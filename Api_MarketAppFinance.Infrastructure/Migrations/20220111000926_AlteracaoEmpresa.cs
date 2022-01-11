using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class AlteracaoEmpresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sobrenome",
                table: "Empresas",
                newName: "NomeCurto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeCurto",
                table: "Empresas",
                newName: "Sobrenome");
        }
    }
}
