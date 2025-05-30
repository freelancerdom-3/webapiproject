USE [MyDB]
GO
/****** Object:  Table [dbo].[TblServiceCartMappings]    Script Date: 30-05-2025 18:16:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblServiceCartMappings](
	[MappingId] [int] IDENTITY(1,1) NOT NULL,
	[ServicesId] [int] NULL,
	[CartId] [int] NULL,
	[Price] [decimal](10, 2) NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblServiceCartMappings] ON 
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServicesId], [CartId], [Price], [Quantity]) VALUES (1, 10134, 1, CAST(300.00 AS Decimal(10, 2)), 2)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServicesId], [CartId], [Price], [Quantity]) VALUES (2, 20123, 2, CAST(500.00 AS Decimal(10, 2)), 1)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServicesId], [CartId], [Price], [Quantity]) VALUES (3, 10567, 3, CAST(400.00 AS Decimal(10, 2)), 3)
GO
INSERT [dbo].[TblServiceCartMappings] ([MappingId], [ServicesId], [CartId], [Price], [Quantity]) VALUES (4, 10521, 4, CAST(1000.00 AS Decimal(10, 2)), 1)
GO
SET IDENTITY_INSERT [dbo].[TblServiceCartMappings] OFF
GO
