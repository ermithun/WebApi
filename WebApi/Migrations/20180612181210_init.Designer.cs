﻿// <auto-generated />
using DigiCore.Entities.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
using WebApi.Data;

namespace WebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180612181210_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DigiCore.Entities.CoreManagement.Models.ExceptionLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("InnerMessage")
                        .HasMaxLength(500);

                    b.Property<string>("Message")
                        .HasMaxLength(500);

                    b.Property<string>("ModuleName")
                        .HasMaxLength(300);

                    b.Property<string>("Source")
                        .HasMaxLength(500);

                    b.Property<string>("StackTrace");

                    b.HasKey("Id");

                    b.ToTable("ExceptionLog");
                });

            modelBuilder.Entity("DigiCore.Entities.CoreManagement.Models.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AreaName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .HasMaxLength(100);

                    b.Property<string>("ModuleName")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<DateTime>("UpdateOn")
                        .HasColumnType("datetime");

                    b.Property<int>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("DigiCore.Entities.StockManagement.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("Status");

                    b.Property<int?>("SubCategoryId");

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("Datetime");

                    b.HasKey("Id");

                    b.HasIndex("AddedBy");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("DigiCore.Entities.StockManagement.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("Date");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("Status");

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("Datetime");

                    b.HasKey("Id");

                    b.HasIndex("AddedBy");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("DigiCore.Entities.UserManagement.Models.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("Date");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.Property<int>("Status");

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("Datetime");

                    b.HasKey("Id");

                    b.HasIndex("AddedBy");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("DigiCore.Entities.UserManagement.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("Date");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsSystemUser");

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

                    b.Property<int>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AddedBy");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DigiCore.Entities.UserManagement.Models.UserLoginHist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IpAddress")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LoginDate");

                    b.Property<bool>("Loginsuccess");

                    b.Property<DateTime?>("LogoutDate");

                    b.Property<string>("Remarks")
                        .HasMaxLength(200);

                    b.Property<string>("SessionId")
                        .HasMaxLength(100);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("UserLoginHist");
                });

            modelBuilder.Entity("DigiCore.Entities.UserManagement.Models.UserRoleMap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("Date");

                    b.Property<DateTime>("FromDate");

                    b.Property<int>("RoleId");

                    b.Property<int>("Status");

                    b.Property<DateTime>("ToDate");

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("Datetime");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddedBy");

                    b.HasIndex("RoleId");

                    b.HasIndex("UpdatedBy");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoleMap");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserToken<int>");
                });

            modelBuilder.Entity("DigiCore.Entities.UserManagement.Models.ApplicationUserToken", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserToken<int>");


                    b.ToTable("AspNetUserTokens");

                    b.HasDiscriminator().HasValue("ApplicationUserToken");
                });

            modelBuilder.Entity("DigiCore.Entities.CoreManagement.Models.Module", b =>
                {
                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser", "AppUserUpdator")
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiCore.Entities.StockManagement.Models.Category", b =>
                {
                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser", "AppUserCreator")
                        .WithMany()
                        .HasForeignKey("AddedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiCore.Entities.StockManagement.Models.Category", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser", "AppUserUpdator")
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiCore.Entities.StockManagement.Models.Product", b =>
                {
                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser", "AppUserCreator")
                        .WithMany()
                        .HasForeignKey("AddedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiCore.Entities.StockManagement.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser", "AppUserUpdator")
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiCore.Entities.UserManagement.Models.ApplicationRole", b =>
                {
                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser", "AppUserCreator")
                        .WithMany()
                        .HasForeignKey("AddedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser", "AppUserUpdator")
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiCore.Entities.UserManagement.Models.ApplicationUser", b =>
                {
                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser", "AppUserCreator")
                        .WithMany()
                        .HasForeignKey("AddedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser", "AppUserUpdator")
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DigiCore.Entities.UserManagement.Models.UserRoleMap", b =>
                {
                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser", "AppUserCreator")
                        .WithMany()
                        .HasForeignKey("AddedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationRole", "AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser", "AppUserUpdator")
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("DigiCore.Entities.UserManagement.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}