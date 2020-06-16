using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class Medicine
    {
        public Medicine()
        {
            this.IsActive = true;
        }

        public long MedicineId { get; set; }

        //public long CompanyId { get; set; }

        [Required]
        [Display(Name = "Medicine Name")]
        public string MedicineName { get; set; }

        public string Description { get; set; }

        [Display(Name = "Medicine Category")]
        public long MedicineCategoryId { get; set; }
        public string MedicineCategoryName { get; set; }
        //public int AvailableQuantity { get; set; }
        //public long UnitId { get; set; }

        [Display(Name = "Status")]
        public bool IsActive { get; set; }
       
    }
}
