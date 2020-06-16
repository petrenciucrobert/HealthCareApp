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
    public class NurseController : Controller
    {
        private readonly AppDbContext _context;

        public NurseController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Nurse
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nurse.ToListAsync());
        }

        // GET: Nurse/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nurse/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NurseId,FirstName,MiddleName,LastName,Email,Phone")] Nurse nurse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nurse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nurse);
        }

        // GET: Nurse/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nurse = await _context.Nurse.FindAsync(id);
            if (nurse == null)
            {
                return NotFound();
            }
            return View(nurse);
        }

        // POST: Nurse/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("NurseId,FirstName,MiddleName,LastName,Email,Phone")] Nurse nurse)
        {
            if (id != nurse.NurseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nurse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NurseExists(nurse.NurseId))
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
            return View(nurse);
        }

        // GET: Nurse/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nurse = await _context.Nurse
                .FirstOrDefaultAsync(m => m.NurseId == id);
            if (nurse == null)
            {
                return NotFound();
            }

            return View(nurse);
        }

        // POST: Nurse/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var nurse = await _context.Nurse.FindAsync(id);
            _context.Nurse.Remove(nurse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NurseExists(long id)
        {
            return _context.Nurse.Any(e => e.NurseId == id);
        }
    }
}
