CREATE TABLE [dbo].[ProgramScheduleData] (
    [id]                     INT            IDENTITY (1, 1) NOT NULL,
    [Psd_ServiceIdReference] VARCHAR (10)   NOT NULL,
    [Psd_ScheduleStart]      DATETIME2 (0)  NOT NULL,
    [Psd_ScheduleEnd]        DATETIME2 (0)  NOT NULL,
    [Psd_ScheduleDuration]   VARCHAR (5)    NOT NULL,
    [Psd_ProgramCrid]        VARCHAR (45)   NOT NULL,
    [Psd_ProgramImi]         VARCHAR (20)   NOT NULL,
    [Psd_PurchaseList]       NVARCHAR (MAX) NULL,
    [Psd_CaptionLanguage]    VARCHAR (5)    NULL,
    [Psd_AV_Attributes]      NVARCHAR (MAX) NULL,
    [Psd_TmsId]              VARCHAR (20)   NOT NULL,
    [Psd_ScheduledStartTime] DATETIME2 (0)  NOT NULL,
    [Psd_ScheduledEndTime]   DATETIME2 (0)  NOT NULL,
    [Psd_EventDuration]      VARCHAR (10)   NOT NULL,
    [Psd_RowChange]          NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_ProgramScheduleData] PRIMARY KEY CLUSTERED ([Id] ASC)
);

