using MetricsForceApp.Extensions;
using MetricsForceApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetricsForceApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Meta> Metas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PercentualComissao> PercentuaisComissao { get; set; }
        public DbSet<RegistroVenda> RegistroVendas { get; set; }
        public DbSet<IndicadorDePerformance> IndicadoresDePerformance { get; set; }
        public DbSet<Comissao> Comissoes { get; set; }
        public DbSet<Dashboard> Dashboards { get; set; }
        public DbSet<MetaGerente> MetasGerentes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
