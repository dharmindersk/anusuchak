using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Portal
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuthManagement" in both code and config file together.
    [ServiceContract]
    public interface IAuthManagement
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/Authenticate", Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        string Authenticate(AuthContext ctxt);

        [OperationContract]
        [WebInvoke(UriTemplate = "/CreateAccount", Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        string CreateAccount(AuthContext ctxt);
    }

    [DataContract]
    public class AuthContext
    {
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string SecretKey { get; set; }
    }
}
