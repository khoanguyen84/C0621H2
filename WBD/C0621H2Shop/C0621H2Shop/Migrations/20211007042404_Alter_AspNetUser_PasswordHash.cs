using Microsoft.EntityFrameworkCore.Migrations;

namespace C0621H2Shop.Migrations
{
    public partial class Alter_AspNetUser_PasswordHash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9da711c1-6773-418f-aba2-ed95ec9e86e2", "AQAAAAEAACcQAAAAECrccNOXsWbBBNbhef2pW1U48TdjLJZHsIjDXPmVx0OGKQUCjadaikd1kQDglh2fsw==", "056f6327-44a4-4920-939a-1a7a4fed3c2e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b66cac5f-b565-4495-bfd8-617158efe704", null, "dc1ea003-bab2-4792-96c8-ba5656e3503e" });
        }
    }
}
