using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.XML_Exemple
{
    public partial class frmBuscaContato : Form
    {
        Contatos contatos = null;
        List<Contato> resultado = null;
        public frmBuscaContato()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            contatos = SContatos.Read();
            if (cmbCampo.SelectedText == "Nome")
            {
                resultado = contatos.Contato.Where(p => p.Nome == txtBusca.Text).ToList<Contato>();
            }
        }
    }
}
