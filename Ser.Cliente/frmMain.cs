using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ser.Cliente
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnInvServico_Click(object sender, EventArgs e)
        {
            var prx = new PrxOlaMundo.OlaMundoServiceClient();
            txtMenssagem.Text = prx.OlaMundo();
        }
    }
}
