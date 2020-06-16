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
        //IEnumerable<PatientCheckUp> GetAllCheckupDetail(long patientId);
        public List<PatientCheckUp> GetAllCheckupDetail(long patientId);
        public PatientCheckUp GetCheckupDetail(long patientCheckupId);
        //public List<PrescriptionDetail> GetAllPrescriptionDetail(long patientId);
        //public Prescription GetPrescriptionDetailByCheckupId(long patientCheckupId);

        //public long SaveCheckupDetail(PatientCheckUpViewModel patientCheckupVM);


    }
}
