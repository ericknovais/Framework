using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public class EProgramadorException : Exception
        {

        }

        private void btnInvocar_Click(object sender, EventArgs e)
        {
            string tarefa = "Criar Aplicativo";
            Gerente(tarefa);
        }

        private void Gerente(string tarefa)
        {
            Lider(tarefa);
        }

        private void Lider(string tarefa)
        {
            try
            {
                Progamador(tarefa);
            }
            catch (FormatException e)
            {
                listBox1.Items.Add("Erro de formato : " + e.Message);
                throw new EProgramadorException();
            }
            catch (Exception e)
            {
                listBox1.Items.Add("Erro Tratado pelo Líder: " + e.Message);
                throw;
            }
        }

        private void Progamador(string tarefa)
        {
            Estagiario(tarefa);
        }

        private void Estagiario(string tarefa)
        {
            Convert.ToDateTime(tarefa);
        }
    }
}
