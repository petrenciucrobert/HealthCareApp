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
        private readonly IDoctorRepository _doctorRepository;
        private readonly IPatientRepository _patientRepository;


        public PatientController(IDoctorRepository doctorRepository, IPatientRepository patientRepository, AppDbContext context)
        {
            _doctorRepository = doctorRepository;
            _patientRepository = patientRepository;
            _context = context;
        }

        // GET: Patient
        public async Task<IActionResult> Index()
        {
            return View(await _context.Patients.ToListAsync());
        }

        // GET: Patient/Details/5
        //public async Task<IActionResult> Details(long? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    //var patientViewModel = new PatientViewModel
        //    var patient = await _context.Patients
        //        .FirstOrDefaultAsync(m => m.PatientId == id);
        //    //var patient = new PatientDetailViewModel();
        //    if (patient == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(patient);
        //}

        // GET: Patient/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Patient/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Patient/Edit/5
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

        // POST: Patient/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Patient/Delete/5
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

        // POST: Patient/Delete/5
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

            //if (CommonLogic.GetQueryString("status").Equals("s", StringComparison.CurrentCultureIgnoreCase))
            //{
            //    ViewBag.SuccessMsg = string.Format(StringConstants.RecordSave, "Checkup Detail");
            //}

            //string path = CommonLogic.GetConfigValue(StringConstants.AppConfig_ProfilePicFolderPath);
            //string defPath = CommonLogic.GetConfigValue(StringConstants.AppConfig_DefaultProfilePic);

            //string mode = CommonLogic.GetFormDataString("mode");
            //long pid = SqlHelper.ParseNativeLong(CommonLogic.GetFormDataString("pid"));

            //if (!string.IsNullOrEmpty(mode) && mode == "del" && pid > 0)
            //{
            //    try
            //    {
            //        PatientBLL.DeleteCheckupDetail(pid);
            //    }
            //    catch (Exception ex)
            //    {
            //        return this.Json(new { IsError = true, ErrorMsg = CommonLogic.GetExceptionMessage(ex) });
            //    }
            //}

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
            var patientCheckupVM = new PatientCheckUpViewModel();
            patientCheckupVM.PatientCheckUp.PatientId = patientId;
           
            ViewBag.Medicines = new SelectList(_context.Medicine, "MedicineId", "MedicineName");

            List<Doctor> doctorsList = new List<Doctor>();
            doctorsList = _context.Doctors.ToList();
            ViewBag.ListofDoctors = doctorsList;

            ViewBag.Heading = "Add Patient Checkup Detail";

            if (checkupId.HasValue && checkupId > 0)
            {
                ViewBag.Heading = "Edit Patient Checkup Detail";
                patientCheckupVM.PatientCheckUp = _patientRepository.GetCheckupDetail(checkupId ?? 0);

                if (patientCheckupVM.PatientCheckUp == null)
                {
                    patientCheckupVM.PatientCheckUp = new PatientCheckUp();
                }
            }

            //return Request.IsAjaxRequest() ? (ActionResult)PartialView("Checkup", patientCheckupVM) : this.View(patientCheckupVM);
            return View(patientCheckupVM);
        }


        [HttpPost]
        [Route("Patient/CheckUp/{patientId}/{checkupId?}")]
        [ValidateAntiForgeryToken]
        public ActionResult CheckUp(long patientId, long? checkupId, PatientCheckUpViewModel patientCheckupVM/*, List<PrescriptionDetail> medicineList*/)
        {
           
                ViewBag.Heading = "Add Patient Checkup Detail";
               // ViewBag.Medicines = new SelectList(_context.Medicine, "MedicineId", "MedicineName");
                patientCheckupVM.PatientCheckUp.PatientId = patientId;
                //List<Doctor> DoctorList = new List<Doctor>();
                //DoctorList = _context.Doctors.ToList();
                //DoctorList.Insert(0, new Doctor { DoctorId = 0, FirstName = "Select" });
                //ViewBag.Doctors = DoctorList;
               // patientCheckupVM.PatientCheckUp.Prescription.MedicineList = medicineList;


                if (patientCheckupVM.PatientCheckUp.PatientCheckupId > 0)
                {
                    ViewBag.Heading = "Edit Patient Checkup Detail";

                }

                if (ModelState.IsValid)
                {
                    _context.Add(patientCheckupVM.PatientCheckUp);
                    _context.SaveChanges();
                return RedirectToAction(nameof(Index));
                //return RedirectToAction(nameof(Index));
                //long returnId = PatientBLL.SaveCheckupDetail(patientCheckupVM);

            }
                else
                {
                    ViewBag.ErrorMsg = "some inputs are missing";
                }
            return View(patientCheckupVM);
           // return RedirectToAction("Details");
        }
        
            
        
        //public PartialViewResult BlankEditorRow()
        //{
        //    ViewBag.Medicines = new SelectList(_context.Medicine, "MedicineId", "MedicineName");
        //    return PartialView("_MedicineRow", new PrescriptionDetail());
        //}
    }
}