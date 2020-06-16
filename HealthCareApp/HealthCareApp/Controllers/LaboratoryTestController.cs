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
    public class LaboratoryTestController : Controller
    {
        private readonly AppDbContext _context;

        public LaboratoryTestController(AppDbContext context)
        {
            _context = context;
        }

        // GET: LaboratoryTest
        public async Task<IActionResult> Index()
        {
            return View(await _context.LaboratoryTest.ToListAsync());
        }
        // GET: LaboratoryTest/Create
        public IActionResult Create()
        {
            List<LaboratoryTestCategory> LabTestCategoryList = new List<LaboratoryTestCategory>();
            LabTestCategoryList = _context.LaboratoryTestCategory.ToList();
            ViewBag.ListofLabTestCategories = LabTestCategoryList;
            return View();
        }

        // POST: LaboratoryTest/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LaboratoryTestId,LabTestCategoryName,LabTestName")] LaboratoryTest laboratoryTest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(laboratoryTest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(laboratoryTest);
        }

        // GET: LaboratoryTest/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            List<LaboratoryTestCategory> LabTestCategoryList = new List<LaboratoryTestCategory>();
            LabTestCategoryList = _context.LaboratoryTestCategory.ToList();
            ViewBag.ListofLabTestCategories = LabTestCategoryList;
            if (id == null)
            {
                return NotFound();
            }

            var laboratoryTest = await _context.LaboratoryTest.FindAsync(id);
            if (laboratoryTest == null)
            {
                return NotFound();
            }
            return View(laboratoryTest);
        }

        // POST: LaboratoryTest/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("LaboratoryTestId,LabTestCategoryName,LabTestName")] LaboratoryTest laboratoryTest)
        {
            if (id != laboratoryTest.LaboratoryTestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(laboratoryTest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaboratoryTestExists(laboratoryTest.LaboratoryTestId))
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
            return View(laboratoryTest);
        }

        // GET: LaboratoryTest/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laboratoryTest = await _context.LaboratoryTest
                .FirstOrDefaultAsync(m => m.LaboratoryTestId == id);
            if (laboratoryTest == null)
            {
                return NotFound();
            }

            return View(laboratoryTest);
        }

        // POST: LaboratoryTest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var laboratoryTest = await _context.LaboratoryTest.FindAsync(id);
            _context.LaboratoryTest.Remove(laboratoryTest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaboratoryTestExists(long id)
        {
            return _context.LaboratoryTest.Any(e => e.LaboratoryTestId == id);
        }
    }
}
