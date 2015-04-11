using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailScheduler.Model
{
    public class UserContext
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public bool enabled { get; set; }

    }
}
