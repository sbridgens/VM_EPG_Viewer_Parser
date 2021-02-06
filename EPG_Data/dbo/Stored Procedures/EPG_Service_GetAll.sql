CREATE PROCEDURE [dbo].[EPG_Service_GetAll]
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
END
