using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class EventAndEvendetailNewtypesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StartTime",
                table: "Events",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "OrganizedDay",
                table: "Events",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "EndTime",
                table: "Events",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "EventDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "HasDeleted",
                table: "EventDetails",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "EventDetails");

            migrationBuilder.DropColumn(
                name: "HasDeleted",
                table: "EventDetails");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Events",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrganizedDay",
                table: "Events",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Events",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
