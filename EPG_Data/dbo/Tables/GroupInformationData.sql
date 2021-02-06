CREATE TABLE [dbo].[GroupInformationData] (
    [Id]                 INT            IDENTITY (1, 1) NOT NULL,
    [Gid_GroupId]        VARCHAR (45)   NOT NULL,
    [Gid_ConnectorId]    VARCHAR (20)   NOT NULL,
    [Gid_Type]           VARCHAR (45)   NOT NULL,
    [Gid_SeriesTitle]    VARCHAR (45)   NULL,
    [Gid_SeriesId]       VARCHAR (15)   NULL,
    [Gid_SeriesNumber]   VARCHAR (15)   NULL,
    [Gid_SeriesCrid]     VARCHAR (45)   NULL,
    [Gid_Synopsis]       NVARCHAR (MAX) NULL,
    [Gid_Genres]         NVARCHAR (MAX) NULL,
    [Gid_Language]       VARCHAR (5)    NULL,
    [Gid_CreditsList]    NVARCHAR (MAX) NULL,
    [Gid_SeriesImages]   NVARCHAR (MAX) NULL,
    [Gid_ProductionYear] VARCHAR (45)   NULL,
    [Gid_RowChanges]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_GroupInformationData] PRIMARY KEY CLUSTERED ([Id] ASC)
);

