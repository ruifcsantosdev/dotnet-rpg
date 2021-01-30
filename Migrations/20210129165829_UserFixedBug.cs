using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_rpg.Migrations
{
    public partial class UserFixedBug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassowrdSalt",
                table: "Users");

            migrationBuilder.AddColumn<byte[]>(
                name: "PassowordSalt",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassowordSalt",
                table: "Users");

            migrationBuilder.AddColumn<byte[]>(
                name: "PassowrdSalt",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
