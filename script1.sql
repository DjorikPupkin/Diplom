USE [master]
GO
/****** Object:  Database [SeerviceCom]    Script Date: 20.05.2024 16:37:47 ******/
CREATE DATABASE [SeerviceCom]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SeerviceCom', FILENAME = N'D:\SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\SeerviceCom.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SeerviceCom_log', FILENAME = N'D:\SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\SeerviceCom_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SeerviceCom].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SeerviceCom] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SeerviceCom] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SeerviceCom] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SeerviceCom] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SeerviceCom] SET ARITHABORT OFF 
GO
ALTER DATABASE [SeerviceCom] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SeerviceCom] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SeerviceCom] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SeerviceCom] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SeerviceCom] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SeerviceCom] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SeerviceCom] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SeerviceCom] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SeerviceCom] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SeerviceCom] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SeerviceCom] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SeerviceCom] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SeerviceCom] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SeerviceCom] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SeerviceCom] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SeerviceCom] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SeerviceCom] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SeerviceCom] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SeerviceCom] SET  MULTI_USER 
GO
ALTER DATABASE [SeerviceCom] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SeerviceCom] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SeerviceCom] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SeerviceCom] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SeerviceCom] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SeerviceCom] SET QUERY_STORE = OFF
GO
USE [SeerviceCom]
GO
/****** Object:  Table [dbo].[ApplicationUs]    Script Date: 20.05.2024 16:37:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationUs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ApplicationDateTime] [datetime] NOT NULL,
	[StatusID] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Comid] [int] NOT NULL,
	[DoneAplDateTime] [datetime] NULL,
	[Detailid] [int] NULL,
	[Worid] [int] NULL,
	[DateTimeWorker] [datetime] NULL,
 CONSTRAINT [PK_ApplicationUs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detail]    Script Date: 20.05.2024 16:37:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DetailName] [nvarchar](50) NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Detail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 20.05.2024 16:37:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 20.05.2024 16:37:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 20.05.2024 16:37:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Roleid] [int] NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ApplicationUs] ON 

INSERT [dbo].[ApplicationUs] ([id], [ApplicationDateTime], [StatusID], [Description], [Comid], [DoneAplDateTime], [Detailid], [Worid], [DateTimeWorker]) VALUES (1008, CAST(N'2024-05-15T15:23:48.447' AS DateTime), 3, N'Не включаеться пк', 1, CAST(N'2024-05-15T15:25:14.587' AS DateTime), 2, 4, CAST(N'2024-05-15T03:24:39.370' AS DateTime))
INSERT [dbo].[ApplicationUs] ([id], [ApplicationDateTime], [StatusID], [Description], [Comid], [DoneAplDateTime], [Detailid], [Worid], [DateTimeWorker]) VALUES (1010, CAST(N'2024-05-15T20:57:58.900' AS DateTime), 3, N'завис', 13, CAST(N'2024-05-15T21:02:55.320' AS DateTime), 8, 4, CAST(N'2024-05-15T09:02:27.223' AS DateTime))
INSERT [dbo].[ApplicationUs] ([id], [ApplicationDateTime], [StatusID], [Description], [Comid], [DoneAplDateTime], [Detailid], [Worid], [DateTimeWorker]) VALUES (1011, CAST(N'2024-05-16T14:24:06.207' AS DateTime), 3, N'Не включаеться комп', 3, CAST(N'2024-05-16T14:25:58.733' AS DateTime), 1, 4, CAST(N'2024-05-16T02:25:35.463' AS DateTime))
SET IDENTITY_INSERT [dbo].[ApplicationUs] OFF
GO
SET IDENTITY_INSERT [dbo].[Detail] ON 

INSERT [dbo].[Detail] ([id], [DetailName], [Quantity]) VALUES (1, N'Блок питания Aerocool mx200 500w', 10)
INSERT [dbo].[Detail] ([id], [DetailName], [Quantity]) VALUES (2, N'Оперативная память Samsung 4gb', 20)
INSERT [dbo].[Detail] ([id], [DetailName], [Quantity]) VALUES (3, N'Жесткий диск AppData 500 гб', 10)
INSERT [dbo].[Detail] ([id], [DetailName], [Quantity]) VALUES (4, N'Ssd диск samsung 500 гб', 10)
INSERT [dbo].[Detail] ([id], [DetailName], [Quantity]) VALUES (7, N'Процессор intel core i5', 10)
INSERT [dbo].[Detail] ([id], [DetailName], [Quantity]) VALUES (8, N'Видеокарта Nvidia gtx1050', 10)
SET IDENTITY_INSERT [dbo].[Detail] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([id], [Role]) VALUES (1, N'Admin')
INSERT [dbo].[Role] ([id], [Role]) VALUES (2, N'User')
INSERT [dbo].[Role] ([id], [Role]) VALUES (3, N'Worker')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([id], [Status]) VALUES (1, N'В обработке')
INSERT [dbo].[Status] ([id], [Status]) VALUES (3, N'Выполненна')
INSERT [dbo].[Status] ([id], [Status]) VALUES (4, N'Передано специалисту')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([id], [UserName], [Roleid], [Login], [Password]) VALUES (1, N'Денис', 1, N'1', N'1')
INSERT [dbo].[User] ([id], [UserName], [Roleid], [Login], [Password]) VALUES (2, N'Ирина Агутина', 2, N'2', N'2')
INSERT [dbo].[User] ([id], [UserName], [Roleid], [Login], [Password]) VALUES (4, N'Игорь Смирнов', 3, N'3', N'3')
INSERT [dbo].[User] ([id], [UserName], [Roleid], [Login], [Password]) VALUES (5, N'Олег Шишов', 3, N'5', N'5')
INSERT [dbo].[User] ([id], [UserName], [Roleid], [Login], [Password]) VALUES (6, N'Илья Иванов', 3, N'6', N'6')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[ApplicationUs]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationUs_Detail] FOREIGN KEY([Detailid])
REFERENCES [dbo].[Detail] ([id])
GO
ALTER TABLE [dbo].[ApplicationUs] CHECK CONSTRAINT [FK_ApplicationUs_Detail]
GO
ALTER TABLE [dbo].[ApplicationUs]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationUs_Status] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Status] ([id])
GO
ALTER TABLE [dbo].[ApplicationUs] CHECK CONSTRAINT [FK_ApplicationUs_Status]
GO
ALTER TABLE [dbo].[ApplicationUs]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationUs_User] FOREIGN KEY([Worid])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[ApplicationUs] CHECK CONSTRAINT [FK_ApplicationUs_User]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([Roleid])
REFERENCES [dbo].[Role] ([id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [SeerviceCom] SET  READ_WRITE 
GO
