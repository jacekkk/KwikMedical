using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace KwikMedical
{
    [DataContract]
    public class CallOutDataContract
    {
        [DataMember]
        public string CallOutId { get; set; }
        [DataMember]
        public string PatientId { get; set; }
        [DataMember]
        public string HospitalId { get; set; }
        [DataMember]
        public string Date { get; set; }
        [DataMember]
        public string Reason { get; set; }
        [DataMember]
        public string ActionTaken { get; set; }
        [DataMember]
        public string TimeSpent { get; set; }
    }
}