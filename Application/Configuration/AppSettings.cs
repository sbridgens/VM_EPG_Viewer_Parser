using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Configuration
{
    public class AppSettings
    {
        public string EnableArchive { get; set; }
        public string ArchiveDirectory { get; set; }
        public string LocalWorkingDirectory { get; set; }
        public string EpgDownloadDirectory { get; set; }
        public string FailedToParseDirectory { get; set; }
        public string DownloadFilesOfType { get; set; }
    }
}
