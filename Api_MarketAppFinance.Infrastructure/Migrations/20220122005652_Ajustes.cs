using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class Ajustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LicencaDispositivos_Dispositivos_DispositivoId",
                table: "LicencaDispositivos");

            migrationBuilder.DropForeignKey(
                name: "FK_LicencaDispositivos_Licencas_LicencaId",
                table: "LicencaDispositivos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LicencaDispositivos",
                table: "LicencaDispositivos");

            migrationBuilder.RenameTable(
                name: "LicencaDispositivos",
                newName: "LicencaAcessos");

            migrationBuilder.RenameIndex(
                name: "IX_LicencaDispositivos_LicencaId",
                table: "LicencaAcessos",
                newName: "IX_LicencaAcessos_LicencaId");

            migrationBuilder.RenameIndex(
                name: "IX_LicencaDispositivos_DispositivoId",
                table: "LicencaAcessos",
                newName: "IX_LicencaAcessos_DispositivoId");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Vendas",
                type: "varchar(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataSaida",
                table: "Vendas",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "VendaProdutos",
                type: "varchar(500)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "ContasAReceber",
                type: "varchar(500)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "ContasAPagar",
                type: "varchar(500)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "ContaAReceberParcelas",
                type: "varchar(500)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "ContaAPagarParcelas",
                type: "varchar(500)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2000)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LicencaAcessos",
                table: "LicencaAcessos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LicencaAcessos_Dispositivos_DispositivoId",
                table: "LicencaAcessos",
                column: "DispositivoId",
                principalTable: "Dispositivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LicencaAcessos_Licencas_LicencaId",
                table: "LicencaAcessos",
                column: "LicencaId",
                principalTable: "Licencas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LicencaAcessos_Dispositivos_DispositivoId",
                table: "LicencaAcessos");

            migrationBuilder.DropForeignKey(
                name: "FK_LicencaAcessos_Licencas_LicencaId",
                table: "LicencaAcessos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LicencaAcessos",
                table: "LicencaAcessos");

            migrationBuilder.RenameTable(
                name: "LicencaAcessos",
                newName: "LicencaDispositivos");

            migrationBuilder.RenameIndex(
                name: "IX_LicencaAcessos_LicencaId",
                table: "LicencaDispositivos",
                newName: "IX_LicencaDispositivos_LicencaId");

            migrationBuilder.RenameIndex(
                name: "IX_LicencaAcessos_DispositivoId",
                table: "LicencaDispositivos",
                newName: "IX_LicencaDispositivos_DispositivoId");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Vendas",
                type: "varchar(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataSaida",
                table: "Vendas",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "VendaProdutos",
                type: "varchar(500)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "ContasAReceber",
                type: "varchar(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "ContasAPagar",
                type: "varchar(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "ContaAReceberParcelas",
                type: "varchar(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "ContaAPagarParcelas",
                type: "varchar(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LicencaDispositivos",
                table: "LicencaDispositivos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LicencaDispositivos_Dispositivos_DispositivoId",
                table: "LicencaDispositivos",
                column: "DispositivoId",
                principalTable: "Dispositivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LicencaDispositivos_Licencas_LicencaId",
                table: "LicencaDispositivos",
                column: "LicencaId",
                principalTable: "Licencas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
