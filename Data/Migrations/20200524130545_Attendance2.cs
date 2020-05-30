using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollAppRazorPages.Data.Migrations
{
    public partial class Attendance2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_AspNetUsers_ApplicationUserId1",
                table: "Attendance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_ApplicationUserId1",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "AttendanceId",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Attendance");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Attendance",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Attendance",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_ApplicationUserId",
                table: "Attendance",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_AspNetUsers_ApplicationUserId",
                table: "Attendance",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_AspNetUsers_ApplicationUserId",
                table: "Attendance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_ApplicationUserId",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Attendance");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Attendance",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AttendanceId",
                table: "Attendance",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Attendance",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance",
                column: "AttendanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_ApplicationUserId1",
                table: "Attendance",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_AspNetUsers_ApplicationUserId1",
                table: "Attendance",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
