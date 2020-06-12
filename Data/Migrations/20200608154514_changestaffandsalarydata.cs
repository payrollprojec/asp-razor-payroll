using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollAppRazorPages.Data.Migrations
{
    public partial class changestaffandsalarydata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "EPF",
                table: "StaffSalary",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "EREPF",
                table: "StaffSalary",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ERSocsoRm",
                table: "StaffSalary",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MailNum",
                table: "StaffSalary",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Tax",
                table: "StaffSalary",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "EPF",
                table: "StaffData",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "EREPF",
                table: "StaffData",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ERSocsoRm",
                table: "StaffData",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Tax",
                table: "StaffData",
                type: "decimal(18, 2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EREPF",
                table: "StaffSalary");

            migrationBuilder.DropColumn(
                name: "ERSocsoRm",
                table: "StaffSalary");

            migrationBuilder.DropColumn(
                name: "MailNum",
                table: "StaffSalary");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "StaffSalary");

            migrationBuilder.DropColumn(
                name: "EREPF",
                table: "StaffData");

            migrationBuilder.DropColumn(
                name: "ERSocsoRm",
                table: "StaffData");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "StaffData");

            migrationBuilder.AlterColumn<int>(
                name: "EPF",
                table: "StaffSalary",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EPF",
                table: "StaffData",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);
        }
    }
}
