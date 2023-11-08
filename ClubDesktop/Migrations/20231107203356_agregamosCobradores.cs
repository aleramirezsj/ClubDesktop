using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubDesktop.Migrations
{
    /// <inheritdoc />
    public partial class agregamosCobradores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cobradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobradores", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cobradores",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Oscar Rodriguez" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cobradores");
        }
    }
}
