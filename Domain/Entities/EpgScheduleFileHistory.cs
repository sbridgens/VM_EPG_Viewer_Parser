using System;

namespace Domain.Entities
{
    public partial class EpgScheduleFileHistory
    {
        public int Id { get; set; }
        public string EpgFilenameGz { get; set; }
        public string EpgFilenameExtracted { get; set; }
        public string EpgOriginalFileSize { get; set; }
        public string EpgExtractedFileSize { get; set; }
        public DateTime EpgDateTimeRetrieved { get; set; }
        public DateTime EpgDateTimeParsed { get; set; }
        public DateTime EpgDateTimeArchived { get; set; }
        public string EpgArchiveLocation { get; set; }
    }
}
