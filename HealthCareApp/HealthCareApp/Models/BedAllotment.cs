using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class BedAllotment
    {
        public long BedAllotmentId { get; set; }
       
        [Display(Name = "Patient")]
        [Required]
        public string PatientName { get; set; }

        [Required]
        [Display(Name = "Bed No.")]
        public string BedName { get; set; }

        [Display(Name = "Bed Category")]
        public string BedCategory { get; set; }

        [Required]
        [Display(Name = "Hospitalization Date")]
        public DateTime? HospitalizationDate { get; set; }

        [Display(Name = "Discharge Date")]
        public DateTime? DischargeDate { get; set; }
        public string Notes { get; set; }

    }
}
