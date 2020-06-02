using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollAppRazorPages.Data.Migrations
{
    public partial class staffdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasicSalary",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateJoined",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EPFNo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SocsoNo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TaxNo",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "StaffData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DOB = table.Column<DateTime>(nullable: true),
                    DateJoined = table.Column<DateTime>(nullable: true),
                    TaxNo = table.Column<string>(nullable: true),
                    EPFNo = table.Column<string>(nullable: true),
                    SocsoNo = table.Column<string>(nullable: true),
                    BasicSalary = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffData_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StaffData_ApplicationUserId",
                table: "StaffData",
                column: "ApplicationUserId",
                unique: true,
                filter: "[ApplicationUserId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffData");

            migrationBuilder.AddColumn<decimal>(
                name: "BasicSalary",
                table: "AspNetUsers",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateJoined",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EPFNo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocsoNo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxNo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
