USE [MyDb]
GO
/****** Object:  Table [dbo].[TblServiceAreaMappings]    Script Date: 29-05-2025 10.32.39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblServiceAreaMappings](
	[MappingId] [int] IDENTITY(1,1) NOT NULL,
	[ServiceId] [int] NULL,
	[AreaId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblServiceAreaMappings] ON 
GO
INSERT [dbo].[TblServiceAreaMappings] ([MappingId], [ServiceId], [AreaId]) VALUES (1, 1, 1)
GO
INSERT [dbo].[TblServiceAreaMappings] ([MappingId], [ServiceId], [AreaId]) VALUES (2, 1, 2)
GO
INSERT [dbo].[TblServiceAreaMappings] ([MappingId], [ServiceId], [AreaId]) VALUES (3, 1, 3)
GO
SET IDENTITY_INSERT [dbo].[TblServiceAreaMappings] OFF
GO
