using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Epg.Configuration.Manager.Schema.VM_EPG_Parser
{
	[XmlRoot(ElementName = "EpgArchive")]
	public class EpgArchive
	{
		[XmlAttribute(AttributeName = "enableArchive")]
		public static bool EnableArchive { get; set; }
		[XmlText]
		public static string EpgArchiveDirectory { get; set; }
	}

	[XmlRoot(ElementName = "ProxyInfo")]
	public class ProxyInfo
	{
		[XmlElement(ElementName = "ProxyType")]
		public static string ProxyType { get; set; }

		[XmlElement(ElementName = "ProxyHost")]
		public static string ProxyHost { get; set; }

		[XmlElement(ElementName = "ProxyPort")]
		public static int ProxyPort { get; set; }

		[XmlElement(ElementName = "ProxyUsername")]
		public static string ProxyUsername { get; set; }

		[XmlElement(ElementName = "ProxyPassword")]
		public static string ProxyPassword { get; set; }

		[XmlAttribute(AttributeName = "useProxy")]
		public static bool UseProxy { get; set; }
	}

	[XmlRoot(ElementName = "EPG_Parser_Config")]
	public class EPG_Parser_Config
	{
		[XmlElement(ElementName = "LocalWorkingDirectory")]
		public static string LocalWorkingDirectory { get; set; }

		[XmlElement(ElementName = "EpgDownloadDirectory")]
		public static string EpgDownloadDirectory { get; set; }
		
		[XmlElement(ElementName = "EpgArchive")]
		public EpgArchive EpgArchive { get; set; }
		[XmlElement(ElementName = "FailedToParseDirectory")]
		public static string FailedToParseDirectory { get; set; }

		[XmlElement(ElementName = "SftpHost")]
		public static string SftpHost { get; set; }

		[XmlElement(ElementName = "SftpPort")]
		public static int SftpPort { get; set; }

		[XmlElement(ElementName = "SftpKeyFile")]
		public static string SftpKeyFile { get; set; }

		[XmlElement(ElementName = "SshHostKeyFingerprint")]
		public static string SshHostKeyFingerprint { get; set; }

		[XmlElement(ElementName = "SftpUserName")]
		public static string SftpUserName { get; set; }

		[XmlElement(ElementName = "SftpKeyOrUserPassword")]
		public static string SftpKeyOrUserPassword { get; set; }

		[XmlElement(ElementName = "SftpRoot")]
		public static string SftpRoot { get; set; }

		[XmlElement(ElementName = "ProxyInfo")]
		public ProxyInfo ProxyInfo { get; set; }

		[XmlElement(ElementName = "DownloadFilesOfType")]
		public static string DownloadFilesOfType { get; set; }

		[XmlElement(ElementName = "DbHost")]
		public static string DbHost { get; set; }

		[XmlElement(ElementName = "DbPort")]
		public static int DbPort { get; set; }

		[XmlElement(ElementName = "DbUser")]
		public static string DbUser { get; set; }

		[XmlElement(ElementName = "DbPass")]
		public static string DbPass { get; set; }

		[XmlElement(ElementName = "DatabaseName")]
		public static string DatabaseName { get; set; }
	}
}
