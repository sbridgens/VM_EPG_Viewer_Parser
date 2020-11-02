using System;
using Epg.Core.Entities;

namespace Epg.Entities.Concrete
{
    public class ProgramScheduleDataEntities : IEntity
    {
        public int Id { get; set; }
        public string Psd_ServiceIdReference { get; set; }
        public DateTime? Psd_ScheduleStart { get; set; }
        public DateTime? Psd_ScheduleEnd { get; set; }
        public string Psd_ScheduleDuration { get; set; }
        public string Psd_ProgramCrid { get; set; }
        public string Psd_ProgramImi { get; set; }
        public string Psd_PurchaseList { get; set; }
        public string Psd_CaptionLanguage { get; set; }
        public string Psd_AV_Attributes { get; set; }
        public string Psd_TmsId { get; set; }
        public DateTime? Psd_ScheduledStartTime { get; set; }
        public DateTime? Psd_ScheduledEndTime { get; set; }
        public string Psd_EventDuration { get; set; }
        public string Psd_RowChange { get; set; }
    }
}
