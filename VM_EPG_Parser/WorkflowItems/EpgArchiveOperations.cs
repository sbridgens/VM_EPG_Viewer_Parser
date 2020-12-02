using System;
using System.Collections.Generic;
using System.Linq;
using Epg.Configuration.Manager.Schema.VM_EPG_Parser;
using Epg.File.Manager.Concrete.ArchiveManagement;

namespace VM_EPG_Parser.WorkflowItems
{
    public class EpgArchiveOperations
    {
        private ZipArchiveManager ZipManager { get; set; }
        public string ExtractedEpgFile { get; set; }

        // Ordering of double extensions is important.
        private static readonly List<string> AllowedExtensions = new List<string>()
        {
            "tar.gz",
            "zip",
            "gz",
            "tar"
        };

        private static string GetArchiveExtension(string epgArchive)
        {
            foreach (var ext in AllowedExtensions.Where(ext => epgArchive.EndsWith($".{ext}")))
            {
                return $".{ext}";
            }
            return string.Empty;
        }

        public bool ProcessEpgArchive(string epgArchive)
        {
            try
            {
                var archiveExtension = GetArchiveExtension(epgArchive);

                if (!string.IsNullOrEmpty(archiveExtension))
                {
                    Console.WriteLine("Unpacking EPG File");
                    ZipManager = new ZipArchiveManager();
                    ZipManager.OutputDirectoryPath = EPG_Parser_Config.LocalWorkingDirectory;
                    ZipManager.FullEpgPackagePath = epgArchive;
                    ZipManager.CanArchive = EpgArchive.EnableArchive;
                    ZipManager.EpgArchiveDirectory = EpgArchive.EpgArchiveDirectory;

                    ZipManager.CleanExtractionDirectory();

                    switch (archiveExtension)
                    {
                        case ".zip":
                            ZipManager.ExtractZipFile();
                            break;
                        case ".gz":
                            ZipManager.ExtractGzipFile();
                            break;
                        case ".tar":
                            ZipManager.ExtractTarFile();
                            break;
                        case ".tar.gz":
                            ZipManager.ExtractTarGzFile();
                            break;
                    }

                    return ZipManager.OperationsSuccessful;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            return false;
        }
    }
}

