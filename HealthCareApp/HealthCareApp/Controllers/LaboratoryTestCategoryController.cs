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
    public class LaboratoryTestCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public LaboratoryTestCategoryController(AppDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            return View(await _context.LaboratoryTestCategory.ToListAsync());
        }

        
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laboratoryTestCategory = await _context.LaboratoryTestCategory
                .FirstOrDefaultAsync(m => m.LaboratoryTestCategoryId == id);
            if (laboratoryTestCategory == null)
            {
                return NotFound();
            }

            return View(laboratoryTestCategory);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LaboratoryTestCategoryId,LabTestCategoryName,Description")] LaboratoryTestCategory laboratoryTestCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(laboratoryTestCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(laboratoryTestCategory);
        }

        
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laboratoryTestCategory = await _context.LaboratoryTestCategory.FindAsync(id);
            if (laboratoryTestCategory == null)
            {
                return NotFound();
            }
            return View(laboratoryTestCategory);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("LaboratoryTestCategoryId,LabTestCategoryName,Description")] LaboratoryTestCategory laboratoryTestCategory)
        {
            if (id != laboratoryTestCategory.LaboratoryTestCategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(laboratoryTestCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaboratoryTestCategoryExists(laboratoryTestCategory.LaboratoryTestCategoryId))
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
            return View(laboratoryTestCategory);
        }

        
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laboratoryTestCategory = await _context.LaboratoryTestCategory
                .FirstOrDefaultAsync(m => m.LaboratoryTestCategoryId == id);
            if (laboratoryTestCategory == null)
            {
                return NotFound();
            }

            return View(laboratoryTestCategory);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var laboratoryTestCategory = await _context.LaboratoryTestCategory.FindAsync(id);
            _context.LaboratoryTestCategory.Remove(laboratoryTestCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaboratoryTestCategoryExists(long id)
        {
            return _context.LaboratoryTestCategory.Any(e => e.LaboratoryTestCategoryId == id);
        }
    }
}
