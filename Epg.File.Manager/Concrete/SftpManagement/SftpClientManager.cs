using System;
using System.IO;
using System.Linq;
using Epg.File.Manager.Abstract;
using WinSCP;

namespace Epg.File.Manager.Concrete.SftpManagement
{
    public class SftpClientManager : ISftpClientInterface, IDisposable
    {
        public FileInfo EpgTarBall { get; set; }
        public SessionOptions SftpOptions { get; set; }
        public Session SftpSession { get; set; }
        public bool SftpTransferOperationResult { get; set; }
        private RemoteDirectoryInfo SftpDirectoryInfo { get; set; }
        private RemoteFileInfo LatestEpgPackage { get; set; }

        private RemoteFileInfo MostRecentEpgFile()
        {
            return SftpDirectoryInfo.Files
                .Where(epg => !epg.IsDirectory)
                .OrderByDescending(epg => epg.LastWriteTime)
                .FirstOrDefault();
        }

        private bool ValidateEpgPackage(string remoteFileExtensionToCheck)
        {
            if (LatestEpgPackage == null)
            {
                Console.WriteLine("No Files Found? Check configuration.");
                return false;
            }

            Console.WriteLine($"Most recent EPG File: {LatestEpgPackage.Name}");
            var remoteFileExtension = Path.GetExtension(LatestEpgPackage.Name);
            if (remoteFileExtension == remoteFileExtensionToCheck)
                return true;

            Console.WriteLine(
                $"Remote file extension does not match required extension: Required = {remoteFileExtensionToCheck}, Sftp File = {remoteFileExtension}");
            return false;
        }

        private void DownloadEpgPackage(string archiveDirectory, string localDownloadDirectory)
        {
            SftpTransferOperationResult = false;
            var localfile = Path.Combine(localDownloadDirectory, LatestEpgPackage.Name);
            var archivedFile = Path.Combine(archiveDirectory, LatestEpgPackage.Name);

            if (System.IO.File.Exists(localfile) || System.IO.File.Exists(archivedFile))
            {
                Console.WriteLine($"Epg file: {LatestEpgPackage.Name} has previously been downloaded.");
            }
            else
            {
                Console.WriteLine($"Downloading Latest EPG File: {LatestEpgPackage.Name} to {localDownloadDirectory}");
                var operationResult = SftpSession.GetFiles(RemotePath.EscapeFileMask(LatestEpgPackage.FullName), localDownloadDirectory);

                if (operationResult.IsSuccess)
                {
                    Console.WriteLine($"Remote File: {LatestEpgPackage.FullName} Downloaded successfully");
                    EpgTarBall = new FileInfo(localfile);
                    SftpTransferOperationResult = true;
                }
                else
                {
                    throw new Exception($"Failed to download file: {operationResult.Failures[0]}");
                }
            }
        }

        private void CleanUp()
        {
            if (SftpSession.Opened)
            {
                SftpSession.Close();
            }
            //free up unused resources
            SftpOptions = null;
        }

        public void ConnectAndDownloadEpgData(string sftpRootDirectory, string remoteFileExtensionToCheck, string localDownloadDirectory, string archiveDirectory)
        {
            try
            {
                //Connect to remote SFTP Server
                SftpSession.Open(SftpOptions);

                Console.WriteLine("Successfully connected to SFTP Server");
                //List SFTP Directory
                SftpDirectoryInfo = SftpSession.ListDirectory(sftpRootDirectory);
                Console.WriteLine("Listing directory and obtaining latest file.");
                //Select the Most recent File
                LatestEpgPackage = MostRecentEpgFile();


                if (!ValidateEpgPackage(remoteFileExtensionToCheck))
                    return;

                DownloadEpgPackage(archiveDirectory,localDownloadDirectory);

            }
            catch (Exception cadedException)
            {
                Console.WriteLine(
                    $"[ConnectAndDownloadEpgData] Failure during sftp opertions: {cadedException.Message}");
            }
            finally
            {
                CleanUp();
            }
        }

        #region IDisposable

        // Flag: Has Dispose already been called?
        private bool disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                SftpSession?.Dispose();
            }


            disposed = true;
        }

        ~SftpClientManager()
        {
            Dispose(false);
        }

        #endregion
    }
}
