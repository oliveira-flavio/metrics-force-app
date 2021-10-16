using MetricsForceApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegistroVenda>().HasData(
                new RegistroVenda { Id = 1, CodigoVendedor = 111111, Data = "2021-10-01", QuantidadeItens = 5, ValorVenda = 500,99 }




                );
        }
    }
}