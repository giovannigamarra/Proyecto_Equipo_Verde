using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TiendaRopa.Data
{
       public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       public DbSet<TiendaRopa.Models.Contacto> Contacto {get; set;}
        public DbSet<TiendaRopa.Models.Producto> Productos { get; set; }
        public DbSet<TiendaRopa.Models.Usuario> Usuarios { get; set; }
        public DbSet<TiendaRopa.Models.OrdenDetail> OrdenDetails { get; set; }
    }
}

