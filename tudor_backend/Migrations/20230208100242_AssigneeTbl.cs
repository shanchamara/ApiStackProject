using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tudorbackend.Migrations
{
    /// <inheritdoc />
    public partial class AssigneeTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblAssignee",
                columns: table => new
                {
                    Staffid = table.Column<int>(name: "Staff_id", type: "int", nullable: false),
                    Requestid = table.Column<int>(name: "Request_id", type: "int", nullable: false),
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
                    table.PrimaryKey("PK_TblAssignee", x => new { x.Staffid, x.Requestid });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TblTransactionDetails",
                columns: table => new
                {
                    Transactionid = table.Column<int>(name: "Transaction_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TableName = table.Column<string>(name: "Table_Name", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Transactiondetails = table.Column<string>(name: "Transaction_details", type: "longtext", nullable: true)
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
                    table.PrimaryKey("PK_TblTransactionDetails", x => x.Transactionid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblAssignee");

            migrationBuilder.DropTable(
                name: "TblTransactionDetails");
        }
    }
}
