using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContentService.Migrations
{
    /// <inheritdoc />
    public partial class Changingpopularproductmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "PopularProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "PopularProducts");
        }
    }
}
