﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HealthCareApp.Models;

namespace HealthCareApp.Controllers
{
    public class CleaningStaffController : Controller
    {
        private readonly AppDbContext _context;

        public CleaningStaffController(AppDbContext context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
            return View(await _context.CleaningStaff.ToListAsync());
        }

        
        public IActionResult Create()
        {
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CleaningStaffId,FirstName,MiddleName,LastName,Phone")] CleaningStaff cleaningStaff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cleaningStaff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cleaningStaff);
        }

       
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cleaningStaff = await _context.CleaningStaff.FindAsync(id);
            if (cleaningStaff == null)
            {
                return NotFound();
            }
            return View(cleaningStaff);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("CleaningStaffId,FirstName,MiddleName,LastName,Phone")] CleaningStaff cleaningStaff)
        {
            if (id != cleaningStaff.CleaningStaffId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cleaningStaff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CleaningStaffExists(cleaningStaff.CleaningStaffId))
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
            return View(cleaningStaff);
        }

        
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cleaningStaff = await _context.CleaningStaff
                .FirstOrDefaultAsync(m => m.CleaningStaffId == id);
            if (cleaningStaff == null)
            {
                return NotFound();
            }

            return View(cleaningStaff);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var cleaningStaff = await _context.CleaningStaff.FindAsync(id);
            _context.CleaningStaff.Remove(cleaningStaff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CleaningStaffExists(long id)
        {
            return _context.CleaningStaff.Any(e => e.CleaningStaffId == id);
        }
    }
}
