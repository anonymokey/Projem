using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ResimEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "gorsel3",
                table: "Araclar",
                newName: "Resim3");

            migrationBuilder.RenameColumn(
                name: "gorsel2",
                table: "Araclar",
                newName: "Resim2");

            migrationBuilder.RenameColumn(
                name: "gorsel1",
                table: "Araclar",
                newName: "Resim1");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 4, 24, 1, 20, 24, 625, DateTimeKind.Local).AddTicks(1365));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Resim3",
                table: "Araclar",
                newName: "gorsel3");

            migrationBuilder.RenameColumn(
                name: "Resim2",
                table: "Araclar",
                newName: "gorsel2");

            migrationBuilder.RenameColumn(
                name: "Resim1",
                table: "Araclar",
                newName: "gorsel1");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 4, 22, 18, 5, 10, 409, DateTimeKind.Local).AddTicks(9755));
        }
    }
}
