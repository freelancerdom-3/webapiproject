USE [MyDb]
GO
/****** Object:  Table [dbo].[TblOrders]    Script Date: 24-07-2025 07:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOrders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[EndUserID] [int] NULL,
	[Date] [date] NULL,
	[Time] [varchar](50) NULL,
	[SubCategoryID] [int] NULL,
	[ServiceProviderID] [int] NULL,
	[ItemTotal] [decimal](10, 2) NULL,
	[PlatformFee] [decimal](10, 2) NULL,
	[SubTotal] [decimal](10, 2) NULL,
	[OrderStatusId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblOrderServiceMapping]    Script Date: 24-07-2025 07:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOrderServiceMapping](
	[MappingID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[ServiceId] [int] NULL,
	[ServiceName] [varchar](100) NULL,
	[Price] [decimal](10, 2) NULL,
	[Quantity] [int] NULL,
	[ServiceOrderStatusID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MappingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblOrderStatus]    Script Date: 24-07-2025 07:23:39 PM ******/
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
/****** Object:  Table [dbo].[TblServiceOrderStatus]    Script Date: 24-07-2025 07:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblServiceOrderStatus](
	[ServiceOrderStatus] [int] IDENTITY(1,1) NOT NULL,
	[ServiceOrderStatusName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ServiceOrderStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblOrders] ON 
GO
INSERT [dbo].[TblOrders] ([OrderID], [EndUserID], [Date], [Time], [SubCategoryID], [ServiceProviderID], [ItemTotal], [PlatformFee], [SubTotal], [OrderStatusId]) VALUES (1, 1, CAST(N'2025-07-25' AS Date), N'10:30 AM', 2, NULL, CAST(1680.00 AS Decimal(10, 2)), CAST(84.00 AS Decimal(10, 2)), CAST(1764.00 AS Decimal(10, 2)), 1)
GO
SET IDENTITY_INSERT [dbo].[TblOrders] OFF
GO
SET IDENTITY_INSERT [dbo].[TblOrderServiceMapping] ON 
GO
INSERT [dbo].[TblOrderServiceMapping] ([MappingID], [OrderID], [ServiceId], [ServiceName], [Price], [Quantity], [ServiceOrderStatusID]) VALUES (1, 1, 10, N'Switchbox installation', CAST(350.00 AS Decimal(10, 2)), 1, 1)
GO
INSERT [dbo].[TblOrderServiceMapping] ([MappingID], [OrderID], [ServiceId], [ServiceName], [Price], [Quantity], [ServiceOrderStatusID]) VALUES (2, 1, 11, N'AC Switchbox installation', CAST(370.00 AS Decimal(10, 2)), 1, 1)
GO
INSERT [dbo].[TblOrderServiceMapping] ([MappingID], [OrderID], [ServiceId], [ServiceName], [Price], [Quantity], [ServiceOrderStatusID]) VALUES (3, 1, 12, N'Switchboard installation', CAST(280.00 AS Decimal(10, 2)), 2, 1)
GO
INSERT [dbo].[TblOrderServiceMapping] ([MappingID], [OrderID], [ServiceId], [ServiceName], [Price], [Quantity], [ServiceOrderStatusID]) VALUES (4, 1, 15, N'Wi-Fi smart switch installation', CAST(200.00 AS Decimal(10, 2)), 2, 1)
GO
SET IDENTITY_INSERT [dbo].[TblOrderServiceMapping] OFF
GO
SET IDENTITY_INSERT [dbo].[TblOrderStatus] ON 
GO
INSERT [dbo].[TblOrderStatus] ([OrderStatusID], [OrderStatusName]) VALUES (1, N'UPCOMING')
GO
INSERT [dbo].[TblOrderStatus] ([OrderStatusID], [OrderStatusName]) VALUES (2, N'IN-PROGRESS')
GO
INSERT [dbo].[TblOrderStatus] ([OrderStatusID], [OrderStatusName]) VALUES (3, N'COMPLETED')
GO
SET IDENTITY_INSERT [dbo].[TblOrderStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[TblServiceOrderStatus] ON 
GO
INSERT [dbo].[TblServiceOrderStatus] ([ServiceOrderStatus], [ServiceOrderStatusName]) VALUES (1, N'PENDING')
GO
INSERT [dbo].[TblServiceOrderStatus] ([ServiceOrderStatus], [ServiceOrderStatusName]) VALUES (2, N'COMPLETED')
GO
SET IDENTITY_INSERT [dbo].[TblServiceOrderStatus] OFF
GO
