USE [QLVT]
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 12/6/2020 12:55:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[MACN] [nchar](10) NOT NULL,
	[ChiNhanh] [nvarchar](100) NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[SoDT] [nvarchar](15) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[MACN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTDDH]    Script Date: 12/6/2020 12:55:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDDH](
	[MasoDDH] [nchar](8) NOT NULL,
	[MAVT] [nchar](4) NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [float] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CTDDH] PRIMARY KEY CLUSTERED 
(
	[MasoDDH] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPN]    Script Date: 12/6/2020 12:55:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPN](
	[MAPN] [nchar](8) NOT NULL,
	[MAVT] [nchar](4) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [float] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CTPN] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPX]    Script Date: 12/6/2020 12:55:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPX](
	[MAPX] [nchar](8) NOT NULL,
	[MAVT] [nchar](4) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [float] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CTPX] PRIMARY KEY CLUSTERED 
(
	[MAPX] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatHang]    Script Date: 12/6/2020 12:55:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatHang](
	[MasoDDH] [nchar](8) NOT NULL,
	[NGAY] [date] NOT NULL,
	[NhaCC] [nvarchar](100) NOT NULL,
	[MANV] [int] NOT NULL,
	[MAKHO] [nchar](4) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_DatHang] PRIMARY KEY CLUSTERED 
(
	[MasoDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 12/6/2020 12:55:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MAKHO] [nchar](4) NOT NULL,
	[TENKHO] [nvarchar](30) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[MACN] [nchar](10) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MAKHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/6/2020 12:55:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MANV] [int] NOT NULL,
	[HO] [nvarchar](40) NULL,
	[TEN] [nvarchar](10) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[NGAYSINH] [datetime] NULL,
	[LUONG] [float] NULL,
	[MACN] [nchar](10) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 12/6/2020 12:55:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MAPN] [nchar](8) NOT NULL,
	[NGAY] [date] NOT NULL,
	[MasoDDH] [nchar](8) NOT NULL,
	[MANV] [int] NOT NULL,
	[MAKHO] [nchar](4) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 12/6/2020 12:55:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MAPX] [nchar](8) NOT NULL,
	[NGAY] [date] NOT NULL,
	[HOTENKH] [nvarchar](100) NOT NULL,
	[MANV] [int] NOT NULL,
	[MAKHO] [nchar](4) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_PX] PRIMARY KEY CLUSTERED 
(
	[MAPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vattu]    Script Date: 12/6/2020 12:55:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vattu](
	[MAVT] [nchar](4) NOT NULL,
	[TENVT] [nvarchar](30) NOT NULL,
	[DVT] [nvarchar](15) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_VatTu] PRIMARY KEY CLUSTERED 
(
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiNhanh] ([MACN], [ChiNhanh], [DIACHI], [SoDT], [rowguid]) VALUES (N'CN1       ', N'Chi nhánh 1 TP HCM', N'35 Trần Hưng Đạo P1 Q1', N'999111888', N'5ede50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[ChiNhanh] ([MACN], [ChiNhanh], [DIACHI], [SoDT], [rowguid]) VALUES (N'CN2       ', N'Chi nhánh 2 TP Cần Thơ', N'27 Nguyễn Huệ', N'333222111', N'5fde50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH01  ', N'IM04', 8, 39000000, N'370d3edc-8c34-eb11-b617-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH01  ', N'IP01', 11, 39990000, N'3a4737bf-ac30-eb11-b610-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH01  ', N'MU06', 7, 300000, N'b1b7c686-e52f-eb11-b610-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH01  ', N'RA02', 20, 2440000, N'26366ea6-de30-eb11-b610-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH01  ', N'TL03', 10, 25960000, N'7cde50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH02  ', N'MC06', 35, 455000, N'c7396a7d-d636-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH02  ', N'ME01', 24, 1330000, N'ec74366d-d636-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH02  ', N'MNN3', 18, 2590000, N'ba7dfb07-d736-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH03  ', N'MB14', 20, 13490000, N'0e0d39c1-3437-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH03  ', N'MS01', 20, 455000, N'7ede50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH03  ', N'OC01', 30, 1440000, N'f011615c-3537-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH03  ', N'SDP1', 25, 265000, N'3bedbb3e-3537-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH03  ', N'SG20', 40, 23990000, N'31430e91-3337-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH03  ', N'TN03', 35, 132000, N'd23b1b27-3537-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH03  ', N'TV01', 16, 24900000, N'd2aae8da-3137-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH04  ', N'CC01', 22, 207000, N'43ce8497-3737-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH04  ', N'LB01', 12, 4990000, N'3fb56da9-3737-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH04  ', N'LS02', 10, 12990000, N'98fb0ed8-3737-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH04  ', N'MQ04', 14, 8890000, N'32b641c7-3737-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH04  ', N'TV05', 10, 18400000, N'bcc23f8c-3637-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH06  ', N'DG01', 30, 1180000, N'36b2df2a-3937-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH06  ', N'DG02', 30, 1250000, N'acc9f936-3937-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH07  ', N'OC01', 27, 1380000, N'09f3a1a7-3e37-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH07  ', N'SDP1', 30, 240000, N'cf198fbb-3e37-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH07  ', N'SG20', 22, 22990000, N'7e94c1cf-3e37-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH09  ', N'IC03', 8, 880000, N'25c4f37d-4137-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH09  ', N'OC02', 12, 1920000, N'ae586d6b-4137-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH09  ', N'RA02', 20, 1440000, N'5cdbae4d-4137-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH09  ', N'RA03', 18, 6650000, N'185178f3-4037-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH10  ', N'MG09', 20, 13290000, N'cddc160f-4237-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH10  ', N'ML07', 12, 16330000, N'78cc802a-4237-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH10  ', N'TL03', 10, 25690000, N'4c579440-4237-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH19  ', N'CO04', 20, 420000, N'2e5061c1-d436-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH19  ', N'FG02', 50, 856000, N'3cb811db-d436-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH20  ', N'DL02', 12, 17990000, N'c09afc23-df36-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH20  ', N'DL03', 8, 21450000, N'ef4fb812-df36-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH21  ', N'RA02', 2, 2440000, N'd50c0520-3736-eb11-b619-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH21  ', N'VS01', 12, 9990000, N'c2431966-3237-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH22  ', N'DL02', 10, 17990000, N'a904ac47-cf36-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH22  ', N'DL03', 15, 21450000, N'a26f7866-cf36-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH23  ', N'AP01', 20, 5250000, N'064df1e4-d136-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH23  ', N'IM04', 10, 29990000, N'c1cde8c7-d136-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH23  ', N'IP01', 30, 39990000, N'dc45bb0a-d236-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH23  ', N'MB01', 15, 45990000, N'34e60f45-d236-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH24  ', N'MG09', 12, 13290000, N'ca555923-d336-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH24  ', N'ML07', 15, 16330000, N'b965317a-d336-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH24  ', N'TL03', 25, 25690000, N'16af1f41-d336-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH25  ', N'RA02', 4, 1050000, N'fce0cde4-df36-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN01    ', N'IM04', 8, 39000000, N'ccaab42b-2637-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN01    ', N'IP01', 10, 39990000, N'abb87fa2-1937-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN01    ', N'RA02', 20, 2440000, N'03754e09-1b37-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN01    ', N'TL03', 10, 25960000, N'd36c18b6-1937-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN03    ', N'MB14', 20, 13490000, N'a3ceddd0-3537-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN03    ', N'MS01', 20, 455000, N'988a5524-3337-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN03    ', N'OC01', 30, 1440000, N'9867a5ef-3537-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN03    ', N'SDP1', 25, 265000, N'9b2085df-3537-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN03    ', N'SG20', 40, 23990000, N'7ad71ab3-3337-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN03    ', N'TN03', 35, 132000, N'4fa5fbe8-3537-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN03    ', N'TV01', 16, 24900000, N'cf55c1f5-3137-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN04    ', N'CC01', 22, 207000, N'd90f8510-3837-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN04    ', N'LB01', 12, 4990000, N'bb4e51f7-3737-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN04    ', N'LS02', 10, 12990000, N'8c335019-3837-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN04    ', N'MQ04', 14, 8890000, N'17d56f04-3837-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN04    ', N'TV05', 10, 18400000, N'f24f2ca0-3637-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN07    ', N'OC01', 27, 1380000, N'da1ee2c2-4137-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN07    ', N'SDP1', 30, 240000, N'91f163ca-4137-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN07    ', N'SG20', 22, 22900000, N'd1ed16d1-4137-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN10    ', N'MG09', 20, 13290000, N'bd90ae5b-4237-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN10    ', N'ML07', 12, 16330000, N'3b39e269-4237-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN10    ', N'TL03', 10, 25690000, N'30411b50-4237-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[CTPX] ([MAPX], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PX01    ', N'MS01', 4, 5600, N'7fde50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[CTPX] ([MAPX], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PX02    ', N'RA02', 1, 999999, N'b827f5d5-ee32-eb11-b615-107d1a1cf728')
GO
INSERT [dbo].[CTPX] ([MAPX], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PX02    ', N'TV05', 1, 9000, N'01afde9b-7b29-eb11-b604-107d1a1cf728')
GO
INSERT [dbo].[CTPX] ([MAPX], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PX03    ', N'M01 ', 5, 7000, N'80de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH01  ', CAST(N'2017-03-15' AS Date), N'CTY Điện máy xanh', 1, N'K1N1', N'74de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH02  ', CAST(N'2017-03-15' AS Date), N'Panasonic Corp.', 1, N'K1N1', N'75de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH03  ', CAST(N'2017-06-22' AS Date), N'Samsung Group', 11, N'K3N1', N'76de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH04  ', CAST(N'2017-08-26' AS Date), N'Sony Corp.', 5, N'K2N1', N'2144b48d-d62f-eb11-b610-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH05  ', CAST(N'2020-09-15' AS Date), N'Panasonic Corp.', 2, N'K2N2', N'7704c244-a72d-eb11-b60d-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH06  ', CAST(N'2017-11-07' AS Date), N'Square Enix Co.', 5, N'K3N1', N'56479b09-1130-eb11-b610-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH07  ', CAST(N'2018-01-12' AS Date), N'Samsung Group', 5, N'K5N1', N'40e62c4a-1130-eb11-b610-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH09  ', CAST(N'2018-04-27' AS Date), N'SK Hynix Inc.', 5, N'K4N1', N'382d3912-2a30-eb11-b610-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH10  ', CAST(N'2018-12-14' AS Date), N'LG Corp.', 13, N'K2N1', N'36279f2a-3c37-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH12  ', CAST(N'2019-02-18' AS Date), N'Samsung Group', 17, N'K4N1', N'a95e4156-3c37-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH13  ', CAST(N'2019-05-19' AS Date), N'Sony Corp.', 11, N'K3N1', N'e4fcfc70-3c37-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH14  ', CAST(N'2019-06-05' AS Date), N'Microsoft Corp.', 5, N'K4N1', N'51155025-2a30-eb11-b610-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH15  ', CAST(N'2020-11-12' AS Date), N'Samsung Group', 4, N'K1N2', N'cbd78b33-8431-eb11-b611-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH19  ', CAST(N'2019-10-28' AS Date), N'Riot Games, Inc.', 5, N'K4N1', N'24c81a93-ac30-eb11-b610-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH20  ', CAST(N'2020-11-24' AS Date), N'Dell Inc.', 2, N'K2N2', N'b626c632-8f31-eb11-b611-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH21  ', CAST(N'2020-03-04' AS Date), N'PTIT', 1, N'K5N1', N'8b763304-3736-eb11-b619-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH22  ', CAST(N'2020-05-18' AS Date), N'Dell Inc.', 3, N'K4N1', N'3c18f823-cf36-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH23  ', CAST(N'2020-09-05' AS Date), N'Apple Inc.', 9, N'K5N1', N'809fd962-d136-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH24  ', CAST(N'2020-12-07' AS Date), N'LG Corp.', 13, N'K6N1', N'eae30bd2-d236-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH25  ', CAST(N'2020-12-05' AS Date), N'SK Hynix Inc.', 4, N'K3N2', N'159e32d9-df36-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K1N1', N'Kho A1', N'11 Nguyễn Đình Chiểu, Đa Kao, Quận 1, TPHCM', N'CN1       ', N'66de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K1N2', N'LONG PHU', N'127 Ngô Thì Nhậm', N'CN2       ', N'6bde50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K2N1', N'Kho B1', N'999 Liên tỉnh lộ 25B, phường Thạnh Mỹ Lợi, Quận 2, TPHCM', N'CN1       ', N'67de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K2N2', N'KHO VT', N'23,Hoàng Diệu 2', N'CN2       ', N'69de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K3N1', N'Kho Công nghiệp', N'555 Trần Hưng đạo', N'CN1       ', N'65de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K3N2', N'KHO XD', N'34,Quang Trung THủ Đức TPHCM', N'CN2       ', N'6ade50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K4N1', N'Kho C1', N'134 Đình Phong Phú ,Quận 9,TPHCM', N'CN1       ', N'68de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K5N1', N'Kho D1', N'97 Đường Man Thiện, Hiệp Phú, Quận 9, TPHCM', N'CN1       ', N'19d5f0cc-542e-eb11-b60e-107d1a1cf728')
GO
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K6N1', N'Kho Q8', N'04 đường Dương Quang Đông, Phường 5, Quận 8, TPHCM', N'CN1       ', N'269893d8-fd32-eb11-b615-107d1a1cf728')
GO
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K7N1', N'Kho quản trị', N'387A Trường Chinh, Phường 14, Quận Tân Bình, TPHCM', N'CN1       ', N'e48ebc97-ff32-eb11-b615-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (1, N'Lương', N'Trang', N'Thủ Đức', CAST(N'2000-05-05T00:00:00.000' AS DateTime), 7000000, N'CN1       ', N'6cde50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (2, N'Nguyễn', N'Hà', N'Quận 9', CAST(N'2001-03-05T00:00:00.000' AS DateTime), 4000000, N'CN2       ', N'6dde50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (3, N'Trần', N'Thanh', N'Quận 10', CAST(N'1994-07-04T00:00:00.000' AS DateTime), 5000000, N'CN1       ', N'6ede50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (4, N'Hồ', N'Thái', N'Bình Thạnh', CAST(N'2001-02-05T00:00:00.000' AS DateTime), 6000000, N'CN2       ', N'70de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (5, N'Thái', N'Hà', N'Quận 6', CAST(N'2001-07-06T00:00:00.000' AS DateTime), 7000000, N'CN1       ', N'6fde50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (6, N'Lê', N'Trà', N'Phú Nhuận', CAST(N'1996-03-07T00:00:00.000' AS DateTime), 7000000, N'CN2       ', N'72de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (7, N'Hà', N'An', N'Gò Vấp', CAST(N'1996-04-06T00:00:00.000' AS DateTime), 5000000, N'CN1       ', N'71de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (9, N'Nguyễn', N'Trường', N'Quận 1', CAST(N'2000-07-07T00:00:00.000' AS DateTime), 9000000, N'CN1       ', N'12aaf8b9-1224-eb11-b5fd-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (11, N'Nguyễn', N'Hợp', N'Thủ Đức', CAST(N'1997-07-06T00:00:00.000' AS DateTime), 8000000, N'CN1       ', N'73de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (13, N'Lê', N'Huy', N'Đồng Nai', CAST(N'1999-08-10T00:00:00.000' AS DateTime), 9000000, N'CN1       ', N'bf458d2f-cc24-eb11-b5fe-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (17, N'Đinh', N'Ân', N'Quận 9', CAST(N'1999-04-04T00:00:00.000' AS DateTime), 6969969, N'CN1       ', N'53916109-1324-eb11-b5fd-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (19, N'Chu', N'An', N'Quận Bình Thạnh', CAST(N'1998-11-27T00:00:00.000' AS DateTime), 9600000, N'CN1       ', N'170ffea0-2036-eb11-b619-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (21, N'Phan', N'Trung', N'Quận 2', CAST(N'1989-02-26T00:00:00.000' AS DateTime), 6333333, N'CN1       ', N'877a8f22-4a36-eb11-b619-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (23, N'Nguyễn', N'Trang', N'Củ Chi', CAST(N'2001-07-14T00:00:00.000' AS DateTime), 9000000, N'CN1       ', N'13409b42-4a36-eb11-b619-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (25, N'Nguyễn', N'Vy', N'Đồng Nai', CAST(N'1999-04-22T00:00:00.000' AS DateTime), 11000000, N'CN1       ', N'1b429380-4a36-eb11-b619-107d1a1cf728')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (27, N'Phan', N'Bình', N'Phú Nhuận', CAST(N'1995-10-23T00:00:00.000' AS DateTime), 8500000, N'CN1       ', N'59f5dbb3-4a36-eb11-b619-107d1a1cf728')
GO
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN01    ', CAST(N'2017-03-18' AS Date), N'MDDH01  ', 1, N'K1N1', N'7ade50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN03    ', CAST(N'2017-06-26' AS Date), N'MDDH03  ', 3, N'K3N1', N'7bde50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN04    ', CAST(N'2017-08-30' AS Date), N'MDDH04  ', 5, N'K2N1', N'eebf4437-3637-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN05    ', CAST(N'2020-11-27' AS Date), N'MDDH05  ', 2, N'K2N2', N'ca089dc8-6c31-eb11-b611-107d1a1cf728')
GO
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN07    ', CAST(N'2018-01-21' AS Date), N'MDDH07  ', 5, N'K5N1', N'ca34566c-3e37-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN10    ', CAST(N'2018-12-17' AS Date), N'MDDH10  ', 13, N'K2N1', N'478146f4-4137-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN15    ', CAST(N'2020-11-28' AS Date), N'MDDH15  ', 4, N'K1N2', N'3f33cf41-8431-eb11-b611-107d1a1cf728')
GO
INSERT [dbo].[PhieuXuat] ([MAPX], [NGAY], [HOTENKH], [MANV], [MAKHO], [rowguid]) VALUES (N'PX01    ', CAST(N'2017-09-15' AS Date), N'Nguyễn Thị Ánh Hồng', 1, N'K1N1', N'77de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[PhieuXuat] ([MAPX], [NGAY], [HOTENKH], [MANV], [MAKHO], [rowguid]) VALUES (N'PX02    ', CAST(N'2017-09-15' AS Date), N'Trần Thị Mỹ Hà', 3, N'K3N1', N'78de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[PhieuXuat] ([MAPX], [NGAY], [HOTENKH], [MANV], [MAKHO], [rowguid]) VALUES (N'PX03    ', CAST(N'2017-09-15' AS Date), N'Trần Bích Phương', 6, N'K1N2', N'79de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[PhieuXuat] ([MAPX], [NGAY], [HOTENKH], [MANV], [MAKHO], [rowguid]) VALUES (N'PX04    ', CAST(N'2020-11-29' AS Date), N'Ricardo Milos', 2, N'K2N2', N'684966e7-4432-eb11-b614-107d1a1cf728')
GO
INSERT [dbo].[PhieuXuat] ([MAPX], [NGAY], [HOTENKH], [MANV], [MAKHO], [rowguid]) VALUES (N'PX05    ', CAST(N'2020-11-30' AS Date), N'Donald Trump', 5, N'K5N1', N'ca39620f-7832-eb11-b614-107d1a1cf728')
GO
INSERT [dbo].[PhieuXuat] ([MAPX], [NGAY], [HOTENKH], [MANV], [MAKHO], [rowguid]) VALUES (N'PX06    ', CAST(N'2020-11-30' AS Date), N'Joe Biden', 5, N'K3N1', N'ad3fcdb8-7932-eb11-b614-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'AP01', N'Apple AirPods Pro MWP22 VN/A', N'Cái', N'1be3d1b3-d833-eb11-b616-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'CC01', N'Cáp Type-C 1.5 m Sony CP-AC150', N'Cái', N'f8a43263-3737-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'CO04', N'Cốc "Lazy Day" Furyhorn', N'Cái', N'40f93569-d436-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'DG01', N'Đĩa Game PS4 Marvel''s Avengers', N'Cái', N'4cace18a-3837-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'DG02', N'Game Nintendo Swt Oct.Traveler', N'Cái', N'a01d4404-3937-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'DL02', N'Laptop Dell Inspiron 5593', N'Cái', N'9af0bfc2-d333-eb11-b616-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'DL03', N'Laptop Dell Gaming G3 3500', N'Cái', N'18d79ce0-d333-eb11-b616-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'FG02', N'League Champion Figures', N'Cái', N'60692226-d436-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'IC03', N'ICs H28S6D302BMR Sk Hynix', N'Cái', N'7dbeb3a1-4037-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'IM04', N'Apple iMac 2019 MRT32', N'Cái', N'78b60c64-d333-eb11-b616-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'IP01', N'Điện Thoại iPhone 12 Pro Max', N'Cái', N'08d71e86-2b2b-eb11-b60a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'LB01', N'Loa Bluetooth Sony SRS-XB43', N'Cái', N'8795c43f-3737-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'LB08', N'Loa Bluetooth JBL Charge 4 30W', N'Cái', N'76985dfb-d833-eb11-b616-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'LS02', N'Loa thanh Sony HT- G700', N'Cái', N'557acf23-3737-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'LV12', N'Lò Vi Sóng Hafele HW-F30A', N'Cái', N'e85efcc6-5e34-eb11-b617-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'MB01', N'Apple Macbook Pro 2020', N'Cái', N'13332f0d-d333-eb11-b616-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'MB14', N'M.Tính Bảng Samsung Galaxy S6', N'Cái', N'6f47c22f-3437-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'MC06', N'Máy Cạo Râu Panasonic ES3831', N'Cái', N'14ae5844-d636-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'ME01', N'Máy Ép Trái Cây Panasonic ', N'Cái', N'0253b601-d636-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'MG09', N'Máy Giặt Sấy LG Inverter 9 Kg', N'Cái', N'63e7dd36-5e34-eb11-b617-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'ML07', N'Máy Lạnh Inverter LG V24ENF', N'Cái', N'61de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'MNN3', N'Máy Nước Nóng Panasonic 4NS3V', N'Cái', N'b3afbef4-d636-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'MQ04', N'Máy quay phim SONY HDR-PJ440E', N'Cái', N'b05d8a83-3737-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'MS01', N'Máy Sấy Tóc Philips BHD002/00', N'Cái', N'62de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'MU06', N'Máy Uốn Tóc AUX HS-8088', N'Cái', N'63de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'OC01', N'Ổ Cứng SSD Samsung 860 500GB', N'Cái', N'c4cfe07f-3437-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'OC02', N'Ổ cứng SSD Hynix BC511 512GB', N'Cái', N'd2f8f323-4037-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'RA01', N'RAM Kingston HyperX Predator', N'Cái', N'b07d8fa2-d633-eb11-b616-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'RA02', N'RAM Laptop Hynix 16GB DDR4', N'Cái', N'36423750-ad30-eb11-b610-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'RA03', N'RAM Hynix 64GB DDR4 2933MHz', N'Cái', N'77898b43-4037-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'SDP1', N'Pin Sạc Dự Phòng Samsung EB-P1', N'Cái', N'4cbfe8f9-3337-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'SG20', N'Điện Thoại SS Galaxy Note 20', N'Cái', N'5284c66c-3337-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'TL03', N'Tủ lạnh LG SBS GR-D247JDS', N'Cái', N'60de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'TN03', N'Thẻ Nhớ Micro SD Samsung 32GB', N'Cái', N'c451065c-3437-eb11-b61a-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'TN05', N'Thẻ Nhớ Micro SDHC SanDisk 32G', N'Cái', N'b100ff57-d733-eb11-b616-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'TV01', N'Smart Tivi Samsung 4K 70 inch', N'Cái', N'06aa2cbb-d133-eb11-b616-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'TV05', N'Android Tivi Sony 4K 55 inch K', N'Cái', N'64de50db-ac0c-eb11-b5d6-107d1a1cf728')
GO
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'VS01', N'Điện thoại Vsmart Aris Pro', N'Cái', N'030594d5-2b2b-eb11-b60a-107d1a1cf728')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_ChiNhanh]    Script Date: 12/6/2020 12:55:48 PM ******/
ALTER TABLE [dbo].[ChiNhanh] ADD  CONSTRAINT [UK_ChiNhanh] UNIQUE NONCLUSTERED 
(
	[ChiNhanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_TENKHO]    Script Date: 12/6/2020 12:55:48 PM ******/
ALTER TABLE [dbo].[Kho] ADD  CONSTRAINT [UK_TENKHO] UNIQUE NONCLUSTERED 
(
	[TENKHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_MaSoDDH]    Script Date: 12/6/2020 12:55:48 PM ******/
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [UK_MaSoDDH] UNIQUE NONCLUSTERED 
(
	[MasoDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_TENVT]    Script Date: 12/6/2020 12:55:48 PM ******/
ALTER TABLE [dbo].[Vattu] ADD  CONSTRAINT [UK_TENVT] UNIQUE NONCLUSTERED 
(
	[TENVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiNhanh] ADD  CONSTRAINT [MSmerge_df_rowguid_31FEC67E4D704F8DA05CA9E2212BE570]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTDDH] ADD  CONSTRAINT [MSmerge_df_rowguid_7CD107C95AEB41D5917A99FFDE8EB831]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTPN] ADD  CONSTRAINT [MSmerge_df_rowguid_A0541A6688954DBE845FB7E332295B69]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTPX] ADD  CONSTRAINT [MSmerge_df_rowguid_09B77BDA543F4B37BC9D4B8628642830]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[DatHang] ADD  CONSTRAINT [DF_DatHang_MasoDDH]  DEFAULT (getdate()) FOR [MasoDDH]
GO
ALTER TABLE [dbo].[DatHang] ADD  CONSTRAINT [DF_DatHang_NGAY]  DEFAULT (getdate()) FOR [NGAY]
GO
ALTER TABLE [dbo].[DatHang] ADD  CONSTRAINT [MSmerge_df_rowguid_1E4E7D13BC5B4B58B2044036E6A45DC8]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[Kho] ADD  CONSTRAINT [MSmerge_df_rowguid_DABD69DD30384ECCA735C2AA210E8EFB]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [MSmerge_df_rowguid_CD59C912D18246CAA25D220300787F2F]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [DF_PhieuNhap_MAPN]  DEFAULT (getdate()) FOR [MAPN]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [DF_PhieuNhap_NGAY]  DEFAULT (getdate()) FOR [NGAY]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [MSmerge_df_rowguid_43EAE33342EE42DC91653F8844E13703]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[PhieuXuat] ADD  CONSTRAINT [DF_PX_NGAY]  DEFAULT (getdate()) FOR [NGAY]
GO
ALTER TABLE [dbo].[PhieuXuat] ADD  CONSTRAINT [MSmerge_df_rowguid_45156321A69C425487417C86DABA0DDA]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[Vattu] ADD  CONSTRAINT [MSmerge_df_rowguid_38EB0A98F6654002B25EF82C8AA5E787]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [FK_CTDDH_DatHang] FOREIGN KEY([MasoDDH])
REFERENCES [dbo].[DatHang] ([MasoDDH])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [FK_CTDDH_DatHang]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [FK_CTDDH_VatTu] FOREIGN KEY([MAVT])
REFERENCES [dbo].[Vattu] ([MAVT])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [FK_CTDDH_VatTu]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPN_PhieuNhap] FOREIGN KEY([MAPN])
REFERENCES [dbo].[PhieuNhap] ([MAPN])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [FK_CTPN_PhieuNhap]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPN_VatTu] FOREIGN KEY([MAVT])
REFERENCES [dbo].[Vattu] ([MAVT])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [FK_CTPN_VatTu]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPX_PX] FOREIGN KEY([MAPX])
REFERENCES [dbo].[PhieuXuat] ([MAPX])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [FK_CTPX_PX]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPX_VatTu] FOREIGN KEY([MAVT])
REFERENCES [dbo].[Vattu] ([MAVT])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [FK_CTPX_VatTu]
GO
ALTER TABLE [dbo].[DatHang]  WITH NOCHECK ADD  CONSTRAINT [FK_DatHang_Kho] FOREIGN KEY([MAKHO])
REFERENCES [dbo].[Kho] ([MAKHO])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_Kho]
GO
ALTER TABLE [dbo].[DatHang]  WITH NOCHECK ADD  CONSTRAINT [FK_DatHang_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_NhanVien]
GO
ALTER TABLE [dbo].[Kho]  WITH NOCHECK ADD  CONSTRAINT [FK_Kho_Kho] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_Kho]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChiNhanh]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH NOCHECK ADD  CONSTRAINT [FK_PhieuNhap_DatHang] FOREIGN KEY([MasoDDH])
REFERENCES [dbo].[DatHang] ([MasoDDH])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_DatHang]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH NOCHECK ADD  CONSTRAINT [FK_PhieuNhap_Kho] FOREIGN KEY([MAKHO])
REFERENCES [dbo].[Kho] ([MAKHO])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_Kho]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH NOCHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH NOCHECK ADD  CONSTRAINT [FK_PX_Kho] FOREIGN KEY([MAKHO])
REFERENCES [dbo].[Kho] ([MAKHO])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PX_Kho]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH NOCHECK ADD  CONSTRAINT [FK_PX_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PX_NhanVien]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [CK_DONGIA] CHECK NOT FOR REPLICATION (([DONGIA]>(0)))
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [CK_DONGIA]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [CK_SOLUONG] CHECK NOT FOR REPLICATION (([SOLUONG]>(0)))
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [CK_SOLUONG]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [CK_DONGIACTPN] CHECK NOT FOR REPLICATION (([DONGIA]>=(0)))
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [CK_DONGIACTPN]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [CK_SOLUONGCTPN] CHECK NOT FOR REPLICATION (([SOLUONG]>(0)))
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [CK_SOLUONGCTPN]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [CK_DONGIACTPX] CHECK NOT FOR REPLICATION (([DONGIA]>=(0)))
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [CK_DONGIACTPX]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [CK_SOLUONGCTPX] CHECK NOT FOR REPLICATION (([SOLUONG]>(0)))
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [CK_SOLUONGCTPX]
GO
ALTER TABLE [dbo].[NhanVien]  WITH NOCHECK ADD  CONSTRAINT [CK_LUONG] CHECK NOT FOR REPLICATION (([LUONG]>=(4000000)))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_LUONG]
GO
