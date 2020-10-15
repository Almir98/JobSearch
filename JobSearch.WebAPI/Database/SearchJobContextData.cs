using JobSearch.WebAPI.Helpers;
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

            //  ADMIN
            Users user = new Users
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
                UserTypeId = 1
            };
            user.PasswordSalt = HashGenerator.GenerateSalt();
            user.PasswordHash = HashGenerator.GenerateHash(user.PasswordSalt, "test");

            //USER

            Users b = new Users
            {
                UserId = 1,
                FirstName = "User",
                LastName = "User",
                Phone = "061333333",
                Email = "user@hotmail",
                Adress = "User adress",
                YearOfBirth = new DateTime(2020, 11, 10),
                CityId = 2,
                GenderId = 2,
                UserTypeId = 2
            };
            b.PasswordSalt = HashGenerator.GenerateSalt();
            b.PasswordHash = HashGenerator.GenerateHash(b.PasswordSalt, "test");

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

            // COMPANY


            //modelBuilder.Entity<Company>().HasData(new Company()
            //{
            //    CompanyId = 1,
            //    CompanyName= "Klika",
            //    Phone = "055 111",
            //    Adress = "Marsala Tita",
            //    AboutUs = "Very nice company",
            //    Photo = "",
            //    Email="test",
            //    Url= "https://klika.ba/"
            //});

            //modelBuilder.Entity<Company>().HasData(new Company()
            //{
            //    CompanyId = 2,
            //    CompanyName = "MOP",
            //    Phone = "055 222",
            //    Adress = "Franca Lehara",
            //    AboutUs = "Very nice company",
            //    Email= "test",
            //    Photo = "",
            //    Url = "https://ministryofprogramming.com/"
            //});

            //modelBuilder.Entity<Company>().HasData(new Company()
            //{
            //    CompanyId = 3,
            //    CompanyName = "Evona",
            //    Phone = "055 333",
            //    Adress = "Blajburska ulica bb",
            //    AboutUs = "Very nice company",
            //    Photo = "",
            //    Email = "test",
            //    Url = "https://www.evona.sk/"
            //});

            //modelBuilder.Entity<Company>().HasData(new Company()
            //{
            //    CompanyId = 4,
            //    CompanyName = "Mistral",
            //    Phone = "055 444",
            //    Adress = "Skenderija",
            //    AboutUs = "Very nice company",
            //    Email="",
            //    Photo = "",
            //    Url = "https://www.mistral.ba/"
            //});

            //modelBuilder.Entity<Company>().HasData(new Company()
            //{
            //    CompanyId = 5,
            //    CompanyName = "QSS",
            //    Phone = "055 555",
            //    Adress = "Skenderija",
            //    AboutUs = "Very nice company",
            //    Email= "test",
            //    Photo = "",
            //    Url = "https://www.qss.ba/"
            //});

            // Skill

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 1,
                SkillName = "OOP"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 2,
                SkillName = ".NET Core"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 3,
                SkillName = "Angular"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 4,
                SkillName = "C++"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 5,
                SkillName = "C#"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 6,
                SkillName = "Java"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 7,
                SkillName = "IoT"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 8,
                SkillName = "Azure"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 9,
                SkillName = "Docker"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 10,
                SkillName = "HTML"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 11,
                SkillName = "CSS"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 12,
                SkillName = "Java Script"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 13,
                SkillName = "REST API"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 14,
                SkillName = "GIT"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 15,
                SkillName = "TFS"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 16,
                SkillName = "SQL"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 17,
                SkillName = "Agile"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 18,
                SkillName = "Scrum"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 19,
                SkillName = "Unit Testing"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 20,
                SkillName = "Mongo Db"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 21,
                SkillName = "Node.js"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 22,
                SkillName = "React"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 23,
                SkillName = "GitHub"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 24,
                SkillName = "Linux"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 25,
                SkillName = "Python"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill()
            {
                SkillId = 26,
                SkillName = "SDLC"
            });

            // ADVERTISMENT

            //modelBuilder.Entity<Advertisment>().HasData(new Advertisment()
            //{

            //});












            // Application

            //modelBuilder.Entity<Application>().HasData(new Application()
            //{
            //    ApplicationId = 1,
            //    ApplicationDate = new DateTime(2020, 11, 10),
            //    Description = "Application for job",
            //    UserId = 2,
            //    AdvertismentId = 1
            //});









        }
    }
}
