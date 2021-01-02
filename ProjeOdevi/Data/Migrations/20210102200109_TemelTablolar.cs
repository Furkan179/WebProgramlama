using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjeOdevi.Data.Migrations
{
    public partial class TemelTablolar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Film_Kategori_CategoryId",
                table: "Film");

            migrationBuilder.DropForeignKey(
                name: "FK_Film_Dil_LanguageId",
                table: "Film");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategori",
                table: "Kategori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Film",
                table: "Film");

            migrationBuilder.RenameTable(
                name: "Kategori",
                newName: "Categori");

            migrationBuilder.RenameTable(
                name: "Film",
                newName: "Car");

            migrationBuilder.RenameIndex(
                name: "IX_Film_LanguageId",
                table: "Car",
                newName: "IX_Car_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_Film_CategoryId",
                table: "Car",
                newName: "IX_Car_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categori",
                table: "Categori",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Car",
                table: "Car",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Categori_CategoryId",
                table: "Car",
                column: "CategoryId",
                principalTable: "Categori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Dil_LanguageId",
                table: "Car",
                column: "LanguageId",
                principalTable: "Dil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Categori_CategoryId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Dil_LanguageId",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categori",
                table: "Categori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Car",
                table: "Car");

            migrationBuilder.RenameTable(
                name: "Categori",
                newName: "Kategori");

            migrationBuilder.RenameTable(
                name: "Car",
                newName: "Film");

            migrationBuilder.RenameIndex(
                name: "IX_Car_LanguageId",
                table: "Film",
                newName: "IX_Film_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_CategoryId",
                table: "Film",
                newName: "IX_Film_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategori",
                table: "Kategori",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Film",
                table: "Film",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Film_Kategori_CategoryId",
                table: "Film",
                column: "CategoryId",
                principalTable: "Kategori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Film_Dil_LanguageId",
                table: "Film",
                column: "LanguageId",
                principalTable: "Dil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
