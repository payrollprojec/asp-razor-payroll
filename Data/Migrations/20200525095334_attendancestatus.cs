using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollAppRazorPages.Data.Migrations
{
    public partial class attendancestatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "PunchIn",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "PunchOut",
                table: "Attendance");

            migrationBuilder.AddColumn<int>(
                name: "AttendanceStatusId",
                table: "Attendance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PunchDate",
                table: "Attendance",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AttendanceStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceStatus", x => x.Id);
                });

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

            migrationBuilder.DropTable(
                name: "AttendanceStatus");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_AttendanceStatusId",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "AttendanceStatusId",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "PunchDate",
                table: "Attendance");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PunchIn",
                table: "Attendance",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PunchOut",
                table: "Attendance",
                type: "datetime2",
                nullable: true);
        }
    }
}
