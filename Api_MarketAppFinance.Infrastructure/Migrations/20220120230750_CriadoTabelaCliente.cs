using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class CriadoTabelaCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "varchar(500)", nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Telefone1 = table.Column<string>(type: "varchar(50)", nullable: true),
                    Telefone2 = table.Column<string>(type: "varchar(50)", nullable: true),
                    Imagem = table.Column<string>(type: "text", nullable: true),
                    EmpresaId = table.Column<int>(type: "integer", nullable: false),
                    Rua = table.Column<string>(type: "varchar(300)", nullable: true),
                    Numero = table.Column<string>(type: "varchar(10)", nullable: true),
                    Cep = table.Column<string>(type: "varchar(20)", nullable: true),
                    Letra = table.Column<string>(type: "varchar(10)", nullable: true),
                    Complemento = table.Column<string>(type: "varchar(100)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(100)", nullable: true),
                    Email = table.Column<string>(type: "varchar(250)", nullable: true),
                    Observacao = table.Column<string>(type: "varchar(500)", nullable: true),
                    NumeroDocumento = table.Column<string>(type: "varchar(100)", nullable: true),
                    ValorMinimoVenda = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorLimiteVenda = table.Column<decimal>(type: "numeric", nullable: false),
                    PrDesconto = table.Column<decimal>(type: "numeric", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    DataCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EmpresaId",
                table: "Clientes",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
