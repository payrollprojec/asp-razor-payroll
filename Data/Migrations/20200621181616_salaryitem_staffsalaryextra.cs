using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollAppRazorPages.Data.Migrations
{
    public partial class salaryitem_staffsalaryextra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalaryItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DefaultAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    IsDeduction = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffSalaryExtra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffSalaryId = table.Column<int>(nullable: false),
                    SalaryItemId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffSalaryExtra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffSalaryExtra_SalaryItem_SalaryItemId",
                        column: x => x.SalaryItemId,
                        principalTable: "SalaryItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffSalaryExtra_StaffSalary_StaffSalaryId",
                        column: x => x.StaffSalaryId,
                        principalTable: "StaffSalary",
                        principalColumn: "salaryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StaffSalaryExtra_SalaryItemId",
                table: "StaffSalaryExtra",
                column: "SalaryItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffSalaryExtra_StaffSalaryId",
                table: "StaffSalaryExtra",
                column: "StaffSalaryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffSalaryExtra");

            migrationBuilder.DropTable(
                name: "SalaryItem");
        }
    }
}
