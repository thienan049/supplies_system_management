drop Procedure [dbo].[SP_KEKHAINHAPXUATTHEOTHANG]
go

SET QUOTED_IDENTIFIER ON
go
SET ANSI_NULLS ON
go
CREATE PROCEDURE [dbo].[SP_KEKHAINHAPXUATTHEOTHANG] 
@NHOM nchar(2), @LOAI nchar(2), @THANGDAU Date, @THANGSAU Date
AS
BEGIN
IF(@NHOM = 'CT')
	IF(@LOAI = 'PN')
		SELECT CAST(RIGHT('0' + CONVERT(nvarchar(2), MONTH(NGAY)), 2) + '/1/' + CONVERT(nvarchar(4), YEAR(NGAY)) as Date) as THANG, TENVT, SUM(Soluong) as SOLUONG, Sum(soluong*dongia) as TRIGIA
		FROM PhieuNhap, Vattu, CTPN
		WHERE PhieuNhap.MAPN = CTPN.MAPN AND CTPN.MAVT = Vattu.MAVT 
		AND PhieuNhap.NGAY >= CAST(CONVERT(nvarchar(2), MONTH(@THANGDAU)) + '/1/' + CONVERT(nvarchar(4), YEAR(@THANGDAU)) as Date) AND PhieuNhap.NGAY <= EOMONTH(@THANGSAU)
		GROUP BY CAST(RIGHT('0' + CONVERT(nvarchar(2), MONTH(NGAY)), 2) + '/1/' + CONVERT(nvarchar(4), YEAR(NGAY)) as Date), TENVT		
		UNION ALL
		SELECT CAST(RIGHT('0' + CONVERT(nvarchar(2), MONTH(NGAY)), 2) + '/1/' + CONVERT(nvarchar(4), YEAR(NGAY)) as Date) as THANG, TENVT, SUM(Soluong) as SOLUONG, Sum(soluong*dongia) as TRIGIA
		FROM LINKEDSERVER.QLVT.dbo.PhieuNhap, LINKEDSERVER.QLVT.dbo.Vattu, LINKEDSERVER.QLVT.dbo.CTPN
		WHERE PhieuNhap.MAPN = CTPN.MAPN AND CTPN.MAVT = Vattu.MAVT 
		AND PhieuNhap.NGAY >= CAST(CONVERT(nvarchar(2), MONTH(@THANGDAU)) + '/1/' + CONVERT(nvarchar(4), YEAR(@THANGDAU)) as Date) AND PhieuNhap.NGAY <= EOMONTH(@THANGSAU)
		GROUP BY CAST(RIGHT('0' + CONVERT(nvarchar(2), MONTH(NGAY)), 2) + '/1/' + CONVERT(nvarchar(4), YEAR(NGAY)) as Date), TENVT
		ORDER BY THANG
	ELSE IF (@LOAI = 'PX')
		SELECT CAST(RIGHT('0' + CONVERT(nvarchar(2), MONTH(NGAY)), 2) + '/1/' + CONVERT(nvarchar(4), YEAR(NGAY)) as Date) as THANG, TENVT, SUM(Soluong) as SOLUONG, Sum(soluong*dongia) as TRIGIA
		FROM PhieuXuat, Vattu, CTPX
		WHERE PhieuXuat.MAPX = CTPX.MAPX AND CTPX.MAVT = Vattu.MAVT 
		AND PhieuXuat.NGAY >= CAST(CONVERT(nvarchar(2), MONTH(@THANGDAU)) + '/1/' + CONVERT(nvarchar(4), YEAR(@THANGDAU)) as Date) AND PhieuXuat.NGAY <= EOMONTH(@THANGSAU)
		GROUP BY CAST(RIGHT('0' + CONVERT(nvarchar(2), MONTH(NGAY)), 2) + '/1/' + CONVERT(nvarchar(4), YEAR(NGAY)) as Date), TENVT
		UNION ALL
		SELECT CAST(RIGHT('0' + CONVERT(nvarchar(2), MONTH(NGAY)), 2) + '/1/' + CONVERT(nvarchar(4), YEAR(NGAY)) as Date) as THANG, TENVT, SUM(Soluong) as SOLUONG, Sum(soluong*dongia) as TRIGIA
		FROM LINKEDSERVER.QLVT.dbo.PhieuXuat, LINKEDSERVER.QLVT.dbo.Vattu, LINKEDSERVER.QLVT.dbo.CTPX
		WHERE PhieuXuat.MAPX = CTPX.MAPX AND CTPX.MAVT = Vattu.MAVT 
		AND PhieuXuat.NGAY >= CAST(CONVERT(nvarchar(2), MONTH(@THANGDAU)) + '/1/' + CONVERT(nvarchar(4), YEAR(@THANGDAU)) as Date) AND PhieuXuat.NGAY <= EOMONTH(@THANGSAU)
		GROUP BY CAST(RIGHT('0' + CONVERT(nvarchar(2), MONTH(NGAY)), 2) + '/1/' + CONVERT(nvarchar(4), YEAR(NGAY)) as Date), TENVT
		ORDER BY THANG
IF (@NHOM = 'CN')
	IF(@LOAI = 'PN')
		SELECT CAST(RIGHT('0' + CONVERT(nvarchar(2), MONTH(NGAY)), 2) + '/1/' + CONVERT(nvarchar(4), YEAR(NGAY)) as Date) as THANG, TENVT, SUM(Soluong) as SOLUONG, Sum(soluong*dongia) as TRIGIA
		FROM PhieuNhap, Vattu, CTPN
		WHERE PhieuNhap.MAPN = CTPN.MAPN AND CTPN.MAVT = Vattu.MAVT 
		AND PhieuNhap.NGAY >= CAST(CONVERT(nvarchar(2), MONTH(@THANGDAU)) + '/1/' + CONVERT(nvarchar(4), YEAR(@THANGDAU)) as Date) AND PhieuNhap.NGAY <= EOMONTH(@THANGSAU)
		GROUP BY CAST(RIGHT('0' + CONVERT(nvarchar(2), MONTH(NGAY)), 2) + '/1/' + CONVERT(nvarchar(4), YEAR(NGAY)) as Date), TENVT
		ORDER BY THANG
		/*CAST(RIGHT('0' + CONVERT(nvarchar(2), MONTH(NGAY)), 2) + '/1/' + CONVERT(nvarchar(4), YEAR(NGAY)) as Date)*/
	ELSE IF (@LOAI = 'PX')
		SELECT CAST(RIGHT('0' + CONVERT(nvarchar(2), MONTH(NGAY)), 2) + '/1/' + CONVERT(nvarchar(4), YEAR(NGAY)) as Date) as THANG, TENVT, SUM(Soluong) as SOLUONG, Sum(soluong*dongia) as TRIGIA
		FROM PhieuXuat, Vattu, CTPX
		WHERE PhieuXuat.MAPX = CTPX.MAPX AND CTPX.MAVT = Vattu.MAVT 
		AND PhieuXuat.NGAY >= CAST(CONVERT(nvarchar(2), MONTH(@THANGDAU)) + '/1/' + CONVERT(nvarchar(4), YEAR(@THANGDAU)) as Date) AND PhieuXuat.NGAY <= EOMONTH(@THANGSAU)
		GROUP BY CAST(RIGHT('0' + CONVERT(nvarchar(2), MONTH(NGAY)), 2) + '/1/' + CONVERT(nvarchar(4), YEAR(NGAY)) as Date), TENVT
		ORDER BY THANG
END



go
