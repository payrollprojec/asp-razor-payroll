using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollAppRazorPages.Data.Migrations
{
    public partial class staffdata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffData_AspNetUsers_ApplicationUserId",
                table: "StaffData");

            migrationBuilder.DropIndex(
                name: "IX_StaffData_ApplicationUserId",
                table: "StaffData");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "StaffData",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StaffData_ApplicationUserId",
                table: "StaffData",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffData_AspNetUsers_ApplicationUserId",
                table: "StaffData",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffData_AspNetUsers_ApplicationUserId",
                table: "StaffData");

            migrationBuilder.DropIndex(
                name: "IX_StaffData_ApplicationUserId",
                table: "StaffData");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "StaffData",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_StaffData_ApplicationUserId",
                table: "StaffData",
                column: "ApplicationUserId",
                unique: true,
                filter: "[ApplicationUserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffData_AspNetUsers_ApplicationUserId",
                table: "StaffData",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
