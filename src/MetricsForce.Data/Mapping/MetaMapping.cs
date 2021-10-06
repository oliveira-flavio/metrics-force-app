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
    public class MetaMapping : IEntityTypeConfiguration<Meta>
    {
        public void Configure(EntityTypeBuilder<Meta> builder)
        {
            builder.HasKey(m => m.IdMeta);

            builder.Property(m => m.InicioMeta)
                .HasColumnType("DateTime")
                .HasColumnName("InicioMeta")
                .IsRequired();

            builder.Property(m => m.FimMeta)
                .HasColumnType("DateTime")
                .HasColumnName("FimMeta")
                .IsRequired();

            builder.Property(m => m.MetaBronze)
                .HasColumnType("decimal(5,2)")
                .HasColumnName("MetaBronze")
                .IsRequired();

            builder.Property(m => m.MetaPrata)
                .HasColumnType("decimal(5,2)")
                .HasColumnName("MetaPrata")
                .IsRequired();

            builder.Property(m => m.MetaOuro)
                .HasColumnType("decimal(5,2)")
                .HasColumnName("MetaOuro")
                .IsRequired();

            builder.Property(m => m.MetaDiamante)
                .HasColumnType("decimal(5,2)")
                .HasColumnName("MetaDiamante")
                .IsRequired();

            builder.ToTable("Metas");
        }
    }
}
