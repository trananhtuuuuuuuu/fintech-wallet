using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class addRelationalDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "ManagementWallets",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ManagementWallets_UserId",
                table: "ManagementWallets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ManagementWallets_Users_UserId",
                table: "ManagementWallets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManagementWallets_Users_UserId",
                table: "ManagementWallets");

            migrationBuilder.DropIndex(
                name: "IX_ManagementWallets_UserId",
                table: "ManagementWallets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ManagementWallets");
        }
    }
}
