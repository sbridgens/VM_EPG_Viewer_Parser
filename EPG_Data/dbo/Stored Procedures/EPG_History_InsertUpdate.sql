CREATE PROCEDURE [dbo].[EPG_History_InsertUpdate]
    @EpgFilenameGZ          VARCHAR (45),
    @EpgFilenameExtracted   VARCHAR (45),
    @EpgOriginalFileSize    VARCHAR (10),
    @EpgExtractedFileSize   VARCHAR (10),
    @EpgDateTimeRetrieved   DATETIME2,
    @EpgDateTimeParsed      DATETIME2,
    @EpgDateTimeArchived    DATETIME2,
    @EpgArchiveLocation     VARCHAR (45),
    @GroupInformationData   XML,
    @ProgramInformationData XML,
    @ProgramScheduleData    XML,
    @ServiceInformationData XML,
    @CurrentDateTime        DATETIME
AS
BEGIN
    INSERT INTO [dbo].[EpgScheduleFileHistory]
            ([EpgFilenameGZ]
            ,[EpgFilenameExtracted]
            ,[EpgOriginalFileSize]
            ,[EpgExtractedFileSize]
            ,[EpgDateTimeRetrieved]
            ,[EpgDateTimeParsed]
            ,[EpgDateTimeArchived]
            ,[EpgArchiveLocation])
        VALUES
            (@EpgFilenameGZ
            ,@EpgFilenameExtracted
            ,@EpgOriginalFileSize
            ,@EpgExtractedFileSize
            ,@EpgDateTimeRetrieved
            ,@EpgDateTimeParsed
            ,@EpgDateTimeArchived
            ,@EpgArchiveLocation);

	DECLARE @Id INT
    SET @Id = SCOPE_IDENTITY();

	DECLARE @pid int
    EXEC sp_xml_preparedocument @pid OUTPUT, @ProgramInformationData, '<root xmlns:mpeg7="urn:tva:mpeg7:2008" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns="urn:tva:metadata:2010" />';

	DECLARE @gid int
    EXEC sp_xml_preparedocument @gid OUTPUT, @GroupInformationData;

	DECLARE @psd int
    EXEC sp_xml_preparedocument @psd OUTPUT, @ProgramScheduleData;

	DECLARE @sid int
    EXEC sp_xml_preparedocument @sid OUTPUT, @ServiceInformationData;

	BEGIN TRANSACTION EPG_InsertUpdate
	BEGIN TRY 
		--Start ProgramInformationData insert/update/delete operation
        DELETE  Pid
        OUTPUT  
                 DELETED.[Pid_Crid]               
                ,DELETED.[Pid_TmsId]              
                ,DELETED.[Pid_RootId]             
                ,DELETED.[Pid_ImdbId]             
                ,DELETED.[Pid_SeriesLink]         
                ,DELETED.[Pid_EpisodeNumber]      
                ,DELETED.[Pid_TitleMain]          
                ,DELETED.[Pid_EpisodeTitle]       
                ,DELETED.[Pid_SynopsisShort]      
                ,DELETED.[Pid_SynopsisMedium]     
                ,DELETED.[Pid_SynopsisLong]       
                ,DELETED.[Pid_ProgramGenres]      
                ,DELETED.[Pid_ParentalGuidance]   
                ,DELETED.[Pid_CreditsList]        
                ,DELETED.[Pid_ProgramImages]      
                ,DELETED.[Pid_ProductionYear]     
                ,DELETED.[Pid_ProductionLocation] 
                ,DELETED.[Pid_RowChanges]         
                ,DELETED.[id]       AS [Pid_ParentId]        
                ,'D'                AS [Pid_Action]         
                ,@CurrentDateTime   AS [Pid_CreatedDateTime]   
        INTO    [ProgramInformationHistory]
        FROM    ProgramInformationData Pid
            LEFT JOIN   (
                        SELECT   [Pid_Crid]
                                ,[Pid_TmsId]
                                ,[Pid_RootId]
                                ,[Pid_ImdbId]
                                ,[Pid_SeriesLink]
                                ,[Pid_EpisodeNumber]
                                ,[Pid_TitleMain]
                                ,[Pid_EpisodeTitle]
                                ,[Pid_SynopsisShort]
                                ,[Pid_SynopsisMedium]
                                ,[Pid_SynopsisLong]
                                ,[Pid_ProgramGenres]
                                ,[Pid_ParentalGuidance]
                                ,[Pid_CreditsList]
                                ,[Pid_ProgramImages]
                                ,[Pid_ProductionYear]
                                ,[Pid_ProductionLocation]
                                ,[Pid_RowChanges]
	                    FROM OPENXML (@pid, 'ArrayOfProgramInformationDataEntities/ProgramInformationDataEntities',2)
	                    WITH (  [id]                     INT            ,
                                [Pid_Crid]               VARCHAR (45)   ,
                                [Pid_TmsId]              VARCHAR (45)   ,
                                [Pid_RootId]             VARCHAR (45)   ,
                                [Pid_ImdbId]             VARCHAR (15)   ,
                                [Pid_SeriesLink]         VARCHAR (45)   ,
                                [Pid_EpisodeNumber]      VARCHAR (4)    ,
                                [Pid_TitleMain]          VARCHAR (120)  ,
                                [Pid_EpisodeTitle]       VARCHAR (120)  ,
                                [Pid_SynopsisShort]      VARCHAR (250)  ,
                                [Pid_SynopsisMedium]     VARCHAR (500)  ,
                                [Pid_SynopsisLong]       VARCHAR (1000) ,
                                [Pid_ProgramGenres]      VARCHAR (1000) ,
                                [Pid_ParentalGuidance]   NVARCHAR (MAX) ,
                                [Pid_CreditsList]        NVARCHAR (MAX) ,
                                [Pid_ProgramImages]      NVARCHAR (MAX) ,
                                [Pid_ProductionYear]     VARCHAR (4)    ,
                                [Pid_ProductionLocation] VARCHAR (4)    ,
                                [Pid_RowChanges]         NVARCHAR (MAX) )
                        ) TPid ON TPid.Pid_Crid = Pid.Pid_Crid
        WHERE   TPid.Pid_Crid IS NULL

        UPDATE  Pid 
        SET     
                 [Pid_Crid]                 = TPid.[Pid_Crid]
                ,[Pid_TmsId]                = TPid.[Pid_TmsId]
                ,[Pid_RootId]               = TPid.[Pid_RootId]
                ,[Pid_ImdbId]               = TPid.[Pid_ImdbId]
                ,[Pid_SeriesLink]           = TPid.[Pid_SeriesLink]
                ,[Pid_EpisodeNumber]        = TPid.[Pid_EpisodeNumber]
                ,[Pid_TitleMain]            = TPid.[Pid_TitleMain]
                ,[Pid_EpisodeTitle]         = TPid.[Pid_EpisodeTitle]
                ,[Pid_SynopsisShort]        = TPid.[Pid_SynopsisShort]
                ,[Pid_SynopsisMedium]       = TPid.[Pid_SynopsisMedium]
                ,[Pid_SynopsisLong]         = TPid.[Pid_SynopsisLong]
                ,[Pid_ProgramGenres]        = TPid.[Pid_ProgramGenres]
                ,[Pid_ParentalGuidance]     = TPid.[Pid_ParentalGuidance]
                ,[Pid_CreditsList]          = TPid.[Pid_CreditsList]
                ,[Pid_ProgramImages]        = TPid.[Pid_ProgramImages]
                ,[Pid_ProductionYear]       = TPid.[Pid_ProductionYear]
                ,[Pid_ProductionLocation]   = TPid.[Pid_ProductionLocation]
                ,[Pid_RowChanges]           = TPid.[Pid_RowChanges]
        OUTPUT  
                 DELETED.[Pid_Crid]               
                ,DELETED.[Pid_TmsId]              
                ,DELETED.[Pid_RootId]             
                ,DELETED.[Pid_ImdbId]             
                ,DELETED.[Pid_SeriesLink]         
                ,DELETED.[Pid_EpisodeNumber]      
                ,DELETED.[Pid_TitleMain]          
                ,DELETED.[Pid_EpisodeTitle]       
                ,DELETED.[Pid_SynopsisShort]      
                ,DELETED.[Pid_SynopsisMedium]     
                ,DELETED.[Pid_SynopsisLong]       
                ,DELETED.[Pid_ProgramGenres]      
                ,DELETED.[Pid_ParentalGuidance]   
                ,DELETED.[Pid_CreditsList]        
                ,DELETED.[Pid_ProgramImages]      
                ,DELETED.[Pid_ProductionYear]     
                ,DELETED.[Pid_ProductionLocation] 
                ,DELETED.[Pid_RowChanges]         
                ,DELETED.[id]       AS [Pid_ParentId]        
                ,'U'                AS [Pid_Action]         
                ,@CurrentDateTime   AS [Pid_CreatedDateTime]   
        INTO    [ProgramInformationHistory]
        FROM ProgramInformationData Pid 
            INNER JOIN (
                        SELECT   [Pid_Crid]
                                ,[Pid_TmsId]
                                ,[Pid_RootId]
                                ,[Pid_ImdbId]
                                ,[Pid_SeriesLink]
                                ,[Pid_EpisodeNumber]
                                ,[Pid_TitleMain]
                                ,[Pid_EpisodeTitle]
                                ,[Pid_SynopsisShort]
                                ,[Pid_SynopsisMedium]
                                ,[Pid_SynopsisLong]
                                ,[Pid_ProgramGenres]
                                ,[Pid_ParentalGuidance]
                                ,[Pid_CreditsList]
                                ,[Pid_ProgramImages]
                                ,[Pid_ProductionYear]
                                ,[Pid_ProductionLocation]
                                ,[Pid_RowChanges]
	                    FROM OPENXML (@pid, 'ArrayOfProgramInformationDataEntities/ProgramInformationDataEntities',2)
	                    WITH (  [id]                     INT            ,
                                [Pid_Crid]               VARCHAR (45)   ,
                                [Pid_TmsId]              VARCHAR (45)   ,
                                [Pid_RootId]             VARCHAR (45)   ,
                                [Pid_ImdbId]             VARCHAR (15)   ,
                                [Pid_SeriesLink]         VARCHAR (45)   ,
                                [Pid_EpisodeNumber]      VARCHAR (4)    ,
                                [Pid_TitleMain]          VARCHAR (120)  ,
                                [Pid_EpisodeTitle]       VARCHAR (120)  ,
                                [Pid_SynopsisShort]      VARCHAR (250)  ,
                                [Pid_SynopsisMedium]     VARCHAR (500)  ,
                                [Pid_SynopsisLong]       VARCHAR (1000) ,
                                [Pid_ProgramGenres]      VARCHAR (1000) ,
                                [Pid_ParentalGuidance]   NVARCHAR (MAX) ,
                                [Pid_CreditsList]        NVARCHAR (MAX) ,
                                [Pid_ProgramImages]      NVARCHAR (MAX) ,
                                [Pid_ProductionYear]     VARCHAR (4)    ,
                                [Pid_ProductionLocation] VARCHAR (4)    ,
                                [Pid_RowChanges]         NVARCHAR (MAX) )
                        ) TPid 
                ON  TPid.Pid_Crid = Pid.Pid_Crid
                AND (
                            Pid.[Pid_TmsId]                != TPid.[Pid_TmsId]
                         OR Pid.[Pid_RootId]               != TPid.[Pid_RootId]
                         OR Pid.[Pid_ImdbId]               != TPid.[Pid_ImdbId]
                         OR Pid.[Pid_SeriesLink]           != TPid.[Pid_SeriesLink]
                         OR Pid.[Pid_EpisodeNumber]        != TPid.[Pid_EpisodeNumber]
                         OR Pid.[Pid_TitleMain]            != TPid.[Pid_TitleMain]
                         OR Pid.[Pid_EpisodeTitle]         != TPid.[Pid_EpisodeTitle]
                         OR Pid.[Pid_SynopsisShort]        != TPid.[Pid_SynopsisShort]
                         OR Pid.[Pid_SynopsisMedium]       != TPid.[Pid_SynopsisMedium]
                         OR Pid.[Pid_SynopsisLong]         != TPid.[Pid_SynopsisLong]
                         OR Pid.[Pid_ProgramGenres]        != TPid.[Pid_ProgramGenres]
                         OR Pid.[Pid_ParentalGuidance]     != TPid.[Pid_ParentalGuidance]
                         OR Pid.[Pid_CreditsList]          != TPid.[Pid_CreditsList]
                         OR Pid.[Pid_ProgramImages]        != TPid.[Pid_ProgramImages]
                         OR Pid.[Pid_ProductionYear]       != TPid.[Pid_ProductionYear]
                         OR Pid.[Pid_ProductionLocation]   != TPid.[Pid_ProductionLocation]
                         OR Pid.[Pid_RowChanges]           != TPid.[Pid_RowChanges]
                )

        INSERT INTO ProgramInformationData
                ([Pid_Crid]
                ,[Pid_TmsId]
                ,[Pid_RootId]
                ,[Pid_ImdbId]
                ,[Pid_SeriesLink]
                ,[Pid_EpisodeNumber]
                ,[Pid_TitleMain]
                ,[Pid_EpisodeTitle]
                ,[Pid_SynopsisShort]
                ,[Pid_SynopsisMedium]
                ,[Pid_SynopsisLong]
                ,[Pid_ProgramGenres]
                ,[Pid_ParentalGuidance]
                ,[Pid_CreditsList]
                ,[Pid_ProgramImages]
                ,[Pid_ProductionYear]
                ,[Pid_ProductionLocation]
                ,[Pid_RowChanges])
        SELECT   TPid.[Pid_Crid]
                ,TPid.[Pid_TmsId]
                ,TPid.[Pid_RootId]
                ,TPid.[Pid_ImdbId]
                ,TPid.[Pid_SeriesLink]
                ,TPid.[Pid_EpisodeNumber]
                ,TPid.[Pid_TitleMain]
                ,TPid.[Pid_EpisodeTitle]
                ,TPid.[Pid_SynopsisShort]
                ,TPid.[Pid_SynopsisMedium]
                ,TPid.[Pid_SynopsisLong]
                ,TPid.[Pid_ProgramGenres]
                ,TPid.[Pid_ParentalGuidance]
                ,TPid.[Pid_CreditsList]
                ,TPid.[Pid_ProgramImages]
                ,TPid.[Pid_ProductionYear]
                ,TPid.[Pid_ProductionLocation]
                ,TPid.[Pid_RowChanges]
	    FROM    (
                SELECT   [Pid_Crid]
                        ,[Pid_TmsId]
                        ,[Pid_RootId]
                        ,[Pid_ImdbId]
                        ,[Pid_SeriesLink]
                        ,[Pid_EpisodeNumber]
                        ,[Pid_TitleMain]
                        ,[Pid_EpisodeTitle]
                        ,[Pid_SynopsisShort]
                        ,[Pid_SynopsisMedium]
                        ,[Pid_SynopsisLong]
                        ,[Pid_ProgramGenres]
                        ,[Pid_ParentalGuidance]
                        ,[Pid_CreditsList]
                        ,[Pid_ProgramImages]
                        ,[Pid_ProductionYear]
                        ,[Pid_ProductionLocation]
                        ,[Pid_RowChanges]
	            FROM OPENXML (@pid, 'ArrayOfProgramInformationDataEntities/ProgramInformationDataEntities',2)
	            WITH (  [id]                     INT            ,
                        [Pid_Crid]               VARCHAR (45)   ,
                        [Pid_TmsId]              VARCHAR (45)   ,
                        [Pid_RootId]             VARCHAR (45)   ,
                        [Pid_ImdbId]             VARCHAR (15)   ,
                        [Pid_SeriesLink]         VARCHAR (45)   ,
                        [Pid_EpisodeNumber]      VARCHAR (4)    ,
                        [Pid_TitleMain]          VARCHAR (120)  ,
                        [Pid_EpisodeTitle]       VARCHAR (120)  ,
                        [Pid_SynopsisShort]      VARCHAR (250)  ,
                        [Pid_SynopsisMedium]     VARCHAR (500)  ,
                        [Pid_SynopsisLong]       VARCHAR (1000) ,
                        [Pid_ProgramGenres]      VARCHAR (1000) ,
                        [Pid_ParentalGuidance]   NVARCHAR (MAX) ,
                        [Pid_CreditsList]        NVARCHAR (MAX) ,
                        [Pid_ProgramImages]      NVARCHAR (MAX) ,
                        [Pid_ProductionYear]     VARCHAR (4)    ,
                        [Pid_ProductionLocation] VARCHAR (4)    ,
                        [Pid_RowChanges]         NVARCHAR (MAX) )
                ) TPid
            LEFT JOIN ProgramInformationData Pid ON TPid.Pid_Crid = Pid.Pid_Crid
        WHERE   Pid.Pid_Crid IS NULL

		--End ProgramInformationData insert/update/delete operation

		--Start GroupInformationData insert/update/delete operation
        DELETE  Gid
        OUTPUT   
                 DELETED.[Gid_GroupId]       
                ,DELETED.[Gid_ConnectorId]   
                ,DELETED.[Gid_Type]          
                ,DELETED.[Gid_SeriesTitle]   
                ,DELETED.[Gid_SeriesId]      
                ,DELETED.[Gid_SeriesNumber]  
                ,DELETED.[Gid_SeriesCrid]    
                ,DELETED.[Gid_Synopsis]      
                ,DELETED.[Gid_Genres]        
                ,DELETED.[Gid_Language]      
                ,DELETED.[Gid_CreditsList]   
                ,DELETED.[Gid_SeriesImages]  
                ,DELETED.[Gid_ProductionYear]
                ,DELETED.[Gid_RowChanges]    
                ,DELETED.[id]       AS [Gid_ParentId]        
                ,'D'                AS [Gid_Action]         
                ,@CurrentDateTime   AS [Gid_CreatedDateTime]   
        INTO    [GroupInformationHistory]
        FROM    GroupInformationData Gid
            LEFT JOIN   (
                        SELECT   [Gid_GroupId]       
                                ,[Gid_ConnectorId]   
                                ,[Gid_Type]          
                                ,[Gid_SeriesTitle]   
                                ,[Gid_SeriesId]      
                                ,[Gid_SeriesNumber]  
                                ,[Gid_SeriesCrid]    
                                ,[Gid_Synopsis]      
                                ,[Gid_Genres]        
                                ,[Gid_Language]      
                                ,[Gid_CreditsList]   
                                ,[Gid_SeriesImages]  
                                ,[Gid_ProductionYear]
                                ,[Gid_RowChanges]    
	                    FROM OPENXML (@gid, 'ArrayOfGroupInformationDataEntities/GroupInformationDataEntities',2)
	                    WITH (  
                                [id]                 INT            ,
                                [Gid_GroupId]        VARCHAR (45)   ,
                                [Gid_ConnectorId]    VARCHAR (20)   ,
                                [Gid_Type]           VARCHAR (45)   ,
                                [Gid_SeriesTitle]    VARCHAR (45)   ,
                                [Gid_SeriesId]       VARCHAR (15)   ,
                                [Gid_SeriesNumber]   VARCHAR (15)   ,
                                [Gid_SeriesCrid]     VARCHAR (45)   ,
                                [Gid_Synopsis]       NVARCHAR (MAX) ,
                                [Gid_Genres]         NVARCHAR (MAX) ,
                                [Gid_Language]       VARCHAR (5)    ,
                                [Gid_CreditsList]    NVARCHAR (MAX) ,
                                [Gid_SeriesImages]   NVARCHAR (MAX) ,
                                [Gid_ProductionYear] VARCHAR (45)   ,
                                [Gid_RowChanges]     NVARCHAR (MAX) 
                            )
                        ) TGid ON TGid.Gid_GroupId = Gid.Gid_GroupId
        WHERE   TGid.Gid_GroupId IS NULL

        UPDATE  Gid 
        SET    
                 [Gid_GroupId]          = TGid.[Gid_GroupId]
                ,[Gid_ConnectorId]      = TGid.[Gid_ConnectorId]
                ,[Gid_Type]             = TGid.[Gid_Type]
                ,[Gid_SeriesTitle]      = TGid.[Gid_SeriesTitle]
                ,[Gid_SeriesId]         = TGid.[Gid_SeriesId]
                ,[Gid_SeriesNumber]     = TGid.[Gid_SeriesNumber]
                ,[Gid_SeriesCrid]       = TGid.[Gid_SeriesCrid]
                ,[Gid_Synopsis]         = TGid.[Gid_Synopsis]
                ,[Gid_Genres]           = TGid.[Gid_Genres]
                ,[Gid_Language]         = TGid.[Gid_Language]
                ,[Gid_CreditsList]      = TGid.[Gid_CreditsList]
                ,[Gid_SeriesImages]     = TGid.[Gid_SeriesImages]
                ,[Gid_ProductionYear]   = TGid.[Gid_ProductionYear]
                ,[Gid_RowChanges]       = TGid.[Gid_RowChanges]        
        OUTPUT   
                 DELETED.[Gid_GroupId]       
                ,DELETED.[Gid_ConnectorId]   
                ,DELETED.[Gid_Type]          
                ,DELETED.[Gid_SeriesTitle]   
                ,DELETED.[Gid_SeriesId]      
                ,DELETED.[Gid_SeriesNumber]  
                ,DELETED.[Gid_SeriesCrid]    
                ,DELETED.[Gid_Synopsis]      
                ,DELETED.[Gid_Genres]        
                ,DELETED.[Gid_Language]      
                ,DELETED.[Gid_CreditsList]   
                ,DELETED.[Gid_SeriesImages]  
                ,DELETED.[Gid_ProductionYear]
                ,DELETED.[Gid_RowChanges]    
                ,DELETED.[id]       AS [Gid_ParentId]        
                ,'U'                AS [Gid_Action]         
                ,@CurrentDateTime   AS [Gid_CreatedDateTime]   
        INTO    [GroupInformationHistory]
        FROM GroupInformationData Gid 
            INNER JOIN  (
                            SELECT   [Gid_GroupId]       
                                    ,[Gid_ConnectorId]   
                                    ,[Gid_Type]          
                                    ,[Gid_SeriesTitle]   
                                    ,[Gid_SeriesId]      
                                    ,[Gid_SeriesNumber]  
                                    ,[Gid_SeriesCrid]    
                                    ,[Gid_Synopsis]      
                                    ,[Gid_Genres]        
                                    ,[Gid_Language]      
                                    ,[Gid_CreditsList]   
                                    ,[Gid_SeriesImages]  
                                    ,[Gid_ProductionYear]
                                    ,[Gid_RowChanges]    
	                        FROM OPENXML (@gid, 'ArrayOfGroupInformationDataEntities/GroupInformationDataEntities',2)
	                        WITH (  
                                    [id]                 INT            ,
                                    [Gid_GroupId]        VARCHAR (45)   ,
                                    [Gid_ConnectorId]    VARCHAR (20)   ,
                                    [Gid_Type]           VARCHAR (45)   ,
                                    [Gid_SeriesTitle]    VARCHAR (45)   ,
                                    [Gid_SeriesId]       VARCHAR (15)   ,
                                    [Gid_SeriesNumber]   VARCHAR (15)   ,
                                    [Gid_SeriesCrid]     VARCHAR (45)   ,
                                    [Gid_Synopsis]       NVARCHAR (MAX) ,
                                    [Gid_Genres]         NVARCHAR (MAX) ,
                                    [Gid_Language]       VARCHAR (5)    ,
                                    [Gid_CreditsList]    NVARCHAR (MAX) ,
                                    [Gid_SeriesImages]   NVARCHAR (MAX) ,
                                    [Gid_ProductionYear] VARCHAR (45)   ,
                                    [Gid_RowChanges]     NVARCHAR (MAX) 
                                )
                        ) TGid 
                ON  TGid.Gid_GroupId = Gid.Gid_GroupId
                AND (
                           Gid.[Gid_ConnectorId]        != TGid.[Gid_ConnectorId]
                        OR Gid.[Gid_Type]               != TGid.[Gid_Type]
                        OR Gid.[Gid_SeriesTitle]        != TGid.[Gid_SeriesTitle]
                        OR Gid.[Gid_SeriesId]           != TGid.[Gid_SeriesId]
                        OR Gid.[Gid_SeriesNumber]       != TGid.[Gid_SeriesNumber]
                        OR Gid.[Gid_SeriesCrid]         != TGid.[Gid_SeriesCrid]
                        OR Gid.[Gid_Synopsis]           != TGid.[Gid_Synopsis]
                        OR Gid.[Gid_Genres]             != TGid.[Gid_Genres]
                        OR Gid.[Gid_Language]           != TGid.[Gid_Language]
                        OR Gid.[Gid_CreditsList]        != TGid.[Gid_CreditsList]
                        OR Gid.[Gid_SeriesImages]       != TGid.[Gid_SeriesImages]
                        OR Gid.[Gid_ProductionYear]     != TGid.[Gid_ProductionYear]
                        OR Gid.[Gid_RowChanges]         != TGid.[Gid_RowChanges]        
                    )

        INSERT INTO GroupInformationData
                ([Gid_GroupId]       
                ,[Gid_ConnectorId]   
                ,[Gid_Type]          
                ,[Gid_SeriesTitle]   
                ,[Gid_SeriesId]      
                ,[Gid_SeriesNumber]  
                ,[Gid_SeriesCrid]    
                ,[Gid_Synopsis]      
                ,[Gid_Genres]        
                ,[Gid_Language]      
                ,[Gid_CreditsList]   
                ,[Gid_SeriesImages]  
                ,[Gid_ProductionYear]
                ,[Gid_RowChanges]    )
        SELECT   TGid.[Gid_GroupId]       
                ,TGid.[Gid_ConnectorId]   
                ,TGid.[Gid_Type]          
                ,TGid.[Gid_SeriesTitle]   
                ,TGid.[Gid_SeriesId]      
                ,TGid.[Gid_SeriesNumber]  
                ,TGid.[Gid_SeriesCrid]    
                ,TGid.[Gid_Synopsis]      
                ,TGid.[Gid_Genres]        
                ,TGid.[Gid_Language]      
                ,TGid.[Gid_CreditsList]   
                ,TGid.[Gid_SeriesImages]  
                ,TGid.[Gid_ProductionYear]
                ,TGid.[Gid_RowChanges]    
	    FROM    (
                    SELECT   [Gid_GroupId]       
                            ,[Gid_ConnectorId]   
                            ,[Gid_Type]          
                            ,[Gid_SeriesTitle]   
                            ,[Gid_SeriesId]      
                            ,[Gid_SeriesNumber]  
                            ,[Gid_SeriesCrid]    
                            ,[Gid_Synopsis]      
                            ,[Gid_Genres]        
                            ,[Gid_Language]      
                            ,[Gid_CreditsList]   
                            ,[Gid_SeriesImages]  
                            ,[Gid_ProductionYear]
                            ,[Gid_RowChanges]    
	                FROM OPENXML (@gid, 'ArrayOfGroupInformationDataEntities/GroupInformationDataEntities',2)
	                WITH (  
                            [id]                 INT            ,
                            [Gid_GroupId]        VARCHAR (45)   ,
                            [Gid_ConnectorId]    VARCHAR (20)   ,
                            [Gid_Type]           VARCHAR (45)   ,
                            [Gid_SeriesTitle]    VARCHAR (45)   ,
                            [Gid_SeriesId]       VARCHAR (15)   ,
                            [Gid_SeriesNumber]   VARCHAR (15)   ,
                            [Gid_SeriesCrid]     VARCHAR (45)   ,
                            [Gid_Synopsis]       NVARCHAR (MAX) ,
                            [Gid_Genres]         NVARCHAR (MAX) ,
                            [Gid_Language]       VARCHAR (5)    ,
                            [Gid_CreditsList]    NVARCHAR (MAX) ,
                            [Gid_SeriesImages]   NVARCHAR (MAX) ,
                            [Gid_ProductionYear] VARCHAR (45)   ,
                            [Gid_RowChanges]     NVARCHAR (MAX) 
                        )
                ) TGid
            LEFT JOIN GroupInformationData Gid ON TGid.Gid_GroupId = Gid.Gid_GroupId
        WHERE   Gid.Gid_GroupId IS NULL

		--End GroupInformationData insert/update/delete operation

		--Start ProgramScheduleData insert/update/delete operation
        DELETE  Psd 
        OUTPUT   
                 DELETED.[Psd_ServiceIdReference] 
                ,DELETED.[Psd_ScheduleStart]      
                ,DELETED.[Psd_ScheduleEnd]        
                ,DELETED.[Psd_ScheduleDuration]   
                ,DELETED.[Psd_ProgramCrid]        
                ,DELETED.[Psd_ProgramImi]         
                ,DELETED.[Psd_PurchaseList]       
                ,DELETED.[Psd_CaptionLanguage]    
                ,DELETED.[Psd_AV_Attributes]      
                ,DELETED.[Psd_TmsId]              
                ,DELETED.[Psd_ScheduledStartTime] 
                ,DELETED.[Psd_ScheduledEndTime]   
                ,DELETED.[Psd_EventDuration]      
                ,DELETED.[Psd_RowChange]          
                ,DELETED.[id]       AS [Psd_ParentId]        
                ,'D'                AS [Psd_Action]         
                ,@CurrentDateTime   AS [Psd_CreatedDateTime]   
        INTO    [ProgramScheduleHistory]
        FROM ProgramScheduleData Psd
            LEFT JOIN   (
                            SELECT   
                                     [Psd_ServiceIdReference] 
                                    ,[Psd_ScheduleStart]      
                                    ,[Psd_ScheduleEnd]        
                                    ,[Psd_ScheduleDuration]   
                                    ,[Psd_ProgramCrid]        
                                    ,[Psd_ProgramImi]         
                                    ,[Psd_PurchaseList]       
                                    ,[Psd_CaptionLanguage]    
                                    ,[Psd_AV_Attributes]      
                                    ,[Psd_TmsId]              
                                    ,[Psd_ScheduledStartTime] 
                                    ,[Psd_ScheduledEndTime]   
                                    ,[Psd_EventDuration]      
                                    ,[Psd_RowChange]          
	                        FROM OPENXML (@psd, 'ArrayOfProgramScheduleDataEntities/ProgramScheduleDataEntities',2)
	                        WITH (  
                                    [id]                     INT           ,
                                    [Psd_ServiceIdReference] VARCHAR (10)  ,
                                    [Psd_ScheduleStart]      DATETIME      ,
                                    [Psd_ScheduleEnd]        DATETIME      ,
                                    [Psd_ScheduleDuration]   VARCHAR (5)   ,
                                    [Psd_ProgramCrid]        VARCHAR (45)  ,
                                    [Psd_ProgramImi]         VARCHAR (20)  ,
                                    [Psd_PurchaseList]       NVARCHAR (MAX),
                                    [Psd_CaptionLanguage]    VARCHAR (5)   ,
                                    [Psd_AV_Attributes]      NVARCHAR (MAX),
                                    [Psd_TmsId]              VARCHAR (20)  ,
                                    [Psd_ScheduledStartTime] DATETIME      ,
                                    [Psd_ScheduledEndTime]   DATETIME      ,
                                    [Psd_EventDuration]      VARCHAR (10)  ,
                                    [Psd_RowChange]          NVARCHAR (MAX)
                                )
                        ) TPsd 
                ON  TPsd.[Psd_ServiceIdReference]   = Psd.[Psd_ServiceIdReference]
                AND TPsd.[Psd_ProgramCrid]          = Psd.[Psd_ProgramCrid]
                AND TPsd.[Psd_ProgramImi]           = Psd.[Psd_ProgramImi]
                AND TPsd.[Psd_ScheduleStart]        = Psd.[Psd_ScheduleStart]
                AND TPsd.[Psd_ScheduleEnd]          = Psd.[Psd_ScheduleEnd]
                AND TPsd.[Psd_ScheduledStartTime]   = Psd.[Psd_ScheduledStartTime]
                AND TPsd.[Psd_ScheduledEndTime]     = Psd.[Psd_ScheduledEndTime]
        WHERE   TPsd.[Psd_ServiceIdReference] IS NULL

        UPDATE  Psd 
        SET    
                 [Psd_ServiceIdReference]       = TPsd.[Psd_ServiceIdReference]
                ,[Psd_ScheduleStart]            = TPsd.[Psd_ScheduleStart]
                ,[Psd_ScheduleEnd]              = TPsd.[Psd_ScheduleEnd]
                ,[Psd_ScheduleDuration]         = TPsd.[Psd_ScheduleDuration]
                ,[Psd_ProgramCrid]              = TPsd.[Psd_ProgramCrid]
                ,[Psd_ProgramImi]               = TPsd.[Psd_ProgramImi]
                ,[Psd_PurchaseList]             = TPsd.[Psd_PurchaseList]
                ,[Psd_CaptionLanguage]          = TPsd.[Psd_CaptionLanguage]
                ,[Psd_AV_Attributes]            = TPsd.[Psd_AV_Attributes]
                ,[Psd_TmsId]                    = TPsd.[Psd_TmsId]
                ,[Psd_ScheduledStartTime]       = TPsd.[Psd_ScheduledStartTime]
                ,[Psd_ScheduledEndTime]         = TPsd.[Psd_ScheduledEndTime]
                ,[Psd_EventDuration]            = TPsd.[Psd_EventDuration]
                ,[Psd_RowChange]                = TPsd.[Psd_RowChange]
        OUTPUT   
                 DELETED.[Psd_ServiceIdReference] 
                ,DELETED.[Psd_ScheduleStart]      
                ,DELETED.[Psd_ScheduleEnd]        
                ,DELETED.[Psd_ScheduleDuration]   
                ,DELETED.[Psd_ProgramCrid]        
                ,DELETED.[Psd_ProgramImi]         
                ,DELETED.[Psd_PurchaseList]       
                ,DELETED.[Psd_CaptionLanguage]    
                ,DELETED.[Psd_AV_Attributes]      
                ,DELETED.[Psd_TmsId]              
                ,DELETED.[Psd_ScheduledStartTime] 
                ,DELETED.[Psd_ScheduledEndTime]   
                ,DELETED.[Psd_EventDuration]      
                ,DELETED.[Psd_RowChange]          
                ,DELETED.[id]       AS [Psd_ParentId]        
                ,'U'                AS [Psd_Action]         
                ,@CurrentDateTime   AS [Psd_CreatedDateTime]   
        INTO    [ProgramScheduleHistory]
        FROM ProgramScheduleData Psd 
            INNER JOIN  (
                            SELECT   
                                     [Psd_ServiceIdReference] 
                                    ,[Psd_ScheduleStart]      
                                    ,[Psd_ScheduleEnd]        
                                    ,[Psd_ScheduleDuration]   
                                    ,[Psd_ProgramCrid]        
                                    ,[Psd_ProgramImi]         
                                    ,[Psd_PurchaseList]       
                                    ,[Psd_CaptionLanguage]    
                                    ,[Psd_AV_Attributes]      
                                    ,[Psd_TmsId]              
                                    ,[Psd_ScheduledStartTime] 
                                    ,[Psd_ScheduledEndTime]   
                                    ,[Psd_EventDuration]      
                                    ,[Psd_RowChange]          
	                        FROM OPENXML (@psd, 'ArrayOfProgramScheduleDataEntities/ProgramScheduleDataEntities',2)
	                        WITH (  
                                    [id]                     INT           ,
                                    [Psd_ServiceIdReference] VARCHAR (10)  ,
                                    [Psd_ScheduleStart]      DATETIME      ,
                                    [Psd_ScheduleEnd]        DATETIME      ,
                                    [Psd_ScheduleDuration]   VARCHAR (5)   ,
                                    [Psd_ProgramCrid]        VARCHAR (45)  ,
                                    [Psd_ProgramImi]         VARCHAR (20)  ,
                                    [Psd_PurchaseList]       NVARCHAR (MAX),
                                    [Psd_CaptionLanguage]    VARCHAR (5)   ,
                                    [Psd_AV_Attributes]      NVARCHAR (MAX),
                                    [Psd_TmsId]              VARCHAR (20)  ,
                                    [Psd_ScheduledStartTime] DATETIME      ,
                                    [Psd_ScheduledEndTime]   DATETIME      ,
                                    [Psd_EventDuration]      VARCHAR (10)  ,
                                    [Psd_RowChange]          NVARCHAR (MAX)
                                )
                        ) TPsd 
                ON  TPsd.[Psd_ServiceIdReference]   = Psd.[Psd_ServiceIdReference]
                AND TPsd.[Psd_ProgramCrid]          = Psd.[Psd_ProgramCrid]
                AND TPsd.[Psd_ProgramImi]           = Psd.[Psd_ProgramImi]
                AND TPsd.[Psd_ScheduleStart]        = Psd.[Psd_ScheduleStart]
                AND TPsd.[Psd_ScheduleEnd]          = Psd.[Psd_ScheduleEnd]
                AND TPsd.[Psd_ScheduledStartTime]   = Psd.[Psd_ScheduledStartTime]
                AND TPsd.[Psd_ScheduledEndTime]     = Psd.[Psd_ScheduledEndTime]
                AND 
                    (
                            Psd.[Psd_ScheduleDuration]         != TPsd.[Psd_ScheduleDuration]
                        OR  Psd.[Psd_PurchaseList]             != TPsd.[Psd_PurchaseList]
                        OR  Psd.[Psd_CaptionLanguage]          != TPsd.[Psd_CaptionLanguage]
                        OR  Psd.[Psd_AV_Attributes]            != TPsd.[Psd_AV_Attributes]
                        OR  Psd.[Psd_TmsId]                    != TPsd.[Psd_TmsId]
                        OR  Psd.[Psd_EventDuration]            != TPsd.[Psd_EventDuration]
                        OR  Psd.[Psd_RowChange]                != TPsd.[Psd_RowChange]
                    )
        
        INSERT INTO ProgramScheduleData
                ([Psd_ServiceIdReference] 
                ,[Psd_ScheduleStart]      
                ,[Psd_ScheduleEnd]        
                ,[Psd_ScheduleDuration]   
                ,[Psd_ProgramCrid]        
                ,[Psd_ProgramImi]         
                ,[Psd_PurchaseList]       
                ,[Psd_CaptionLanguage]    
                ,[Psd_AV_Attributes]      
                ,[Psd_TmsId]              
                ,[Psd_ScheduledStartTime] 
                ,[Psd_ScheduledEndTime]   
                ,[Psd_EventDuration]      
                ,[Psd_RowChange]    )
        SELECT   
                 TPsd.[Psd_ServiceIdReference] 
                ,TPsd.[Psd_ScheduleStart]      
                ,TPsd.[Psd_ScheduleEnd]        
                ,TPsd.[Psd_ScheduleDuration]   
                ,TPsd.[Psd_ProgramCrid]        
                ,TPsd.[Psd_ProgramImi]         
                ,TPsd.[Psd_PurchaseList]       
                ,TPsd.[Psd_CaptionLanguage]    
                ,TPsd.[Psd_AV_Attributes]      
                ,TPsd.[Psd_TmsId]              
                ,TPsd.[Psd_ScheduledStartTime] 
                ,TPsd.[Psd_ScheduledEndTime]   
                ,TPsd.[Psd_EventDuration]      
                ,TPsd.[Psd_RowChange]          
	    FROM    (
                    SELECT   
                             [Psd_ServiceIdReference] 
                            ,[Psd_ScheduleStart]      
                            ,[Psd_ScheduleEnd]        
                            ,[Psd_ScheduleDuration]   
                            ,[Psd_ProgramCrid]        
                            ,[Psd_ProgramImi]         
                            ,[Psd_PurchaseList]       
                            ,[Psd_CaptionLanguage]    
                            ,[Psd_AV_Attributes]      
                            ,[Psd_TmsId]              
                            ,[Psd_ScheduledStartTime] 
                            ,[Psd_ScheduledEndTime]   
                            ,[Psd_EventDuration]      
                            ,[Psd_RowChange]          
	                FROM OPENXML (@psd, 'ArrayOfProgramScheduleDataEntities/ProgramScheduleDataEntities',2)
	                WITH (  
                            [id]                     INT           ,
                            [Psd_ServiceIdReference] VARCHAR (10)  ,
                            [Psd_ScheduleStart]      DATETIME      ,
                            [Psd_ScheduleEnd]        DATETIME      ,
                            [Psd_ScheduleDuration]   VARCHAR (5)   ,
                            [Psd_ProgramCrid]        VARCHAR (45)  ,
                            [Psd_ProgramImi]         VARCHAR (20)  ,
                            [Psd_PurchaseList]       NVARCHAR (MAX),
                            [Psd_CaptionLanguage]    VARCHAR (5)   ,
                            [Psd_AV_Attributes]      NVARCHAR (MAX),
                            [Psd_TmsId]              VARCHAR (20)  ,
                            [Psd_ScheduledStartTime] DATETIME      ,
                            [Psd_ScheduledEndTime]   DATETIME      ,
                            [Psd_EventDuration]      VARCHAR (10)  ,
                            [Psd_RowChange]          NVARCHAR (MAX)
                        )
                ) TPsd
            LEFT JOIN ProgramScheduleData Psd 
                ON  TPsd.[Psd_ServiceIdReference]   = Psd.[Psd_ServiceIdReference]
                AND TPsd.[Psd_ProgramCrid]          = Psd.[Psd_ProgramCrid]
                AND TPsd.[Psd_ProgramImi]           = Psd.[Psd_ProgramImi]
                AND TPsd.[Psd_ScheduleStart]        = Psd.[Psd_ScheduleStart]
                AND TPsd.[Psd_ScheduleEnd]          = Psd.[Psd_ScheduleEnd]
                AND TPsd.[Psd_ScheduledStartTime]   = Psd.[Psd_ScheduledStartTime]
                AND TPsd.[Psd_ScheduledEndTime]     = Psd.[Psd_ScheduledEndTime]
        WHERE   Psd.id IS NULL

		--End ProgramScheduleData insert/update/delete operation


		IF @@TRANCOUNT > 0
			COMMIT TRANSACTION EPG_InsertUpdate
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION EPG_InsertUpdate
		
		DECLARE @ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT, @ErrorNumber INT
		SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE(), @ErrorNumber = ERROR_NUMBER()
		RAISERROR  (@ErrorMessage,@ErrorSeverity,@ErrorState,@ErrorNumber)
	END CATCH
    
	EXEC sp_xml_removedocument @pid
    
	EXEC sp_xml_removedocument @gid
    
	EXEC sp_xml_removedocument @psd
    
	EXEC sp_xml_removedocument @sid

END