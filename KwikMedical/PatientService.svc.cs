using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using KwikMedical.Model;
using MySql.Data.MySqlClient;

namespace KwikMedical
{   
    public class PatientService : IPatientService
    {
        private kwik_medicalEntities _dbConnection;

        public PatientService()
        {
            _dbConnection = new kwik_medicalEntities();
        }

        public List<PatientDataContract> GetAllPatients()
        {
            var query = (from allPatients in _dbConnection.patients
                         select allPatients)
                         .Distinct();

            List<PatientDataContract> patientsList = new List<PatientDataContract>();

            query.ToList().ForEach(result =>
            {
                patientsList.Add(new PatientDataContract
                {
                    PatientId = Convert.ToString(result.id),
                    FirstName = result.first_name,
                    LastName = result.last_name,
                    Address = result.address,
                    InsuranceNumber = result.insurance_number,
                    RegionalHospital = Convert.ToString(result.regional_hospital_id),
                    MedicalConditions = result.medical_conditions
                });
            });

            return patientsList;
        }

        public PatientDataContract GetPatient(string patientId)
        {
            PatientDataContract patient = new PatientDataContract();

            try
            {
                var query = (from tableRow in _dbConnection.patients
                             where tableRow.id.ToString().Equals(patientId)
                             select tableRow)
                             .Distinct()
                             .FirstOrDefault();           

                patient.PatientId = Convert.ToString(query.id);
                patient.FirstName = query.first_name;
                patient.LastName = query.last_name;
                patient.Address = query.address;
                patient.InsuranceNumber = query.insurance_number;
                patient.RegionalHospital = Convert.ToString(query.regional_hospital_id);
                patient.MedicalConditions = query.medical_conditions;
            }
            catch (Exception) { }

            return patient;
        }

        public string InsertPatient(string FirstName, string LastName, string Address, string InsuranceNumber, string RegionalHospital, string MedicalConditions)
        {
            try
            {
                var patient = new patient
                {
                    first_name = FirstName,
                    last_name = LastName,
                    address = Address,
                    insurance_number = InsuranceNumber,
                    regional_hospital_id = Convert.ToInt32(RegionalHospital),
                    medical_conditions = MedicalConditions
                };

                _dbConnection.patients.Add(patient);
                _dbConnection.SaveChanges();

                return $"Patient {patient.first_name} {patient.last_name} added successfully. Patient ID is {patient.id}";
            }
            catch (Exception)
            {
                return "Unable to add patient";
            }
        }
    }
}
