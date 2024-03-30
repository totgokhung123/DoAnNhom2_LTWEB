﻿// <auto-generated />
using System;
using DoAnNhom2_LTWEB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoAnNhom2_LTWEB.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.BANGDANGTUYEN", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PHIEUDANGTUYENId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PHIEUDANGTUYENId");

                    b.ToTable("BANGDANGTUYENs");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.DONUNGTUYEN", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FILECV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("USERTKId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("USERTKId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("USERTKId1");

                    b.ToTable("DONUNGTUYENs");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.KINHNGHIEM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NAMKN")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("KINHNGHIEMs");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.LOAINGANH", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("TENLOAI")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LOAINGANHs");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.MUCLUONG", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SOLUONG")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("MUCLUONGs");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.NGANHUNGTUYEN", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LOAINGANHId")
                        .HasColumnType("int");

                    b.Property<string>("TENNGANH")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("LOAINGANHId");

                    b.ToTable("NGANHUNGTUYENs");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.NHATUYENDUNG", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DIADIEM")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("EMAIL")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("IMGBANGTIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMGDAIDIEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QUYMO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("TENNTD")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TINHId")
                        .HasColumnType("int");

                    b.Property<string>("TRANGTHAI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("USERTKId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("USERTKId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WEBSITE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TINHId");

                    b.HasIndex("USERTKId1");

                    b.ToTable("NHATUYENDUNGs");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.PHIEUDANGTUYEN", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CHUCDANH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DIADIEM")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("HANPHIEU")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KINHNGHIEMId")
                        .HasColumnType("int");

                    b.Property<string>("MOTA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MUCLUONGId")
                        .HasColumnType("int");

                    b.Property<int?>("NGANHUNGTUYENId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NGAYLAP")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NHATUYENDUNGId")
                        .HasColumnType("int");

                    b.Property<string>("TENVIECLAM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TINHId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KINHNGHIEMId");

                    b.HasIndex("MUCLUONGId");

                    b.HasIndex("NGANHUNGTUYENId");

                    b.HasIndex("NHATUYENDUNGId");

                    b.HasIndex("TINHId");

                    b.ToTable("PHIEUDANGTUYENs");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.TINH", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TENTINH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TRANGTHAI")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TINHs");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.USERTK", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("USERTK");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.BANGDANGTUYEN", b =>
                {
                    b.HasOne("DoAnNhom2_LTWEB.Models.PHIEUDANGTUYEN", "PHIEUDANGTUYEN")
                        .WithMany()
                        .HasForeignKey("PHIEUDANGTUYENId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PHIEUDANGTUYEN");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.DONUNGTUYEN", b =>
                {
                    b.HasOne("DoAnNhom2_LTWEB.Models.USERTK", "USERTK")
                        .WithMany()
                        .HasForeignKey("USERTKId1");

                    b.Navigation("USERTK");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.NGANHUNGTUYEN", b =>
                {
                    b.HasOne("DoAnNhom2_LTWEB.Models.LOAINGANH", "LOAINGANH")
                        .WithMany("NGANHUNGTUYENs")
                        .HasForeignKey("LOAINGANHId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LOAINGANH");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.NHATUYENDUNG", b =>
                {
                    b.HasOne("DoAnNhom2_LTWEB.Models.TINH", "TINH")
                        .WithMany("NHATUYENDUNGs")
                        .HasForeignKey("TINHId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoAnNhom2_LTWEB.Models.USERTK", "USERTK")
                        .WithMany()
                        .HasForeignKey("USERTKId1");

                    b.Navigation("TINH");

                    b.Navigation("USERTK");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.PHIEUDANGTUYEN", b =>
                {
                    b.HasOne("DoAnNhom2_LTWEB.Models.KINHNGHIEM", "KINHNGHIEM")
                        .WithMany("PHIEUDANGTUYENs")
                        .HasForeignKey("KINHNGHIEMId");

                    b.HasOne("DoAnNhom2_LTWEB.Models.MUCLUONG", "MUCLUONG")
                        .WithMany("PHIEUDANGTUYENs")
                        .HasForeignKey("MUCLUONGId");

                    b.HasOne("DoAnNhom2_LTWEB.Models.NGANHUNGTUYEN", "NGANHUNGTUYEN")
                        .WithMany("PHIEUDANGTUYENs")
                        .HasForeignKey("NGANHUNGTUYENId");

                    b.HasOne("DoAnNhom2_LTWEB.Models.NHATUYENDUNG", "NHATUYENDUNG")
                        .WithMany()
                        .HasForeignKey("NHATUYENDUNGId");

                    b.HasOne("DoAnNhom2_LTWEB.Models.TINH", "TINH")
                        .WithMany("PHIEUDANGTUYENs")
                        .HasForeignKey("TINHId");

                    b.Navigation("KINHNGHIEM");

                    b.Navigation("MUCLUONG");

                    b.Navigation("NGANHUNGTUYEN");

                    b.Navigation("NHATUYENDUNG");

                    b.Navigation("TINH");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.KINHNGHIEM", b =>
                {
                    b.Navigation("PHIEUDANGTUYENs");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.LOAINGANH", b =>
                {
                    b.Navigation("NGANHUNGTUYENs");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.MUCLUONG", b =>
                {
                    b.Navigation("PHIEUDANGTUYENs");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.NGANHUNGTUYEN", b =>
                {
                    b.Navigation("PHIEUDANGTUYENs");
                });

            modelBuilder.Entity("DoAnNhom2_LTWEB.Models.TINH", b =>
                {
                    b.Navigation("NHATUYENDUNGs");

                    b.Navigation("PHIEUDANGTUYENs");
                });
#pragma warning restore 612, 618
        }
    }
}
