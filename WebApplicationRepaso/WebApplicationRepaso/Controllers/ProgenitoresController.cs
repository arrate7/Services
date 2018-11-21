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
    public class ProgenitoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProgenitoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Progenitores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Progenitor.Include(x => x.Descendientes).ToListAsync());
        }

        // GET: Progenitores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var progenitor = await _context.Progenitor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (progenitor == null)
            {
                return NotFound();
            }

            return View(progenitor);
        }

        // GET: Progenitores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Progenitores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Sexo,Edad")] Progenitor progenitor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(progenitor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(progenitor);
        }

        // GET: Progenitores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var progenitor = await _context.Progenitor.FindAsync(id);
            if (progenitor == null)
            {
                return NotFound();
            }
            return View(progenitor);
        }

        // POST: Progenitores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Sexo,Edad")] Progenitor progenitor)
        {
            if (id != progenitor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(progenitor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgenitorExists(progenitor.Id))
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
            return View(progenitor);
        }

        // GET: Progenitores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var progenitor = await _context.Progenitor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (progenitor == null)
            {
                return NotFound();
            }

            return View(progenitor);
        }

        // POST: Progenitores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var progenitor = await _context.Progenitor.FindAsync(id);
            _context.Progenitor.Remove(progenitor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgenitorExists(int id)
        {
            return _context.Progenitor.Any(e => e.Id == id);
        }
    }
}
