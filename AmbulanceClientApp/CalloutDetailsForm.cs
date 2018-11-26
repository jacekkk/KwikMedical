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
using AmbulanceClientApp.CalloutServiceReference;

namespace AmbulanceClientApp
{
    public partial class SubmitCallOutDetails : Form
    {
        public SubmitCallOutDetails(ListViewItem selectedCallOut)
        {
            InitializeComponent();
            text_box_callout_id.Text = selectedCallOut.SubItems[0].Text;
            text_box_patient_id.Text = selectedCallOut.SubItems[1].Text;
            text_box_hospital_id.Text = selectedCallOut.SubItems[2].Text;
            text_box_date.Text = selectedCallOut.SubItems[3].Text;
            text_box_reason.Text = selectedCallOut.SubItems[4].Text;
            text_box_action_taken.Text = selectedCallOut.SubItems[5].Text;
            text_box_time_spent.Text = selectedCallOut.SubItems[6].Text;
        }

        private void button_submit_details_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient
            {
                Headers = { ["Content-type"] = "application/json" },
                Encoding = Encoding.UTF8
            };

            CallOutDataContract data = new CallOutDataContract
            {
                CallOutId = text_box_callout_id.Text,
                PatientId = text_box_patient_id.Text,
                HospitalId = text_box_hospital_id.Text,
                Date = text_box_date.Text,
                Reason = text_box_reason.Text,
                ActionTaken = text_box_action_taken.Text,
                TimeSpent = text_box_time_spent.Text
            };

            MemoryStream stream = new MemoryStream();
            StreamReader sr = new StreamReader(stream);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(CallOutDataContract));

            try
            {
                serializer.WriteObject(stream, data);
                stream.Position = 0;
                webClient.UploadString("http://localhost:60227/CallOutService.svc/CallOuts/" + data.CallOutId, "PUT", sr.ReadToEnd());

                button_submit_details.Text = "Details submitted!";
                button_submit_details.Enabled = false;
                text_box_date.Enabled = false;
                text_box_reason.Enabled = false;
                text_box_action_taken.Enabled = false;
                text_box_time_spent.Enabled = false;
            }
            catch (WebException ex)
            {
                Console.Write(ex.ToString());
            }           
        }
    }
}
