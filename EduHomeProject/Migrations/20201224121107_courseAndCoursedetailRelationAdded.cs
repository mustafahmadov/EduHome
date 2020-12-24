using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class courseAndCoursedetailRelationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseDetailId",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "CourseDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CourseDetails_CourseId",
                table: "CourseDetails",
                column: "CourseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDetails_Courses_CourseId",
                table: "CourseDetails",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDetails_Courses_CourseId",
                table: "CourseDetails");

            migrationBuilder.DropIndex(
                name: "IX_CourseDetails_CourseId",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "CourseDetailId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "CourseDetails");
        }
    }
}
