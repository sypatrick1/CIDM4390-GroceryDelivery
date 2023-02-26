using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food2URazor.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Shopper",
                table: "Shopper");

            migrationBuilder.RenameTable(
                name: "Shopper",
                newName: "Shoppers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shoppers",
                table: "Shoppers",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Shoppers",
                table: "Shoppers");

            migrationBuilder.RenameTable(
                name: "Shoppers",
                newName: "Shopper");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shopper",
                table: "Shopper",
                column: "ID");
        }
    }
}
