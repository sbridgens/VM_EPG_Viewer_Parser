CREATE PROCEDURE [dbo].[EPG_ProgramSchedule_GetAll]
	@Date DATE
AS
BEGIN
	SELECT			PID.Id,
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
					PSD.Psd_EventDuration
	FROM			DBO.ProgramInformationData PID
		INNER JOIN	DBO.ProgramScheduleData PSD
			ON		PID.Pid_Crid = PSD.Psd_ProgramCrid 
					AND CONVERT(DATE, PSD.Psd_ScheduledStartTime) = @Date
END
