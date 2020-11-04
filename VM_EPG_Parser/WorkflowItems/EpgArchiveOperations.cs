using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Epg.Configuration.Manager.Schema.VM_EPG_Parser;
using Epg.File.Manager.Concrete.ArchiveManagement;

namespace VM_EPG_Parser.WorkflowItems
{
    public class EpgArchiveOperations
    {
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
                    var zipManager = new ZipArchiveManager();
                    zipManager.OutputDirectoryPath = EPG_Parser_Config.LocalWorkingDirectory;
                    zipManager.FullEpgPackagePath = epgArchive;

                    switch (archiveExtension)
                    {
                        case ".zip":
                            zipManager.ExtractZipFile();
                            break;
                        case ".gz":
                            zipManager.ExtractGzipFile();
                            break;
                        case ".tar":
                            zipManager.ExtractTarFile();
                            break;
                        case ".tar.gz":
                            zipManager.ExtractTarGzFile();
                            break;
                    }

                    return zipManager.OperationsSuccessful;
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

