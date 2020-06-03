using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollAppRazorPages.Data.Migrations
{
    public partial class salarything : Migration
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
                    Month = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Bonus = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Allowances = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EPF = table.Column<int>(nullable: true),
                    Socso = table.Column<int>(nullable: true),
                    AdvSalary = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    GrossSalary = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffSalary", x => x.salaryID);
                    table.ForeignKey(
                        name: "FK_StaffSalary_AspNetUsers_staffID",
                        column: x => x.staffID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StaffSalary_staffID",
                table: "StaffSalary",
                column: "staffID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffSalary");
        }
    }
}
