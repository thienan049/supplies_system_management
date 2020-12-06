drop Procedure [dbo].[SP_LAYMAPNPX]
go

SET QUOTED_IDENTIFIER ON
go
SET ANSI_NULLS ON
go
CREATE PROCEDURE [dbo].[SP_LAYMAPNPX] 
@LOAIPHIEU nchar(2), @MAPHIEUMOI nchar(8)
AS
BEGIN
	IF(@LOAIPHIEU = 'PN')
		IF (EXISTS (select MaPN from PhieuNhap WHERE MaPN = @MAPHIEUMOI))
			SELECT 1;
		ELSE IF (EXISTS (select MaPN from LINKEDSERVER.QLVT.dbo.PhieuNhap WHERE MaPN = @MAPHIEUMOI))
			SELECT 2;
		ELSE 
			SELECT 0;
	ELSE IF(@LOAIPHIEU = 'PX')
		IF (EXISTS (select MaPX from PhieuXuat WHERE MaPX = @MAPHIEUMOI))
			SELECT 1;
		ELSE IF (EXISTS (select MaPX from LINKEDSERVER.QLVT.dbo.PhieuXuat WHERE MaPX = @MAPHIEUMOI))
			SELECT 2;
		ELSE 
			SELECT 0;
END

go
