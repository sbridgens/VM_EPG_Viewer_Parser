using System;
using Epg.Core.Entities;

namespace Epg.Entities.Concrete
{
    public class EpgScheduleFileHistoryEntities : IEntity
    {
        public int Id { get; set; }

        public string EpgFilenameGZ { get; set; }

        public string EpgFilenameExtracted { get; set; }

        public string EpgOriginalFileSize { get; set; }

        public string EpgExtractedFileSize { get; set; }

        public DateTime? EpgDateTimeRetrieved { get; set; }

        public DateTime? EpgDateTimeParsed { get; set; }

        public DateTime? EpgDateTimeArchived { get; set; }

        public string EpgArchiveLocation { get; set; }

    }
}
