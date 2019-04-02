using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace System.XML_Exemple
{
    [Serializable()]
    public class Telefone
    {
        public Telefone() { }
        public Telefone(int tipo, string numero)
        {
            Tipo = tipo;
            Numero = numero;
        }

        [XmlElement("Tipo")]
        public int Tipo { get; set; }
        [XmlElement("Numero")]
        public string Numero { get; set; }

        public static string ExNumResidencial = "(99)9999-9999";
        public static string ExNumComercial   = "(99)9999-9999";
        public static string ExNumCelular     = "(99)99999-9999";
    }
}
