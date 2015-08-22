using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailScheduler.Interface
{
    interface ITaskController
    {
        List<ITask> GetTasks();
        ITask GetTaskById(long id);
        bool UpdateTaskById(long id);
    }
}
