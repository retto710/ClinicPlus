USE [master]
GO
/****** Object:  Database [FinalAppWeb]    Script Date: 5/19/2018 3:27:25 PM ******/
CREATE DATABASE [FinalAppWeb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FinalAppWeb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\FinalAppWeb.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FinalAppWeb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\FinalAppWeb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FinalAppWeb] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FinalAppWeb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FinalAppWeb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FinalAppWeb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FinalAppWeb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FinalAppWeb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FinalAppWeb] SET ARITHABORT OFF 
GO
ALTER DATABASE [FinalAppWeb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FinalAppWeb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FinalAppWeb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FinalAppWeb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FinalAppWeb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FinalAppWeb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FinalAppWeb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FinalAppWeb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FinalAppWeb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FinalAppWeb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FinalAppWeb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FinalAppWeb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FinalAppWeb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FinalAppWeb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FinalAppWeb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FinalAppWeb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FinalAppWeb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FinalAppWeb] SET RECOVERY FULL 
GO
ALTER DATABASE [FinalAppWeb] SET  MULTI_USER 
GO
ALTER DATABASE [FinalAppWeb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FinalAppWeb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FinalAppWeb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FinalAppWeb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [FinalAppWeb] SET DELAYED_DURABILITY = DISABLED 
GO
USE [FinalAppWeb]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 5/19/2018 3:27:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[personId] [int] NOT NULL,
 CONSTRAINT [PK_admin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[alergies]    Script Date: 5/19/2018 3:27:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alergies](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_alergies] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[clinicDate]    Script Date: 5/19/2018 3:27:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clinicDate](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clinicHistorytId] [int] NOT NULL,
	[doctorId] [int] NOT NULL,
	[nurseId] [int] NOT NULL,
	[dateOfRequest] [date] NOT NULL,
	[dateOfAppointment] [date] NOT NULL,
	[description] [nvarchar](50) NOT NULL,
	[status] [bit] NOT NULL,
	[weight] [decimal](5, 2) NULL,
	[height] [decimal](5, 2) NULL,
	[alergies] [nvarchar](50) NULL,
 CONSTRAINT [PK_clinicDate] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[clinicHistory]    Script Date: 5/19/2018 3:27:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clinicHistory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[patientId] [int] NOT NULL,
	[date] [date] NOT NULL,
	[weight] [decimal](5, 2) NULL,
	[height] [decimal](5, 2) NULL,
	[alergies] [nvarchar](50) NULL,
	[description] [nvarchar](50) NULL,
 CONSTRAINT [PK_clinicHistory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[clinicHistory_Alergie]    Script Date: 5/19/2018 3:27:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clinicHistory_Alergie](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clinicHistoryId] [int] NOT NULL,
	[AlergieId] [int] NOT NULL,
 CONSTRAINT [PK_clinicHistory_Alergie] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[doctor]    Script Date: 5/19/2018 3:27:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[personId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[dateOfEnrollment] [date] NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_doctor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[doctor_speciality]    Script Date: 5/19/2018 3:27:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctor_speciality](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[doctorId] [int] NOT NULL,
	[specialityId] [int] NOT NULL,
 CONSTRAINT [PK_doctor_speciality] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nurse]    Script Date: 5/19/2018 3:27:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nurse](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[personId] [int] NOT NULL,
	[userid] [int] NOT NULL,
	[dateOfEnrollment] [date] NOT NULL,
 CONSTRAINT [PK_nurse] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[patient]    Script Date: 5/19/2018 3:27:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[personId] [int] NOT NULL,
 CONSTRAINT [PK_patient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[person]    Script Date: 5/19/2018 3:27:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[person](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[DNI] [decimal](8, 0) NOT NULL,
	[gender] [nvarchar](50) NOT NULL,
	[age] [int] NOT NULL,
	[phone] [decimal](9, 0) NOT NULL,
	[dateOfBith] [date] NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[address] [nvarchar](100) NOT NULL,
	[nationality] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_patients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[services]    Script Date: 5/19/2018 3:27:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[services](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[doctorId] [int] NOT NULL,
	[clinicDateId] [int] NOT NULL,
	[dateOfRequest] [date] NOT NULL,
	[dateOfService] [date] NOT NULL,
	[description] [nvarchar](50) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_services] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[speciality]    Script Date: 5/19/2018 3:27:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[speciality](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[description] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_especialties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user]    Script Date: 5/19/2018 3:27:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](10) NOT NULL,
	[password] [nvarchar](20) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[admin] ON 

INSERT [dbo].[admin] ([ID], [userId], [personId]) VALUES (1, 1, 1)
INSERT [dbo].[admin] ([ID], [userId], [personId]) VALUES (7, 2, 2)
INSERT [dbo].[admin] ([ID], [userId], [personId]) VALUES (8, 7, 5)
INSERT [dbo].[admin] ([ID], [userId], [personId]) VALUES (9, 23, 33)
SET IDENTITY_INSERT [dbo].[admin] OFF
SET IDENTITY_INSERT [dbo].[alergies] ON 

INSERT [dbo].[alergies] ([ID], [descripcion]) VALUES (1, N'panadol')
INSERT [dbo].[alergies] ([ID], [descripcion]) VALUES (2, N'chocolate')
SET IDENTITY_INSERT [dbo].[alergies] OFF
SET IDENTITY_INSERT [dbo].[clinicDate] ON 

INSERT [dbo].[clinicDate] ([id], [clinicHistorytId], [doctorId], [nurseId], [dateOfRequest], [dateOfAppointment], [description], [status], [weight], [height], [alergies]) VALUES (1, 2, 2, 3, CAST(N'2018-05-18' AS Date), CAST(N'2018-05-19' AS Date), N'pls', 0, CAST(1.00 AS Decimal(5, 2)), CAST(2.00 AS Decimal(5, 2)), N'si')
INSERT [dbo].[clinicDate] ([id], [clinicHistorytId], [doctorId], [nurseId], [dateOfRequest], [dateOfAppointment], [description], [status], [weight], [height], [alergies]) VALUES (3, 4, 1, 3, CAST(N'2018-05-18' AS Date), CAST(N'2018-05-18' AS Date), N'nada', 1, CAST(4.00 AS Decimal(5, 2)), CAST(5.00 AS Decimal(5, 2)), N'si')
INSERT [dbo].[clinicDate] ([id], [clinicHistorytId], [doctorId], [nurseId], [dateOfRequest], [dateOfAppointment], [description], [status], [weight], [height], [alergies]) VALUES (6, 2, 1, 3, CAST(N'2018-05-19' AS Date), CAST(N'2018-05-19' AS Date), N'nada', 1, CAST(78.50 AS Decimal(5, 2)), CAST(1.23 AS Decimal(5, 2)), N'si')
SET IDENTITY_INSERT [dbo].[clinicDate] OFF
SET IDENTITY_INSERT [dbo].[clinicHistory] ON 

INSERT [dbo].[clinicHistory] ([id], [patientId], [date], [weight], [height], [alergies], [description]) VALUES (2, 1, CAST(N'2018-05-18' AS Date), CAST(78.50 AS Decimal(5, 2)), CAST(1.23 AS Decimal(5, 2)), N'si', N'18/05/2018 12:00:00 a. m.')
INSERT [dbo].[clinicHistory] ([id], [patientId], [date], [weight], [height], [alergies], [description]) VALUES (3, 3, CAST(N'2018-05-18' AS Date), CAST(4.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(5, 2)), N'no', N'nada')
INSERT [dbo].[clinicHistory] ([id], [patientId], [date], [weight], [height], [alergies], [description]) VALUES (4, 7, CAST(N'2018-05-18' AS Date), CAST(4.00 AS Decimal(5, 2)), CAST(5.00 AS Decimal(5, 2)), N'si', N'nada x2')
INSERT [dbo].[clinicHistory] ([id], [patientId], [date], [weight], [height], [alergies], [description]) VALUES (5, 24, CAST(N'2018-05-19' AS Date), CAST(4.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(5, 2)), N'no', N'sada')
INSERT [dbo].[clinicHistory] ([id], [patientId], [date], [weight], [height], [alergies], [description]) VALUES (6, 2, CAST(N'2018-05-19' AS Date), CAST(120.40 AS Decimal(5, 2)), CAST(210.00 AS Decimal(5, 2)), N'no', N'5/19/2018 12:00:00 AM')
SET IDENTITY_INSERT [dbo].[clinicHistory] OFF
SET IDENTITY_INSERT [dbo].[clinicHistory_Alergie] ON 

INSERT [dbo].[clinicHistory_Alergie] ([id], [clinicHistoryId], [AlergieId]) VALUES (2, 2, 1)
INSERT [dbo].[clinicHistory_Alergie] ([id], [clinicHistoryId], [AlergieId]) VALUES (3, 2, 1)
INSERT [dbo].[clinicHistory_Alergie] ([id], [clinicHistoryId], [AlergieId]) VALUES (5, 2, 2)
INSERT [dbo].[clinicHistory_Alergie] ([id], [clinicHistoryId], [AlergieId]) VALUES (6, 5, 1)
SET IDENTITY_INSERT [dbo].[clinicHistory_Alergie] OFF
SET IDENTITY_INSERT [dbo].[doctor] ON 

INSERT [dbo].[doctor] ([id], [personId], [userId], [dateOfEnrollment], [status]) VALUES (1, 1, 1, CAST(N'2018-05-17' AS Date), 1)
INSERT [dbo].[doctor] ([id], [personId], [userId], [dateOfEnrollment], [status]) VALUES (2, 2, 2, CAST(N'2018-05-17' AS Date), 1)
INSERT [dbo].[doctor] ([id], [personId], [userId], [dateOfEnrollment], [status]) VALUES (3, 13, 5, CAST(N'2018-05-18' AS Date), 1)
INSERT [dbo].[doctor] ([id], [personId], [userId], [dateOfEnrollment], [status]) VALUES (4, 18, 11, CAST(N'2018-05-18' AS Date), 1)
INSERT [dbo].[doctor] ([id], [personId], [userId], [dateOfEnrollment], [status]) VALUES (5, 34, 24, CAST(N'2018-05-19' AS Date), 1)
SET IDENTITY_INSERT [dbo].[doctor] OFF
SET IDENTITY_INSERT [dbo].[doctor_speciality] ON 

INSERT [dbo].[doctor_speciality] ([id], [doctorId], [specialityId]) VALUES (1, 1, 4)
INSERT [dbo].[doctor_speciality] ([id], [doctorId], [specialityId]) VALUES (2, 2, 4)
INSERT [dbo].[doctor_speciality] ([id], [doctorId], [specialityId]) VALUES (3, 1, 5)
INSERT [dbo].[doctor_speciality] ([id], [doctorId], [specialityId]) VALUES (4, 1, 4)
SET IDENTITY_INSERT [dbo].[doctor_speciality] OFF
SET IDENTITY_INSERT [dbo].[nurse] ON 

INSERT [dbo].[nurse] ([id], [personId], [userid], [dateOfEnrollment]) VALUES (1, 4, 3, CAST(N'0001-01-01' AS Date))
INSERT [dbo].[nurse] ([id], [personId], [userid], [dateOfEnrollment]) VALUES (3, 13, 5, CAST(N'0001-01-01' AS Date))
INSERT [dbo].[nurse] ([id], [personId], [userid], [dateOfEnrollment]) VALUES (4, 12, 6, CAST(N'0001-01-01' AS Date))
INSERT [dbo].[nurse] ([id], [personId], [userid], [dateOfEnrollment]) VALUES (5, 8, 8, CAST(N'0001-01-01' AS Date))
INSERT [dbo].[nurse] ([id], [personId], [userid], [dateOfEnrollment]) VALUES (6, 9, 9, CAST(N'0001-01-01' AS Date))
INSERT [dbo].[nurse] ([id], [personId], [userid], [dateOfEnrollment]) VALUES (7, 10, 10, CAST(N'0001-01-01' AS Date))
INSERT [dbo].[nurse] ([id], [personId], [userid], [dateOfEnrollment]) VALUES (8, 17, 4, CAST(N'0001-01-01' AS Date))
INSERT [dbo].[nurse] ([id], [personId], [userid], [dateOfEnrollment]) VALUES (9, 20, 12, CAST(N'0001-01-01' AS Date))
INSERT [dbo].[nurse] ([id], [personId], [userid], [dateOfEnrollment]) VALUES (10, 1, 1, CAST(N'0001-01-01' AS Date))
SET IDENTITY_INSERT [dbo].[nurse] OFF
SET IDENTITY_INSERT [dbo].[patient] ON 

INSERT [dbo].[patient] ([id], [personId]) VALUES (1, 2)
INSERT [dbo].[patient] ([id], [personId]) VALUES (2, 1)
INSERT [dbo].[patient] ([id], [personId]) VALUES (3, 3)
INSERT [dbo].[patient] ([id], [personId]) VALUES (5, 5)
INSERT [dbo].[patient] ([id], [personId]) VALUES (6, 6)
INSERT [dbo].[patient] ([id], [personId]) VALUES (7, 7)
INSERT [dbo].[patient] ([id], [personId]) VALUES (8, 11)
INSERT [dbo].[patient] ([id], [personId]) VALUES (9, 12)
INSERT [dbo].[patient] ([id], [personId]) VALUES (10, 15)
INSERT [dbo].[patient] ([id], [personId]) VALUES (11, 16)
INSERT [dbo].[patient] ([id], [personId]) VALUES (12, 19)
INSERT [dbo].[patient] ([id], [personId]) VALUES (13, 21)
INSERT [dbo].[patient] ([id], [personId]) VALUES (14, 22)
INSERT [dbo].[patient] ([id], [personId]) VALUES (15, 23)
INSERT [dbo].[patient] ([id], [personId]) VALUES (16, 24)
INSERT [dbo].[patient] ([id], [personId]) VALUES (17, 25)
INSERT [dbo].[patient] ([id], [personId]) VALUES (18, 26)
INSERT [dbo].[patient] ([id], [personId]) VALUES (19, 27)
INSERT [dbo].[patient] ([id], [personId]) VALUES (20, 28)
INSERT [dbo].[patient] ([id], [personId]) VALUES (21, 29)
INSERT [dbo].[patient] ([id], [personId]) VALUES (22, 30)
INSERT [dbo].[patient] ([id], [personId]) VALUES (23, 31)
INSERT [dbo].[patient] ([id], [personId]) VALUES (24, 32)
INSERT [dbo].[patient] ([id], [personId]) VALUES (25, 33)
INSERT [dbo].[patient] ([id], [personId]) VALUES (26, 35)
SET IDENTITY_INSERT [dbo].[patient] OFF
SET IDENTITY_INSERT [dbo].[person] ON 

INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (1, N'Anthony', N'Retto', CAST(73530766 AS Decimal(8, 0)), N'Male', 22, CAST(986232837 AS Decimal(9, 0)), CAST(N'1995-10-07' AS Date), N'a@gmail.com', N'ada', N'Peruvian')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (2, N'Jose', N'Jamon', CAST(73530765 AS Decimal(8, 0)), N'Female', 34, CAST(43229876 AS Decimal(9, 0)), CAST(N'2018-05-08' AS Date), N'jj@gmail.com', N'asda', N'asada')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (3, N'sada', N'a', CAST(46549879 AS Decimal(8, 0)), N'Female', 2, CAST(54650 AS Decimal(9, 0)), CAST(N'2018-05-16' AS Date), N'a', N'a', N'a')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (4, N'asa', N'a', CAST(15465465 AS Decimal(8, 0)), N'Female', 100, CAST(2320 AS Decimal(9, 0)), CAST(N'2018-05-16' AS Date), N'asa', N'a', N'a')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (5, N'Renato', N'Mercado', CAST(78945646 AS Decimal(8, 0)), N'Male', 20, CAST(972983014 AS Decimal(9, 0)), CAST(N'1998-02-02' AS Date), N'u201510738@upc.edu.pe', N'Av. no se', N'Peruano')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (6, N'Alejandra', N'Arevalo', CAST(54652031 AS Decimal(8, 0)), N'Female', 89, CAST(456237981 AS Decimal(9, 0)), CAST(N'1929-06-20' AS Date), N'P2@contoso.pe', N'Av. siempre viva', N'NorCoreana')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (7, N'Edison', N'Echevarria', CAST(77465456 AS Decimal(8, 0)), N'Male', 45, CAST(456321831 AS Decimal(9, 0)), CAST(N'1973-07-23' AS Date), N'P2@contoso.pe', N'Av.los elotes 123', N'Siria')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (8, N'Fabricio', N'Fernanandez', CAST(77465457 AS Decimal(8, 0)), N'Male', 40, CAST(456321831 AS Decimal(9, 0)), CAST(N'1978-07-16' AS Date), N'P3@contoso.pe', N'Av.los elotes 124', N'Pakistani')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (9, N'Britany', N'Belboa', CAST(77465458 AS Decimal(8, 0)), N'Female', 32, CAST(456321831 AS Decimal(9, 0)), CAST(N'1986-05-14' AS Date), N'P4@contoso.pe', N'Av.los elotes 125', N'liechtensteiniana')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (10, N'Clara', N'Columbus', CAST(13287513 AS Decimal(8, 0)), N'Female', 78, CAST(456789126 AS Decimal(9, 0)), CAST(N'1940-07-09' AS Date), N'P5@contoso.pe', N'Av. siempre trieste 1243', N'Irani')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (11, N'Dario', N'Domingez', CAST(89735123 AS Decimal(8, 0)), N'Female', 48, CAST(486523456 AS Decimal(9, 0)), CAST(N'1970-02-04' AS Date), N'P6@contoso.pe', N'Giron Depresion 213', N'China')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (12, N'Gerardo', N'Garcia', CAST(87932145 AS Decimal(8, 0)), N'Male', 99, CAST(0 AS Decimal(9, 0)), CAST(N'1919-11-27' AS Date), N'P7@contoso.pe', N'Av. juventud 732', N'Yugoslava')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (13, N'Helena', N'Hernandez', CAST(78494321 AS Decimal(8, 0)), N'Female', 100, CAST(465123456 AS Decimal(9, 0)), CAST(N'1900-01-01' AS Date), N'P8@contoso.pe', N'Av. las golondrinas 3432', N'togolesa')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (14, N'Irvin', N'Inga', CAST(78494321 AS Decimal(8, 0)), N'Female', 77, CAST(465123456 AS Decimal(9, 0)), CAST(N'1941-05-06' AS Date), N'P8@contoso.pe', N'Av. las golondrinas 3432', N'sanvicentino')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (15, N'Laura', N'Larco', CAST(78494328 AS Decimal(8, 0)), N'Female', 33, CAST(456123789 AS Decimal(9, 0)), CAST(N'1985-03-04' AS Date), N'P9@contoso.pe', N'Av. correos repetitivos 1253', N'luxemburguesa')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (16, N'Wilson', N'Won', CAST(22222222 AS Decimal(8, 0)), N'Male', 22, CAST(123456783 AS Decimal(9, 0)), CAST(N'1996-06-02' AS Date), N'P10@contoso.pe', N'Av. dos 222', N'Argeliano')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (17, N'Tobias', N'Tapia', CAST(33333333 AS Decimal(8, 0)), N'Male', 33, CAST(333333333 AS Decimal(9, 0)), CAST(N'1985-03-03' AS Date), N'P11@contoso.pe', N'Av. tres 333', N'Tripolino')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (18, N'Yelsin', N'Yoyo', CAST(44444444 AS Decimal(8, 0)), N'Male', 44, CAST(444444444 AS Decimal(9, 0)), CAST(N'1974-04-04' AS Date), N'P12@contoso.pe', N'Av. cuatroIV 4444', N'Lituanes')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (19, N'Xiomara', N'Xia', CAST(55555555 AS Decimal(8, 0)), N'Female', 55, CAST(555555555 AS Decimal(9, 0)), CAST(N'1963-05-05' AS Date), N'P13@contoso.pe', N'Av. cinco_V cinco', N'rusa')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (20, N'Jimena', N'Jimenez', CAST(56413251 AS Decimal(8, 0)), N'Female', 64, CAST(413212344 AS Decimal(9, 0)), CAST(N'1964-07-19' AS Date), N'P14@contoso.pe', N'Av. jota Mz. J 23', N'jamaiquina')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (21, N'Otto', N'Olivares', CAST(54651321 AS Decimal(8, 0)), N'Male', 44, CAST(123456986 AS Decimal(9, 0)), CAST(N'1974-07-07' AS Date), N'P15@contoso.pe', N'Av. Avestruz 213', N'Aleman')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (22, N'Paulo', N'Pascual', CAST(12321233 AS Decimal(8, 0)), N'Male', 0, CAST(0 AS Decimal(9, 0)), CAST(N'2018-05-16' AS Date), N'P16@contoso.pe', N'Av. registro R1234', N'Peruano')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (23, N'skduak', N'jghkjag', CAST(28163918 AS Decimal(8, 0)), N'Female', 10, CAST(999999999 AS Decimal(9, 0)), CAST(N'2018-05-19' AS Date), N'askjdk', N'skjdhkja', N'kjhkj')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (24, N'khsjgdkahj', N'kjhsxkjd', CAST(72683761 AS Decimal(8, 0)), N'Male', 20, CAST(999999999 AS Decimal(9, 0)), CAST(N'2018-05-19' AS Date), N'ahgdjha', N'kjhgsakj', N'kajsh')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (25, N'amhgdkhak', N'jksjadhk', CAST(12345678 AS Decimal(8, 0)), N'Female', 3, CAST(763871268 AS Decimal(9, 0)), CAST(N'2018-05-19' AS Date), N'asjhd', N'kjsxhfks', N'kjhkj')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (26, N'asjdhkas', N'kjgsakdjag', CAST(98765432 AS Decimal(8, 0)), N'Male', 100, CAST(12124310 AS Decimal(9, 0)), CAST(N'2018-05-19' AS Date), N'asda', N'sada', N'asda')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (27, N'name1', N'las1', CAST(87654321 AS Decimal(8, 0)), N'Male', 20, CAST(176270 AS Decimal(9, 0)), CAST(N'2018-05-19' AS Date), N'sakjdgak', N'kjhasdkj', N'jsdhka')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (28, N'anthony', N'hagskdj', CAST(9876543 AS Decimal(8, 0)), N'Male', 100, CAST(1210 AS Decimal(9, 0)), CAST(N'2018-05-19' AS Date), N'asd,jagk', N'kjsakdjak', N'jkh')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (29, N'asdjg', N'jkashdk', CAST(13579246 AS Decimal(8, 0)), N'Female', 20, CAST(120 AS Decimal(9, 0)), CAST(N'2018-05-19' AS Date), N'asdjah', N'asjdhk', N'kjhk')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (30, N'nasdkj', N'kjsahdkja', CAST(21937634 AS Decimal(8, 0)), N'Male', 3, CAST(125 AS Decimal(9, 0)), CAST(N'2018-05-19' AS Date), N'kajshgdk', N'kjhkjdah', N'kjhkj')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (31, N'sakjdhk', N'kjsahkdj', CAST(28176387 AS Decimal(8, 0)), N'Female', 10, CAST(1120 AS Decimal(9, 0)), CAST(N'2018-05-19' AS Date), N'ashjdgak', N'kjhaskjd', N'kjhk')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (32, N'kasjdfhk', N'kjhsdkjf', CAST(32746382 AS Decimal(8, 0)), N'Female', 20, CAST(231310 AS Decimal(9, 0)), CAST(N'2018-05-19' AS Date), N'jasbdhkj', N'kljsdhakjh', N'kjhkj')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (33, N'name1', N'last1', CAST(82153875 AS Decimal(8, 0)), N'Male', 100, CAST(239216390 AS Decimal(9, 0)), CAST(N'2018-05-19' AS Date), N'sdsad', N'asda', N'sad')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (34, N'name', N'last', CAST(1234567 AS Decimal(8, 0)), N'Female', 20, CAST(230 AS Decimal(9, 0)), CAST(N'2018-05-19' AS Date), N'sada', N'sda', N'asda')
INSERT [dbo].[person] ([ID], [name], [lastName], [DNI], [gender], [age], [phone], [dateOfBith], [email], [address], [nationality]) VALUES (35, N'kasjh', N'ahsdgh', CAST(82713658 AS Decimal(8, 0)), N'Male', 100, CAST(2173680 AS Decimal(9, 0)), CAST(N'2018-05-19' AS Date), N'asjbdk', N'kjhaskj', N'kjh')
SET IDENTITY_INSERT [dbo].[person] OFF
SET IDENTITY_INSERT [dbo].[speciality] ON 

INSERT [dbo].[speciality] ([ID], [description]) VALUES (4, N'Audiology')
INSERT [dbo].[speciality] ([ID], [description]) VALUES (5, N'Pathology')
INSERT [dbo].[speciality] ([ID], [description]) VALUES (6, N'Pediatry')
SET IDENTITY_INSERT [dbo].[speciality] OFF
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (1, N'a73530766', N'joven123', N'anthonyretto@gmail.com')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (2, N'J73530765', N'default1', N'jj@gmail.com')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (3, N'a15465465', N'default1', N'asa')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (4, N'T33333333', N'default1', N'P11@contoso.pe')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (5, N'H78494321', N'default1', N'P8@contoso.pe')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (6, N'G87932145', N'default1', N'P7@contoso.pe')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (7, N'R78945646', N'default1', N'u201510738@upc.edu.pe')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (8, N'F77465457', N'default1', N'P3@contoso.pe')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (9, N'B77465458', N'default1', N'P4@contoso.pe')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (10, N'C13287513', N'default1', N'P5@contoso.pe')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (11, N'Y44444444', N'default1', N'P12@contoso.pe')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (12, N'J56413251', N'default1', N'P14@contoso.pe')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (13, N's46549879', N'default1', N'a')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (14, N'k72683761', N'default1', N'ahgdjha')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (15, N'a12345678', N'default1', N'asjhd')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (16, N'a98765432', N'default1', N'asda')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (17, N'n87654321', N'default1', N'sakjdgak')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (18, N'a9876543', N'default1', N'asd,jagk')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (19, N'a13579246', N'default1', N'asdjah')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (20, N'n21937634', N'default1', N'kajshgdk')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (21, N's28176387', N'default1', N'ashjdgak')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (22, N'k32746382', N'default1', N'jasbdhkj')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (23, N'n82153875', N'default1', N'sdsad')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (24, N'n1234567', N'default1', N'sada')
INSERT [dbo].[user] ([id], [username], [password], [email]) VALUES (25, N'k82713658', N'default1', N'asjbdk')
SET IDENTITY_INSERT [dbo].[user] OFF
ALTER TABLE [dbo].[admin]  WITH CHECK ADD  CONSTRAINT [FK_admin_person] FOREIGN KEY([personId])
REFERENCES [dbo].[person] ([ID])
GO
ALTER TABLE [dbo].[admin] CHECK CONSTRAINT [FK_admin_person]
GO
ALTER TABLE [dbo].[admin]  WITH CHECK ADD  CONSTRAINT [FK_admin_user] FOREIGN KEY([userId])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[admin] CHECK CONSTRAINT [FK_admin_user]
GO
ALTER TABLE [dbo].[clinicDate]  WITH CHECK ADD  CONSTRAINT [FK_clinicDate_doctor] FOREIGN KEY([doctorId])
REFERENCES [dbo].[doctor] ([id])
GO
ALTER TABLE [dbo].[clinicDate] CHECK CONSTRAINT [FK_clinicDate_doctor]
GO
ALTER TABLE [dbo].[clinicDate]  WITH CHECK ADD  CONSTRAINT [FK_clinicDate_nurse] FOREIGN KEY([nurseId])
REFERENCES [dbo].[nurse] ([id])
GO
ALTER TABLE [dbo].[clinicDate] CHECK CONSTRAINT [FK_clinicDate_nurse]
GO
ALTER TABLE [dbo].[clinicDate]  WITH CHECK ADD  CONSTRAINT [FK_clinicDate_patient] FOREIGN KEY([clinicHistorytId])
REFERENCES [dbo].[clinicHistory] ([id])
GO
ALTER TABLE [dbo].[clinicDate] CHECK CONSTRAINT [FK_clinicDate_patient]
GO
ALTER TABLE [dbo].[clinicHistory]  WITH CHECK ADD  CONSTRAINT [FK_clinicHistory_patient] FOREIGN KEY([patientId])
REFERENCES [dbo].[patient] ([id])
GO
ALTER TABLE [dbo].[clinicHistory] CHECK CONSTRAINT [FK_clinicHistory_patient]
GO
ALTER TABLE [dbo].[clinicHistory_Alergie]  WITH CHECK ADD  CONSTRAINT [FK_clinicHistory_Alergie_alergies] FOREIGN KEY([AlergieId])
REFERENCES [dbo].[alergies] ([ID])
GO
ALTER TABLE [dbo].[clinicHistory_Alergie] CHECK CONSTRAINT [FK_clinicHistory_Alergie_alergies]
GO
ALTER TABLE [dbo].[clinicHistory_Alergie]  WITH CHECK ADD  CONSTRAINT [FK_clinicHistory_Alergie_clinicHistory_Alergie] FOREIGN KEY([clinicHistoryId])
REFERENCES [dbo].[clinicHistory] ([id])
GO
ALTER TABLE [dbo].[clinicHistory_Alergie] CHECK CONSTRAINT [FK_clinicHistory_Alergie_clinicHistory_Alergie]
GO
ALTER TABLE [dbo].[doctor]  WITH CHECK ADD  CONSTRAINT [FK_doctor_person] FOREIGN KEY([personId])
REFERENCES [dbo].[person] ([ID])
GO
ALTER TABLE [dbo].[doctor] CHECK CONSTRAINT [FK_doctor_person]
GO
ALTER TABLE [dbo].[doctor]  WITH CHECK ADD  CONSTRAINT [FK_doctor_user] FOREIGN KEY([userId])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[doctor] CHECK CONSTRAINT [FK_doctor_user]
GO
ALTER TABLE [dbo].[doctor_speciality]  WITH CHECK ADD  CONSTRAINT [FK_doctor_speciality_doctor] FOREIGN KEY([doctorId])
REFERENCES [dbo].[doctor] ([id])
GO
ALTER TABLE [dbo].[doctor_speciality] CHECK CONSTRAINT [FK_doctor_speciality_doctor]
GO
ALTER TABLE [dbo].[doctor_speciality]  WITH CHECK ADD  CONSTRAINT [FK_doctor_speciality_specialties] FOREIGN KEY([specialityId])
REFERENCES [dbo].[speciality] ([ID])
GO
ALTER TABLE [dbo].[doctor_speciality] CHECK CONSTRAINT [FK_doctor_speciality_specialties]
GO
ALTER TABLE [dbo].[nurse]  WITH CHECK ADD  CONSTRAINT [FK_nurse_person] FOREIGN KEY([personId])
REFERENCES [dbo].[person] ([ID])
GO
ALTER TABLE [dbo].[nurse] CHECK CONSTRAINT [FK_nurse_person]
GO
ALTER TABLE [dbo].[nurse]  WITH CHECK ADD  CONSTRAINT [FK_nurse_user] FOREIGN KEY([userid])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[nurse] CHECK CONSTRAINT [FK_nurse_user]
GO
ALTER TABLE [dbo].[patient]  WITH CHECK ADD  CONSTRAINT [FK_patient_person] FOREIGN KEY([personId])
REFERENCES [dbo].[person] ([ID])
GO
ALTER TABLE [dbo].[patient] CHECK CONSTRAINT [FK_patient_person]
GO
ALTER TABLE [dbo].[services]  WITH CHECK ADD  CONSTRAINT [FK_services_clinicDate] FOREIGN KEY([clinicDateId])
REFERENCES [dbo].[clinicDate] ([id])
GO
ALTER TABLE [dbo].[services] CHECK CONSTRAINT [FK_services_clinicDate]
GO
ALTER TABLE [dbo].[services]  WITH CHECK ADD  CONSTRAINT [FK_services_doctor] FOREIGN KEY([doctorId])
REFERENCES [dbo].[doctor] ([id])
GO
ALTER TABLE [dbo].[services] CHECK CONSTRAINT [FK_services_doctor]
GO
USE [master]
GO
ALTER DATABASE [FinalAppWeb] SET  READ_WRITE 
GO
