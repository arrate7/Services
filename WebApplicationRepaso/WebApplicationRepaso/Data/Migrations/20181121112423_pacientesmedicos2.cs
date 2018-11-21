using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationRepaso.Data.Migrations
{
    public partial class pacientesmedicos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PacientesMedicos_Medico_MedicoNumeroColegiado",
                table: "PacientesMedicos");

            migrationBuilder.DropForeignKey(
                name: "FK_PacientesMedicos_Paciente_PacienteNumSeguridadSocial",
                table: "PacientesMedicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medico",
                table: "Medico");

            migrationBuilder.RenameColumn(
                name: "PacienteNumSeguridadSocial",
                table: "PacientesMedicos",
                newName: "PacienteId");

            migrationBuilder.RenameColumn(
                name: "MedicoNumeroColegiado",
                table: "PacientesMedicos",
                newName: "MedicoId");

            migrationBuilder.RenameIndex(
                name: "IX_PacientesMedicos_PacienteNumSeguridadSocial",
                table: "PacientesMedicos",
                newName: "IX_PacientesMedicos_PacienteId");

            migrationBuilder.RenameIndex(
                name: "IX_PacientesMedicos_MedicoNumeroColegiado",
                table: "PacientesMedicos",
                newName: "IX_PacientesMedicos_MedicoId");

            migrationBuilder.AlterColumn<int>(
                name: "NumSeguridadSocial",
                table: "Paciente",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Paciente",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "NumeroColegiado",
                table: "Medico",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Medico",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medico",
                table: "Medico",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PacientesMedicos_Medico_MedicoId",
                table: "PacientesMedicos",
                column: "MedicoId",
                principalTable: "Medico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PacientesMedicos_Paciente_PacienteId",
                table: "PacientesMedicos",
                column: "PacienteId",
                principalTable: "Paciente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PacientesMedicos_Medico_MedicoId",
                table: "PacientesMedicos");

            migrationBuilder.DropForeignKey(
                name: "FK_PacientesMedicos_Paciente_PacienteId",
                table: "PacientesMedicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medico",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Medico");

            migrationBuilder.RenameColumn(
                name: "PacienteId",
                table: "PacientesMedicos",
                newName: "PacienteNumSeguridadSocial");

            migrationBuilder.RenameColumn(
                name: "MedicoId",
                table: "PacientesMedicos",
                newName: "MedicoNumeroColegiado");

            migrationBuilder.RenameIndex(
                name: "IX_PacientesMedicos_PacienteId",
                table: "PacientesMedicos",
                newName: "IX_PacientesMedicos_PacienteNumSeguridadSocial");

            migrationBuilder.RenameIndex(
                name: "IX_PacientesMedicos_MedicoId",
                table: "PacientesMedicos",
                newName: "IX_PacientesMedicos_MedicoNumeroColegiado");

            migrationBuilder.AlterColumn<int>(
                name: "NumSeguridadSocial",
                table: "Paciente",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "NumeroColegiado",
                table: "Medico",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente",
                column: "NumSeguridadSocial");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medico",
                table: "Medico",
                column: "NumeroColegiado");

            migrationBuilder.AddForeignKey(
                name: "FK_PacientesMedicos_Medico_MedicoNumeroColegiado",
                table: "PacientesMedicos",
                column: "MedicoNumeroColegiado",
                principalTable: "Medico",
                principalColumn: "NumeroColegiado",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PacientesMedicos_Paciente_PacienteNumSeguridadSocial",
                table: "PacientesMedicos",
                column: "PacienteNumSeguridadSocial",
                principalTable: "Paciente",
                principalColumn: "NumSeguridadSocial",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
