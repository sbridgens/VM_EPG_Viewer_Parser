using System;
using Epg.Core.Entities;

namespace Epg.Entities.Concrete
{
    public class ServiceInformationDataEntities : IEntity
    {
        public int Id { get; set; }
        public string Sid_ServiceName { get; set; }
        public string Sid_VM_ServiceId { get; set; }
        public string Sid_Epg_ServiceId { get; set; }
        public string Sid_ServiceLogo { get; set; }
        public string Sid_ChannelResolution { get; set; }
        public string Sid_VM_ServiceGroup { get; set; }
        public string Sid_RowChanges { get; set; }
    }
}
