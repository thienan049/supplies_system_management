drop View [dbo].[V_DS_DDHCHUACOPN]
go

SET QUOTED_IDENTIFIER ON
go
SET ANSI_NULLS ON
go




CREATE view [dbo].[V_DS_DDHCHUACOPN]
AS
SELECT * FROM DatHang WHERE MasoDDH in
	(SELECT MasoDDH FROM DatHang EXCEPT SELECT MasoDDH FROM PhieuNhap)

go
