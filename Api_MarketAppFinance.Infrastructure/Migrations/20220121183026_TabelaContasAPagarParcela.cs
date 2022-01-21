using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class TabelaContasAPagarParcela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContaAPagarParcelas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ContaAPagarId = table.Column<int>(type: "integer", nullable: false),
                    NumeroParcela = table.Column<int>(type: "integer", nullable: false),
                    ValorParcela = table.Column<decimal>(type: "numeric", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(2000)", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "date", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "date", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    DataCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaAPagarParcelas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContaAPagarParcelas_ContasAPagar_ContaAPagarId",
                        column: x => x.ContaAPagarId,
                        principalTable: "ContasAPagar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContaAPagarParcelas_ContaAPagarId",
                table: "ContaAPagarParcelas",
                column: "ContaAPagarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContaAPagarParcelas");
        }
    }
}
