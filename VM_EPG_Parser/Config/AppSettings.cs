using System;
using System.Collections.Generic;
using System.Text;

namespace VM_EPG_Parser.Config
{
    public class AppSettings
    {
        public static bool EnableArchive 
        {
            get
            {
                return Convert.ToBoolean(ParserMain.Configuration["EpgArchive:EnableArchive"]);
            }
        }
        public static string EpgArchiveDirectory
        {
            get
            {
                return Convert.ToString(ParserMain.Configuration["EpgArchive:Directory"]);
            }
        }

        public static string ProxyType
        {
            get
            {
                return Convert.ToString(ParserMain.Configuration["ProxyInfo:ProxyType"]);
            }
        }

        public static string ProxyHost
        {
            get
            {
                return Convert.ToString(ParserMain.Configuration["ProxyInfo:ProxyHost"]);
            }
        }
        public static int ProxyPort
        {
            get
            {
                return Convert.ToInt32(ParserMain.Configuration["ProxyInfo:ProxyPort"]);
            }
        }
        public static string ProxyUsername
        {
            get
            {
                return Convert.ToString(ParserMain.Configuration["ProxyInfo:ProxyUsername"]);
            }
        }
        public static string ProxyPassword
        {
            get
            {
                return Convert.ToString(ParserMain.Configuration["ProxyInfo:ProxyPassword"]);
            }
        }
        public static bool UseProxy
        {
            get
            {
                return Convert.ToBoolean(ParserMain.Configuration["ProxyInfo:UseProxy"]);
            }
        }

        public static string LocalWorkingDirectory
        {
            get
            {
                return Convert.ToString(ParserMain.Configuration["DirectoryInfo:LocalWorkingDirectory"]);
            }
        }

        public static string EpgDownloadDirectory
        {
            get
            {
                return Convert.ToString(ParserMain.Configuration["DirectoryInfo:EpgDownloadDirectory"]);
            }
        }

        public static string FailedToParseDirectory
        {
            get
            {
                return Convert.ToString(ParserMain.Configuration["DirectoryInfo:FailedToParseDirectory"]);
            }
        }

        public static string SftpHost
        {
            get
            {
                return Convert.ToString(ParserMain.Configuration["SFTPInfo:SftpHost"]);
            }
        }

        public static int SftpPort
        {
            get
            {
                return Convert.ToInt32(ParserMain.Configuration["SFTPInfo:SftpPort"]);
            }
        }

        public static string SftpKeyFile
        {
            get
            {
                return Convert.ToString(ParserMain.Configuration["SFTPInfo:SftpKeyFile"]);
            }
        }

        public static string SshHostKeyFingerprint
        {
            get
            {
                return Convert.ToString(ParserMain.Configuration["SFTPInfo:SshHostKeyFingerprint"]);
            }
        }

        public static string SftpUserName
        {
            get
            {
                return Convert.ToString(ParserMain.Configuration["SFTPInfo:SftpUserName"]);
            }
        }

        public static string SftpKeyOrUserPassword
        {
            get
            {
                return Convert.ToString(ParserMain.Configuration["SFTPInfo:SftpKeyOrUserPassword"]);
            }
        }

        public static string SftpRoot
        {
            get
            {
                return Convert.ToString(ParserMain.Configuration["SFTPInfo:SftpRoot"]);
            }
        }


        public static string DownloadFilesOfType
        {
            get
            {
                return Convert.ToString(ParserMain.Configuration["General:DownloadFilesOfType"]);
            }
        }
    }
}
