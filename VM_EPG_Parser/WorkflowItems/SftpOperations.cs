using System;
using System.IO;
using Epg.Configuration.Manager.Schema.VM_EPG_Parser;
using Epg.File.Manager.Concrete.SftpManagement;
using Epg.File.Manager.Enum;
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
                    HostName = EPG_Parser_Config.SftpHost,
                    UserName = EPG_Parser_Config.SftpUserName,
                    Password = EPG_Parser_Config.SftpKeyOrUserPassword,
                    PortNumber = EPG_Parser_Config.SftpPort,
                    SshHostKeyFingerprint = EPG_Parser_Config.SshHostKeyFingerprint,
                    SshPrivateKeyPath = EPG_Parser_Config.SftpKeyFile
                }
            };


            if (ProxyInfo.UseProxy)
            {
                var pMethod = (ProxyMethod)Enum.Parse(typeof(ProxyMethod), ProxyInfo.ProxyType);
                sftpClient.SftpOptions.AddRawSettings("ProxyMethod", $"{(int)pMethod}");
                sftpClient.SftpOptions.AddRawSettings("ProxyHost", ProxyInfo.ProxyHost);
                sftpClient.SftpOptions.AddRawSettings("ProxyPort", $"{ProxyInfo.ProxyPort}");
                sftpClient.SftpOptions.AddRawSettings("ProxyUsername", ProxyInfo.ProxyUsername);
                sftpClient.SftpOptions.AddRawSettings("ProxyPassword", ProxyInfo.ProxyPassword);
            }

            sftpClient.SftpSession = new Session();

            sftpClient.ConnectAndDownloadEpgData(
                sftpRootDirectory: EPG_Parser_Config.SftpRoot,
                EPG_Parser_Config.DownloadFilesOfType,
                localDownloadDirectory: EPG_Parser_Config.EpgDownloadDirectory,
                archiveDirectory: EpgArchive.EpgArchiveDirectory);

            LatestEpg = sftpClient.EpgTarBall;

            return sftpClient.SftpTransferOperationResult;
        }
    }
}
