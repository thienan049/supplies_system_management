drop Procedure [dbo].[SP_LAYTHONGTINVATTUDATHANG]
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
CREATE PROCEDURE [dbo].[SP_LAYTHONGTINVATTUDATHANG] 
@MADDH nchar(8)
AS
BEGIN
	SELECT CTDDH.MAVT, Vattu.TENVT, Vattu.DVT, CTDDH.SOLUONG, CTDDH.DONGIA
	FROM CTDDH INNER JOIN Vattu ON CTDDH.MAVT = Vattu.MAVT
	WHERE CTDDH.MasoDDH = @MADDH	
END


go
