USE [master]
GO
/****** Object:  Database [Fitness_Club]    Script Date: 11/5/2018 7:25:12 PM ******/
CREATE DATABASE [Fitness_Club]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Fitness_Club', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Fitness_Club.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Fitness_Club_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Fitness_Club_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Fitness_Club] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Fitness_Club].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Fitness_Club] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Fitness_Club] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Fitness_Club] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Fitness_Club] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Fitness_Club] SET ARITHABORT OFF 
GO
ALTER DATABASE [Fitness_Club] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Fitness_Club] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Fitness_Club] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Fitness_Club] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Fitness_Club] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Fitness_Club] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Fitness_Club] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Fitness_Club] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Fitness_Club] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Fitness_Club] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Fitness_Club] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Fitness_Club] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Fitness_Club] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Fitness_Club] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Fitness_Club] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Fitness_Club] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Fitness_Club] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Fitness_Club] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Fitness_Club] SET  MULTI_USER 
GO
ALTER DATABASE [Fitness_Club] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Fitness_Club] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Fitness_Club] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Fitness_Club] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Fitness_Club] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Fitness_Club]
GO
/****** Object:  Table [dbo].[InstructorFreeTimeTable]    Script Date: 11/5/2018 7:25:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstructorFreeTimeTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[WeekDay] [nchar](30) NOT NULL,
	[Date] [date] NOT NULL,
	[Time] [nchar](30) NOT NULL,
	[InstructorID] [int] NOT NULL,
 CONSTRAINT [PK_InstructorFreeTimeTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InstructorTimeTable]    Script Date: 11/5/2018 7:25:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstructorTimeTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[WeekDay] [nchar](30) NOT NULL,
	[Time] [nchar](30) NOT NULL,
	[Date] [date] NOT NULL,
	[UserID] [int] NOT NULL,
	[InstructorID] [int] NOT NULL,
 CONSTRAINT [PK_InstructorTimeTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Manager]    Script Date: 11/5/2018 7:25:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](60) NOT NULL,
	[LastName] [nchar](60) NOT NULL,
	[PersonalNumber] [bigint] NOT NULL,
	[Password] [nchar](60) NOT NULL,
 CONSTRAINT [PK_Manager] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Packages]    Script Date: 11/5/2018 7:25:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Packages](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PackageName] [nchar](60) NOT NULL,
	[PackagePrice] [int] NOT NULL,
 CONSTRAINT [PK_Packages] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Photo]    Script Date: 11/5/2018 7:25:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Photo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Trenners] [nchar](60) NULL,
	[Users] [nchar](60) NULL,
	[Gym] [nchar](60) NULL,
 CONSTRAINT [PK_Photo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrennerInformation]    Script Date: 11/5/2018 7:25:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrennerInformation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](30) NOT NULL,
	[Surname] [nchar](50) NOT NULL,
	[Username] [int] NOT NULL,
	[Password] [nchar](30) NOT NULL,
	[SallaryPerHour] [int] NOT NULL,
	[PhotoID] [int] NULL,
	[PN] [bigint] NOT NULL,
 CONSTRAINT [PK_TrennerInformation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserInformation]    Script Date: 11/5/2018 7:25:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInformation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](30) NOT NULL,
	[LastName] [nchar](60) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
	[PersonalNumber] [bigint] NOT NULL,
	[PhotoID] [int] NULL,
	[Password] [nchar](60) NOT NULL,
	[PackageID] [int] NULL,
 CONSTRAINT [PK_UserInformation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserTimeTable]    Script Date: 11/5/2018 7:25:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTimeTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[WeekDay] [nchar](30) NOT NULL,
	[Time] [nchar](30) NOT NULL,
	[Date] [date] NOT NULL,
	[InstructorID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_UserTimeTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Manager] ON 

INSERT [dbo].[Manager] ([ID], [Name], [LastName], [PersonalNumber], [Password]) VALUES (1, N'Mariam                                                      ', N'Talakhadze                                                  ', 11001029167, N'BlaBlaBla                                                   ')
SET IDENTITY_INSERT [dbo].[Manager] OFF
SET IDENTITY_INSERT [dbo].[UserInformation] ON 

INSERT [dbo].[UserInformation] ([ID], [Name], [LastName], [PhoneNumber], [PersonalNumber], [PhotoID], [Password], [PackageID]) VALUES (1, N'mariam                        ', N'talakhadze                                                  ', 558783089, 11001029167, NULL, N'nini                                                        ', NULL)
INSERT [dbo].[UserInformation] ([ID], [Name], [LastName], [PhoneNumber], [PersonalNumber], [PhotoID], [Password], [PackageID]) VALUES (12, N'mimi                          ', N'nini                                                        ', 12321, 11111111111, NULL, N'mimi                                                        ', NULL)
INSERT [dbo].[UserInformation] ([ID], [Name], [LastName], [PhoneNumber], [PersonalNumber], [PhotoID], [Password], [PackageID]) VALUES (13, N'mariami                       ', N'ijiji                                                       ', 454545, 12345678910, NULL, N'momo                                                        ', NULL)
INSERT [dbo].[UserInformation] ([ID], [Name], [LastName], [PhoneNumber], [PersonalNumber], [PhotoID], [Password], [PackageID]) VALUES (14, N'luka                          ', N'qutateladze                                                 ', 12345, 12312312311, NULL, N'quta                                                        ', NULL)
SET IDENTITY_INSERT [dbo].[UserInformation] OFF
ALTER TABLE [dbo].[InstructorFreeTimeTable]  WITH CHECK ADD  CONSTRAINT [FK_InstructorFreeTimeTable_TrennerInformation] FOREIGN KEY([InstructorID])
REFERENCES [dbo].[TrennerInformation] ([ID])
GO
ALTER TABLE [dbo].[InstructorFreeTimeTable] CHECK CONSTRAINT [FK_InstructorFreeTimeTable_TrennerInformation]
GO
ALTER TABLE [dbo].[InstructorTimeTable]  WITH CHECK ADD  CONSTRAINT [FK_InstructorTimeTable_TrennerInformation] FOREIGN KEY([InstructorID])
REFERENCES [dbo].[TrennerInformation] ([ID])
GO
ALTER TABLE [dbo].[InstructorTimeTable] CHECK CONSTRAINT [FK_InstructorTimeTable_TrennerInformation]
GO
ALTER TABLE [dbo].[InstructorTimeTable]  WITH CHECK ADD  CONSTRAINT [FK_InstructorTimeTable_UserInformation] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserInformation] ([ID])
GO
ALTER TABLE [dbo].[InstructorTimeTable] CHECK CONSTRAINT [FK_InstructorTimeTable_UserInformation]
GO
ALTER TABLE [dbo].[TrennerInformation]  WITH CHECK ADD  CONSTRAINT [FK_TrennerInformation_Photo] FOREIGN KEY([PhotoID])
REFERENCES [dbo].[Photo] ([ID])
GO
ALTER TABLE [dbo].[TrennerInformation] CHECK CONSTRAINT [FK_TrennerInformation_Photo]
GO
ALTER TABLE [dbo].[UserInformation]  WITH CHECK ADD  CONSTRAINT [FK_UserInformation_Packages] FOREIGN KEY([PackageID])
REFERENCES [dbo].[Packages] ([ID])
GO
ALTER TABLE [dbo].[UserInformation] CHECK CONSTRAINT [FK_UserInformation_Packages]
GO
ALTER TABLE [dbo].[UserInformation]  WITH CHECK ADD  CONSTRAINT [FK_UserInformation_Photo] FOREIGN KEY([PhotoID])
REFERENCES [dbo].[Photo] ([ID])
GO
ALTER TABLE [dbo].[UserInformation] CHECK CONSTRAINT [FK_UserInformation_Photo]
GO
ALTER TABLE [dbo].[UserTimeTable]  WITH CHECK ADD  CONSTRAINT [FK_UserTimeTable_TrennerInformation] FOREIGN KEY([InstructorID])
REFERENCES [dbo].[TrennerInformation] ([ID])
GO
ALTER TABLE [dbo].[UserTimeTable] CHECK CONSTRAINT [FK_UserTimeTable_TrennerInformation]
GO
ALTER TABLE [dbo].[UserTimeTable]  WITH CHECK ADD  CONSTRAINT [FK_UserTimeTable_UserInformation] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserInformation] ([ID])
GO
ALTER TABLE [dbo].[UserTimeTable] CHECK CONSTRAINT [FK_UserTimeTable_UserInformation]
GO
USE [master]
GO
ALTER DATABASE [Fitness_Club] SET  READ_WRITE 
GO
