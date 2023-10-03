using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthClinic.Migrations
{
    /// <inheritdoc />
    public partial class HC1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Comentario_IdComentario",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Prontuario_IdProntuario",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Prontuario");

            migrationBuilder.RenameColumn(
                name: "IdEspecialidae",
                table: "Especialidade",
                newName: "IdEspecialidade");

            migrationBuilder.RenameColumn(
                name: "IdProntuario",
                table: "Consulta",
                newName: "IdStatusConsulta");

            migrationBuilder.RenameColumn(
                name: "IdComentario",
                table: "Consulta",
                newName: "IdClinica");

            migrationBuilder.RenameColumn(
                name: "DataAgendamento",
                table: "Consulta",
                newName: "DataConsulta");

            migrationBuilder.RenameIndex(
                name: "IX_Consulta_IdProntuario",
                table: "Consulta",
                newName: "IX_Consulta_IdStatusConsulta");

            migrationBuilder.RenameIndex(
                name: "IX_Consulta_IdComentario",
                table: "Consulta",
                newName: "IX_Consulta_IdClinica");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoProntuario",
                table: "Prontuario",
                type: "VARCHAR(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "IdMedico",
                table: "Prontuario",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdPaciente",
                table: "Prontuario",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CRM",
                table: "Medico",
                type: "CHAR(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeMedico",
                table: "Medico",
                type: "VARCHAR(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Consulta",
                type: "VARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR (100)");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Horario",
                table: "Consulta",
                type: "TIME",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.CreateTable(
                name: "StatusConsulta",
                columns: table => new
                {
                    IdStatusConsulta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "VARCHAR(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusConsulta", x => x.IdStatusConsulta);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prontuario_IdMedico",
                table: "Prontuario",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Prontuario_IdPaciente",
                table: "Prontuario",
                column: "IdPaciente");

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Clinica_IdClinica",
                table: "Consulta",
                column: "IdClinica",
                principalTable: "Clinica",
                principalColumn: "IdClinica",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_StatusConsulta_IdStatusConsulta",
                table: "Consulta",
                column: "IdStatusConsulta",
                principalTable: "StatusConsulta",
                principalColumn: "IdStatusConsulta",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prontuario_Medico_IdMedico",
                table: "Prontuario",
                column: "IdMedico",
                principalTable: "Medico",
                principalColumn: "IdMedico",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prontuario_Paciente_IdPaciente",
                table: "Prontuario",
                column: "IdPaciente",
                principalTable: "Paciente",
                principalColumn: "IdPaciente",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Clinica_IdClinica",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_StatusConsulta_IdStatusConsulta",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_Prontuario_Medico_IdMedico",
                table: "Prontuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Prontuario_Paciente_IdPaciente",
                table: "Prontuario");

            migrationBuilder.DropTable(
                name: "StatusConsulta");

            migrationBuilder.DropIndex(
                name: "IX_Prontuario_IdMedico",
                table: "Prontuario");

            migrationBuilder.DropIndex(
                name: "IX_Prontuario_IdPaciente",
                table: "Prontuario");

            migrationBuilder.DropColumn(
                name: "DescricaoProntuario",
                table: "Prontuario");

            migrationBuilder.DropColumn(
                name: "IdMedico",
                table: "Prontuario");

            migrationBuilder.DropColumn(
                name: "IdPaciente",
                table: "Prontuario");

            migrationBuilder.DropColumn(
                name: "CRM",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "NomeMedico",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "Horario",
                table: "Consulta");

            migrationBuilder.RenameColumn(
                name: "IdEspecialidade",
                table: "Especialidade",
                newName: "IdEspecialidae");

            migrationBuilder.RenameColumn(
                name: "IdStatusConsulta",
                table: "Consulta",
                newName: "IdProntuario");

            migrationBuilder.RenameColumn(
                name: "IdClinica",
                table: "Consulta",
                newName: "IdComentario");

            migrationBuilder.RenameColumn(
                name: "DataConsulta",
                table: "Consulta",
                newName: "DataAgendamento");

            migrationBuilder.RenameIndex(
                name: "IX_Consulta_IdStatusConsulta",
                table: "Consulta",
                newName: "IX_Consulta_IdProntuario");

            migrationBuilder.RenameIndex(
                name: "IX_Consulta_IdClinica",
                table: "Consulta",
                newName: "IX_Consulta_IdComentario");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Prontuario",
                type: "VARCHAR (100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Consulta",
                type: "VARCHAR (100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Comentario_IdComentario",
                table: "Consulta",
                column: "IdComentario",
                principalTable: "Comentario",
                principalColumn: "IdComentario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Prontuario_IdProntuario",
                table: "Consulta",
                column: "IdProntuario",
                principalTable: "Prontuario",
                principalColumn: "IdProntuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
