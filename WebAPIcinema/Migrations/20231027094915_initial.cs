using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIcinema.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    filmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vizyonTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    filmTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filmIsmi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hIciFiyat = table.Column<float>(type: "real", nullable: false),
                    hSonuFiyat = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.filmId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Film");
        }
    }
}
