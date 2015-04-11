using EmailScheduler.DAL;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Utility;

namespace EmailScheduler.Tasks
{
    public class BasicEmailTask : ITask
    {
        public long Id { get; set; }

        public string Title { get; set; }
        public string Status { get; set; }
        public Model.UserContext UserInfo { get; set; }
        public DateTime ScheduledTime { get; set; }
        public TaskSchedule Frequency { get; set; }
        public string TaskType { get; set; }

        public Dictionary<string, string> Attributes { get; set; }

        public void InitialiseTask(DAL.Task Task)
        {
            this.Id = Task.id;
            this.Title = Task.title;
            this.Status = Task.status;
            this.ScheduledTime = Task.scheduled_time;
            this.TaskType = Task.tasktype;
            this.Frequency = (TaskSchedule)Enum.Parse(typeof(TaskSchedule), Task.frequency, true);
        }

        public void InitialisePrincipal(DAL.Account account)
        {
            this.UserInfo = new Model.UserContext();
            this.UserInfo.email = account.email;
            this.UserInfo.enabled = account.enabled;
            this.UserInfo.password = account.password;
            this.UserInfo.username = account.username;
        }

        public void RunTask()
        {
            try
            {
                Logger.Info("Running Task: " + Title);
                var email_message = Attributes.Where(x => x.Key.Equals("email_message", StringComparison.OrdinalIgnoreCase)).SingleOrDefault().Value;
                var recipientTo = Attributes.Where(x => x.Key.Equals("recipientTo", StringComparison.OrdinalIgnoreCase)).SingleOrDefault().Value;
                if (string.IsNullOrEmpty(recipientTo))
                    recipientTo = UserInfo.email;
                // var recipientCC = Attributes.Where(x => x.Key.Equals("recipientCC", StringComparison.OrdinalIgnoreCase)).SingleOrDefault().Value;
                eMailer.SendEmail(recipientTo, Title, email_message, true);
            }
            catch (Exception ex)
            {
                Logger.Error("Error while running task : " + ex);
            }
        }

        public void UpdateNextRuntime()
        {
            var scheduledTime = DateTime.Now;
            switch (Frequency)
            {
                case TaskSchedule.Hourly:
                    ScheduledTime = scheduledTime.AddHours(1);
                    break;
                case TaskSchedule.Daily:
                    ScheduledTime = scheduledTime.AddDays(1);
                    break;
                case TaskSchedule.Weekly:
                    ScheduledTime = scheduledTime.AddDays(7);
                    break;
                case TaskSchedule.Monthly:
                    ScheduledTime = scheduledTime.AddMonths(1);
                    break;
                case TaskSchedule.Once:
                    ScheduledTime = scheduledTime;
                    Status = "completed";
                    break;
            }
        }
    }
}
