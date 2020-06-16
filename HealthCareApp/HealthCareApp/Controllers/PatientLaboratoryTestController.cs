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
    public class PatientLaboratoryTestController : Controller
    {
        private readonly AppDbContext _context;

        public PatientLaboratoryTestController(AppDbContext context)
        {
            _context = context;
        }

        // GET: PatientLaboratoryTest
        public async Task<IActionResult> Index()
        {
            return View(await _context.PatientLaboratoryTest.ToListAsync());
        }

        // GET: PatientLaboratoryTest/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientLaboratoryTest = await _context.PatientLaboratoryTest
                .FirstOrDefaultAsync(m => m.PatientLaboratoryTestId == id);
            if (patientLaboratoryTest == null)
            {
                return NotFound();
            }

            return View(patientLaboratoryTest);
        }

        // GET: PatientLaboratoryTest/Create
        public IActionResult Create()
        {
            List<Patient> patientsList = new List<Patient>();
            patientsList = _context.Patients.ToList();
            ViewBag.ListofPatients = patientsList;

            List<Doctor> doctorsList = new List<Doctor>();
            doctorsList = _context.Doctors.ToList();
            ViewBag.ListofDoctors = doctorsList;

            List<LaboratoryTest> laboratoryTests = new List<LaboratoryTest>();
            laboratoryTests = _context.LaboratoryTest.ToList();
            ViewBag.ListofLabTests = laboratoryTests;
            return View();
        }

        // POST: PatientLaboratoryTest/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PatientLaboratoryTestId,PatientName,DoctorName,LabTestName,TestDate,Result,Remarks")] PatientLaboratoryTest patientLaboratoryTest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patientLaboratoryTest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patientLaboratoryTest);
        }

        // GET: PatientLaboratoryTest/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            List<Patient> patientsList = new List<Patient>();
            patientsList = _context.Patients.ToList();
            ViewBag.ListofPatients = patientsList;

            List<Doctor> doctorsList = new List<Doctor>();
            doctorsList = _context.Doctors.ToList();
            ViewBag.ListofDoctors = doctorsList;

            List<LaboratoryTest> laboratoryTests = new List<LaboratoryTest>();
            laboratoryTests = _context.LaboratoryTest.ToList();
            ViewBag.ListofLabTests = laboratoryTests;
            if (id == null)
            {
                return NotFound();
            }

            var patientLaboratoryTest = await _context.PatientLaboratoryTest.FindAsync(id);
            if (patientLaboratoryTest == null)
            {
                return NotFound();
            }
            return View(patientLaboratoryTest);
        }

        // POST: PatientLaboratoryTest/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("PatientLaboratoryTestId,PatientName,DoctorName,LabTestName,TestDate,Result,Remarks")] PatientLaboratoryTest patientLaboratoryTest)
        {
            if (id != patientLaboratoryTest.PatientLaboratoryTestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patientLaboratoryTest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientLaboratoryTestExists(patientLaboratoryTest.PatientLaboratoryTestId))
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
            return View(patientLaboratoryTest);
        }

        // GET: PatientLaboratoryTest/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientLaboratoryTest = await _context.PatientLaboratoryTest
                .FirstOrDefaultAsync(m => m.PatientLaboratoryTestId == id);
            if (patientLaboratoryTest == null)
            {
                return NotFound();
            }

            return View(patientLaboratoryTest);
        }

        // POST: PatientLaboratoryTest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var patientLaboratoryTest = await _context.PatientLaboratoryTest.FindAsync(id);
            _context.PatientLaboratoryTest.Remove(patientLaboratoryTest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientLaboratoryTestExists(long id)
        {
            return _context.PatientLaboratoryTest.Any(e => e.PatientLaboratoryTestId == id);
        }
    }
}
