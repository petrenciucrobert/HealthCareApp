using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class CleaningStaff
    {
        public long CleaningStaffId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return string.Concat(this.FirstName, ' ', this.LastName);
            }
        }
        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
}
