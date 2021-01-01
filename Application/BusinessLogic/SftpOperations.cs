using System;
using System.IO;
using Application.BusinessLogic.Contracts;
using Application.Configuration;
using Epg.File.Manager.Concrete.SftpManagement;
using Epg.File.Manager.Enum;
using Microsoft.Extensions.Options;
using WinSCP;

namespace Application.BusinessLogic
{
    public class SftpOperations : ISftpOperations
    {
        private AppSettings _appSettings;
        private SftpSettings _sftpSettings;
        private ProxySettings _proxySettings;

        public FileInfo LatestEpg { get; set; }
        public SftpOperations(
            IOptions<AppSettings> appOptions,
            IOptions<SftpSettings> sftpOptions, 
            IOptions<ProxySettings> proxyOptions)
        {
            _appSettings = appOptions.Value;
            _sftpSettings = sftpOptions.Value;
            _proxySettings = proxyOptions.Value;
        }

        public bool RetrieveLatestEpgFile()
        {
            var sftpClient = new SftpClientManager
            {
                SftpOptions = new SessionOptions
                {
                    Protocol = Protocol.Sftp,
                    HostName = _sftpSettings.SftpHost,
                    UserName = _sftpSettings.SftpUserName,
                    Password = _sftpSettings.SftpKeyOrUserPassword,
                    PortNumber = Convert.ToInt32(_sftpSettings.SftpPort),
                    SshHostKeyFingerprint = _sftpSettings.SshHostKeyFingerprint,
                    SshPrivateKeyPath = _sftpSettings.SftpKeyFile
                }
            };


            if (Convert.ToBoolean(_proxySettings.UseProxy))
            {
                var pMethod = (ProxyMethod)Enum.Parse(typeof(ProxyMethod), _proxySettings.ProxyType);
                sftpClient.SftpOptions.AddRawSettings("ProxyMethod", $"{(int)pMethod}");
                sftpClient.SftpOptions.AddRawSettings("ProxyHost", _proxySettings.ProxyHost);
                sftpClient.SftpOptions.AddRawSettings("ProxyPort", $"{_proxySettings.ProxyPort}");
                sftpClient.SftpOptions.AddRawSettings("ProxyUsername", _proxySettings.ProxyUsername);
                sftpClient.SftpOptions.AddRawSettings("ProxyPassword", _proxySettings.ProxyPassword);
            }

            sftpClient.SftpSession = new Session();

            sftpClient.ConnectAndDownloadEpgData(
                sftpRootDirectory: _sftpSettings.SftpRoot,
                _appSettings.DownloadFilesOfType,
                localDownloadDirectory:_appSettings.EpgDownloadDirectory,
                archiveDirectory:_appSettings.ArchiveDirectory);

            LatestEpg = sftpClient.EpgTarBall;

            return sftpClient.SftpTransferOperationResult;
        }
    }
}
