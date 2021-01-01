CREATE PROCEDURE [dbo].[EPG_History_InsertUpdate]
    @EpgFilenameGZ          VARCHAR (45),
    @EpgFilenameExtracted   VARCHAR (45),
    @EpgOriginalFileSize    VARCHAR (10),
    @EpgExtractedFileSize   VARCHAR (10),
    @EpgDateTimeRetrieved   DATETIME2,
    @EpgDateTimeParsed      DATETIME2,
    @EpgDateTimeArchived    DATETIME2,
    @EpgArchiveLocation     VARCHAR (45),
    @GroupInformationData   xml,
    @ProgramInformationData xml,
    @ProgramScheduleData    xml,
    @ServiceInformationData xml,
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

    --Start ProgramInformationData insert into templary table from xml
    DECLARE @ProgramInformationDataTable AS TABLE (
        [Id]                     INT            IDENTITY (1, 1) NOT NULL,
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
        [Pid_RowChanges]         NVARCHAR (MAX) NULL
    );

	DECLARE @pid int
    EXEC sp_xml_preparedocument @pid OUTPUT, @ProgramInformationData;

	INSERT INTO @ProgramInformationDataTable
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
            [Pid_RowChanges]         NVARCHAR (MAX) );
    
	EXEC sp_xml_removedocument @pid
    
    --End ProgramInformationData insert into templary table from xml

    --Start GroupInformationData insert into templary table from xml
    DECLARE @GroupInformationDataTable AS TABLE (
        [id]                 INT            IDENTITY (1, 1) NOT NULL,
        [Gid_GroupId]        VARCHAR (45)   NOT NULL,
        [Gid_ConnectorId]    VARCHAR (20)   NOT NULL,
        [Gid_Type]           VARCHAR (45)   NOT NULL,
        [Gid_SeriesTitle]    VARCHAR (45)   NOT NULL,
        [Gid_SeriesId]       VARCHAR (15)   NOT NULL,
        [Gid_SeriesNumber]   VARCHAR (15)   NOT NULL,
        [Gid_SeriesCrid]     VARCHAR (45)   NOT NULL,
        [Gid_Synopsis]       NVARCHAR (MAX) NOT NULL,
        [Gid_Genres]         NVARCHAR (MAX) NULL,
        [Gid_Language]       VARCHAR (5)    NULL,
        [Gid_CreditsList]    NVARCHAR (MAX) NULL,
        [Gid_SeriesImages]   NVARCHAR (MAX) NOT NULL,
        [Gid_ProductionYear] VARCHAR (45)   NULL,
        [Gid_RowChanges]     NVARCHAR (MAX) NULL
    );

	DECLARE @gid int
    EXEC sp_xml_preparedocument @gid OUTPUT, @GroupInformationData;

	INSERT INTO @GroupInformationDataTable
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
            ,[Gid_RowChanges] )
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
        );
    
	EXEC sp_xml_removedocument @gid
    
    --End GroupInformationData insert into templary table from xml

    --Start ProgramScheduleData insert into templary table from xml
    DECLARE @ProgramScheduleDataTable AS TABLE (
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
        [Psd_RowChange]          NVARCHAR (MAX) NULL
    );

	DECLARE @psd int
    EXEC sp_xml_preparedocument @psd OUTPUT, @ProgramScheduleData;

	INSERT INTO @ProgramScheduleDataTable
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
            ,[Psd_RowChange] )
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
        );
    
	EXEC sp_xml_removedocument @psd
    
    --End ProgramScheduleData insert into templary table from xml

    --Start ServiceInformationData insert into templary table from xml
    DECLARE @ServiceInformationDataTable AS TABLE (
        [id]                    INT           IDENTITY (1, 1) NOT NULL,
        [Sid_ServiceName]       VARCHAR (45)  NULL,
        [Sid_VM_ServiceId]      VARCHAR (10)  NOT NULL,
        [Sid_Epg_ServiceId]     VARCHAR (10)  NOT NULL,
        [Sid_ServiceLogo]       VARCHAR (250) NOT NULL,
        [Sid_ChannelResolution] VARCHAR (3)   NOT NULL,
        [Sid_VM_ServiceGroup]   VARCHAR (250) NOT NULL,
        [Sid_RowChanges]        VARCHAR (45)  NULL
    );

	DECLARE @sid int
    EXEC sp_xml_preparedocument @sid OUTPUT, @ServiceInformationData;

	INSERT INTO @ServiceInformationDataTable
            (
             [Sid_ServiceName]       
            ,[Sid_VM_ServiceId]      
            ,[Sid_Epg_ServiceId]     
            ,[Sid_ServiceLogo]       
            ,[Sid_ChannelResolution] 
            ,[Sid_VM_ServiceGroup]   
            ,[Sid_RowChanges]        
            )
    SELECT   
             [Sid_ServiceName]       
            ,[Sid_VM_ServiceId]      
            ,[Sid_Epg_ServiceId]     
            ,[Sid_ServiceLogo]       
            ,[Sid_ChannelResolution] 
            ,[Sid_VM_ServiceGroup]   
            ,[Sid_RowChanges]        
	FROM OPENXML (@sid, 'ArrayOfServiceInformationDataEntities/ServiceInformationDataEntities',2)
	WITH (  
            [id]                    INT          ,
            [Sid_ServiceName]       VARCHAR (45) ,
            [Sid_VM_ServiceId]      VARCHAR (10) ,
            [Sid_Epg_ServiceId]     VARCHAR (10) ,
            [Sid_ServiceLogo]       VARCHAR (250),
            [Sid_ChannelResolution] VARCHAR (3)  ,
            [Sid_VM_ServiceGroup]   VARCHAR (250),
            [Sid_RowChanges]        VARCHAR (45) 
        );
    
	EXEC sp_xml_removedocument @sid
    
    --End ProgramInformationData insert into templary table from xml

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
            LEFT JOIN @ProgramInformationDataTable TPid ON TPid.Pid_Crid = Pid.Pid_Crid
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
            INNER JOIN @ProgramInformationDataTable TPid 
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
	    FROM    @ProgramInformationDataTable TPid
            LEFT JOIN ProgramInformationData Pid ON TPid.Pid_Crid = Pid.Pid_Crid
        WHERE   Pid.Pid_Crid IS NULL

		--End ProgramInformationData insert/update/delete operation

		--Start GroupInformationData insert/update/delete operation
        DELETE  Gid
        FROM    GroupInformationData Gid
            LEFT JOIN @GroupInformationDataTable TGid ON TGid.Gid_GroupId = Gid.Gid_GroupId
        WHERE   TGid.Gid_GroupId IS NULL

        UPDATE  GroupInformationData 
        SET    
                 [Gid_GroupId]       = TGid.[Gid_GroupId]
                ,[Gid_ConnectorId]   = TGid.[Gid_ConnectorId]
                ,[Gid_Type]          = TGid.[Gid_Type]
                ,[Gid_SeriesTitle]   = TGid.[Gid_SeriesTitle]
                ,[Gid_SeriesId]      = TGid.[Gid_SeriesId]
                ,[Gid_SeriesNumber]  = TGid.[Gid_SeriesNumber]
                ,[Gid_SeriesCrid]    = TGid.[Gid_SeriesCrid]
                ,[Gid_Synopsis]      = TGid.[Gid_Synopsis]
                ,[Gid_Genres]        = TGid.[Gid_Genres]
                ,[Gid_Language]      = TGid.[Gid_Language]
                ,[Gid_CreditsList]   = TGid.[Gid_CreditsList]
                ,[Gid_SeriesImages]  = TGid.[Gid_SeriesImages]
                ,[Gid_ProductionYear]= TGid.[Gid_ProductionYear]
                ,[Gid_RowChanges]    = TGid.[Gid_RowChanges]        
        FROM GroupInformationData Gid 
            INNER JOIN @GroupInformationDataTable TGid ON TGid.Gid_GroupId = Gid.Gid_GroupId

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
	    FROM    @GroupInformationDataTable TGid
            LEFT JOIN GroupInformationData Gid ON TGid.Pid_Crid = Gid.Pid_Crid
        WHERE   Gid.Gid_GroupId IS NULL

		--End GroupInformationData insert/update/delete operation

		--Start ProgramScheduleData insert/update/delete operation
        DELETE  Psd 
        FROM ProgramScheduleData Psd
            LEFT JOIN @ProgramScheduleDataTable TPsd 
                ON  TPsd.[Psd_ServiceIdReference]   = Psd.[Psd_ServiceIdReference]
                AND TPsd.[Psd_ProgramCrid]          = Psd.[Psd_ProgramCrid]
                AND TPsd.[Psd_ScheduleStart]        = Psd.[Psd_ScheduleStart]
                AND TPsd.[Psd_ScheduleEnd]          = Psd.[Psd_ScheduleEnd]
        WHERE   TPsd.[Psd_ServiceIdReference] IS NULL

        UPDATE  ProgramScheduleData 
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
        FROM ProgramScheduleData Psd 
            INNER JOIN @ProgramScheduleDataTable TPsd 
                ON  TPsd.[Psd_ServiceIdReference]   = Psd.[Psd_ServiceIdReference]
                AND TPsd.[Psd_ProgramCrid]          = Psd.[Psd_ProgramCrid]
                AND TPsd.[Psd_ScheduleStart]        = Psd.[Psd_ScheduleStart]
                AND TPsd.[Psd_ScheduleEnd]          = Psd.[Psd_ScheduleEnd]

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
	    FROM    @ProgramScheduleDataTable TPsd
            LEFT JOIN ProgramScheduleData Psd 
                ON  TPsd.[Psd_ServiceIdReference]   = Psd.[Psd_ServiceIdReference]
                AND TPsd.[Psd_ProgramCrid]          = Psd.[Psd_ProgramCrid]
                AND TPsd.[Psd_ScheduleStart]        = Psd.[Psd_ScheduleStart]
                AND TPsd.[Psd_ScheduleEnd]          = Psd.[Psd_ScheduleEnd]
        WHERE   Psd.id IS NULL

		--End ProgramScheduleData insert/update/delete operation

		--Start ServiceInformationData insert/update/delete operation
        DELETE  [Sid]
        FROM    ServiceInformationData [Sid]
            LEFT JOIN @ServiceInformationDataTable TSid ON TSid.[Sid_Epg_ServiceId] = [Sid].[Sid_Epg_ServiceId]
        WHERE   TSid.[Sid_Epg_ServiceId] IS NULL

        UPDATE  ServiceInformationData 
        SET    
             [Sid_ServiceName]       = TSid.[Sid_ServiceName]       
            ,[Sid_VM_ServiceId]      = TSid.[Sid_VM_ServiceId]      
            ,[Sid_Epg_ServiceId]     = TSid.[Sid_Epg_ServiceId]     
            ,[Sid_ServiceLogo]       = TSid.[Sid_ServiceLogo]       
            ,[Sid_ChannelResolution] = TSid.[Sid_ChannelResolution] 
            ,[Sid_VM_ServiceGroup]   = TSid.[Sid_VM_ServiceGroup]   
            ,[Sid_RowChanges]        = TSid.[Sid_RowChanges]        
        FROM ServiceInformationData [Sid]
            INNER JOIN @ServiceInformationDataTable TSid ON TSid.[Sid_Epg_ServiceId] = [Sid].[Sid_Epg_ServiceId]

        INSERT INTO ServiceInformationData
                ([Sid_ServiceName]       
                ,[Sid_VM_ServiceId]      
                ,[Sid_Epg_ServiceId]     
                ,[Sid_ServiceLogo]       
                ,[Sid_ChannelResolution] 
                ,[Sid_VM_ServiceGroup]   
                ,[Sid_RowChanges]        )
        SELECT  
                 TSid.[Sid_ServiceName]       
                ,TSid.[Sid_VM_ServiceId]      
                ,TSid.[Sid_Epg_ServiceId]     
                ,TSid.[Sid_ServiceLogo]       
                ,TSid.[Sid_ChannelResolution] 
                ,TSid.[Sid_VM_ServiceGroup]   
                ,TSid.[Sid_RowChanges]        
	    FROM    @ServiceInformationDataTable TSid
            LEFT JOIN ServiceInformationData [Sid] ON TSid.[Sid_Epg_ServiceId] = [Sid].[Sid_Epg_ServiceId]
        WHERE   [Sid].[Sid_Epg_ServiceId] IS NULL

		--End ServiceInformationData insert/update/delete operation


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

END