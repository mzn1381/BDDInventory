using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Presentation.Migrations
{
    public partial class yourMigrationName2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CountProduct",
                table: "Inventories",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "InventoryName",
                table: "Inventories",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Inventories",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountProduct",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "InventoryName",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Inventories");
        }
    }
}
