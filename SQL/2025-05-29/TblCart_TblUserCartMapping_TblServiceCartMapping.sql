USE [MyDB]
GO
/****** Object:  Table [dbo].[TblCarts]    Script Date: 29-05-2025 14:49:04 ******/
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
/****** Object:  Table [dbo].[TblServiceCartMappings]    Script Date: 29-05-2025 14:49:04 ******/
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
/****** Object:  Table [dbo].[TblUserCartMappings]    Script Date: 29-05-2025 14:49:04 ******/
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
