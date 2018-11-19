using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelosEntidadRelacion.Models;

    public class DDBBContext : DbContext
    {
        public DDBBContext (DbContextOptions<DDBBContext> options)
            : base(options)
        {
        }

        public DbSet<ModelosEntidadRelacion.Models.Adress> Adresses { get; set; }
    public DbSet<ModelosEntidadRelacion.Models.Student> Students { get; set; }
}
