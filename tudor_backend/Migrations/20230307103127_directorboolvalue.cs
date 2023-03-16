using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tudorbackend.Migrations
{
    /// <inheritdoc />
    public partial class directorboolvalue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Contracts_Confirmation_Received",
                table: "TblDirector",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Contracts_Confirmation_Received",
                table: "TblDirector",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");
        }
    }
}
