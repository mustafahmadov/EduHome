using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeASPNET.Migrations
{
    public partial class TeacherAndTeacherdetails2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Teachers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "HasDeleted",
                table: "Teachers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "TeacherDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "HasDeleted",
                table: "TeacherDetails",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Innovation",
                table: "Skills",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Development",
                table: "Skills",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Design",
                table: "Skills",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Communication",
                table: "Skills",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Skills",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "HasDeleted",
                table: "Skills",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "HasDeleted",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "TeacherDetails");

            migrationBuilder.DropColumn(
                name: "HasDeleted",
                table: "TeacherDetails");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "HasDeleted",
                table: "Skills");

            migrationBuilder.AlterColumn<string>(
                name: "Innovation",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Development",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Design",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Communication",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
