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
    public class ExpenseCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public ExpenseCategoryController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ExpenseCategory
        public async Task<IActionResult> Index()
        {
            return View(await _context.ExpenseCategory.ToListAsync());
        }


        // GET: ExpenseCategory/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExpenseCategory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExpenseCategoryId,ExpenseCategoryName,Description")] ExpenseCategory expenseCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expenseCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(expenseCategory);
        }

        // GET: ExpenseCategory/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expenseCategory = await _context.ExpenseCategory.FindAsync(id);
            if (expenseCategory == null)
            {
                return NotFound();
            }
            return View(expenseCategory);
        }

        // POST: ExpenseCategory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ExpenseCategoryId,ExpenseCategoryName,Description")] ExpenseCategory expenseCategory)
        {
            if (id != expenseCategory.ExpenseCategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expenseCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpenseCategoryExists(expenseCategory.ExpenseCategoryId))
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
            return View(expenseCategory);
        }

        // GET: ExpenseCategory/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expenseCategory = await _context.ExpenseCategory
                .FirstOrDefaultAsync(m => m.ExpenseCategoryId == id);
            if (expenseCategory == null)
            {
                return NotFound();
            }

            return View(expenseCategory);
        }

        // POST: ExpenseCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var expenseCategory = await _context.ExpenseCategory.FindAsync(id);
            _context.ExpenseCategory.Remove(expenseCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpenseCategoryExists(long id)
        {
            return _context.ExpenseCategory.Any(e => e.ExpenseCategoryId == id);
        }
    }
}
