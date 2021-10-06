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

            builder.HasMany(g => g.Comissoes)
                .WithOne(c => c.Gerente)
                .HasForeignKey(c => c.IdUsuario);

            builder.HasMany(g => g.Metas)
                .WithOne(m => m.Gerente)
                .HasForeignKey(m => m.IdUsuario);

            builder.HasMany(g => g.IndicadoresDePerformance)
                .WithOne(p => p.Gerente)
                .HasForeignKey(p => p.IdUsuario);

            builder.ToTable("Gerentes");
        }
    }
}
