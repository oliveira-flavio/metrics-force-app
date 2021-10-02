using AppMetricsForce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsForce.Data.Mapping
{
    public class VendedorMapping : IEntityTypeConfiguration<Vendedor>
    {
        public void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            builder.Property(v => v.Comissao)
                .HasColumnName("Comissão")
                .HasColumnType("decimal(10,2)");

            builder.HasMany(v => v.Metas)
                .WithOne(m => m.Vendedor)
                .HasForeignKey(m => m.UsuarioId);

            builder.ToTable("Vendedores");
        }
    }
}
