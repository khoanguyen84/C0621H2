using Microsoft.EntityFrameworkCore.Migrations;

namespace C0621H2Shop.Migrations
{
    public partial class Alter_Seeding_AspNetUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "b66cac5f-b565-4495-bfd8-617158efe704", "khoa.nguyen@codegym.vn", "khoa nguyen", "dc1ea003-bab2-4792-96c8-ba5656e3503e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "93624403-f901-4425-98b2-7352c3d124c0", null, null, "27686877-d4d6-485a-ab4f-30625b5ce31f" });
        }
    }
}
