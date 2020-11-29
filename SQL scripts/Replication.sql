/****** Scripting replication configuration. Script Date: 11/29/2020 5:10:10 PM ******/
/****** Please Note: For security reasons, all password parameters were scripted with either NULL or an empty string. ******/

/****** Begin: Script to be run at Publisher ******/

/****** Installing the server as a Distributor. Script Date: 11/29/2020 5:10:10 PM ******/
use master
exec sp_adddistributor @distributor = N'ANTHIEN049', @password = N''
GO

-- Adding the agent profiles
-- Updating the agent profile defaults
exec sp_MSupdate_agenttype_default @profile_id = 1
GO
exec sp_MSupdate_agenttype_default @profile_id = 2
GO
exec sp_MSupdate_agenttype_default @profile_id = 4
GO
exec sp_MSupdate_agenttype_default @profile_id = 6
GO
exec sp_MSupdate_agenttype_default @profile_id = 11
GO

-- Adding the distribution databases
use master
exec sp_adddistributiondb @database = N'distribution', @data_folder = N'D:\Docs\Apps\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\Data', @data_file = N'distribution.MDF', @data_file_size = 141, @log_folder = N'D:\Docs\Apps\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\Data', @log_file = N'distribution.LDF', @log_file_size = 73, @min_distretention = 0, @max_distretention = 72, @history_retention = 48, @deletebatchsize_xact = 5000, @deletebatchsize_cmd = 2000, @security_mode = 1
GO

-- Adding the distribution publishers
exec sp_adddistpublisher @publisher = N'ANTHIEN049', @distribution_db = N'distribution', @security_mode = 0, @login = N'sa', @password = N'', @working_directory = N'\\ANTHIEN049\ReplData', @trusted = N'false', @thirdparty_flag = 0, @publisher_type = N'MSSQLSERVER'
GO


/****** End: Script to be run at Publisher ******/


-- Enabling the replication database
use master
exec sp_replicationdboption @dbname = N'QLVT', @optname = N'merge publish', @value = N'true'
GO

-- Adding the merge publication
use [QLVT]
exec sp_addmergepublication @publication = N'QLVT_CN1', @description = N'CHI NHÁNH 1', @sync_mode = N'native', @retention = 14, @allow_push = N'true', @allow_pull = N'true', @allow_anonymous = N'true', @enabled_for_internet = N'false', @snapshot_in_defaultfolder = N'true', @compress_snapshot = N'false', @ftp_port = 21, @ftp_subdirectory = N'ftp', @ftp_login = N'anonymous', @allow_subscription_copy = N'false', @add_to_active_directory = N'false', @dynamic_filters = N'false', @conflict_retention = 14, @keep_partition_changes = N'false', @allow_synctoalternate = N'false', @max_concurrent_merge = 0, @max_concurrent_dynamic_snapshots = 0, @use_partition_groups = N'true', @publication_compatibility_level = N'100RTM', @replicate_ddl = 1, @allow_subscriber_initiated_snapshot = N'false', @allow_web_synchronization = N'false', @allow_partition_realignment = N'true', @retention_period_unit = N'days', @conflict_logging = N'both', @automatic_reinitialization_policy = 0
GO


exec sp_addpublication_snapshot @publication = N'QLVT_CN1', @frequency_type = 1, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 500, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0, @job_login = null, @job_password = null, @publisher_security_mode = 0, @publisher_login = N'sa', @publisher_password = N''
exec sp_grant_publication_access @publication = N'QLVT_CN1', @login = N'sa'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN1', @login = N'ANTHIEN049\Administrator'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN1', @login = N'NT SERVICE\Winmgmt'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN1', @login = N'NT SERVICE\SQLWriter'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN1', @login = N'NT SERVICE\SQLSERVERAGENT'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN1', @login = N'NT SERVICE\MSSQLSERVER'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN1', @login = N'distributor_admin'
GO

-- Adding the merge articles
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'ChiNhanh', @source_owner = N'dbo', @source_object = N'ChiNhanh', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'[MACN] =''CN1''', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'Vattu', @source_owner = N'dbo', @source_object = N'Vattu', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'Kho', @source_owner = N'dbo', @source_object = N'Kho', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'NhanVien', @source_owner = N'dbo', @source_object = N'NhanVien', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'DatHang', @source_owner = N'dbo', @source_object = N'DatHang', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'PhieuXuat', @source_owner = N'dbo', @source_object = N'PhieuXuat', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'PhieuNhap', @source_owner = N'dbo', @source_object = N'PhieuNhap', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'CTDDH', @source_owner = N'dbo', @source_object = N'CTDDH', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'CTPX', @source_owner = N'dbo', @source_object = N'CTPX', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'CTPN', @source_owner = N'dbo', @source_object = N'CTPN', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'SP_LAYMADDH', @source_owner = N'dbo', @source_object = N'SP_LAYMADDH', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_LAYMADDH', @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'SP_LAYMAKHO', @source_owner = N'dbo', @source_object = N'SP_LAYMAKHO', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_LAYMAKHO', @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'SP_LAYMANV', @source_owner = N'dbo', @source_object = N'SP_LAYMANV', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_LAYMANV', @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'SP_LAYMAPN', @source_owner = N'dbo', @source_object = N'SP_LAYMAPN', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_LAYMAPN', @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'SP_LAYMAVT', @source_owner = N'dbo', @source_object = N'SP_LAYMAVT', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_LAYMAVT', @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'SP_TAOTAIKHOAN', @source_owner = N'dbo', @source_object = N'SP_TAOTAIKHOAN', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_TAOTAIKHOAN', @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'SP_THONGTINDANGNHAP', @source_owner = N'dbo', @source_object = N'SP_THONGTINDANGNHAP', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_THONGTINDANGNHAP', @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN1', @article = N'V_DS_DDHCHUACOPN', @source_owner = N'dbo', @source_object = N'V_DS_DDHCHUACOPN', @type = N'view schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'V_DS_DDHCHUACOPN', @force_reinit_subscription = 1
GO

-- Adding the merge article join filters
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN1', @article = N'Kho', @filtername = N'Kho_ChiNhanh', @join_articlename = N'ChiNhanh', @join_filterclause = N'[ChiNhanh].[MACN] = [Kho].[MACN]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN1', @article = N'NhanVien', @filtername = N'NhanVien_ChiNhanh', @join_articlename = N'ChiNhanh', @join_filterclause = N'[ChiNhanh].[MACN] = [NhanVien].[MACN]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN1', @article = N'CTDDH', @filtername = N'CTDDH_DatHang', @join_articlename = N'DatHang', @join_filterclause = N'[DatHang].[MasoDDH] = [CTDDH].[MasoDDH]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN1', @article = N'DatHang', @filtername = N'DatHang_Kho', @join_articlename = N'Kho', @join_filterclause = N'[Kho].[MAKHO] = [DatHang].[MAKHO]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN1', @article = N'PhieuNhap', @filtername = N'PhieuNhap_Kho', @join_articlename = N'Kho', @join_filterclause = N'[Kho].[MAKHO] = [PhieuNhap].[MAKHO]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN1', @article = N'PhieuXuat', @filtername = N'PhieuXuat_Kho', @join_articlename = N'Kho', @join_filterclause = N'[Kho].[MAKHO] = [PhieuXuat].[MAKHO]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN1', @article = N'CTPN', @filtername = N'CTPN_PhieuNhap', @join_articlename = N'PhieuNhap', @join_filterclause = N'[PhieuNhap].[MAPN] = [CTPN].[MAPN]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN1', @article = N'CTPX', @filtername = N'CTPX_PhieuXuat', @join_articlename = N'PhieuXuat', @join_filterclause = N'[PhieuXuat].[MAPX] = [CTPX].[MAPX]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO

-- Adding the merge subscriptions
use [QLVT]
exec sp_addmergesubscription @publication = N'QLVT_CN1', @subscriber = N'ANTHIEN049\ANTHIEN049_1', @subscriber_db = N'QLVT', @subscription_type = N'Push', @sync_type = N'Automatic', @subscriber_type = N'Global', @subscription_priority = 75, @description = N'', @use_interactive_resolver = N'False'
exec sp_addmergepushsubscription_agent @publication = N'QLVT_CN1', @subscriber = N'ANTHIEN049\ANTHIEN049_1', @subscriber_db = N'QLVT', @job_login = null, @job_password = null, @subscriber_security_mode = 0, @subscriber_login = N'sa', @subscriber_password = null, @publisher_security_mode = 1, @frequency_type = 64, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 0, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0
GO

-- Adding the merge publication
use [QLVT]
exec sp_addmergepublication @publication = N'QLVT_CN2', @description = N'CHI NHÁNH 2', @sync_mode = N'native', @retention = 14, @allow_push = N'true', @allow_pull = N'true', @allow_anonymous = N'true', @enabled_for_internet = N'false', @snapshot_in_defaultfolder = N'true', @compress_snapshot = N'false', @ftp_port = 21, @ftp_subdirectory = N'ftp', @ftp_login = N'anonymous', @allow_subscription_copy = N'false', @add_to_active_directory = N'false', @dynamic_filters = N'false', @conflict_retention = 14, @keep_partition_changes = N'false', @allow_synctoalternate = N'false', @max_concurrent_merge = 0, @max_concurrent_dynamic_snapshots = 0, @use_partition_groups = N'true', @publication_compatibility_level = N'100RTM', @replicate_ddl = 1, @allow_subscriber_initiated_snapshot = N'false', @allow_web_synchronization = N'false', @allow_partition_realignment = N'true', @retention_period_unit = N'days', @conflict_logging = N'both', @automatic_reinitialization_policy = 0
GO


exec sp_addpublication_snapshot @publication = N'QLVT_CN2', @frequency_type = 1, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 500, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0, @job_login = null, @job_password = null, @publisher_security_mode = 0, @publisher_login = N'sa', @publisher_password = N''
exec sp_grant_publication_access @publication = N'QLVT_CN2', @login = N'sa'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN2', @login = N'ANTHIEN049\Administrator'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN2', @login = N'NT SERVICE\Winmgmt'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN2', @login = N'NT SERVICE\SQLWriter'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN2', @login = N'NT SERVICE\SQLSERVERAGENT'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN2', @login = N'NT SERVICE\MSSQLSERVER'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN2', @login = N'distributor_admin'
GO

-- Adding the merge articles
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'ChiNhanh', @source_owner = N'dbo', @source_object = N'ChiNhanh', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'[MACN] =''CN2''', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'Vattu', @source_owner = N'dbo', @source_object = N'Vattu', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'Kho', @source_owner = N'dbo', @source_object = N'Kho', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'NhanVien', @source_owner = N'dbo', @source_object = N'NhanVien', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'DatHang', @source_owner = N'dbo', @source_object = N'DatHang', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'PhieuXuat', @source_owner = N'dbo', @source_object = N'PhieuXuat', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'PhieuNhap', @source_owner = N'dbo', @source_object = N'PhieuNhap', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'CTDDH', @source_owner = N'dbo', @source_object = N'CTDDH', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'CTPX', @source_owner = N'dbo', @source_object = N'CTPX', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'CTPN', @source_owner = N'dbo', @source_object = N'CTPN', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'SP_LAYMADDH', @source_owner = N'dbo', @source_object = N'SP_LAYMADDH', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_LAYMADDH', @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'SP_LAYMAKHO', @source_owner = N'dbo', @source_object = N'SP_LAYMAKHO', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_LAYMAKHO', @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'SP_LAYMANV', @source_owner = N'dbo', @source_object = N'SP_LAYMANV', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_LAYMANV', @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'SP_LAYMAPN', @source_owner = N'dbo', @source_object = N'SP_LAYMAPN', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_LAYMAPN', @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'SP_LAYMAVT', @source_owner = N'dbo', @source_object = N'SP_LAYMAVT', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_LAYMAVT', @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'SP_TAOTAIKHOAN', @source_owner = N'dbo', @source_object = N'SP_TAOTAIKHOAN', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_TAOTAIKHOAN', @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'SP_THONGTINDANGNHAP', @source_owner = N'dbo', @source_object = N'SP_THONGTINDANGNHAP', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'SP_THONGTINDANGNHAP', @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN2', @article = N'V_DS_DDHCHUACOPN', @source_owner = N'dbo', @source_object = N'V_DS_DDHCHUACOPN', @type = N'view schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'V_DS_DDHCHUACOPN', @force_reinit_subscription = 1
GO

-- Adding the merge article join filters
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN2', @article = N'Kho', @filtername = N'Kho_ChiNhanh', @join_articlename = N'ChiNhanh', @join_filterclause = N'[ChiNhanh].[MACN] = [Kho].[MACN]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN2', @article = N'NhanVien', @filtername = N'NhanVien_ChiNhanh', @join_articlename = N'ChiNhanh', @join_filterclause = N'[ChiNhanh].[MACN] = [NhanVien].[MACN]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN2', @article = N'CTDDH', @filtername = N'CTDDH_DatHang', @join_articlename = N'DatHang', @join_filterclause = N'[DatHang].[MasoDDH] = [CTDDH].[MasoDDH]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN2', @article = N'DatHang', @filtername = N'DatHang_Kho', @join_articlename = N'Kho', @join_filterclause = N'[Kho].[MAKHO] = [DatHang].[MAKHO]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN2', @article = N'PhieuNhap', @filtername = N'PhieuNhap_Kho', @join_articlename = N'Kho', @join_filterclause = N'[Kho].[MAKHO] = [PhieuNhap].[MAKHO]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN2', @article = N'PhieuXuat', @filtername = N'PhieuXuat_Kho', @join_articlename = N'Kho', @join_filterclause = N'[Kho].[MAKHO] = [PhieuXuat].[MAKHO]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN2', @article = N'CTPN', @filtername = N'CTPN_PhieuNhap', @join_articlename = N'PhieuNhap', @join_filterclause = N'[PhieuNhap].[MAPN] = [CTPN].[MAPN]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLVT]
exec sp_addmergefilter @publication = N'QLVT_CN2', @article = N'CTPX', @filtername = N'CTPX_PhieuXuat', @join_articlename = N'PhieuXuat', @join_filterclause = N'[PhieuXuat].[MAPX] = [CTPX].[MAPX]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO

-- Adding the merge subscriptions
use [QLVT]
exec sp_addmergesubscription @publication = N'QLVT_CN2', @subscriber = N'ANTHIEN049\ANTHIEN049_2', @subscriber_db = N'QLVT', @subscription_type = N'Push', @sync_type = N'Automatic', @subscriber_type = N'Global', @subscription_priority = 75, @description = N'', @use_interactive_resolver = N'False'
exec sp_addmergepushsubscription_agent @publication = N'QLVT_CN2', @subscriber = N'ANTHIEN049\ANTHIEN049_2', @subscriber_db = N'QLVT', @job_login = null, @job_password = null, @subscriber_security_mode = 0, @subscriber_login = N'sa', @subscriber_password = null, @publisher_security_mode = 1, @frequency_type = 64, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 0, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0
GO

-- Adding the merge publication
use [QLVT]
exec sp_addmergepublication @publication = N'QLVT_CN3', @description = N'CHI NHÁNH 3', @sync_mode = N'native', @retention = 14, @allow_push = N'true', @allow_pull = N'true', @allow_anonymous = N'true', @enabled_for_internet = N'false', @snapshot_in_defaultfolder = N'true', @compress_snapshot = N'false', @ftp_port = 21, @ftp_subdirectory = N'ftp', @ftp_login = N'anonymous', @allow_subscription_copy = N'false', @add_to_active_directory = N'false', @dynamic_filters = N'false', @conflict_retention = 14, @keep_partition_changes = N'false', @allow_synctoalternate = N'false', @max_concurrent_merge = 0, @max_concurrent_dynamic_snapshots = 0, @use_partition_groups = N'false', @publication_compatibility_level = N'100RTM', @replicate_ddl = 1, @allow_subscriber_initiated_snapshot = N'false', @allow_web_synchronization = N'false', @allow_partition_realignment = N'true', @retention_period_unit = N'days', @conflict_logging = N'both', @automatic_reinitialization_policy = 0
GO


exec sp_addpublication_snapshot @publication = N'QLVT_CN3', @frequency_type = 1, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 500, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0, @job_login = null, @job_password = null, @publisher_security_mode = 0, @publisher_login = N'sa', @publisher_password = N''
exec sp_grant_publication_access @publication = N'QLVT_CN3', @login = N'sa'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN3', @login = N'ANTHIEN049\Administrator'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN3', @login = N'NT SERVICE\Winmgmt'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN3', @login = N'NT SERVICE\SQLWriter'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN3', @login = N'NT SERVICE\SQLSERVERAGENT'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN3', @login = N'NT SERVICE\MSSQLSERVER'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN3', @login = N'distributor_admin'
GO
exec sp_grant_publication_access @publication = N'QLVT_CN3', @login = N'test'
GO

-- Adding the merge articles
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN3', @article = N'Kho', @source_owner = N'dbo', @source_object = N'Kho', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLVT]
exec sp_addmergearticle @publication = N'QLVT_CN3', @article = N'NhanVien', @source_owner = N'dbo', @source_object = N'NhanVien', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'true', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
exec sp_mergearticlecolumn @publication = N'QLVT_CN3', @article = N'NhanVien', @column = N'MANV', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'QLVT_CN3', @article = N'NhanVien', @column = N'TEN', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'QLVT_CN3', @article = N'NhanVien', @column = N'MACN', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'QLVT_CN3', @article = N'NhanVien', @column = N'rowguid', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO

-- Adding the merge subscriptions
use [QLVT]
exec sp_addmergesubscription @publication = N'QLVT_CN3', @subscriber = N'ANTHIEN049\ANTHIEN049_3', @subscriber_db = N'QLVT', @subscription_type = N'Push', @sync_type = N'Automatic', @subscriber_type = N'Global', @subscription_priority = 75, @description = N'', @use_interactive_resolver = N'False'
exec sp_addmergepushsubscription_agent @publication = N'QLVT_CN3', @subscriber = N'ANTHIEN049\ANTHIEN049_3', @subscriber_db = N'QLVT', @job_login = null, @job_password = null, @subscriber_security_mode = 0, @subscriber_login = N'sa', @subscriber_password = null, @publisher_security_mode = 1, @frequency_type = 64, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 0, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0
GO



