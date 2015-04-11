using EmailScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Portal
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITaskManagement" in both code and config file together.
    [ServiceContract]
    public interface ITaskManagement
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/GetAllTasks/{apikey}", Method = "GET", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<Task> GetAllTasks(string apikey);

        [OperationContract]
        [WebInvoke(UriTemplate = "/UpdateAllTasks/{apikey}", Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int UpdateAllTasks(List<Task> tasks, string apikey);

        [OperationContract]
        [WebInvoke(UriTemplate = "/DeleteAllTasks/{apikey}", Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int DeleteAllTasks(List<Task> tasks, string apikey);

        [OperationContract]
        [WebInvoke(UriTemplate = "/GetTask/{apikey}", Method = "GET", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        Task GetTask(string apikey);

        [OperationContract]
        [WebInvoke(UriTemplate = "/UpdateTask/{apikey}", Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int UpdateTask(Task task, string apikey);

        [OperationContract]
        [WebInvoke(UriTemplate = "/DeleteTask/{apikey}", Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int DeleteTask(Task task, string apikey);
    }

    [DataContract]
    public class Task
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public bool Status { get; set; }
        [DataMember]
        public string TaskType { get; set; }
        [DataMember]
        public DateTime ScheduledTime { get; set; }
        [DataMember]
        public TaskSchedule Frequency { get; set; }
        [DataMember]
        public Dictionary<string, string> Attributes { get; set; }
    }
}
