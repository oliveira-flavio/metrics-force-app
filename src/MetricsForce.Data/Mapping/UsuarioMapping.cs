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
            builder.HasKey(u => u.IdUsuario);
            builder.Property(u => u.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("varchar(255)");

            builder.Property(u => u.Login)
                .IsRequired()
                .HasColumnName("Login")
                .HasColumnType("varchar(100)");

            builder.Property(u => u.Senha)
                .IsRequired()
                .HasColumnName("Senha")
                .HasColumnType("varchar(100)");

            builder.Property(u => u.CodigoFuncionario)
                .IsRequired()
                .HasColumnName("CodigoFuncionario")
                .HasColumnType("varchar(100)");

            builder.HasIndex(u => new
            {
                u.CodigoFuncionario
            })
                .IsUnique();

            builder.Property(u => u.Cargo)
                .IsRequired()
                .HasColumnName("Cargo")
                .HasColumnType("varchar(100)");

            builder.Property(u => u.Ativo)
                .IsRequired()
                .HasColumnName("Ativo")
                .HasColumnType("varchar(100)");

            builder.ToTable("Usuarios");
        }
    }
}
