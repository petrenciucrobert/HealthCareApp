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
    public class BedAllotmentController : Controller
    {
        private readonly AppDbContext _context;

        public BedAllotmentController(AppDbContext context)
        {
            _context = context;
        }

        // GET: BedAllotment
        public async Task<IActionResult> Index()
        {
            return View(await _context.BedAllotment.ToListAsync());
        }

        // GET: BedAllotment/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bedAllotment = await _context.BedAllotment
                .FirstOrDefaultAsync(m => m.BedAllotmentId == id);
            if (bedAllotment == null)
            {
                return NotFound();
            }

            return View(bedAllotment);
        }

        // GET: BedAllotment/Create
        public IActionResult Create()
        {
            List<Patient> patientsList = new List<Patient>();
            patientsList = _context.Patients.ToList();
            ViewBag.ListofPatients = patientsList;

            List<Bed> bedsList = new List<Bed>();
            bedsList = _context.Bed.ToList();
            ViewBag.ListofBeds = bedsList;

            List<BedCategory> bedCategoryList = new List<BedCategory>();
            bedCategoryList = _context.BedCategory.ToList();
            ViewBag.ListofBedCategories = bedCategoryList;
            return View();
        }

        // POST: BedAllotment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BedAllotmentId,PatientName,BedName,BedCategory,HospitalizationDate,DischargeDate,Notes")] BedAllotment bedAllotment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bedAllotment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bedAllotment);
        }

        // GET: BedAllotment/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            List<Patient> patientsList = new List<Patient>();
            patientsList = _context.Patients.ToList();
            ViewBag.ListofPatients = patientsList;

            List<Bed> bedsList = new List<Bed>();
            bedsList = _context.Bed.ToList();
            ViewBag.ListofBeds = bedsList;

            List<BedCategory> bedCategoryList = new List<BedCategory>();
            bedCategoryList = _context.BedCategory.ToList();
            ViewBag.ListofBedCategories = bedCategoryList;
            if (id == null)
            {
                return NotFound();
            }

            var bedAllotment = await _context.BedAllotment.FindAsync(id);
            if (bedAllotment == null)
            {
                return NotFound();
            }
            return View(bedAllotment);
        }

        // POST: BedAllotment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("BedAllotmentId,PatientName,BedName,BedCategory,HospitalizationDate,DischargeDate,Notes")] BedAllotment bedAllotment)
        {
            if (id != bedAllotment.BedAllotmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bedAllotment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BedAllotmentExists(bedAllotment.BedAllotmentId))
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
            return View(bedAllotment);
        }

        // GET: BedAllotment/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bedAllotment = await _context.BedAllotment
                .FirstOrDefaultAsync(m => m.BedAllotmentId == id);
            if (bedAllotment == null)
            {
                return NotFound();
            }

            return View(bedAllotment);
        }

        // POST: BedAllotment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var bedAllotment = await _context.BedAllotment.FindAsync(id);
            _context.BedAllotment.Remove(bedAllotment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BedAllotmentExists(long id)
        {
            return _context.BedAllotment.Any(e => e.BedAllotmentId == id);
        }
    }
}
