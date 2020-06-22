using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HealthCareApp.Models;

namespace HealthCareApp.Controllers
{
    public class MedicineCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public MedicineCategoryController(AppDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            return View(await _context.MedicineCategory.ToListAsync());
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MedicineCategoryId,MedicineCategoryName,IsActive")] MedicineCategory medicineCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicineCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medicineCategory);
        }

        
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicineCategory = await _context.MedicineCategory.FindAsync(id);
            if (medicineCategory == null)
            {
                return NotFound();
            }
            return View(medicineCategory);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("MedicineCategoryId,MedicineCategoryName,IsActive")] MedicineCategory medicineCategory)
        {
            if (id != medicineCategory.MedicineCategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicineCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicineCategoryExists(medicineCategory.MedicineCategoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(medicineCategory);
        }

        
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicineCategory = await _context.MedicineCategory
                .FirstOrDefaultAsync(m => m.MedicineCategoryId == id);
            if (medicineCategory == null)
            {
                return NotFound();
            }

            return View(medicineCategory);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var medicineCategory = await _context.MedicineCategory.FindAsync(id);
            _context.MedicineCategory.Remove(medicineCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicineCategoryExists(long id)
        {
            return _context.MedicineCategory.Any(e => e.MedicineCategoryId == id);
        }
    }
}
