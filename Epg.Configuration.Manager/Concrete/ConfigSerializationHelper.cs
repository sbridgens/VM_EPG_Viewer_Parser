using System;
using System.Xml.Linq;
using System.Xml.Serialization;
using Epg.Configuration.Manager.Schema.VM_EPG_Parser;

namespace Epg.Configuration.Manager.Concrete
{
    public class ConfigSerializationHelper<T>
    {
        private readonly Type type;

        public ConfigSerializationHelper()
        {
            type = typeof(T);
        }

        public bool LoadConfigurationFile(string configFile)
        {
            var configLoaded = true;
            var xDoc = XDocument.Load(configFile);
            if (xDoc.Root == null)
                return false;
            var configs = xDoc.Elements(xDoc.Root.Name);
            var properties = type.GetProperties();
            foreach (var ele in configs.Descendants())
            {
                foreach (var pinf in properties)
                {
                    if (pinf.Name != ele.Name.LocalName) 
                        continue;

                    switch (ele.Name.LocalName)
                    {
                        case "SftpPort":
                            EPG_Parser_Config1.SftpPort = Convert.ToInt32(ele.Value);
                            break;
                        case "DbPort":
                            EPG_Parser_Config1.DbPort = Convert.ToInt32(ele.Value);
                            break;
                        case "EpgArchive":
                            EpgArchive1.EnableArchive = Convert.ToBoolean(ele.Attribute("enableArchive")?.Value);
                            EpgArchive1.EpgArchiveDirectory = ele.Value;
                            break;
                        case "ProxyInfo":
                            ProxyInfo1.UseProxy = Convert.ToBoolean(ele.Attribute("useProxy")?.Value);
                            foreach (var pval in ele.Descendants())
                            {
                                switch (pval.Name.LocalName)
                                {
                                    case "ProxyType":
                                        ProxyInfo1.ProxyType = pval.Value;
                                        break;
                                    case "ProxyHost":
                                        ProxyInfo1.ProxyHost = pval.Value;
                                        break;
                                    case "ProxyUsername":
                                        ProxyInfo1.ProxyUsername = pval.Value;
                                        break;
                                    case "ProxyPassword":
                                        ProxyInfo1.ProxyPassword = pval.Value;
                                        break;
                                    case "ProxyPort":
                                        ProxyInfo1.ProxyPort = !string.IsNullOrEmpty(pval.Value)
                                            ? Convert.ToInt32(pval.Value)
                                            : 0;
                                        break;
                                }
                            }
                            break;

                        default:
                            pinf.SetValue(pinf.Name, ele.Value);

                            if (pinf.GetValue(null, null) != null)
                            {
                            }
                            else
                            {
                                Console.WriteLine(
                                    $"Failed to load config value: \"{pinf.Name}\", please check configuration");
                                configLoaded = false;
                            }

                            break;
                    }
                }
            }

            return configLoaded;
        }
    }
}
