﻿// <auto-generated />
using System;
using MetricsForceApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MetricsForceApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211015135844_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MetricsForceApp.Models.Comissao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("GerenteId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("MesReferencia")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric");

                    b.Property<int?>("VendedorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GerenteId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Comissoes");
                });

            modelBuilder.Entity("MetricsForceApp.Models.IndicadorDePerformance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("GerenteId")
                        .HasColumnType("integer");

                    b.Property<int>("QuantidadeVenda")
                        .HasColumnType("integer");

                    b.Property<decimal>("TicketMedio")
                        .HasColumnType("numeric");

                    b.Property<int?>("VendedorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GerenteId");

                    b.HasIndex("VendedorId");

                    b.ToTable("IndicadoresDePerformance");
                });

            modelBuilder.Entity("MetricsForceApp.Models.Meta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("FimMeta")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("GerenteId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("InicioMeta")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("MetaMes")
                        .HasColumnType("numeric");

                    b.Property<int?>("VendedorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GerenteId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Metas");
                });

            modelBuilder.Entity("MetricsForceApp.Models.PercentualComissao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ComissaoId")
                        .HasColumnType("integer");

                    b.Property<float>("PorcentagemComissaoBase")
                        .HasColumnType("real");

                    b.Property<float>("PorcentagemComissaoBronze")
                        .HasColumnType("real");

                    b.Property<float>("PorcentagemComissaoDiamante")
                        .HasColumnType("real");

                    b.Property<float>("PorcentagemComissaoOuro")
                        .HasColumnType("real");

                    b.Property<float>("PorcentagemComissaoPrata")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ComissaoId");

                    b.ToTable("PercentuaisComissao");
                });

            modelBuilder.Entity("MetricsForceApp.Models.RegistroVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CodigoVendedor")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("QuantidadeItens")
                        .HasColumnType("integer");

                    b.Property<decimal>("ValorVenda")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("RegistroVendas");
                });

            modelBuilder.Entity("MetricsForceApp.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("CodigoFuncionario")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("character varying(6)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.HasIndex("CodigoFuncionario")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuarios");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuario");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MetricsForceApp.Models.Administrador", b =>
                {
                    b.HasBaseType("MetricsForceApp.Models.Usuario");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("MetricsForceApp.Models.Gerente", b =>
                {
                    b.HasBaseType("MetricsForceApp.Models.Usuario");

                    b.HasDiscriminator().HasValue("Gerente");
                });

            modelBuilder.Entity("MetricsForceApp.Models.Vendedor", b =>
                {
                    b.HasBaseType("MetricsForceApp.Models.Usuario");

                    b.HasDiscriminator().HasValue("Vendedor");
                });

            modelBuilder.Entity("MetricsForceApp.Models.Comissao", b =>
                {
                    b.HasOne("MetricsForceApp.Models.Gerente", "Gerente")
                        .WithMany("Comissoes")
                        .HasForeignKey("GerenteId");

                    b.HasOne("MetricsForceApp.Models.Vendedor", "Vendedor")
                        .WithMany("Comissoes")
                        .HasForeignKey("VendedorId");

                    b.Navigation("Gerente");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("MetricsForceApp.Models.IndicadorDePerformance", b =>
                {
                    b.HasOne("MetricsForceApp.Models.Gerente", "Gerente")
                        .WithMany("IndicadoresDePerformance")
                        .HasForeignKey("GerenteId");

                    b.HasOne("MetricsForceApp.Models.Vendedor", "Vendedor")
                        .WithMany("IndicadoresDePerformance")
                        .HasForeignKey("VendedorId");

                    b.Navigation("Gerente");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("MetricsForceApp.Models.Meta", b =>
                {
                    b.HasOne("MetricsForceApp.Models.Gerente", "Gerente")
                        .WithMany("Metas")
                        .HasForeignKey("GerenteId");

                    b.HasOne("MetricsForceApp.Models.Vendedor", "Vendedor")
                        .WithMany("Metas")
                        .HasForeignKey("VendedorId");

                    b.Navigation("Gerente");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("MetricsForceApp.Models.PercentualComissao", b =>
                {
                    b.HasOne("MetricsForceApp.Models.Comissao", "Comissao")
                        .WithMany()
                        .HasForeignKey("ComissaoId");

                    b.Navigation("Comissao");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MetricsForceApp.Models.Gerente", b =>
                {
                    b.Navigation("Comissoes");

                    b.Navigation("IndicadoresDePerformance");

                    b.Navigation("Metas");
                });

            modelBuilder.Entity("MetricsForceApp.Models.Vendedor", b =>
                {
                    b.Navigation("Comissoes");

                    b.Navigation("IndicadoresDePerformance");

                    b.Navigation("Metas");
                });
#pragma warning restore 612, 618
        }
    }
}
