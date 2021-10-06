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
    public class PercentualComissaoMapping : IEntityTypeConfiguration<PercentualComissao>
    {
        public void Configure(EntityTypeBuilder<PercentualComissao> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.PorcentagemComissaoBase)
                .HasColumnType("decimal(5,2)")
                .HasColumnName("PorcentagemComissaoBase")
                .IsRequired();

            builder.Property(p => p.PorcentagemComissaoBronze)
                .HasColumnType("decimal(5,2)")
                .HasColumnName("PorcentagemComissaoBronze")
                .IsRequired();

            builder.Property(p => p.PorcentagemComissaoPrata)
                .HasColumnType("decimal(5,2)")
                .HasColumnName("PorcentagemComissaoPrata")
                .IsRequired();

            builder.Property(p => p.PorcentagemComissaoOuro)
                .HasColumnType("decimal(5,2)")
                .HasColumnName("PorcentagemComissaoOuro")
                .IsRequired();

            builder.Property(p => p.PorcentagemComissaoDiamante)
                .HasColumnType("decimal(5,2)")
                .HasColumnName("PorcentagemComissaoDiamante")
                .IsRequired();

            builder.ToTable("PercentualComissao");
        }
    }
}
