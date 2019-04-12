﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Data;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

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
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

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

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebApplication2.Models.Credit", b =>
                {
                    b.Property<int>("CreditId");

                    b.Property<string>("CreditAbbr")
                        .HasMaxLength(10);

                    b.Property<string>("CreditName")
                        .HasMaxLength(20);

                    b.Property<int>("IsFall");

                    b.Property<int>("IsSpring");

                    b.Property<int>("IsSummer");

                    b.HasKey("CreditId");

                    b.ToTable("Credit");
                });

            modelBuilder.Entity("WebApplication2.Models.Degree", b =>
                {
                    b.Property<int>("DegreeId");

                    b.Property<string>("DegreeAbbr")
                        .HasMaxLength(10);

                    b.Property<string>("DegreeName")
                        .HasMaxLength(20);

                    b.Property<int>("NumberOfTerms");

                    b.HasKey("DegreeId");

                    b.ToTable("Degree");
                });

            modelBuilder.Entity("WebApplication2.Models.DegreeCredit", b =>
                {
                    b.Property<int>("DegreeCreditId");

                    b.Property<int>("CreditId");

                    b.Property<int>("DegreeId");

                    b.HasKey("DegreeCreditId");

                    b.HasIndex("CreditId");

                    b.HasIndex("DegreeId");

                    b.ToTable("DegreeCredit");
                });

            modelBuilder.Entity("WebApplication2.Models.DegreePlan", b =>
                {
                    b.Property<int>("DegreePlanId");

                    b.Property<string>("DegreePlanAbbr");

                    b.Property<string>("DegreePlanName")
                        .HasMaxLength(25);

                    b.Property<int>("DegreePlanSelected");

                    b.Property<int>("StudentId");

                    b.HasKey("DegreePlanId");

                    b.HasIndex("StudentId");

                    b.ToTable("DegreePlan");
                });

            modelBuilder.Entity("WebApplication2.Models.Slot", b =>
                {
                    b.Property<int>("SlotId");

                    b.Property<int>("CreditId");

                    b.Property<int>("DegreePlanSelected");

                    b.Property<string>("Status")
                        .HasMaxLength(1);

                    b.Property<int>("Term");

                    b.HasKey("SlotId");

                    b.HasIndex("CreditId");

                    b.ToTable("Slot");
                });

            modelBuilder.Entity("WebApplication2.Models.Student", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<string>("Family")
                        .HasMaxLength(15);

                    b.Property<string>("Given")
                        .HasMaxLength(25);

                    b.Property<int>("N919");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("WebApplication2.Models.StudentTerm", b =>
                {
                    b.Property<int>("StudentTermId");

                    b.Property<int>("StudentId");

                    b.Property<int>("Term");

                    b.Property<string>("TermAbbr")
                        .HasMaxLength(10);

                    b.Property<string>("TermName")
                        .HasMaxLength(10);

                    b.HasKey("StudentTermId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentTerm");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication2.Models.DegreeCredit", b =>
                {
                    b.HasOne("WebApplication2.Models.Credit", "Credit")
                        .WithMany()
                        .HasForeignKey("CreditId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication2.Models.Degree", "Degree")
                        .WithMany()
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication2.Models.DegreePlan", b =>
                {
                    b.HasOne("WebApplication2.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication2.Models.Slot", b =>
                {
                    b.HasOne("WebApplication2.Models.Credit", "Credit")
                        .WithMany()
                        .HasForeignKey("CreditId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication2.Models.StudentTerm", b =>
                {
                    b.HasOne("WebApplication2.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}