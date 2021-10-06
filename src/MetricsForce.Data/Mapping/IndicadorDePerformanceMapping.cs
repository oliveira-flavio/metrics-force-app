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
    public class IndicadorDePerformanceMapping : IEntityTypeConfiguration<IndicadorDePerformance>
    {
        public void Configure(EntityTypeBuilder<IndicadorDePerformance> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.TicketMedio)
                .HasColumnType("decimal(5,2)")
                .HasColumnName("TicketMedio")
                .IsRequired();

            builder.Property(p => p.QuantidadeVenda)
                .HasColumnType("int2")
                .HasColumnName("QuantidadeVenda")
                .IsRequired();

            builder.Property(p => p.Data)
                .HasColumnName("Data");

            builder.ToTable("IndicadoresDePerformance");
        }
    }
}
