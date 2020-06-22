using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollAppRazorPages.Data.Migrations
{
    public partial class holidayspellin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HolidaDes",
                table: "Holiday");

            migrationBuilder.AddColumn<string>(
                name: "HolidayDes",
                table: "Holiday",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HolidayDes",
                table: "Holiday");

            migrationBuilder.AddColumn<string>(
                name: "HolidaDes",
                table: "Holiday",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
