using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationServices.Models;

namespace WebApplicationServices.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebApplicationServices.Models.Personaje> Personaje { get; set; }
        public DbSet<WebApplicationServices.Models.Response> Response { get; set; }
    }
}
