using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Database.MySql.Migrations
{
    public partial class addeddeletedbytoaccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Accounts",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedByDateTime",
                table: "Accounts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "Accounts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_DeletedById",
                table: "Accounts",
                column: "DeletedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Users_DeletedById",
                table: "Accounts",
                column: "DeletedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Users_DeletedById",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_DeletedById",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "DeletedByDateTime",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Accounts");
        }
    }
}
