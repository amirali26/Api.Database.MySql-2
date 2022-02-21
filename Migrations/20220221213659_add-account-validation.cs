using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Database.MySql.Migrations
{
    public partial class addaccountvalidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirmVerificationCode",
                table: "Accounts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirmVerified",
                table: "Accounts",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirmVerificationCode",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "FirmVerified",
                table: "Accounts");
        }
    }
}
