using EmailScheduler.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using Utility;

namespace EmailScheduler.DAL
{
    public static class DatabaseManager
    {
        private static string CONNECTIONSTRING = ConfigurationManager.ConnectionStrings["AnusuchakDB"].ConnectionString;

        //public static DAL.Account SelectSingleAccount(string owner)
        //{
        //    DAL.Account acnt = new DAL.Account();
        //    using (var context = new SchedulerTasksDataContext(CONNECTIONSTRING))
        //    {
        //        var results = context.spSelectSingleAccount(owner);
        //        foreach (var dbacnt in results)
        //        {
        //            acnt.username = dbacnt.username;
        //            acnt.email = dbacnt.email;
        //            acnt.enabled = dbacnt.enabled;
        //            acnt.password = dbacnt.password;
        //            acnt.id = dbacnt.id;
        //            break;
        //        }
        //    }
        //    return acnt;
        //}

        //public static DAL.Account SelectAccountByApiKey(string apikey)
        //{
        //    DAL.Account acnt = new DAL.Account();
        //    using (var context = new SchedulerTasksDataContext(CONNECTIONSTRING))
        //    {
        //        var results = context.spSelectAccountByApiKey(apikey);
        //        foreach (var dbacnt in results)
        //        {
        //            acnt.username = dbacnt.username;
        //            acnt.email = dbacnt.email;
        //            acnt.enabled = dbacnt.enabled;
        //            acnt.password = dbacnt.password;
        //            acnt.id = dbacnt.id;
        //            break;
        //        }
        //    }
        //    return acnt;
        //}

        //public static List<DAL.Account> SelectAllAccount()
        //{
        //    List<DAL.Account> accounts = new List<Account>();
        //    using (var context = new SchedulerTasksDataContext(CONNECTIONSTRING))
        //    {
        //        var results = context.spSelectAllAccount();

        //        foreach (var item in results)
        //        {
        //            DAL.Account acnt = new Account();
        //            acnt.username = item.username;
        //            acnt.password = item.password;
        //            acnt.enabled = item.enabled;
        //            acnt.id = item.id;
        //            accounts.Add(acnt);
        //        }

        //    }
        //    return accounts;
        //}

        //public static List<DAL.Task> SelectAllTasksForAnAccount(string owner)
        //{
        //    List<DAL.Task> tasks = new List<Task>();
        //    using (var context = new SchedulerTasksDataContext(CONNECTIONSTRING))
        //    {
        //        var results = context.spSelectByTasksOwner(owner);
        //        foreach (var item in results)
        //        {
        //            DAL.Task task = new Task();
        //            task.id = item.id;
        //            task.owner = item.owner;
        //            task.tasktype = item.tasktype;
        //            task.title = item.title;
        //            task.scheduled_time = item.scheduled_time;
        //            task.frequency = item.frequency;
        //            task.status = item.status;
        //            tasks.Add(task);
        //        }
        //    }
        //    return tasks;
        //}

        //public static List<DAL.Attribute> SelectAllAttributesForATask(long id)
        //{
        //    List<DAL.Attribute> attributes = new List<Attribute>();

        //    using (var context = new SchedulerTasksDataContext(CONNECTIONSTRING))
        //    {
        //        var results = context.spSelectByAttributesTask_id(id);
        //        foreach (var item in results)
        //        {
        //            DAL.Attribute attrib = new DAL.Attribute();
        //            attrib.attr_name = item.attr_name;
        //            attrib.attr_value = item.attr_value;
        //            attrib.task_id = item.task_id;
        //            attributes.Add(attrib);
        //        }
        //    }

        //    return attributes;
        //}

        ////public static void UpdateTasks(ITask task)
        ////{
        ////    using (var context = new SchedulerTasksDataContext(CONNECTIONSTRING))
        ////    {
        ////        var results = context.spUpdateTasks(task.Id, task.UserInfo.username, task.TaskType, task.Title, task.State, task.ScheduledTime, task.Frequency.ToString());
        ////    }
        ////}

        //public static void InsertAccount(Account user)
        //{
        //    using (var context = new SchedulerTasksDataContext(CONNECTIONSTRING))
        //    {
        //        context.spInsertAccount(user.username, user.password, user.email, user.enabled);
        //    }
        //}

        //public static string CreateSession(string username, string secretkey)
        //{
        //    //delete any old session
        //    //recreate new
        //    var token = Guid.NewGuid().ToString();
        //    using (var context = new SchedulerTasksDataContext(CONNECTIONSTRING))
        //    {
        //        context.spDeleteUserSession(username);
        //        context.spCreateUserSession(username, secretkey, token);
        //    }
        //    return token;
        //}
    }
}
