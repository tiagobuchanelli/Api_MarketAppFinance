using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class AlteracaoFornecedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Licencas_Fornecedores_FornecedorId",
                table: "Licencas");

            migrationBuilder.DropIndex(
                name: "IX_Licencas_FornecedorId",
                table: "Licencas");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "Licencas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "Licencas",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Licencas_FornecedorId",
                table: "Licencas",
                column: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Licencas_Fornecedores_FornecedorId",
                table: "Licencas",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id");
        }
    }
}
