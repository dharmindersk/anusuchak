using EmailScheduler.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Portal
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TaskManagement" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TaskManagement.svc or TaskManagement.svc.cs at the Solution Explorer and start debugging.
    public class TaskManagement : ITaskManagement
    {

        public List<Task> GetAllTasks(string apikey)
        {
            var acnt = DatabaseManager.SelectAccountByApiKey(apikey);
            var tasklist = DatabaseManager.SelectAllTasksForAnAccount(acnt.username);
            List<Task> tasks = new List<Task>();
            foreach (var item in tasklist)
            {
                Task task = new Task();
                task.Title = item.title;
                task.TaskType = item.tasktype;
                task.ScheduledTime = item.scheduled_time;
                EmailScheduler.TaskSchedule frequency;
                Enum.TryParse<EmailScheduler.TaskSchedule>(item.frequency, out frequency);
                task.Frequency = frequency;
                task.Status = item.status != "pending";
                task.Attributes = ParseAttributes(DatabaseManager.SelectAllAttributesForATask(item.id));
                tasks.Add(task);
            }

            return tasks;
        }

        public int UpdateAllTasks(List<Task> tasks, string apikey)
        {
            return 0;
        }

        public int DeleteAllTasks(List<Task> tasks, string apikey)
        {
            return 0;
        }

        private static Dictionary<string, string> ParseAttributes(List<EmailScheduler.DAL.Attribute> attributes)
        {
            var attributeDictionary = new Dictionary<string, string>();

            foreach (var attrib in attributes)
            {
                attributeDictionary[attrib.attr_name] = attrib.attr_value;
            }

            return attributeDictionary;
        }

        public Task GetTask(string apikey)
        {
            throw new NotImplementedException();
        }

        public int UpdateTask(Task task, string apikey)
        {
            throw new NotImplementedException();
        }

        public int DeleteTask(Task task, string apikey)
        {
            throw new NotImplementedException();
        }
    }
}
