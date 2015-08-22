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
        TaskState State { get; set; }
        string TaskType { get; set; }

        UserAccount UserInfo { get; set; }
        DateTime ScheduledTime { get; set; }
        TaskSchedule Frequency { get; set; }
        Dictionary<string, string> Attributes { get; set; }

        bool Run();
        void UpdateNextRuntime();
        void InitialiseTask(DAL.Task task);
        void UpdateState(TaskState taskState);
        void SaveTask();
    }

    public enum TaskSchedule
    {
        Once = 0,
        Hourly = 1,
        Daily = 2,
        Weekly = 3,
        Monthly = 4,
    }
    public enum TaskState
    {
        New = 0,
        Active = 1,
        Pending = 2,
        Complete = 3,
    }
}
