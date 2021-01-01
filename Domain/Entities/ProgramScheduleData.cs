using System;

namespace Domain.Entities
{
    public partial class ProgramScheduleData
    {
        public int Id { get; set; }
        public string PsdServiceIdReference { get; set; }
        public DateTime PsdScheduleStart { get; set; }
        public DateTime PsdScheduleEnd { get; set; }
        public string PsdScheduleDuration { get; set; }
        public string PsdProgramCrid { get; set; }
        public string PsdProgramImi { get; set; }
        public string PsdPurchaseList { get; set; }
        public string PsdCaptionLanguage { get; set; }
        public string PsdAvAttributes { get; set; }
        public string PsdTmsId { get; set; }
        public DateTime PsdScheduledStartTime { get; set; }
        public DateTime PsdScheduledEndTime { get; set; }
        public string PsdEventDuration { get; set; }
        public string PsdRowChange { get; set; }
    }
}
