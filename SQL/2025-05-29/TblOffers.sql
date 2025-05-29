USE [MyDb]
GO
/****** Object:  Table [dbo].[TblOffers]    Script Date: 29-05-2025 7.03.13 PM ******/
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
