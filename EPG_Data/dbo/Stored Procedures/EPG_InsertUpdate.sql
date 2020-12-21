CREATE PROCEDURE [dbo].[EPG_InsertUpdate]
    @EpgFilenameGZ        VARCHAR (45),
    @EpgFilenameExtracted VARCHAR (45),
    @EpgOriginalFileSize  VARCHAR (10),
    @EpgExtractedFileSize VARCHAR (10),
    @EpgDateTimeRetrieved DATETIME2,
    @EpgDateTimeParsed    DATETIME2,
    @EpgDateTimeArchived  DATETIME2,
    @EpgArchiveLocation   VARCHAR (45)
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

END