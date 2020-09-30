CREATE DATABASE SearchJob
GO

USE SearchJob
GO

CREATE TABLE UserType
(
UserTypeID INT NOT NULL CONSTRAINT PK_UserTypeID PRIMARY KEY IDENTITY(1,1),
TypeName NVARCHAR(50) NULL
)
GO

CREATE TABLE Country
(
CountryID INT NOT NULL CONSTRAINT PK_CountryID PRIMARY KEY IDENTITY(1,1),
CountryName NVARCHAR(50) NULL
)
GO

CREATE TABLE City
(
CityID INT NOT NULL CONSTRAINT PK_CityID PRIMARY KEY IDENTITY(1,1),
CityName NVARCHAR(50) NULL,
ZipCode NVARCHAR(50) NULL,

CountryID INT NULL CONSTRAINT FK_City_CountryID FOREIGN KEY REFERENCES Country(CountryID),
)
GO

CREATE TABLE Gender
(
GenderID INT NOT NULL CONSTRAINT PK_GenderID PRIMARY KEY IDENTITY(1,1),
GenderType NVARCHAR(50) NULL,
)
GO

CREATE TABLE Users
(
UserID INT NOT NULL CONSTRAINT PK_UserID PRIMARY KEY IDENTITY(1,1),
TypeName NVARCHAR(50) NULL,

 FirstName NVARCHAR(50) NOT NULL,
 LastName NVARCHAR(50) NOT NULL,
 Phone NVARCHAR(50) NOT NULL,
 Email NVARCHAR(50) NOT NULL,
 Adress NVARCHAR(50) NOT NULL,
 YearOfBirth DATE NULL,
 PasswordSalt NVARCHAR(100) NOT NULL,
 PasswordHash NVARCHAR(100) NOT NULL,

 CityID INT NULL CONSTRAINT FK_User_CityID FOREIGN KEY REFERENCES City(CityID),
 GenderID INT NULL CONSTRAINT FK_User_GenderID FOREIGN KEY REFERENCES Gender(GenderID),
 UserTypeID INT NULL CONSTRAINT FK_User_UserTypeID FOREIGN KEY REFERENCES UserType(UserTypeID),
)
GO

CREATE TABLE Category
(
CategoryID INT NOT NULL CONSTRAINT PK_CategoryID PRIMARY KEY IDENTITY(1,1),
CategoryName NVARCHAR(50) NULL,
)
GO

CREATE TABLE JobType
(
JobTypeID INT NOT NULL CONSTRAINT PK_JobTypeID PRIMARY KEY IDENTITY(1,1),
JobTypeName NVARCHAR(50) NULL,
)
GO

CREATE TABLE JobLevel
(
JobLevelID INT NOT NULL CONSTRAINT PK_JobLevelID PRIMARY KEY IDENTITY(1,1),
LevelName NVARCHAR(50) NULL,
)
GO

CREATE TABLE Company
(
CompanyID INT NOT NULL CONSTRAINT PK_CompanyID PRIMARY KEY IDENTITY(1,1),
CompanyName NVARCHAR(50) NULL,
Phone NVARCHAR(50) NOT NULL,
Email NVARCHAR(50) NOT NULL,
Adress NVARCHAR(50) NOT NULL,
AboutUs NVARCHAR(MAX),
Photo NVARCHAR
)
GO


CREATE TABLE Skill
(
SkillID INT NOT NULL CONSTRAINT PK_SkillID PRIMARY KEY IDENTITY(1,1),
SkillName NVARCHAR(50) NULL,
)
GO

CREATE TABLE Advertisment
(
AdvertismentID INT NOT NULL CONSTRAINT PK_AdvertismentID PRIMARY KEY IDENTITY(1,1),
CategoryName NVARCHAR(50) NOT NULL,
Published DATE NOT NULL,
ToDate DATE NOT NULL,
IsActive BIT NOT NULL,
Requirements NVARCHAR(MAX) NOT NULL,
BonusSkills NVARCHAR(MAX) NOT NULL,
Offers NVARCHAR(MAX) NOT NULL,
Education NVARCHAR(MAX) NOT NULL,
JobDescription NVARCHAR(MAX) NOT NULL,
CandidateDescription NVARCHAR(MAX) NOT NULL,

CityID INT NULL CONSTRAINT FK_Advertisment_CityID FOREIGN KEY REFERENCES City(CityID),
CompanyID INT NULL CONSTRAINT FK_Advertisment_CompanyID FOREIGN KEY REFERENCES Company(CompanyID),
CategoryID INT NULL CONSTRAINT FK_Advertisment_CategoryID FOREIGN KEY REFERENCES Category(CategoryID),
JobLevelID INT NULL CONSTRAINT FK_Advertisment_JobLevelID FOREIGN KEY REFERENCES JobLevel(JobLevelID),
JobTypeID INT NULL CONSTRAINT FK_Advertisment_JobTypeID FOREIGN KEY REFERENCES JobType(JobTypeID),
)
GO

CREATE TABLE AdvertismentSkill
(
AdvertismentSkillID INT NOT NULL CONSTRAINT PK_AdvertismentSkillID PRIMARY KEY IDENTITY(1,1),

AdvertismentID INT NULL CONSTRAINT FK_AdvertismentSkill_AdvertismentID FOREIGN KEY REFERENCES Advertisment(AdvertismentID),
SkillID INT NULL CONSTRAINT FK_AdvertismentSkill_SkillID FOREIGN KEY REFERENCES Skill(SkillID),
)
GO


CREATE TABLE Application
(
ApplicationID INT NOT NULL CONSTRAINT PK_ApplicationID PRIMARY KEY IDENTITY(1,1),
ApplicationDate DATE NOT NULL,
FirstName NVARCHAR,
LastName NVARCHAR,
Email NVARCHAR,
PhoneNumber NVARCHAR,
Description NVARCHAR,
CV NVARCHAR,
Motivation NVARCHAR,

AdvertismentID INT NULL CONSTRAINT FK_Applications_AdvertismentID FOREIGN KEY REFERENCES Advertisment(AdvertismentID),
UserID INT NULL CONSTRAINT FK_Applications_UserID FOREIGN KEY REFERENCES Users(UserID),
)
GO

CREATE TABLE Question
(
Id INT NOT NULL CONSTRAINT PK_QuestionID PRIMARY KEY IDENTITY(1,1),
Subject NVARCHAR(MAX),
Message NVARCHAR(MAX),

UserID INT NULL CONSTRAINT FK_Question_UserID FOREIGN KEY REFERENCES Users(UserID) 
)
GO
























