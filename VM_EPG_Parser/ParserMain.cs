using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Epg.Configuration.Manager.Concrete;
using Epg.Configuration.Manager.Schema.VM_EPG_Parser;
using Epg.Serialization.Concrete;
using VM_EPG_Parser.WorkflowItems;

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
            Console.WriteLine(!xmlConfigSerializer.LoadConfigurationFile("./Config/EPG_Parser_Config.xml")
                ? "Failed to Load config file?"
                : "Successfully Loaded Configuration File");


            Console.WriteLine($"Connecting to FTP Server: {EPG_Parser_Config.SftpHost}");

            var sftpOperations = new SftpOperations();
            if(sftpOperations.RetrieveLatestEpgFile())
            {
                Console.WriteLine("SFTP Operations completed successfully");
            }
        }
    }
}
