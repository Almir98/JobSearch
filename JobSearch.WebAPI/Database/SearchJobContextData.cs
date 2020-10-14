using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Database
{
    public partial class SearchJobContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            // Gender
            modelBuilder.Entity<Gender>().HasData(new Gender()
            {
                GenderId = 1,
                GenderType = "Female"
            });

            modelBuilder.Entity<Gender>().HasData(new Gender()
            {
                GenderId = 2,
                GenderType = "Male"
            });

            modelBuilder.Entity<Gender>().HasData(new Gender()
            {
                GenderId = 3,
                GenderType = "I don't want to say"
            });

            //UserType
            modelBuilder.Entity<UserType>().HasData(new UserType()
            {
                UserTypeId = 1,
                TypeName = "Administrator"
            });

            modelBuilder.Entity<UserType>().HasData(new UserType()
            {
                UserTypeId = 2,
                TypeName = "User"
            });

            //Country
            modelBuilder.Entity<Country>().HasData(new Country()
            {
                CountryId = 1,
                CountryName = "Bosnia and Herzegovina"
            });

            modelBuilder.Entity<Country>().HasData(new Country()
            {
                CountryId = 2,
                CountryName = "Croatia"
            });

            modelBuilder.Entity<Country>().HasData(new Country()
            {
                CountryId = 3,
                CountryName = "Austria"
            });

            modelBuilder.Entity<Country>().HasData(new Country()
            {
                CountryId = 4,
                CountryName = "Germany"
            });

            // City
            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = 1,
                CityName = "Sarajevo",
                ZipCode = "71000",
                CountryId = 1
            });

            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = 2,
                CityName = "Mostar",
                ZipCode = "88000",
                CountryId = 1
            });

            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = 3,
                CityName = "Bugojno",
                ZipCode = "7230",
                CountryId = 1
            });

            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = 4,
                CityName = "Sarajevo",
                ZipCode = "71000",
                CountryId = 1
            });

            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = 5,
                CityName = "Zagreb",
                ZipCode = "10000 ",
                CountryId = 2
            });

            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = 6,
                CityName = "Graz",
                ZipCode = "8010 ",
                CountryId = 3
            });

            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = 7,
                CityName = "Munchen",
                ZipCode = "80331",
                CountryId = 4
            });

            //Users

            modelBuilder.Entity<Users>().HasData(new Users()
            {
                UserId = 1,
                FirstName = "Admin",
                LastName = "Admin",
                Phone = "06211111",
                Email = "admin@hotmail",
                Adress = "Test adress",
                YearOfBirth = new DateTime(2020, 11, 10),
                CityId = 1,
                GenderId = 1,
                UserTypeId = 1,
                //PasswordHash=,

            });


            //JobLevel

            modelBuilder.Entity<JobLevel>().HasData(new JobLevel()
            {
                JobLevelId = 1,
                LevelName = "Junior"
            });

            modelBuilder.Entity<JobLevel>().HasData(new JobLevel()
            {
                JobLevelId = 2,
                LevelName = "Medior"
            });

            modelBuilder.Entity<JobLevel>().HasData(new JobLevel()
            {
                JobLevelId = 3,
                LevelName = "Senior"
            });

            // JobType
            modelBuilder.Entity<JobType>().HasData(new JobType()
            {
                JobTypeId = 1,
                JobTypeName = "Intern"
            });

            modelBuilder.Entity<JobType>().HasData(new JobType()
            {
                JobTypeId = 2,
                JobTypeName = "Part-time"
            });

            modelBuilder.Entity<JobType>().HasData(new JobType()
            {
                JobTypeId = 3,
                JobTypeName = "Full-time"
            });

            //Category
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 1,
                CategoryName = "Software developer"
            });

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 2,
                CategoryName = "Project Manager"
            });

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 3,
                CategoryName = "Solutin Architect"
            });

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 4,
                CategoryName = "Scrum Master"
            });

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 5,
                CategoryName = "UX/UI Designer"
            });

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 6,
                CategoryName = "Frontend Developer"
            });
            
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 7,
                CategoryName = "Backend Developer"
            });

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 8,
                CategoryName = "Database Developer"
            });

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 9,
                CategoryName = "Fullstack Developer"
            });
            
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 10,
                CategoryName = "CTO"
            });












        }
    }
}
