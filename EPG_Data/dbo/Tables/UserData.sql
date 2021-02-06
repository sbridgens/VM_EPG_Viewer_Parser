CREATE TABLE [dbo].[UserData] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [Ud_Username]       VARCHAR (100)  NOT NULL,
    [Ud_Email]          VARCHAR (250)   NOT NULL,
    [Ud_Firstname]       VARCHAR (100)  NOT NULL,
    [Ud_Lastname]       VARCHAR (100)  NOT NULL,
    [Ud_Password]       VARCHAR (MAX)  NOT NULL,
    [Ud_PasswordSalt]   VARCHAR (MAX)  NOT NULL,
    [Ud_IsActive]       BIT            NULL,
    [Ud_CreatedOn]      DATETIME   NULL,
    [Ud_UpdatedOn]      DATETIME   NULL
    CONSTRAINT [PK_UserData] PRIMARY KEY CLUSTERED ([Id] ASC)
);

