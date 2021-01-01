namespace Domain.Entities
{
    public partial class ProgramInformationData
    {
        public int Id { get; set; }
        public string PidCrid { get; set; }
        public string PidTmsId { get; set; }
        public string PidRootId { get; set; }
        public string PidImdbId { get; set; }
        public string PidSeriesLink { get; set; }
        public string PidEpisodeNumber { get; set; }
        public string PidTitleMain { get; set; }
        public string PidEpisodeTitle { get; set; }
        public string PidSynopsisShort { get; set; }
        public string PidSynopsisMedium { get; set; }
        public string PidSynopsisLong { get; set; }
        public string PidProgramGenres { get; set; }
        public string PidParentalGuidance { get; set; }
        public string PidCreditsList { get; set; }
        public string PidProgramImages { get; set; }
        public string PidProductionYear { get; set; }
        public string PidProductionLocation { get; set; }
        public string PidRowChanges { get; set; }
    }
}
