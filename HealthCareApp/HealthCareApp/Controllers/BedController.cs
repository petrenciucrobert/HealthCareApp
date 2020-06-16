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
    public class BedController : Controller
    {
        private readonly AppDbContext _context;

        public BedController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Bed
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bed.ToListAsync());
        }
        // GET: Bed/Create
        public IActionResult Create()
        {
            List<BedCategory> bedCategoryList = new List<BedCategory>();
            bedCategoryList = _context.BedCategory.ToList();
            ViewBag.ListofCategories = bedCategoryList;
            return View();
        }

        // POST: Bed/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BedId,BedName,BedCategoryId,BedCategory,Description")] Bed bed)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bed);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bed);
        }

        // GET: Bed/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            List<BedCategory> bedCategoryList = new List<BedCategory>();
            bedCategoryList = _context.BedCategory.ToList();
            ViewBag.ListofCategories = bedCategoryList;
            if (id == null)
            {
                return NotFound();
            }

            var bed = await _context.Bed.FindAsync(id);
            if (bed == null)
            {
                return NotFound();
            }
            return View(bed);
        }

        // POST: Bed/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("BedId,BedName,BedCategoryId,BedCategory,Description")] Bed bed)
        {
            if (id != bed.BedId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bed);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BedExists(bed.BedId))
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
            return View(bed);
        }

        // GET: Bed/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bed = await _context.Bed
                .FirstOrDefaultAsync(m => m.BedId == id);
            if (bed == null)
            {
                return NotFound();
            }

            return View(bed);
        }

        // POST: Bed/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var bed = await _context.Bed.FindAsync(id);
            _context.Bed.Remove(bed);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BedExists(long id)
        {
            return _context.Bed.Any(e => e.BedId == id);
        }
    }
}
