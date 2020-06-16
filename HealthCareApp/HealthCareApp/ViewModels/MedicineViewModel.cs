using HealthCareApp.Core.Repository;
using HealthCareApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareApp.ViewModels
{
    public class MedicineViewModel
    {
        private readonly AppDbContext _context;
        public MedicineViewModel(AppDbContext context)
        {
            _context = context;
            this.Medicine = new Medicine();

            this.MedicineCategories = _context.MedicineCategory.ToList();
        }
        public Medicine Medicine { get; set; }
        public IEnumerable<MedicineCategory> MedicineCategories;
        
        }
}

