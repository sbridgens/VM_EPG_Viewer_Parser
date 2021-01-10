using System;
using System.Diagnostics;
using System.IO;
using Epg.Serialization.Concrete;
using Epg.Entities.Concrete.XMLEntities;
using VM_EPG_Parser.WorkflowItems;
using Epg.Entities.Concrete;
using System.Text;
using Microsoft.Extensions.Configuration;
using VM_EPG_Parser.Config;

namespace VM_EPG_Parser
{
    class ParserMain
    {
        public static IConfigurationRoot Configuration;

        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            Console.WriteLine("Loading Config file.");

            Console.OutputEncoding = Encoding.UTF8;
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("Config/sb_settings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            Console.WriteLine("Loaded Config file.");

            Console.WriteLine($"Connecting to FTP Server: {AppSettings.SftpHost}");

            var sftpOperations = new SftpOperations();
            if (!sftpOperations.RetrieveLatestEpgFile()) 
                return;

            //Need to capture epgfile here and dispose sftp resources
            Console.WriteLine("SFTP Operations completed successfully");
            EpgArchiveOperations archiveOperations = new EpgArchiveOperations();
            EpgScheduleFileHistoryEntities scheduleFileHistory = archiveOperations.ProcessEpgArchive(sftpOperations.LatestEpg.FullName);
            if(scheduleFileHistory != null)
            {
                Console.WriteLine("Epg file Successfully unpacked");
                
                XmlSerializationManager<TVAMain> xmlSerializationManager = new XmlSerializationManager<TVAMain>();
                string xmlInputData = File.ReadAllText(archiveOperations.ExtractedEpgFile);
                TVAMain tVAMain = xmlSerializationManager.Read(xmlInputData);
                scheduleFileHistory.EpgDateTimeParsed = DateTime.UtcNow;

                archiveOperations.ArchiveActiveFile();
                scheduleFileHistory.EpgDateTimeArchived = DateTime.UtcNow;

                TVADBMainEntities dbMainEntity = tVAMain.GetDbEntity(scheduleFileHistory);
                EpgDataSaveOperations.InsertUpdateEpgData(dbMainEntity);
                Console.WriteLine("Data inserted successfully.");
            }
            else 
            {
                Console.WriteLine("Operations Failed during unpacking of Epg File");
            }
        }
    }
}