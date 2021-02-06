using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Epg.Entities.Concrete.XMLEntities
{
    public static class XmlMapper
    {
        public static TVADBMainEntities GetDbEntity(this TVAMain tvaMain, EpgScheduleFileHistoryEntities scheduleFileHistory = null)
        {
            Console.WriteLine("Adding Data to the Database.");
            TVADBMainEntities dBMainEntities = new TVADBMainEntities();
            if (scheduleFileHistory != null)
                dBMainEntities.ScheduleFileHistory = scheduleFileHistory;

            if (tvaMain.ProgramDescription == null)
                return dBMainEntities;

            //set List<ProgramInformationDataEntities> Programs = new List<ProgramInformationDataEntities>();
            foreach (var t in tvaMain.ProgramDescription.ProgramInformationTable.ProgramInformation)
            {
                dBMainEntities.Programs.Add(MapProgram(t));
            }

            //set List<GroupInformationDataEntities> Groups = new List<GroupInformationDataEntities>();
            foreach (var t in tvaMain.ProgramDescription.GroupInformationTable.GroupInformation)
            {
                dBMainEntities.Groups.Add(MapGroups(t));
            }

            //set List<ProgramScheduleDataEntities> ProgramSchedules = new List<ProgramScheduleDataEntities>();
            foreach (var t in tvaMain.ProgramDescription.ProgramLocationTable.Schedule)
            {
                dBMainEntities.ProgramSchedules.AddRange(MapProgramSchedules(t));
            }

            //set List<ServiceInformationDataEntities> Services = new List<ServiceInformationDataEntities>();
            foreach (TVAMainProgramDescriptionServiceInformationTableServiceInformation t in tvaMain.ProgramDescription.ServiceInformationTable.ServiceInformation)
            {
                dBMainEntities.Services.Add(MapServices(t));
            }
            return dBMainEntities;
        }

        private static ProgramInformationDataEntities MapProgram(TVAMainProgramDescriptionProgramInformationTableProgramInformation programInformation)
        {
            var genreList = programInformation.BasicDescription.Genre?.Select(x => x.Name.Value).ToList();
            var guidanceList = programInformation.BasicDescription.ParentalGuidance?.Select(x => x.ParentalRating)
                .ToList();
            return new ProgramInformationDataEntities()
            {
                Pid_Crid = programInformation.programId,
                Pid_TmsId = programInformation.OtherIdentifier?.FirstOrDefault(x => x.type.ToLower() == "tmsid")?.Value,
                Pid_RootId = programInformation.OtherIdentifier?.FirstOrDefault(x => x.type.ToLower() == "rootid")?.Value,
                Pid_ImdbId = programInformation.OtherIdentifier?.FirstOrDefault(x => x.type.ToLower() == "IMDb:Id")?.Value,
                Pid_SeriesLink = programInformation.EpisodeOf?.crid,
                Pid_EpisodeNumber = programInformation.EpisodeOf?.index.ToString(),
                Pid_TitleMain = programInformation.BasicDescription.Title?.FirstOrDefault(x => x.type.ToLower() == "main")?.Value,
                Pid_EpisodeTitle = programInformation.BasicDescription.Title?.FirstOrDefault(x => x.type.ToLower() == "episodetitle")?.Value,
                Pid_SynopsisShort = programInformation.BasicDescription.Synopsis?.FirstOrDefault(x => x.length.ToLower() == "short")?.Value,
                Pid_SynopsisMedium = programInformation.BasicDescription.Synopsis?.FirstOrDefault(x => x.length.ToLower() == "medium")?.Value,
                Pid_SynopsisLong = programInformation.BasicDescription.Synopsis?.FirstOrDefault(x => x.length.ToLower() == "long")?.Value,
                Pid_ProgramGenres = genreList != null ? string.Join(",", genreList) : null,
                Pid_ParentalGuidance = programInformation.BasicDescription.ParentalGuidance != null 
                    ? JsonConvert.SerializeObject(programInformation.BasicDescription.ParentalGuidance)
                    : null,
                Pid_CreditsList = programInformation.BasicDescription.CreditsList != null ? JsonConvert.SerializeObject(programInformation.BasicDescription.CreditsList) : null,
                Pid_ProgramImages = programInformation.BasicDescription.RelatedMaterial != null ? JsonConvert.SerializeObject(programInformation.BasicDescription.RelatedMaterial) : null,
                Pid_ProductionYear = programInformation.BasicDescription.ProductionDate?.TimePoint,
                Pid_ProductionLocation = programInformation.BasicDescription.ProductionLocation,
            };
        }

        private static GroupInformationDataEntities MapGroups(TVAMainProgramDescriptionGroupInformationTableGroupInformation groupInformation)
        {
            var synopsisList = groupInformation.BasicDescription.Synopsis?.Where(x => x.length.ToLower() == "long").Select(x => x.Value).ToList();
            var genreList = groupInformation.BasicDescription.Genre?.Select(x => x.Name.Value).ToList();

            return new GroupInformationDataEntities()
            {
                Gid_GroupId = groupInformation.groupId,
                Gid_ConnectorId = groupInformation.OtherIdentifier?.FirstOrDefault(x => x.type.ToLower() == "connectorid")?.Value,
                Gid_Type = groupInformation.GroupType?.value,
                Gid_SeriesTitle = groupInformation.BasicDescription.Title.FirstOrDefault()?.Value,
                Gid_SeriesId = groupInformation.OtherIdentifier?.FirstOrDefault(x => x.type.ToLower() == "seriesid")?.Value,
                Gid_SeriesNumber = groupInformation.MemberOf?.FirstOrDefault()?.index.ToString(),
                Gid_SeriesCrid = groupInformation.MemberOf?.FirstOrDefault()?.crid,
                Gid_Synopsis = synopsisList != null ? string.Join(",", synopsisList) : null,
                Gid_Genres = genreList != null ? string.Join(",", genreList) : null,
                Gid_Language = groupInformation.BasicDescription.Title.FirstOrDefault()?.Value,
                Gid_CreditsList = groupInformation.BasicDescription.CreditsList != null 
                    ? JsonConvert.SerializeObject(groupInformation.BasicDescription.CreditsList) 
                    :null,
                Gid_SeriesImages = groupInformation.BasicDescription.RelatedMaterial != null 
                    ? JsonConvert.SerializeObject(groupInformation.BasicDescription.RelatedMaterial) 
                    : null,
                Gid_ProductionYear = groupInformation.BasicDescription.ProductionDate != null 
                    ? Convert.ToString(groupInformation.BasicDescription.ProductionDate.TimePoint) 
                    : null,
            };
        }

        private static List<ProgramScheduleDataEntities> MapProgramSchedules(TVAMainProgramDescriptionProgramLocationTableSchedule mainProgramDescriptionSchedule)
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
                    Psd_CaptionLanguage = t.InstanceDescription.CaptionLanguage != null 
                        ? JsonConvert.SerializeObject(t.InstanceDescription.CaptionLanguage) 
                        : null,
                    Psd_AV_Attributes = t.InstanceDescription.AVAttributes != null ? JsonConvert.SerializeObject(t.InstanceDescription.AVAttributes): null,
                    Psd_TmsId = string.Empty,//TODO this should link to current program tmsid if it exists!
                    Psd_ScheduledStartTime = t.PublishedStartTime,  
                    Psd_ScheduledEndTime = t.PublishedEndTime,
                    Psd_EventDuration = t.PublishedDuration,
                    Psd_RowChange = string.Empty
                });
            }

            return result;
        }

        private static ServiceInformationDataEntities MapServices(TVAMainProgramDescriptionServiceInformationTableServiceInformation serviceInformation)
        {
            return new ServiceInformationDataEntities()
            {
                Sid_ServiceName = serviceInformation.Name.Value,
                Sid_VM_ServiceId = string.Empty,//TODO this needs to come from a lookup table.
                Sid_Epg_ServiceId = serviceInformation.serviceId,
                Sid_ServiceLogo = serviceInformation.Logo != null? serviceInformation.Logo.MediaUri: string.Empty, //TODO this will also map to a lookup if not provided
                Sid_ChannelResolution = string.Empty, //TODO Check on this...
                Sid_VM_ServiceGroup = string.Empty, //TODO this will likely come from a lookup table
                Sid_RowChanges = string.Empty
            };
        }

    }
}
