using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationRepaso.Data;
using WebApplicationRepaso.Models;

namespace WebApplicationRepaso.Controllers
{
    public class BodasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BodasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bodas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Boda.Include(x => x.Pareja).ToListAsync());
        }

        // GET: Bodas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boda = await _context.Boda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (boda == null)
            {
                return NotFound();
            }

            return View(boda);
        }

        // GET: Bodas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bodas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fecha,Lugar")] Boda boda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(boda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(boda);
        }

        // GET: Bodas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boda = await _context.Boda.FindAsync(id);
            if (boda == null)
            {
                return NotFound();
            }
            return View(boda);
        }

        // POST: Bodas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fecha,Lugar")] Boda boda)
        {
            if (id != boda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BodaExists(boda.Id))
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
            return View(boda);
        }

        // GET: Bodas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boda = await _context.Boda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (boda == null)
            {
                return NotFound();
            }

            return View(boda);
        }

        // POST: Bodas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var boda = await _context.Boda.FindAsync(id);
            _context.Boda.Remove(boda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BodaExists(int id)
        {
            return _context.Boda.Any(e => e.Id == id);
        }
    }
}
