using System;
using System.IO;
using System.Linq;
using Epg.File.Manager.Abstract;
using WinSCP;

namespace Epg.File.Manager.Concrete.SftpManagement
{
    public class SftpClientManager : ISftpClientInterface
    {
        public bool UseProxy { get; set; }
        public FileInfo EpgTarBall { get; set; }
        public string SftpAllowedHostFingerprint { get; set; }
        public SessionOptions SftpOptions { get; set; }
        public Session SftpSession { get; set; }
        public bool SftpTransferOperationResult { get; set; }


        public void ConnectAndDownloadEpgData(string sftpRootDirectory, string remoteFileExtensionToCheck, string localDownloadDirectory, string archiveDirectory)
        {
            try
            {
                SftpTransferOperationResult = false;
                SftpSession.DebugLogLevel = 2;
                //Connect to remote SFTP Server
                SftpSession.Open(SftpOptions);

                Console.WriteLine("Successfully connected to SFTP Server");
                //List SFTP Directory
                var sftpDirectoryInfo = SftpSession.ListDirectory(sftpRootDirectory);
                Console.WriteLine("Listing directory and obtaining latest file.");
                //Select the Most recent File
                var latestEpgTarball = sftpDirectoryInfo.Files
                    .Where(epg => !epg.IsDirectory)
                    .OrderByDescending(epg => epg.LastWriteTime)
                    .FirstOrDefault();

                if (latestEpgTarball == null)
                {
                    throw new Exception("No Files Found? Check configuration.");
                }

                var remoteFileExtension = Path.GetExtension(latestEpgTarball.Name);

                if (remoteFileExtension == remoteFileExtensionToCheck)
                {
                    var localFile = Path.Combine(localDownloadDirectory, latestEpgTarball.Name);
                    var archivedFile = Path.Combine(archiveDirectory, latestEpgTarball.Name);

                    if (System.IO.File.Exists(localFile) || System.IO.File.Exists(archivedFile))
                    {
                        Console.WriteLine($"Epg file: {latestEpgTarball.Name} has previously been downloaded.");
                        SftpTransferOperationResult = true;
                    }
                    else
                    {
                        var operationResult = SftpSession.GetFiles(RemotePath.EscapeFileMask(latestEpgTarball.FullName), localDownloadDirectory);
                        if (operationResult.IsSuccess)
                        {
                            Console.WriteLine($"Remote File: {latestEpgTarball.FullName} Downloaded successfully");
                            EpgTarBall = new FileInfo(localFile);
                            SftpTransferOperationResult = true;
                        }
                        else
                        {
                            throw new Exception($"Failed to download file: {operationResult.Failures[0]}");
                        }
                    }
                }
                else
                {
                    throw new Exception(
                        $"Remote file extension does not match required extension: Required = {remoteFileExtensionToCheck}, Sftp File = {remoteFileExtension}");
                }

            }
            catch (Exception cadedException)
            {
                Console.WriteLine(
                    $"[ConnectAndDownloadEpgData] Failure during sftp opertions: {cadedException.Message}");
            }
            finally
            {
                if (SftpSession.Opened)
                {
                    SftpSession.Close();
                }
            }
        }
    }
}
