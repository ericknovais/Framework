using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace System.XML_Exemple
{
    public partial class frmAgenda3 : Form
    {
        Contatos contatos = null;
        public frmAgenda3()
        {
            InitializeComponent();
            contatos = SContatos.Read();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato cont = new Contato();
            cont.Id = this.NextId();
            cont.Nome = txtNome.Text;
            cont.Telefone = txtTelefone.Text;

            contatos.Contato.Add(cont);
            SContatos.Write(contatos);

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
            int next = contatos.Contato[contatos.Contato.Count - 1].Id + 1;
            return next;
        }
    }
}
