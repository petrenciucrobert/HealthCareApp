using HealthCareApp.Core.IRepository;
using HealthCareApp.Models;
using HealthCareApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Core.Repository 
{ 
    public class PatientRepository : IPatientRepository
    {
        private readonly AppDbContext _appDbContext;
        public PatientRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Patient> AllPatients
        {
            get
            {
                return _appDbContext.Patients;
            }
        }

        public List<PatientCheckUp> GetAllCheckupDetail(long patientId)
        {
            var checkupDetail = new List<PatientCheckUp>();
                checkupDetail = _appDbContext.PatientCheckup.Where(m => m.PatientId == patientId).ToList();
                   
            return checkupDetail;
        }
        public PatientCheckUp GetCheckupDetail(long patientCheckupId)
        {
            var checkupDetail = new PatientCheckUp();
            checkupDetail = _appDbContext.PatientCheckup.FirstOrDefault(m => m.PatientCheckupId == patientCheckupId);
           

            return checkupDetail;
        }
        public Patient GetPatientById(long PatientId)
        {
            return _appDbContext.Patients.FirstOrDefault(p => p.PatientId == PatientId);
        }

    }
}
