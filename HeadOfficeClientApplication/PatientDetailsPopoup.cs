using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeadOfficeClientApplication.HospitalServiceReference;
using HeadOfficeClientApplication.PatientServiceReference;

namespace HeadOfficeClientApplication
{
    public partial class PatientDetailsPopoup : Form
    {
        private string _patientId;
        private string _hospitalId;

        public PatientDetailsPopoup(PatientDataContract patient)
        {
            InitializeComponent();
            text_patient_first_name.Text = patient.FirstName;
            text_patient_last_name.Text = patient.LastName;
            text_patient_address.Text = patient.Address;
            text_patient_insurance_number.Text = patient.InsuranceNumber;
            text_medical_conditions.Text = patient.MedicalConditions;

            _hospitalId = patient.RegionalHospital;
            _patientId = patient.PatientId;
        }

        void getHospitalDetils(string hospitalId)
        {
            WebClient proxy = new WebClient();
            proxy.DownloadStringAsync(new Uri("http://localhost:60227/HospitalService.svc/Hospitals/" + hospitalId));
            proxy.DownloadStringCompleted += proxy_DownloadStringCompleted;
        }

        void proxy_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Stream stream = new MemoryStream(Encoding.Unicode.GetBytes(e.Result));
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(HospitalDataContract));

            try
            {
                HospitalDataContract result = obj.ReadObject(stream) as HospitalDataContract;
                text_hospital_name.Text = result.Name;
                text_hospital_address.Text = result.Address;
                text_hospital_email.Text = result.Email;
                text_hospital_phone.Text = result.PhoneNumber;
            }
            catch (Exception) { }
        }

        private void button_send_ambulance_request_Click(object sender, EventArgs e)
        {
            var form = new SendAmbulanceForm(_patientId, _hospitalId);
            form.Show(this);           
        }

        private void button_get_hospital_details_Click(object sender, EventArgs e)
        {
            getHospitalDetils(_hospitalId);
        }
    }
}
