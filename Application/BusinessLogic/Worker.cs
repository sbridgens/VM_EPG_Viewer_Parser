using System;
using System.Text;
using Application.BusinessLogic.Contracts;
using Application.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Application.BusinessLogic
{
    public class Worker : IWorker
    {
        private AppSettings _appSettings;
        private DatabaseSettings _dbSettings;
        private SftpSettings _sftpSettings;
        private ProxySettings _proxySettings;

        private readonly IServiceScopeFactory _scopeFactory;
        public Worker(IServiceScopeFactory scopeFactory, 
            IOptions<AppSettings> appOptions, 
            IOptions<DatabaseSettings> dbOptions,
            IOptions<SftpSettings> sftpOptions,
            IOptions<ProxySettings> proxyOptions)
        {
            _scopeFactory = scopeFactory;
            _appSettings = appOptions.Value;
            _dbSettings = dbOptions.Value;
            _sftpSettings = sftpOptions.Value;
            _proxySettings = proxyOptions.Value;
        }

        public void DoWork()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Loaded Config file.");

            Console.WriteLine($"Connecting to FTP Server: {_sftpSettings.SftpHost}");
            using var scope = _scopeFactory.CreateScope();
            var sftpProcessor = scope.ServiceProvider.GetRequiredService<ISftpOperations>();
            
            if (!sftpProcessor.RetrieveLatestEpgFile())
                return;

            ////Need to capture epgfile here and dispose sftp resources
            //Console.WriteLine("SFTP Operations completed successfully");
            //EpgArchiveOperations archiveOperations = new EpgArchiveOperations();
            //bool isUnpackedSuccess = archiveOperations.ProcessEpgArchive(sftpProcessor.LatestEpg.FullName);
            //if (isUnpackedSuccess)
            //{
            //    Console.WriteLine("Epg file Successfully unpacked");
            //    XmlSerializationManager xmlSerializationManager = new XmlSerializationManager();
            //    string xmlInputData = File.ReadAllText(archiveOperations.ExtractedEpgFile);
            //    TVAMain tVAMain = xmlSerializationManager.Read<TVAMain>(xmlInputData);
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
