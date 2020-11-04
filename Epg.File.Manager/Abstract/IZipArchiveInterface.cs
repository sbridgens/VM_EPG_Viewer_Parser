using System;
using System.Collections.Generic;
using System.Text;

namespace Epg.File.Manager.Abstract
{
    public interface IZipArchiveInterface
    {
        string FullEpgPackagePath { get; set; }
        string OutputDirectoryPath { get; set; }
        string OutputEpgFile { get; set; }
        string EpgArchiveDirectory { get; set; }
        bool OperationsSuccessful { get; set; }
        bool CanArchive { get; set; }
        void ExtractZipFile();
        void ExtractGzipFile();
        void ExtractTarFile();
        void ExtractTarGzFile();
    }
}
