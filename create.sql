CREATE DATABASE ConferenceDb

USE ConferenceDb

CREATE TABLE Building
(
	"Name" NVARCHAR(100) PRIMARY KEY
)


CREATE TABLE Place
(
	"Name" NVARCHAR(100) PRIMARY KEY
)

CREATE TABLE Equipment
(
	EquipmentId INT PRIMARY KEY IDENTITY(1, 1),
	"Name" NVARCHAR(100),
	"Description" NVARCHAR(2000)
)


CREATE TABLE Leader
(
	LeaderId INT PRIMARY KEY IDENTITY(1, 1),
	Lastname NVARCHAR(50) NOT NULL,
	Firstname NVARCHAR(50) NOT NULL, 
	Middlename NVARCHAR(50)
)

CREATE TABLE Speaker
(
	SpeakerId INT PRIMARY KEY IDENTITY(1, 1),
	Lastname NVARCHAR(50) NOT NULL,
	Firstname NVARCHAR(50) NOT NULL, 
	Middlename NVARCHAR(50),
	Degree NVARCHAR(100),
	Work NVARCHAR(100),
	PostName NVARCHAR(100),
	Biography NVARCHAR(4000)
)

CREATE TABLE Conference
(
	ConferenceId INT PRIMARY KEY IDENTITY(1,1),
	"Name" NVARCHAR(100) NOT NULL,
	StartDateTime DATETIME,
	EndDateTime DATETIME,
	BuildingName NVARCHAR(100) FOREIGN KEY REFERENCES Building("Name")
)

CREATE TABLE Section
(
	SectionId INT PRIMARY KEY IDENTITY(1,1),
	"Name" NVARCHAR(100) NOT NULL,
	OrdinalNumber INT,
	LeaderId INT FOREIGN KEY REFERENCES Leader(LeaderId),
	ConferenceId INT FOREIGN KEY REFERENCES Conference(ConferenceId),
	PlaceName NVARCHAR(100) FOREIGN KEY REFERENCES Place("Name")
)

CREATE TABLE Performance
(
	PerformanceId INT PRIMARY KEY IDENTITY(1,1),
	Theme NVARCHAR(100) NOT NULL,
	SpeakerId INT FOREIGN KEY REFERENCES Speaker(SpeakerId),
	SectionId INT FOREIGN KEY REFERENCES Section(SectionId),
	DateTimeStart DATETIME,
	Duration TIME
)



CREATE TABLE PerformanceEquipment
(
	PerformanceId INT,
	EquipmentId INT,
	PRIMARY KEY (PerformanceId, EquipmentId),
	FOREIGN KEY (PerformanceId) REFERENCES Performance(PerformanceId),
	FOREIGN KEY (EquipmentId) REFERENCES Equipment(EquipmentId)
)

