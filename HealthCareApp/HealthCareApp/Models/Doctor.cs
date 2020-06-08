using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class Doctor
    {
        public long DoctorId { get; set; }

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
        //[RegularExpression(StringConstants.EmailRegEx, ErrorMessage = "Enter valid email.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //[Required]
        //[DataType(DataType.Password)]
        //[Display(Name = "Password")]
        //public string Password { get; set; }

        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        //[Display(Name = "Role")]
        //public long? RoleId { get; set; }

        //public string RoleName { get; set; }

        //public long CreatedBy { get; set; }

        //[Display(Name = "Hospital")]
        //public long? CompanyId { get; set; }

        [Display(Name = "Status")]
        public bool IsActive { get; set; }

        //public int TotalRecordCount { get; set; }

        //public string DuplicateColumn { get; set; }

        //[Display(Name = "Profile Picture")]
        //public string ProfilePic { get; set; }
    }
}
