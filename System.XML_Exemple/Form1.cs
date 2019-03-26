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

namespace System.XML_Exemple
{

    public partial class Form1 : Form
    {
        string arquivo = @"E:\Erick\Estudos\DevMidia C#\Framework\System.XML_Exemple\XML\Agenda.xml";
        XmlDocument xmlDocument = new XmlDocument();

        public Form1()
        {
            InitializeComponent();

            if (!File.Exists(arquivo))
            {
                
                XmlNode nodeRoot = xmlDocument.CreateElement("Contatos");
                xmlDocument.AppendChild(nodeRoot);
                xmlDocument.Save(arquivo);
            }
            ReadAgenda();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            xmlDocument.Load(arquivo);
            XmlNode nodeNome = xmlDocument.CreateElement("Nome");
            XmlNode nodeTelefone = xmlDocument.CreateElement("Telefone");

            nodeNome.InnerText = txtNome.Text;
            nodeTelefone.InnerText = txtTelefone.Text;

            XmlNode nodeContato = xmlDocument.CreateElement("Contato");
            xmlDocument.SelectSingleNode("/Contatos").PrependChild(nodeContato);

            

            xmlDocument.SelectSingleNode("/Contatos/Contato").AppendChild(nodeNome);
            xmlDocument.SelectSingleNode("/Contatos/Contato").AppendChild(nodeTelefone);
            xmlDocument.Save(arquivo);
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtNome.Focus();
        }

        private void ReadAgenda()
        {
            xmlDocument.Load(arquivo);
            foreach(XmlNode node in xmlDocument.SelectNodes("Contatos"))
            {
                lblAgenda.Text += "Nome:" + node.SelectNodes("Nome"); 
            }
            
        }
    }
}
