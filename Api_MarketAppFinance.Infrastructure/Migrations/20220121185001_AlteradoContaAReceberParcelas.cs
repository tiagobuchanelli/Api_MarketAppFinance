using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class AlteradoContaAReceberParcelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContaAReceberParcelas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ContaAReceberId = table.Column<int>(type: "integer", nullable: false),
                    FormaPagamentoId = table.Column<int>(type: "integer", nullable: false),
                    NumeroParcela = table.Column<int>(type: "integer", nullable: false),
                    ValorParcela = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorAcrescimo = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorDesconto = table.Column<decimal>(type: "numeric", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(2000)", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "date", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "date", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    DataCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaAReceberParcelas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContaAReceberParcelas_ContasAReceber_ContaAReceberId",
                        column: x => x.ContaAReceberId,
                        principalTable: "ContasAReceber",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContaAReceberParcelas_FormasPagamento_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "FormasPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContaAReceberParcelas_ContaAReceberId",
                table: "ContaAReceberParcelas",
                column: "ContaAReceberId");

            migrationBuilder.CreateIndex(
                name: "IX_ContaAReceberParcelas_FormaPagamentoId",
                table: "ContaAReceberParcelas",
                column: "FormaPagamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContaAReceberParcelas");
        }
    }
}
