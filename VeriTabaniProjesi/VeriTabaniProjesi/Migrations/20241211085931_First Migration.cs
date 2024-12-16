using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeriTabaniProjesi.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentcourse_course_course_ID1",
                table: "studentcourse");

            migrationBuilder.DropForeignKey(
                name: "FK_studentcourse_student_student_ID1",
                table: "studentcourse");

            migrationBuilder.DropIndex(
                name: "IX_studentcourse_course_ID1",
                table: "studentcourse");

            migrationBuilder.DropIndex(
                name: "IX_studentcourse_student_ID1",
                table: "studentcourse");

            migrationBuilder.DropColumn(
                name: "course_ID1",
                table: "studentcourse");

            migrationBuilder.DropColumn(
                name: "student_ID1",
                table: "studentcourse");

            migrationBuilder.AlterColumn<string>(
                name: "course_name",
                table: "course",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_studentcourse_course_ID",
                table: "studentcourse",
                column: "course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_course_course_name",
                table: "course",
                column: "course_name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_studentcourse_course_course_ID",
                table: "studentcourse",
                column: "course_ID",
                principalTable: "course",
                principalColumn: "course_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_studentcourse_student_student_ID",
                table: "studentcourse",
                column: "student_ID",
                principalTable: "student",
                principalColumn: "student_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentcourse_course_course_ID",
                table: "studentcourse");

            migrationBuilder.DropForeignKey(
                name: "FK_studentcourse_student_student_ID",
                table: "studentcourse");

            migrationBuilder.DropIndex(
                name: "IX_studentcourse_course_ID",
                table: "studentcourse");

            migrationBuilder.DropIndex(
                name: "IX_course_course_name",
                table: "course");

            migrationBuilder.AddColumn<int>(
                name: "course_ID1",
                table: "studentcourse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "student_ID1",
                table: "studentcourse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "course_name",
                table: "course",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_studentcourse_course_ID1",
                table: "studentcourse",
                column: "course_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_studentcourse_student_ID1",
                table: "studentcourse",
                column: "student_ID1");

            migrationBuilder.AddForeignKey(
                name: "FK_studentcourse_course_course_ID1",
                table: "studentcourse",
                column: "course_ID1",
                principalTable: "course",
                principalColumn: "course_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_studentcourse_student_student_ID1",
                table: "studentcourse",
                column: "student_ID1",
                principalTable: "student",
                principalColumn: "student_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
