using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollAppRazorPages.Data.Migrations
{
    public partial class advsalaryplus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GrossSalary",
                table: "StaffSalary",
                newName: "AdvSalaryPlus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdvSalaryPlus",
                table: "StaffSalary",
                newName: "GrossSalary");
        }
    }
}
