namespace Domain.Entities
{
    public partial class ServiceInformationData
    {
        public int Id { get; set; }
        public string SidServiceName { get; set; }
        public string SidVmServiceId { get; set; }
        public string SidEpgServiceId { get; set; }
        public string SidServiceLogo { get; set; }
        public string SidChannelResolution { get; set; }
        public string SidVmServiceGroup { get; set; }
        public string SidRowChanges { get; set; }
    }
}
