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
using HeadOfficeClientApplication.CalloutServiceReference;

namespace HeadOfficeClientApplication
{
    public partial class SendAmbulanceForm : Form
    {
        private string _patientId;
        private string _hospitalId;

        public SendAmbulanceForm(string patientId, string hospitalId)
        {
            InitializeComponent();

            _patientId = patientId;
            _hospitalId = hospitalId;
        }

        private void button_generate_ambulance_request_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient
            {
                Headers = { ["Content-type"] = "application/json" },
                Encoding = Encoding.UTF8
            };

            CallOutDataContract data = new CallOutDataContract
            {
                PatientId = _patientId,
                HospitalId = _hospitalId,
                Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),
                Reason = text_box_request_reason.Text,
                ActionTaken = text_box_request_action.Text,
                TimeSpent = ""
            };

            MemoryStream stream = new MemoryStream();
            StreamReader sr = new StreamReader(stream);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(CallOutDataContract));

            try
            {
                serializer.WriteObject(stream, data);
                stream.Position = 0;
                webClient.UploadString("http://localhost:60227/CallOutService.svc/CallOuts", sr.ReadToEnd());

                button_generate_ambulance_request.Text = "Request sent!";
                button_generate_ambulance_request.Enabled = false;
                text_box_request_reason.Enabled = false;
                text_box_request_action.Enabled = false;
            }
            catch (Exception) { }
        }
    }
}
