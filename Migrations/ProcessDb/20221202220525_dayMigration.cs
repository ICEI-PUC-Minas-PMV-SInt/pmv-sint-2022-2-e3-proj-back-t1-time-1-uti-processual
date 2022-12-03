using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace utip_backend.Migrations.ProcessDb
{
    public partial class dayMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Processo",
                columns: table => new
                {
                    ProcessID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumLegalProcess = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    Defendant = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    NaturalidadeReu = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    FiliacaoReu = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    DataNascReu = table.Column<DateTime>(type: "datetime", nullable: true),
                    TelefoneReu = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    DefensoriaPublica = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Attorney = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    TipoPenal = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    DefAddress = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    NumeroREDS = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    DataDoCrime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LocalDoCrime = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    NumInqueritoPolicial = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    IdStatus = table.Column<int>(type: "int", nullable: true),
                    TxStatus = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    days = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processo", x => x.ProcessID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Processo");
        }
    }
}
