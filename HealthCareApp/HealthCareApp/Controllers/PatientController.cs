using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HealthCareApp.Models;
using HealthCareApp.ViewModels;
using HealthCareApp.Core.IRepository;

namespace HealthCareApp.Controllers
{
    public class PatientController : Controller
    {
        private readonly AppDbContext _context;
        //private readonly IDoctorRepository _doctorRepository;
        private readonly IPatientRepository _patientRepository;


        public PatientController(/*IDoctorRepository doctorRepository,*/ IPatientRepository patientRepository, AppDbContext context)
        {
            //_doctorRepository = doctorRepository;
            _patientRepository = patientRepository;
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Patients.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PatientId,FirstName,MiddleName,LastName,Email,Password,Phone,IsActive,BirthDate,Gender,BloodGroup,Address")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

       
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            return View(patient);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("PatientId,FirstName,MiddleName,LastName,Email,Password,Phone,IsActive,BirthDate,Gender,BloodGroup,Address")] Patient patient)
        {
            if (id != patient.PatientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientExists(patient.PatientId))
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
            return View(patient);
        }

        
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patients
                .FirstOrDefaultAsync(m => m.PatientId == id);
            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var patient = await _context.Patients.FindAsync(id);
            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientExists(long id)
        {
            return _context.Patients.Any(e => e.PatientId == id);
        }




     


        
        public async Task<IActionResult> Details(long id)
        {
            var patient = new PatientViewModel();
            ViewBag.Heading = "Patient Detail";

            if (id > 0)
            {
                patient.PatientDetail = await _context.Patients.FirstOrDefaultAsync(m => m.PatientId == id);
                patient.CheckupHistoryList =  _patientRepository.GetAllCheckupDetail(id);

                
            }

            return View(patient);
        }




        [Route("Patient/CheckUp/{patientId}/{checkupId?}")]
        public IActionResult CheckUp(long patientId, long? checkupId)
        {
            var patientCheckup = new PatientCheckUp();
            patientCheckup.PatientId = patientId;
           
            ViewBag.Medicines = new SelectList(_context.Medicine, "MedicineId", "MedicineName");

            List<Doctor> doctorsList = new List<Doctor>();
            doctorsList = _context.Doctors.ToList();
            ViewBag.ListofDoctors = doctorsList;

            ViewBag.Heading = "Add Patient Checkup Detail";

            if (checkupId.HasValue && checkupId > 0)
            {
                ViewBag.Heading = "Edit Patient Checkup Detail";
                patientCheckup = _patientRepository.GetCheckupDetail(checkupId ?? 0);

                if (patientCheckup == null)
                {
                    patientCheckup = new PatientCheckUp();
                }
            }

            
            return View(patientCheckup);
        }


        [HttpPost]
        [Route("Patient/CheckUp/{patientId}/{checkupId?}")]
        [ValidateAntiForgeryToken]
        public ActionResult CheckUp(long patientId, long? checkupId, PatientCheckUp patientCheckup)
        {
           
                ViewBag.Heading = "Add Patient Checkup Detail";
              
                patientCheckup.PatientId = patientId;
                

                if (patientCheckup.PatientCheckupId > 0)
                {
                    ViewBag.Heading = "Edit Patient Checkup Detail";

                }

                if (ModelState.IsValid)
                {
                    _context.Add(patientCheckup);
                    _context.SaveChanges();
                return RedirectToAction(nameof(Index));
                

                }
                else
                {
                    ViewBag.ErrorMsg = "some inputs are missing";
                }
            return View(patientCheckup);
           
        }
        
            
        
        
    }
}