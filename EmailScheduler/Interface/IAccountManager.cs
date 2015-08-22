using EmailScheduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailScheduler.Interface
{
    interface IAccountManager
    {
         UserAccount GetAccountByUserId(long id);
         UserAccount GetAccountByAPIKey(string apikey);
         UserAccount DeleteAccountByUserId(long id);
        //CreateAccount
        //
    }
}
