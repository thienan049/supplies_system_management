drop Procedure [dbo].[SP_PHIEULAPTRONGNAMTHEOLOAI]
go

SET QUOTED_IDENTIFIER ON
go
SET ANSI_NULLS ON
go
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_PHIEULAPTRONGNAMTHEOLOAI]
	@LOAI char(2),  @NAM int
AS
BEGIN
	IF(@LOAI = 'PN')
		SELECT PvN.PHIEU, NGAY, TENVT, SOLUONG, DONGIA, TRIGIA = SOLUONG*DONGIA, NV.MANV, NV.HOTEN
		FROM(SELECT MANV, MAPN as PHIEU, NGAY FROM PhieuNhap WHERE YEAR(NGAY)=@NAM) as PvN, CTPN as CT, Vattu as VT,
			(SELECT MANV, HO+ ' '+TEN as HOTEN FROM NhanVien) as NV
		WHERE CT.MAPN = PvN.PHIEU AND CT.MAVT = VT.MAVT AND PvN.MANV = NV.MANV
		ORDER BY NGAY
	ELSE
		SELECT PvN.PHIEU, NGAY, TENVT, SOLUONG, DONGIA, TRIGIA = SOLUONG*DONGIA, NV.MANV, NV.HOTEN
		FROM(SELECT MANV, MAPX as PHIEU, NGAY FROM PhieuXuat WHERE YEAR(NGAY)=@NAM) as PvN, CTPX as CT, Vattu as VT,
			(SELECT MANV, HO+ ' '+TEN as HOTEN FROM NhanVien) as NV
		WHERE CT.MAPX = PvN.PHIEU AND CT.MAVT = VT.MAVT AND PvN.MANV = NV.MANV
		ORDER BY NGAY
END

go
