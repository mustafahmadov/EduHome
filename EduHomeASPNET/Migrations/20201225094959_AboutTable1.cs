using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeASPNET.Migrations
{
    public partial class AboutTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "LeftNotices",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasDeleted",
                table: "LeftNotices",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "LeftNotices");

            migrationBuilder.DropColumn(
                name: "HasDeleted",
                table: "LeftNotices");
        }
    }
}
