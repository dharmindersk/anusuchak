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
        public TaskState State { get; set; }
        public Model.UserAccount UserInfo { get; set; }
        public DateTime ScheduledTime { get; set; }
        public TaskSchedule Frequency { get; set; }
        public string TaskType { get; set; }
        public Dictionary<string, string> Attributes { get; set; }

        public void InitialiseTask(DAL.Task Task)
        {
            this.Id = Task.id;
            this.Title = Task.title;
            //   this.Status = Task.status;
            this.ScheduledTime = Task.scheduled_time;
            this.TaskType = Task.tasktype;
            this.Frequency = (TaskSchedule)Enum.Parse(typeof(TaskSchedule), Task.frequency, true);
        }

        public bool Run()
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
                UpdateNextRuntime();
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error("Error while running task : " + ex);
                return false;
            }
        }

        public void UpdateNextRuntime()
        {
            switch (Frequency)
            {
                case TaskSchedule.Hourly:
                    ScheduledTime = ScheduledTime.AddHours(1);
                    UpdateState(TaskState.New);
                    break;
                case TaskSchedule.Daily:
                    ScheduledTime = ScheduledTime.AddDays(1);
                    UpdateState(TaskState.New);
                    break;
                case TaskSchedule.Weekly:
                    ScheduledTime = ScheduledTime.AddDays(7);
                    UpdateState(TaskState.New);
                    break;
                case TaskSchedule.Monthly:
                    ScheduledTime = ScheduledTime.AddMonths(1);
                    UpdateState(TaskState.New);
                    break;
                case TaskSchedule.Once:
                    ScheduledTime = ScheduledTime;
                    UpdateState(TaskState.Complete);
                    break;
            }
        }

        public void UpdateState(TaskState taskState)
        {
            State = taskState;
        }

        public void SaveTask()
        {
            throw new NotImplementedException();
        }
    }
}
