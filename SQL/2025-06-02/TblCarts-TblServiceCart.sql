USE [MyDb]
GO
/****** Object:  Table [dbo].[TblCarts]    Script Date: 02-06-2025 12:22:18 PM ******/
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
/****** Object:  Table [dbo].[TblServiceCartMappings]    Script Date: 02-06-2025 12:22:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblServiceCartMappings](
	[MappingId] [int] IDENTITY(1,1) NOT NULL,
	[ServiceId] [int] NULL,
	[CartId] [int] NULL,
	[Price] [decimal](10, 2) NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblCarts] ON 
GO
INSERT [dbo].[TblCarts] ([CartId], [Price]) VALUES (1, CAST(1600.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[TblCarts] ([CartId], [Price]) VALUES (2, CAST(1000.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[TblCarts] ([CartId], [Price]) VALUES (3, CAST(2400.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[TblCarts] ([CartId], [Price]) VALUES (4, CAST(1000.00 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[TblCarts] OFF
GO
SET IDENTITY_INSERT [dbo].[TblServiceCartMappings] ON 
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (1, 1, 1, CAST(300.00 AS Decimal(10, 2)), 2)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (2, 1, 2, CAST(500.00 AS Decimal(10, 2)), 1)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (3, 1, 3, CAST(400.00 AS Decimal(10, 2)), 2)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (4, 1, 4, CAST(1000.00 AS Decimal(10, 2)), 1)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (5, 2, 1, CAST(500.00 AS Decimal(10, 2)), 2)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (7, 2, 2, CAST(500.00 AS Decimal(10, 2)), 1)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (9, 5, 3, CAST(800.00 AS Decimal(10, 2)), 2)
GO
SET IDENTITY_INSERT [dbo].[TblServiceCartMappings] OFF
GO
