using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tudorbackend.Migrations
{
    /// <inheritdoc />
    public partial class roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "36c9d5b8-e498-4969-bad4-96a4aef6dd00", "b4bdef3a-30ad-44c7-9f18-5c3a4d1167e1", "Admin", "ADMIN" },
                    { "bf8f6d4e-86cb-483a-9b74-e9d80733077f", "81f756e6-77d7-4982-9864-ca2321ffc562", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9d5b8-e498-4969-bad4-96a4aef6dd00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf8f6d4e-86cb-483a-9b74-e9d80733077f");
        }
    }
}
