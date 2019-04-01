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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato cont = new Contato();
            cont.Id = this.NextId();
            cont.Nome = txtNome.Text;
            cont.Telefone = txtTelefone.Text;

            contatos.Contato.Add(cont);
            SContatos.Write(contatos);

            this.LimparCampos();

            this.BindlbxAgenda();
        }

        private void frmAgenda3_Load(object sender, EventArgs e)
        {
            this.BindlbxAgenda();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lbxAgenda.SelectedIndex > -1)
            {
                Contato cont = contatos.Contato.Find(p => p.Id == (int)lbxAgenda.SelectedValue);
                contatos.Contato.Remove(cont);
                SContatos.Write(contatos);
                this.BindlbxAgenda();
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtNome.Focus();
        }

        private void BindlbxAgenda()
        {
            contatos = SContatos.Read();
            lbxAgenda.DataSource = contatos.Contato;
            lbxAgenda.DisplayMember = "Nome";
            lbxAgenda.ValueMember = "Id";
        }

        private int NextId()
        {
            int next = contatos.Contato[contatos.Contato.Count - 1].Id + 1;
            return next;
        }

        private void lbxAgenda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Contato cont = contatos.Contato.Find(p => p.Id == (int)lbxAgenda.SelectedValue);
            MessageBox.Show("Nome: " + cont.Nome + "\n" +
                            "Telefone: " + cont.Telefone);
        }
    }
}
