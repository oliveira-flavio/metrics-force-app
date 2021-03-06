using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MetricsForceApp.Data.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistroVendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoVendedor = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    Data = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    QuantidadeItens = table.Column<int>(type: "integer", nullable: false),
                    ValorVenda = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroVendas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    CodigoFuncionario = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comissoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Valor = table.Column<decimal>(type: "numeric", nullable: false),
                    MesReferencia = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    VendedorId = table.Column<int>(type: "integer", nullable: true),
                    GerenteId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comissoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comissoes_Usuarios_GerenteId",
                        column: x => x.GerenteId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comissoes_Usuarios_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndicadoresDePerformance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TicketMedio = table.Column<decimal>(type: "numeric", nullable: false),
                    QuantidadeVenda = table.Column<int>(type: "integer", nullable: false),
                    Data = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    VendedorId = table.Column<int>(type: "integer", nullable: true),
                    GerenteId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndicadoresDePerformance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndicadoresDePerformance_Usuarios_GerenteId",
                        column: x => x.GerenteId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndicadoresDePerformance_Usuarios_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Metas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VendedorId = table.Column<int>(type: "integer", nullable: false),
                    InicioMeta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FimMeta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    MetaMes = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Metas_Usuarios_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MetasGerentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GerenteId = table.Column<int>(type: "integer", nullable: false),
                    InicioMeta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FimMeta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    MetaMes = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetasGerentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MetasGerentes_Usuarios_GerenteId",
                        column: x => x.GerenteId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PercentuaisComissao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PorcentagemComissaoBase = table.Column<float>(type: "real", nullable: false),
                    PorcentagemComissaoBronze = table.Column<float>(type: "real", nullable: false),
                    PorcentagemComissaoPrata = table.Column<float>(type: "real", nullable: false),
                    PorcentagemComissaoOuro = table.Column<float>(type: "real", nullable: false),
                    PorcentagemComissaoDiamante = table.Column<float>(type: "real", nullable: false),
                    ComissaoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PercentuaisComissao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PercentuaisComissao_Comissoes_ComissaoId",
                        column: x => x.ComissaoId,
                        principalTable: "Comissoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "RegistroVendas",
                columns: new[] { "Id", "CodigoVendedor", "Data", "QuantidadeItens", "ValorVenda" },
                values: new object[,]
                {
                    { 4, "111111", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 500.99m },
                    { 25, "222222", new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 440.99m },
                    { 24, "111111", new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5550.99m },
                    { 23, "111111", new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 900.99m },
                    { 22, "222222", new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 6600.99m },
                    { 21, "111111", new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 400.99m },
                    { 20, "111111", new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4500.99m },
                    { 19, "111111", new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3300.99m },
                    { 18, "111111", new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1500.99m },
                    { 17, "222222", new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 990.99m },
                    { 16, "222222", new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 5990.99m },
                    { 15, "111111", new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 890.99m },
                    { 14, "111111", new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 660.99m },
                    { 13, "222222", new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 7700.99m },
                    { 12, "111111", new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 5500.99m },
                    { 11, "111111", new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 5880.99m },
                    { 10, "111111", new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 5700.99m },
                    { 9, "222222", new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 5600.99m },
                    { 8, "111111", new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5500.99m },
                    { 7, "111111", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1500.99m },
                    { 6, "111111", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1000.99m },
                    { 5, "222222", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 600.99m },
                    { 26, "111111", new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 7800.99m },
                    { 27, "222222", new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 9900.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comissoes_GerenteId",
                table: "Comissoes",
                column: "GerenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Comissoes_VendedorId",
                table: "Comissoes",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_IndicadoresDePerformance_GerenteId",
                table: "IndicadoresDePerformance",
                column: "GerenteId");

            migrationBuilder.CreateIndex(
                name: "IX_IndicadoresDePerformance_VendedorId",
                table: "IndicadoresDePerformance",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Metas_VendedorId",
                table: "Metas",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_MetasGerentes_GerenteId",
                table: "MetasGerentes",
                column: "GerenteId");

            migrationBuilder.CreateIndex(
                name: "IX_PercentuaisComissao_ComissaoId",
                table: "PercentuaisComissao",
                column: "ComissaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CodigoFuncionario",
                table: "Usuarios",
                column: "CodigoFuncionario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "IndicadoresDePerformance");

            migrationBuilder.DropTable(
                name: "Metas");

            migrationBuilder.DropTable(
                name: "MetasGerentes");

            migrationBuilder.DropTable(
                name: "PercentuaisComissao");

            migrationBuilder.DropTable(
                name: "RegistroVendas");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Comissoes");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
