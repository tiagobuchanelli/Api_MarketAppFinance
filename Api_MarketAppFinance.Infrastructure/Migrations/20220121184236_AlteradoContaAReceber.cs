using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class AlteradoContaAReceber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "ContasAPagar",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ContasAReceber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpresaId = table.Column<int>(type: "integer", nullable: false),
                    CodigoLancamentoId = table.Column<int>(type: "integer", nullable: false),
                    CarteiraId = table.Column<int>(type: "integer", nullable: false),
                    ClienteId = table.Column<int>(type: "integer", nullable: false),
                    FormaPagamentoId = table.Column<int>(type: "integer", nullable: false),
                    NumeroDocumento = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(2000)", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DataAtualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    DataCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContasAReceber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContasAReceber_Carteiras_CarteiraId",
                        column: x => x.CarteiraId,
                        principalTable: "Carteiras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContasAReceber_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContasAReceber_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContasAReceber_FormasPagamento_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "FormasPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContasAPagar_FornecedorId",
                table: "ContasAPagar",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_ContasAReceber_CarteiraId",
                table: "ContasAReceber",
                column: "CarteiraId");

            migrationBuilder.CreateIndex(
                name: "IX_ContasAReceber_ClienteId",
                table: "ContasAReceber",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ContasAReceber_EmpresaId",
                table: "ContasAReceber",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContasAReceber_FormaPagamentoId",
                table: "ContasAReceber",
                column: "FormaPagamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContasAPagar_Fornecedores_FornecedorId",
                table: "ContasAPagar",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContasAPagar_Fornecedores_FornecedorId",
                table: "ContasAPagar");

            migrationBuilder.DropTable(
                name: "ContasAReceber");

            migrationBuilder.DropIndex(
                name: "IX_ContasAPagar_FornecedorId",
                table: "ContasAPagar");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "ContasAPagar");
        }
    }
}
