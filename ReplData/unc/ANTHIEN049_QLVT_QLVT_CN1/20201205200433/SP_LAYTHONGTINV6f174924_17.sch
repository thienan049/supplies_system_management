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
    SELECT * 
	FROM Vattu 
	WHERE Vattu.MAVT IN (SELECT MAVT FROM CTDDH WHERE CTDDH.MasoDDH = 'MDDH02')
END


go
