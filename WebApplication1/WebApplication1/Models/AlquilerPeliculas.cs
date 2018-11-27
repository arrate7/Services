using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AlquilerPeliculas
    {
        public int Id { get; set; }
        public Alquiler Alquiler { get; set; }
        public Pelicula Pelicula { get; set; }
        public IdentityUser AppUser { get; set; }
    }
}
