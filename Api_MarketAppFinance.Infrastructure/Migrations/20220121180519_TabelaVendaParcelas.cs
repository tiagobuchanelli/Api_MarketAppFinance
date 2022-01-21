using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class TabelaVendaParcelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VendaParcelas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VendaId = table.Column<int>(type: "integer", nullable: false),
                    VendaFormaPagamentoId = table.Column<int>(type: "integer", nullable: false),
                    NumeroParcela = table.Column<int>(type: "integer", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "date", nullable: false),
                    ValorParcela = table.Column<decimal>(type: "numeric", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    DataCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaParcelas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendaParcelas_VendaFormasPagamento_VendaFormaPagamentoId",
                        column: x => x.VendaFormaPagamentoId,
                        principalTable: "VendaFormasPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendaParcelas_Vendas_VendaId",
                        column: x => x.VendaId,
                        principalTable: "Vendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendaParcelas_VendaFormaPagamentoId",
                table: "VendaParcelas",
                column: "VendaFormaPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaParcelas_VendaId",
                table: "VendaParcelas",
                column: "VendaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendaParcelas");
        }
    }
}
