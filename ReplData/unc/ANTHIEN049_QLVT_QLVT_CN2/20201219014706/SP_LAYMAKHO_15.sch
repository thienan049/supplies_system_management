drop Procedure [dbo].[SP_LAYMAKHO]
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
CREATE PROCEDURE [dbo].[SP_LAYMAKHO] 
@MAKHOMOI nchar(4), @TENKHOMOI nvarchar(30)
AS
BEGIN
    IF (EXISTS (select MAKHO from LINKEDSERVER3.QLVT.dbo.Kho WHERE MAKHO = @MAKHOMOI) AND EXISTS (select TENKHO from LINKEDSERVER3.QLVT.dbo.Kho WHERE TENKHO = @TENKHOMOI))
		SELECT 3;
	ELSE IF (NOT EXISTS (select MAKHO from LINKEDSERVER3.QLVT.dbo.Kho WHERE MAKHO = @MAKHOMOI) AND EXISTS (select TENKHO from LINKEDSERVER3.QLVT.dbo.Kho WHERE TENKHO = @TENKHOMOI))
		SELECT 2;
	ELSE IF (EXISTS (select MAKHO from LINKEDSERVER3.QLVT.dbo.Kho WHERE MAKHO = @MAKHOMOI) AND NOT EXISTS (select TENKHO from LINKEDSERVER3.QLVT.dbo.Kho WHERE TENKHO = @TENKHOMOI))
		SELECT 1;
	ELSE 
		SELECT 0;
END

go
