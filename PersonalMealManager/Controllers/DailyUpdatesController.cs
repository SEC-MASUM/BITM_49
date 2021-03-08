using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PersonalMealManager.Models;

namespace PersonalMealManager.Controllers
{
    public class DailyUpdatesController : Controller
    {
        private readonly PMMContext _context;

        public DailyUpdatesController(PMMContext context)
        {
            _context = context;
        }

        // GET: DailyUpdates
        public async Task<IActionResult> Index()
        {
            var pMMContext = _context.DailyUpdates.Include(d => d.Member);
            return View(await pMMContext.ToListAsync());
        }

        // GET: DailyUpdates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dailyUpdate = await _context.DailyUpdates
                .Include(d => d.Member)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dailyUpdate == null)
            {
                return NotFound();
            }

            return View(dailyUpdate);
        }

        // GET: DailyUpdates/Create
        public IActionResult Create()
        {
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Id");
            return View();
        }

        // POST: DailyUpdates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,MealCount,GuestMealCount,MemberId")] DailyUpdate dailyUpdate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dailyUpdate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Id", dailyUpdate.MemberId);
            return View(dailyUpdate);
        }

        // GET: DailyUpdates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dailyUpdate = await _context.DailyUpdates.FindAsync(id);
            if (dailyUpdate == null)
            {
                return NotFound();
            }
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Id", dailyUpdate.MemberId);
            return View(dailyUpdate);
        }

        // POST: DailyUpdates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,MealCount,GuestMealCount,MemberId")] DailyUpdate dailyUpdate)
        {
            if (id != dailyUpdate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dailyUpdate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DailyUpdateExists(dailyUpdate.Id))
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
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Id", dailyUpdate.MemberId);
            return View(dailyUpdate);
        }

        // GET: DailyUpdates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dailyUpdate = await _context.DailyUpdates
                .Include(d => d.Member)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dailyUpdate == null)
            {
                return NotFound();
            }

            return View(dailyUpdate);
        }

        // POST: DailyUpdates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dailyUpdate = await _context.DailyUpdates.FindAsync(id);
            _context.DailyUpdates.Remove(dailyUpdate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DailyUpdateExists(int id)
        {
            return _context.DailyUpdates.Any(e => e.Id == id);
        }
    }
}
