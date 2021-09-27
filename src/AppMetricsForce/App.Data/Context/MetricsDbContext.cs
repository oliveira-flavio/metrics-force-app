using AppMetricsForce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMetricsForce.App.Data.Context
{
    public class MetricsDbContext : DbContext
    {
        public MetricsDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Meta> Metas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
