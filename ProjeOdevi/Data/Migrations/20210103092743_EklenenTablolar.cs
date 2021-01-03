using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjeOdevi.Data.Migrations
{
    public partial class EklenenTablolar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Categori_CategoryId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "KategoriId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Car");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "State",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Car",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OriginId",
                table: "Car",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OriginId1",
                table: "Car",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Origin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OriginName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Origin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modeli",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ModelDate = table.Column<DateTime>(nullable: false),
                    OriginId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modeli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modeli_Origin_OriginId",
                        column: x => x.OriginId,
                        principalTable: "Origin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_State_CityId",
                table: "State",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_OriginId1",
                table: "Car",
                column: "OriginId1");

            migrationBuilder.CreateIndex(
                name: "IX_Modeli_OriginId",
                table: "Modeli",
                column: "OriginId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Categori_CategoryId",
                table: "Car",
                column: "CategoryId",
                principalTable: "Categori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Origin_OriginId1",
                table: "Car",
                column: "OriginId1",
                principalTable: "Origin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_State_City_CityId",
                table: "State",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Categori_CategoryId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Origin_OriginId1",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_State_City_CityId",
                table: "State");

            migrationBuilder.DropTable(
                name: "Modeli");

            migrationBuilder.DropTable(
                name: "Origin");

            migrationBuilder.DropIndex(
                name: "IX_State_CityId",
                table: "State");

            migrationBuilder.DropIndex(
                name: "IX_Car_OriginId1",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "State");

            migrationBuilder.DropColumn(
                name: "OriginId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "OriginId1",
                table: "Car");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Car",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "KategoriId",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Car",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Categori_CategoryId",
                table: "Car",
                column: "CategoryId",
                principalTable: "Categori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
