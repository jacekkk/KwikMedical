using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KwikMedical
{
    [ServiceContract]
    public interface ICallOutService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, UriTemplate = "/CallOuts/")]
        List<CallOutDataContract> GetAllCallOuts();

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/CallOuts/{CallOutId}")]
        CallOutDataContract GetCallOut(string callOutId);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/CallOuts/")]
        string InsertCallOut(string PatientId, string HospitalId, string Date, string Reason, string ActionTaken, string TimeSpent);

        [OperationContract]
        [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/CallOuts/{CallOutId}")]
        string UpdateCallOut(string CallOutId, string PatientId, string HospitalId, string Date, string Reason, string ActionTaken, string TimeSpent);
    }
}
