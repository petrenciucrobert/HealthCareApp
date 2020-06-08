using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
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

        public Patient GetPatientById(int PatientId)
        {
            return _appDbContext.Patients.FirstOrDefault(p => p.PatientId == PatientId);
        }
    }
}
