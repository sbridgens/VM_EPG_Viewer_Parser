using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Application.BusinessLogic.Contracts
{
    public interface ISftpOperations
    {
        FileInfo LatestEpg { get; set; }

        bool RetrieveLatestEpgFile();
    }
}
