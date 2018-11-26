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
    public partial class AmbulanceApp : Form
    {
        public AmbulanceApp()
        {
            InitializeComponent();
        }

        private void button_submit_details_Click(object sender, EventArgs e)
        {
            if (list_recent_call_outs.SelectedItems.Count > 0)
            {
                var form = new SubmitCallOutDetails(list_recent_call_outs.SelectedItems[0]);
                form.Show(this);
            }
        }

        void proxy_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                Stream stream = new MemoryStream(Encoding.Unicode.GetBytes(e.Result));
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<CallOutDataContract>));
                List<CallOutDataContract> result = serializer.ReadObject(stream) as List<CallOutDataContract>;

                foreach (var callOut in result)
                {
                    ListViewItem item = new ListViewItem(callOut.CallOutId) { Name = callOut.CallOutId };
                    item.SubItems.Add(callOut.PatientId);
                    item.SubItems.Add(callOut.HospitalId);
                    item.SubItems.Add(callOut.Date);
                    item.SubItems.Add(callOut.Reason);
                    item.SubItems.Add(callOut.ActionTaken);
                    item.SubItems.Add(callOut.TimeSpent);

                    if (!list_recent_call_outs.Items.ContainsKey(callOut.CallOutId))
                    {
                        list_recent_call_outs.Items.Add(item);
                    }
                    else
                    {                   
                        var lvItem = list_recent_call_outs.Items.Find(callOut.CallOutId, false).First();

                        if (!lvItem.SubItems.Equals(item.SubItems))
                        {
                            for (int i = 0; i < 7; i++)
                            {
                                lvItem.SubItems[i] = item.SubItems[i];
                            }
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void list_recent_call_outs_MouseEnter(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadStringAsync(new Uri("http://localhost:60227/CallOutService.svc/CallOuts/"));
            webClient.DownloadStringCompleted += proxy_DownloadStringCompleted;
        }
    }
}
