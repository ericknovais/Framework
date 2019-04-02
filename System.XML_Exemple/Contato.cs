using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace System.XML_Exemple
{
    [Serializable()]
    public class Contato
    {
        [XmlElement("Id")]
        public int Id { get; set; }
        [XmlElement("Nome")]
        public string Nome { get; set; }
        [XmlElement("Telefone")]
        public string Telefone { get; set; }
        [XmlElement("Obs")]
        public string Obs { get; set; }

        StringBuilder _msgErro = new StringBuilder();

        public void ValidarContato()
        {
             _msgErro.Clear() ;
            CamposObrigatorios("Nome", Nome);
            CamposObrigatorios("Telefone", Telefone);
            if (_msgErro.Length > 0)
            {
                throw new Exception(_msgErro.ToString());
            }
        }

        private void CamposObrigatorios(string nomoCampo, string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                _msgErro.AppendFormat("O campo {0} é obrigatório!{1}", nomoCampo, "\n");
            }
        }
    }
}
