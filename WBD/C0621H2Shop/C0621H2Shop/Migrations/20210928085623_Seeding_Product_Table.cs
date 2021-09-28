using Microsoft.EntityFrameworkCore.Migrations;

namespace C0621H2Shop.Migrations
{
    public partial class Seeding_Product_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Pictures", "Price", "ProductName", "Quantity" },
                values: new object[] { 1, 1, "~/wwwroot/images/iphone12.jpg", 18000000, "iPhone 12", 12 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Pictures", "Price", "ProductName", "Quantity" },
                values: new object[] { 2, 2, "~/wwwroot/images/laptop.jpg", 12000000, "Asus", 10 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Pictures", "Price", "ProductName", "Quantity" },
                values: new object[] { 3, 3, "~/wwwroot/images/pc.jpg", 13500000, "PC", 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);
        }
    }
}
