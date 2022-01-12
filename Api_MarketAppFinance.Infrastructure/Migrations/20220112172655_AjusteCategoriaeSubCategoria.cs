using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class AjusteCategoriaeSubCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Empresas",
                newName: "Ativo");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "SubCategorias",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "SubCategorias",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Categorias",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Categorias",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategorias_EmpresaId",
                table: "SubCategorias",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_EmpresaId",
                table: "Categorias",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Empresas_EmpresaId",
                table: "Categorias",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategorias_Empresas_EmpresaId",
                table: "SubCategorias",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Empresas_EmpresaId",
                table: "Categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategorias_Empresas_EmpresaId",
                table: "SubCategorias");

            migrationBuilder.DropIndex(
                name: "IX_SubCategorias_EmpresaId",
                table: "SubCategorias");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_EmpresaId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "SubCategorias");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "SubCategorias");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Categorias");

            migrationBuilder.RenameColumn(
                name: "Ativo",
                table: "Empresas",
                newName: "IsActive");
        }
    }
}
