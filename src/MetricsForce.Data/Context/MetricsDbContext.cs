﻿using AppMetricsForce.Models;
using MetricsForce.Business.Models;
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
        public DbSet<PercentualComissao> PercentuaisComissao { get; set; }
        public DbSet<RegistroVenda> RegistroVendas { get; set; }
        public DbSet<IndicadorDePerformance> IndicadoresDePerformance { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MetricsDbContext).Assembly);

            // Impedir delete cascade
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) 
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
