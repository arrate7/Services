using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationRepaso.Data.Migrations
{
    public partial class boda5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boda_Pareja_IdPareja",
                table: "Boda");

            migrationBuilder.DropIndex(
                name: "IX_Boda_IdPareja",
                table: "Boda");

            migrationBuilder.AddColumn<int>(
                name: "ParejaId",
                table: "Boda",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Boda_ParejaId",
                table: "Boda",
                column: "ParejaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boda_Pareja_ParejaId",
                table: "Boda",
                column: "ParejaId",
                principalTable: "Pareja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boda_Pareja_ParejaId",
                table: "Boda");

            migrationBuilder.DropIndex(
                name: "IX_Boda_ParejaId",
                table: "Boda");

            migrationBuilder.DropColumn(
                name: "ParejaId",
                table: "Boda");

            migrationBuilder.CreateIndex(
                name: "IX_Boda_IdPareja",
                table: "Boda",
                column: "IdPareja");

            migrationBuilder.AddForeignKey(
                name: "FK_Boda_Pareja_IdPareja",
                table: "Boda",
                column: "IdPareja",
                principalTable: "Pareja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
