using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class CriadoTabelaMovimentacaoProdutosLote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovimentacaoProdutoLotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoLancamento = table.Column<int>(type: "integer", nullable: false),
                    CodigoItem = table.Column<int>(type: "integer", nullable: false),
                    EmpresaId = table.Column<int>(type: "integer", nullable: false),
                    ProdutoId = table.Column<int>(type: "integer", nullable: false),
                    OrigemMovimentacaoProdutoId = table.Column<int>(type: "integer", nullable: false),
                    LoteId = table.Column<int>(type: "integer", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "date", nullable: false),
                    QuantidadeEntrada = table.Column<decimal>(type: "numeric", nullable: false),
                    QuantidadeSaida = table.Column<decimal>(type: "numeric", nullable: false),
                    SaldoAnterior = table.Column<decimal>(type: "numeric", nullable: false),
                    Saldo = table.Column<decimal>(type: "numeric", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    DataCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimentacaoProdutoLotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovimentacaoProdutoLotes_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovimentacaoProdutoLotes_Lotes_LoteId",
                        column: x => x.LoteId,
                        principalTable: "Lotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovimentacaoProdutoLotes_OrigemMovimentacaoProdutos_OrigemM~",
                        column: x => x.OrigemMovimentacaoProdutoId,
                        principalTable: "OrigemMovimentacaoProdutos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovimentacaoProdutoLotes_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovimentacaoProdutoLotes_EmpresaId",
                table: "MovimentacaoProdutoLotes",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimentacaoProdutoLotes_LoteId",
                table: "MovimentacaoProdutoLotes",
                column: "LoteId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimentacaoProdutoLotes_OrigemMovimentacaoProdutoId",
                table: "MovimentacaoProdutoLotes",
                column: "OrigemMovimentacaoProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimentacaoProdutoLotes_ProdutoId",
                table: "MovimentacaoProdutoLotes",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovimentacaoProdutoLotes");
        }
    }
}
