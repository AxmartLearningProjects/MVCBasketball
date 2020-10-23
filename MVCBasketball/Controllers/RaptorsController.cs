using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCBasketball.Data;
using MVCBasketball.Models;

namespace MVCBasketball.Controllers
{
    public class RaptorsController : Controller
    {
        private readonly MVCBasketballContext _context;

        public RaptorsController(MVCBasketballContext context)
        {
            _context = context;
        }

        // GET: Raptors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Raptors.ToListAsync());
        }

        // GET: Raptors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raptors = await _context.Raptors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (raptors == null)
            {
                return NotFound();
            }

            return View(raptors);
        }

        // GET: Raptors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Raptors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PlayerNumber,PlayerName,PlayerPosition,PlayerHeight,PlayerSalary")] Raptors raptors)
        {
            if (ModelState.IsValid)
            {
                _context.Add(raptors);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(raptors);
        }

        // GET: Raptors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raptors = await _context.Raptors.FindAsync(id);
            if (raptors == null)
            {
                return NotFound();
            }
            return View(raptors);
        }

        // POST: Raptors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PlayerNumber,PlayerName,PlayerPosition,PlayerHeight,PlayerSalary")] Raptors raptors)
        {
            if (id != raptors.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(raptors);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RaptorsExists(raptors.Id))
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
            return View(raptors);
        }

        // GET: Raptors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raptors = await _context.Raptors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (raptors == null)
            {
                return NotFound();
            }

            return View(raptors);
        }

        // POST: Raptors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var raptors = await _context.Raptors.FindAsync(id);
            _context.Raptors.Remove(raptors);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RaptorsExists(int id)
        {
            return _context.Raptors.Any(e => e.Id == id);
        }
    }
}
