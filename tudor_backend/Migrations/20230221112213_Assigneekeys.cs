using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tudorbackend.Migrations
{
    /// <inheritdoc />
    public partial class Assigneekeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TblAssignee_Request_id",
                table: "TblAssignee",
                column: "Request_id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblAssignee_TblRequest_Request_id",
                table: "TblAssignee",
                column: "Request_id",
                principalTable: "TblRequest",
                principalColumn: "Request_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblAssignee_TblStaff_Staff_id",
                table: "TblAssignee",
                column: "Staff_id",
                principalTable: "TblStaff",
                principalColumn: "Staff_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblAssignee_TblRequest_Request_id",
                table: "TblAssignee");

            migrationBuilder.DropForeignKey(
                name: "FK_TblAssignee_TblStaff_Staff_id",
                table: "TblAssignee");

            migrationBuilder.DropIndex(
                name: "IX_TblAssignee_Request_id",
                table: "TblAssignee");
        }
    }
}
