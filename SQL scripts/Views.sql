USE [QLVT]
GO
/****** Object:  View [dbo].[V_DS_DDHCHUACOPN]    Script Date: 11/29/2020 5:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE view [dbo].[V_DS_DDHCHUACOPN]
AS
SELECT * FROM DatHang WHERE MasoDDH in
	(SELECT MasoDDH FROM DatHang EXCEPT SELECT MasoDDH FROM PhieuNhap)
GO
/****** Object:  View [dbo].[V_DS_PHANMANH]    Script Date: 11/29/2020 5:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [dbo].[V_DS_PHANMANH]
AS
SELECT TENCN=PUBS.description, TENSERVER=subscriber_server
FROM dbo.sysmergepublications PUBS, dbo.sysmergesubscriptions SUBS
WHERE PUBS.pubid=SUBS.PUBID AND PUBS.publisher <> SUBS.subscriber_server AND SUBS.status = 1
		AND PUBS.description <> 'CHI NHÁNH 3'
GO
