USE [QLVT]
GO
/****** Object:  View [dbo].[V_DS_DDHCHUACOPN]    Script Date: 12/20/2020 5:24:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE view [dbo].[V_DS_DDHCHUACOPN]
AS
SELECT * FROM DatHang WHERE MasoDDH in
	(SELECT MasoDDH FROM DatHang EXCEPT SELECT MasoDDH FROM PhieuNhap)
GO
/****** Object:  View [dbo].[V_DS_DDHCHUACOPN_RP]    Script Date: 12/20/2020 5:24:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_DS_DDHCHUACOPN_RP]
AS
	SELECT DatHang.MasoDDH, DatHang.NGAY, DatHang.NhaCC, NV.HOTEN, VT.TENVT, CT.SOLUONG, CT.DONGIA
	FROM DatHang, (SELECT MANV, HO+ ' '+TEN as HOTEN FROM NhanVien) as NV, Vattu as VT, CTDDH as CT
	WHERE DatHang.MasoDDH in (SELECT MasoDDH FROM DatHang EXCEPT SELECT MasoDDH FROM PhieuNhap) AND DatHang.MANV = NV.MANV
	AND CT.MasoDDH = DatHang.MasoDDH AND VT.MAVT = CT.MAVT
GO
/****** Object:  View [dbo].[V_DS_PHANMANH]    Script Date: 12/20/2020 5:24:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [dbo].[V_DS_PHANMANH]
AS
SELECT TENCN=PUBS.description, TENSERVER=subscriber_server
FROM dbo.sysmergepublications PUBS, dbo.sysmergesubscriptions SUBS
WHERE PUBS.pubid=SUBS.PUBID AND PUBS.publisher <> SUBS.subscriber_server AND SUBS.status = 1
		AND PUBS.description <> 'CHI NHÁNH 3'
GO
/****** Object:  View [dbo].[V_DS_ROLES]    Script Date: 12/20/2020 5:24:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[V_DS_ROLES]
AS
	SELECT 'Công ty' as TEN, 'CONGTY' as GIATRI
	UNION
	SELECT 'Chi nhánh' , 'CHINHANH'
	UNION
	SELECT 'User', 'USER'
GO
