using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Epg.Serialization.Concrete
{
    public class XmlSerializationManager<T>
    {
        private readonly Type _type;


        public XmlSerializationManager()
        {
            _type = typeof(T);
        }

        public void Save(string path, object obj)
        {
            using (TextWriter textWriter = new StreamWriter(path))
            {
                var serializer = new XmlSerializer(_type);
                serializer.Serialize(textWriter, obj);
                textWriter.Close();
            }
        }

        public T Read(string fileContent)
        {
            fileContent = fileContent.Replace("xmlns=\"urn:tva:metadata:2010\"", "");
            T result;
            using (TextReader textReader = new StringReader(fileContent))
            {
                using (var reader = new XmlTextReader(textReader))
                {
                    //reader.Namespaces = false;
                    XmlNamespaceManager nsmanager = new XmlNamespaceManager(reader.NameTable);
                    nsmanager.AddNamespace("mpeg7", "urn:tva:mpeg7:2008");
                    nsmanager.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                    nsmanager.PushScope();
                    //nsmanager.AddNamespace(null, "urn:tva:metadata:2010");
                    XmlSerializer serializer = new XmlSerializer(_type, new XmlRootAttribute("TVAMain"));
                    XmlReaderSettings settings = new XmlReaderSettings();
                    using (XmlReader xmlReader = XmlReader.Create(reader, settings))
                    {
                        result = (T)serializer.Deserialize(reader);
                    }
                }
            }

            return result;
        }
    }
}