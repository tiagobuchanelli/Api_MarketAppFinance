using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class AlterandoNomeColunaDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Usuarios",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Usuarios",
                newName: "DataAtualizacao");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "SubCategorias",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "SubCategorias",
                newName: "DataAtualizacao");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Produtos",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Produtos",
                newName: "DataAtualizacao");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Marcas",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Marcas",
                newName: "DataAtualizacao");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Licencas",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Licencas",
                newName: "DataAtualizacao");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "LicencaDispositivos",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "LicencaDispositivos",
                newName: "DataAtualizacao");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "ImagensProduto",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "ImagensProduto",
                newName: "DataAtualizacao");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Enderecos",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Enderecos",
                newName: "DataAtualizacao");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Empresas",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Empresas",
                newName: "DataAtualizacao");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Dispositivos",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Dispositivos",
                newName: "DataAtualizacao");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Classificacao",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Classificacao",
                newName: "DataAtualizacao");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Cidades",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Cidades",
                newName: "DataAtualizacao");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Categorias",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Categorias",
                newName: "DataAtualizacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Usuarios",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "Usuarios",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "SubCategorias",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "SubCategorias",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Produtos",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "Produtos",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Marcas",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "Marcas",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Licencas",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "Licencas",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "LicencaDispositivos",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "LicencaDispositivos",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "ImagensProduto",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "ImagensProduto",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Enderecos",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "Enderecos",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Empresas",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "Empresas",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Dispositivos",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "Dispositivos",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Classificacao",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "Classificacao",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Cidades",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "Cidades",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Categorias",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "Categorias",
                newName: "CreateAt");
        }
    }
}
