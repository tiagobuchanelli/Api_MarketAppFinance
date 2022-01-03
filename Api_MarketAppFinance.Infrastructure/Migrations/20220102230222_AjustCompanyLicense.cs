using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    public partial class AjustCompanyLicense : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Licenses_LicenseId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Users_UserId",
                table: "Licenses");

            migrationBuilder.DropIndex(
                name: "IX_Companies_LicenseId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "LicenseId",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Licenses",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Licenses_UserId",
                table: "Licenses",
                newName: "IX_Licenses_CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Companies_CompanyId",
                table: "Licenses",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Companies_CompanyId",
                table: "Licenses");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Licenses",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Licenses_CompanyId",
                table: "Licenses",
                newName: "IX_Licenses_UserId");

            migrationBuilder.AddColumn<int>(
                name: "LicenseId",
                table: "Companies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_LicenseId",
                table: "Companies",
                column: "LicenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Licenses_LicenseId",
                table: "Companies",
                column: "LicenseId",
                principalTable: "Licenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Users_UserId",
                table: "Licenses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
