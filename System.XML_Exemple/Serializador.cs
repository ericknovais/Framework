using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace System.XML_Exemple
{
    public static class Serializador
    {
        public static  T Deserialize<T>(this XElement xElement)
        {
            using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(xElement.ToString())))
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(memoryStream);
            }
        }

        public static  XElement Serialize<T>(this object obj)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (TextWriter streamWrite = new StreamWriter(memoryStream))
                {
                    var xmlSerialize = new XmlSerializer(typeof(T));
                    xmlSerialize.Serialize(streamWrite, obj);
                    return XElement.Parse(Encoding.UTF8.GetString(memoryStream.ToArray()));
                }
            }
        }
    }
}
