CREATE TABLE [dbo].[ProgramInformationData] (
    [id]                     INT            IDENTITY (1, 1) NOT NULL,
    [Pid_Crid]               VARCHAR (45)   NOT NULL,
    [Pid_TmsId]              VARCHAR (45)   NOT NULL,
    [Pid_RootId]             VARCHAR (45)   NOT NULL,
    [Pid_ImdbId]             VARCHAR (15)   NULL,
    [Pid_SeriesLink]         VARCHAR (45)   NULL,
    [Pid_EpisodeNumber]      VARCHAR (4)    NULL,
    [Pid_TitleMain]          VARCHAR (120)  NOT NULL,
    [Pid_EpisodeTitle]       VARCHAR (120)  NULL,
    [Pid_SynopsisShort]      VARCHAR (250)  NULL,
    [Pid_SynopsisMedium]     VARCHAR (500)  NULL,
    [Pid_SynopsisLong]       VARCHAR (1000) NULL,
    [Pid_ProgramGenres]      VARCHAR (1000) NULL,
    [Pid_ParentalGuidance]   NVARCHAR (MAX) NULL,
    [Pid_CreditsList]        NVARCHAR (MAX) NULL,
    [Pid_ProgramImages]      NVARCHAR (MAX) NOT NULL,
    [Pid_ProductionYear]     VARCHAR (4)    NULL,
    [Pid_ProductionLocation] VARCHAR (4)    NULL,
    [Pid_RowChanges]         NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_ProgramInformationData] PRIMARY KEY CLUSTERED ([Id] ASC)
);

