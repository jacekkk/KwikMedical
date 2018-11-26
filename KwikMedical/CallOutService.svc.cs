using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using KwikMedical.Model;

namespace KwikMedical
{
    public class CallOutService : ICallOutService
    {
        private kwik_medicalEntities _dbConnection;

        public CallOutService()
        {
            _dbConnection = new kwik_medicalEntities();
        }

        public List<CallOutDataContract> GetAllCallOuts()
        {
            var query = (from allCallOuts in _dbConnection.call_outs
                    select allCallOuts)
                .Distinct();

            List<CallOutDataContract> callOutList = new List<CallOutDataContract>();

            query.ToList().ForEach(result =>
            {
                callOutList.Add(new CallOutDataContract
                {
                    CallOutId = Convert.ToString(result.id),
                    PatientId = Convert.ToString(result.patient_id),
                    HospitalId = Convert.ToString(result.hospital_id),
                    Date = result.date,
                    Reason = result.reason,
                    ActionTaken = result.action_taken,
                    TimeSpent = result.time_spent
                });
            });

            return callOutList;
        }

        public CallOutDataContract GetCallOut(string callOutId)
        {
            CallOutDataContract callOut = new CallOutDataContract();

            try
            {
                var query = (from tableRow in _dbConnection.call_outs
                        where tableRow.id.ToString().Equals(callOutId)
                        select tableRow)
                    .Distinct()
                    .FirstOrDefault();

                callOut.CallOutId = Convert.ToString(query.id);
                callOut.PatientId = Convert.ToString(query.patient_id);
                callOut.HospitalId = Convert.ToString(query.hospital_id);
                callOut.Date = query.date;
                callOut.Reason = query.reason;
                callOut.ActionTaken = query.action_taken;
                callOut.TimeSpent = query.time_spent;
            }
            catch (Exception) { }

            return callOut;
        }

        public string InsertCallOut(string PatientId, string HospitalId, string Date, string Reason, string ActionTaken, string TimeSpent)
        {
            try
            {
                var callOut = new call_outs
                {
                    patient_id = Convert.ToInt32(PatientId),
                    hospital_id = Convert.ToInt32(HospitalId),
                    date = Date,
                    reason = Reason,
                    action_taken = ActionTaken,
                    time_spent = TimeSpent
                };

                _dbConnection.call_outs.Add(callOut);
                _dbConnection.SaveChanges();

                return $"Call-out added successfully. Call-out ID is {callOut.id}";
            }
            catch (Exception)
            {
                return "Unable to add call-out";
            }
        }

        public string UpdateCallOut(string CallOutId, string PatientId, string HospitalId, string Date, string Reason, string ActionTaken, string TimeSpent)
        {
            try
            {
                var callOut = new call_outs
                {
                    id = Convert.ToInt32(CallOutId),
                    patient_id = Convert.ToInt32(PatientId),
                    hospital_id = Convert.ToInt32(HospitalId),
                    date = Date,
                    reason = Reason,
                    action_taken = ActionTaken,
                    time_spent = TimeSpent
                };

                _dbConnection.call_outs.AddOrUpdate(callOut);
                _dbConnection.SaveChanges();

                return $"Call-out updated successfully. Call-out ID is {callOut.id}";
            }
            catch (Exception)
            {
                return "Unable to update call-out";
            }
        }
    }
}
