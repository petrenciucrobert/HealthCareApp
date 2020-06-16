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
    public class BedCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public BedCategoryController(AppDbContext context)
        {
            _context = context;
        }

        // GET: BedCategory
        public async Task<IActionResult> Index()
        {
            return View(await _context.BedCategory.ToListAsync());
        }

        // GET: BedCategory/Details/5
     

        // GET: BedCategory/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BedCategory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BedCategoryId,BedCategoryName,Description,IsActive")] BedCategory bedCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bedCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bedCategory);
        }

        // GET: BedCategory/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bedCategory = await _context.BedCategory.FindAsync(id);
            if (bedCategory == null)
            {
                return NotFound();
            }
            return View(bedCategory);
        }

        // POST: BedCategory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("BedCategoryId,BedCategoryName,Description,IsActive")] BedCategory bedCategory)
        {
            if (id != bedCategory.BedCategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bedCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BedCategoryExists(bedCategory.BedCategoryId))
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
            return View(bedCategory);
        }

        // GET: BedCategory/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bedCategory = await _context.BedCategory
                .FirstOrDefaultAsync(m => m.BedCategoryId == id);
            if (bedCategory == null)
            {
                return NotFound();
            }

            return View(bedCategory);
        }

        // POST: BedCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var bedCategory = await _context.BedCategory.FindAsync(id);
            _context.BedCategory.Remove(bedCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BedCategoryExists(long id)
        {
            return _context.BedCategory.Any(e => e.BedCategoryId == id);
        }
    }
}
