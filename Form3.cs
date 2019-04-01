﻿using System.IO;
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

        private void btnIncluir_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                Contato cont = new Contato();

                if (int.Parse(lblId.Text) <= 0)
                {
                    cont.Id = this.NextId();
                    cont.Nome = txtNome.Text;
                    cont.Telefone = txtTelefone.Text;
                    cont.ValidarContato();
                    contatos.Contato.Add(cont);
                }
                else
                {
                    cont.Id = int.Parse(lblId.Text);
                    contatos.Contato.Find(p => p.Id == cont.Id).Nome = txtNome.Text;
                    contatos.Contato.Find(p => p.Id == cont.Id).Telefone = txtTelefone.Text;
                    Cancelar();
                }
                SContatos.Write(contatos);
                LimparCampos();
                BindlbxAgenda();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

                if (MessageBox.Show("Excluir o contato " + cont.Nome.ToUpper() + " ?", "Excluir contato", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    contatos.Contato.Remove(cont);
                    SContatos.Write(contatos);
                    this.BindlbxAgenda();
                    this.LimparCampos();
                    this.Cancelar();
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }
        }

        private void lbxAgenda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Contato cont = contatos.Contato.Find(p => p.Id == (int)lbxAgenda.SelectedValue);
            MessageBox.Show("Nome: " + cont.Nome + "\n" +
                            "Telefone: " + cont.Telefone, "Contato",
                            MessageBoxButtons.OK, MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (lbxAgenda.SelectedIndex > -1)
            {
                btnIncluir_Alterar.Text = "Alterar";
                pnlAlterar.Visible = true;

                Contato cont = contatos.Contato.Find(p => p.Id == (int)lbxAgenda.SelectedValue);
                lblId.Text = cont.Id.ToString();
                txtNome.Text = cont.Nome;
                txtTelefone.Text = cont.Telefone;
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar essa operação ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                LimparCampos();
                Cancelar();
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            lblId.Text = "0";
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

        private void Cancelar()
        {
            btnIncluir_Alterar.Text = "Incluir";
            pnlAlterar.Visible = false;
        }

    }
}