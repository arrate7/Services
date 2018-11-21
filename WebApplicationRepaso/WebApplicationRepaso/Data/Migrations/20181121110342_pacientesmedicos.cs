using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationRepaso.Data.Migrations
{
    public partial class pacientesmedicos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    NumeroColegiado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Especialidad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.NumeroColegiado);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    NumSeguridadSocial = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.NumSeguridadSocial);
                });

            migrationBuilder.CreateTable(
                name: "PacientesMedicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PacienteNumSeguridadSocial = table.Column<int>(nullable: true),
                    MedicoNumeroColegiado = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacientesMedicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PacientesMedicos_Medico_MedicoNumeroColegiado",
                        column: x => x.MedicoNumeroColegiado,
                        principalTable: "Medico",
                        principalColumn: "NumeroColegiado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PacientesMedicos_Paciente_PacienteNumSeguridadSocial",
                        column: x => x.PacienteNumSeguridadSocial,
                        principalTable: "Paciente",
                        principalColumn: "NumSeguridadSocial",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PacientesMedicos_MedicoNumeroColegiado",
                table: "PacientesMedicos",
                column: "MedicoNumeroColegiado");

            migrationBuilder.CreateIndex(
                name: "IX_PacientesMedicos_PacienteNumSeguridadSocial",
                table: "PacientesMedicos",
                column: "PacienteNumSeguridadSocial");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PacientesMedicos");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
