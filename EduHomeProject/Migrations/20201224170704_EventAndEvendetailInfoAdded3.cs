using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class EventAndEvendetailInfoAdded3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Sliders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Sliders");
        }
    }
}
