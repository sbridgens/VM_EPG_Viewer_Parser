using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Configuration
{
    public class SftpSettings
    {
        public string SftpHost { get; set; }
        public string SftpPort { get; set; }
        public string SftpKeyFile { get; set; }
        public string SshHostKeyFingerprint { get; set; }
        public string SftpUserName { get; set; }
        public string SftpKeyOrUserPassword { get; set; }
        public string SftpRoot { get; set; }
    }
}
