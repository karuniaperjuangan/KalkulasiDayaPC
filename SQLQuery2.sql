USE [C:\USERS\KARUNIA PERJUANGAN\SOURCE\REPOS\KARUNIAPERJUANGAN\KALKULASIDAYAPC\COMPUTERDB.MDF]
GO
/****** Object:  Table [dbo].[DBComputer]    Script Date: 28/04/2021 14.58.27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DBComputer](
	[Id] [int] NOT NULL,
	[OwnerName] [nvarchar](255) NULL,
	[Motherboard_Size] [nvarchar](50) NOT NULL,
	[GPU_Id] [int] NOT NULL,
	[CPU_Id] [int] NOT NULL,
	[RAM_Size] [int] NOT NULL,
	[Drive_Count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DBCPU]    Script Date: 28/04/2021 14.58.27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DBCPU](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](255) NULL,
	[base_clock] [int] NULL,
	[TDP] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DBGPU]    Script Date: 28/04/2021 14.58.27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DBGPU](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](255) NULL,
	[base_clock] [int] NULL,
	[TDP] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DBComputer] ([Id], [OwnerName], [Motherboard_Size], [GPU_Id], [CPU_Id], [RAM_Size], [Drive_Count]) VALUES (1, N'Juang', N'Micro-ATX', 29, 74, 8, 2)
INSERT [dbo].[DBComputer] ([Id], [OwnerName], [Motherboard_Size], [GPU_Id], [CPU_Id], [RAM_Size], [Drive_Count]) VALUES (2, N'Ariel Noah', N'ATX', 29, 9, 32, 2)
INSERT [dbo].[DBComputer] ([Id], [OwnerName], [Motherboard_Size], [GPU_Id], [CPU_Id], [RAM_Size], [Drive_Count]) VALUES (3, N'Zakki Mahfud', N'ATX', 22, 15, 16, 2)
GO
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (1, N'AMD Ryzen 9 5900X', 3700, 105)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (2, N'AMD Ryzen 9 5950X', 3400, 105)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (3, N'Intel Core i9-11900K', 3500, 125)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (4, N'AMD Ryzen 7 5800X', 3800, 105)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (5, N'AMD Ryzen 5 5600X', 3700, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (6, N'Intel Core i9-10900K', 3700, 125)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (7, N'Intel Core i9-10850K', 3600, 95)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (8, N'Intel Core i5-11600K', 3900, 125)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (9, N'Intel Core i7-10700K', 3800, 125)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (10, N'Intel Core i9-10980XE', 3000, 165)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (11, N'Intel W-3175X', 3100, 225)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (12, N'Intel Core i9-9900KS', 4000, 127)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (13, N'Intel Core i7-10700/F', 2900, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (14, N'Intel Core i5-10600K', 4100, 125)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (15, N'Intel Core i7-9700K', 3600, 95)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (16, N'Intel Core i9-9900K / F', 3600, 95)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (17, N'AMD Ryzen 9 3950X', 3500, 105)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (18, N'AMD Threadripper 3970X', 3700, 280)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (19, N'AMD Threadripper 3960X', 3800, 280)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (20, N'AMD Ryzen 7 3800XT', 3900, 105)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (21, N'AMD Threadripper 3990X', 2900, 280)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (22, N'AMD Ryzen 9 3900XT', 3800, 105)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (23, N'AMD Ryzen 9 3900X', 3800, 105)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (24, N'Intel Core i9-9980XE', 4400, 165)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (25, N'AMD Ryzen 9 3900', 3100, 105)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (26, N'AMD Ryzen 7 3700X', 3600, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (27, N'AMD Ryzen 7 3800X', 3900, 105)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (28, N'AMD Ryzen 5 3600XT', 3800, 95)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (29, N'AMD Ryzen 5 3600', 3600, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (30, N'Intel Core i9-7960X', 2800, 165)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (31, N'Intel Core i7-8700K', 3700, 95)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (32, N'AMD Ryzen 5 3600X', 3800, 95)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (33, N'AMD Ryzen 3 3300X', 3800, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (34, N'Intel Core i5-9600K', 3700, 95)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (35, N'AMD Threadripper Pro 3995WX', 2700, 280)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (36, N'Intel Core i5-8600K', 3600, 95)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (37, N'Intel Core i7-8700', 3200, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (38, N'Intel Core i7-8086K', 4000, 95)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (39, N'Intel Core i5-9400 / i5-9400F', 2900, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (40, N'Intel Core i5-8400', 2800, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (41, N'AMD Ryzen 5 3500X', 3600, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (42, N'AMD Ryzen 7 2700X', 3700, 105)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (43, N'AMD Ryzen 3 3100', 3800, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (44, N'Intel Core i9-7980XE', 2600, 165)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (45, N'Intel Core i9-7900X', 3300, 140)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (46, N'AMD Ryzen 7 Pro 4750G*', 3600, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (47, N'AMD Ryzen 5 2600X', 3600, 95)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (48, N'Intel Core i7-7700K', 4200, 91)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (49, N'AMD Threadripper 2990WX (GM)', 3000, 250)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (50, N'Intel Core i7-7820X', 3600, 140)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (51, N'AMD Threadripper 2950X (GM)', 3500, 180)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (52, N'AMD Threadripper 2970WX', 3000, 250)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (53, N'AMD Ryzen 7 2700', 3200, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (54, N'AMD Threadripper 1900X (GM)', 3800, 180)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (55, N'Intel Core i7-7700', 3600, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (56, N'AMD Ryzen 5 2600', 3400, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (57, N'Intel Core i7-7800X', 3500, 140)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (58, N'Intel Core i5-7600K', 3800, 91)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (59, N'AMD Threadripper 1950X (GM)', 3400, 180)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (60, N'AMD Threadripper 1920X (GM)', 3500, 180)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (61, N'Intel Core i3-9350KF', 4000, 91)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (62, N'AMD Ryzen 7 1800X', 3600, 95)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (63, N'Intel Core i5-7600', 3500, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (64, N'Intel Core i3-8100', 3600, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (65, N'Intel Core i5-7500', 3400, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (66, N'Intel Core i5-7400', 3000, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (67, N'AMD Ryzen 7 1700X', 3800, 95)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (68, N'AMD Ryzen 5 1600AF', 3200, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (69, N'AMD Ryzen 7 1700', 3000, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (70, N'Intel Core i3-8350K', 4000, 91)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (71, N'Intel Core i3-9100', 3600, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (72, N'AMD Ryzen 5 1600X', 3600, 95)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (73, N'AMD Ryzen 5 1600', 3200, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (74, N'AMD Ryzen 5 3400G', 3700, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (75, N'Intel Core i5-7400', 3000, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (76, N'Intel Core i3-8100', 3600, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (77, N'AMD Ryzen 3 3200G', 3600, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (78, N'AMD Ryzen 5 2400G', 3600, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (79, N'AMD Ryzen 5 1500X', 3500, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (80, N'Intel Core i3-7350K', 4200, 60)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (81, N'Intel Pentium G5600', 3900, 54)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (82, N'AMD Ryzen 3 2200G', 3500, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (83, N'AMD Ryzen 3 1300X', 3500, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (84, N'Intel Core i3-7300', 4000, 51)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (85, N'Intel Pentium G5600', 3900, 54)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (86, N'Intel Pentium G5400', 3700, 54)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (87, N'Intel Core i3-7100', 3900, 51)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (88, N'AMD Ryzen 5 1400', 3200, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (89, N'Intel Pentium G4620', 3700, 54)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (90, N'Intel Pentium G4560', 3500, 54)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (91, N'AMD Athlon 3000G', 3500, 35)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (92, N'AMD Athlon 240GE', 3500, 35)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (93, N'AMD Athlon 220GE', 3400, 35)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (94, N'AMD Athlon 200GE', 3200, 35)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (95, N'AMD Ryzen 3 1200', 3100, 65)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (96, N'Zhaoxin KaiXian KX-U6780A', 2700, 70)
INSERT [dbo].[DBCPU] ([Id], [Name], [base_clock], [TDP]) VALUES (97, N'AMD A10-9700', 3500, 65)
GO
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (1, N'Nvidia GeForce RTX 3090', 1400, 350)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (2, N'AMD Radeon RX 6900 XT', 1825, 300)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (3, N'AMD Radeon RX 6800 XT', 1825, 300)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (4, N'Nvidia GeForce RTX 3080', 1440, 320)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (5, N'AMD Radeon RX 6800', 1700, 250)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (6, N'Nvidia Titan RTX', 1350, 280)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (7, N'Nvidia GeForce RTX 2080 Ti', 1350, 260)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (8, N'Nvidia GeForce RTX 3070', 1500, 220)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (9, N'AMD Radeon RX 6700 XT', 2321, 230)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (10, N'Nvidia GeForce RTX 3060 Ti', 1410, 200)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (11, N'Nvidia Titan V', 1200, 250)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (12, N'Nvidia GeForce RTX 2080 Super', 1650, 250)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (13, N'Nvidia GeForce RTX 2080', 1515, 225)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (14, N'Nvidia Titan Xp', 1405, 250)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (15, N'Nvidia GeForce RTX 2070 Super', 1605, 215)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (16, N'AMD Radeon VII', 1400, 300)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (17, N'Nvidia GeForce GTX 1080 Ti', 1480, 250)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (18, N'AMD Radeon RX 5700 XT', 1605, 225)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (19, N'Nvidia GeForce RTX 3060 12GB', 1320, 170)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (20, N'Nvidia GeForce RTX 2070', 1410, 185)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (21, N'AMD Radeon RX 5700', 1465, 185)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (22, N'Nvidia GeForce RTX 2060 Super', 1470, 175)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (23, N'AMD Radeon RX Vega 64', 1274, 295)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (24, N'AMD Radeon RX 5600 XT', 1615, 150)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (25, N'Nvidia GeForce GTX 1080', 1607, 180)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (26, N'Nvidia GeForce RTX 2060', 1365, 160)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (27, N'AMD Radeon RX Vega 56', 1156, 210)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (28, N'Nvidia GeForce GTX 1070 Ti', 1607, 180)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (29, N'Nvidia GeForce GTX 1660 Super', 1530, 125)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (30, N'Nvidia GeForce GTX 1660 Ti', 1365, 120)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (31, N'Nvidia GeForce GTX 1070', 1506, 150)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (32, N'Nvidia GTX Titan X (Maxwell)', 1000, 250)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (33, N'Nvidia GeForce GTX 980 Ti', 1000, 250)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (34, N'Nvidia GeForce GTX 1660', 1530, 120)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (35, N'AMD Radeon R9 Fury X', 1050, 275)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (36, N'AMD Radeon RX 590', 1469, 225)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (37, N'AMD Radeon RX 5500 XT 8GB', 1717, 130)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (38, N'AMD Radeon RX 580 8GB', 1257, 185)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (39, N'Nvidia GeForce GTX 1650 Super', 1530, 100)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (40, N'AMD Radeon RX 5500 XT 4GB', 1717, 130)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (41, N'AMD Radeon R9 390', 1000, 275)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (42, N'Nvidia GeForce GTX 1060 6GB', 1506, 120)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (43, N'Nvidia GeForce GTX 980', 1126, 165)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (44, N'AMD Radeon RX 570 4GB', 1168, 150)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (45, N'Nvidia GTX 1650 GDDR6', 1410, 75)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (46, N'Nvidia GeForce GTX 1060 3GB', 1506, 120)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (47, N'Nvidia GeForce GTX 970', 1050, 145)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (48, N'Nvidia GeForce GTX 1650', 1485, 75)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (49, N'Nvidia GeForce GTX 1050 Ti', 1290, 75)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (50, N'AMD Radeon RX 560 4GB', 1175, 80)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (51, N'Nvidia GeForce GTX 1050', 1354, 75)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (52, N'AMD Radeon RX 550', 1100, 50)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (53, N'Nvidia GeForce GT 1030', 1228, 30)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (54, N'AMD Vega 11 (R5 3400G)', 1400, 0)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (55, N'AMD Vega 8 (R3 3200G)', 1250, 0)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (56, N'Intel Iris Plus (i7-1065G7)', 1100, 0)
INSERT [dbo].[DBGPU] ([Id], [Name], [base_clock], [TDP]) VALUES (57, N'Intel UHD Graphics 630 (i7-10700K)', 1200, 0)
GO
ALTER TABLE [dbo].[DBComputer]  WITH CHECK ADD  CONSTRAINT [FK_Computer_CPU] FOREIGN KEY([CPU_Id])
REFERENCES [dbo].[DBCPU] ([Id])
GO
ALTER TABLE [dbo].[DBComputer] CHECK CONSTRAINT [FK_Computer_CPU]
GO
ALTER TABLE [dbo].[DBComputer]  WITH CHECK ADD  CONSTRAINT [FK_Computer_GPU] FOREIGN KEY([GPU_Id])
REFERENCES [dbo].[DBGPU] ([Id])
GO
ALTER TABLE [dbo].[DBComputer] CHECK CONSTRAINT [FK_Computer_GPU]
GO
