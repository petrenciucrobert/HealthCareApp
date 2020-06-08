using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class Prescription
    {
        public long PrescriptionId { get; set; }
        public long PatientCheckupId { get; set; }
        public long PatientId { get; set; }
        public long TreatmentId { get; set; }
        public string CaseHistory { get; set; }
        public string ExtraNotes { get; set; }
        public DateTime PrescriptionDate { get; set; }

        [Display(Name = "Medication")]
        public List<PrescriptionDetail> MedicineList { get; set; }
    }
}
