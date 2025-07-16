USE [MyDb]
GO
/****** Object:  Table [dbo].[TblBookings]    Script Date: 16-07-2025 01:55:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblBookings](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[EndUserID] [int] NULL,
	[Date] [date] NULL,
	[Time] [time](7) NULL,
	[SubCategoryID] [int] NULL,
	[ServiceProviderID] [int] NULL,
	[ItemTotal] [decimal](10, 2) NULL,
	[PlatformFee] [decimal](10, 2) NULL,
	[SubTotal] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblCarts]    Script Date: 16-07-2025 01:55:27 PM ******/
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
/****** Object:  Table [dbo].[TblOrderIDS]    Script Date: 16-07-2025 01:55:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOrderIDS](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblOrderServiceMapping]    Script Date: 16-07-2025 01:55:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOrderServiceMapping](
	[MappingID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[ServiceId] [int] NULL,
	[ServiceName] [varchar](100) NULL,
	[Price] [int] NULL,
	[Quantity] [int] NULL,
	[OrderStatusID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MappingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblOrderStatus]    Script Date: 16-07-2025 01:55:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOrderStatus](
	[OrderStatusID] [int] IDENTITY(1,1) NOT NULL,
	[OrderStatusName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblServiceCartMappings]    Script Date: 16-07-2025 01:55:27 PM ******/
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
INSERT [dbo].[TblCarts] ([CartId], [Price]) VALUES (1, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[TblCarts] ([CartId], [Price]) VALUES (2, CAST(0.00 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[TblCarts] OFF
GO
SET IDENTITY_INSERT [dbo].[TblOrderIDS] ON 
GO
INSERT [dbo].[TblOrderIDS] ([OrderID]) VALUES (1)
GO
SET IDENTITY_INSERT [dbo].[TblOrderIDS] OFF
GO
SET IDENTITY_INSERT [dbo].[TblOrderServiceMapping] ON 
GO
INSERT [dbo].[TblOrderServiceMapping] ([MappingID], [OrderID], [ServiceId], [ServiceName], [Price], [Quantity], [OrderStatusID]) VALUES (1, 1, 5, N'Foam-jet Service (2AC s)', 1000, 3, 0)
GO
INSERT [dbo].[TblOrderServiceMapping] ([MappingID], [OrderID], [ServiceId], [ServiceName], [Price], [Quantity], [OrderStatusID]) VALUES (2, 1, 7, N'Foam-jet Service (3AC s)', 1500, 4, 0)
GO
SET IDENTITY_INSERT [dbo].[TblOrderServiceMapping] OFF
GO
SET IDENTITY_INSERT [dbo].[TblOrderStatus] ON 
GO
INSERT [dbo].[TblOrderStatus] ([OrderStatusID], [OrderStatusName]) VALUES (1, N'PENDING')
GO
INSERT [dbo].[TblOrderStatus] ([OrderStatusID], [OrderStatusName]) VALUES (2, N'COMPLETED')
GO
SET IDENTITY_INSERT [dbo].[TblOrderStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[TblServiceCartMappings] ON 
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (1, 5, 2, CAST(1000.00 AS Decimal(10, 2)), 3)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (2, 7, 2, CAST(1500.00 AS Decimal(10, 2)), 4)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (3, 10, 2, CAST(350.00 AS Decimal(10, 2)), 1)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (4, 11, 2, CAST(370.00 AS Decimal(10, 2)), 2)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (5, 12, 2, CAST(280.00 AS Decimal(10, 2)), 2)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (6, 15, 2, CAST(200.00 AS Decimal(10, 2)), 1)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (7, 2, 2, CAST(140.00 AS Decimal(10, 2)), 2)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (8, 25, 2, CAST(150.00 AS Decimal(10, 2)), 1)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (9, 26, 2, CAST(210.00 AS Decimal(10, 2)), 2)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServiceId], [CartId], [Price], [Quantity]) VALUES (10, 27, 2, CAST(160.00 AS Decimal(10, 2)), 1)
GO
SET IDENTITY_INSERT [dbo].[TblServiceCartMappings] OFF
GO
