using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tudorbackend.Migrations
{
    /// <inheritdoc />
    public partial class maintables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblStaff",
                columns: table => new
                {
                    Staffid = table.Column<int>(name: "Staff_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NICno = table.Column<string>(name: "NIC_no", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Joindate = table.Column<DateTime>(name: "Join_date", type: "datetime(6)", nullable: false),
                    Designation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contactno = table.Column<string>(name: "Contact_no", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Category = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<string>(type: "longtext", nullable: true)
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
                    table.PrimaryKey("PK_TblStaff", x => x.Staffid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TblRequest",
                columns: table => new
                {
                    Requestid = table.Column<int>(name: "Request_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FKClientid = table.Column<int>(name: "FKClient_id", type: "int", nullable: false),
                    FKStaffid = table.Column<int>(name: "FKStaff_id", type: "int", nullable: false),
                    Audittype = table.Column<string>(name: "Audit_type", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AuditBackuptype = table.Column<string>(name: "Audit_Backup_type", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Requisitiondate = table.Column<DateTime>(name: "Requisition_date", type: "datetime(6)", nullable: false),
                    Yearend = table.Column<string>(name: "Year_end", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeetingDate = table.Column<DateTime>(name: "Meeting_Date", type: "datetime(6)", nullable: false),
                    MeetingLocation = table.Column<string>(name: "Meeting_Location", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KeyPoints = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Accountingperiod = table.Column<string>(name: "Accounting_period", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Registeredaddress = table.Column<string>(name: "Registered_address", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Legalformofbusiness = table.Column<string>(name: "Legal_form_of_business", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Lastyearauditopinion = table.Column<string>(name: "Last_year_audit_opinion", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Taxconsultant = table.Column<string>(name: "Tax_consultant", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Companysecretaries = table.Column<string>(name: "Company_secretaries", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Reportingfromwork = table.Column<string>(name: "Reporting_from_work", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Clientriskdesignation = table.Column<string>(name: "Client_risk_designation", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReasonforRating = table.Column<string>(name: "Reason_for_Rating", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descriptionofclients = table.Column<string>(name: "Description_of_clients", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Revenuerecognition = table.Column<string>(name: "Revenue_recognition", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Lossofcapitaltest = table.Column<string>(name: "Loss_of_capital_test", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Statedcapital = table.Column<decimal>(name: "Stated_capital", type: "decimal(65,30)", nullable: false),
                    Netassets = table.Column<decimal>(name: "Net_assets", type: "decimal(65,30)", nullable: false),
                    Solvencytest = table.Column<string>(name: "Solvency_test", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Grossprofitration = table.Column<string>(name: "Gross_profit_ration", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Basisselected = table.Column<string>(name: "Basis_selected", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Overallmateriality = table.Column<string>(name: "Overall_materiality", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Performmeeting = table.Column<string>(name: "Perform_meeting", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Performedanalyticalreview = table.Column<bool>(name: "Performed_analytical_review", type: "tinyint(1)", nullable: false),
                    FieldworkAllocateddate = table.Column<DateTime>(name: "Fieldwork_Allocated_date", type: "datetime(6)", nullable: false),
                    FieldworkExpectedcommencementdate = table.Column<DateTime>(name: "Fieldwork_Expected_commencement_date", type: "datetime(6)", nullable: false),
                    FieldworkExpectedcompletiondate = table.Column<DateTime>(name: "Fieldwork_Expected_completion_date", type: "datetime(6)", nullable: false),
                    FieldworkActualcommencementdate = table.Column<DateTime>(name: "Fieldwork_Actual_commencement_date", type: "datetime(6)", nullable: false),
                    FieldworkActualcompletiondate = table.Column<DateTime>(name: "Fieldwork_Actual_completion_date", type: "datetime(6)", nullable: false),
                    FieldworkDuration = table.Column<string>(name: "Fieldwork_Duration", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FieldworkImportantdeadline = table.Column<DateTime>(name: "Fieldwork_Important_deadline", type: "datetime(6)", nullable: false),
                    FieldworkStatus = table.Column<string>(name: "Fieldwork_Status", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Existmeetingdate = table.Column<DateTime>(name: "Exist_meeting_date", type: "datetime(6)", nullable: false),
                    Existmeetingclient = table.Column<string>(name: "Exist_meeting_client", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Remarks = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dateofexistfromfield = table.Column<DateTime>(name: "Date_of_exist_from_field", type: "datetime(6)", nullable: false),
                    Datereportingoffice = table.Column<DateTime>(name: "Date_reporting_office", type: "datetime(6)", nullable: false),
                    Submissionforreviewdate = table.Column<DateTime>(name: "Submission_for_review_date", type: "datetime(6)", nullable: false),
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
                    table.PrimaryKey("PK_TblRequest", x => x.Requestid);
                    table.ForeignKey(
                        name: "FK_TblRequest_TblClient_FKClient_id",
                        column: x => x.FKClientid,
                        principalTable: "TblClient",
                        principalColumn: "Client_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblRequest_TblStaff_FKStaff_id",
                        column: x => x.FKStaffid,
                        principalTable: "TblStaff",
                        principalColumn: "Staff_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TblBottleneck",
                columns: table => new
                {
                    Bottleneckid = table.Column<int>(name: "Bottleneck_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FKRequestid = table.Column<int>(name: "FKRequest_id", type: "int", nullable: false),
                    Deadlinedate = table.Column<DateTime>(name: "Deadline_date", type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOfCommunication = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false),
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
                    table.PrimaryKey("PK_TblBottleneck", x => x.Bottleneckid);
                    table.ForeignKey(
                        name: "FK_TblBottleneck_TblRequest_FKRequest_id",
                        column: x => x.FKRequestid,
                        principalTable: "TblRequest",
                        principalColumn: "Request_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TblChecklist",
                columns: table => new
                {
                    Checklistid = table.Column<int>(name: "Checklist_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FKRequestid = table.Column<int>(name: "FKRequest_id", type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Confirmation = table.Column<bool>(type: "tinyint(1)", nullable: false),
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
                    table.PrimaryKey("PK_TblChecklist", x => x.Checklistid);
                    table.ForeignKey(
                        name: "FK_TblChecklist_TblRequest_FKRequest_id",
                        column: x => x.FKRequestid,
                        principalTable: "TblRequest",
                        principalColumn: "Request_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TblClient_Contact_Person",
                columns: table => new
                {
                    Personid = table.Column<int>(name: "Person_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FKRequestid = table.Column<int>(name: "FKRequest_id", type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Position = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telno = table.Column<string>(name: "Tel_no", type: "longtext", nullable: true)
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
                    table.PrimaryKey("PK_TblClient_Contact_Person", x => x.Personid);
                    table.ForeignKey(
                        name: "FK_TblClient_Contact_Person_TblRequest_FKRequest_id",
                        column: x => x.FKRequestid,
                        principalTable: "TblRequest",
                        principalColumn: "Request_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TblDirector",
                columns: table => new
                {
                    Directorid = table.Column<int>(name: "Director_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FKRequestid = table.Column<int>(name: "FKRequest_id", type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShareHoling = table.Column<int>(name: "Share_Holing", type: "int", nullable: false),
                    ContractsConfirmationReceived = table.Column<int>(name: "Contracts_Confirmation_Received", type: "int", nullable: false),
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
                    table.PrimaryKey("PK_TblDirector", x => x.Directorid);
                    table.ForeignKey(
                        name: "FK_TblDirector_TblRequest_FKRequest_id",
                        column: x => x.FKRequestid,
                        principalTable: "TblRequest",
                        principalColumn: "Request_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TblReview",
                columns: table => new
                {
                    Reviewid = table.Column<int>(name: "Review_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FKRequestid = table.Column<int>(name: "FKRequest_id", type: "int", nullable: false),
                    DateOfSubmission = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Topic = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Details = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QueryDiscussionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
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
                    table.PrimaryKey("PK_TblReview", x => x.Reviewid);
                    table.ForeignKey(
                        name: "FK_TblReview_TblRequest_FKRequest_id",
                        column: x => x.FKRequestid,
                        principalTable: "TblRequest",
                        principalColumn: "Request_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TblTaxComputation",
                columns: table => new
                {
                    Taxid = table.Column<int>(name: "Tax_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FKRequestid = table.Column<int>(name: "FKRequest_id", type: "int", nullable: false),
                    DateOfSubmission = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HandedOverBy = table.Column<int>(type: "int", nullable: false),
                    HandedOverTo = table.Column<int>(type: "int", nullable: false),
                    DateOfReleasedCopy = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    firstcopyapproveddate = table.Column<DateTime>(name: "first_copy_approved_date", type: "datetime(6)", nullable: false),
                    Postingdate = table.Column<DateTime>(name: "Posting_date", type: "datetime(6)", nullable: false),
                    TypedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostingCheckedBy = table.Column<string>(name: "Posting_Checked_By", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CastingCheckedBy = table.Column<string>(name: "Casting_Checked_By", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CorrectionCheckedBy = table.Column<string>(name: "Correction_Checked_By", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CorrectionCheckedDate = table.Column<DateTime>(name: "Correction_Checked_Date", type: "datetime(6)", nullable: false),
                    PartnerReviwedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CopyApprovedDateforDFD = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DFDIssusedOn = table.Column<DateTime>(name: "DFD_IssusedOn", type: "datetime(6)", nullable: false),
                    DfdStatus = table.Column<string>(name: "Dfd_Status", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MLReplyReceiveDate = table.Column<DateTime>(name: "ML_Reply_Receive_Date", type: "datetime(6)", nullable: false),
                    FinalizingMLreplyDate = table.Column<DateTime>(name: "Finalizing_ML_reply_Date", type: "datetime(6)", nullable: false),
                    WPFiledone = table.Column<bool>(name: "W_P_File_done", type: "tinyint(1)", nullable: false),
                    Draftedauditreport = table.Column<bool>(name: "Drafted_audit_report", type: "tinyint(1)", nullable: false),
                    Approvedauditreport = table.Column<bool>(name: "Approved_audit_report", type: "tinyint(1)", nullable: false),
                    Issued13 = table.Column<bool>(name: "Issued_1_3", type: "tinyint(1)", nullable: false),
                    Lastyearauditfeepaid = table.Column<bool>(name: "Last_year_audit_fee_paid", type: "tinyint(1)", nullable: false),
                    Representationreceived = table.Column<bool>(name: "Representation_received", type: "tinyint(1)", nullable: false),
                    Issuefinal = table.Column<bool>(name: "Issue_final", type: "tinyint(1)", nullable: false),
                    Finalissueddate = table.Column<DateTime>(name: "Final_issued_date", type: "datetime(6)", nullable: false),
                    Taxcopyhandedoverdate = table.Column<DateTime>(name: "Taxcopy_handed_over_date", type: "datetime(6)", nullable: false),
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
                    table.PrimaryKey("PK_TblTaxComputation", x => x.Taxid);
                    table.ForeignKey(
                        name: "FK_TblTaxComputation_TblRequest_FKRequest_id",
                        column: x => x.FKRequestid,
                        principalTable: "TblRequest",
                        principalColumn: "Request_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TblBottleneck_FKRequest_id",
                table: "TblBottleneck",
                column: "FKRequest_id");

            migrationBuilder.CreateIndex(
                name: "IX_TblChecklist_FKRequest_id",
                table: "TblChecklist",
                column: "FKRequest_id");

            migrationBuilder.CreateIndex(
                name: "IX_TblClient_Contact_Person_FKRequest_id",
                table: "TblClient_Contact_Person",
                column: "FKRequest_id");

            migrationBuilder.CreateIndex(
                name: "IX_TblDirector_FKRequest_id",
                table: "TblDirector",
                column: "FKRequest_id");

            migrationBuilder.CreateIndex(
                name: "IX_TblRequest_FKClient_id",
                table: "TblRequest",
                column: "FKClient_id");

            migrationBuilder.CreateIndex(
                name: "IX_TblRequest_FKStaff_id",
                table: "TblRequest",
                column: "FKStaff_id");

            migrationBuilder.CreateIndex(
                name: "IX_TblReview_FKRequest_id",
                table: "TblReview",
                column: "FKRequest_id");

            migrationBuilder.CreateIndex(
                name: "IX_TblTaxComputation_FKRequest_id",
                table: "TblTaxComputation",
                column: "FKRequest_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblBottleneck");

            migrationBuilder.DropTable(
                name: "TblChecklist");

            migrationBuilder.DropTable(
                name: "TblClient_Contact_Person");

            migrationBuilder.DropTable(
                name: "TblDirector");

            migrationBuilder.DropTable(
                name: "TblReview");

            migrationBuilder.DropTable(
                name: "TblTaxComputation");

            migrationBuilder.DropTable(
                name: "TblRequest");

            migrationBuilder.DropTable(
                name: "TblStaff");
        }
    }
}
