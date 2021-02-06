using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Epg.Serialization.Concrete
{
    public static class ExtensionMethod
    {
        public static string ToXML<T>(this List<T> lst, bool omitXML = true)
        {
            string s = string.Empty;
            XmlSerializer serialiser = new XmlSerializer(typeof(List<T>));
            using (var stream = new StringWriter())
            {
                serialiser.Serialize(stream, lst);
                s = stream.ToString();
            }
            if (omitXML)
                return s.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
            else
                return s;
        }
    }
}
