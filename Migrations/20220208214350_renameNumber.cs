using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Database.MySql.Migrations
{
    public partial class renameNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "OrderNumbers");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "Requests");

            migrationBuilder.AddColumn<string>(
                name: "RequestNumber",
                table: "Requests",
                type: "varchar(767)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequestNumber",
                table: "Requests",
                column: "RequestNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Requests_RequestNumber",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "RequestNumber",
                table: "Requests");

            migrationBuilder.CreateSequence<int>(
                name: "OrderNumbers");

            migrationBuilder.AddColumn<string>(
                name: "OrderNumber",
                table: "Requests",
                type: "text",
                nullable: true,
                defaultValue: "NEXT VALUE FOR shared.OrderNumbers");
        }
    }
}
