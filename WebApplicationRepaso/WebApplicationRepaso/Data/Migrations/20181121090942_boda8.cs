using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationRepaso.Data.Migrations
{
    public partial class boda8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPareja",
                table: "Boda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPareja",
                table: "Boda",
                nullable: false,
                defaultValue: 0);
        }
    }
}
