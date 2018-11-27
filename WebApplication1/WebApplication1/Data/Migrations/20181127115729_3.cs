using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "AlquilerPeliculas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AlquilerPeliculas_AppUserId",
                table: "AlquilerPeliculas",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlquilerPeliculas_AspNetUsers_AppUserId",
                table: "AlquilerPeliculas",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlquilerPeliculas_AspNetUsers_AppUserId",
                table: "AlquilerPeliculas");

            migrationBuilder.DropIndex(
                name: "IX_AlquilerPeliculas_AppUserId",
                table: "AlquilerPeliculas");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "AlquilerPeliculas");
        }
    }
}
