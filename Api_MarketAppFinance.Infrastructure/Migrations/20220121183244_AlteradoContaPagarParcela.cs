using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class AlteradoContaPagarParcela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormaPagamentoId",
                table: "ContaAPagarParcelas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ContaAPagarParcelas_FormaPagamentoId",
                table: "ContaAPagarParcelas",
                column: "FormaPagamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContaAPagarParcelas_FormasPagamento_FormaPagamentoId",
                table: "ContaAPagarParcelas",
                column: "FormaPagamentoId",
                principalTable: "FormasPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContaAPagarParcelas_FormasPagamento_FormaPagamentoId",
                table: "ContaAPagarParcelas");

            migrationBuilder.DropIndex(
                name: "IX_ContaAPagarParcelas_FormaPagamentoId",
                table: "ContaAPagarParcelas");

            migrationBuilder.DropColumn(
                name: "FormaPagamentoId",
                table: "ContaAPagarParcelas");
        }
    }
}
