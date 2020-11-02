using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Epg.Configuration.Manager.Concrete;
using Epg.Configuration.Manager.Schema.VM_EPG_Parser;
using Epg.File.Manager.Concrete.SftpManagement;
using Epg.File.Manager.Enum;
using Epg.Serialization.Concrete;
using WinSCP;

namespace VM_EPG_Parser
{
    class ParserMain
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var xmlSerializer = new XmlSerializationManager<TVAMain>();
            //TVAMain epgFile;

            //epgFile = xmlSerializer.Read(System.IO.File.ReadAllText(@"C:\Users\Simon\Desktop\formatted_tva_epg_file.xml"));

            //var programData = epgFile.ProgramDescription.ProgramInformationTable;
            //var seriesData = epgFile.ProgramDescription.GroupInformationTable;

            //foreach (var item in programData)
            //{
            //    Console.WriteLine($"Program ID: {item?.programId}");
            //}
            //watch.Stop();
            //Console.WriteLine($"Completed in {watch.Elapsed.TotalSeconds} Seconds");

            Console.WriteLine("Loading Config file");
            var xmlConfigSerializer = new ConfigSerializationHelper<EPG_Parser_Config>();
            if (!xmlConfigSerializer.LoadConfigurationFile("./Config/EPG_Parser_Config.xml"))
            {
                Console.WriteLine("Failed to Load config file?");
            }
            else
            {
                Console.WriteLine("Successfully Loaded Configuration File");

            }
            //if (!xmlSerializer .LoadConfigurationFile(Settings.Default.XmlConfigFile))
            //    return false;

            //Console.WriteLine($"Program ID: {programData?.programId}");
            //Console.WriteLine($"Series Crid: {seriesData?.groupId}");
            //PrivateKeyFile keyFile = new PrivateKeyFile(@"D:\VmEpgTesting\.ssh\id_rsa");
            //var keyFiles = new[] { keyFile };
            //var methods = new List<AuthenticationMethod>();
            //methods.Add(new PrivateKeyAuthenticationMethod("uk_hzn4", keyFiles));
            //ConnectionInfo con = new ConnectionInfo("airflow-sftp.horizongo.eu", 22, "uk_hzn4", methods.ToArray());

            //SftpClient sftpClient = new SftpClient(con);
            //sftpClient.HostKeyReceived += delegate (object sender, HostKeyEventArgs e)
            //{
            //    Console.WriteLine(e.FingerPrint);
            //    Console.WriteLine(ConvertFingerprintToByteArray(e.FingerPrint.ToString()));
            //    if (e.FingerPrint.SequenceEqual(ConvertFingerprintToByteArray("1d:c1:5a:71:c4:8e:a3:ff:01:0a:3b:46:17:6f:e1:52")))
            //        e.CanTrust = true;
            //    else
            //        e.CanTrust = false;
            //};

            //SessionOptions sessionOptions = new SessionOptions
            //{
            //    Protocol = Protocol.Sftp,
            //    HostName = "airflow-sftp.horizongo.eu",
            //    UserName = "uk_hzn4",
            //    Password = "",
            //    SshHostKeyFingerprint = "SHA256:9SkvY4im7ric05fqMmWpJD9icI5w2+HcLsMbIQWGnt0"
            //};



            Console.WriteLine($"Connecting to FTP Server: {EPG_Parser_Config.SftpHost}");

            SftpClientManager sftpClient = new SftpClientManager();

            sftpClient.SftpOptions = new SessionOptions
            {
                Protocol = Protocol.Sftp,
                HostName = EPG_Parser_Config.SftpHost,
                UserName = EPG_Parser_Config.SftpUserName,
                Password = EPG_Parser_Config.SftpKeyOrUserPassword,
                PortNumber = EPG_Parser_Config.SftpPort,
                SshHostKeyFingerprint = EPG_Parser_Config.SshHostKeyFingerprint,
                SshPrivateKeyPath = EPG_Parser_Config.SftpKeyFile
            };

            if (ProxyInfo.UseProxy)
            {
                var pMethod = (ProxyMethod) Enum.Parse(typeof(ProxyMethod),ProxyInfo.ProxyType);
                sftpClient.SftpOptions.AddRawSettings("ProxyMethod",$"{(int)pMethod}");
                sftpClient.SftpOptions.AddRawSettings("ProxyHost", ProxyInfo.ProxyHost);
                sftpClient.SftpOptions.AddRawSettings("ProxyPort", $"{ProxyInfo.ProxyPort}");
                sftpClient.SftpOptions.AddRawSettings("ProxyUsername", ProxyInfo.ProxyUsername);
                sftpClient.SftpOptions.AddRawSettings("ProxyPassword", ProxyInfo.ProxyPassword);
            }

            sftpClient.SftpSession = new Session();

            sftpClient.ConnectAndDownloadEpgData(
                sftpRootDirectory: EPG_Parser_Config.SftpRoot, 
                EPG_Parser_Config.DownloadFilesOfType, 
                EPG_Parser_Config.LocalWorkingDirectory, 
                archiveDirectory: EpgArchive.EpgArchiveDirectory);

        }
    }
}
