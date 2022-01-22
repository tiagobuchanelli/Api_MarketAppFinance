using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class ContasAReceberAPagarParcelasBaixa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContaAPagarParcelaBaixas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpresaId = table.Column<int>(type: "integer", nullable: false),
                    ContaAPagarId = table.Column<int>(type: "integer", nullable: false),
                    FormaPagamentoId = table.Column<int>(type: "integer", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "date", nullable: false),
                    ValorPagamento = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorAcrescimo = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorDesconto = table.Column<decimal>(type: "numeric", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(500)", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    DataCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaAPagarParcelaBaixas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContaAPagarParcelaBaixas_ContasAPagar_ContaAPagarId",
                        column: x => x.ContaAPagarId,
                        principalTable: "ContasAPagar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContaAPagarParcelaBaixas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContaAPagarParcelaBaixas_FormasPagamento_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "FormasPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContaAReceberParcelaBaixas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpresaId = table.Column<int>(type: "integer", nullable: false),
                    ContaAReceberId = table.Column<int>(type: "integer", nullable: false),
                    FormaPagamentoId = table.Column<int>(type: "integer", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "date", nullable: false),
                    ValorPagamento = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorAcrescimo = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorDesconto = table.Column<decimal>(type: "numeric", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(500)", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    DataCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaAReceberParcelaBaixas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContaAReceberParcelaBaixas_ContasAReceber_ContaAReceberId",
                        column: x => x.ContaAReceberId,
                        principalTable: "ContasAReceber",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContaAReceberParcelaBaixas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContaAReceberParcelaBaixas_FormasPagamento_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "FormasPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContaAPagarParcelaBaixas_ContaAPagarId",
                table: "ContaAPagarParcelaBaixas",
                column: "ContaAPagarId");

            migrationBuilder.CreateIndex(
                name: "IX_ContaAPagarParcelaBaixas_EmpresaId",
                table: "ContaAPagarParcelaBaixas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContaAPagarParcelaBaixas_FormaPagamentoId",
                table: "ContaAPagarParcelaBaixas",
                column: "FormaPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContaAReceberParcelaBaixas_ContaAReceberId",
                table: "ContaAReceberParcelaBaixas",
                column: "ContaAReceberId");

            migrationBuilder.CreateIndex(
                name: "IX_ContaAReceberParcelaBaixas_EmpresaId",
                table: "ContaAReceberParcelaBaixas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContaAReceberParcelaBaixas_FormaPagamentoId",
                table: "ContaAReceberParcelaBaixas",
                column: "FormaPagamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContaAPagarParcelaBaixas");

            migrationBuilder.DropTable(
                name: "ContaAReceberParcelaBaixas");
        }
    }
}
