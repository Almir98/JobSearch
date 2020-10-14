using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JobSearch.WebAPI.Database
{
    public partial class SearchJobContext : DbContext
    {
        public SearchJobContext()
        {
        }

        public SearchJobContext(DbContextOptions<SearchJobContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Advertisment> Advertisment { get; set; }
        public virtual DbSet<AdvertismentSkill> AdvertismentSkill { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<JobLevel> JobLevel { get; set; }
        public virtual DbSet<JobType> JobType { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=SearchJob;Integrated Security=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advertisment>(entity =>
            {
                entity.Property(e => e.AdvertismentId).HasColumnName("AdvertismentID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.JobLevelId).HasColumnName("JobLevelID");

                entity.Property(e => e.JobTypeId).HasColumnName("JobTypeID");

                entity.Property(e => e.Published).HasColumnType("date");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Advertisment)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Advertisment_CategoryID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Advertisment)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Advertisment_CityID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Advertisment)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Advertisment_CompanyID");

                entity.HasOne(d => d.JobLevel)
                    .WithMany(p => p.Advertisment)
                    .HasForeignKey(d => d.JobLevelId)
                    .HasConstraintName("FK_Advertisment_JobLevelID");

                entity.HasOne(d => d.JobType)
                    .WithMany(p => p.Advertisment)
                    .HasForeignKey(d => d.JobTypeId)
                    .HasConstraintName("FK_Advertisment_JobTypeID");
            });

            modelBuilder.Entity<AdvertismentSkill>(entity =>
            {
                entity.Property(e => e.AdvertismentSkillId).HasColumnName("AdvertismentSkillID");

                entity.Property(e => e.AdvertismentId).HasColumnName("AdvertismentID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.HasOne(d => d.Advertisment)
                    .WithMany(p => p.AdvertismentSkill)
                    .HasForeignKey(d => d.AdvertismentId)
                    .HasConstraintName("FK_AdvertismentSkill_AdvertismentID");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.AdvertismentSkill)
                    .HasForeignKey(d => d.SkillId)
                    .HasConstraintName("FK_AdvertismentSkill_SkillID");
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.AdvertismentId).HasColumnName("AdvertismentID");

                entity.Property(e => e.ApplicationDate).HasColumnType("date");

                entity.Property(e => e.Cv).HasColumnName("CV");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Advertisment)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.AdvertismentId)
                    .HasConstraintName("FK_Applications_AdvertismentID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Applications_UserID");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName).HasMaxLength(50);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.ZipCode).HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_City_CountryID");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Photo).HasMaxLength(1);

                entity.Property(e => e.Url).HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName).HasMaxLength(50);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GenderType).HasMaxLength(50);
            });

            modelBuilder.Entity<JobLevel>(entity =>
            {
                entity.Property(e => e.JobLevelId).HasColumnName("JobLevelID");

                entity.Property(e => e.LevelName).HasMaxLength(50);
            });

            modelBuilder.Entity<JobType>(entity =>
            {
                entity.Property(e => e.JobTypeId).HasColumnName("JobTypeID");

                entity.Property(e => e.JobTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Question_UserID");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.SkillName).HasMaxLength(50);
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.Property(e => e.TypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_UserID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordHash).HasMaxLength(500);

                entity.Property(e => e.PasswordSalt).HasMaxLength(500);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.Property(e => e.YearOfBirth).HasColumnType("date");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_User_CityID");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_User_GenderID");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK_User_UserTypeID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
