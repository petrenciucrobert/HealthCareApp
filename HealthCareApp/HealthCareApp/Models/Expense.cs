using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.Models
{
    public class Expense
    {
        public long ExpenseId { get; set; }

        [Required]
        [Display(Name = "Expense Category")]
        public string ExpenseCategoryName { get; set; }

        public DateTime ExpenseDate { get; set; }

        [Required]
        [Display(Name = "Amount($)")]
        [DataType(DataType.Currency)]
        public decimal ExpenseAmount { get; set; }

    }
}
