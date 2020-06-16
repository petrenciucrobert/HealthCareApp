using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class MedicineCategory
    {
        public MedicineCategory()
        {
            this.IsActive = true;
        }
        public long MedicineCategoryId { get; set; }

        [Required]
        [Display(Name = "Medicine Category")]
        public string MedicineCategoryName { get; set; }

        [Display(Name = "Status")]
        public bool IsActive { get; set; }

        
    }
}
