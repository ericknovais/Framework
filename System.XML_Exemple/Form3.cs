using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace System.XML_Exemple
{
    public partial class frmAgenda3 : Form
    {
        string arquivo = @"E:\Erick\Estudos\DevMidia C#\Framework\System.XML_Exemple\XML\Agenda.xml";
        XmlDocument xDoc = new XmlDocument();
        XElement elementX;
        Contatos contatos;

        public frmAgenda3()
        {
            InitializeComponent();
            if (!File.Exists(arquivo))
            {
                XmlNode nodeRoot = xDoc.CreateElement("Contatos");
                xDoc.AppendChild(nodeRoot);
                xDoc.Save(arquivo);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato cont = new Contato();
            cont.Id = this.NextId();
            cont.Nome = txtNome.Text;
            cont.Telefone = txtTelefone.Text;

            contatos.Contato.Add(cont);
            //Serializador
            XElement xReturn = Serializador.Serialize<Contatos>(contatos);
            xReturn.Save(arquivo);

            LimparCampos();

            ReadAgenda();
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtNome.Focus();
        }

        private void ReadAgenda()
        {
            //Deserelizador
            elementX = XElement.Load(arquivo);
            contatos = Serializador.Deserialize<Contatos>(elementX);

            lblContatos.Text = string.Empty;
            foreach (Contato cont in contatos.Contato)
            {
                lblContatos.Text += "Nome: " + cont.Nome +
                                    "\nTelefone: " + cont.Telefone + "\n\n";
            }
        }

        private void frmAgenda3_Load(object sender, EventArgs e)
        {
            ReadAgenda();
        }

        private int NextId()
        {
           int next = contatos.Contato[contatos.Contato.Count - 1].Id + 1
            return next;
        }
    }
}
