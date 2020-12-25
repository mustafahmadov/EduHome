using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeASPNET.Migrations
{
    public partial class adddatabase1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogDetail_Blogs_BlogId",
                table: "BlogDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogDetail",
                table: "BlogDetail");

            migrationBuilder.RenameTable(
                name: "BlogDetail",
                newName: "BlogDetails");

            migrationBuilder.RenameIndex(
                name: "IX_BlogDetail_BlogId",
                table: "BlogDetails",
                newName: "IX_BlogDetails_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogDetails",
                table: "BlogDetails",
                column: "Id");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogDetails",
                table: "BlogDetails");

            migrationBuilder.RenameTable(
                name: "BlogDetails",
                newName: "BlogDetail");

            migrationBuilder.RenameIndex(
                name: "IX_BlogDetails_BlogId",
                table: "BlogDetail",
                newName: "IX_BlogDetail_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogDetail",
                table: "BlogDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogDetail_Blogs_BlogId",
                table: "BlogDetail",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
