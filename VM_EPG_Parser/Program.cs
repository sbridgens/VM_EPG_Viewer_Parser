﻿using System;
using System.Diagnostics;
using System.IO;
using Epg.Serialization.Concrete;
using Epg.Entities.Concrete.XMLEntities;
using VM_EPG_Parser.WorkflowItems;
using Epg.Entities.Concrete;
using System.Text;
using Application.BusinessLogic.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;



namespace VM_EPG_Parser
{
    class Program
    {
        public static IConfiguration Configuration { get; private set; }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Loading Config file.");
            IServiceCollection serviceCollection = new ServiceCollection();
            Startup startup = new Startup();
            startup.ConfigureServices(serviceCollection);

            //SB: for service scope when added create serviceprovider
            //then use service provider to inject ILoggerFactory from logging libs
            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            var service = serviceProvider.GetService<IWorker>();
            service.DoWork();

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Loaded Config file.");

            //Console.WriteLine($"Connecting to FTP Server: {AppSettings.SftpHost}");

            //var sftpOperations = new SftpOperations();
            //if (!sftpOperations.RetrieveLatestEpgFile()) 
            //    return;

            //////Need to capture epgfile here and dispose sftp resources
            //Console.WriteLine("SFTP Operations completed successfully");
            //EpgArchiveOperations archiveOperations = new EpgArchiveOperations();
            //bool isUnpackedSuccess = archiveOperations.ProcessEpgArchive(sftpOperations.LatestEpg.FullName);
            //if(isUnpackedSuccess)
            //{
            //    Console.WriteLine("Epg file Successfully unpacked");
            //    XmlSerializationManager<TVAMain> xmlSerializationManager = new XmlSerializationManager<TVAMain>();
            //    string xmlInputData = File.ReadAllText(archiveOperations.ExtractedEpgFile);
            //    TVAMain tVAMain = xmlSerializationManager.Read(xmlInputData);
            //    TVADBMainEntities dbMainEntity = tVAMain.GetDbEntity();

            //    EpgDataSaveOperations.InsertUpdateEpgData(dbMainEntity);
            //}
            //else
            //{
            //    Console.WriteLine("Operations Failed during unpacking of Epg File");
            //}
        }
    }
}