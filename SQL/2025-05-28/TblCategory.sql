USE [MyDb]
GO
/****** Object:  Table [dbo].[TblCategorys]    Script Date: 28-05-2025 14:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCategorys](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblCategorys] ON 
GO
INSERT [dbo].[TblCategorys] ([CategoryId], [CategoryName]) VALUES (1, N'home')
GO
INSERT [dbo].[TblCategorys] ([CategoryId], [CategoryName]) VALUES (2, N'beauty')
GO
INSERT [dbo].[TblCategorys] ([CategoryId], [CategoryName]) VALUES (3, N'native')
GO
SET IDENTITY_INSERT [dbo].[TblCategorys] OFF
GO
