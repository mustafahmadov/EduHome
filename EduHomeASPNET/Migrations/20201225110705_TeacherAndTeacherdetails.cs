using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeASPNET.Migrations
{
    public partial class TeacherAndTeacherdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Profession = table.Column<string>(nullable: false),
                    Facebook = table.Column<string>(nullable: true),
                    Pinterest = table.Column<string>(nullable: true),
                    Vimeo = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Skype = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: false),
                    TeacherDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<int>(nullable: false),
                    TeamLeader = table.Column<int>(nullable: false),
                    Development = table.Column<string>(nullable: true),
                    Design = table.Column<string>(nullable: true),
                    Innovation = table.Column<string>(nullable: true),
                    Communication = table.Column<string>(nullable: true),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailedImage = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    Hobbies = table.Column<string>(nullable: true),
                    Experience = table.Column<string>(nullable: true),
                    Faculty = table.Column<string>(nullable: true),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherDetails_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_TeacherId",
                table: "Skills",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherDetails_TeacherId",
                table: "TeacherDetails",
                column: "TeacherId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "TeacherDetails");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
