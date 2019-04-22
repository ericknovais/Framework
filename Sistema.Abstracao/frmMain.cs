using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Abstracao
{
    public partial class frmMain : Form
    {
        // Abstração
        private FormaEnvio _formaEnvio;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            this._formaEnvio = Fabrica.CriarEnvio((TipoEnvio)cmbTipo.SelectedIndex);
            _formaEnvio.Enviar(txtAviso.Text);
        }
    }
}
