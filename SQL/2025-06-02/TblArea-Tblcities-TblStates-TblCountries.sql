USE [MyDb]
GO
/****** Object:  Table [dbo].[TblAreas]    Script Date: 02-06-2025 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblAreas](
	[AreaId] [int] IDENTITY(1,1) NOT NULL,
	[AreaName] [varchar](100) NULL,
	[CityId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AreaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblCities]    Script Date: 02-06-2025 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCities](
	[CityId] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [varchar](100) NULL,
	[StateId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblCountries]    Script Date: 02-06-2025 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCountries](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblStates]    Script Date: 02-06-2025 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblStates](
	[StateId] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [varchar](100) NULL,
	[CountryId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[StateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblAreas] ON 
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (1, N'Gota', 1)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (2, N'Navrangpura', 1)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (3, N'Naranpura', 1)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (4, N'Kalupur', 1)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (5, N'Sola', 1)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (6, N'Satellite', 1)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (7, N'Bopal', 1)
GO
SET IDENTITY_INSERT [dbo].[TblAreas] OFF
GO
SET IDENTITY_INSERT [dbo].[TblCities] ON 
GO
INSERT [dbo].[TblCities] ([CityId], [CityName], [StateId]) VALUES (1, N'Ahmedabad', 1)
GO
INSERT [dbo].[TblCities] ([CityId], [CityName], [StateId]) VALUES (2, N'Vadodara', 1)
GO
INSERT [dbo].[TblCities] ([CityId], [CityName], [StateId]) VALUES (3, N'Surat', 1)
GO
INSERT [dbo].[TblCities] ([CityId], [CityName], [StateId]) VALUES (4, N'Rajkot', 1)
GO
INSERT [dbo].[TblCities] ([CityId], [CityName], [StateId]) VALUES (5, N'Jamnagar', 1)
GO
SET IDENTITY_INSERT [dbo].[TblCities] OFF
GO
SET IDENTITY_INSERT [dbo].[TblCountries] ON 
GO
INSERT [dbo].[TblCountries] ([CountryId], [CountryName]) VALUES (1, N'India')
GO
INSERT [dbo].[TblCountries] ([CountryId], [CountryName]) VALUES (2, N'USA')
GO
INSERT [dbo].[TblCountries] ([CountryId], [CountryName]) VALUES (3, N'South-Africa')
GO
INSERT [dbo].[TblCountries] ([CountryId], [CountryName]) VALUES (4, N'Bhutan')
GO
SET IDENTITY_INSERT [dbo].[TblCountries] OFF
GO
SET IDENTITY_INSERT [dbo].[TblStates] ON 
GO
INSERT [dbo].[TblStates] ([StateId], [StateName], [CountryId]) VALUES (1, N'Gujarat', 1)
GO
INSERT [dbo].[TblStates] ([StateId], [StateName], [CountryId]) VALUES (2, N'Maharashtra', 1)
GO
INSERT [dbo].[TblStates] ([StateId], [StateName], [CountryId]) VALUES (3, N'Rajashthan', 1)
GO
INSERT [dbo].[TblStates] ([StateId], [StateName], [CountryId]) VALUES (4, N'Madhya-Pradesh', 1)
GO
SET IDENTITY_INSERT [dbo].[TblStates] OFF
GO
