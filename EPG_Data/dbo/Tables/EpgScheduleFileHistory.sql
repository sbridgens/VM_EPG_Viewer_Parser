CREATE TABLE [dbo].[EpgScheduleFileHistory] (
    [id]                   INT           IDENTITY (1, 1) NOT NULL,
    [EpgFilenameGZ]        VARCHAR (45)  NOT NULL,
    [EpgFilenameExtracted] VARCHAR (45)  NOT NULL,
    [EpgOriginalFileSize]  VARCHAR (10)  NOT NULL,
    [EpgExtractedFileSize] VARCHAR (10)  NOT NULL,
    [EpgDateTimeRetrieved] DATETIME2 (0) NOT NULL,
    [EpgDateTimeParsed]    DATETIME2 (0) NOT NULL,
    [EpgDateTimeArchived]  DATETIME2 (0) NOT NULL,
    [EpgArchiveLocation]   VARCHAR (45)  NOT NULL,
    CONSTRAINT [PK_EpgScheduleFileHistory] PRIMARY KEY CLUSTERED ([Id] ASC)
);

