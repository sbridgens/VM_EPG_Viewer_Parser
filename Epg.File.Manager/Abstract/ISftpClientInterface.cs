using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WinSCP;

namespace Epg.File.Manager.Abstract
{
    public interface ISftpClientInterface
    {
        FileInfo EpgTarBall { get; set; }

        SessionOptions SftpOptions { get; set; }

        Session SftpSession { get; set; }

        bool SftpTransferOperationResult { get; set; }

        void ConnectAndDownloadEpgData(string sftpRootDirectory, string remoteFileExtensionToCheck,
            string localDownloadDirectory, string archiveDirectory);
    }
}
