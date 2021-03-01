CREATE PROCEDURE [dbo].[EPG_ProgramHistory_Get]
	@Id int
AS
BEGIN
	SELECT			PIH.Id,
					PIH.Pid_Crid,
					PIH.Pid_TmsId,
					PIH.Pid_RootId,
					PIH.Pid_ImdbId,
					PIH.Pid_SeriesLink,
					PIH.Pid_EpisodeNumber,
					PIH.Pid_TitleMain,
					PIH.Pid_EpisodeTitle,
					PIH.Pid_SynopsisShort,
					PIH.Pid_SynopsisLong,
					PIH.Pid_ProgramGenres,
					PIH.Pid_ProgramImages,
					PIH.Pid_ProductionYear,
					PIH.Pid_ProductionLocation,
					PIH.Pid_CreatedDateTime,

					GID.Gid_ConnectorId,
					GID.Gid_Language,
					GID.Gid_Type,
					GID.Gid_SeriesImages,
					GID.Gid_Genres
	FROM			DBO.ProgramInformationHistory AS PIH
	LEFT JOIN 
	DBO.GroupInformationData AS GID
	ON GID.Gid_SeriesCrid=PIH.Pid_SeriesLink
	WHERE PIH.Pid_ParentId=@Id
END
