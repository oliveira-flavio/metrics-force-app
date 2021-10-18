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

        public DbSet<MetaGerente> MetasGerentes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
            //modelBuilder.Entity<RegistroVenda>().HasData(
            //     new RegistroVenda { Id = 4, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 1), QuantidadeItens = 2, ValorVenda = (decimal)500.99 },
            //     new RegistroVenda { Id = 5, CodigoVendedor = "222222", Data = new DateTime(2021, 10, 1), QuantidadeItens = 2, ValorVenda = (decimal)600.99 },
            //     new RegistroVenda { Id = 6, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 1), QuantidadeItens = 6, ValorVenda = (decimal)1000.99 },
            //     new RegistroVenda { Id = 7, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 1), QuantidadeItens = 7, ValorVenda = (decimal)1500.99 },
            //     new RegistroVenda { Id = 8, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 2), QuantidadeItens = 5, ValorVenda = (decimal)5500.99 },
            //     new RegistroVenda { Id = 9, CodigoVendedor = "222222", Data = new DateTime(2021, 10, 2), QuantidadeItens = 8, ValorVenda = (decimal)5600.99 },
            //     new RegistroVenda { Id = 10, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 2), QuantidadeItens = 8, ValorVenda = (decimal)5700.99 },
            //     new RegistroVenda { Id = 11, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 2), QuantidadeItens = 8, ValorVenda = (decimal)5880.99 },
            //     new RegistroVenda { Id = 12, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 2), QuantidadeItens = 6, ValorVenda = (decimal)5500.99 },
            //     new RegistroVenda { Id = 13, CodigoVendedor = "222222", Data = new DateTime(2021, 10, 2), QuantidadeItens = 9, ValorVenda = (decimal)7700.99 },
            //     new RegistroVenda { Id = 14, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 4), QuantidadeItens = 4, ValorVenda = (decimal)660.99 },
            //     new RegistroVenda { Id = 15, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 4), QuantidadeItens = 6, ValorVenda = (decimal)890.99 },
            //     new RegistroVenda { Id = 16, CodigoVendedor = "222222", Data = new DateTime(2021, 10, 4), QuantidadeItens = 6, ValorVenda = (decimal)5990.99 },
            //     new RegistroVenda { Id = 17, CodigoVendedor = "222222", Data = new DateTime(2021, 10, 4), QuantidadeItens = 5, ValorVenda = (decimal)990.99 },
            //     new RegistroVenda { Id = 18, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 4), QuantidadeItens = 8, ValorVenda = (decimal)1500.99 },
            //     new RegistroVenda { Id = 19, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 4), QuantidadeItens = 6, ValorVenda = (decimal)3300.99 },
            //     new RegistroVenda { Id = 20, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 6), QuantidadeItens = 3, ValorVenda = (decimal)4500.99 },
            //     new RegistroVenda { Id = 21, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 6), QuantidadeItens = 8, ValorVenda = (decimal)400.99 },
            //     new RegistroVenda { Id = 22, CodigoVendedor = "222222", Data = new DateTime(2021, 10, 6), QuantidadeItens = 5, ValorVenda = (decimal)6600.99 },
            //     new RegistroVenda { Id = 23, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 6), QuantidadeItens = 8, ValorVenda = (decimal)900.99 },
            //     new RegistroVenda { Id = 24, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 6), QuantidadeItens = 5, ValorVenda = (decimal)5550.99 },
            //     new RegistroVenda { Id = 25, CodigoVendedor = "222222", Data = new DateTime(2021, 10, 7), QuantidadeItens = 4, ValorVenda = (decimal)440.99 },
            //     new RegistroVenda { Id = 26, CodigoVendedor = "111111", Data = new DateTime(2021, 10, 7), QuantidadeItens = 7, ValorVenda = (decimal)7800.99 },
            //     new RegistroVenda { Id = 27, CodigoVendedor = "222222", Data = new DateTime(2021, 10, 7), QuantidadeItens = 6, ValorVenda = (decimal)9900.99 }
            //     );
        }
    }
}
