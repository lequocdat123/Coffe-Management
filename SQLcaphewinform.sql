

USE [master]
GO
/****** Object:  Database [QLCafe]    Script Date: 8/1/2022 23:49:47 PM ******/
CREATE DATABASE [QLCafe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLCafe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TAOLADAT\MSSQL\DATA\QLCafe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLCafe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TAOLADAT\MSSQL\DATA\QLCafe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLCafe] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLCafe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLCafe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLCafe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLCafe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLCafe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLCafe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLCafe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLCafe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLCafe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLCafe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLCafe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLCafe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLCafe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLCafe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLCafe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLCafe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLCafe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLCafe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLCafe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLCafe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLCafe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLCafe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLCafe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLCafe] SET RECOVERY FULL 
GO
ALTER DATABASE [QLCafe] SET  MULTI_USER 
GO
ALTER DATABASE [QLCafe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLCafe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLCafe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLCafe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLCafe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLCafe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLCafe', N'ON'
GO
ALTER DATABASE [QLCafe] SET QUERY_STORE = OFF
GO
USE [QLCafe]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 8/1/2022 23:49:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[ID] [int] NOT NULL,
	[IDEmployee] [int] NOT NULL,
	[IDTable] [int] NOT NULL,
	[CheckIn] [varchar](50) NULL,
	[CheckOut] [varchar](50) NULL,
	[Status] [int] NOT NULL,
	[TotalPrice] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill_Detail]    Script Date: 8/1/2022 23:49:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill_Detail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDBill] [int] NOT NULL,
	[IDProduct] [int] NOT NULL,
	[Count] [int] NOT NULL,
	[TotalPrice] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 8/1/2022 23:49:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Dateofbirth] [varchar](50) NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 8/1/2022 23:49:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Type] [varchar](50) NULL,
	[Price] [bigint] NOT NULL,
	[Image] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SEAT]    Script Date: 8/1/2022 23:49:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEAT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Bill] ([ID], [IDEmployee], [IDTable], [CheckIn], [CheckOut], [Status], [TotalPrice]) VALUES (232659552, 1, 1, N'6/1/2022 22:14:09 PM', N'7/1/2022 12:13:05 PM', 1, 99000)
INSERT [dbo].[Bill] ([ID], [IDEmployee], [IDTable], [CheckIn], [CheckOut], [Status], [TotalPrice]) VALUES (551327215, 1, 2, N'6/1/2022 21:01:16 PM', N'6/1/2022 21:01:22 PM', 1, 99000)
INSERT [dbo].[Bill] ([ID], [IDEmployee], [IDTable], [CheckIn], [CheckOut], [Status], [TotalPrice]) VALUES (609009051, 1, 1, N'6/1/2022 21:01:10 PM', N'6/1/2022 21:01:10 PM', 1, 163000)
INSERT [dbo].[Bill] ([ID], [IDEmployee], [IDTable], [CheckIn], [CheckOut], [Status], [TotalPrice]) VALUES (764007491, 1, 2, N'6/1/2022 22:15:02 PM', N'7/1/2022 12:13:15 PM', 1, 99000)
INSERT [dbo].[Bill] ([ID], [IDEmployee], [IDTable], [CheckIn], [CheckOut], [Status], [TotalPrice]) VALUES (764562356, 1, 1, N'6/1/2022 21:00:54 PM', N'6/1/2022 21:01:01 PM', 1, 122000)
INSERT [dbo].[Bill] ([ID], [IDEmployee], [IDTable], [CheckIn], [CheckOut], [Status], [TotalPrice]) VALUES (949492222, 1, -1, N'6/1/2022 21:10:55 PM', N'6/1/2022 21:10:55 PM', 1, 109000)
INSERT [dbo].[Bill] ([ID], [IDEmployee], [IDTable], [CheckIn], [CheckOut], [Status], [TotalPrice]) VALUES (1308896906, 1, 1, N'7/1/2022 12:23:25 PM', N'', 0, 99000)
INSERT [dbo].[Bill] ([ID], [IDEmployee], [IDTable], [CheckIn], [CheckOut], [Status], [TotalPrice]) VALUES (1325499781, 1, 1, N'6/1/2022 21:25:52 PM', N'6/1/2022 21:26:27 PM', 1, 157000)
INSERT [dbo].[Bill] ([ID], [IDEmployee], [IDTable], [CheckIn], [CheckOut], [Status], [TotalPrice]) VALUES (1466298914, 1, 2, N'6/1/2022 20:38:16 PM', N'6/1/2022 20:42:14 PM', 1, 87000)
INSERT [dbo].[Bill] ([ID], [IDEmployee], [IDTable], [CheckIn], [CheckOut], [Status], [TotalPrice]) VALUES (1614298876, 1, -1, N'7/1/2022 21:46:38 PM', N'7/1/2022 21:46:38 PM', 1, 114000)
INSERT [dbo].[Bill] ([ID], [IDEmployee], [IDTable], [CheckIn], [CheckOut], [Status], [TotalPrice]) VALUES (1773146210, 1, 2, N'6/1/2022 21:26:37 PM', N'6/1/2022 22:14:35 PM', 1, 64000)
INSERT [dbo].[Bill] ([ID], [IDEmployee], [IDTable], [CheckIn], [CheckOut], [Status], [TotalPrice]) VALUES (1911000758, 1, 3, N'7/1/2022 21:47:08 PM', N'', 0, 109000)
GO
SET IDENTITY_INSERT [dbo].[Bill_Detail] ON 

INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (2, 1466298914, 1, 3, 87000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (3, 764562356, 1, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (4, 609009051, 1, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (5, 609009051, 2, 3, 105000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (6, 609009051, 3, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (7, 551327215, 1, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (8, 551327215, 2, 2, 70000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (9, 551327215, 3, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (10, 949492222, 1, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (11, 949492222, 2, 1, 35000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (12, 949492222, 24, 1, 45000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (16, 1325499781, 1, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (17, 1325499781, 2, 1, 35000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (18, 1325499781, 3, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (19, 1325499781, 1, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (20, 1325499781, 2, 1, 35000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (21, 1773146210, 5, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (22, 1773146210, 4, 1, 35000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (23, 232659552, 1, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (24, 232659552, 3, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (34, 764007491, 2, 1, 35000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (35, 764007491, 3, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (36, 764007491, 4, 1, 35000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (39, 1308896906, 3, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (40, 1308896906, 4, 1, 35000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (41, 1308896906, 2, 1, 35000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (42, 1614298876, 3, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (43, 1614298876, 4, 1, 35000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (44, 1614298876, 11, 1, 50000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (45, 1911000758, 3, 1, 29000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (46, 1911000758, 4, 1, 35000)
INSERT [dbo].[Bill_Detail] ([ID], [IDBill], [IDProduct], [Count], [TotalPrice]) VALUES (47, 1911000758, 14, 1, 45000)
SET IDENTITY_INSERT [dbo].[Bill_Detail] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([ID], [Name], [Dateofbirth], [Username], [Password]) VALUES (1, N'Le Quoc Dat', N'27/04/2000', N'a', N'12345')
INSERT [dbo].[Employee] ([ID], [Name], [Dateofbirth], [Username], [Password]) VALUES (2, N'Thai Ba Dung
', N'27/04/2000', N'b', N'12345')
INSERT [dbo].[Employee] ([ID], [Name], [Dateofbirth], [Username], [Password]) VALUES (3, N'Truong Trung Tin', N'27/04/2000', N'c', N'12345')
INSERT [dbo].[Employee] ([ID], [Name], [Dateofbirth], [Username], [Password]) VALUES (4, N'Nguyen Van D', N'27/04/2000', N'd', N'12345')
INSERT [dbo].[Employee] ([ID], [Name], [Dateofbirth], [Username], [Password]) VALUES (5, N'Nguyen Van E', N'27/04/2000', N'e', N'12345')
INSERT [dbo].[Employee] ([ID], [Name], [Dateofbirth], [Username], [Password]) VALUES (6, N'Nguyen Van F', N'27/04/2000', N'f', N'12345')
INSERT [dbo].[Employee] ([ID], [Name], [Dateofbirth], [Username], [Password]) VALUES (7, N'Nguyen Van G', N'27/04/2000', N'g', N'12345')
INSERT [dbo].[Employee] ([ID], [Name], [Dateofbirth], [Username], [Password]) VALUES (8, N'Nguyen Van H', N'27/04/2000', N'h', N'12345')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (1, N'B?c S?u Ðá', N'Cafe', 29000, N'../../Resources/Images/product-0.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (2, N'B?c S?u Nóng', N'Cafe', 35000, N'../../Resources/Images/product-1.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (3, N'Cà Phê Ðen Ðá', N'Cafe', 29000, N'../../Resources/Images/product-2.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (4, N'Cà Phê Ðen Nóng', N'Cafe', 35000, N'../../Resources/Images/product-3.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (5, N'Cà Phê S?a Ðá', N'Cafe', 29000, N'../../Resources/Images/product-4.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (6, N'Cà Phê S?a Ðá Chai Fresh 250ml', N'Cafe', 79000, N'../../Resources/Images/product-5.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (7, N'Cà phê S?a Nóng', N'Cafe', 35000, N'../../Resources/Images/product-6.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (8, N'Latte Táo Lê Qu? Nóng', N'Cafe', 59000, N'../../Resources/Images/product-7.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (9, N'Latte Táo Lê Qu? Ðá', N'Cafe', 59000, N'../../Resources/Images/product-8.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (10, N'Latte Táo Lê Qu? Chai Fresh 500ml', N'Cafe', 109000, N'../../Resources/Images/product-9.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (11, N'Mocha Nóng', N'Cafe', 50000, N'../../Resources/Images/product-10.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (12, N'Mocha Ðá', N'Cafe', 50000, N'../../Resources/Images/product-11.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (13, N'Espresso Nóng', N'Cafe', 40000, N'../../Resources/Images/product-12.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (14, N'Espresso Ðá', N'Cafe', 45000, N'../../Resources/Images/product-13.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (15, N'Cappuccino Nóng', N'Cafe', 50000, N'../../Resources/Images/product-14.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (16, N'Cappuccino Ðá', N'Cafe', 50000, N'../../Resources/Images/product-15.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (17, N'Americano Nóng', N'Cafe', 40000, N'../../Resources/Images/product-6.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (18, N'Latte Ðá', N'Cafe', 50000, N'../../Resources/Images/product-17.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (19, N'Caramel Macchiato Nóng', N'Cafe', 50000, N'../../Resources/Images/product-18.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (20, N'Caramel Macchiato Ðá', N'Cafe', 50000, N'../../Resources/Images/product-19.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (21, N'Latte Nóng', N'Cafe', 40000, N'../../Resources/Images/product-20.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (22, N'Americano Ðá', N'Cafe', 40000, N'../../Resources/Images/product-21.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (23, N'Cold Brew Phúc B?n T?', N'Cafe', 50000, N'../../Resources/Images/product-22.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (24, N'Cold Brew S?a Tuoi', N'Cafe', 45000, N'../../Resources/Images/product-23.png')
INSERT [dbo].[Product] ([ID], [Name], [Type], [Price], [Image]) VALUES (25, N'Cold Brew Truy?n Th?ng', N'Cafe', 45000, N'../../Resources/Images/product-24.png')
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[SEAT] ON 

INSERT [dbo].[SEAT] ([ID], [Status]) VALUES (1, 1)
INSERT [dbo].[SEAT] ([ID], [Status]) VALUES (2, 0)
INSERT [dbo].[SEAT] ([ID], [Status]) VALUES (3, 1)
INSERT [dbo].[SEAT] ([ID], [Status]) VALUES (7, 0)
INSERT [dbo].[SEAT] ([ID], [Status]) VALUES (8, 1)
SET IDENTITY_INSERT [dbo].[SEAT] OFF
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[SEAT] ADD  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Employee] FOREIGN KEY([IDEmployee])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Employee]
GO
ALTER TABLE [dbo].[Bill_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Detail_Bill] FOREIGN KEY([IDBill])
REFERENCES [dbo].[Bill] ([ID])
GO
ALTER TABLE [dbo].[Bill_Detail] CHECK CONSTRAINT [FK_Bill_Detail_Bill]
GO
ALTER TABLE [dbo].[Bill_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Detail_Product] FOREIGN KEY([IDProduct])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[Bill_Detail] CHECK CONSTRAINT [FK_Bill_Detail_Product]
GO
USE [master]
GO
ALTER DATABASE [QLCafe] SET  READ_WRITE 
GO
