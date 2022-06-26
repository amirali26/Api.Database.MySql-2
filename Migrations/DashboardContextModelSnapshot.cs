﻿// <auto-generated />
using System;
using Api.Database.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api.Database.MySql.Migrations
{
    [DbContext(typeof(DashboardContext))]
    partial class DashboardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("AccountUser", b =>
                {
                    b.Property<int>("AccountsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("AccountsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("AccountUser");
                });

            modelBuilder.Entity("Api.Database.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("AreaInRegion")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DeletedByDateTime")
                        .HasColumnType("datetime");

                    b.Property<int?>("DeletedById")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("ExternalId")
                        .HasColumnType("text");

                    b.Property<string>("FirmVerificationCode")
                        .HasColumnType("text");

                    b.Property<bool>("FirmVerified")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("PostCode")
                        .HasColumnType("text");

                    b.Property<string>("Region")
                        .HasColumnType("text");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Size")
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("Website")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("DeletedById");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Api.Database.Models.AccountUserInvitation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("ExternalId")
                        .HasColumnType("text");

                    b.Property<int?>("ReferUserId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ReferUserId");

                    b.ToTable("AccountUserInvitations");
                });

            modelBuilder.Entity("Api.Database.Models.AccountUserPermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("AccountPermission")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("UserId");

                    b.ToTable("AccountUserPermissions");
                });

            modelBuilder.Entity("Api.Database.Models.AreasOfPractice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("ExternalId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("AreasOfPractice");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExternalId = "d3ba0922-a24e-4e11-82bb-5ea04d25e16c",
                            Name = "Family Law"
                        },
                        new
                        {
                            Id = 2,
                            ExternalId = "6fa539f4-bf66-4a13-9ae9-c051c57adb8b",
                            Name = "Consumer Law"
                        },
                        new
                        {
                            Id = 3,
                            ExternalId = "b36dee61-ce14-4bc4-9943-cee671dde98e",
                            Name = "Corporate Law"
                        },
                        new
                        {
                            Id = 4,
                            ExternalId = "4f718103-f998-4acd-8697-9c19c6acfb3a",
                            Name = "Debt and Finance"
                        },
                        new
                        {
                            Id = 5,
                            ExternalId = "ad46cb40-a55b-46fd-ad21-cafe330a389e",
                            Name = "Property Law"
                        });
                });

            modelBuilder.Entity("Api.Database.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("ExternalId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Api.Database.Models.Enquiry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<int>("EnquiryNumber")
                        .HasColumnType("int");

                    b.Property<int?>("EstimatedPrice")
                        .HasColumnType("int");

                    b.Property<string>("ExternalId")
                        .HasColumnType("text");

                    b.Property<int>("InitialConsultationFee")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<bool>("OfficeAppointment")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("PhoneAppointment")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("RequestId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("nvarchar(24)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("VideoCallAppointment")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("RequestId");

                    b.HasIndex("UserId");

                    b.ToTable("Enquiries");
                });

            modelBuilder.Entity("Api.Database.Models.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AreaInRegion")
                        .HasColumnType("text");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ExternalId")
                        .HasColumnType("text");

                    b.Property<string>("PostCode")
                        .HasColumnType("text");

                    b.Property<string>("Region")
                        .HasColumnType("text");

                    b.Property<int>("RequestNumber")
                        .HasColumnType("int");

                    b.Property<bool>("ShowPhoneNumber")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("RequestNumber")
                        .IsUnique();

                    b.HasIndex("TopicId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("Api.Database.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("ExternalId")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<int?>("UserApprovalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserApprovalId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Api.Database.Models.UserApproval", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AdmissionDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ExternalId")
                        .HasColumnType("text");

                    b.Property<string>("IdentificationImage")
                        .HasColumnType("text");

                    b.Property<string>("PassportNumber")
                        .HasColumnType("text");

                    b.Property<int>("SraNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserApproval");
                });

            modelBuilder.Entity("AccountUser", b =>
                {
                    b.HasOne("Api.Database.Models.Account", null)
                        .WithMany()
                        .HasForeignKey("AccountsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Database.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api.Database.Models.Account", b =>
                {
                    b.HasOne("Api.Database.Models.User", "CreatedBy")
                        .WithMany("CreatedAccounts")
                        .HasForeignKey("CreatedById");

                    b.HasOne("Api.Database.Models.User", "DeletedBy")
                        .WithMany("DeletedAccounts")
                        .HasForeignKey("DeletedById");

                    b.Navigation("CreatedBy");

                    b.Navigation("DeletedBy");
                });

            modelBuilder.Entity("Api.Database.Models.AccountUserInvitation", b =>
                {
                    b.HasOne("Api.Database.Models.Account", "Account")
                        .WithMany("AccountUserInvitations")
                        .HasForeignKey("AccountId");

                    b.HasOne("Api.Database.Models.User", "ReferUser")
                        .WithMany("AccountUserInvitations")
                        .HasForeignKey("ReferUserId");

                    b.Navigation("Account");

                    b.Navigation("ReferUser");
                });

            modelBuilder.Entity("Api.Database.Models.AccountUserPermission", b =>
                {
                    b.HasOne("Api.Database.Models.Account", "Account")
                        .WithMany("AccountUserPermissions")
                        .HasForeignKey("AccountId");

                    b.HasOne("Api.Database.Models.User", "User")
                        .WithMany("AccountUserPermissions")
                        .HasForeignKey("UserId");

                    b.Navigation("Account");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Api.Database.Models.AreasOfPractice", b =>
                {
                    b.HasOne("Api.Database.Models.Account", null)
                        .WithMany("AreasOfPractice")
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("Api.Database.Models.Enquiry", b =>
                {
                    b.HasOne("Api.Database.Models.Account", "Account")
                        .WithMany("Enquiries")
                        .HasForeignKey("AccountId");

                    b.HasOne("Api.Database.Models.Request", "Request")
                        .WithMany("Enquiries")
                        .HasForeignKey("RequestId");

                    b.HasOne("Api.Database.Models.User", "User")
                        .WithMany("Enquiries")
                        .HasForeignKey("UserId");

                    b.Navigation("Account");

                    b.Navigation("Request");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Api.Database.Models.Request", b =>
                {
                    b.HasOne("Api.Database.Models.Client", "Client")
                        .WithMany("Requests")
                        .HasForeignKey("ClientId");

                    b.HasOne("Api.Database.Models.AreasOfPractice", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId");

                    b.Navigation("Client");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("Api.Database.Models.User", b =>
                {
                    b.HasOne("Api.Database.Models.UserApproval", "UserApproval")
                        .WithOne("User")
                        .HasForeignKey("Api.Database.Models.User", "UserApprovalId");

                    b.Navigation("UserApproval");
                });

            modelBuilder.Entity("Api.Database.Models.Account", b =>
                {
                    b.Navigation("AccountUserInvitations");

                    b.Navigation("AccountUserPermissions");

                    b.Navigation("AreasOfPractice");

                    b.Navigation("Enquiries");
                });

            modelBuilder.Entity("Api.Database.Models.Client", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("Api.Database.Models.Request", b =>
                {
                    b.Navigation("Enquiries");
                });

            modelBuilder.Entity("Api.Database.Models.User", b =>
                {
                    b.Navigation("AccountUserInvitations");

                    b.Navigation("AccountUserPermissions");

                    b.Navigation("CreatedAccounts");

                    b.Navigation("DeletedAccounts");

                    b.Navigation("Enquiries");
                });

            modelBuilder.Entity("Api.Database.Models.UserApproval", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
