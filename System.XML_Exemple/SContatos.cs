using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace System.XML_Exemple
{
    public class SContatos
    {
        static string arquivo = Properties.Resources.Agenda; // @"E:\Erick\Estudos\DevMidia C#\Framework\System.XML_Exemple\XML\Agenda.xml";
        static XmlDocument xDoc = new XmlDocument();
        static XElement elementX;
        static Contatos contatos;

        public SContatos()
        {
            if (!File.Exists(arquivo))
            {
                XmlNode nodeRoot = xDoc.CreateElement("Contatos");
                xDoc.AppendChild(nodeRoot);
                xDoc.Save(arquivo);
            }
        }

        public static Contatos Read()
        {
            //Deserelizador
            elementX = XElement.Load(arquivo);
            contatos = Serializador.Deserialize<Contatos>(elementX);

            return contatos;
        }

        public static void Write(Contatos contatos)
        {
            //Serializador
            XElement xReturn = Serializador.Serialize<Contatos>(contatos);
            xReturn.Save(arquivo);
        }

    }
}
