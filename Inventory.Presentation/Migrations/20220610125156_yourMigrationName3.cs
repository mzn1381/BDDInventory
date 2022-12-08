using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Presentation.Migrations
{
    public partial class yourMigrationName3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UnitPrice",
                table: "Inventories",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Inventories");
        }
    }
}
