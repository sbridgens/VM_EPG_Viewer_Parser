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

            //set List<ProgramInformationDataEntities> Programs = new List<ProgramInformationDataEntities>();
            for (int i = 0; i < tVAMain.ProgramDescription.ProgramInformationTable.Length; i++)
            {
                dBMainEntities.Programs.Add(mapProgram(tVAMain.ProgramDescription.ProgramInformationTable[i]));
            }

            //set List<GroupInformationDataEntities> Groups = new List<GroupInformationDataEntities>();
            //set List<ProgramScheduleDataEntities> ProgramSchedules = new List<ProgramScheduleDataEntities>();
            //set List<ServiceInformationDataEntities> Services = new List<ServiceInformationDataEntities>();
            return dBMainEntities;
        }

        private static ProgramInformationDataEntities mapProgram(TVAMainProgramDescriptionProgramInformation programInformation)
        {
            return new ProgramInformationDataEntities()
            {
                Pid_Crid = programInformation.programId,
                Pid_TmsId = programInformation.OtherIdentifier.Where(x => x.type.ToLower() == "tmsid").FirstOrDefault().Value,
                Pid_RootId = programInformation.OtherIdentifier.Where(x => x.type.ToLower() == "rootid").FirstOrDefault().Value,
                Pid_ImdbId = "0",
                Pid_SeriesLink = programInformation.EpisodeOf.crid,
                Pid_EpisodeNumber = Convert.ToString(programInformation.EpisodeOf.index),
                Pid_TitleMain = programInformation.BasicDescription.Title.Where(x => x.type.ToLower() == "main").FirstOrDefault().Value,
                Pid_EpisodeTitle = string.Empty,
                Pid_SynopsisShort = programInformation.BasicDescription.Synopsis.Where(x => x.length.ToLower() == "short").FirstOrDefault().Value,
                Pid_SynopsisMedium = programInformation.BasicDescription.Synopsis.Where(x => x.length.ToLower() == "medium").FirstOrDefault().Value,
                Pid_SynopsisLong = programInformation.BasicDescription.Synopsis.Where(x => x.length.ToLower() == "long").FirstOrDefault().Value,
                Pid_ProgramGenres = String.Join(",", programInformation.BasicDescription.Genre.Select(x => x.Name)),
                Pid_ParentalGuidance = string.Empty,
                Pid_CreditsList = JsonConvert.SerializeObject(programInformation.BasicDescription.CreditsList),
                Pid_ProgramImages = JsonConvert.SerializeObject(programInformation.BasicDescription.RelatedMaterial),
                Pid_ProductionYear = Convert.ToString(programInformation.BasicDescription.ProductionDate.TimePoint),
                Pid_ProductionLocation = programInformation.BasicDescription.ProductionLocation,
                Pid_RowChanges = string.Empty
            };
        }
    }
}
