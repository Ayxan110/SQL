USE [master]
GO
/****** Object:  Database [SchoolDb]    Script Date: 12/8/2019 7:30:44 PM ******/
CREATE DATABASE [SchoolDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLSERVER2020\MSSQL\DATA\SchoolDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SchoolDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLSERVER2020\MSSQL\DATA\SchoolDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SchoolDb] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SchoolDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SchoolDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SchoolDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SchoolDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SchoolDb] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SchoolDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SchoolDb] SET QUERY_STORE = OFF
GO
USE [SchoolDb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [SchoolDb]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 12/8/2019 7:30:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[ClassID] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 12/8/2019 7:30:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [varchar](30) NOT NULL,
	[StudentSurname] [varchar](30) NOT NULL,
	[ClassID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubjectClass]    Script Date: 12/8/2019 7:30:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubjectClass](
	[SubjectClassID] [int] IDENTITY(1,1) NOT NULL,
	[SubjectID] [int] NULL,
	[ClassID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SubjectClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 12/8/2019 7:30:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[SubjectID] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 12/8/2019 7:30:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[TeacherID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherName] [varchar](30) NOT NULL,
	[TeacherSurname] [varchar](30) NOT NULL,
	[ClassID] [int] NULL,
	[SubjectID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Classes] ON 

INSERT [dbo].[Classes] ([ClassID], [ClassName]) VALUES (1, N'1')
INSERT [dbo].[Classes] ([ClassID], [ClassName]) VALUES (2, N'2')
INSERT [dbo].[Classes] ([ClassID], [ClassName]) VALUES (3, N'3')
INSERT [dbo].[Classes] ([ClassID], [ClassName]) VALUES (4, N'4')
INSERT [dbo].[Classes] ([ClassID], [ClassName]) VALUES (5, N'5')
INSERT [dbo].[Classes] ([ClassID], [ClassName]) VALUES (6, N'6')
INSERT [dbo].[Classes] ([ClassID], [ClassName]) VALUES (7, N'7')
INSERT [dbo].[Classes] ([ClassID], [ClassName]) VALUES (8, N'8')
INSERT [dbo].[Classes] ([ClassID], [ClassName]) VALUES (9, N'9')
INSERT [dbo].[Classes] ([ClassID], [ClassName]) VALUES (10, N'10')
INSERT [dbo].[Classes] ([ClassID], [ClassName]) VALUES (11, N'11')
SET IDENTITY_INSERT [dbo].[Classes] OFF
SET IDENTITY_INSERT [dbo].[SubjectClass] ON 

INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (1, 1, 1)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (2, 2, 1)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (3, 3, 1)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (4, 3, 2)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (5, 4, 2)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (6, 5, 2)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (7, 5, 3)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (8, 6, 3)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (9, 7, 3)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (10, 7, 4)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (11, 1, 4)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (12, 2, 4)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (13, 2, 5)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (14, 3, 5)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (15, 4, 5)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (16, 4, 6)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (17, 5, 6)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (18, 6, 6)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (19, 6, 7)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (20, 7, 7)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (21, 1, 7)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (22, 1, 8)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (23, 2, 8)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (24, 3, 8)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (25, 3, 9)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (26, 4, 9)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (27, 5, 9)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (28, 5, 10)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (29, 6, 10)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (30, 7, 10)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (31, 7, 11)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (32, 1, 11)
INSERT [dbo].[SubjectClass] ([SubjectClassID], [SubjectID], [ClassID]) VALUES (33, 2, 11)
SET IDENTITY_INSERT [dbo].[SubjectClass] OFF
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([SubjectID], [SubjectName]) VALUES (1, N'Math')
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName]) VALUES (2, N'Chemistry')
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName]) VALUES (3, N'Biology')
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName]) VALUES (4, N'History')
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName]) VALUES (5, N'English')
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName]) VALUES (6, N'Literature')
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName]) VALUES (7, N'Physics')
SET IDENTITY_INSERT [dbo].[Subjects] OFF
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [TeacherSurname], [ClassID], [SubjectID]) VALUES (4, N'Aykhan', N'Dadashov', 10, 6)
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [TeacherSurname], [ClassID], [SubjectID]) VALUES (5, N'Alakbar', N'Alakbarov', 11, 2)
SET IDENTITY_INSERT [dbo].[Teachers] OFF
ALTER TABLE [dbo].[Students]  WITH CHECK ADD FOREIGN KEY([ClassID])
REFERENCES [dbo].[Classes] ([ClassID])
GO
ALTER TABLE [dbo].[SubjectClass]  WITH CHECK ADD FOREIGN KEY([ClassID])
REFERENCES [dbo].[Classes] ([ClassID])
GO
ALTER TABLE [dbo].[SubjectClass]  WITH CHECK ADD FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([SubjectID])
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD FOREIGN KEY([ClassID])
REFERENCES [dbo].[Classes] ([ClassID])
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([SubjectID])
GO
USE [master]
GO
ALTER DATABASE [SchoolDb] SET  READ_WRITE 
GO
