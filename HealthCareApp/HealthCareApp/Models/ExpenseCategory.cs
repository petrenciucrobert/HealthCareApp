using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class ExpenseCategory
    {
        public long ExpenseCategoryId { get; set; }

        [Required]
        [Display(Name = "Expense Category")]
        public string ExpenseCategoryName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

    }
}
