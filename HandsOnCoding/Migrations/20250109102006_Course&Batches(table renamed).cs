using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandsOnCoding.Migrations
{
    /// <inheritdoc />
    public partial class CourseBatchestablerenamed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_CourseId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Batches");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CourseId",
                table: "Batches",
                newName: "IX_Batches_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Batches",
                table: "Batches",
                column: "BatchID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Batches_Courses_CourseId",
                table: "Batches",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batches_Courses_CourseId",
                table: "Batches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Batches",
                table: "Batches");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "Batches",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_Batches_CourseId",
                table: "Users",
                newName: "IX_Users_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "BatchID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_CourseId",
                table: "Users",
                column: "CourseId",
                principalTable: "Departments",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
