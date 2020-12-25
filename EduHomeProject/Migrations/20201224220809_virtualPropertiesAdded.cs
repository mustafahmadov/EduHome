using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class virtualPropertiesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasDeletedTime",
                table: "BlogDetails");

            migrationBuilder.AddColumn<bool>(
                name: "HasDeleted",
                table: "BlogDetails",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasDeleted",
                table: "BlogDetails");

            migrationBuilder.AddColumn<bool>(
                name: "HasDeletedTime",
                table: "BlogDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
