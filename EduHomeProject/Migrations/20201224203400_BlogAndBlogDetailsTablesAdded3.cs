using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class BlogAndBlogDetailsTablesAdded3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogDetailId",
                table: "Blogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "BlogDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Authors",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasDeleted",
                table: "Authors",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_BlogDetails_BlogId",
                table: "BlogDetails",
                column: "BlogId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogDetails_Blogs_BlogId",
                table: "BlogDetails",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogDetails_Blogs_BlogId",
                table: "BlogDetails");

            migrationBuilder.DropIndex(
                name: "IX_BlogDetails_BlogId",
                table: "BlogDetails");

            migrationBuilder.DropColumn(
                name: "BlogDetailId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "BlogDetails");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "HasDeleted",
                table: "Authors");
        }
    }
}
