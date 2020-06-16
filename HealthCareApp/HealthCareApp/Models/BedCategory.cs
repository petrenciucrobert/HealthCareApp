using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class BedCategory
    {
      
        public long BedCategoryId { get; set; }

        [Required]
        [Display(Name = "Bed Category")]
        public string BedCategoryName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Status")]
        public bool IsActive { get; set; }

    }
}
