using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KwikMedical
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHospitalService" in both code and config file together.
    [ServiceContract]
    public interface IHospitalService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, UriTemplate = "/Hospitals/")]
        List<HospitalDataContract> GetAllHospitals();

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/Hospitals/{HospitalId}")]
        HospitalDataContract GetHospital(string hospitalId);
    }
}
