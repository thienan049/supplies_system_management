drop View [dbo].[V_DS_ROLES]
go

SET QUOTED_IDENTIFIER ON
go
SET ANSI_NULLS ON
go


CREATE view [dbo].[V_DS_ROLES]
AS
	SELECT 'Công ty' as TEN, 'CONGTY' as GIATRI
	UNION
	SELECT 'Chi nhánh' , 'CHINHANH'
	UNION
	SELECT 'User', 'USER'

go
