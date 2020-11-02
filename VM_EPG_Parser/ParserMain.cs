using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Epg.Configuration.Manager.Concrete;
using Epg.Configuration.Manager.Schema.VM_EPG_Parser;
using Epg.File.Manager.Concrete.SftpManagement;
using Epg.File.Manager.Enum;
using Epg.Serialization.Concrete;
using VM_EPG_Parser.WorkflowItems;
using WinSCP;

namespace VM_EPG_Parser
{
    class ParserMain
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var xmlSerializer = new XmlSerializationManager<TVAMain>();
            //TVAMain epgFile;

            //epgFile = xmlSerializer.Read(System.IO.File.ReadAllText(@"C:\Users\Simon\Desktop\formatted_tva_epg_file.xml"));

            //var programData = epgFile.ProgramDescription.ProgramInformationTable;
            //var seriesData = epgFile.ProgramDescription.GroupInformationTable;

            //foreach (var item in programData)
            //{
            //    Console.WriteLine($"Program ID: {item?.programId}");
            //}
            //watch.Stop();
            //Console.WriteLine($"Completed in {watch.Elapsed.TotalSeconds} Seconds");

            Console.WriteLine("Loading Config file");
            var xmlConfigSerializer = new ConfigSerializationHelper<EPG_Parser_Config>();
            if (!xmlConfigSerializer.LoadConfigurationFile("./Config/EPG_Parser_Config.xml"))
            {
                Console.WriteLine("Failed to Load config file?");
            }
            else
            {
                Console.WriteLine("Successfully Loaded Configuration File");

            }


            Console.WriteLine($"Connecting to FTP Server: {EPG_Parser_Config.SftpHost}");

            var sftpOperations = new SftpOperations();
            if(sftpOperations.RetrieveLatestEpgFile());
            {
                Console.WriteLine("SFTP Operations completed successfully");
            }

        }
    }
}
