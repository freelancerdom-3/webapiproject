USE [MyDb]
GO
/****** Object:  Table [dbo].[TblCarts]    Script Date: 29-05-2025 7.04.54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCarts](
	[CartId] [int] IDENTITY(1,1) NOT NULL,
	[Price] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[CartId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblCategorys]    Script Date: 29-05-2025 7.04.54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCategorys](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblOffers]    Script Date: 29-05-2025 7.04.54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOffers](
	[OfferId] [int] IDENTITY(1,1) NOT NULL,
	[ServiceId] [int] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Discount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OfferId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblServiceAreaMappings]    Script Date: 29-05-2025 7.04.54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblServiceAreaMappings](
	[MappingId] [int] IDENTITY(1,1) NOT NULL,
	[ServiceId] [int] NULL,
	[AreaId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblServiceCartMappings]    Script Date: 29-05-2025 7.04.54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblServiceCartMappings](
	[MappingId] [int] IDENTITY(1,1) NOT NULL,
	[ServicesId] [int] NULL,
	[CartId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblServices]    Script Date: 29-05-2025 7.04.54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblServices](
	[ServiceId] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [varchar](50) NULL,
	[SubCategoryId] [int] NULL,
	[Price] [decimal](10, 2) NULL,
	[TimeTaken] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSubCategorys]    Script Date: 29-05-2025 7.04.54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSubCategorys](
	[SubCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[SubCategoryName] [varchar](50) NULL,
	[CategoryId] [int] NULL,
	[SubCategoreId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SubCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblUserCartMappings]    Script Date: 29-05-2025 7.04.54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblUserCartMappings](
	[MappingId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[CartId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblUsers]    Script Date: 29-05-2025 7.04.54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblUsers](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](200) NULL,
	[Email] [varchar](200) NULL,
	[Gender] [varchar](10) NULL,
	[DOB] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblCarts] ON 
GO
INSERT [dbo].[TblCarts] ([CartId], [Price]) VALUES (1, CAST(200.50 AS Decimal(10, 2)))
GO
INSERT [dbo].[TblCarts] ([CartId], [Price]) VALUES (2, CAST(1000.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[TblCarts] ([CartId], [Price]) VALUES (3, CAST(500.00 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[TblCarts] OFF
GO
SET IDENTITY_INSERT [dbo].[TblCategorys] ON 
GO
INSERT [dbo].[TblCategorys] ([CategoryId], [CategoryName]) VALUES (1, N'home')
GO
INSERT [dbo].[TblCategorys] ([CategoryId], [CategoryName]) VALUES (2, N'beauty')
GO
INSERT [dbo].[TblCategorys] ([CategoryId], [CategoryName]) VALUES (3, N'native')
GO
SET IDENTITY_INSERT [dbo].[TblCategorys] OFF
GO
SET IDENTITY_INSERT [dbo].[TblOffers] ON 
GO
INSERT [dbo].[TblOffers] ([OfferId], [ServiceId], [StartDate], [EndDate], [Discount]) VALUES (1, 1, CAST(N'2025-05-01T09:00:00.000' AS DateTime), CAST(N'2025-05-15T23:59:59.000' AS DateTime), 10)
GO
INSERT [dbo].[TblOffers] ([OfferId], [ServiceId], [StartDate], [EndDate], [Discount]) VALUES (2, 2, CAST(N'2025-05-10T00:00:00.000' AS DateTime), CAST(N'2025-06-10T23:59:59.000' AS DateTime), 15)
GO
INSERT [dbo].[TblOffers] ([OfferId], [ServiceId], [StartDate], [EndDate], [Discount]) VALUES (3, 3, CAST(N'2025-06-01T08:00:00.000' AS DateTime), CAST(N'2025-06-30T22:00:00.000' AS DateTime), 20)
GO
INSERT [dbo].[TblOffers] ([OfferId], [ServiceId], [StartDate], [EndDate], [Discount]) VALUES (4, 3, CAST(N'2025-05-29T13:29:59.477' AS DateTime), CAST(N'2025-09-29T13:29:59.477' AS DateTime), 25)
GO
INSERT [dbo].[TblOffers] ([OfferId], [ServiceId], [StartDate], [EndDate], [Discount]) VALUES (6, 5, CAST(N'2025-05-29T13:30:45.080' AS DateTime), CAST(N'2025-06-29T13:30:45.080' AS DateTime), 30)
GO
SET IDENTITY_INSERT [dbo].[TblOffers] OFF
GO
SET IDENTITY_INSERT [dbo].[TblServiceAreaMappings] ON 
GO
INSERT [dbo].[TblServiceAreaMappings] ([MappingId], [ServiceId], [AreaId]) VALUES (1, 1, 1)
GO
INSERT [dbo].[TblServiceAreaMappings] ([MappingId], [ServiceId], [AreaId]) VALUES (2, 1, 2)
GO
INSERT [dbo].[TblServiceAreaMappings] ([MappingId], [ServiceId], [AreaId]) VALUES (3, 1, 3)
GO
INSERT [dbo].[TblServiceAreaMappings] ([MappingId], [ServiceId], [AreaId]) VALUES (5, 3, 2)
GO
SET IDENTITY_INSERT [dbo].[TblServiceAreaMappings] OFF
GO
SET IDENTITY_INSERT [dbo].[TblServiceCartMappings] ON 
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServicesId], [CartId]) VALUES (1, 10134, 1)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServicesId], [CartId]) VALUES (2, 20123, 2)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServicesId], [CartId]) VALUES (3, 1000, 5)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServicesId], [CartId]) VALUES (4, 2309, 4)
GO
SET IDENTITY_INSERT [dbo].[TblServiceCartMappings] OFF
GO
SET IDENTITY_INSERT [dbo].[TblServices] ON 
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken]) VALUES (1, N'Basin installation', 5, CAST(300.00 AS Decimal(10, 2)), N'60 minutes')
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken]) VALUES (2, N'Basin relacement', 5, CAST(500.00 AS Decimal(10, 2)), N'80 minutes')
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken]) VALUES (3, N'fan replaceement', 6, CAST(250.00 AS Decimal(10, 2)), N'30 minutes')
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken]) VALUES (4, N'fan installation', 6, CAST(200.00 AS Decimal(10, 2)), N'20 minutes')
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken]) VALUES (5, N'pain relief', 7, CAST(800.00 AS Decimal(10, 2)), N'60 minutes')
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken]) VALUES (7, N'premium signature therapy', 9, CAST(1500.00 AS Decimal(10, 2)), N'70 minutes')
GO
SET IDENTITY_INSERT [dbo].[TblServices] OFF
GO
SET IDENTITY_INSERT [dbo].[TblSubCategorys] ON 
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoreId]) VALUES (1, N'plumber', 1, NULL)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoreId]) VALUES (2, N'electrician', 1, NULL)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoreId]) VALUES (3, N'spa', 2, NULL)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoreId]) VALUES (4, N'massage', 2, NULL)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoreId]) VALUES (5, N'Basin & sink', NULL, 1)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoreId]) VALUES (6, N'fan', NULL, 2)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoreId]) VALUES (7, N'prime', NULL, 3)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoreId]) VALUES (9, N'royel', NULL, 4)
GO
SET IDENTITY_INSERT [dbo].[TblSubCategorys] OFF
GO
SET IDENTITY_INSERT [dbo].[TblUserCartMappings] ON 
GO
INSERT [dbo].[TblUserCartMappings] ([MappingId], [UserId], [CartId]) VALUES (1, 1, 5)
GO
INSERT [dbo].[TblUserCartMappings] ([MappingId], [UserId], [CartId]) VALUES (2, 2, 6)
GO
INSERT [dbo].[TblUserCartMappings] ([MappingId], [UserId], [CartId]) VALUES (3, 3, 7)
GO
SET IDENTITY_INSERT [dbo].[TblUserCartMappings] OFF
GO
SET IDENTITY_INSERT [dbo].[TblUsers] ON 
GO
INSERT [dbo].[TblUsers] ([UserId], [FullName], [Email], [Gender], [DOB]) VALUES (1, N'test', N'test@gmail.com', N'M', CAST(N'2000-01-15T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TblUsers] ([UserId], [FullName], [Email], [Gender], [DOB]) VALUES (2, N'XYZ', N'ABC@gmail.com', N'F', CAST(N'1975-05-27T05:44:15.730' AS DateTime))
GO
INSERT [dbo].[TblUsers] ([UserId], [FullName], [Email], [Gender], [DOB]) VALUES (3, N'Sardar-vallabhbhai-patel', N'sardarpatel@swaraaj.com', N'Male', CAST(N'1956-05-25T05:12:20.143' AS DateTime))
GO
INSERT [dbo].[TblUsers] ([UserId], [FullName], [Email], [Gender], [DOB]) VALUES (5, N'Gami-Alpesh', N'gamialpesh001@mail.com', N'Male', CAST(N'2003-05-29T06:23:36.013' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[TblUsers] OFF
GO
