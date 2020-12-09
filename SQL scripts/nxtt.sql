USE [QLVT]
GO
/****** Object:  StoredProcedure [dbo].[SP_KEKHAINHAPXUATTHEOTHANG]    Script Date: 12/9/2020 7:16:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_KEKHAINHAPXUATTHEOTHANG] 
@LOAI nchar(2), @THANGDAU Date, @THANGSAU Date
AS
BEGIN
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


