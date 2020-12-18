using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epg.Entities.Concrete.XMLEntities
{
    public static class XMLMapper
    {
        public static TVADBMainEntities GetDBEntity(this TVAMain tVAMain, EpgScheduleFileHistoryEntities scheduleFileHistory = null)
        {
            TVADBMainEntities dBMainEntities = new TVADBMainEntities();
            if (scheduleFileHistory != null)
                dBMainEntities.ScheduleFileHistory = scheduleFileHistory;

            if (tVAMain.ProgramDescription != null) 
            { 
                //set List<ProgramInformationDataEntities> Programs = new List<ProgramInformationDataEntities>();
                for (int i = 0; i < tVAMain.ProgramDescription.ProgramInformationTable.Length; i++)
                {
                    dBMainEntities.Programs.Add(mapProgram(tVAMain.ProgramDescription.ProgramInformationTable[i]));
                }

                //      set List<GroupInformationDataEntities> Groups = new List<GroupInformationDataEntities>();
                for (int i = 0; i < tVAMain.ProgramDescription.GroupInformationTable.Length; i++)
                {
                    dBMainEntities.Groups.Add(mapGroups(tVAMain.ProgramDescription.GroupInformationTable[i]));
                }

                //set List<ProgramScheduleDataEntities> ProgramSchedules = new List<ProgramScheduleDataEntities>();
                for (int i = 0; i < tVAMain.ProgramDescription.ProgramLocationTable.Length; i++)
                {
                    dBMainEntities.ProgramSchedules.Add(mapProgramSchedules(tVAMain.ProgramDescription.ProgramLocationTable[i]));
                }

                //set List<ServiceInformationDataEntities> Services = new List<ServiceInformationDataEntities>();
                for (int i = 0; i < tVAMain.ProgramDescription.ServiceInformationTable.Length; i++)
                {
                    dBMainEntities.Services.Add(mapServices(tVAMain.ProgramDescription.ServiceInformationTable[i]));
                }
            }
            return dBMainEntities;
        }

        private static ProgramInformationDataEntities mapProgram(TVAMainProgramDescriptionProgramInformation programInformation)
        {
            var genreList = programInformation.BasicDescription.Genre?.Select(x => x.Name.Value).ToList();

            return new ProgramInformationDataEntities()
            {
                Pid_Crid = programInformation.programId,
                Pid_TmsId = programInformation.OtherIdentifier?.Where(x => x.type.ToLower() == "tmsid").FirstOrDefault()?.Value,
                Pid_RootId = programInformation.OtherIdentifier?.Where(x => x.type.ToLower() == "rootid").FirstOrDefault()?.Value,
                Pid_ImdbId = "0",
                Pid_SeriesLink = programInformation.EpisodeOf?.crid,
                Pid_EpisodeNumber = Convert.ToString(programInformation.EpisodeOf?.index),
                Pid_TitleMain = programInformation.BasicDescription.Title?.Where(x => x.type.ToLower() == "main").FirstOrDefault()?.Value,
                Pid_EpisodeTitle = string.Empty,
                Pid_SynopsisShort = programInformation.BasicDescription.Synopsis?.Where(x => x.length.ToLower() == "short").FirstOrDefault()?.Value,
                Pid_SynopsisMedium = programInformation.BasicDescription.Synopsis?.Where(x => x.length.ToLower() == "medium").FirstOrDefault()?.Value,
                Pid_SynopsisLong = programInformation.BasicDescription.Synopsis?.Where(x => x.length.ToLower() == "long").FirstOrDefault()?.Value,
                Pid_ProgramGenres = genreList != null ? String.Join(",", genreList) : null,
                Pid_ParentalGuidance = string.Empty,
                Pid_CreditsList = programInformation.BasicDescription.CreditsList != null ? JsonConvert.SerializeObject(programInformation.BasicDescription.CreditsList) : null,
                Pid_ProgramImages = programInformation.BasicDescription.RelatedMaterial != null ? JsonConvert.SerializeObject(programInformation.BasicDescription.RelatedMaterial) : null,
                Pid_ProductionYear = Convert.ToString(programInformation.BasicDescription.ProductionDate?.TimePoint),
                Pid_ProductionLocation = programInformation.BasicDescription.ProductionLocation,
                Pid_RowChanges = string.Empty
            };
        }

        private static GroupInformationDataEntities mapGroups(TVAMainProgramDescriptionGroupInformation groupInformation)
        {
            var synopsisList = groupInformation.BasicDescription.Synopsis?.Where(x => x.length.ToLower() == "long")?.Select(x => x.Value).ToList();
            var genreList = groupInformation.BasicDescription.Genre?.Select(x => x.Name.Value).ToList();

            return new GroupInformationDataEntities()
            {
                Gid_GroupId = groupInformation.groupId,
                Gid_ConnectorId = groupInformation.OtherIdentifier?.Where(x => x.type.ToLower() == "connectorid").FirstOrDefault()?.Value,
                Gid_Type = groupInformation.GroupType?.value,
                Gid_SeriesTitle = groupInformation.BasicDescription.Title?.Value,
                Gid_SeriesId = groupInformation.OtherIdentifier?.Where(x => x.type.ToLower() == "seriesid").FirstOrDefault()?.Value,
                Gid_SeriesNumber = Convert.ToString(groupInformation.MemberOf?.index),
                Gid_SeriesCrid = groupInformation.MemberOf?.crid,
                Gid_Synopsis = synopsisList != null ? String.Join(",", synopsisList) : null,
                Gid_Genres = genreList != null ? String.Join(",", genreList) : null,
                Gid_Language = groupInformation.BasicDescription.Title?.lang,
                Gid_CreditsList = string.Empty,
                Gid_SeriesImages = groupInformation.BasicDescription.RelatedMaterial != null ? JsonConvert.SerializeObject(groupInformation.BasicDescription.RelatedMaterial) : null,
                Gid_ProductionYear = groupInformation.BasicDescription.ProductionDate != null ? Convert.ToString(groupInformation.BasicDescription.ProductionDate.TimePoint) : null,
                Gid_RowChanges = string.Empty
            };
        }

        private static ProgramScheduleDataEntities mapProgramSchedules(TVAMainProgramDescriptionSchedule mainProgramDescriptionSchedule)
        {
            return new ProgramScheduleDataEntities()
            {
                Psd_ServiceIdReference = Convert.ToString(mainProgramDescriptionSchedule.serviceIDRef),
                Psd_ScheduleStart = mainProgramDescriptionSchedule.start,
                Psd_ScheduleEnd = mainProgramDescriptionSchedule.end,
                Psd_ScheduleDuration = string.Empty,
                Psd_ProgramCrid = string.Empty,
                Psd_ProgramImi = string.Empty,
                Psd_PurchaseList = string.Empty,
                Psd_CaptionLanguage = string.Empty,
                Psd_AV_Attributes = string.Empty,
                Psd_TmsId = string.Empty,
                //Psd_ScheduledStartTime      = string.Empty,
                //Psd_ScheduledEndTime        = string.Empty,
                Psd_EventDuration = string.Empty,
                Psd_RowChange = string.Empty
            };
        }

        private static ServiceInformationDataEntities mapServices(TVAMainProgramDescriptionServiceInformation serviceInformation)
        {
            return new ServiceInformationDataEntities()
            {
                Sid_ServiceName = serviceInformation.Name,
                Sid_VM_ServiceId = Convert.ToString(serviceInformation.serviceId),
                Sid_Epg_ServiceId = string.Empty,
                Sid_ServiceLogo = string.Empty,
                Sid_ChannelResolution = string.Empty,
                Sid_VM_ServiceGroup = string.Empty,
                Sid_RowChanges = string.Empty
            };
        }

    }
}
