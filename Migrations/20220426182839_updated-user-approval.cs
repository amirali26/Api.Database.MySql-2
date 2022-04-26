using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Database.MySql.Migrations
{
    public partial class updateduserapproval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExternalId",
                table: "UserApproval",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "UserApproval");
        }
    }
}
