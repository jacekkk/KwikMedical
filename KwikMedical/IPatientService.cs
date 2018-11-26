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
    public interface IPatientService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, UriTemplate = "/Patients/")]
        List<PatientDataContract> GetAllPatients();

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/Patients/{PatientId}")]
        PatientDataContract GetPatient(string patientId);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, 
            BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/Patients/")]
        string InsertPatient(string FirstName, string LastName, string Address, string InsuranceNumber, 
            string RegionalHospital, string MedicalConditions);
    }
}
