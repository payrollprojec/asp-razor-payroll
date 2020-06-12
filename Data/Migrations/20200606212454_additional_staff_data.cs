using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollAppRazorPages.Data.Migrations
{
    public partial class additional_staff_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "SocsoRm",
                table: "StaffSalary",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Allowances",
                table: "StaffData",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EPF",
                table: "StaffData",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Socso",
                table: "StaffData",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SocsoRm",
                table: "StaffData",
                type: "decimal(18, 2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocsoRm",
                table: "StaffSalary");

            migrationBuilder.DropColumn(
                name: "Allowances",
                table: "StaffData");

            migrationBuilder.DropColumn(
                name: "EPF",
                table: "StaffData");

            migrationBuilder.DropColumn(
                name: "Socso",
                table: "StaffData");

            migrationBuilder.DropColumn(
                name: "SocsoRm",
                table: "StaffData");
        }
    }
}
