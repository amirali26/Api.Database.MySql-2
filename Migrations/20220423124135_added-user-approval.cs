using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Api.Database.MySql.Migrations
{
    public partial class addeduserapproval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserApprovalId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserApproval",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SraNumber = table.Column<int>(type: "int", nullable: false),
                    AdmissionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PassportNumber = table.Column<string>(type: "text", nullable: true),
                    IdentificationImage = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserApproval", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserApprovalId",
                table: "Users",
                column: "UserApprovalId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserApproval_UserApprovalId",
                table: "Users",
                column: "UserApprovalId",
                principalTable: "UserApproval",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserApproval_UserApprovalId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "UserApproval");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserApprovalId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserApprovalId",
                table: "Users");
        }
    }
}
