using System;
using Epg.Core.Entities;

namespace Epg.Entities.Concrete
{
    public class ProgramInformationDataEntities : IEntity
    {
        public int Id { get; set; }
        public string Pid_Crid { get; set; }
        public string Pid_TmsId { get; set; }
        public string Pid_RootId { get; set; }
        public string Pid_ImdbId { get; set; }
        public string Pid_SeriesLink { get; set; }
        public string Pid_EpisodeNumber { get; set; }
        public string Pid_TitleMain { get; set; }
        public string Pid_EpisodeTitle { get; set; }
        public string Pid_SynopsisShort { get; set; }
        public string Pid_SynopsisMedium { get; set; }
        public string Pid_SynopsisLong { get; set; }
        public string Pid_ProgramGenres { get; set; }
        public string Pid_ParentalGuidance { get; set; }
        public string Pid_CreditsList { get; set; }
        public string Pid_ProgramImages { get; set; }
        public string Pid_ProductionYear { get; set; }
        public string Pid_ProductionLocation { get; set; }
        public string Pid_RowChanges { get; set; }

    }
}
