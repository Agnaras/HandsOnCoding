using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HandsOnCoding.Migrations
{
    /// <inheritdoc />
    public partial class CourseBatches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseDuration = table.Column<int>(type: "int", nullable: false),
                    CourseStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    BatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.BatchID);
                    table.ForeignKey(
                        name: "FK_Users_Departments_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Departments",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "CourseId", "CourseDescription", "CourseDuration", "CourseName", "CourseStatus" },
                values: new object[,]
                {
                    { 1, "Intermediate java to advance", 40, "java", true },
                    { 2, "Intermediate dotNet to advance", 40, "dotNet", true },
                    { 3, "Intermediate Python to advance", 40, "Python", true },
                    { 4, "Intermediate SharePoint to advance", 40, "SharePoint", true }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "BatchID", "BatchName", "CourseId", "StartFrom" },
                values: new object[,]
                {
                    { 1, "OIL", 1, new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "OIL", 1, new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "OIL", 2, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "OIL", 3, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CourseId",
                table: "Users",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
