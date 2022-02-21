using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Database.MySql.Migrations
{
    public partial class accountlocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AreaInRegion",
                table: "Accounts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "Accounts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Accounts",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaInRegion",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "Accounts");
        }
    }
}
