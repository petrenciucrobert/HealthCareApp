using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class PatientLaboratoryTest
    {
        public long PatientLaboratoryTestId { get; set; }

        [Required]
        [Display(Name = "Patient")]
        public string PatientName { get; set; }

        [Required]
        [Display(Name = "Consultant")]
        public string DoctorName { get; set; }
        [Required]
        [Display(Name = "Laboratory Test Name")]
        public string LabTestName { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime? TestDate { get; set; }

        public string Result { get; set; }
        public string Remarks { get; set; }

    }
}
