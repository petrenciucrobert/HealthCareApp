using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class PrescriptionDetail
    {
        public long PrescriptionDetailId { get; set; }
        public long PrescriptionId { get; set; }
        public long PatientId { get; set; }

        [Required]
        public long MedicineId { get; set; }

        public string MedicineName { get; set; }
        [Required]
        public int NoOfDays { get; set; }

        [Required]
        public string WhenToTake { get; set; }
        public bool IsBeforeMeal { get; set; }
    }
}
