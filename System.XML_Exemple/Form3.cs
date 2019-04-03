using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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
            CarregaTextoExemplo();
         
        }

        #region Evento dos Botões

        private void btnIncluir_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                Contato cont = new Contato();

                if (int.Parse(lblId.Text) <= 0)
                {
                    //ClearCampos();
                    cont.Id = this.NextId();
                    cont.Nome = txtNome.Text;
                    cont.Telefone = new List<Telefone>();
                    cont.Telefone.Add(new Telefone((int)TiposTelefone.Residencial, txtFoneResidencial.Text));
                    cont.Telefone.Add(new Telefone((int)TiposTelefone.Comercial, txtFoneComercial.Text));
                    cont.Telefone.Add(new Telefone((int)TiposTelefone.Celular, txtFoneCelular.Text));
                    cont.Obs = txtObs.Text;
                    cont.ValidarContato();
                    contatos.Contato.Add(cont);
                }
                else
                {
                   // ClearCampos();
                    cont.Id = int.Parse(lblId.Text) == 0 ? this.NextId() : int.Parse(lblId.Text);
                    cont = contatos.Contato.Find(p => p.Id == cont.Id);
                    cont.Nome = txtNome.Text;
                    cont.Telefone[(int)TiposTelefone.Residencial].Numero = txtFoneResidencial.Text;
                    cont.Telefone[(int)TiposTelefone.Comercial].Numero = txtFoneComercial.Text;
                    cont.Telefone[(int)TiposTelefone.Celular].Numero = txtFoneCelular.Text;
                    cont.Obs = txtObs.Text;
                    cont.ValidarContato();
                    Cancelar();
                }
                SContatos.Write(contatos);
                ClearCampos();
                BindlbxAgenda();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblvalNome.Visible = true;

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
                    this.ClearCampos();
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
                            "Telefone: " + cont.Telefone + "\n" +
                            "Observações: " + cont.Obs,
                            "Contato",
                            MessageBoxButtons.OK, MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            CarregaTextoExemplo();
            if (lbxAgenda.SelectedIndex > -1)
            {
                btnIncluir_Alterar.Text = "Alterar";
                btnIncluir_Alterar.Image = Properties.Resources.edit_document_32x32;
                pnlAlterar.Visible = true;

                Contato cont = contatos.Contato.Find(p => p.Id == (int)lbxAgenda.SelectedValue);
                lblId.Text = cont.Id.ToString();
                txtNome.Text = cont.Nome;
                if (cont.Telefone.Count > 0)
                {
                    txtFoneResidencial.Text = cont.Telefone[(int)TiposTelefone.Residencial].Numero;
                    txtFoneComercial.Text = cont.Telefone[(int)TiposTelefone.Comercial].Numero;
                    txtFoneCelular.Text = cont.Telefone[(int)TiposTelefone.Celular].Numero;
                }
                txtObs.Text = cont.Obs;
                CorCampo();
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
                ClearCampos();
                Cancelar();
            }
        }

        #endregion

        #region Metodos
        private void ClearCampos()
        {
            lblvalNome.Visible = false;
            lblId.Text = "0";
            txtNome.Clear();
            txtFoneResidencial.Clear();
            txtFoneComercial.Clear();
            txtFoneCelular.Clear();
            txtObs.Clear();
            txtNome.Focus();
            CarregaTextoExemplo();
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
            btnIncluir_Alterar.Image = Properties.Resources.add_32x32;
            pnlAlterar.Visible = false;
        }

        private void CorCampo()
        {
            if (txtNome.Text != Contato.ExNome) txtNome.ForeColor = Color.Black;
            if (txtFoneResidencial.Text != Telefone.ExNumResidencial) txtFoneResidencial.ForeColor = Color.Black;
            if (txtFoneComercial.Text != Telefone.ExNumComercial) txtFoneComercial.ForeColor = Color.Black; ;
            if (txtFoneCelular.Text != Telefone.ExNumCelular) txtFoneCelular.ForeColor = Color.Black;
            if (txtObs.Text != Contato.ExObs) txtObs.ForeColor = Color.Black;
        }
        #endregion

        #region Validações Campos
        private void txtNome_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) || txtNome.Text == Contato.ExNome)
            {
                ExemploNome();
            }
            else
            {
                lblvalNome.Visible = false;
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == Contato.ExNome)
            {
                txtNome.Text = string.Empty;
            }
            txtNome.ForeColor = Color.Black;
        }

        private void txtFoneResidencial_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFoneResidencial.Text) || txtFoneResidencial.Text == Telefone.ExNumResidencial || txtFoneResidencial.Text == "(  )    -")
            {
                ExemploFoneResidencial();
            }
        }

        private void txtFoneResidencial_Enter(object sender, EventArgs e)
        {
            if (txtFoneResidencial.Text == Telefone.ExNumResidencial)
            {
                txtFoneResidencial.Text = string.Empty;
            }
            txtFoneResidencial.ForeColor = Color.Black;
        }

        private void txtFoneComercial_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFoneComercial.Text) || txtFoneComercial.Text == Telefone.ExNumComercial|| txtFoneComercial.Text == "(  )    -")
            {
                ExemploFoneComercial();
            }
        }

        private void txtFoneComercial_Enter(object sender, EventArgs e)
        {
            if (txtFoneComercial.Text == Telefone.ExNumComercial)
            {
                txtFoneComercial.Text = string.Empty;
            }
            txtFoneComercial.ForeColor = Drawing.Color.Black;
        }

        private void txtFoneCelular_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFoneCelular.Text) || txtFoneCelular.Text == Telefone.ExNumComercial || txtFoneCelular.Text == "(  )     -")
            {
                ExemploFoneCelular();
            }
        }

        private void txtFoneCelular_Enter(object sender, EventArgs e)
        {
            if (txtFoneCelular.Text == Telefone.ExNumCelular)
            {
                txtFoneCelular.Clear();
            }
            txtFoneCelular.ForeColor = Drawing.Color.Black;
        }

        private void txtObs_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtObs.Text) || txtObs.Text == Contato.ExObs)
            {
                ExemploObs();
            }
        }

        private void txtObs_Enter(object sender, EventArgs e)
        {
            if (txtObs.Text == Contato.ExObs)
            {
                txtObs.Text = string.Empty;
            }
            txtObs.ForeColor = Drawing.Color.Black;
        }
        #endregion

        #region Metodos de Exemplos
        private void CarregaTextoExemplo()
        {
            ExemploNome();
            ExemploFoneResidencial();
            ExemploFoneComercial();
            ExemploFoneCelular();
            ExemploObs();
        }
        private void ExemploNome()
        {
            txtNome.Text = Contato.ExNome;
            txtNome.ForeColor = Drawing.Color.Silver;
        }
        private void ExemploFoneResidencial()
        {
            txtFoneResidencial.Text = Telefone.ExNumResidencial;
            txtFoneResidencial.ForeColor = Drawing.Color.Silver;
        }
        private void ExemploFoneComercial()
        {
            txtFoneComercial.Text = Telefone.ExNumComercial;
            txtFoneComercial.ForeColor = Drawing.Color.Silver;
        }
        private void ExemploFoneCelular()
        {
            txtFoneCelular.Text = Telefone.ExNumCelular;
            txtFoneCelular.ForeColor = Drawing.Color.Silver;
        }
        private void ExemploObs()
        {
            txtObs.Text = Contato.ExObs;
            txtObs.ForeColor = Drawing.Color.Silver;
        }




        #endregion

    }
}
