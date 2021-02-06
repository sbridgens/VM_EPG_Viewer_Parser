CREATE PROCEDURE [dbo].[EPG_ProgramData_Get]
	@id int
AS
BEGIN
	SELECT * 
	FROM DBO.ProgramInformationData PID
	WHERE PID.ID = @id
END
GO