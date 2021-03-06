﻿using EmailScheduler.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Xml;
using Utility;

namespace EmailScheduler
{
    public partial class Scheduler : ServiceBase
    {
        private static ManualResetEvent doneEvent;
        private static string configPath = string.Empty;
        private static int numBusy;
        private const string DATE_FORMAT_STRING = "MM/dd/yyyy HH:mm";
        private static Assembly tasksAssembly;
        readonly System.Timers.Timer _timer = new System.Timers.Timer();
        private static bool workInProgress;

        public Scheduler()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                Logger.Info("Mail Scheduler Service Started");
                LoadTasksAssembly();
                _timer.Interval = ConfigurationManager.AppSettings["Interval"] == null ? 6000 : double.Parse(ConfigurationManager.AppSettings["Interval"]);
                _timer.Elapsed += RunTasksForEachAccount;
                _timer.Start();
            }
            catch (Exception ex)
            {
                Logger.Error("Error occurred OnStart " + ex.Message);
            }
        }

        protected override void OnStop()
        {
            Logger.Info("MailScheduler service stopped");
        }

        private static void RunTasksForEachAccount(object sender, ElapsedEventArgs args)
        {
            try
            {
                //If the processing of RunTasks lasts longer than the Timer's interval, RunTasks could be called  
                //again before the previous call finished. To overcome this, using a bool variable workInProgress to track if this method is in progress  
                //If not, go ahead else return   
                if (workInProgress) return;

                numBusy = 0;
                doneEvent = new ManualResetEvent(false);

                var allUsers = DatabaseManager.SelectAllAccount();
                Logger.Info("no of users : " + allUsers.Count);
                foreach (var user in allUsers)
                {
                    if (!user.enabled) continue;
                    Logger.Info("Getting tasks for: " + user.username);
                    List<ITask> tasksList = GetTasksToRun(user.username);
                    //Logger.Info("All tasks loaded: " + tasksList.Count);
                    numBusy = tasksList.Count; //Number of threads to create is not constant, depends on the tasks ready to run at a given time  
                    if (numBusy > 0)
                    {
                        workInProgress = true;
                        foreach (ITask task in tasksList)
                        {
                            ThreadPool.QueueUserWorkItem(DoTask, task);
                        }
                        doneEvent.WaitOne();
                    }
                    //All scheduled tasks completed, persist the tasks data to disk,iteration over  
                    if (numBusy == 0 && tasksList.Count > 0)
                    {
                        workInProgress = false;
                    }

                }
            }
            catch (Exception ex)
            {
                Logger.Error("error running task" + ex);
            }
        }

        private static void DoTask(object o)
        {
            ITask task = o as ITask;
            if (task == null) return;
            try
            {
                //Event Log, starting task at this time.  
                task.RunTask();
                task.UpdateNextRuntime();
                DatabaseManager.UpdateTasks(task);
                //Task completed successfuly at this time  

            }
            catch (Exception ex)
            {
                Logger.Error("Stack Trace is: " + ex.Message);
            }
            finally
            {
                if (Interlocked.Decrement(ref numBusy) == 0)
                {
                    doneEvent.Set();
                }
            }
        }

        private static List<ITask> GetTasksToRun(string owner)
        {
            List<ITask> tasks = new List<ITask>();
            try
            {


                var allTasks = DatabaseManager.SelectAllTasksForAnAccount(owner);
                var dbaccount = DatabaseManager.SelectSingleAccount(owner);
                foreach (var dbtask in allTasks)
                {
                    var attributes = DatabaseManager.SelectAllAttributesForATask(dbtask.id);
                    ITask task = CreateTaskInstance(dbtask.tasktype);
                    task.InitialiseTask(dbtask);
                    task.InitialisePrincipal(dbaccount);
                    task.Attributes = ParseAttributes(attributes);
                    if (task != null)
                    {
                        //initialise Task with attributes and then add
                        if (DateTime.Now < task.ScheduledTime || task.Status.Equals("completed", StringComparison.OrdinalIgnoreCase)) continue;
                        tasks.Add(task);
                    }
                }
                Logger.Info("no of tasks added" + tasks.Count);
            }
            catch (Exception ex)
            {
                Logger.Info("error" + ex);
                throw;
            }
            return tasks;
        }

        private static Dictionary<string, string> ParseAttributes(List<DAL.Attribute> attributes)
        {
            var attributeDictionary = new Dictionary<string, string>();

            foreach (var attrib in attributes)
            {
                attributeDictionary[attrib.attr_name] = attrib.attr_value;
            }

            return attributeDictionary;
        }

        private static ITask CreateTaskInstance(string taskName)
        {
            try
            {
                if (tasksAssembly == null)
                    throw new Exception("Tasks Assembly is null, cannot proceed further..");
                //Create an instance of the task  
                ITask task = (ITask)tasksAssembly.CreateInstance(taskName, true);
                return task;
            }
            catch (Exception ex)
            {
                Logger.Error("Error occurred while creating Task Instance " + ex.Message);
            }
            return null;
        }

        private static void LoadTasksAssembly()
        {
            try
            {
                if (tasksAssembly == null)
                    tasksAssembly = Assembly.GetAssembly(typeof(ITask));
            }
            catch (Exception ex)
            {
                Logger.Error("Error occurred while loading tasks Assembly " + ex.Message);
                throw;
            }
        }

    }
}
