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
    public class GerenteMapping : IEntityTypeConfiguration<Gerente>
    {
        public void Configure(EntityTypeBuilder<Gerente> builder)
        {

            builder.Property(g => g.Comissao)
                .HasColumnName("Comissão")
                .HasColumnType("decimal(10,2)");

            builder.HasMany(g => g.Metas)
                .WithOne(m => m.Gerente)
                .HasForeignKey(m => m.IdUsuario);

            builder.ToTable("Gerentes");
        }
    }
}
