USE [MyDb]
GO
/****** Object:  Table [dbo].[TblUsers]    Script Date: 04-06-2025 07:44:36 PM ******/
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
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblUsers] ON 
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId]) VALUES (1, N'1234567891', N'Chhagan', N'chhagan@mail.com', N'Male', CAST(N'2002-06-02' AS Date), 1)
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId]) VALUES (2, N'789461231', N'Maagan', N'magan@mail.com', N'Male', CAST(N'2002-07-02' AS Date), 3)
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId]) VALUES (3, N'1234567892', N'Jhon', N'jhon@mail.com', N'Male', CAST(N'2002-06-02' AS Date), 2)
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId]) VALUES (4, N'1234567893', N'Rock', N'rock@mail.com', N'Male', CAST(N'2002-06-02' AS Date), 2)
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId]) VALUES (5, N'1234567894', N'Natha', N'natha@mail.com', N'Male', CAST(N'2002-06-02' AS Date), 3)
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId]) VALUES (6, N'1234567897', N'Chiman', N'chiman@mail.com', N'Male', CAST(N'2002-06-02' AS Date), 3)
GO
INSERT [dbo].[TblUsers] ([UserId], [MobileNumber], [FullName], [Email], [Gender], [DateOfBirth], [UserTypeId]) VALUES (7, N'1234567895', N'Girdhar', N'girdhar@mail.com', N'Male', CAST(N'2002-06-02' AS Date), 3)
GO
SET IDENTITY_INSERT [dbo].[TblUsers] OFF
GO
