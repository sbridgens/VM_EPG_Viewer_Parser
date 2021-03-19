CREATE PROCEDURE [dbo].[EPG_ProgramSchedule_GetAll]
	@Date DATE
AS
BEGIN
	SELECT			PID.Id Pid_Id,
					PID.Pid_Crid,
					PID.Pid_TmsId,
					PID.Pid_RootId,
					PID.Pid_ImdbId,
					PID.Pid_SeriesLink,
					PID.Pid_EpisodeNumber,
					PID.Pid_TitleMain,
					PID.Pid_EpisodeTitle,
					PID.Pid_SynopsisShort,
					PID.Pid_SynopsisLong,
					PID.Pid_ProgramGenres,
					PID.Pid_ProgramImages,
					PID.Pid_ProductionYear,
					PID.Pid_ProductionLocation,
			
					PSD.Psd_ServiceIdReference,
					PSD.Psd_ProgramImi,
					PSD.Psd_CaptionLanguage,
					PSD.Psd_ScheduledStartTime,
					PSD.Psd_ScheduledEndTime,
					PSD.Psd_EventDuration,

					GID.Gid_ConnectorId,
					GID.Gid_Language,
					GID.Gid_Type,
					GID.Gid_SeriesImages,
					GID.Gid_Genres,

					PGID.Gid_SeriesImages PGid_SeriesImages 
	FROM			DBO.ProgramInformationData PID
		INNER JOIN	DBO.ProgramScheduleData PSD
			ON		PID.Pid_Crid = PSD.Psd_ProgramCrid 
					AND CONVERT(DATE, PSD.Psd_ScheduledStartTime) = @Date
		LEFT JOIN	(SELECT 
						MAX(Pid_Action) Pid_Action, 
						Pid_ParentId, 
						MAX(Pid_CreatedDateTime) Pid_CreatedDateTime 
					FROM DBO.ProgramInformationHistory 
					WHERE Pid_Action = 'U' GROUP BY Pid_ParentId) PIH
			ON		PIH.Pid_ParentId = PID.Id
		LEFT JOIN 
					DBO.GroupInformationData AS GID
			ON GID.Gid_GroupId=PID.Pid_SeriesLink
		LEFT JOIN 
					DBO.GroupInformationData AS PGID
			ON PGID.Gid_GroupId = GID.Gid_SeriesCrid
END
