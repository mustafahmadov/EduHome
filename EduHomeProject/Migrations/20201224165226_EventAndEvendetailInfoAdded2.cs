using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class EventAndEvendetailInfoAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "EventDetails");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "EventDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "EventDetails");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "EventDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
