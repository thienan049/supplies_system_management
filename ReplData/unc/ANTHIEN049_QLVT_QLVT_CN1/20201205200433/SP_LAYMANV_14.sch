drop Procedure [dbo].[SP_LAYMANV]
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
CREATE PROCEDURE [dbo].[SP_LAYMANV] 
@MANVMOI int
AS
BEGIN
    IF (EXISTS (select MANV from LINKEDSERVER3.QLVT.dbo.NhanVien WHERE MANV = @MANVMOI AND MACN = 'CN1'))
		SELECT 1;
	IF (EXISTS (select MANV from LINKEDSERVER3.QLVT.dbo.NhanVien WHERE MANV = @MANVMOI AND MACN = 'CN2'))
		SELECT 2;
	ELSE
		SELECT 0;
END

go
