USE [MyDb]
GO
/****** Object:  Table [dbo].[TblOtp]    Script Date: 29-05-2025 04:18:04 PM ******/
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
SET IDENTITY_INSERT [dbo].[TblOtp] ON 
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (2, N'2345678901', 111111, CAST(N'2025-05-22T16:41:43.263' AS DateTime), 0)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (3, N'3456789012', 222222, CAST(N'2025-05-22T16:41:43.263' AS DateTime), 0)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (4, N'4567890123', 333333, CAST(N'2025-05-23T16:41:43.263' AS DateTime), 0)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (6, N'1234567777', 1125, CAST(N'2025-05-27T10:41:31.240' AS DateTime), 0)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (1002, N'9999955555', 1896, CAST(N'2025-05-29T05:14:26.793' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (1003, N'1111115555', 7778, CAST(N'2025-05-29T05:18:32.047' AS DateTime), 1)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (1004, N'1111115555', 7778, CAST(N'2025-05-29T05:18:32.047' AS DateTime), 0)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (1005, N'4444455555', 4568, CAST(N'2025-05-29T05:25:43.173' AS DateTime), 0)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (1006, N'1596325875', 4567, CAST(N'2025-05-29T06:37:41.827' AS DateTime), 0)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (1007, N'2323232323', 123456, CAST(N'2025-05-30T06:46:18.887' AS DateTime), 0)
GO
INSERT [dbo].[TblOtp] ([OTPId], [MobileNumber], [OTP], [ExpiryTime], [IsUsed]) VALUES (1008, N'8888885552', 1454, CAST(N'2025-05-29T10:16:29.553' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[TblOtp] OFF
GO
