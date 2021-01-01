CREATE TABLE [dbo].[GroupInformationHistory] (
    [id]                    INT            IDENTITY (1, 1) NOT NULL,
    [Gid_GroupId]           VARCHAR (45)   NOT NULL,
    [Gid_ConnectorId]       VARCHAR (20)   NOT NULL,
    [Gid_Type]              VARCHAR (45)   NOT NULL,
    [Gid_SeriesTitle]       VARCHAR (45)   NOT NULL,
    [Gid_SeriesId]          VARCHAR (15)   NOT NULL,
    [Gid_SeriesNumber]      VARCHAR (15)   NOT NULL,
    [Gid_SeriesCrid]        VARCHAR (45)   NOT NULL,
    [Gid_Synopsis]          NVARCHAR (MAX) NOT NULL,
    [Gid_Genres]            NVARCHAR (MAX) NULL,
    [Gid_Language]          VARCHAR (5)    NULL,
    [Gid_CreditsList]       NVARCHAR (MAX) NULL,
    [Gid_SeriesImages]      NVARCHAR (MAX) NOT NULL,
    [Gid_ProductionYear]    VARCHAR (45)   NULL,
    [Gid_RowChanges]        NVARCHAR (MAX) NULL,
    [Gid_ParentId]          INT            NOT NULL,
    [Gid_Action]            CHAR(1)        NOT NULL,
    [Gid_CreatedDateTime]   DATETIME       NOT NULL
    CONSTRAINT [PK_GroupInformationHistory] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_GroupInformationHistory_GroupInformationData] FOREIGN KEY ([Gid_ParentId]) REFERENCES [dbo].[GroupInformationData] ([Id])
);

