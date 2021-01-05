using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Epg.Entities.Concrete.XMLEntities
{
    public static class XmlMapper
    {
        public static TVADBMainEntities GetDbEntity(this TVAMain tvaMain, EpgScheduleFileHistoryEntities scheduleFileHistory = null)
        {
            TVADBMainEntities dBMainEntities = new TVADBMainEntities();
            if (scheduleFileHistory != null)
                dBMainEntities.ScheduleFileHistory = scheduleFileHistory;

            if (tvaMain.ProgramDescription == null)
                return dBMainEntities;

            //set List<ProgramInformationDataEntities> Programs = new List<ProgramInformationDataEntities>();
            foreach (var t in tvaMain.ProgramDescription.ProgramInformationTable)
            {
                dBMainEntities.Programs.Add(MapProgram(t));
            }

            //set List<GroupInformationDataEntities> Groups = new List<GroupInformationDataEntities>();
            foreach (var t in tvaMain.ProgramDescription.GroupInformationTable)
            {
                dBMainEntities.Groups.Add(MapGroups(t));
            }

            //set List<ProgramScheduleDataEntities> ProgramSchedules = new List<ProgramScheduleDataEntities>();
            foreach (var t in tvaMain.ProgramDescription.ProgramLocationTable)
            {
                dBMainEntities.ProgramSchedules.AddRange(MapProgramSchedules(t));
            }

            //set List<ServiceInformationDataEntities> Services = new List<ServiceInformationDataEntities>();
            foreach (var t in tvaMain.ProgramDescription.ServiceInformationTable)
            {
                dBMainEntities.Services.Add(MapServices(t));
            }
            return dBMainEntities;
        }

        private static ProgramInformationDataEntities MapProgram(TVAMainProgramDescriptionProgramInformation programInformation)
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
                Pid_EpisodeTitle = programInformation.BasicDescription.Title?.Where(x => x.type.ToLower() == "episodetitle").FirstOrDefault()?.Value,
                Pid_SynopsisShort = programInformation.BasicDescription.Synopsis?.Where(x => x.length.ToLower() == "short").FirstOrDefault()?.Value,
                Pid_SynopsisMedium = programInformation.BasicDescription.Synopsis?.Where(x => x.length.ToLower() == "medium").FirstOrDefault()?.Value,
                Pid_SynopsisLong = programInformation.BasicDescription.Synopsis?.Where(x => x.length.ToLower() == "long").FirstOrDefault()?.Value,
                Pid_ProgramGenres = genreList != null ? String.Join(",", genreList) : null,
                Pid_ParentalGuidance = string.Empty,
                Pid_CreditsList = programInformation.BasicDescription.CreditsList != null ? JsonConvert.SerializeObject(programInformation.BasicDescription.CreditsList) : null,
                Pid_ProgramImages = programInformation.BasicDescription.RelatedMaterial != null ? JsonConvert.SerializeObject(programInformation.BasicDescription.RelatedMaterial) : null,
                Pid_ProductionYear = Convert.ToString(programInformation.BasicDescription.ProductionDate?.TimePoint),
                Pid_ProductionLocation = programInformation.BasicDescription.ProductionLocation,
            };
        }

        private static GroupInformationDataEntities MapGroups(TVAMainProgramDescriptionGroupInformation groupInformation)
        {
            var synopsisList = groupInformation.BasicDescription.Synopsis?.Where(x => x.length.ToLower() == "long").Select(x => x.Value).ToList();
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
            };
        }

        private static List<ProgramScheduleDataEntities> MapProgramSchedules(TVAMainProgramDescriptionSchedule mainProgramDescriptionSchedule)
        {
            List<ProgramScheduleDataEntities> result = new List<ProgramScheduleDataEntities>();

            foreach (var t in mainProgramDescriptionSchedule.ScheduleEvent)
            {
                result.Add(new ProgramScheduleDataEntities()
                {
                    Psd_ServiceIdReference = Convert.ToString(mainProgramDescriptionSchedule.serviceIDRef),
                    Psd_ScheduleStart = mainProgramDescriptionSchedule.start,
                    Psd_ScheduleEnd = mainProgramDescriptionSchedule.end,
                    Psd_ScheduleDuration = t.PublishedDuration,
                    Psd_ProgramCrid = t.Program.crid,
                    Psd_ProgramImi = t.InstanceMetadataId,
                    Psd_PurchaseList = t.InstanceDescription.PurchaseList != null ? JsonConvert.SerializeObject(t.InstanceDescription.PurchaseList): null,
                    Psd_CaptionLanguage = string.Empty,
                    Psd_AV_Attributes = t.InstanceDescription.AVAttributes != null ? JsonConvert.SerializeObject(t.InstanceDescription.AVAttributes): null,
                    Psd_TmsId = string.Empty,
                    Psd_ScheduledStartTime = t.PublishedStartTime,
                    Psd_ScheduledEndTime = t.PublishedEndTime,
                    Psd_EventDuration = t.PublishedDuration,
                    Psd_RowChange = string.Empty
                });
            }

            return result;
        }

        private static ServiceInformationDataEntities MapServices(TVAMainProgramDescriptionServiceInformation serviceInformation)
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
