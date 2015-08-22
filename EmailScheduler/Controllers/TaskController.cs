using EmailScheduler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailScheduler
{
    public class TaskController:ITaskController
    {

          //task.InitialiseTask(dbtask);
          //task.InitialisePrincipal(dbaccount);
          //task.Attributes = ParseAttributes(attributes);


        public List<ITask> GetTasks()
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
