using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class PatientCheckUp
    {
        public PatientCheckUp()
        {
            this.Prescription = new Prescription();
        }
        public long PatientCheckupId { get; set; }
        public long PatientId { get; set; }

        [Display(Name = "Checkup Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? CheckupDate { get; set; }

        [Required]
        [Display(Name = "Doctor")]
        public long DoctorId { get; set; }
        public string DoctorName { get; set; }

        [Required]
        public string Symptoms { get; set; }

        [Required]
        public string Diagnosis { get; set; }
        public Prescription Prescription { get; set; }
    }
}
