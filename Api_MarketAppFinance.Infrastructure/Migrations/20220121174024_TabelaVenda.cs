using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class TabelaVenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpresaId = table.Column<int>(type: "integer", nullable: false),
                    ClienteId = table.Column<int>(type: "integer", nullable: false),
                    CarteiraId = table.Column<int>(type: "integer", nullable: false),
                    FormaPagamentoId = table.Column<int>(type: "integer", nullable: false),
                    NumeroDocumento = table.Column<decimal>(type: "numeric", nullable: false),
                    DataEmissao = table.Column<DateTime>(type: "date", nullable: false),
                    DataSaida = table.Column<DateTime>(type: "date", nullable: false),
                    PesoLiquido = table.Column<decimal>(type: "numeric", nullable: false),
                    PesoBruto = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorFrete = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorDesconto = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorAcrescimo = table.Column<decimal>(type: "numeric", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(2000)", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    DataCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendas_Carteiras_CarteiraId",
                        column: x => x.CarteiraId,
                        principalTable: "Carteiras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vendas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vendas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vendas_FormasPagamento_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "FormasPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_CarteiraId",
                table: "Vendas",
                column: "CarteiraId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ClienteId",
                table: "Vendas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_EmpresaId",
                table: "Vendas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_FormaPagamentoId",
                table: "Vendas",
                column: "FormaPagamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
