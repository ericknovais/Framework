using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servico.Cliente
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnInvocarWebService_Click(object sender, EventArgs e)
        {
            var prx = new Prx.WebService();
            txtResult.Text = prx.Somar(1, 30).ToString();
            gridClientes.DataSource = prx.GetClientes();
        }
    }
}
