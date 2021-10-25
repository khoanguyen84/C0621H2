using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeGymShop.API.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(maxLength: 250, nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Manufactory = table.Column<string>(maxLength: 250, nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Manufactory", "Photo", "Price", "ProductName", "Quantity", "Status" },
                values: new object[] { 1, "Viet Nam", "~/images/iphone12.jpg", 18000000, "iPhone 12", 12, true });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Manufactory", "Photo", "Price", "ProductName", "Quantity", "Status" },
                values: new object[] { 2, "ThaiLand", "~/images/laptop.jpg", 12000000, "Asus", 10, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
