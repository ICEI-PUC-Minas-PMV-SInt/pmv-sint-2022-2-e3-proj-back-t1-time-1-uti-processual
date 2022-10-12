using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTIProcessual.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CadastroProcessos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TipoPenal = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LocalDoCrime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDoCrime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NumeroPCNET = table.Column<int>(type: "int", nullable: false),
                    NumeroREDS = table.Column<int>(type: "int", nullable: false),
                    NumInqueritoPolicial = table.Column<int>(type: "int", nullable: false),
                    NomeReu = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FiliacaoReu = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascReu = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NaturalidadeReu = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EnderecoReu = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefoneReu = table.Column<int>(type: "int", nullable: false),
                    Advogado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    OABAdvogado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefensoriaPublica = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroProcessos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadastroProcessos");
        }
    }
}
