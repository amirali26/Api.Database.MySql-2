using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Database.MySql.Migrations
{
    public partial class addedsequence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "OrderNumbers");

            migrationBuilder.AddColumn<string>(
                name: "OrderNumber",
                table: "Requests",
                type: "text",
                nullable: true,
                defaultValue: "NEXT VALUE FOR shared.OrderNumbers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "OrderNumbers");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "Requests");
        }
    }
}
