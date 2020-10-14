﻿// <auto-generated />
using System;
using JobSearch.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JobSearch.WebAPI.Migrations
{
    [DbContext(typeof(SearchJobContext))]
    [Migration("20201014004524_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JobSearch.WebAPI.Database.Advertisment", b =>
                {
                    b.Property<int>("AdvertismentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AdvertismentID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BonusSkills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId")
                        .HasColumnName("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("CityId")
                        .HasColumnName("CityID")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnName("CompanyID")
                        .HasColumnType("int");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("JobDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JobLevelId")
                        .HasColumnName("JobLevelID")
                        .HasColumnType("int");

                    b.Property<int?>("JobTypeId")
                        .HasColumnName("JobTypeID")
                        .HasColumnType("int");

                    b.Property<string>("Offers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Published")
                        .HasColumnType("date");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("date");

                    b.HasKey("AdvertismentId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("JobLevelId");

                    b.HasIndex("JobTypeId");

                    b.ToTable("Advertisment");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.AdvertismentSkill", b =>
                {
                    b.Property<int>("AdvertismentSkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AdvertismentSkillID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdvertismentId")
                        .HasColumnName("AdvertismentID")
                        .HasColumnType("int");

                    b.Property<int?>("SkillId")
                        .HasColumnName("SkillID")
                        .HasColumnType("int");

                    b.HasKey("AdvertismentSkillId");

                    b.HasIndex("AdvertismentId");

                    b.HasIndex("SkillId");

                    b.ToTable("AdvertismentSkill");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.Application", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ApplicationID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdvertismentId")
                        .HasColumnName("AdvertismentID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ApplicationDate")
                        .HasColumnType("date");

                    b.Property<string>("Cv")
                        .HasColumnName("CV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Motivation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("int");

                    b.HasKey("ApplicationId");

                    b.HasIndex("AdvertismentId");

                    b.HasIndex("UserId");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CategoryID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CityID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("CountryId")
                        .HasColumnName("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CompanyID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutUs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CountryID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("CountryId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GenderID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenderType")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("GenderId");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.JobLevel", b =>
                {
                    b.Property<int>("JobLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("JobLevelID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LevelName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("JobLevelId");

                    b.ToTable("JobLevel");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.JobType", b =>
                {
                    b.Property<int>("JobTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("JobTypeID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JobTypeName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("JobTypeId");

                    b.ToTable("JobType");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SkillID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SkillName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("SkillId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.UserType", b =>
                {
                    b.Property<int>("UserTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserTypeID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("UserTypeId");

                    b.ToTable("UserType");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("CityId")
                        .HasColumnName("CityID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("GenderId")
                        .HasColumnName("GenderID")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("UserTypeId")
                        .HasColumnName("UserTypeID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("YearOfBirth")
                        .HasColumnType("date");

                    b.HasKey("UserId")
                        .HasName("PK_UserID");

                    b.HasIndex("CityId");

                    b.HasIndex("GenderId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.Advertisment", b =>
                {
                    b.HasOne("JobSearch.WebAPI.Database.Category", "Category")
                        .WithMany("Advertisment")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Advertisment_CategoryID");

                    b.HasOne("JobSearch.WebAPI.Database.City", "City")
                        .WithMany("Advertisment")
                        .HasForeignKey("CityId")
                        .HasConstraintName("FK_Advertisment_CityID");

                    b.HasOne("JobSearch.WebAPI.Database.Company", "Company")
                        .WithMany("Advertisment")
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK_Advertisment_CompanyID");

                    b.HasOne("JobSearch.WebAPI.Database.JobLevel", "JobLevel")
                        .WithMany("Advertisment")
                        .HasForeignKey("JobLevelId")
                        .HasConstraintName("FK_Advertisment_JobLevelID");

                    b.HasOne("JobSearch.WebAPI.Database.JobType", "JobType")
                        .WithMany("Advertisment")
                        .HasForeignKey("JobTypeId")
                        .HasConstraintName("FK_Advertisment_JobTypeID");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.AdvertismentSkill", b =>
                {
                    b.HasOne("JobSearch.WebAPI.Database.Advertisment", "Advertisment")
                        .WithMany("AdvertismentSkill")
                        .HasForeignKey("AdvertismentId")
                        .HasConstraintName("FK_AdvertismentSkill_AdvertismentID");

                    b.HasOne("JobSearch.WebAPI.Database.Skill", "Skill")
                        .WithMany("AdvertismentSkill")
                        .HasForeignKey("SkillId")
                        .HasConstraintName("FK_AdvertismentSkill_SkillID");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.Application", b =>
                {
                    b.HasOne("JobSearch.WebAPI.Database.Advertisment", "Advertisment")
                        .WithMany("Application")
                        .HasForeignKey("AdvertismentId")
                        .HasConstraintName("FK_Applications_AdvertismentID");

                    b.HasOne("JobSearch.WebAPI.Database.Users", "User")
                        .WithMany("Application")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Applications_UserID");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.City", b =>
                {
                    b.HasOne("JobSearch.WebAPI.Database.Country", "Country")
                        .WithMany("City")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK_City_CountryID");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.Question", b =>
                {
                    b.HasOne("JobSearch.WebAPI.Database.Users", "User")
                        .WithMany("Question")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Question_UserID");
                });

            modelBuilder.Entity("JobSearch.WebAPI.Database.Users", b =>
                {
                    b.HasOne("JobSearch.WebAPI.Database.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityId")
                        .HasConstraintName("FK_User_CityID");

                    b.HasOne("JobSearch.WebAPI.Database.Gender", "Gender")
                        .WithMany("Users")
                        .HasForeignKey("GenderId")
                        .HasConstraintName("FK_User_GenderID");

                    b.HasOne("JobSearch.WebAPI.Database.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeId")
                        .HasConstraintName("FK_User_UserTypeID");
                });
#pragma warning restore 612, 618
        }
    }
}