﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tudor_backend.Context;

#nullable disable

namespace tudorbackend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230203104129_maintables")]
    partial class maintables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TudorApp.DatabaseConnection.TblReview", b =>
                {
                    b.Property<int>("Review_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfSubmission")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Delete_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Delete_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Details")
                        .HasColumnType("longtext");

                    b.Property<string>("Edit_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Edit_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FKRequest_id")
                        .HasColumnType("int")
                        .HasColumnName("FKRequest_id");

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("QueryDiscussionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Topic")
                        .HasColumnType("longtext");

                    b.HasKey("Review_id");

                    b.HasIndex("FKRequest_id");

                    b.ToTable("TblReview");
                });

            modelBuilder.Entity("tudor_backend.Context.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastUpdatedDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("tudor_backend.DatabaseConnection.TblBottleneck", b =>
                {
                    b.Property<int>("Bottleneck_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfCommunication")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Deadline_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Delete_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Delete_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Edit_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Edit_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FKRequest_id")
                        .HasColumnType("int")
                        .HasColumnName("FKRequest_id");

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Bottleneck_id");

                    b.HasIndex("FKRequest_id");

                    b.ToTable("TblBottleneck");
                });

            modelBuilder.Entity("tudor_backend.DatabaseConnection.TblChecklist", b =>
                {
                    b.Property<int>("Checklist_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<bool>("Confirmation")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Delete_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Delete_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Edit_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Edit_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FKRequest_id")
                        .HasColumnType("int")
                        .HasColumnName("FKRequest_id");

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Checklist_id");

                    b.HasIndex("FKRequest_id");

                    b.ToTable("TblChecklist");
                });

            modelBuilder.Entity("tudor_backend.DatabaseConnection.TblClient", b =>
                {
                    b.Property<int>("Client_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.Property<string>("Company_Contact_person")
                        .HasColumnType("longtext");

                    b.Property<string>("Company_Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Contact_no")
                        .HasColumnType("longtext");

                    b.Property<string>("Delete_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Delete_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Designation")
                        .HasColumnType("longtext");

                    b.Property<string>("Edit_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Edit_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Client_id");

                    b.ToTable("TblClient");
                });

            modelBuilder.Entity("tudor_backend.DatabaseConnection.TblClient_Contact_Person", b =>
                {
                    b.Property<int>("Person_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Delete_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Delete_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Edit_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Edit_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FKRequest_id")
                        .HasColumnType("int")
                        .HasColumnName("FKRequest_id");

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Position")
                        .HasColumnType("longtext");

                    b.Property<string>("Tel_no")
                        .HasColumnType("longtext");

                    b.HasKey("Person_id");

                    b.HasIndex("FKRequest_id");

                    b.ToTable("TblClient_Contact_Person");
                });

            modelBuilder.Entity("tudor_backend.DatabaseConnection.TblDirector", b =>
                {
                    b.Property<int>("Director_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Contracts_Confirmation_Received")
                        .HasColumnType("int");

                    b.Property<string>("Delete_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Delete_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Edit_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Edit_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FKRequest_id")
                        .HasColumnType("int")
                        .HasColumnName("FKRequest_id");

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Share_Holing")
                        .HasColumnType("int");

                    b.HasKey("Director_id");

                    b.HasIndex("FKRequest_id");

                    b.ToTable("TblDirector");
                });

            modelBuilder.Entity("tudor_backend.DatabaseConnection.TblRequest", b =>
                {
                    b.Property<int>("Request_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Accounting_period")
                        .HasColumnType("longtext");

                    b.Property<string>("Audit_Backup_type")
                        .HasColumnType("longtext");

                    b.Property<string>("Audit_type")
                        .HasColumnType("longtext");

                    b.Property<string>("Basis_selected")
                        .HasColumnType("longtext");

                    b.Property<string>("Client_risk_designation")
                        .HasColumnType("longtext");

                    b.Property<string>("Company_secretaries")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Date_of_exist_from_field")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Date_reporting_office")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Delete_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Delete_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description_of_clients")
                        .HasColumnType("longtext");

                    b.Property<string>("Edit_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Edit_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Exist_meeting_client")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Exist_meeting_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FKClient_id")
                        .HasColumnType("int")
                        .HasColumnName("FKClient_id");

                    b.Property<int>("FKStaff_id")
                        .HasColumnType("int")
                        .HasColumnName("FKStaff_id");

                    b.Property<DateTime>("Fieldwork_Actual_commencement_date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Fieldwork_Actual_completion_date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Fieldwork_Allocated_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Fieldwork_Duration")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Fieldwork_Expected_commencement_date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Fieldwork_Expected_completion_date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Fieldwork_Important_deadline")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Fieldwork_Status")
                        .HasColumnType("longtext");

                    b.Property<string>("Gross_profit_ration")
                        .HasColumnType("longtext");

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("KeyPoints")
                        .HasColumnType("longtext");

                    b.Property<string>("Last_year_audit_opinion")
                        .HasColumnType("longtext");

                    b.Property<string>("Legal_form_of_business")
                        .HasColumnType("longtext");

                    b.Property<string>("Loss_of_capital_test")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Meeting_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Meeting_Location")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Net_assets")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Overall_materiality")
                        .HasColumnType("longtext");

                    b.Property<string>("Perform_meeting")
                        .HasColumnType("longtext");

                    b.Property<bool>("Performed_analytical_review")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Reason_for_Rating")
                        .HasColumnType("longtext");

                    b.Property<string>("Registered_address")
                        .HasColumnType("longtext");

                    b.Property<string>("Remarks")
                        .HasColumnType("longtext");

                    b.Property<string>("Reporting_from_work")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Requisition_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Revenue_recognition")
                        .HasColumnType("longtext");

                    b.Property<string>("Solvency_test")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Stated_capital")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("Submission_for_review_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Tax_consultant")
                        .HasColumnType("longtext");

                    b.Property<string>("Year_end")
                        .HasColumnType("longtext");

                    b.HasKey("Request_id");

                    b.HasIndex("FKClient_id");

                    b.HasIndex("FKStaff_id");

                    b.ToTable("TblRequest");
                });

            modelBuilder.Entity("tudor_backend.DatabaseConnection.TblStaff", b =>
                {
                    b.Property<int>("Staff_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.Property<string>("Contact_no")
                        .HasColumnType("longtext");

                    b.Property<string>("Delete_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Delete_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Designation")
                        .HasColumnType("longtext");

                    b.Property<string>("Edit_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Edit_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Join_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NIC_no")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .HasColumnType("longtext");

                    b.HasKey("Staff_id");

                    b.ToTable("TblStaff");
                });

            modelBuilder.Entity("tudor_backend.DatabaseConnection.TblTaxComputation", b =>
                {
                    b.Property<int>("Tax_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Approved_audit_report")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Casting_Checked_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CopyApprovedDateforDFD")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Correction_Checked_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Correction_Checked_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DFD_IssusedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateOfReleasedCopy")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateOfSubmission")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Delete_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Delete_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Dfd_Status")
                        .HasColumnType("longtext");

                    b.Property<bool>("Drafted_audit_report")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Edit_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Edit_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FKRequest_id")
                        .HasColumnType("int")
                        .HasColumnName("FKRequest_id");

                    b.Property<DateTime>("Final_issued_date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Finalizing_ML_reply_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("HandedOverBy")
                        .HasColumnType("int");

                    b.Property<int>("HandedOverTo")
                        .HasColumnType("int");

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Issue_final")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Issued_1_3")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Last_year_audit_fee_paid")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("ML_Reply_Receive_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("PartnerReviwedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Posting_Checked_By")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Posting_date")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Representation_received")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Taxcopy_handed_over_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("TypedBy")
                        .HasColumnType("longtext");

                    b.Property<bool>("W_P_File_done")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("first_copy_approved_date")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Tax_id");

                    b.HasIndex("FKRequest_id");

                    b.ToTable("TblTaxComputation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("tudor_backend.Context.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("tudor_backend.Context.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tudor_backend.Context.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("tudor_backend.Context.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TudorApp.DatabaseConnection.TblReview", b =>
                {
                    b.HasOne("tudor_backend.DatabaseConnection.TblRequest", "TblRequest")
                        .WithMany()
                        .HasForeignKey("FKRequest_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblRequest");
                });

            modelBuilder.Entity("tudor_backend.Context.AppUser", b =>
                {
                    b.OwnsMany("tudor_backend.Model.RefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<string>("AppUserId")
                                .HasColumnType("varchar(255)");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            b1.Property<DateTime>("Created")
                                .HasColumnType("datetime(6)");

                            b1.Property<DateTime>("Expires")
                                .HasColumnType("datetime(6)");

                            b1.Property<DateTime?>("Revoked")
                                .HasColumnType("datetime(6)");

                            b1.Property<string>("Token")
                                .HasColumnType("longtext");

                            b1.HasKey("AppUserId", "Id");

                            b1.ToTable("RefreshToken");

                            b1.WithOwner()
                                .HasForeignKey("AppUserId");
                        });

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("tudor_backend.DatabaseConnection.TblBottleneck", b =>
                {
                    b.HasOne("tudor_backend.DatabaseConnection.TblRequest", "TblRequest")
                        .WithMany()
                        .HasForeignKey("FKRequest_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblRequest");
                });

            modelBuilder.Entity("tudor_backend.DatabaseConnection.TblChecklist", b =>
                {
                    b.HasOne("tudor_backend.DatabaseConnection.TblRequest", "TblRequest")
                        .WithMany()
                        .HasForeignKey("FKRequest_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblRequest");
                });

            modelBuilder.Entity("tudor_backend.DatabaseConnection.TblClient_Contact_Person", b =>
                {
                    b.HasOne("tudor_backend.DatabaseConnection.TblRequest", "TblRequest")
                        .WithMany()
                        .HasForeignKey("FKRequest_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblRequest");
                });

            modelBuilder.Entity("tudor_backend.DatabaseConnection.TblDirector", b =>
                {
                    b.HasOne("tudor_backend.DatabaseConnection.TblRequest", "TblRequest")
                        .WithMany()
                        .HasForeignKey("FKRequest_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblRequest");
                });

            modelBuilder.Entity("tudor_backend.DatabaseConnection.TblRequest", b =>
                {
                    b.HasOne("tudor_backend.DatabaseConnection.TblClient", "TblClient")
                        .WithMany()
                        .HasForeignKey("FKClient_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tudor_backend.DatabaseConnection.TblStaff", "TblStaff")
                        .WithMany()
                        .HasForeignKey("FKStaff_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblClient");

                    b.Navigation("TblStaff");
                });

            modelBuilder.Entity("tudor_backend.DatabaseConnection.TblTaxComputation", b =>
                {
                    b.HasOne("tudor_backend.DatabaseConnection.TblRequest", "TblRequest")
                        .WithMany()
                        .HasForeignKey("FKRequest_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblRequest");
                });
#pragma warning restore 612, 618
        }
    }
}
