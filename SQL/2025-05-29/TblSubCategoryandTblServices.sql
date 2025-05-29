USE [MyDb]
GO
/****** Object:  Table [dbo].[TblServices]    Script Date: 29-05-2025 12:56:58 ******/
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
/****** Object:  Table [dbo].[TblSubCategorys]    Script Date: 29-05-2025 12:56:58 ******/
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
