CREATE PROCEDURE [dbo].[EPG_InsertUpdate]
    @EpgFilenameGZ        VARCHAR (45),
    @EpgFilenameExtracted VARCHAR (45),
    @EpgOriginalFileSize  VARCHAR (10),
    @EpgExtractedFileSize VARCHAR (10),
    @EpgDateTimeRetrieved DATETIME2,
    @EpgDateTimeParsed    DATETIME2,
    @EpgDateTimeArchived  DATETIME2,
    @EpgArchiveLocation   VARCHAR (45),
    @GroupInformationData   xml,
    @ProgramInformationData xml,
    @ProgramScheduleData    xml,
    @ServiceInformationData xml
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

	BEGIN TRANSACTION EPG_InsertUpdate
	BEGIN TRY 
		DECLARE @gid int
		EXEC sp_xml_preparedocument @gid OUTPUT, @GroupInformationData


		EXEC sp_xml_removedocument @gid

		IF @@TRANCOUNT > 0
			COMMIT TRANSACTION EPG_InsertUpdate
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION EPG_InsertUpdate
		
        EXEC sp_xml_removedocument @gid
		
		DECLARE @ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT, @ErrorNumber INT
		SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE(), @ErrorNumber = ERROR_NUMBER()
		RAISERROR  (@ErrorMessage,@ErrorSeverity,@ErrorState,@ErrorNumber)
	END CATCH

END