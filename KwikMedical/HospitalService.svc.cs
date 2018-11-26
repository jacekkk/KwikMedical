using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using KwikMedical.Model;

namespace KwikMedical
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HospitalService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HospitalService.svc or HospitalService.svc.cs at the Solution Explorer and start debugging.
    public class HospitalService : IHospitalService
    {
        private kwik_medicalEntities _dbConnection;

        public HospitalService()
        {
            _dbConnection = new kwik_medicalEntities();
        }

        public List<HospitalDataContract> GetAllHospitals()
        {
            var query = (from allHospitals in _dbConnection.regional_hospitals
                    select allHospitals)
                .Distinct();

            List<HospitalDataContract> hospitalsList = new List<HospitalDataContract>();

            query.ToList().ForEach(result =>
            {
                hospitalsList.Add(new HospitalDataContract
                {
                    HospitalId = Convert.ToString(result.id),
                    Name = result.hospital_name,
                    Address = result.address,
                    Email = result.email,
                    PhoneNumber = Convert.ToString(result.phone_number)
                });
            });

            return hospitalsList;
        }

        public HospitalDataContract GetHospital(string hospitalId)
        {
            HospitalDataContract hospital = new HospitalDataContract();

            try
            {
                var query = (from tableRow in _dbConnection.regional_hospitals
                        where tableRow.id.ToString().Equals(hospitalId)
                        select tableRow)
                    .Distinct()
                    .FirstOrDefault();

                hospital.HospitalId = Convert.ToString(query.id);
                hospital.Name = query.hospital_name;
                hospital.Address = query.address;
                hospital.Email = query.email;
                hospital.PhoneNumber = Convert.ToString(query.phone_number);
            }
            catch (Exception) { }

            return hospital;
        }
    }
}
