using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationRepaso.Data.Migrations
{
    public partial class boda4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pareja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreMiembro1 = table.Column<string>(nullable: true),
                    NombreMiembro2 = table.Column<string>(nullable: true),
                    NumeroHijos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pareja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Boda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdPareja = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Lugar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boda_Pareja_IdPareja",
                        column: x => x.IdPareja,
                        principalTable: "Pareja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boda_IdPareja",
                table: "Boda",
                column: "IdPareja");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boda");

            migrationBuilder.DropTable(
                name: "Pareja");
        }
    }
}
