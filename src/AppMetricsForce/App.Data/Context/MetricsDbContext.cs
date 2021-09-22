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
        public DbSet<Administrador> administradores { get; set; }
        public DbSet<Gerente> gerentes { get; set; }
        public DbSet<Vendedor> vendedores { get; set; }
        public DbSet<Meta> metas { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
    }
}
