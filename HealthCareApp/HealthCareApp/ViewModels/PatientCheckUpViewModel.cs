using HealthCareApp.Core.IRepository;
using HealthCareApp.Core.Repository;
using HealthCareApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.ViewModels
{
    public class PatientCheckUpViewModel
    {
        public PatientCheckUpViewModel()
        {
            this.PatientCheckup = new PatientCheckUp();

            //this.Doctors = Doctors.AllDoctors();

            List<Treatment> TreatmentList = new List<Treatment>();
            TreatmentList.Add(new Treatment() { TreatmentId = 1, TreatmentName = "Treatment1" });
            TreatmentList.Add(new Treatment() { TreatmentId = 2, TreatmentName = "Treatment2" });
            TreatmentList.Add(new Treatment() { TreatmentId = 3, TreatmentName = "Treatment3" });
            TreatmentList.Add(new Treatment() { TreatmentId = 4, TreatmentName = "Treatment4" });
            this.Treatments = TreatmentList;

            //List<Medicine> MedicineList = new List<Medicine>();
            //MedicineList.Add(new Medicine() { MedicineId = 1, MedicineName = "Medicine 1" });
            //MedicineList.Add(new Medicine() { MedicineId = 2, MedicineName = "Medicine 2" });
            //MedicineList.Add(new Medicine() { MedicineId = 3, MedicineName = "Medicine 3" });
            //MedicineList.Add(new Medicine() { MedicineId = 4, MedicineName = "Medicine 4" });
            //this.Medicines = MedicineList;
        }
        public PatientCheckUp PatientCheckup { get; set; }
        //public List<Doctor> Doctors { get; set; }
        public DoctorRepository  Doctors { get; set; }
        public List<Treatment> Treatments { get; set; }

        //public List<Medicine> Medicines { get; set; }
    }
}
