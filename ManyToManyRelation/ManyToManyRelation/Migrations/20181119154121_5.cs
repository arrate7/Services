using Microsoft.EntityFrameworkCore.Migrations;

namespace ManyToManyRelation.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Student_StudentId",
                table: "StudentCourse");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourse_CourseId",
                table: "StudentCourse");

            migrationBuilder.AddColumn<int>(
                name: "StudentCourseCourseId",
                table: "Student",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentCourseStudentId",
                table: "Student",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentCourseCourseId",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentCourseStudentId",
                table: "Courses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentCourseStudentId_StudentCourseCourseId",
                table: "Student",
                columns: new[] { "StudentCourseStudentId", "StudentCourseCourseId" });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentCourseStudentId_StudentCourseCourseId",
                table: "Courses",
                columns: new[] { "StudentCourseStudentId", "StudentCourseCourseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_StudentCourse_StudentCourseStudentId_StudentCourseCourseId",
                table: "Courses",
                columns: new[] { "StudentCourseStudentId", "StudentCourseCourseId" },
                principalTable: "StudentCourse",
                principalColumns: new[] { "StudentId", "CourseId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_StudentCourse_StudentCourseStudentId_StudentCourseCourseId",
                table: "Student",
                columns: new[] { "StudentCourseStudentId", "StudentCourseCourseId" },
                principalTable: "StudentCourse",
                principalColumns: new[] { "StudentId", "CourseId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_StudentCourse_StudentCourseStudentId_StudentCourseCourseId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_StudentCourse_StudentCourseStudentId_StudentCourseCourseId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_StudentCourseStudentId_StudentCourseCourseId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Courses_StudentCourseStudentId_StudentCourseCourseId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudentCourseCourseId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StudentCourseStudentId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StudentCourseCourseId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudentCourseStudentId",
                table: "Courses");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_CourseId",
                table: "StudentCourse",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Student_StudentId",
                table: "StudentCourse",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
