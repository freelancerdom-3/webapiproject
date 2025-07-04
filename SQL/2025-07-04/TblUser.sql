USE [MyDb]
GO
/****** Object:  Table [dbo].[TblUsers]    Script Date: 04-07-2025 05:28:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblUsers](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[MobileNumber] [varchar](20) NULL,
	[FullName] [varchar](100) NULL,
	[Email] [varchar](200) NULL,
	[Gender] [varchar](20) NULL,
	[DateOfBirth] [date] NULL,
	[UserTypeId] [int] NULL,
	[HouseNumber] [varchar](200) NULL,
	[Landmark] [varchar](200) NULL,
	[AriaName] [varchar](200) NULL,
	[LocationType] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblUsers] ON 
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId], [HouseNumber], [Landmark], [AriaName], [LocationType]) VALUES (1, N'1234567891', N'Chagan', N'chagan12@gmail.com', N'Male', CAST(N'2025-07-04' AS Date), 1, N'A222', N'eeee', N'tttt', N'HOME')
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId], [HouseNumber], [Landmark], [AriaName], [LocationType]) VALUES (2, N'789461231', N'Maagan', N'magan@mail.com', N'Male', CAST(N'2002-07-02' AS Date), 3, N'B-120', N'RK', N'Royal', N'HOME')
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId], [HouseNumber], [Landmark], [AriaName], [LocationType]) VALUES (3, N'1234567892', N'Jon', N'jon@mail.com', N'Male', CAST(N'2002-06-02' AS Date), 3, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId], [HouseNumber], [Landmark], [AriaName], [LocationType]) VALUES (4, N'1234567893', N'Rock', N'rock@mail.com', N'Male', CAST(N'2002-06-02' AS Date), 2, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId], [HouseNumber], [Landmark], [AriaName], [LocationType]) VALUES (5, N'1234567894', N'Natha', N'natha@mail.com', N'Male', CAST(N'2002-06-02' AS Date), 3, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId], [HouseNumber], [Landmark], [AriaName], [LocationType]) VALUES (6, N'1234567897', N'Chiman', N'chiman@mail.com', N'Male', CAST(N'2002-06-02' AS Date), 3, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId], [HouseNumber], [Landmark], [AriaName], [LocationType]) VALUES (7, N'1234567895', N'Girdhar', N'girdhar@mail.com', N'Male', CAST(N'2002-06-02' AS Date), 3, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId], [HouseNumber], [Landmark], [AriaName], [LocationType]) VALUES (8, N'123456789', N'MaxWell', N'maxy@mail.com', N'Male', CAST(N'2002-06-03' AS Date), 3, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId], [HouseNumber], [Landmark], [AriaName], [LocationType]) VALUES (9, N'1234567981', NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId], [HouseNumber], [Landmark], [AriaName], [LocationType]) VALUES (10, N'9876543211', N'Hemil Fichadia', N'hemil@mail.com', N'Male', CAST(N'2000-04-12' AS Date), 1, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId], [HouseNumber], [Landmark], [AriaName], [LocationType]) VALUES (11, N'1234567890', NULL, NULL, NULL, NULL, 2, N'B-120', N'CCC', N'VVV', N'HOME')
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId], [HouseNumber], [Landmark], [AriaName], [LocationType]) VALUES (12, N'1111111111', NULL, NULL, NULL, NULL, 2, N'D-404', N'Mall', N'Radhe', N'HOME')
GO
SET IDENTITY_INSERT [dbo].[TblUsers] OFF
GO
