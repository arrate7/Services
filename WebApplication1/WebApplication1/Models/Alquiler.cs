using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Alquiler
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public IdentityUser User { get; set; }
        public List<AlquilerPeliculas> AlquilerPeliculas { get; set; }

    }
}
