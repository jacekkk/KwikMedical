using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace KwikMedical
{
    [DataContract]
    public class PatientDataContract
    {
        [DataMember]
        public string PatientId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string InsuranceNumber { get; set; }
        [DataMember]
        public string RegionalHospital { get; set; }
        [DataMember]
        public string MedicalConditions { get; set; }
    }
}