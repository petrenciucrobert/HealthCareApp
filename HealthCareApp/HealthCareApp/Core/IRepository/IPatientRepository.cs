using HealthCareApp.Models;
using HealthCareApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Core.IRepository
{ 
    public interface IPatientRepository
    {
        IEnumerable<Patient> AllPatients { get; }
        Patient GetPatientById(long PatientId);
        public List<PatientCheckUp> GetAllCheckupDetail(long patientId);
        public PatientCheckUp GetCheckupDetail(long patientCheckupId);


    }
}
