CREATE PROCEDURE [dbo].[EPG_Service_Filter]
	@Date DATE,
	@FilterText varchar(100)
AS 
BEGIN
SELECT [Id]
          ,[Sid_ServiceName]
          ,[Sid_VM_ServiceId]
          ,[Sid_Epg_ServiceId]
          ,[Sid_ServiceLogo]
          ,[Sid_ChannelResolution]
          ,[Sid_VM_ServiceGroup]
          ,[Sid_RowChanges]
    FROM [dbo].[ServiceInformationData]
	where Sid_Epg_ServiceId in (SELECT distinct Psd_ServiceIdReference FROM DBO.ProgramScheduleData WHERE CONVERT(DATE, Psd_ScheduledStartTime) = @Date and Psd_ProgramCrid in (
				select distinct Pid_Crid from DBo.ProgramInformationData where Pid_TitleMain like concat('%', @FilterText, '%')))
END
GO