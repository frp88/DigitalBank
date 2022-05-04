using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalBank.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    dataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    dataDeCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    situacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numero = table.Column<long>(type: "bigint", nullable: false),
                    saldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    situacao = table.Column<int>(type: "int", nullable: false),
                    dataDeCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataDeFinalizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    clienteid = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Contas_Clientes_clienteid",
                        column: x => x.clienteid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contas_clienteid",
                table: "Contas",
                column: "clienteid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contas");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
