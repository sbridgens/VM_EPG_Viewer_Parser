using System;
using System.IO;
using Epg.File.Manager.Concrete.SftpManagement;
using Epg.File.Manager.Enum;
using VM_EPG_Parser.Config;
using WinSCP;

namespace VM_EPG_Parser.WorkflowItems
{
    public class SftpOperations
    {
        public FileInfo LatestEpg { get; set; }
        public bool RetrieveLatestEpgFile()
        {
            var sftpClient = new SftpClientManager
            {
                SftpOptions = new SessionOptions
                {
                    Protocol = Protocol.Sftp,
                    HostName = AppSettings.SftpHost,
                    UserName = AppSettings.SftpUserName,
                    Password = AppSettings.SftpKeyOrUserPassword,
                    PortNumber = AppSettings.SftpPort,
                    SshHostKeyFingerprint = AppSettings.SshHostKeyFingerprint,
                    SshPrivateKeyPath = AppSettings.SftpKeyFile
                }
            };


            if (AppSettings.UseProxy)
            {
                var pMethod = (ProxyMethod)Enum.Parse(typeof(ProxyMethod), AppSettings.ProxyType);
                sftpClient.SftpOptions.AddRawSettings("ProxyMethod", $"{(int)pMethod}");
                sftpClient.SftpOptions.AddRawSettings("ProxyHost", AppSettings.ProxyHost);
                sftpClient.SftpOptions.AddRawSettings("ProxyPort", $"{AppSettings.ProxyPort}");
                sftpClient.SftpOptions.AddRawSettings("ProxyUsername", AppSettings.ProxyUsername);
                sftpClient.SftpOptions.AddRawSettings("ProxyPassword", AppSettings.ProxyPassword);
            }

            sftpClient.SftpSession = new Session();

            sftpClient.ConnectAndDownloadEpgData(
                sftpRootDirectory: AppSettings.SftpRoot,
                AppSettings.DownloadFilesOfType,
                localDownloadDirectory: AppSettings.EpgDownloadDirectory,
                archiveDirectory: AppSettings.EpgArchiveDirectory);

            LatestEpg = sftpClient.EpgTarBall;

            return sftpClient.SftpTransferOperationResult;
        }
    }
}
