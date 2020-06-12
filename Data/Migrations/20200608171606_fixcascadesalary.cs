using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollAppRazorPages.Data.Migrations
{
    public partial class fixcascadesalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffSalary_AspNetUsers_staffID",
                table: "StaffSalary");

            migrationBuilder.AlterColumn<string>(
                name: "staffID",
                table: "StaffSalary",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "EIS",
                table: "StaffSalary",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "EREIS",
                table: "StaffSalary",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffSalary_AspNetUsers_staffID",
                table: "StaffSalary",
                column: "staffID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffSalary_AspNetUsers_staffID",
                table: "StaffSalary");

            migrationBuilder.DropColumn(
                name: "EIS",
                table: "StaffSalary");

            migrationBuilder.DropColumn(
                name: "EREIS",
                table: "StaffSalary");

            migrationBuilder.AlterColumn<string>(
                name: "staffID",
                table: "StaffSalary",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_StaffSalary_AspNetUsers_staffID",
                table: "StaffSalary",
                column: "staffID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
