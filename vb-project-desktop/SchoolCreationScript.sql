/***********************
 *** Create Database ***
 **********************/
USE [master]
GO

CREATE DATABASE [School]
GO

ALTER DATABASE [School] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [School].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [School] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [School] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [School] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [School] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [School] SET ARITHABORT OFF 
GO

ALTER DATABASE [School] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [School] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [School] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [School] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [School] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [School] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [School] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [School] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [School] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [School] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [School] SET  DISABLE_BROKER 
GO

ALTER DATABASE [School] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [School] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [School] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [School] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [School] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [School] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [School] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [School] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [School] SET  MULTI_USER 
GO

ALTER DATABASE [School] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [School] SET DB_CHAINING OFF 
GO

ALTER DATABASE [School] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [School] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [School] SET  READ_WRITE 
GO

/*********************
 *** Create Tables ***
 ********************/
USE [School]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

/*** Create Course Table ***/
CREATE TABLE [dbo].[Course](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [varchar](50) NOT NULL,
	[CoursePrereq] [int] NULL,
	[CourseUnits] [tinyint] NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/*** Create CourseSection Table ***/
CREATE TABLE [dbo].[CourseSection](
	[CourseSectionID] [int] IDENTITY(1,1) NOT NULL,
	[CourseID] [int] NOT NULL,
	[CourseLocationID] [int] NOT NULL,
	[CourseStartDate] [smalldatetime] NULL,
	[CourseEndDate] [smalldatetime] NULL,
	[TeacherID] [int] NULL,
 CONSTRAINT [PK_CourseSection] PRIMARY KEY CLUSTERED 
(
	[CourseSectionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/*** Create CourseLocation Table ***/
CREATE TABLE [dbo].[CourseLocation](
	[CourseLocationID] [int] IDENTITY(1,1) NOT NULL,
	[Building] [varchar](20) NOT NULL,
	[Room] [varchar](20) NOT NULL,
	[ComputerLab] [bit] NOT NULL,
	[SeatCapacity] [smallint] NOT NULL,
 CONSTRAINT [PK_CourseLocation] PRIMARY KEY CLUSTERED 
(
	[CourseLocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/*** Create Enrollment Table ***/
CREATE TABLE [dbo].[Enrollment](
	[EnrollmentID] [int] IDENTITY(1, 1) NOT NULL,
	[CourseSectionID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[GradeID] [int] NULL,
	CONSTRAINT [PK_Enrollment] PRIMARY KEY CLUSTERED
	(
		[EnrollmentID] ASC
	),
	CONSTRAINT [AK_Enrollment] UNIQUE ([CourseSectionID] ASC, [StudentID] ASC, [GradeID] ASC)
) ON [PRIMARY]

GO

/*** Create Education Table ***/
CREATE TABLE [dbo].[Education](
	[EducationID] [int] IDENTITY(1,1) NOT NULL,
	[Education] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Education] PRIMARY KEY CLUSTERED 
(
	[EducationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/*** Create Grade Table ***/
CREATE TABLE [dbo].[Grade](
	[GradeID] [int] IDENTITY(1,1) NOT NULL,
	[Grade] [varchar](2) NOT NULL,
	[GradePoint] [decimal](3, 2),
 CONSTRAINT [PK_Grade] PRIMARY KEY CLUSTERED 
(
	[GradeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/*** Create Major Table ***/
CREATE TABLE [dbo].[Major](
	[MajorID] [int] IDENTITY(1,1) NOT NULL,
	[Major] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Major] PRIMARY KEY CLUSTERED 
(
	[MajorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/*** Create Rank Table ***/
CREATE TABLE [dbo].[Rank](
	[RankID] [int] IDENTITY(1,1) NOT NULL,
	[Rank] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Rank] PRIMARY KEY CLUSTERED 
(
	[RankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/*** Create Student Table ***/
CREATE TABLE [dbo].[Student](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [varchar](50) NOT NULL,
	[Lastname] [varchar](50) NOT NULL,
	[EducationID] [int] NOT NULL,
	[MajorID] [int],
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/*** Create Teacher Table ***/
CREATE TABLE [dbo].[Teacher](
	[TeacherID] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [varchar](50) NOT NULL,
	[Lastname] [varchar](50) NOT NULL,
	[EducationID] [int] NOT NULL,
	[RankID] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/************************************
 *** Alter Tables for Constraints ***
 ***********************************/
ALTER TABLE [dbo].[Course] ADD  CONSTRAINT [DF_Course_CourseUnits]  DEFAULT ((3)) FOR [CourseUnits]
GO

ALTER TABLE [dbo].[CourseSection]  WITH CHECK ADD  CONSTRAINT [FK_CourseSection_Course] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
GO

ALTER TABLE [dbo].[CourseSection] CHECK CONSTRAINT [FK_CourseSection_Course]
GO

ALTER TABLE [dbo].[CourseSection]  WITH CHECK ADD  CONSTRAINT [FK_CourseSection_CourseLocation] FOREIGN KEY([CourseLocationID])
REFERENCES [dbo].[CourseLocation] ([CourseLocationID])
GO

ALTER TABLE [dbo].[CourseSection] CHECK CONSTRAINT [FK_CourseSection_CourseLocation]
GO

ALTER TABLE [dbo].[CourseSection]  WITH CHECK ADD  CONSTRAINT [FK_CourseSection_Teacher] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teacher] ([TeacherID])
GO

ALTER TABLE [dbo].[CourseSection] CHECK CONSTRAINT [FK_CourseSection_Teacher]
GO

ALTER TABLE [dbo].[CourseLocation] ADD  CONSTRAINT [DF_CourseLocation_ComputerLab]  DEFAULT ((0)) FOR [ComputerLab]
GO

ALTER TABLE [dbo].[CourseLocation] ADD  CONSTRAINT [DF_CourseLocation_SeatCapacity]  DEFAULT ((10)) FOR [SeatCapacity]
GO

ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_CourseSection] FOREIGN KEY([CourseSectionID])
REFERENCES [dbo].[CourseSection] ([CourseSectionID])
GO

ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Enrollment_CourseSection]
GO

ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Grade] FOREIGN KEY([GradeID])
REFERENCES [dbo].[Grade] ([GradeID])
GO

ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Enrollment_Grade]
GO

ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
GO

ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Enrollment_Student]
GO

ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO

ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Education] FOREIGN KEY([EducationID])
REFERENCES [dbo].[Education] ([EducationID])
GO

ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Education]
GO

ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Major] FOREIGN KEY([MajorID])
REFERENCES [dbo].[Major] ([MajorID])
GO

ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Major]
GO

ALTER TABLE [dbo].[Teacher] ADD  CONSTRAINT [DF_Teacher_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO

ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Education] FOREIGN KEY([EducationID])
REFERENCES [dbo].[Education] ([EducationID])
GO

ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Education]
GO

ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Rank] FOREIGN KEY([RankID])
REFERENCES [dbo].[Rank] ([RankID])
GO

ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Rank]
GO

/***********************
 *** Populate Tables ***
 **********************/
SET IDENTITY_INSERT [dbo].[Grade] ON
INSERT INTO [dbo].[Grade] ([GradeID], [Grade], [GradePoint]) VALUES (1, N'A', 4.00)
INSERT INTO [dbo].[Grade] ([GradeID], [Grade], [GradePoint]) VALUES (2, N'B', 3.00)
INSERT INTO [dbo].[Grade] ([GradeID], [Grade], [GradePoint]) VALUES (3, N'C', 2.00)
INSERT INTO [dbo].[Grade] ([GradeID], [Grade], [GradePoint]) VALUES (4, N'D', 1.00)
INSERT INTO [dbo].[Grade] ([GradeID], [Grade], [GradePoint]) VALUES (5, N'F', 0.00)
INSERT INTO [dbo].[Grade] ([GradeID], [Grade], [GradePoint]) VALUES (6, N'W', Null)
INSERT INTO [dbo].[Grade] ([GradeID], [Grade], [GradePoint]) VALUES (7, N'I', Null)
INSERT INTO [dbo].[Grade] ([GradeID], [Grade], [GradePoint]) VALUES (8, N'P', Null)
INSERT INTO [dbo].[Grade] ([GradeID], [Grade], [GradePoint]) VALUES (9, N'NP', Null)
INSERT INTO [dbo].[Grade] ([GradeID], [Grade], [GradePoint]) VALUES (10, N'IP', Null)
INSERT INTO [dbo].[Grade] ([GradeID], [Grade], [GradePoint]) VALUES (11, N'MW', Null)
INSERT INTO [dbo].[Grade] ([GradeID], [Grade], [GradePoint]) VALUES (12, N'RD', Null)
GO
SET IDENTITY_INSERT [dbo].[Grade] OFF

SET IDENTITY_INSERT [dbo].[Major] ON
INSERT INTO [dbo].[Major] ([MajorID], [Major]) VALUES (1, N'Accounting')
INSERT INTO [dbo].[Major] ([MajorID], [Major]) VALUES (2, N'American Sign Language')
INSERT INTO [dbo].[Major] ([MajorID], [Major]) VALUES (3, N'Anatomy')
INSERT INTO [dbo].[Major] ([MajorID], [Major]) VALUES (4, N'Biology')
INSERT INTO [dbo].[Major] ([MajorID], [Major]) VALUES (5, N'Chemistry')
INSERT INTO [dbo].[Major] ([MajorID], [Major]) VALUES (6, N'Computer Science')
INSERT INTO [dbo].[Major] ([MajorID], [Major]) VALUES (7, N'Mathematics')
INSERT INTO [dbo].[Major] ([MajorID], [Major]) VALUES (8, N'Physics')
INSERT INTO [dbo].[Major] ([MajorID], [Major]) VALUES (9, N'Welding')
GO
SET IDENTITY_INSERT [dbo].[Major] OFF

SET IDENTITY_INSERT [dbo].[Rank] ON
INSERT INTO [dbo].[Rank] ([RankID], [Rank]) VALUES (1, N'Part Time Adjunct')
INSERT INTO [dbo].[Rank] ([RankID], [Rank]) VALUES (2, N'Full Time')
INSERT INTO [dbo].[Rank] ([RankID], [Rank]) VALUES (3, N'Full Time Tenure Track')
GO
SET IDENTITY_INSERT [dbo].[Rank] OFF

SET IDENTITY_INSERT [dbo].[Education] ON
INSERT INTO [dbo].[Education] ([EducationID], [Education]) VALUES (1, N'High School')
INSERT INTO [dbo].[Education] ([EducationID], [Education]) VALUES (2, N'Some College')
INSERT INTO [dbo].[Education] ([EducationID], [Education]) VALUES (3, N'Associates')
INSERT INTO [dbo].[Education] ([EducationID], [Education]) VALUES (4, N'Bachelor')
INSERT INTO [dbo].[Education] ([EducationID], [Education]) VALUES (5, N'Post Bachelor')
INSERT INTO [dbo].[Education] ([EducationID], [Education]) VALUES (6, N'Master')
INSERT INTO [dbo].[Education] ([EducationID], [Education]) VALUES (7, N'Post Graduate')
INSERT INTO [dbo].[Education] ([EducationID], [Education]) VALUES (8, N'Doctorate')
INSERT INTO [dbo].[Education] ([EducationID], [Education]) VALUES (9, N'Post Doctorate')
INSERT INTO [dbo].[Education] ([EducationID], [Education]) VALUES (10, N'Less Than High School')
GO
SET IDENTITY_INSERT [dbo].[Education] OFF

SET IDENTITY_INSERT [dbo].[Teacher] ON
INSERT INTO [dbo].[Teacher] ([TeacherID], [Firstname], [Lastname], [EducationID], [RankID], [IsActive]) VALUES (1, N'Paul', N'Conrad', 6, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Teacher] OFF

SET IDENTITY_INSERT [dbo].[Student] ON
INSERT INTO [dbo].[Student] ([StudentID], [Firstname], [Lastname], [EducationID], [MajorID], [IsActive]) VALUES (1, N'John', N'Doe', 2, 6, 1)
INSERT INTO [dbo].[Student] ([StudentID], [Firstname], [Lastname], [EducationID], [MajorID], [IsActive]) VALUES (2, N'Jane', N'Smith', 3, 6, 1)
INSERT INTO [dbo].[Student] ([StudentID], [Firstname], [Lastname], [EducationID], [MajorID], [IsActive]) VALUES (3, N'Jerry', N'Hale', 1, 6, 0)
GO
SET IDENTITY_INSERT [dbo].[Student] OFF

SET IDENTITY_INSERT [dbo].[Course] ON
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [CoursePrereq], [CourseUnits]) VALUES (1, N'CS 110', Null, 4.00)
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [CoursePrereq], [CourseUnits]) VALUES (2, N'CS 120', Null, 4.00)
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [CoursePrereq], [CourseUnits]) VALUES (3, N'CS 130', 1, 3.00)
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [CoursePrereq], [CourseUnits]) VALUES (4, N'CS 190', 3, 4.00)
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [CoursePrereq], [CourseUnits]) VALUES (5, N'CS 215', 1, 4.00)
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [CoursePrereq], [CourseUnits]) VALUES (6, N'CS 220', 2, 4.00)
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [CoursePrereq], [CourseUnits]) VALUES (7, N'CS 265', 4, 3.00)
GO
SET IDENTITY_INSERT [dbo].[Course] OFF

SET IDENTITY_INSERT [dbo].[CourseLocation] ON
INSERT INTO [dbo].[CourseLocation] ([CourseLocationID], [Building], [Room], [ComputerLab], [SeatCapacity]) VALUES (1, N'B', N'118', 1, 30)
INSERT INTO [dbo].[CourseLocation] ([CourseLocationID], [Building], [Room], [ComputerLab], [SeatCapacity]) VALUES (2, N'B', N'125', 1, 30)
INSERT INTO [dbo].[CourseLocation] ([CourseLocationID], [Building], [Room], [ComputerLab], [SeatCapacity]) VALUES (3, N'B', N'220', 1, 30)
GO
SET IDENTITY_INSERT [dbo].[CourseLocation] OFF

SET IDENTITY_INSERT [dbo].[CourseSection] ON
INSERT INTO [dbo].[CourseSection] ([CourseSectionID], [CourseID], [CourseLocationID], [CourseStartDate], [CourseEndDate], [TeacherID]) VALUES (1, 1, 1, N'1/21/2010 1:00 PM', N'5/20/2010 3:50 PM', Null)
INSERT INTO [dbo].[CourseSection] ([CourseSectionID], [CourseID], [CourseLocationID], [CourseStartDate], [CourseEndDate], [TeacherID]) VALUES (2, 2, 2, N'8/21/2011 4:00 PM', N'12/19/2011 6:50 PM', Null)
INSERT INTO [dbo].[CourseSection] ([CourseSectionID], [CourseID], [CourseLocationID], [CourseStartDate], [CourseEndDate], [TeacherID]) VALUES (3, 3, 3, N'1/19/2012 6:00 PM', N'5/20/2012 8:50 PM', Null)
INSERT INTO [dbo].[CourseSection] ([CourseSectionID], [CourseID], [CourseLocationID], [CourseStartDate], [CourseEndDate], [TeacherID]) VALUES (4, 4, 1, N'1/19/2010 6:00 PM', N'5/20/2010 8:50 PM', 1)
INSERT INTO [dbo].[CourseSection] ([CourseSectionID], [CourseID], [CourseLocationID], [CourseStartDate], [CourseEndDate], [TeacherID]) VALUES (5, 5, 2, N'1/21/2010 6:00 PM', N'5/22/2010 8:50 PM', 1)
INSERT INTO [dbo].[CourseSection] ([CourseSectionID], [CourseID], [CourseLocationID], [CourseStartDate], [CourseEndDate], [TeacherID]) VALUES (6, 6, 3, N'8/17/2011 6:00 PM', N'12/20/2011 8:50 PM', 1)
INSERT INTO [dbo].[CourseSection] ([CourseSectionID], [CourseID], [CourseLocationID], [CourseStartDate], [CourseEndDate], [TeacherID]) VALUES (7, 7, 1, N'8/19/2011 6:00 PM', N'12/20/2011 8:50 PM', Null)
GO
SET IDENTITY_INSERT [dbo].[CourseSection] OFF

SET IDENTITY_INSERT [dbo].[Enrollment] ON
INSERT INTO [dbo].[Enrollment] ([EnrollmentID], [CourseSectionID], [StudentID], [GradeID]) VALUES (1, 1, 1, 6)
INSERT INTO [dbo].[Enrollment] ([EnrollmentID], [CourseSectionID], [StudentID], [GradeID]) VALUES (2, 2, 2, 1)
INSERT INTO [dbo].[Enrollment] ([EnrollmentID], [CourseSectionID], [StudentID], [GradeID]) VALUES (3, 3, 3, 2)
INSERT INTO [dbo].[Enrollment] ([EnrollmentID], [CourseSectionID], [StudentID], [GradeID]) VALUES (4, 4, 1, 4)
INSERT INTO [dbo].[Enrollment] ([EnrollmentID], [CourseSectionID], [StudentID], [GradeID]) VALUES (5, 5, 2, 3)
INSERT INTO [dbo].[Enrollment] ([EnrollmentID], [CourseSectionID], [StudentID], [GradeID]) VALUES (6, 6, 3, 1)
INSERT INTO [dbo].[Enrollment] ([EnrollmentID], [CourseSectionID], [StudentID], [GradeID]) VALUES (7, 7, 1, 2)
SET IDENTITY_INSERT [dbo].[Enrollment] OFF
GO

/****************************************
 *** Create all the Stored Procedures ***
 ***************************************/
IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spAddCourse' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spAddCourse
GO

CREATE PROCEDURE [dbo].spAddCourse
(
	@CourseName varchar(50),
	@CoursePrereq int,
	@CourseUnits tinyint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Course] ([CourseName], [CoursePrereq], [CourseUnits])
		VALUES (@CourseName, @CoursePrereq, @CourseUnits);
RETURN SCOPE_IDENTITY();
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetAllCourses' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetAllCourses
GO

CREATE PROCEDURE [dbo].spGetAllCourses
AS
	SET NOCOUNT OFF;
SELECT * FROM Course
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spUpdateCourse' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spUpdateCourse
GO

CREATE PROCEDURE [dbo].spUpdateCourse
(
	@CourseID int,
	@CourseName varchar(50),
	@CoursePrereq int,	
	@CourseUnits tinyint	
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[Course] SET [CourseName] = @CourseName, [CoursePrereq] = @CoursePrereq, [CourseUnits] = @CourseUnits 
		WHERE [CourseID] = @CourseID;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spDeleteCourseByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spDeleteCourseByID
GO

CREATE PROCEDURE [dbo].spDeleteCourseByID
(
	@CourseID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM Course WHERE CourseID = @CourseID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spAddCourseSection' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spAddCourseSection
GO

CREATE PROCEDURE [dbo].spAddCourseSection
(
	@CourseID int,
	@CourseLocationID int,
	@CourseStartDate smalldatetime,
	@CourseEndDate smalldatetime,
	@TeacherID int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[CourseSection] ([CourseID], [CourseLocationID], [CourseStartDate], [CourseEndDate], [TeacherID])
		VALUES (@CourseID, @CourseLocationID, @CourseStartDate, @CourseEndDate, @TeacherID);
RETURN SCOPE_IDENTITY();
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetAllCourseSections' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetAllCourseSections
GO

CREATE PROCEDURE [dbo].spGetAllCourseSections
AS
	SET NOCOUNT OFF;
SELECT * FROM CourseSection
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spUpdateCourseSection' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spUpdateCourseSection
GO

CREATE PROCEDURE [dbo].spUpdateCourseSection
(
	@CourseSectionID int,
	@CourseID int,
	@CourseLocationID int,
	@CourseStartDate smalldatetime,
	@CourseEndDate smalldatetime,
	@TeacherID int
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[CourseSection] SET [CourseID] = @CourseID, [CourseLocationID] = @CourseLocationID,
								 [CourseStartDate] = @CourseStartDate, [CourseEndDate] = @CourseEndDate,
								 [TeacherID] = @TeacherID
		WHERE [CourseSectionID] = @CourseSectionID 
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spDeleteCourseSectionByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spDeleteCourseSectionByID
GO

CREATE PROCEDURE [dbo].spDeleteCourseSectionByID
(
	@CourseSectionID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM CourseSection WHERE CourseSectionID = @CourseSectionID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spAddCourseLocation' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spAddCourseLocation
GO

CREATE PROCEDURE [dbo].spAddCourseLocation
(
	@Building varchar(20),
	@Room varchar(20),
	@ComputerLab bit,
	@SeatCapacity smallint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[CourseLocation] ([Building], [Room], [ComputerLab], [SeatCapacity] )
		VALUES (@Building, @Room, @ComputerLab, @SeatCapacity);
RETURN SCOPE_IDENTITY();
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetAllCourseLocations' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetAllCourseLocations
GO

CREATE PROCEDURE [dbo].spGetAllCourseLocations
AS
	SET NOCOUNT OFF;
SELECT * FROM CourseLocation
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spUpdateCourseLocation' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spUpdateCourseLocation
GO

CREATE PROCEDURE [dbo].spUpdateCourseLocation
(
	@CourseLocationID int,
	@Building varchar(20),
	@Room varchar(20),
	@ComputerLab bit,
	@SeatCapacity smallint
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[CourseLocation] SET [Building] = @Building, [Room] = @Room, [ComputerLab] = @ComputerLab, 
								  [SeatCapacity] = @SeatCapacity
		WHERE [CourseLocationID] = @CourseLocationID;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spDeleteCourseLocationByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spDeleteCourseLocationByID
GO

CREATE PROCEDURE [dbo].spDeleteCourseLocationByID
(
	@CourseLocationID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM CourseLocation WHERE CourseLocationID = @CourseLocationID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spAddEducation' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spAddEducation
GO

CREATE PROCEDURE [dbo].spAddEducation
(
	@Education varchar(25)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Education] ([Education])
		VALUES (@Education);
RETURN SCOPE_IDENTITY();
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetAllEducations' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetAllEducations
GO

CREATE PROCEDURE [dbo].spGetAllEducations
AS
	SET NOCOUNT OFF;
SELECT * FROM Education
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spUpdateEducation' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spUpdateEducation
GO

CREATE PROCEDURE [dbo].spUpdateEducation
(
	@EducationID int,
	@Education varchar(25)
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[Education] SET [Education] = @Education
		WHERE [EducationID] = @EducationID;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spDeleteEducationByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spDeleteEducationByID
GO

CREATE PROCEDURE [dbo].spDeleteEducationByID
(
	@EducationID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM Education WHERE EducationID = @EducationID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spAddEnrollment' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spAddEnrollment
GO

CREATE PROCEDURE [dbo].spAddEnrollment
(
	@CourseSectionID int,
	@StudentID int,
	@GradeID int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Enrollment] ([CourseSectionID], [StudentID], [GradeID])
		VALUES (@CourseSectionID, @StudentID, @GradeID);
RETURN SCOPE_IDENTITY();
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetAllEnrollments' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetAllEnrollments
GO

CREATE PROCEDURE [dbo].spGetAllEnrollments
AS
	SET NOCOUNT OFF;
SELECT * FROM Enrollment
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spUpdateEnrollment' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spUpdateEnrollment
GO

CREATE PROCEDURE [dbo].spUpdateEnrollment
(
	@EnrollmentID int,
	@NewCourseSectionID int,
	@NewStudentID int,
	@NewGradeID int
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[Enrollment] SET [CourseSectionID] = @NewCourseSectionID, [StudentID] = @NewStudentID, 
							  [GradeID] = @NewGradeID
		WHERE ( [EnrollmentID] = @EnrollmentID );
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spDeleteEnrollmentByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spDeleteEnrollmentByID
GO

CREATE PROCEDURE [dbo].spDeleteEnrollmentByID
(
	@EnrollmentID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM Enrollment WHERE ( EnrollmentID = @EnrollmentID )
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spAddGrade' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spAddGrade
GO

CREATE PROCEDURE [dbo].spAddGrade
(
	@Grade varchar(2),
	@GradePoint decimal(3,2)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Grade] ([Grade], [GradePoint])
		VALUES (@Grade, @GradePoint);
RETURN SCOPE_IDENTITY();
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetAllGrades' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetAllGrades
GO

CREATE PROCEDURE [dbo].spGetAllGrades
AS
	SET NOCOUNT OFF;
SELECT * FROM Grade
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spUpdateGrade' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spUpdateGrade
GO

CREATE PROCEDURE [dbo].spUpdateGrade
(
	@GradeID int,
	@Grade varchar(2),
	@GradePoint decimal(3,2)
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[Grade] SET [Grade] = @Grade, [GradePoint] = @GradePoint
		WHERE [GradeID] = @GradeID;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spDeleteGradeByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spDeleteGradeByID
GO

CREATE PROCEDURE [dbo].spDeleteGradeByID
(
	@GradeID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM Grade WHERE GradeID = @GradeID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spAddMajor' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spAddMajor
GO

CREATE PROCEDURE [dbo].spAddMajor
(
	@Major varchar(25)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Major] ([Major])
		VALUES (@Major);
RETURN SCOPE_IDENTITY();
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetAllMajors' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetAllMajors
GO

CREATE PROCEDURE [dbo].spGetAllMajors
AS
	SET NOCOUNT OFF;
SELECT * FROM Major
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spUpdateMajor' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spUpdateMajor
GO

CREATE PROCEDURE [dbo].spUpdateMajor
(
	@MajorID int,
	@Major varchar(25)	
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[Major] SET [Major] = @Major
		WHERE [MajorID] = @MajorID;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spDeleteMajorByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spDeleteMajorByID
GO

CREATE PROCEDURE [dbo].spDeleteMajorByID
(
	@MajorID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM Major WHERE MajorID = @MajorID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spAddRank' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spAddRank
GO

CREATE PROCEDURE [dbo].spAddRank
(
	@Rank varchar(25)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Rank] ([Rank])
		VALUES (@Rank);
RETURN SCOPE_IDENTITY();
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetAllRanks' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetAllRanks
GO

CREATE PROCEDURE [dbo].spGetAllRanks
AS
	SET NOCOUNT OFF;
SELECT * FROM Rank
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spUpdateRank' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spUpdateRank
GO

CREATE PROCEDURE [dbo].spUpdateRank
(
	@RankID int,
	@Rank varchar(25)
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[Rank] SET [Rank] = @Rank
		WHERE [RankID] = @RankID;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spDeleteRankByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spDeleteRankByID
GO

CREATE PROCEDURE [dbo].spDeleteRankByID
(
	@RankID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM Rank WHERE RankID = @RankID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spAddStudent' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spAddStudent
GO

CREATE PROCEDURE [dbo].spAddStudent
(
	@StudentFirstName varchar(50),
	@StudentLastName varchar(50),
	@StudentEducationID int,	
	@StudentMajorID int,
	@StudentIsActive bit
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Student] ([FirstName], [LastName], [EducationID], [MajorID], [IsActive]) 
		VALUES (@StudentFirstName, @StudentLastName, @StudentEducationID, @StudentMajorID, @StudentIsActive);
RETURN SCOPE_IDENTITY();
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetAllStudents' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetAllStudents
GO

CREATE PROCEDURE [dbo].spGetAllStudents
AS
	SET NOCOUNT OFF;
SELECT * FROM Student
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spUpdateStudent' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spUpdateStudent
GO

CREATE PROCEDURE [dbo].spUpdateStudent
(
	@StudentID int,
	@StudentFirstName varchar(50),
	@StudentLastName varchar(50),
	@StudentEducationID int,
	@StudentMajorID int,	
	@StudentIsActive bit
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[Student] SET [FirstName] = @StudentFirstName, [LastName] = @StudentLastName, 
						   [EducationID] = @StudentEducationID, [MajorID] = @StudentMajorID, [IsActive] = @StudentIsActive
		WHERE [StudentID] = @StudentID;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spDeleteStudentByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spDeleteStudentByID
GO

CREATE PROCEDURE [dbo].spDeleteStudentByID
(
	@StudentID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM Student WHERE StudentID = @StudentID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spAddTeacher' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spAddTeacher
GO

CREATE PROCEDURE [dbo].spAddTeacher
(
	@TeacherFirstName varchar(50),
	@TeacherLastName varchar(50),
	@TeacherEducationID int,
	@TeacherRank int,
	@TeacherIsActive bit
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Teacher] ([FirstName], [LastName], [EducationID], [RankID], [IsActive]) 
		VALUES (@TeacherFirstName, @TeacherLastName, @TeacherEducationID, @TeacherRank,
				@TeacherIsActive);
RETURN SCOPE_IDENTITY();
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetAllTeachers' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetAllTeachers
GO

CREATE PROCEDURE [dbo].spGetAllTeachers
AS
	SET NOCOUNT OFF;
SELECT * FROM Teacher
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spUpdateTeacher' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spUpdateTeacher
GO

CREATE PROCEDURE [dbo].spUpdateTeacher
(
	@TeacherID int,
	@TeacherFirstName varchar(50),
	@TeacherLastName varchar(50),
	@TeacherEducationID int,	
	@TeacherRankID int,
	@TeacherIsActive bit
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[Teacher] SET [FirstName] = @TeacherFirstName, [LastName] = @TeacherLastName, 
						   [EducationID] = @TeacherEducationID, [RankID] = @TeacherRankID, 
						   [IsActive] = @TeacherIsActive
		WHERE [TeacherID] = @TeacherID;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spDeleteTeacherByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spDeleteTeacherByID
GO

CREATE PROCEDURE [dbo].spDeleteTeacherByID
(
	@TeacherID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM Teacher WHERE TeacherID = @TeacherID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetAllEnrollments' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetAllEnrollments
GO

CREATE PROCEDURE [dbo].spGetAllEnrollments
AS
	SET NOCOUNT OFF;
SELECT Course.CourseID, Course.CourseName, Course.CourseUnits, CourseSection.CourseSectionID, CourseSection.CourseStartDate, CourseSection.CourseEndDate, 
       CourseSection.TeacherID, CourseLocation.Building, CourseLocation.Room, Student.StudentID, Student.Firstname, Student.Lastname, Enrollment.GradeID, 
       Grade.Grade, Grade.GradePoint
FROM   CourseSection INNER JOIN
       Enrollment ON CourseSection.CourseSectionID = Enrollment.CourseSectionID INNER JOIN
       Grade ON Enrollment.GradeID = Grade.GradeID INNER JOIN
       Student ON Enrollment.StudentID = Student.StudentID INNER JOIN
       Course ON CourseSection.CourseID = Course.CourseID INNER JOIN
       CourseLocation ON CourseSection.CourseLocationID = CourseLocation.CourseLocationID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetAllStudentsGPA' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetAllStudentsGPA
GO

CREATE PROCEDURE [dbo].spGetAllStudentsGPA
AS
	SET NOCOUNT OFF;
SELECT Student.StudentID, Student.Firstname, Student.Lastname, (SUM(Grade.GradePoint*Course.CourseUnits) / SUM(Course.CourseUnits)) As GPA
FROM   CourseSection INNER JOIN
       Enrollment ON CourseSection.CourseSectionID = Enrollment.CourseSectionID INNER JOIN
       Grade ON Enrollment.GradeID = Grade.GradeID INNER JOIN
       Student ON Enrollment.StudentID = Student.StudentID INNER JOIN
       Course ON CourseSection.CourseID = Course.CourseID INNER JOIN
       CourseLocation ON CourseSection.CourseLocationID = CourseLocation.CourseLocationID
WHERE Grade.GradePoint IS NOT Null
GROUP BY Student.StudentID, Student.Firstname, Student.Lastname
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetStudentsGPAByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetStudentsGPAByID
GO

CREATE PROCEDURE [dbo].spGetStudentsGPAByID
(
	@StudentID int
)
AS
	SET NOCOUNT OFF;
SELECT Student.Firstname, Student.Lastname, (SUM(Grade.GradePoint*Course.CourseUnits) / SUM(Course.CourseUnits)) As GPA
FROM   CourseSection INNER JOIN
       Enrollment ON CourseSection.CourseSectionID = Enrollment.CourseSectionID INNER JOIN
       Grade ON Enrollment.GradeID = Grade.GradeID INNER JOIN
       Student ON Enrollment.StudentID = Student.StudentID INNER JOIN
       Course ON CourseSection.CourseID = Course.CourseID INNER JOIN
       CourseLocation ON CourseSection.CourseLocationID = CourseLocation.CourseLocationID
WHERE (Grade.GradePoint IS NOT Null) AND (Student.StudentID=@StudentID)
GROUP BY Student.StudentID, Student.Firstname, Student.Lastname
GO


IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetCourseByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetCourseByID
GO

CREATE PROCEDURE [dbo].spGetCourseByID
(
	@CourseID int
)
AS
	SET NOCOUNT OFF;
	SELECT * FROM Course
	WHERE CourseID = @CourseID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetCourseLocationByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetCourseLocationByID
GO

CREATE PROCEDURE [dbo].spGetCourseLocationByID

(
	@CourseLocationID int
)
AS
	SET NOCOUNT OFF;
	SELECT * FROM CourseLocation
	WHERE CourseLocationID = @CourseLocationID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetCourseSectionByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetCourseSectionByID
GO

CREATE PROCEDURE [dbo].spGetCourseSectionByID
(
	@CourseSectionID int
)
AS
	SET NOCOUNT OFF;
	SELECT * FROM CourseSection
	WHERE CourseSectionID = @CourseSectionID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetEnrollmentByIDs' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetEnrollmentByIDs
GO

CREATE PROCEDURE [dbo].spGetEnrollmentByIDs
(
	@CourseSectionID int,
	@StudentID int,
	@GradeID int
)
AS
	SET NOCOUNT OFF;
	SELECT * FROM Enrollment
	WHERE (CourseSectionID = @CourseSectionID AND StudentID = @StudentID AND GradeID = @GradeID)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetEnrollmentByEnrollmentID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetEnrollmentByEnrollmentID
GO

CREATE PROCEDURE [dbo].spGetEnrollmentByEnrollmentID
(
	@EnrollmentID int
)
AS
	SET NOCOUNT OFF;
	SELECT * FROM Enrollment
	WHERE EnrollmentID = @EnrollmentID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetEnrollmentByCourseSectionID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetEnrollmentByCourseSectionID
GO

CREATE PROCEDURE [dbo].spGetEnrollmentByCourseSectionID
(
	@CourseSectionID int
)
AS
	SET NOCOUNT OFF;
	SELECT * FROM Enrollment
	WHERE CourseSectionID = @CourseSectionID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetEnrollmentByStudentID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetEnrollmentByStudentID
GO

CREATE PROCEDURE [dbo].spGetEnrollmentByStudentID
(
	@StudentID int
)
AS
	SET NOCOUNT OFF;
	SELECT * FROM Enrollment
	WHERE StudentID = @StudentID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetGradeByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetGradeByID
GO

CREATE PROCEDURE [dbo].spGetGradeByID
(
	@GradeID int
)
AS
	SET NOCOUNT OFF;
	SELECT * FROM Grade
	WHERE GradeID = @GradeID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetMajorByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetMajorByID
GO

CREATE PROCEDURE [dbo].spGetMajorByID
(
	@MajorID int
)
AS
	SET NOCOUNT OFF;
	SELECT * FROM Major
	WHERE MajorID = @MajorID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetEducationByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetEducationByID
GO

CREATE PROCEDURE [dbo].spGetEducationByID
(
	@EducationID int
)
AS
	SET NOCOUNT OFF;
	SELECT * FROM Education
	WHERE EducationID = @EducationID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetRankByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetRankByID
GO

CREATE PROCEDURE [dbo].spGetRankByID
(
	@RankID int
)
AS
	SET NOCOUNT OFF;
	SELECT * FROM Rank
	WHERE RankID = @RankID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetStudentByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetStudentByID
GO

CREATE PROCEDURE [dbo].spGetStudentByID
(
	@StudentID int
)
AS
	SET NOCOUNT OFF;
	SELECT * FROM Student
	WHERE StudentID = @StudentID
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'spGetTeacherByID' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].spGetTeacherByID
GO

CREATE PROCEDURE [dbo].spGetTeacherByID
(
	@TeacherID int
)
AS
	SET NOCOUNT OFF;
	SELECT * FROM Teacher
	WHERE TeacherID = @TeacherID
GO

/*** All Done - Set ANSI_PADDING Off ***/
SET ANSI_PADDING OFF
GO
