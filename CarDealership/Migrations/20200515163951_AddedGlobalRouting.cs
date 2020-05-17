using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDealership.Migrations
{
    public partial class AddedGlobalRouting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01ddf13d-f4b8-4f73-9735-e0b5943f0740");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Clients",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2113f984-10fc-432e-a2de-a5474ec2b638", "91b9880f-ecd8-4389-9ee1-40e6156e3f9c", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_IdentityUserId",
                table: "Clients",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_AspNetUsers_IdentityUserId",
                table: "Clients",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_AspNetUsers_IdentityUserId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_IdentityUserId",
                table: "Clients");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2113f984-10fc-432e-a2de-a5474ec2b638");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Clients");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01ddf13d-f4b8-4f73-9735-e0b5943f0740", "08a449e6-1350-472c-a513-c70f3fd4d267", "Admin", "ADMIN" });
        }
    }
}
