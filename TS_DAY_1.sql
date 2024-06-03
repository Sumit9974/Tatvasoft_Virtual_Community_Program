-- Table Country

create table country (
	id int PRIMARY KEY,
	countryName varchar(255)
);

select * from country

-- Table City
create table city (
	id int PRIMARY KEY,
	countryId int,
	cityName varchar(255),
	FOREIGN KEY (countryId) REFERENCES country(id)
)

select * from city

--Table MissionApplication
CREATE TABLE missionApplication (
    id INT PRIMARY KEY,
    missionId INT,
    userId INT,
    appliedDate TIMESTAMP,
    status BOOL,
    sheet INT,
	FOREIGN KEY (missionId) REFERENCES missions (id)
);

select * from missionApplication

--  Table Missions
create table missions (
    id INT PRIMARY KEY,
    missionTitle VARCHAR(255),
    missionDescription VARCHAR(255),
    missionOrganisationName VARCHAR(255),
    missionOrganisationDetail VARCHAR(255),
    countryId INT,
    cityId INT,
    startDate DATE,
    endDate DATE,
    missionType VARCHAR(255),
    totalSheets INT,
    registrationDeadLine DATE,
    missionThemeId VARCHAR(255),
    missionSkillId INT,
    missionImages VARCHAR(255),
    missionDocuments VARCHAR(255),
    missionAvailability VARCHAR(255),
    missionVideoUrl VARCHAR(255),
	FOREIGN KEY (missionSkillId) REFERENCES missionSkill (id)
	
);

select * from missions;

-- Table missionSkill
create table missionSkill (
    id INT PRIMARY KEY,
    skillName VARCHAR(255),
    status VARCHAR(255)
);

select * from MissionSkill;

-- Table missionTheme
create table missionTheme(
	id int PRIMARY KEY,
	themeName varchar(255),
	status varchar(255)
)

select * from missionTheme

--  Table User
create table users (
id int PRIMARY KEY,
firstName varchar(255),
lastName varchar(255),
phoneNumber varchar(255),
emailAddress varchar(255),
userType varchar(255),
password varchar(255)	
)
 
	insert into users (id,firstName,lastName,phoneNumber,emailAddress,userType,password) values
	(3011,'Sumit','Dubey',9876543212,'sumit@gmail.com','user','abcd1234')
	

select * from users

-- Table userDetails
create table userDetails(
id int PRIMARY KEY,
userId int,
name varchar(255),
surname varchar(255),
employeeId varchar(255),
manager varchar(255),
title varchar(255),
department varchar(255),
myProfile varchar(255),
whyIVolunteer varchar(255),
countryId int,
cityId int,
avilability varchar(255),
linkdInUrl varchar(255),
mySkills varchar(255),
userImage varchar(255),
status bool
)

select * from userDetails;

--  Table  userSkills
create table userSkills(
	id int PRIMARY KEY,
	skill varchar(255),
	userId int
)

select * from userSkills

INSERT INTO country (id, countryName) VALUES
(1, 'United States'),
(2, 'Canada'),
(3, 'United Kingdom'),
(4, 'Australia'),
(5, 'Germany');

INSERT INTO city (id, countryId, cityName) VALUES
(1, 1, 'New York'), -- United States
(2, 1, 'Los Angeles'), -- United States
(3, 2, 'Toronto'), -- Canada
(4, 3, 'London'), -- United Kingdom
(5, 4, 'Sydney'); -- Australia

INSERT INTO missionSkill (id, skillName, status) VALUES
(1, 'Programming', 'Active'),
(2, 'Design', 'Active'),
(3, 'Communication', 'Inactive'),
(4, 'Problem Solving', 'Active'),
(5, 'Leadership', 'Inactive');

INSERT INTO missions (id, missionTitle, missionDescription, missionOrganisationName, missionOrganisationDetail, countryId, cityId, startDate, endDate, missionType, totalSheets, registrationDeadLine, missionThemeId, missionSkillId, missionImages, missionDocuments, missionAvailability, missionVideoUrl) VALUES
(1, 'Develop Website', 'Create a new website for the organisation', 'Tech Org', 'A non-profit tech organisation', 1, 1, '2024-06-01', '2024-08-01', 'Development', 5, '2024-05-15', 'Tech', 1, 'image1.jpg', 'doc1.pdf', 'Full-time', 'https://example.com/video1'),
(2, 'Design Logo', 'Design a new logo for the organisation', 'Design Org', 'A non-profit design organisation', 2, 2, '2024-07-01', '2024-07-15', 'Design', 2, '2024-06-15', 'Art', 2, 'image2.jpg', 'doc2.pdf', 'Part-time', 'https://example.com/video2')