using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alquiler_AspNetUsers_UserId",
                table: "Alquiler");

            migrationBuilder.DropForeignKey(
                name: "FK_AlquilerPeliculas_Alquiler_AlquilerId",
                table: "AlquilerPeliculas");

            migrationBuilder.DropForeignKey(
                name: "FK_AlquilerPeliculas_Pelicula_PeliculaId",
                table: "AlquilerPeliculas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pelicula",
                table: "Pelicula");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alquiler",
                table: "Alquiler");

            migrationBuilder.RenameTable(
                name: "Pelicula",
                newName: "Peliculas");

            migrationBuilder.RenameTable(
                name: "Alquiler",
                newName: "Alquileres");

            migrationBuilder.RenameIndex(
                name: "IX_Alquiler_UserId",
                table: "Alquileres",
                newName: "IX_Alquileres_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peliculas",
                table: "Peliculas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alquileres",
                table: "Alquileres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alquileres_AspNetUsers_UserId",
                table: "Alquileres",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AlquilerPeliculas_Alquileres_AlquilerId",
                table: "AlquilerPeliculas",
                column: "AlquilerId",
                principalTable: "Alquileres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AlquilerPeliculas_Peliculas_PeliculaId",
                table: "AlquilerPeliculas",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alquileres_AspNetUsers_UserId",
                table: "Alquileres");

            migrationBuilder.DropForeignKey(
                name: "FK_AlquilerPeliculas_Alquileres_AlquilerId",
                table: "AlquilerPeliculas");

            migrationBuilder.DropForeignKey(
                name: "FK_AlquilerPeliculas_Peliculas_PeliculaId",
                table: "AlquilerPeliculas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peliculas",
                table: "Peliculas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alquileres",
                table: "Alquileres");

            migrationBuilder.RenameTable(
                name: "Peliculas",
                newName: "Pelicula");

            migrationBuilder.RenameTable(
                name: "Alquileres",
                newName: "Alquiler");

            migrationBuilder.RenameIndex(
                name: "IX_Alquileres_UserId",
                table: "Alquiler",
                newName: "IX_Alquiler_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pelicula",
                table: "Pelicula",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alquiler",
                table: "Alquiler",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alquiler_AspNetUsers_UserId",
                table: "Alquiler",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AlquilerPeliculas_Alquiler_AlquilerId",
                table: "AlquilerPeliculas",
                column: "AlquilerId",
                principalTable: "Alquiler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AlquilerPeliculas_Pelicula_PeliculaId",
                table: "AlquilerPeliculas",
                column: "PeliculaId",
                principalTable: "Pelicula",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
