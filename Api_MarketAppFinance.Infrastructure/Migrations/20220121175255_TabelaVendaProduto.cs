using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class TabelaVendaProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Vendas",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "VendaProdutos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoItem = table.Column<int>(type: "integer", nullable: false),
                    VendaId = table.Column<int>(type: "integer", nullable: false),
                    ProdutoId = table.Column<int>(type: "integer", nullable: false),
                    Quantidade = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorDesconto = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorAscrcescimo = table.Column<decimal>(type: "numeric", nullable: false),
                    PrDesconto = table.Column<decimal>(type: "numeric", nullable: false),
                    PesoLiquido = table.Column<decimal>(type: "numeric", nullable: false),
                    PesoBruto = table.Column<decimal>(type: "numeric", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(500)", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    DataCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaProdutos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendaProdutos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendaProdutos_Vendas_VendaId",
                        column: x => x.VendaId,
                        principalTable: "Vendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendaProdutos_ProdutoId",
                table: "VendaProdutos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaProdutos_VendaId",
                table: "VendaProdutos",
                column: "VendaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendaProdutos");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Vendas");
        }
    }
}
