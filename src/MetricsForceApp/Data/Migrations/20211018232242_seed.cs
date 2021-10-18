using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MetricsForceApp.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "RegistroVendas",
                keyColumn: "Id",
                keyValue: 27);
        }
    }
}
