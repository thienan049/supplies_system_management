USE [QLVT]
GO
/****** Object:  StoredProcedure [dbo].[SP_LAYMADDH]    Script Date: 11/29/2020 5:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LAYMADDH] 
@MASODDHMOI nchar(8)
AS
BEGIN
    IF (EXISTS (select MasoDDH from DatHang WHERE MasoDDH = @MASODDHMOI))
		SELECT 1;
	ELSE IF (EXISTS (select MasoDDH from LINKEDSERVER.QLVT.dbo.DatHang WHERE MasoDDH = @MASODDHMOI))
		SELECT 2;
	ELSE 
		SELECT 0;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_LAYMAKHO]    Script Date: 11/29/2020 5:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[SP_LAYMANV]    Script Date: 11/29/2020 5:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_LAYMANV] 
@MANVMOI int
AS
BEGIN
    IF (EXISTS (select MANV from LINKEDSERVER3.QLVT.dbo.NhanVien WHERE MANV = @MANVMOI))
		SELECT 1;
	else
		SELECT 0;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAYMAPN]    Script Date: 11/29/2020 5:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LAYMAPN] 
@MAPNMOI nchar(8)
AS
BEGIN
    IF (EXISTS (select MaPN from PhieuNhap WHERE MaPN = @MAPNMOI))
		SELECT 1;
	ELSE IF (EXISTS (select MaPN from LINKEDSERVER.QLVT.dbo.PhieuNhap WHERE MaPN = @MAPNMOI))
		SELECT 2;
	ELSE 
		SELECT 0;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_LAYMAVT]    Script Date: 11/29/2020 5:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOTAIKHOAN]    Script Date: 11/29/2020 5:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOTAIKHOAN]
    @LGNAME VARCHAR(50),  @PASS VARCHAR(50),
    @USERNAME VARCHAR(50),  @ROLE VARCHAR(50)     
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS, 'QLVT'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
  BEGIN
     RAISERROR ('Login name bị trùng', 16,1)
	 RETURN
  END 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RAISERROR ('Nhân viên đã có login name', 16,2)
       RETURN
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE= 'CONGTY' OR @ROLE= 'CHINHANH'
    EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
RETURN 0  -- THANH CONG
GO
/****** Object:  StoredProcedure [dbo].[SP_THONGTINDANGNHAP]    Script Date: 11/29/2020 5:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THONGTINDANGNHAP]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50), @UserId int
SELECT @UserId= UId ,@TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 SELECT USERNAME = @TENUSER, 
  HOTEN = (SELECT HO+ ' '+ TEN FROM dbo.NhanVien WHERE MANV = @TENUSER ),
   NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= @UserId
               )
GO
