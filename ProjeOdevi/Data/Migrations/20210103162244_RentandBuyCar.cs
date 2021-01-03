using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjeOdevi.Data.Migrations
{
    public partial class RentandBuyCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuyCar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    gear = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Fuel = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Distance = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    OriginId1 = table.Column<int>(nullable: true),
                    OriginId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuyCar_Categori_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuyCar_Dil_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Dil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuyCar_Origin_OriginId1",
                        column: x => x.OriginId1,
                        principalTable: "Origin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RentCar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    gear = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Fuel = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Distance = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    OriginId1 = table.Column<int>(nullable: true),
                    OriginId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentCar_Categori_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentCar_Dil_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Dil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentCar_Origin_OriginId1",
                        column: x => x.OriginId1,
                        principalTable: "Origin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuyCar_CategoryId",
                table: "BuyCar",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyCar_LanguageId",
                table: "BuyCar",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyCar_OriginId1",
                table: "BuyCar",
                column: "OriginId1");

            migrationBuilder.CreateIndex(
                name: "IX_RentCar_CategoryId",
                table: "RentCar",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RentCar_LanguageId",
                table: "RentCar",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_RentCar_OriginId1",
                table: "RentCar",
                column: "OriginId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyCar");

            migrationBuilder.DropTable(
                name: "RentCar");
        }
    }
}
