using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollAppRazorPages.Data.Migrations
{
    public partial class addeisandemployercontrib : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "EIS",
                table: "StaffData",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "EREIS",
                table: "StaffData",
                type: "decimal(18, 2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EIS",
                table: "StaffData");

            migrationBuilder.DropColumn(
                name: "EREIS",
                table: "StaffData");
        }
    }
}
