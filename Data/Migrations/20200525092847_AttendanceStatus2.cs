using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollAppRazorPages.Data.Migrations
{
    public partial class AttendanceStatus2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_AttendanceStatus_AttendanceStatusId1",
                table: "Attendance");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_AttendanceStatusId1",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "AttendanceStatusId1",
                table: "Attendance");

            migrationBuilder.AlterColumn<int>(
                name: "AttendanceStatusId",
                table: "Attendance",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_AttendanceStatusId",
                table: "Attendance",
                column: "AttendanceStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_AttendanceStatus_AttendanceStatusId",
                table: "Attendance",
                column: "AttendanceStatusId",
                principalTable: "AttendanceStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_AttendanceStatus_AttendanceStatusId",
                table: "Attendance");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_AttendanceStatusId",
                table: "Attendance");

            migrationBuilder.AlterColumn<string>(
                name: "AttendanceStatusId",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "AttendanceStatusId1",
                table: "Attendance",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_AttendanceStatusId1",
                table: "Attendance",
                column: "AttendanceStatusId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_AttendanceStatus_AttendanceStatusId1",
                table: "Attendance",
                column: "AttendanceStatusId1",
                principalTable: "AttendanceStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
