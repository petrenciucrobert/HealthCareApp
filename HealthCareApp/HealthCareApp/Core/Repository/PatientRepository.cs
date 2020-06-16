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
           // var prescription = new List<PrescriptionDetail>();
            
                checkupDetail = _appDbContext.PatientCheckup.Where(m => m.PatientId == patientId).ToList();
                   
               // prescription = GetAllPrescriptionDetail(patientId);

                //foreach (var c in checkupDetail)
                //{
                //    c.Prescription = prescription.Find(p => p.PatientId == c.PatientId);
                //}
            

            return checkupDetail;
        }
        public PatientCheckUp GetCheckupDetail(long patientCheckupId)
        {
            var checkupDetail = new PatientCheckUp();
            //var prescription = new Prescription();
            checkupDetail = _appDbContext.PatientCheckup.FirstOrDefault(m => m.PatientCheckupId == patientCheckupId);
            //prescription = GetPrescriptionDetailByCheckupId(patientCheckupId);
            //checkupDetail.Prescription = prescription;

            return checkupDetail;
        }
        //public  List<PrescriptionDetail> GetAllPrescriptionDetail(long patientId)
        //{
        //    var prescriptionDetail = new List<PrescriptionDetail>();
        //    prescriptionDetail= _appDbContext.PrescriptionDetail.Where(m => m.PatientId == patientId).ToList();

        //    return prescriptionDetail;


        //}

        //public  Prescription GetPrescriptionDetailByCheckupId(long patientCheckupId)
        //{
        //    return _appDbContext.Prescription.FirstOrDefault(m => m.PatientCheckupId == patientCheckupId);
            
        //}

        public Patient GetPatientById(long PatientId)
        {
            return _appDbContext.Patients.FirstOrDefault(p => p.PatientId == PatientId);
        }

        //public long SaveCheckupDetail(PatientCheckUpViewModel patientCheckupVM)
        //{
           
        //}
    }
}
