﻿// <auto-generated />
using ASPNetCoreIdentityDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ASPNetCoreIdentityDemo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("ASPNetCoreIdentityDemo.Models.Accident", b =>
                {
                    b.Property<int>("AccidentId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AccidentDate");

                    b.Property<string>("ChiefEngineer");

                    b.Property<string>("ControlAction");

                    b.Property<DateTime>("ControlDoneDate");

                    b.Property<DateTime>("ControlDueDate");

                    b.Property<bool>("ControlRectified");

                    b.Property<string>("ControlUpload");

                    b.Property<string>("CorrectiveAction");

                    b.Property<DateTime>("CorrectiveDoneDate");

                    b.Property<DateTime>("CorrectiveDueDate");

                    b.Property<bool>("CorrectiveRectified");

                    b.Property<string>("CorrectiveUpload");

                    b.Property<string>("DescriptionOfEvent");

                    b.Property<string>("LeassonLearned");

                    b.Property<string>("Master");

                    b.Property<string>("Place");

                    b.Property<string>("PreventiveAction");

                    b.Property<DateTime>("PreventiveDoneDate");

                    b.Property<DateTime>("PreventiveDueDate");

                    b.Property<bool>("PreventiveRectified");

                    b.Property<string>("PreventiveUpload");

                    b.Property<string>("Rca");

                    b.Property<string>("ShipNameId");

                    b.Property<string>("TypeOfEvent");

                    b.Property<string>("TypeOfOccurence");

                    b.HasKey("AccidentId");

                    b.ToTable("Accidents");
                });

            modelBuilder.Entity("ASPNetCoreIdentityDemo.Models.ActionCode", b =>
                {
                    b.Property<int>("ActionCodeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodeDescription");

                    b.Property<int>("DefaultCodeId");

                    b.Property<string>("RelatedRootCodeId");

                    b.HasKey("ActionCodeId");

                    b.ToTable("Actions");
                });

            modelBuilder.Entity("ASPNetCoreIdentityDemo.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ASPNetCoreIdentityDemo.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyAddress");

                    b.Property<string>("CompanyCity");

                    b.Property<string>("CompanyCountry");

                    b.Property<string>("CompanyEmail");

                    b.Property<string>("CompanyName");

                    b.Property<string>("CompanyPhone");

                    b.Property<string>("CompanyZip");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("ASPNetCoreIdentityDemo.Models.Flag", b =>
                {
                    b.Property<int>("FlagId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FlagCountry");

                    b.Property<string>("FlagName");

                    b.HasKey("FlagId");

                    b.ToTable("Flags");
                });

            modelBuilder.Entity("ASPNetCoreIdentityDemo.Models.Inspection", b =>
                {
                    b.Property<int>("InspectionId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfInspection");

                    b.Property<string>("FollowUpRectified");

                    b.Property<int>("IsmDefiencies");

                    b.Property<string>("MouName");

                    b.Property<int>("NonIsmDefiencies");

                    b.Property<string>("PortOfInspection");

                    b.Property<bool>("RefusalOfAccess");

                    b.Property<string>("ShipName");

                    b.Property<int>("TotalDefiencies");

                    b.Property<bool>("VesselDetained");

                    b.HasKey("InspectionId");

                    b.ToTable("Inspections");
                });

            modelBuilder.Entity("ASPNetCoreIdentityDemo.Models.IsmDeficiency", b =>
                {
                    b.Property<int>("IsmDeficiencyId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AccidentalDamage");

                    b.Property<string>("Actions");

                    b.Property<string>("ControlAction");

                    b.Property<DateTime>("ControlDoneDate");

                    b.Property<DateTime>("ControlDueDate");

                    b.Property<bool>("ControlRectified");

                    b.Property<string>("ControlUpload");

                    b.Property<string>("CorrectiveAction");

                    b.Property<DateTime>("CorrectiveDoneDate");

                    b.Property<DateTime>("CorrectiveDueDate");

                    b.Property<bool>("CorrectiveRectified");

                    b.Property<string>("CorrectiveUpload");

                    b.Property<string>("DeficiencyCode");

                    b.Property<string>("DescriptionOfDeficiency");

                    b.Property<string>("GroupCode");

                    b.Property<int>("InspectionId");

                    b.Property<string>("PreventiveAction");

                    b.Property<DateTime>("PreventiveDoneDate");

                    b.Property<DateTime>("PreventiveDueDate");

                    b.Property<bool>("PreventiveRectified");

                    b.Property<string>("PreventiveUpload");

                    b.Property<string>("Rca");

                    b.Property<string>("RcaText");

                    b.Property<bool>("Ro");

                    b.HasKey("IsmDeficiencyId");

                    b.ToTable("IsmDeficiencies");
                });

            modelBuilder.Entity("ASPNetCoreIdentityDemo.Models.ParisMouDeficiencyCode", b =>
                {
                    b.Property<int>("ParisMouDeficiencyCodeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DefectiveItem");

                    b.Property<int>("ThetisCode");

                    b.Property<string>("ThetisGroup");

                    b.Property<string>("ThetisSubGroup");

                    b.HasKey("ParisMouDeficiencyCodeId");

                    b.HasIndex("ThetisCode")
                        .IsUnique();

                    b.ToTable("ParisMouDeficiencyCodes");
                });

            modelBuilder.Entity("ASPNetCoreIdentityDemo.Models.RcaCode", b =>
                {
                    b.Property<int>("RcaCodeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodeDescription");

                    b.Property<int>("DefaultCodeId");

                    b.Property<string>("RelatedRootCodeId");

                    b.HasKey("RcaCodeId");

                    b.ToTable("RcaCodes");
                });

            modelBuilder.Entity("ASPNetCoreIdentityDemo.Models.RecognizedOrganization", b =>
                {
                    b.Property<int>("RecognizedOrganizationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RecognizedOrganizationInitials");

                    b.Property<string>("RecognizedOrganizationName");

                    b.Property<string>("RoCarribeanMou");

                    b.Property<string>("RoIndianOceanMou");

                    b.Property<string>("RoMediterraneanMou");

                    b.Property<string>("RoParisMou");

                    b.Property<string>("RoRiyadhMou");

                    b.Property<string>("RoTokyoMou");

                    b.Property<string>("RoUsCoastGuardMou");

                    b.Property<string>("RoVinaDelMarMou");

                    b.HasKey("RecognizedOrganizationId");

                    b.ToTable("RecognizedOrganizations");
                });

            modelBuilder.Entity("ASPNetCoreIdentityDemo.Models.Ship", b =>
                {
                    b.Property<int>("ShipId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassOrganization");

                    b.Property<string>("CompanyName");

                    b.Property<string>("CountryFlag");

                    b.Property<string>("GT");

                    b.Property<int>("ImoNumber");

                    b.Property<string>("OfficialNr");

                    b.Property<string>("RecognizedOrganization");

                    b.Property<string>("ShipName");

                    b.Property<string>("TypeOfShip");

                    b.Property<string>("Year");

                    b.HasKey("ShipId");

                    b.ToTable("Ships");
                });

            modelBuilder.Entity("ASPNetCoreIdentityDemo.Models.ShipType", b =>
                {
                    b.Property<int>("ShipTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CanBeLrs");

                    b.Property<int>("PointsOfHrs");

                    b.Property<string>("ShipTypeName");

                    b.HasKey("ShipTypeId");

                    b.ToTable("ShipTypes");
                });

            modelBuilder.Entity("ASPNetCoreIdentityDemo.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("ASPNetCoreIdentityDemo.Models.TokyoWgbList", b =>
                {
                    b.Property<int>("TokyoWgbListId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BmBmthBhBvhr");

                    b.Property<string>("WgbFlag");

                    b.Property<string>("WorGorB");

                    b.HasKey("TokyoWgbListId");

                    b.HasIndex("WgbFlag")
                        .IsUnique();

                    b.ToTable("TokyoWgbLists");
                });

            modelBuilder.Entity("ASPNetCoreIdentityDemo.Models.WGBList", b =>
                {
                    b.Property<int>("WgbListId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BmBmthBhBvhr");

                    b.Property<string>("WgbFlag");

                    b.Property<string>("WorGorB");

                    b.HasKey("WgbListId");

                    b.HasIndex("WgbFlag")
                        .IsUnique();

                    b.ToTable("WgbLists");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ASPNetCoreIdentityDemo.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ASPNetCoreIdentityDemo.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ASPNetCoreIdentityDemo.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ASPNetCoreIdentityDemo.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}