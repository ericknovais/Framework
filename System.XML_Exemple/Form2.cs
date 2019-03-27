using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace System.XML_Exemple
{
    public partial class Form2 : Form
    {
        string arquivo = @"E:\Erick\Estudos\DevMidia C#\Framework\System.XML_Exemple\XML\Agenda2.xml";
        XmlDocument xmlDoc = new XmlDocument();
        public Form2()
        {
            InitializeComponent();
            if (!File.Exists(arquivo))
            {

                XmlNode nodeRoot = xmlDoc.CreateElement("Contatos");
                xmlDoc.AppendChild(nodeRoot);
                xmlDoc.Save(arquivo);
            }
            ReadAgenda();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarContato(txtNome.Text, txtTelefone.Text);
            LimparCampos();
            ReadAgenda();
        }

        private void ReadAgenda()
        {
            xmlDoc.Load(arquivo);
            lblAgenda.Text = "Contatos:\n\n";
            foreach (XmlNode node in xmlDoc.GetElementsByTagName("Contato"))
            {
                lblAgenda.Text += "Nome:" + node.Attributes["nome"].Value + ", " +
                                  "Telefone:" + node.Attributes["telefone"].Value + "\n";
            }
        }

        private void SalvarContato(string nome, string telefone)
        {
            XElement element = new XElement("Contato");
            element.Add(new XAttribute("nome", nome));
            element.Add(new XAttribute("telefone", telefone));
            xmlDoc.Load(arquivo);
            //xmlDoc.AppendChild(element);
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtNome.Focus();
        }
    }
}
