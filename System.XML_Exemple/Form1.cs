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
                
                XmlNode nodeRoot = xmlDocument.CreateElement("Contato");
                xmlDocument.AppendChild(nodeRoot);
                xmlDocument.Save(arquivo);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            xmlDocument.Load(arquivo);
            XmlNode nodeNome = xmlDocument.CreateElement("Nome");
            XmlNode nodeTelefone = xmlDocument.CreateElement("Telefone");
            nodeNome.InnerText = txtNome.Text;
            nodeTelefone.InnerText = txtTelefone.Text;
            xmlDocument.SelectSingleNode("/Contato").AppendChild(nodeNome);
            xmlDocument.SelectSingleNode("/Contato").AppendChild(nodeTelefone);
            xmlDocument.Save(arquivo);
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtNome.Focus();
        }
    }
}
