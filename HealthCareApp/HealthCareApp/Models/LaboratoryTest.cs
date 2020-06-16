using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class LaboratoryTest
    {
        public long LaboratoryTestId { get; set; }

        [Required]
        [Display(Name = "Laboratory Test Category")]
        public string LabTestCategoryName { get; set; }

        [Required]
        [Display(Name = "Laboratory Test Name")]
        public string LabTestName { get; set; }

    
    }
}
