using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class EventAndEvendetailNewColumsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    OrganizedDay = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    PlacedArea = table.Column<string>(nullable: false),
                    HasDeleted = table.Column<bool>(nullable: false),
                    DeletedTime = table.Column<DateTime>(nullable: true),
                    ExperiedDate = table.Column<bool>(nullable: false),
                    EventDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstContent = table.Column<string>(maxLength: 300, nullable: true),
                    SecondContent = table.Column<string>(maxLength: 300, nullable: true),
                    ThirdContent = table.Column<string>(maxLength: 300, nullable: true),
                    DetailedImage = table.Column<string>(nullable: false),
                    DetailedPlacedArea = table.Column<string>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventDetails_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventDetails_EventId",
                table: "EventDetails",
                column: "EventId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventDetails");

            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
