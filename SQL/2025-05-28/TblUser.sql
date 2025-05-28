USE [MyDB]
GO
/****** Object:  Table [dbo].[TblUsers]    Script Date: 28-05-2025 11:39:10 ******/
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
SET IDENTITY_INSERT [dbo].[TblUsers] ON 
GO
INSERT [dbo].[TblUsers] ([UserId], [FullName], [Email], [Gender], [DOB]) VALUES (1, N'test', N'test@gmail.com', N'M', CAST(N'2000-01-15T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TblUsers] ([UserId], [FullName], [Email], [Gender], [DOB]) VALUES (2, N'XYZ', N'ABC@gmail.com', N'F', CAST(N'1975-05-27T05:44:15.730' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[TblUsers] OFF
GO
