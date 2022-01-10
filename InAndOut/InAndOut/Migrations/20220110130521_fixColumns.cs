using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut.Migrations
{
    public partial class fixColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LenderName",
                table: "Items",
                newName: "Lender");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lender",
                table: "Items",
                newName: "LenderName");
        }
    }
}
