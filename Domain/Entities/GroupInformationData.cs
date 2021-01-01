namespace Domain.Entities
{
    public partial class GroupInformationData
    {
        public int Id { get; set; }
        public string GidGroupId { get; set; }
        public string GidConnectorId { get; set; }
        public string GidType { get; set; }
        public string GidSeriesTitle { get; set; }
        public string GidSeriesId { get; set; }
        public string GidSeriesNumber { get; set; }
        public string GidSeriesCrid { get; set; }
        public string GidSynopsis { get; set; }
        public string GidGenres { get; set; }
        public string GidLanguage { get; set; }
        public string GidCreditsList { get; set; }
        public string GidSeriesImages { get; set; }
        public string GidProductionYear { get; set; }
        public string GidRowChanges { get; set; }
    }
}
