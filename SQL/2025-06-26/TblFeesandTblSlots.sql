USE [MyDb]
GO
/****** Object:  Table [dbo].[TblFees]    Script Date: 26-06-2025 14:12:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblFees](
	[FeesId] [int] IDENTITY(1,1) NOT NULL,
	[Range] [varchar](15) NULL,
	[Charge] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FeesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblTimeSlots]    Script Date: 26-06-2025 14:12:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblTimeSlots](
	[SlotId] [int] IDENTITY(1,1) NOT NULL,
	[Time] [time](7) NULL,
	[SlotExtrafee] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SlotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblFees] ON 

INSERT [dbo].[TblFees] ([FeesId], [Range], [Charge]) VALUES (1, N'0-500', 40)
INSERT [dbo].[TblFees] ([FeesId], [Range], [Charge]) VALUES (2, N'501-1000', 80)
INSERT [dbo].[TblFees] ([FeesId], [Range], [Charge]) VALUES (3, N'1001-1500', 120)
INSERT [dbo].[TblFees] ([FeesId], [Range], [Charge]) VALUES (4, N'1501-2000', 160)
INSERT [dbo].[TblFees] ([FeesId], [Range], [Charge]) VALUES (5, N'2001-2500', 200)
INSERT [dbo].[TblFees] ([FeesId], [Range], [Charge]) VALUES (6, N'2501-3000', 240)
INSERT [dbo].[TblFees] ([FeesId], [Range], [Charge]) VALUES (7, N'3001-300000', 300)
SET IDENTITY_INSERT [dbo].[TblFees] OFF
GO
SET IDENTITY_INSERT [dbo].[TblTimeSlots] ON 

INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (1, CAST(N'08:00:00' AS Time), 100)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (2, CAST(N'08:30:00' AS Time), 100)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (3, CAST(N'09:00:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (4, CAST(N'09:30:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (5, CAST(N'10:00:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (6, CAST(N'10:30:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (7, CAST(N'11:00:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (8, CAST(N'11:30:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (9, CAST(N'12:00:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (10, CAST(N'12:30:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (11, CAST(N'13:00:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (12, CAST(N'13:30:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (13, CAST(N'14:00:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (14, CAST(N'14:30:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (15, CAST(N'15:30:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (16, CAST(N'16:00:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (17, CAST(N'16:30:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (18, CAST(N'17:00:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (19, CAST(N'17:30:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (20, CAST(N'18:00:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (21, CAST(N'18:30:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (22, CAST(N'19:00:00' AS Time), 0)
INSERT [dbo].[TblTimeSlots] ([SlotId], [Time], [SlotExtrafee]) VALUES (23, CAST(N'19:30:00' AS Time), 0)
SET IDENTITY_INSERT [dbo].[TblTimeSlots] OFF
GO
