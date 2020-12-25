using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeASPNET.Migrations
{
    public partial class TeacherAndTeacherdetails1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Skills_TeacherId",
                table: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "Teachers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_TeacherId",
                table: "Skills",
                column: "TeacherId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Skills_TeacherId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "Teachers");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_TeacherId",
                table: "Skills",
                column: "TeacherId");
        }
    }
}
