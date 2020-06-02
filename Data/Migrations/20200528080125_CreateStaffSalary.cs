using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollAppRazorPages.Data.Migrations
{
    public partial class CreateStaffSalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StaffSalary",
                columns: table => new
                {
                    salaryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    staffID = table.Column<string>(nullable: true),
                    ValidFrom = table.Column<DateTime>(nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Bonus = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Allowances = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EPF = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Socso = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Tax = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AdvSalary = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    GrossSalary = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffSalary", x => x.salaryID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffSalary");
        }
    }
}
