using EmailScheduler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailScheduler
{
    public class TaskDBProvider : ITaskProvider
    {
        public List<ITask> SelectTasksByUserId(string username)
        {
            throw new NotImplementedException();
        }

        public ITask GetTaskById(long id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTaskById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
