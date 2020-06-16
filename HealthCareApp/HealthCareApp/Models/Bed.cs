using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class Bed
    {
        public long BedId { get; set; }

        [Required]
        [Display(Name = "Bed No.")]
        public string BedName { get; set; }

        [Required]
        [Display(Name = "Bed Category")]
        public long BedCategoryId { get; set; }

        public string BedCategory { get; set; }

        public string Description { get; set; }

    }
}
