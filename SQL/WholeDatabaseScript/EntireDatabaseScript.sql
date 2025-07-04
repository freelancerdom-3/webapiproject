USE [MyDb]
GO
/****** Object:  Table [dbo].[TblAreas]    Script Date: 04-07-2025 05:43:19 PM ******/
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
/****** Object:  Table [dbo].[TblCarts]    Script Date: 04-07-2025 05:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCarts](
	[CartId] [int] IDENTITY(1,1) NOT NULL,
	[Price] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[CartId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblCategorys]    Script Date: 04-07-2025 05:43:19 PM ******/
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
/****** Object:  Table [dbo].[TblCities]    Script Date: 04-07-2025 05:43:19 PM ******/
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
/****** Object:  Table [dbo].[TblCountries]    Script Date: 04-07-2025 05:43:19 PM ******/
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
/****** Object:  Table [dbo].[TblFees]    Script Date: 04-07-2025 05:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblFees](
	[FeesId] [int] IDENTITY(1,1) NOT NULL,
	[StartRange] [decimal](10, 2) NULL,
	[EndRange] [decimal](10, 2) NULL,
	[Charge] [decimal](4, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[FeesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblImageNames]    Script Date: 04-07-2025 05:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblImageNames](
	[ImageNameId] [int] IDENTITY(1,1) NOT NULL,
	[CategorizedTypeId] [int] NULL,
	[CategorizedTypeName] [varchar](100) NULL,
	[ImageName] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ImageNameId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblOffers]    Script Date: 04-07-2025 05:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOffers](
	[OfferId] [int] IDENTITY(1,1) NOT NULL,
	[ServiceId] [int] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Discount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OfferId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblOtp]    Script Date: 04-07-2025 05:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOtp](
	[OTPId] [int] IDENTITY(1,1) NOT NULL,
	[MobileNumber] [varchar](10) NULL,
	[OTP] [int] NULL,
	[ExpiryTime] [datetime] NULL,
	[IsUsed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[OTPId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblServiceAreaMappings]    Script Date: 04-07-2025 05:43:19 PM ******/
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
/****** Object:  Table [dbo].[TblServiceCartMappings]    Script Date: 04-07-2025 05:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblServiceCartMappings](
	[MappingId] [int] IDENTITY(1,1) NOT NULL,
	[ServiceId] [int] NULL,
	[CartId] [int] NULL,
	[Price] [decimal](10, 2) NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblServiceProviderAreaMapping]    Script Date: 04-07-2025 05:43:19 PM ******/
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
/****** Object:  Table [dbo].[TblServiceProviderSubCategoryMapping]    Script Date: 04-07-2025 05:43:19 PM ******/
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
/****** Object:  Table [dbo].[TblServices]    Script Date: 04-07-2025 05:43:19 PM ******/
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
	[MainSubCategoryId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblStates]    Script Date: 04-07-2025 05:43:19 PM ******/
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
/****** Object:  Table [dbo].[TblSubCategorys]    Script Date: 04-07-2025 05:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSubCategorys](
	[SubCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[SubCategoryName] [varchar](50) NULL,
	[CategoryId] [int] NULL,
	[SubCategoryMappingId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SubCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblTimeSlots]    Script Date: 04-07-2025 05:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblTimeSlots](
	[TimeSlotId] [int] IDENTITY(1,1) NOT NULL,
	[Time] [varchar](10) NULL,
	[SpecialSlot] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TimeSlotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblUserCartMappings]    Script Date: 04-07-2025 05:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblUserCartMappings](
	[MappingId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[CartId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblUsers]    Script Date: 04-07-2025 05:43:19 PM ******/
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
/****** Object:  Table [dbo].[TblUserTypes]    Script Date: 04-07-2025 05:43:19 PM ******/
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
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (8, N'Alkapuri', 2)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (9, N'Sayajigunj', 2)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (10, N'Manjalpur', 2)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (11, N'Gotri', 2)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (12, N'Kalali', 2)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (13, N'Palanpur', 3)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (14, N'Nanpura', 3)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (15, N'Adajan', 3)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (16, N'Varachha', 3)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (17, N'Katargam', 3)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (18, N'Bhakti Nagar', 4)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (19, N'Mavdi', 4)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (20, N'Kailash Nagar', 4)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (21, N'Limda Chowk', 4)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (22, N'Chandreshnagar', 4)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (23, N'Patel Colony', 5)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (24, N'Digvijay Plot', 5)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (25, N'Gokul Nagar', 5)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (26, N'Mithapur', 5)
GO
INSERT [dbo].[TblAreas] ([AreaId], [AreaName], [CityId]) VALUES (27, N'Green City', 5)
GO
SET IDENTITY_INSERT [dbo].[TblAreas] OFF
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
SET IDENTITY_INSERT [dbo].[TblFees] ON 
GO
INSERT [dbo].[TblFees] ([FeesId], [StartRange], [EndRange], [Charge]) VALUES (1, CAST(0.00 AS Decimal(10, 2)), CAST(500.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(4, 2)))
GO
INSERT [dbo].[TblFees] ([FeesId], [StartRange], [EndRange], [Charge]) VALUES (2, CAST(501.00 AS Decimal(10, 2)), CAST(1000.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(4, 2)))
GO
INSERT [dbo].[TblFees] ([FeesId], [StartRange], [EndRange], [Charge]) VALUES (3, CAST(1001.00 AS Decimal(10, 2)), CAST(1500.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(4, 2)))
GO
INSERT [dbo].[TblFees] ([FeesId], [StartRange], [EndRange], [Charge]) VALUES (4, CAST(1501.00 AS Decimal(10, 2)), CAST(2000.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(4, 2)))
GO
INSERT [dbo].[TblFees] ([FeesId], [StartRange], [EndRange], [Charge]) VALUES (5, CAST(2001.00 AS Decimal(10, 2)), CAST(2500.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(4, 2)))
GO
INSERT [dbo].[TblFees] ([FeesId], [StartRange], [EndRange], [Charge]) VALUES (6, CAST(2501.00 AS Decimal(10, 2)), CAST(3000.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(4, 2)))
GO
INSERT [dbo].[TblFees] ([FeesId], [StartRange], [EndRange], [Charge]) VALUES (7, CAST(3001.00 AS Decimal(10, 2)), CAST(300000.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(4, 2)))
GO
SET IDENTITY_INSERT [dbo].[TblFees] OFF
GO
SET IDENTITY_INSERT [dbo].[TblImageNames] ON 
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (1, 1, N'SubCategory', N'appliance-repair')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (2, 2, N'SubCategory', N'electrician')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (3, 3, N'SubCategory', N'plumber')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (4, 4, N'SubCategory', N'carpenter')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (5, 5, N'SubCategory', N'bathroom-kitchen-cleaning')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (6, 6, N'SubCategory', N'cleaning')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (7, 7, N'SubCategory', N'full-home-painting')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (8, 8, N'SubCategory', N'ac-repair-service')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (9, 9, N'SubCategory', N'laptop-checkup')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (10, 10, N'SubCategory', N'switch-socket')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (11, 11, N'SubCategory', N'fan')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (12, 12, N'SubCategory', N'mcb-submeter')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (13, 13, N'SubCategory', N'bath-fittings')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (14, 14, N'SubCategory', N'basin-sink')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (15, 15, N'SubCategory', N'clothes-hanger')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (16, 16, N'SubCategory', N'bathroom-cleaning')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (17, 17, N'SubCategory', N'kitchen-cleaning')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (18, 18, N'SubCategory', N'salon-for-women')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (19, 19, N'SubCategory', N'spa-for-women')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (20, 20, N'SubCategory', N'massage-for-men')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (21, 21, N'SubCategory', N'salon-luxe')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (22, 22, N'SubCategory', N'salon-classic')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (23, 23, N'SubCategory', N'spa-ayurveda')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (24, 24, N'SubCategory', N'blow-dry-style')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (25, 25, N'SubCategory', N'royal')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (26, 26, N'SubCategory', N'wall-ceiling-light')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (27, 27, N'SubCategory', N'wiring')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (28, 28, N'SubCategory', N'doorbell')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (29, 29, N'SubCategory', N'inverter-stabiliser')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (30, 30, N'SubCategory', N'appliance')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (31, 1, N'Service', N'basin-installation')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (32, 2, N'Service', N'basin-replacement')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (33, 3, N'Service', N'fan-replacement')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (34, 4, N'Service', N'fan-installation')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (35, 5, N'Service', N'foam-jet-service(2AC s)')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (36, 7, N'Service', N'foam-jet-service(3AC s)')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (37, 8, N'Service', N'fan-uninstallation')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (38, 9, N'Service', N'fan-regulator-repair-replacement')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (39, 10, N'Service', N'switchbox-installation')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (40, 11, N'Service', N'ac-switchbox-installation')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (41, 12, N'Service', N'switchboard-installation')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (42, 13, N'Service', N'smart-switch-installation')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (43, 14, N'Service', N'smart-appliance-controller')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (44, 15, N'Service', N'wi-fi-smart-switch-installation')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (45, 16, N'Service', N'switch-socket-replacement')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (46, 17, N'Service', N'switchboard-switchbox-repair')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (47, 31, N'SubCategory', N'grouting')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (48, 32, N'SubCategory', N'water-filter')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (49, 33, N'SubCategory', N'drainage')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (50, 34, N'SubCategory', N'toilet')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (51, 35, N'SubCategory', N'tap-mixer')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (52, 36, N'SubCategory', N'water-tank')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (53, 37, N'SubCategory', N'motor')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (54, 38, N'SubCategory', N'water-pipes')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (55, 18, N'Service', N'fan-repair')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (56, 19, N'Service', N'single-pole-mcb-installation')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (57, 20, N'Service', N'double-pole-mcb-installation')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (58, 21, N'Service', N'mcb-fuse-replacement')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (59, 22, N'Service', N'submeter-installation')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (60, 23, N'Service', N'3-phase-changeover-switch-installation')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (61, 24, N'Service', N'sink-drainage-removal')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (62, 25, N'Service', N'bath-accessory-installation')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (63, 26, N'Service', N'ceiling-mounted-shower-installation')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (64, 27, N'Service', N'wall-mounted-shower-installation')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (65, 28, N'Service', N'bathroom-tile-grouting')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (66, 29, N'Service', N'kitchen-tile-grouting')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (67, 39, N'SubCategory', N'air-cooler')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (68, 40, N'SubCategory', N'chimney')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (69, 41, N'SubCategory', N'geyser')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (70, 42, N'SubCategory', N'refrigerator')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (71, 43, N'SubCategory', N'washing-machine')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (72, 44, N'SubCategory', N'microwave')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (73, 45, N'SubCategory', N'television')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (74, 46, N'SubCategory', N'water-purifier')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (75, 8, N'SubCategory', N'ac-repair-service')
GO
INSERT [dbo].[TblImageNames] ([ImageNameId], [CategorizedTypeId], [CategorizedTypeName], [ImageName]) VALUES (76, 9, N'SubCategory', N'laptop-check-up')
GO
SET IDENTITY_INSERT [dbo].[TblImageNames] OFF
GO
SET IDENTITY_INSERT [dbo].[TblOffers] ON 
GO
INSERT [dbo].[TblOffers] ([OfferId], [ServiceId], [StartDate], [EndDate], [Discount]) VALUES (1, 1, CAST(N'2025-05-01T09:00:00.000' AS DateTime), CAST(N'2025-05-15T23:59:59.000' AS DateTime), 10)
GO
INSERT [dbo].[TblOffers] ([OfferId], [ServiceId], [StartDate], [EndDate], [Discount]) VALUES (2, 2, CAST(N'2025-05-10T00:00:00.000' AS DateTime), CAST(N'2025-06-10T23:59:59.000' AS DateTime), 15)
GO
INSERT [dbo].[TblOffers] ([OfferId], [ServiceId], [StartDate], [EndDate], [Discount]) VALUES (3, 3, CAST(N'2025-06-01T08:00:00.000' AS DateTime), CAST(N'2025-06-30T22:00:00.000' AS DateTime), 20)
GO
INSERT [dbo].[TblOffers] ([OfferId], [ServiceId], [StartDate], [EndDate], [Discount]) VALUES (4, 3, CAST(N'2025-05-29T13:29:59.477' AS DateTime), CAST(N'2025-09-29T13:29:59.477' AS DateTime), 25)
GO
INSERT [dbo].[TblOffers] ([OfferId], [ServiceId], [StartDate], [EndDate], [Discount]) VALUES (6, 5, CAST(N'2025-05-29T13:30:45.080' AS DateTime), CAST(N'2025-06-29T13:30:45.080' AS DateTime), 30)
GO
SET IDENTITY_INSERT [dbo].[TblOffers] OFF
GO
SET IDENTITY_INSERT [dbo].[TblOtp] ON 
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (1, N'1234567891', 223280, CAST(N'2025-06-04T19:30:09.897' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (2, N'1234567891', 561349, CAST(N'2025-06-04T19:34:59.167' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (3, N'1234567891', 673770, CAST(N'2025-06-04T19:42:27.053' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (4, N'1234567891', 441374, CAST(N'2025-06-04T19:47:04.777' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (5, N'1234567891', 766268, CAST(N'2025-06-04T19:59:02.860' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (6, N'1234567891', 148984, CAST(N'2025-06-05T11:19:19.573' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (7, N'1234567891', 858881, CAST(N'2025-06-05T12:10:35.257' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (8, N'123456789', 246514, CAST(N'2025-06-05T12:17:55.097' AS DateTime), 0)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (9, N'1234567891', 763696, CAST(N'2025-06-05T12:18:37.923' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (10, N'1234567891', 544611, CAST(N'2025-06-05T12:28:21.787' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (11, N'1234567891', 145615, CAST(N'2025-06-05T12:33:21.640' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (12, N'1234567981', 563860, CAST(N'2025-06-05T12:45:36.777' AS DateTime), 0)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (13, N'1234567891', 502539, CAST(N'2025-06-05T12:58:28.403' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (14, N'1234567891', 653931, CAST(N'2025-06-05T13:17:48.033' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (15, N'9876543211', 913156, CAST(N'2025-06-05T15:22:22.107' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (16, N'9876543211', 490555, CAST(N'2025-06-06T11:58:19.270' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (17, N'1234567891', 495748, CAST(N'2025-06-19T17:23:37.350' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (18, N'1234567890', 845287, CAST(N'2025-06-24T18:44:38.190' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (19, N'1234567890', 538527, CAST(N'2025-06-25T17:58:16.600' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (20, N'1234567890', 888685, CAST(N'2025-06-30T13:26:45.487' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (21, N'1234567891', 946660, CAST(N'2025-07-02T14:20:05.130' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (22, N'1234567891', 795700, CAST(N'2025-07-02T16:48:56.230' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (1001, N'1234567891', 911411, CAST(N'2025-07-03T10:17:08.683' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (1002, N'1234567891', 759791, CAST(N'2025-07-03T14:52:30.843' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (2001, N'1234567891', 673073, CAST(N'2025-07-04T10:45:08.197' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (2002, N'1234567891', 195465, CAST(N'2025-07-04T11:37:11.157' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (2003, N'1234567891', 758015, CAST(N'2025-07-04T13:25:45.090' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (2004, N'1234567891', 800669, CAST(N'2025-07-04T13:31:31.013' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (2005, N'1234567890', 547482, CAST(N'2025-07-04T14:24:08.640' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (2006, N'1111111111', 110532, CAST(N'2025-07-04T14:51:54.570' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[TblOtp] OFF
GO
SET IDENTITY_INSERT [dbo].[TblServiceAreaMappings] ON 
GO
INSERT [dbo].[TblServiceAreaMappings] ([MappingId], [ServiceId], [AreaId]) VALUES (1, 1, 1)
GO
INSERT [dbo].[TblServiceAreaMappings] ([MappingId], [ServiceId], [AreaId]) VALUES (2, 1, 2)
GO
INSERT [dbo].[TblServiceAreaMappings] ([MappingId], [ServiceId], [AreaId]) VALUES (3, 1, 3)
GO
INSERT [dbo].[TblServiceAreaMappings] ([MappingId], [ServiceId], [AreaId]) VALUES (5, 3, 2)
GO
SET IDENTITY_INSERT [dbo].[TblServiceAreaMappings] OFF
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
SET IDENTITY_INSERT [dbo].[TblServices] ON 
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (1, N'Wash Basin installation', 14, CAST(460.00 AS Decimal(10, 2)), N'45 minutes', 3)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (2, N'Waste pipe replacement', 14, CAST(140.00 AS Decimal(10, 2)), N'30 minutes', 3)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (3, N'fan replaceement', 11, CAST(250.00 AS Decimal(10, 2)), N'30 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (4, N'fan installation', 11, CAST(200.00 AS Decimal(10, 2)), N'20 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (5, N'Foam-jet Service (2AC s)', 8, CAST(1000.00 AS Decimal(10, 2)), N'1 hour', 1)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (7, N'Foam-jet Service (3AC s)', 8, CAST(1500.00 AS Decimal(10, 2)), N'2 hours', 1)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (8, N'Fan Uninstallation', 11, CAST(300.00 AS Decimal(10, 2)), N'30 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (9, N'Fan regulator repair/replacement', 11, CAST(100.00 AS Decimal(10, 2)), N'20 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (10, N'Switchbox installation', 10, CAST(350.00 AS Decimal(10, 2)), N'30 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (11, N'AC Switchbox installation', 10, CAST(370.00 AS Decimal(10, 2)), N'30 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (12, N'Switchboard installation', 10, CAST(280.00 AS Decimal(10, 2)), N'30 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (13, N'Smart switch installation', 10, CAST(150.00 AS Decimal(10, 2)), N'15 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (14, N'Smart appliance controller', 10, CAST(200.00 AS Decimal(10, 2)), N'15 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (15, N'Wi-Fi smart switch installation', 10, CAST(200.00 AS Decimal(10, 2)), N'15 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (16, N'Switch/socket replacement', 10, CAST(110.00 AS Decimal(10, 2)), N'10 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (17, N'Switchboard/switchbox repair', 10, CAST(110.00 AS Decimal(10, 2)), N'30 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (18, N'Fan Repair', 11, CAST(200.00 AS Decimal(10, 2)), N'30 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (19, N'Single-pole MCB installation', 12, CAST(120.00 AS Decimal(10, 2)), N'60 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (20, N'Double-pole MCB installation', 12, CAST(150.00 AS Decimal(10, 2)), N'60 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (21, N'MCB/Fuse Replacement', 12, CAST(110.00 AS Decimal(10, 2)), N'30 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (22, N'Submeter installation', 12, CAST(320.00 AS Decimal(10, 2)), N'60 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (23, N'3-phase changeover switch installation', 12, CAST(370.00 AS Decimal(10, 2)), N'30 minutes', 2)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (24, N'Sink drainage removal', 14, CAST(210.00 AS Decimal(10, 2)), N'30 minutes', 3)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (25, N'Bath accessory installation', 13, CAST(150.00 AS Decimal(10, 2)), N'30 minutes', 3)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (26, N'Ceiling mounted shower installation', 13, CAST(210.00 AS Decimal(10, 2)), N'35 minutes', 3)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (27, N'Wall mounted shower installation', 13, CAST(160.00 AS Decimal(10, 2)), N'35 minutes', 3)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (28, N'Bathroom tile grouting', 31, CAST(1500.00 AS Decimal(10, 2)), N'2 hours', 3)
GO
INSERT [dbo].[TblServices] ([ServiceId], [ServiceName], [SubCategoryId], [Price], [TimeTaken], [MainSubCategoryId]) VALUES (29, N'Kitchen tile grouting', 31, CAST(1000.00 AS Decimal(10, 2)), N'60 minutes', 3)
GO
SET IDENTITY_INSERT [dbo].[TblServices] OFF
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
SET IDENTITY_INSERT [dbo].[TblSubCategorys] ON 
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (1, N'Appliance Repair & Service', 1, 0)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (2, N'Electrician', 1, 0)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (3, N'Plumber', 1, 0)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (4, N'Carpenter', 1, 0)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (5, N'Bathroom & kitchen cleaning', 1, 0)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (6, N'Cleaning', 1, 0)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (7, N'Full home painting', 1, 0)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (8, N'AC Repair & Service', 0, 1)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (9, N'Laptop check up', 0, 1)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (10, N'Switch & socket', 0, 2)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (11, N'Fan', 0, 2)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (12, N'MCB & submeter', 0, 2)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (13, N'Bath fittings', 0, 3)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (14, N'Basin & sink', 0, 3)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (15, N'Clothes hanger', 0, 4)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (16, N'Bathroom cleaning', 0, 5)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (17, N'Kitchen cleaning', 0, 5)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (18, N'Salon for Women', 2, 0)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (19, N'Spa for Women', 2, 0)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (20, N'Massage for Men', 2, 0)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (21, N'Salon Luxe', 0, 18)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (22, N'Salon Classic', 0, 18)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (23, N'Spa Ayurveda', 0, 19)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (24, N'Blow-dry & style', 0, 20)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (25, N'Royal', 0, 22)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (26, N'Wall/Ceiling-light', 0, 2)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (27, N'Wiring', 0, 2)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (28, N'Doorbell', 0, 2)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (29, N'Inverter & Stabilisers', 0, 2)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (30, N'Appliance', 0, 2)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (31, N'Grouting', 0, 3)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (32, N'Water filter', 0, 3)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (33, N'Drainage', 0, 3)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (34, N'Toilet', 0, 3)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (35, N'Tap and mixer', 0, 3)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (36, N'Water tank', 0, 3)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (37, N'Motor', 0, 3)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (38, N'Water pipes', 0, 3)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (39, N'Air cooler', 0, 1)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (40, N'Chimney', 0, 1)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (41, N'Geyser', 0, 1)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (42, N'Refrigerator', 0, 1)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (43, N'Washing machine', 0, 1)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (44, N'Microwave', 0, 1)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (45, N'Television', 0, 1)
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId]) VALUES (46, N'Water purifier', 0, 1)
GO
SET IDENTITY_INSERT [dbo].[TblSubCategorys] OFF
GO
SET IDENTITY_INSERT [dbo].[TblTimeSlots] ON 
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (1, N'08:00 AM', 1)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (2, N'08:00 AM', 1)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (3, N'08:30 AM', 1)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (4, N'09:00 AM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (5, N'09:30 AM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (6, N'10:00 AM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (7, N'10:30 AM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (8, N'11:00 AM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (9, N'11:30 AM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (10, N'12:00 PM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (11, N'12:30 PM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (12, N'01:00 PM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (13, N'01:30 PM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (14, N'02:00 PM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (15, N'02:30 PM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (16, N'03:00 PM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (17, N'03:30 PM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (18, N'04:00 PM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (19, N'04:30 PM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (20, N'05:00 PM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (21, N'05:30 PM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (22, N'06:00 PM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (23, N'06:30 PM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (24, N'07:00 PM', 0)
GO
INSERT [dbo].[TblTimeSlots] ([TimeSlotId], [Time], [SpecialSlot]) VALUES (25, N'07:30 PM', 0)
GO
SET IDENTITY_INSERT [dbo].[TblTimeSlots] OFF
GO
SET IDENTITY_INSERT [dbo].[TblUserCartMappings] ON 
GO
INSERT [dbo].[TblUserCartMappings] ([MappingId], [UserId], [CartId]) VALUES (1, 1, 1)
GO
INSERT [dbo].[TblUserCartMappings] ([MappingId], [UserId], [CartId]) VALUES (2, 2, 2)
GO
INSERT [dbo].[TblUserCartMappings] ([MappingId], [UserId], [CartId]) VALUES (3, 3, 3)
GO
SET IDENTITY_INSERT [dbo].[TblUserCartMappings] OFF
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
INSERT [dbo].[TblUserTypes] ([UserTypeId], [UserTypeName]) VALUES (1, N'Admin')
GO
INSERT [dbo].[TblUserTypes] ([UserTypeId], [UserTypeName]) VALUES (2, N'End User')
GO
INSERT [dbo].[TblUserTypes] ([UserTypeId], [UserTypeName]) VALUES (3, N'Service Provider')
GO
