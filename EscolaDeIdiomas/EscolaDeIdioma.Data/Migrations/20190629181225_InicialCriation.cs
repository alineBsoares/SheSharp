using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaDeIdioma.Data.Migrations
{
    public partial class InicialCriation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cpf = table.Column<string>(maxLength: 11, nullable: false),
                    nome = table.Column<string>(maxLength: 100, nullable: false),
                    dataNascimento = table.Column<DateTime>(nullable: false),
                    telefone = table.Column<string>(maxLength: 11, nullable: false),
                    email = table.Column<string>(nullable: false),
                    ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cpf = table.Column<string>(maxLength: 11, nullable: false),
                    nome = table.Column<string>(nullable: false),
                    dataNascimento = table.Column<DateTime>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    telefone = table.Column<string>(maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    turma = table.Column<string>(nullable: false),
                    periodo = table.Column<string>(nullable: false),
                    idioma = table.Column<string>(nullable: true),
                    sala = table.Column<int>(nullable: false),
                    nivel = table.Column<string>(nullable: false),
                    periodo_conclusao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Professores");

            migrationBuilder.DropTable(
                name: "Turmas");
        }
    }
}
