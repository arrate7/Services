using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class VideoclubServices
    {
        private readonly Data.ApplicationDbContext _context;

        public VideoclubServices()
        {

        }
        public VideoclubServices(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pelicula>> GetPeliculas()
        {
            return (await _context.Peliculas.ToListAsync());
        }
        public void AddAlquiler(AlquilerPeliculas alquiler)
        {
            _context.AlquilerPeliculas.Add(alquiler);
        }
    }
}
