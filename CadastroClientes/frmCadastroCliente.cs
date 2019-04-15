using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CadastroClientes
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //cria DATASET, que pode ser uma coleção de tabela
            DataSet dataSet = new DataSet("Dados");
            //Cria a tabela
            DataTable tabela = CriarEstruturaTabela();
            //Adiciona tabela ao DATASET
            dataSet.Tables.Add(tabela);
            //Adicionar os registros na tabela
            DataRow registro = CriaRegistro(tabela);
            tabela.Rows.Add(registro);
            //Salvando o cliente em arquivo xml
            dataSet.WriteXml(@".\cliente_" + txtCodigo.Text + ".xml");
            LimpaCampos();
        }

        private DataRow CriaRegistro(DataTable tabela)
        {
            //cria os registros
            DataRow registro = tabela.NewRow();
            registro["Codigo"] = txtCodigo.Text;
            registro["Nome"] = txtNome.Text;
            registro["Fone"] = txtTelefone.Text;
            registro["Email"] = txtEmail.Text;
            return registro;
        }

        private  DataTable CriarEstruturaTabela()
        {
            DataTable tabela = new DataTable("Clientes");
            //Cria colunas na tabela
            tabela.Columns.Add(new DataColumn("Codigo"));
            tabela.Columns.Add(new DataColumn("Nome"));
            tabela.Columns.Add(new DataColumn("Fone"));
            tabela.Columns.Add(new DataColumn("Email"));
            return tabela;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            // Cria o dataset
            DataSet dataSet = new DataSet();
            // le o dataset do disco
            dataSet.ReadXml(@".\cliente_" + txtCodigo.Text + ".xml");
            //Tabela é o primeiro datatableda coleção
            DataTable tabela = dataSet.Tables[0];
            //Considero o primeiro registro da tabela
            DataRow registro = tabela.Rows[0];
            MostrarDadosNaTela(registro);
        }

        private void MostrarDadosNaTela(DataRow registro)
        {
            //Mostro dados do registro na tela
            txtNome.Text = registro["Nome"].ToString();
            txtTelefone.Text = registro["Fone"].ToString();
            txtEmail.Text = registro["Email"].ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            //Percorrer todos os controles da tela para limpar
            foreach (Control txt in Controls)
            {
                if (txt is TextBox)
                    (txt as TextBox).Clear();
            }
            txtCodigo.Focus();
        }
    }
}
