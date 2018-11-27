using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class AlquilerPeliculasController : Controller
    {
        private readonly ApplicationDbContext _context;
        public VideoclubServices videoclubServices;

        public AlquilerPeliculasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AlquilerPeliculas
        public async Task<IActionResult> Index()
        {
        
            return View(await _context.AlquilerPeliculas.Include(x=>x.Alquiler).Include(x=>x.Pelicula).Where(x=>x.AppUser.UserName==User.Identity.Name).ToListAsync());
        }

        // GET: AlquilerPeliculas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alquilerPeliculas = await _context.AlquilerPeliculas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alquilerPeliculas == null)
            {
                return NotFound();
            }

            return View(alquilerPeliculas);
        }

        // GET: AlquilerPeliculas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AlquilerPeliculas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] AlquilerPeliculas alquilerPeliculas)
        {
            if (ModelState.IsValid)
            {

                _context.Add(alquilerPeliculas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alquilerPeliculas);
        }
      

        // GET: AlquilerPeliculas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alquilerPeliculas = await _context.AlquilerPeliculas.FindAsync(id);
            if (alquilerPeliculas == null)
            {
                return NotFound();
            }
            return View(alquilerPeliculas);
        }

        // POST: AlquilerPeliculas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] AlquilerPeliculas alquilerPeliculas)
        {
            if (id != alquilerPeliculas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alquilerPeliculas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlquilerPeliculasExists(alquilerPeliculas.Id))
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
            return View(alquilerPeliculas);
        }

        // GET: AlquilerPeliculas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alquilerPeliculas = await _context.AlquilerPeliculas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alquilerPeliculas == null)
            {
                return NotFound();
            }

            return View(alquilerPeliculas);
        }

        // POST: AlquilerPeliculas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alquilerPeliculas = await _context.AlquilerPeliculas.FindAsync(id);
            _context.AlquilerPeliculas.Remove(alquilerPeliculas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlquilerPeliculasExists(int id)
        {
            return _context.AlquilerPeliculas.Any(e => e.Id == id);
        }
    }
}
