USE [QLVT]
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 11/29/2020 5:23:32 PM ******/
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
/****** Object:  Table [dbo].[CTDDH]    Script Date: 11/29/2020 5:23:32 PM ******/
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
/****** Object:  Table [dbo].[CTPN]    Script Date: 11/29/2020 5:23:32 PM ******/
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
/****** Object:  Table [dbo].[CTPX]    Script Date: 11/29/2020 5:23:32 PM ******/
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
/****** Object:  Table [dbo].[DatHang]    Script Date: 11/29/2020 5:23:32 PM ******/
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
/****** Object:  Table [dbo].[Kho]    Script Date: 11/29/2020 5:23:32 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/29/2020 5:23:32 PM ******/
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
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 11/29/2020 5:23:32 PM ******/
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
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 11/29/2020 5:23:32 PM ******/
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
/****** Object:  Table [dbo].[Vattu]    Script Date: 11/29/2020 5:23:32 PM ******/
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
INSERT [dbo].[ChiNhanh] ([MACN], [ChiNhanh], [DIACHI], [SoDT], [rowguid]) VALUES (N'CN2       ', N'Chi nhánh 2 TP Cần Thơ', N'27 Nguyễn Huệ', N'333222111', N'5fde50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH01  ', N'L03 ', 11, 400001, N'3a4737bf-ac30-eb11-b610-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH01  ', N'M01 ', 10, 400000, N'7cde50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH01  ', N'MU01', 7, 500000, N'b1b7c686-e52f-eb11-b610-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH01  ', N'RH02', 1, 8000000000, N'26366ea6-de30-eb11-b610-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH02  ', N'MU01', 6, 500000, N'7dde50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH03  ', N'MX02', 20, 700000, N'7ede50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH04  ', N'M01 ', 1, 1000000, N'b41e7886-d730-eb11-b610-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH09  ', N'L03 ', 1, 10000000, N'2f53bccd-ac30-eb11-b610-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH09  ', N'M01 ', 2, 8000000, N'fa9b5ada-ac30-eb11-b610-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH09  ', N'MU01', 3, 300000, N'd3f0b1e3-ac30-eb11-b610-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH09  ', N'MX02', 4, 250000, N'c8864ff3-ac30-eb11-b610-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH09  ', N'MX07', 5, 12000000, N'db57a701-ad30-eb11-b610-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH09  ', N'RH02', 2, 1050000, N'6b0a0e5d-ad30-eb11-b610-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH09  ', N'TV02', 1, 40000000, N'20eefe0b-ad30-eb11-b610-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH09  ', N'V02 ', 7, 15000000, N'0b7b3d1a-ad30-eb11-b610-107d1a1cf728')
INSERT [dbo].[CTDDH] ([MasoDDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'MDDH19  ', N'MX07', 1, 1, N'0bb3b753-7631-eb11-b611-107d1a1cf728')
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN01    ', N'M01 ', 10, 500, N'81de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN03    ', N'MX02', 9, 800, N'eff1ef9a-972e-eb11-b60e-107d1a1cf728')
INSERT [dbo].[CTPX] ([MAPX], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PX01    ', N'MX02', 4, 5600, N'7fde50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[CTPX] ([MAPX], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PX02    ', N'TV02', 1, 9000, N'01afde9b-7b29-eb11-b604-107d1a1cf728')
INSERT [dbo].[CTPX] ([MAPX], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PX03    ', N'M01 ', 5, 7000, N'80de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH01  ', CAST(N'2017-09-15' AS Date), N'CTY Điện máy xanh', 1, N'K1N1', N'74de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH02  ', CAST(N'2017-09-15' AS Date), N'CTY Panasonic', 1, N'K1N1', N'75de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH03  ', CAST(N'2017-09-15' AS Date), N'CTY Samsung', 8, N'K3N1', N'76de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH04  ', CAST(N'2020-11-26' AS Date), N'Sony', 4, N'K2N1', N'2144b48d-d62f-eb11-b610-107d1a1cf728')
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH05  ', CAST(N'2020-09-15' AS Date), N'CTY Panasonic', 2, N'K2N2', N'7704c244-a72d-eb11-b60d-107d1a1cf728')
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH06  ', CAST(N'2020-11-25' AS Date), N'Square Enix', 4, N'K3N1', N'56479b09-1130-eb11-b610-107d1a1cf728')
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH07  ', CAST(N'2020-11-12' AS Date), N'Samsung', 4, N'K5N1', N'40e62c4a-1130-eb11-b610-107d1a1cf728')
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH09  ', CAST(N'2020-11-27' AS Date), N'Hynix', 4, N'K4N1', N'382d3912-2a30-eb11-b610-107d1a1cf728')
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH14  ', CAST(N'2020-11-27' AS Date), N'Microsoft', 4, N'K4N1', N'51155025-2a30-eb11-b610-107d1a1cf728')
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH15  ', CAST(N'2020-11-12' AS Date), N'Samsung', 5, N'K1N2', N'cbd78b33-8431-eb11-b611-107d1a1cf728')
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH19  ', CAST(N'2020-11-27' AS Date), N'Riot Games', 4, N'K4N1', N'24c81a93-ac30-eb11-b610-107d1a1cf728')
INSERT [dbo].[DatHang] ([MasoDDH], [NGAY], [NhaCC], [MANV], [MAKHO], [rowguid]) VALUES (N'MDDH20  ', CAST(N'2020-11-24' AS Date), N'Dell', 2, N'K2N2', N'b626c632-8f31-eb11-b611-107d1a1cf728')
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K1N1', N'KHO A', N'28-30 Ngô Quyền P1 Q5', N'CN1       ', N'66de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K1N2', N'LONG PHU', N'127 Ngô Thì Nhậm', N'CN2       ', N'6bde50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K2N1', N'KHO B', N'78 Nguyen Trai, TPHCM', N'CN1       ', N'67de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K2N2', N'KHO VT', N'23,Hoàng Diệu 2', N'CN2       ', N'69de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K3N1', N'CONG NGHIEP', N'555 Trần Hưng đạo', N'CN1       ', N'65de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K3N2', N'KHO XD', N'34,Quang Trung THủ Đức TPHCM', N'CN2       ', N'6ade50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K4N1', N'KHO HH', N'134 Đình Phong Phú ,Quận 9,TPHCM', N'CN1       ', N'68de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[Kho] ([MAKHO], [TENKHO], [DIACHI], [MACN], [rowguid]) VALUES (N'K5N1', N'KHO 5', N'Quận 9', N'CN1       ', N'19d5f0cc-542e-eb11-b60e-107d1a1cf728')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (1, N'Lương', N'Trang', N'Thủ Đức', CAST(N'2000-05-05T00:00:00.000' AS DateTime), 7000000, N'CN1       ', N'6cde50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (2, N'Nguyễn', N'Hà', N'Quận 9', CAST(N'2001-03-05T00:00:00.000' AS DateTime), 4000000, N'CN2       ', N'6dde50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (3, N'Trần', N'Thanh', N'Quận 10', CAST(N'1994-07-04T00:00:00.000' AS DateTime), 5000000, N'CN1       ', N'6ede50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (4, N'Thái', N'Hà', N'Quận 6', CAST(N'2001-07-06T00:00:00.000' AS DateTime), 7000000, N'CN1       ', N'6fde50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (5, N'Hồ', N'Thái', N'Bình Thạnh', CAST(N'2001-02-05T00:00:00.000' AS DateTime), 6000000, N'CN2       ', N'70de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (6, N'Hà', N'An', N'Gò Vấp', CAST(N'1996-04-06T00:00:00.000' AS DateTime), 5000000, N'CN1       ', N'71de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (7, N'Lê', N'Trà', N'Phú Nhuận', CAST(N'1996-03-07T00:00:00.000' AS DateTime), 7000000, N'CN2       ', N'72de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (8, N'Nguyễn', N'Hợp', N'Thủ Đức', CAST(N'1997-07-06T00:00:00.000' AS DateTime), 8000000, N'CN1       ', N'73de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (9, N'Nguyễn', N'Trường', N'Quận 1', CAST(N'2000-07-07T00:00:00.000' AS DateTime), 9000000, N'CN1       ', N'12aaf8b9-1224-eb11-b5fd-107d1a1cf728')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (10, N'Lê', N'Huy', N'Đồng Nai', CAST(N'1999-08-10T00:00:00.000' AS DateTime), 9000000, N'CN1       ', N'bf458d2f-cc24-eb11-b5fe-107d1a1cf728')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [rowguid]) VALUES (12, N'Đinh', N'Ân', N'Quận 9', CAST(N'1999-04-04T00:00:00.000' AS DateTime), 6969969, N'CN1       ', N'53916109-1324-eb11-b5fd-107d1a1cf728')
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN01    ', CAST(N'2017-09-15' AS Date), N'MDDH01  ', 1, N'K1N1', N'7ade50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN03    ', CAST(N'2017-09-15' AS Date), N'MDDH03  ', 3, N'K3N1', N'7bde50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN04    ', CAST(N'2020-11-27' AS Date), N'MDDH09  ', 4, N'K4N1', N'cba30a37-c930-eb11-b610-107d1a1cf728')
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN05    ', CAST(N'2020-11-27' AS Date), N'MDDH05  ', 2, N'K2N2', N'ca089dc8-6c31-eb11-b611-107d1a1cf728')
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN06    ', CAST(N'2020-11-27' AS Date), N'MDDH06  ', 4, N'K3N1', N'fa223ba9-c930-eb11-b610-107d1a1cf728')
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN07    ', CAST(N'2020-11-27' AS Date), N'MDDH07  ', 4, N'K5N1', N'a2fc0ec4-c930-eb11-b610-107d1a1cf728')
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN09    ', CAST(N'2020-11-28' AS Date), N'MDDH04  ', 4, N'K2N1', N'36ca9596-7031-eb11-b611-107d1a1cf728')
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN14    ', CAST(N'2020-11-27' AS Date), N'MDDH14  ', 4, N'K5N1', N'ce81449b-c930-eb11-b610-107d1a1cf728')
INSERT [dbo].[PhieuNhap] ([MAPN], [NGAY], [MasoDDH], [MANV], [MAKHO], [rowguid]) VALUES (N'PN15    ', CAST(N'2020-11-28' AS Date), N'MDDH15  ', 5, N'K1N2', N'3f33cf41-8431-eb11-b611-107d1a1cf728')
INSERT [dbo].[PhieuXuat] ([MAPX], [NGAY], [HOTENKH], [MANV], [MAKHO], [rowguid]) VALUES (N'PX01    ', CAST(N'2017-09-15' AS Date), N'Nguyễn Thị Ánh Hồng', 1, N'K1N1', N'77de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[PhieuXuat] ([MAPX], [NGAY], [HOTENKH], [MANV], [MAKHO], [rowguid]) VALUES (N'PX02    ', CAST(N'2017-09-15' AS Date), N'Trần Thị Mỹ Hà', 3, N'K3N1', N'78de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[PhieuXuat] ([MAPX], [NGAY], [HOTENKH], [MANV], [MAKHO], [rowguid]) VALUES (N'PX03    ', CAST(N'2017-09-15' AS Date), N'Trần Bích Phương', 7, N'K1N2', N'79de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'L03 ', N'Laptop Dell', N'Cái', N'08d71e86-2b2b-eb11-b60a-107d1a1cf728')
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'M01 ', N'Máy giặt tự động cửa trước', N'Cái', N'60de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'MU01', N'Máy uốn tóc', N'Cái', N'63de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'MX02', N'Máy sấy', N'Cái', N'62de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'MX07', N'Máy lạnh LG', N'Cái', N'61de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'RH02', N'RAM Hynix DDR4 8GB', N'Cái', N'36423750-ad30-eb11-b610-107d1a1cf728')
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'TV02', N'Ti vi Sam Sung', N'Cái', N'64de50db-ac0c-eb11-b5d6-107d1a1cf728')
INSERT [dbo].[Vattu] ([MAVT], [TENVT], [DVT], [rowguid]) VALUES (N'V02 ', N'Điện thoại Vsmart', N'Cái', N'030594d5-2b2b-eb11-b60a-107d1a1cf728')
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_ChiNhanh]    Script Date: 11/29/2020 5:23:32 PM ******/
ALTER TABLE [dbo].[ChiNhanh] ADD  CONSTRAINT [UK_ChiNhanh] UNIQUE NONCLUSTERED 
(
	[ChiNhanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_TENKHO]    Script Date: 11/29/2020 5:23:32 PM ******/
ALTER TABLE [dbo].[Kho] ADD  CONSTRAINT [UK_TENKHO] UNIQUE NONCLUSTERED 
(
	[TENKHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_MaSoDDH]    Script Date: 11/29/2020 5:23:32 PM ******/
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [UK_MaSoDDH] UNIQUE NONCLUSTERED 
(
	[MasoDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_TENVT]    Script Date: 11/29/2020 5:23:32 PM ******/
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
