CREATE TABLE [dbo].[ServiceInformationData] (
    [Id]                    INT           IDENTITY (1, 1) NOT NULL,
    [Sid_ServiceName]       VARCHAR (45)  NULL,
    [Sid_VM_ServiceId]      VARCHAR (10)  NOT NULL,
    [Sid_Epg_ServiceId]     VARCHAR (10)  NOT NULL,
    [Sid_ServiceLogo]       VARCHAR (250) NOT NULL,
    [Sid_ChannelResolution] VARCHAR (3)   NOT NULL,
    [Sid_VM_ServiceGroup]   VARCHAR (250) NOT NULL,
    [Sid_RowChanges]        VARCHAR (45)  NULL,
    CONSTRAINT [PK_ServiceInformationData] PRIMARY KEY CLUSTERED ([Id] ASC)
);

