using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDealership.Migrations
{
    public partial class AddedVehiclesLayout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "350a634b-51c2-4121-bf2a-c04da50650c4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ba9a874-5710-4b26-96eb-968345145d02", "bc96f630-ce92-4606-9088-67dd337e7d2a", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ba9a874-5710-4b26-96eb-968345145d02");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "350a634b-51c2-4121-bf2a-c04da50650c4", "a4d54f9f-cfee-46a7-bb36-cf660e54e6e8", "Admin", "ADMIN" });
        }
    }
}
