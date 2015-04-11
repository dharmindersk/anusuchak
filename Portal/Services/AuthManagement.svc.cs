using EmailScheduler.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Portal
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuthManagement" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuthManagement.svc or AuthManagement.svc.cs at the Solution Explorer and start debugging.
    public class AuthManagement : IAuthManagement
    {
        public string Authenticate(AuthContext ctxt)
        {
            string token = string.Empty;
            var accnt = DatabaseManager.SelectSingleAccount(ctxt.Username);
            if (accnt != null)
            {
                bool IsValid = AuthenticateCredential(ctxt, accnt);
                if (IsValid)
                    token = DatabaseManager.CreateSession(ctxt.Username, ctxt.SecretKey);
            }
            return token;
        }

        public string CreateAccount(AuthContext ctxt)
        {
            string token = string.Empty;
            var alreadyPresent = DatabaseManager.SelectSingleAccount(ctxt.Username);
            if (alreadyPresent == null)
            {
                DatabaseManager.InsertAccount(new EmailScheduler.Model.UserContext
                {
                    email = ctxt.Email,
                    enabled = true,
                    password = CalculateMD5Hash(ctxt.Password).ToString(),
                    username = ctxt.Username
                });
                token = DatabaseManager.CreateSession(ctxt.Username, ctxt.SecretKey);
            }
            return token;
        }

        private bool AuthenticateCredential(AuthContext ctxt, EmailScheduler.DAL.Account accnt)
        {
            var check = ctxt.Username.Equals(accnt.username, StringComparison.OrdinalIgnoreCase)
                         && CalculateMD5Hash(ctxt.Password).ToString().Equals(accnt.password, StringComparison.OrdinalIgnoreCase);
            //if suername is same
            //if hash of password == db password
            return check;
        }

        private Guid CalculateMD5Hash(string input)
        {
            using (var algo = System.Security.Cryptography.RIPEMD160Managed.Create("password"))
            {
                byte[] inputBytes = System.Text.UTF8Encoding.ASCII.GetBytes(input);
                byte[] hash = algo.ComputeHash(inputBytes);
                return new Guid(hash);
            }
        }
    }
}
