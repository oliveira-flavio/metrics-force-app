using MetricsForce.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsForce.Data.Mapping
{
    public class ComissaoMapping : IEntityTypeConfiguration<Comissao>
    {
        public void Configure(EntityTypeBuilder<Comissao> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Valor)
                .HasColumnType("decimal(5,2)")
                .HasColumnName("Valor")
                .IsRequired();
           

            builder.Property(c => c.Mes)
                .HasColumnName("MesComissao")
                .HasColumnType("DateTime");

            builder.HasOne(c => c.PercentualComissao)
                .WithOne(p => p.Comissao)
                .HasForeignKey(p => p.);

            builder.ToTable("Comissoes");
        }
    }
}
