using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDealership.Migrations
{
    public partial class AddedSellers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2113f984-10fc-432e-a2de-a5474ec2b638");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Sellers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "350a634b-51c2-4121-bf2a-c04da50650c4", "a4d54f9f-cfee-46a7-bb36-cf660e54e6e8", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_IdentityUserId",
                table: "Sellers",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_AspNetUsers_IdentityUserId",
                table: "Sellers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_AspNetUsers_IdentityUserId",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Sellers_IdentityUserId",
                table: "Sellers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "350a634b-51c2-4121-bf2a-c04da50650c4");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Sellers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2113f984-10fc-432e-a2de-a5474ec2b638", "91b9880f-ecd8-4389-9ee1-40e6156e3f9c", "Admin", "ADMIN" });
        }
    }
}
