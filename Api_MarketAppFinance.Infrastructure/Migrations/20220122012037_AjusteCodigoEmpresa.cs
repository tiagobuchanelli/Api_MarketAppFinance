using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class AjusteCodigoEmpresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "VendaProdutos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "VendaParcelas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "VendaFormasPagamento",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "LicencaAcessos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "ImagensProduto",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Enderecos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Dispositivos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "ContaAReceberParcelas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "ContaAPagarParcelas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VendaProdutos_EmpresaId",
                table: "VendaProdutos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaParcelas_EmpresaId",
                table: "VendaParcelas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaFormasPagamento_EmpresaId",
                table: "VendaFormasPagamento",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_LicencaAcessos_EmpresaId",
                table: "LicencaAcessos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagensProduto_EmpresaId",
                table: "ImagensProduto",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_EmpresaId",
                table: "Enderecos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dispositivos_EmpresaId",
                table: "Dispositivos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContaAReceberParcelas_EmpresaId",
                table: "ContaAReceberParcelas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContaAPagarParcelas_EmpresaId",
                table: "ContaAPagarParcelas",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContaAPagarParcelas_Empresas_EmpresaId",
                table: "ContaAPagarParcelas",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContaAReceberParcelas_Empresas_EmpresaId",
                table: "ContaAReceberParcelas",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dispositivos_Empresas_EmpresaId",
                table: "Dispositivos",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Empresas_EmpresaId",
                table: "Enderecos",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImagensProduto_Empresas_EmpresaId",
                table: "ImagensProduto",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LicencaAcessos_Empresas_EmpresaId",
                table: "LicencaAcessos",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VendaFormasPagamento_Empresas_EmpresaId",
                table: "VendaFormasPagamento",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VendaParcelas_Empresas_EmpresaId",
                table: "VendaParcelas",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProdutos_Empresas_EmpresaId",
                table: "VendaProdutos",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContaAPagarParcelas_Empresas_EmpresaId",
                table: "ContaAPagarParcelas");

            migrationBuilder.DropForeignKey(
                name: "FK_ContaAReceberParcelas_Empresas_EmpresaId",
                table: "ContaAReceberParcelas");

            migrationBuilder.DropForeignKey(
                name: "FK_Dispositivos_Empresas_EmpresaId",
                table: "Dispositivos");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Empresas_EmpresaId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_ImagensProduto_Empresas_EmpresaId",
                table: "ImagensProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_LicencaAcessos_Empresas_EmpresaId",
                table: "LicencaAcessos");

            migrationBuilder.DropForeignKey(
                name: "FK_VendaFormasPagamento_Empresas_EmpresaId",
                table: "VendaFormasPagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_VendaParcelas_Empresas_EmpresaId",
                table: "VendaParcelas");

            migrationBuilder.DropForeignKey(
                name: "FK_VendaProdutos_Empresas_EmpresaId",
                table: "VendaProdutos");

            migrationBuilder.DropIndex(
                name: "IX_VendaProdutos_EmpresaId",
                table: "VendaProdutos");

            migrationBuilder.DropIndex(
                name: "IX_VendaParcelas_EmpresaId",
                table: "VendaParcelas");

            migrationBuilder.DropIndex(
                name: "IX_VendaFormasPagamento_EmpresaId",
                table: "VendaFormasPagamento");

            migrationBuilder.DropIndex(
                name: "IX_LicencaAcessos_EmpresaId",
                table: "LicencaAcessos");

            migrationBuilder.DropIndex(
                name: "IX_ImagensProduto_EmpresaId",
                table: "ImagensProduto");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_EmpresaId",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Dispositivos_EmpresaId",
                table: "Dispositivos");

            migrationBuilder.DropIndex(
                name: "IX_ContaAReceberParcelas_EmpresaId",
                table: "ContaAReceberParcelas");

            migrationBuilder.DropIndex(
                name: "IX_ContaAPagarParcelas_EmpresaId",
                table: "ContaAPagarParcelas");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "VendaProdutos");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "VendaParcelas");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "VendaFormasPagamento");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "LicencaAcessos");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "ImagensProduto");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Dispositivos");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "ContaAReceberParcelas");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "ContaAPagarParcelas");
        }
    }
}
