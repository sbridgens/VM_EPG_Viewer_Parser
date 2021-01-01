CREATE TABLE [dbo].[ProgramScheduleHistory] (
    [id]                     INT            IDENTITY (1, 1) NOT NULL,
    [Psd_ServiceIdReference] VARCHAR (10)   NOT NULL,
    [Psd_ScheduleStart]      DATETIME       NOT NULL,
    [Psd_ScheduleEnd]        DATETIME       NOT NULL,
    [Psd_ScheduleDuration]   VARCHAR (5)    NOT NULL,
    [Psd_ProgramCrid]        VARCHAR (45)   NOT NULL,
    [Psd_ProgramImi]         VARCHAR (20)   NOT NULL,
    [Psd_PurchaseList]       NVARCHAR (MAX) NULL,
    [Psd_CaptionLanguage]    VARCHAR (5)    NULL,
    [Psd_AV_Attributes]      NVARCHAR (MAX) NULL,
    [Psd_TmsId]              VARCHAR (20)   NOT NULL,
    [Psd_ScheduledStartTime] DATETIME       NOT NULL,
    [Psd_ScheduledEndTime]   DATETIME       NOT NULL,
    [Psd_EventDuration]      VARCHAR (10)   NOT NULL,
    [Psd_RowChange]          NVARCHAR (MAX) NULL,
    [Psd_ParentId]           INT            NOT NULL,
    [Psd_Action]             CHAR(1)        NOT NULL,
    [Psd_CreatedDateTime]    DATETIME       NOT NULL
    CONSTRAINT [PK_ProgramScheduleHistory] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProgramScheduleHistory_ProgramScheduleData] FOREIGN KEY ([Psd_ParentId]) REFERENCES [dbo].[ProgramScheduleData] ([Id])
);

