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
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(u => u.Login)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(u => u.Senha)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(u => u.CodigoFuncionario)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasIndex(u => new
            {
                u.CodigoFuncionario
            })
                .IsUnique();

            builder.Property(u => u.Cargo)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(u => u.Ativo)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.ToTable("Usuarios");
        }
    }
}
