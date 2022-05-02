using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopApp.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Products",
                newName: "Color");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Products",
                newName: "Department");
        }
    }
}
