using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClubDesktop.Migrations
{
    /// <inheritdoc />
    public partial class agregandoDatosSemilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Socios",
                columns: new[] { "Id", "ApellidoNombre", "Dirección", "Teléfono" },
                values: new object[,]
                {
                    { 1, "Juan Perez", "9 de julio 2323", "123456" },
                    { 2, "Fulano DeTal", "Av Iriondo 2123", "345678" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Socios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Socios",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
