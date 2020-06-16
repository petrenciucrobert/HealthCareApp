using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class LaboratoryTestCategory
    {
        public long LaboratoryTestCategoryId { get; set; }

        [Required]
        [Display(Name = "LabTest Category")]
        public string LabTestCategoryName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

    }
}
