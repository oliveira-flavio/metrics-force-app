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
            builder.HasMany(v => v.Metas)
                .WithOne(m => m.Vendedor)
                .HasForeignKey(m => m.IdUsuario);

            builder.HasMany(v => v.Comissoes)
                .WithOne(c => c.Vendedor)
                .HasForeignKey(c => c.IdUsuario);
                
            builder.ToTable("Vendedores");
        }
    }
}
