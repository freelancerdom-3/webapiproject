USE [MyDb]
GO
/****** Object:  Table [dbo].[TblSubCategorys]    Script Date: 18-06-2025 11:29:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSubCategorys](
	[SubCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[SubCategoryName] [varchar](50) NULL,
	[CategoryId] [int] NULL,
	[SubCategoryMappingId] [int] NULL,
	[ImageName] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[SubCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblSubCategorys] ON 
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (1, N'Appliance Repair & Service', 1, 0, N'appliance-repair')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (2, N'Electrician', 1, 0, N'electrician')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (3, N'Plumber', 1, 0, N'plumber')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (4, N'Carpenter', 1, 0, N'carpenter')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (5, N'Bathroom & kitchen cleaning', 1, 0, N'bathroom-kitchen-cleaning')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (6, N'Cleaning', 1, 0, N'cleaning')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (7, N'Full home painting', 1, 0, N'full-home-painting')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (8, N'AC Repair & Service', 0, 1, N'ac-repair-service')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (9, N'Laptop check up', 0, 1, N'laptop-checkup')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (10, N'Switch & socket', 0, 2, N'switch-socket')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (11, N'Fan', 0, 2, N'fan')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (12, N'MCB & submeter', 0, 2, N'mcb-submeter')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (13, N'Bath fittings', 0, 3, N'bath-fittings')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (14, N'Basin & sink', 0, 3, N'basin-sink')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (15, N'Clothes hanger', 0, 4, N'clothes-hanger')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (16, N'Bathroom cleaning', 0, 5, N'bathroom-cleaning')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (17, N'Kitchen cleaning', 0, 5, N'kitchen-cleaning')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (18, N'Salon for Women', 2, 0, N'salon-for-women')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (19, N'Spa for Women', 2, 0, N'spa-for-women')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (20, N'Massage for Men', 2, 0, N'massage-for-men')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (21, N'Salon Luxe', 0, 18, N'salon-luxe')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (22, N'Salon Classic', 0, 18, N'salon-classic')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (23, N'Spa Ayurveda', 0, 19, N'spa-ayurveda')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (24, N'Blow-dry & style', 0, 20, N'blow-dry-style')
GO
INSERT [dbo].[TblSubCategorys] ([SubCategoryId], [SubCategoryName], [CategoryId], [SubCategoryMappingId], [ImageName]) VALUES (25, N'Royal', 0, 22, N'royal')
GO
SET IDENTITY_INSERT [dbo].[TblSubCategorys] OFF
GO
