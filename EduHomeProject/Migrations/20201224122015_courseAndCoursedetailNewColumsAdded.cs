using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class courseAndCoursedetailNewColumsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Courses",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "CourseDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutApply",
                table: "CourseDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutCertification",
                table: "CourseDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "CourseDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "About",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "AboutApply",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "AboutCertification",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "CourseDetails");
        }
    }
}
