using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class AlteradoContaPagarParcelaNovosCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ValorAcrescimo",
                table: "ContaAPagarParcelas",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorDesconto",
                table: "ContaAPagarParcelas",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorAcrescimo",
                table: "ContaAPagarParcelas");

            migrationBuilder.DropColumn(
                name: "ValorDesconto",
                table: "ContaAPagarParcelas");
        }
    }
}
