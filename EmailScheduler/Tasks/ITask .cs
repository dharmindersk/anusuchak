using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailScheduler.Model;

namespace EmailScheduler
{
    public interface ITask
    {
        long Id { get; set; }
        string Title { get; set; }
        string Status { get; set; }
        string TaskType { get; set; }

        UserContext UserInfo { get; set; }
        DateTime ScheduledTime { get; set; }
        TaskSchedule Frequency { get; set; }
        Dictionary<string, string> Attributes { get; set; }

        void RunTask();
        void UpdateNextRuntime();
        void InitialiseTask(DAL.Task task);
        void InitialisePrincipal(DAL.Account account);
    }

    public enum TaskSchedule
    {
        Once = 0,
        Hourly = 1,
        Daily = 2,
        Weekly = 3,
        Monthly = 4,
    }
}
