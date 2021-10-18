using Microsoft.EntityFrameworkCore.Migrations;

namespace MetricsForceApp.Data.Migrations
{
    public partial class registrovendas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CodigoVendedor",
                table: "RegistroVendas",
                type: "character varying(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CodigoVendedor",
                table: "RegistroVendas",
                type: "integer",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(6)",
                oldMaxLength: 6);
        }
    }
}
