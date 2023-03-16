using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tudorbackend.Migrations
{
    /// <inheritdoc />
    public partial class securitytbls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblMeetingParticipant",
                columns: table => new
                {
                    Participantid = table.Column<int>(name: "Participant_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FKRequestid = table.Column<int>(name: "FKRequest_id", type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contactno = table.Column<string>(name: "Contact_no", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Isdeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EditBy = table.Column<string>(name: "Edit_By", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeleteBy = table.Column<string>(name: "Delete_By", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EditDate = table.Column<DateTime>(name: "Edit_Date", type: "datetime(6)", nullable: false),
                    DeleteDate = table.Column<DateTime>(name: "Delete_Date", type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMeetingParticipant", x => x.Participantid);
                    table.ForeignKey(
                        name: "FK_TblMeetingParticipant_TblRequest_FKRequest_id",
                        column: x => x.FKRequestid,
                        principalTable: "TblRequest",
                        principalColumn: "Request_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TblMeetingParticipant_FKRequest_id",
                table: "TblMeetingParticipant",
                column: "FKRequest_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblMeetingParticipant");
        }
    }
}
