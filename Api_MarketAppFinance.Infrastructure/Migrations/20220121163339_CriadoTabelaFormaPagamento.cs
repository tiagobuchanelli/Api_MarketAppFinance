using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class CriadoTabelaFormaPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormasPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "varchar(300)", nullable: false),
                    Abreviacao = table.Column<string>(type: "varchar(50)", nullable: true),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    EmpresaId = table.Column<int>(type: "integer", nullable: false),
                    CarteiraId = table.Column<int>(type: "integer", nullable: false),
                    TipoPagamento = table.Column<int>(type: "integer", nullable: false),
                    ValorAcrescimo = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorDesconto = table.Column<decimal>(type: "numeric", nullable: false),
                    PrDesconto = table.Column<decimal>(type: "numeric", nullable: false),
                    PrAcrescimo = table.Column<decimal>(type: "numeric", nullable: false),
                    NrDiasIntervalo = table.Column<decimal>(type: "numeric", nullable: false),
                    NrDiasLimiteIntervalo = table.Column<decimal>(type: "numeric", nullable: false),
                    NrIntervalos = table.Column<decimal>(type: "numeric", nullable: false),
                    DiaPadraoVencimento = table.Column<int>(type: "integer", nullable: false),
                    GerarFinanceiro = table.Column<bool>(type: "boolean", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    DataCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormasPagamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormasPagamento_Carteiras_CarteiraId",
                        column: x => x.CarteiraId,
                        principalTable: "Carteiras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormasPagamento_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormasPagamento_CarteiraId",
                table: "FormasPagamento",
                column: "CarteiraId");

            migrationBuilder.CreateIndex(
                name: "IX_FormasPagamento_EmpresaId",
                table: "FormasPagamento",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormasPagamento");
        }
    }
}
