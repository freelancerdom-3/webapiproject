USE [MyDb]
GO
/****** Object:  Table [dbo].[TblServiceProviderAreaMapping]    Script Date: 03-06-2025 14:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblServiceProviderAreaMapping](
	[MappingId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[AreaId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblServiceProviderSubCategoryMapping]    Script Date: 03-06-2025 14:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblServiceProviderSubCategoryMapping](
	[MappingId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[SubCategoryId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblUsers]    Script Date: 03-06-2025 14:55:11 ******/
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
	[UserTypeId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblUserTypes]    Script Date: 03-06-2025 14:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblUserTypes](
	[UserTypeId] [int] NOT NULL,
	[UserTypeName] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblServiceProviderAreaMapping] ON 
GO
INSERT [dbo].[TblServiceProviderAreaMapping] ([MappingId], [UserId], [AreaId]) VALUES (1, 3, 1)
GO
INSERT [dbo].[TblServiceProviderAreaMapping] ([MappingId], [UserId], [AreaId]) VALUES (2, 3, 2)
GO
INSERT [dbo].[TblServiceProviderAreaMapping] ([MappingId], [UserId], [AreaId]) VALUES (3, 8, 1)
GO
SET IDENTITY_INSERT [dbo].[TblServiceProviderAreaMapping] OFF
GO
SET IDENTITY_INSERT [dbo].[TblServiceProviderSubCategoryMapping] ON 
GO
INSERT [dbo].[TblServiceProviderSubCategoryMapping] ([MappingId], [UserId], [SubCategoryId]) VALUES (1, 3, 1)
GO
INSERT [dbo].[TblServiceProviderSubCategoryMapping] ([MappingId], [UserId], [SubCategoryId]) VALUES (2, 3, 2)
GO
INSERT [dbo].[TblServiceProviderSubCategoryMapping] ([MappingId], [UserId], [SubCategoryId]) VALUES (3, 8, 3)
GO
SET IDENTITY_INSERT [dbo].[TblServiceProviderSubCategoryMapping] OFF
GO
SET IDENTITY_INSERT [dbo].[TblUsers] ON 
GO
INSERT [dbo].[TblUsers] ([UserId], [FullName], [Email], [Gender], [DOB], [UserTypeId]) VALUES (1, N'test', N'test@gmail.com', N'M', CAST(N'2000-01-15T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[TblUsers] ([UserId], [FullName], [Email], [Gender], [DOB], [UserTypeId]) VALUES (2, N'XYZ', N'ABC@gmail.com', N'F', CAST(N'1975-05-27T05:44:15.730' AS DateTime), 2)
GO
INSERT [dbo].[TblUsers] ([UserId], [FullName], [Email], [Gender], [DOB], [UserTypeId]) VALUES (3, N'Sardar-vallabhbhai-patel', N'sardarpatel@swaraaj.com', N'Male', CAST(N'1956-05-25T05:12:20.143' AS DateTime), 3)
GO
INSERT [dbo].[TblUsers] ([UserId], [FullName], [Email], [Gender], [DOB], [UserTypeId]) VALUES (5, N'Gami-Alpesh', N'gamialpesh001@mail.com', N'Male', CAST(N'2003-05-29T06:23:36.013' AS DateTime), 2)
GO
INSERT [dbo].[TblUsers] ([UserId], [FullName], [Email], [Gender], [DOB], [UserTypeId]) VALUES (6, N'admin', N'admin@gmail.com', N'Male', CAST(N'2000-01-01T09:11:00.230' AS DateTime), 1)
GO
INSERT [dbo].[TblUsers] ([UserId], [FullName], [Email], [Gender], [DOB], [UserTypeId]) VALUES (7, N'end user', N'user@gmail.com', N'M', CAST(N'2025-06-03T09:10:40.353' AS DateTime), 2)
GO
INSERT [dbo].[TblUsers] ([UserId], [FullName], [Email], [Gender], [DOB], [UserTypeId]) VALUES (8, N'service provider', N'serviceprovider@gmail.com', N'M', CAST(N'2025-06-03T09:10:40.353' AS DateTime), 3)
GO
SET IDENTITY_INSERT [dbo].[TblUsers] OFF
GO
INSERT [dbo].[TblUserTypes] ([UserTypeId], [UserTypeName]) VALUES (1, N'Admin')
GO
INSERT [dbo].[TblUserTypes] ([UserTypeId], [UserTypeName]) VALUES (2, N'End User')
GO
INSERT [dbo].[TblUserTypes] ([UserTypeId], [UserTypeName]) VALUES (3, N'Service Provider')
GO
ALTER TABLE [dbo].[TblUsers] ADD  DEFAULT ((2)) FOR [UserTypeId]
GO
