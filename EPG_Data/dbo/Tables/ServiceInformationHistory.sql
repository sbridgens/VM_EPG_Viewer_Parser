﻿CREATE TABLE [dbo].[ServiceInformationHistory] (
    [Id]                    INT           IDENTITY (1, 1) NOT NULL,
    [Sih_ServiceName]       VARCHAR (45)  NULL,
    [Sih_VM_ServiceId]      VARCHAR (10)  NOT NULL,
    [Sih_Epg_ServiceId]     VARCHAR (10)  NOT NULL,
    [Sih_ServiceLogo]       VARCHAR (250) NOT NULL,
    [Sih_ChannelResolution] VARCHAR (3)   NOT NULL,
    [Sih_VM_ServiceGroup]   VARCHAR (250) NOT NULL,
    [Sih_RowChanges]        VARCHAR (45)  NULL,
    [Sih_ParentId]          INT           NOT NULL,
    [Sih_Action]            CHAR(1)       NOT NULL,
    [Sih_CreatedDateTime]   DATETIME      NOT NULL
    CONSTRAINT [PK_ServiceInformationHistory] PRIMARY KEY CLUSTERED ([Id] ASC)
);

