using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CA_EFHastaneOtomasyon.Migrations
{
    /// <inheritdoc />
    public partial class initialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hastalars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HastaAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastaSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tckn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastalars", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TahlilSonuclaris",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TahlilZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TahlilDosyaLinki = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastalarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TahlilSonuclaris", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TahlilSonuclaris_Hastalars_HastalarId",
                        column: x => x.HastalarId,
                        principalTable: "Hastalars",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TahlilSonuclaris_HastalarId",
                table: "TahlilSonuclaris",
                column: "HastalarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TahlilSonuclaris");

            migrationBuilder.DropTable(
                name: "Hastalars");
        }
    }
}
