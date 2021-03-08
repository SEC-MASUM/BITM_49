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
    public class MemberPaysController : Controller
    {
        private readonly PMMContext _context;

        public MemberPaysController(PMMContext context)
        {
            _context = context;
        }

        // GET: MemberPays
        public async Task<IActionResult> Index()
        {
            var pMMContext = _context.MemberPays.Include(m => m.Member);
            return View(await pMMContext.ToListAsync());
        }

        // GET: MemberPays/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memberPay = await _context.MemberPays
                .Include(m => m.Member)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (memberPay == null)
            {
                return NotFound();
            }

            return View(memberPay);
        }

        // GET: MemberPays/Create
        public IActionResult Create()
        {
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Id");
            return View();
        }

        // POST: MemberPays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MemberId,Amount,Date")] MemberPay memberPay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(memberPay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Name", memberPay.MemberId);
            return View(memberPay);
        }

        // GET: MemberPays/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memberPay = await _context.MemberPays.FindAsync(id);
            if (memberPay == null)
            {
                return NotFound();
            }
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Id", memberPay.MemberId);
            return View(memberPay);
        }

        // POST: MemberPays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MemberId,Amount,Date")] MemberPay memberPay)
        {
            if (id != memberPay.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(memberPay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberPayExists(memberPay.Id))
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
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Id", memberPay.MemberId);
            return View(memberPay);
        }

        // GET: MemberPays/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memberPay = await _context.MemberPays
                .Include(m => m.Member)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (memberPay == null)
            {
                return NotFound();
            }

            return View(memberPay);
        }

        // POST: MemberPays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var memberPay = await _context.MemberPays.FindAsync(id);
            _context.MemberPays.Remove(memberPay);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemberPayExists(int id)
        {
            return _context.MemberPays.Any(e => e.Id == id);
        }
    }
}
