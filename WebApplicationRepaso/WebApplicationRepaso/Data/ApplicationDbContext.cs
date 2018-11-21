using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationRepaso.Models;

namespace WebApplicationRepaso.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebApplicationRepaso.Models.Boda> Boda { get; set; }
        public DbSet<WebApplicationRepaso.Models.Progenitor> Progenitor { get; set; }
        public DbSet<WebApplicationRepaso.Models.PacientesMedicos> PacientesMedicos { get; set; }
    }
}
