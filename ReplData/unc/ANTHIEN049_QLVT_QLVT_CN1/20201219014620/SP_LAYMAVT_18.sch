drop Procedure [dbo].[SP_LAYMAVT]
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
CREATE PROCEDURE [dbo].[SP_LAYMAVT] 
@MAVTMOI nchar(4), @TENVTMOI nvarchar(30)
AS
BEGIN
    IF (EXISTS (select MAVT from Vattu WHERE MAVT = @MAVTMOI) AND EXISTS (select TENVT from Vattu WHERE TENVT = @TENVTMOI))
		SELECT 3;
	ELSE IF (NOT EXISTS (select MAVT from Vattu WHERE MAVT = @MAVTMOI) AND EXISTS (select TENVT from Vattu WHERE TENVT = @TENVTMOI))
		SELECT 2;
	ELSE IF (EXISTS (select MAVT from Vattu WHERE MAVT = @MAVTMOI) AND NOT EXISTS (select TENVT from Vattu WHERE TENVT = @TENVTMOI))
		SELECT 1;
	ELSE 
		SELECT 0;
END

go
