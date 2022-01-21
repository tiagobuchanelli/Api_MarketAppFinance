using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class TabelaContasAPagar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "VendaFormasPagamento");

            migrationBuilder.CreateTable(
                name: "ContasAPagar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpresaId = table.Column<int>(type: "integer", nullable: false),
                    CodigoLancamentoId = table.Column<int>(type: "integer", nullable: false),
                    CarteiraId = table.Column<int>(type: "integer", nullable: false),
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
                    table.PrimaryKey("PK_ContasAPagar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContasAPagar_Carteiras_CarteiraId",
                        column: x => x.CarteiraId,
                        principalTable: "Carteiras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContasAPagar_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContasAPagar_FormasPagamento_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "FormasPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContasAPagar_CarteiraId",
                table: "ContasAPagar",
                column: "CarteiraId");

            migrationBuilder.CreateIndex(
                name: "IX_ContasAPagar_EmpresaId",
                table: "ContasAPagar",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContasAPagar_FormaPagamentoId",
                table: "ContasAPagar",
                column: "FormaPagamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContasAPagar");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "VendaFormasPagamento",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
