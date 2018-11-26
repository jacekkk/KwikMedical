using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeadOfficeClientApplication.PatientServiceReference;

namespace HeadOfficeClientApplication
{
    public partial class HeadOfficeApp : Form
    {
        public HeadOfficeApp()
        {
            InitializeComponent();
        }

        
        void proxy_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Stream stream = new MemoryStream(Encoding.Unicode.GetBytes(e.Result));
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<PatientDataContract>));

            try
            {
                List<PatientDataContract> result = obj.ReadObject(stream) as List<PatientDataContract>;

                foreach (var patient in result)
                {
                    if (patient.InsuranceNumber.Equals(text_box_insurance_number.Text))
                    {
                        var form = new PatientDetailsPopoup(patient);
                        form.Show(this);
                    }
                }
            }
            catch (Exception) { }       
        }

        private void button_find_patient_Click(object sender, EventArgs e)
        {
            WebClient proxy = new WebClient();
            proxy.DownloadStringAsync(new Uri("http://localhost:60227/PatientService.svc/Patients/"));
            proxy.DownloadStringCompleted += proxy_DownloadStringCompleted;
        }
    }
}
