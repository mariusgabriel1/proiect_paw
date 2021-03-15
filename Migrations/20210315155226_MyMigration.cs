using Microsoft.EntityFrameworkCore.Migrations;

namespace proiect.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "conturi",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Timestamp = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conturi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cheltuieli",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Suma = table.Column<float>(type: "REAL", nullable: false),
                    Timestamp = table.Column<int>(type: "INTEGER", nullable: false),
                    TipCheltuiala = table.Column<int>(type: "INTEGER", nullable: false),
                    ContId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cheltuieli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cheltuieli_conturi_ContId",
                        column: x => x.ContId,
                        principalTable: "conturi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "venituri",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Suma = table.Column<float>(type: "REAL", nullable: false),
                    Timestamp = table.Column<int>(type: "INTEGER", nullable: false),
                    TipVenit = table.Column<int>(type: "INTEGER", nullable: false),
                    ContId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_venituri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_venituri_conturi_ContId",
                        column: x => x.ContId,
                        principalTable: "conturi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cheltuieli_ContId",
                table: "cheltuieli",
                column: "ContId");

            migrationBuilder.CreateIndex(
                name: "IX_venituri_ContId",
                table: "venituri",
                column: "ContId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cheltuieli");

            migrationBuilder.DropTable(
                name: "venituri");

            migrationBuilder.DropTable(
                name: "conturi");
        }
    }
}
