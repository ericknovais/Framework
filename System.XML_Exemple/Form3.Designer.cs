namespace System.XML_Exemple
{
    partial class frmAgenda3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblFoneResidencial = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbxAgenda = new System.Windows.Forms.ListBox();
            this.pnlAlterar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblContatos = new System.Windows.Forms.Label();
            this.txtFoneResidencial = new System.Windows.Forms.MaskedTextBox();
            this.txtFoneComercial = new System.Windows.Forms.MaskedTextBox();
            this.lblFoneComercial = new System.Windows.Forms.Label();
            this.txtFoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblFoneCelular = new System.Windows.Forms.Label();
            this.lblvalNome = new System.Windows.Forms.Label();
            this.btnIncluir_Alterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnLimpaFiltro = new System.Windows.Forms.Button();
            this.pnlAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblFoneResidencial
            // 
            this.lblFoneResidencial.AutoSize = true;
            this.lblFoneResidencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFoneResidencial.Location = new System.Drawing.Point(15, 56);
            this.lblFoneResidencial.Name = "lblFoneResidencial";
            this.lblFoneResidencial.Size = new System.Drawing.Size(105, 17);
            this.lblFoneResidencial.TabIndex = 3;
            this.lblFoneResidencial.Text = "Fone Residencial:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(321, 24);
            this.txtNome.TabIndex = 2;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Validated += new System.EventHandler(this.txtNome_Validated);
            // 
            // lbxAgenda
            // 
            this.lbxAgenda.FormattingEnabled = true;
            this.lbxAgenda.ItemHeight = 15;
            this.lbxAgenda.Location = new System.Drawing.Point(363, 29);
            this.lbxAgenda.Name = "lbxAgenda";
            this.lbxAgenda.Size = new System.Drawing.Size(286, 394);
            this.lbxAgenda.TabIndex = 15;
            this.lbxAgenda.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxAgenda_MouseDoubleClick);
            // 
            // pnlAlterar
            // 
            this.pnlAlterar.Controls.Add(this.btnCancelar);
            this.pnlAlterar.Location = new System.Drawing.Point(119, 246);
            this.pnlAlterar.Name = "pnlAlterar";
            this.pnlAlterar.Size = new System.Drawing.Size(127, 35);
            this.pnlAlterar.TabIndex = 12;
            this.pnlAlterar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::System.XML_Exemple.Properties.Resources.delete_32x32;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 35);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSelecionar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Image = global::System.XML_Exemple.Properties.Resources.edit_select_all_002;
            this.btnSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionar.Location = new System.Drawing.Point(423, 433);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(122, 35);
            this.btnSelecionar.TabIndex = 12;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(85, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 17);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(15, 215);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(321, 24);
            this.txtObs.TabIndex = 10;
            this.txtObs.Enter += new System.EventHandler(this.txtObs_Enter);
            this.txtObs.Validated += new System.EventHandler(this.txtObs_Validated);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(15, 195);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(83, 17);
            this.lblObs.TabIndex = 9;
            this.lblObs.Text = "Observações:";
            // 
            // lblContatos
            // 
            this.lblContatos.AutoSize = true;
            this.lblContatos.Location = new System.Drawing.Point(363, 10);
            this.lblContatos.Name = "lblContatos";
            this.lblContatos.Size = new System.Drawing.Size(62, 17);
            this.lblContatos.TabIndex = 14;
            this.lblContatos.Text = "Contatos:";
            // 
            // txtFoneResidencial
            // 
            this.txtFoneResidencial.Location = new System.Drawing.Point(15, 74);
            this.txtFoneResidencial.Mask = "(99)0000-0000";
            this.txtFoneResidencial.Name = "txtFoneResidencial";
            this.txtFoneResidencial.Size = new System.Drawing.Size(103, 24);
            this.txtFoneResidencial.TabIndex = 4;
            this.txtFoneResidencial.Tag = "99";
            this.txtFoneResidencial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFoneResidencial.Enter += new System.EventHandler(this.txtFoneResidencial_Enter);
            this.txtFoneResidencial.Validated += new System.EventHandler(this.txtFoneResidencial_Validated);
            // 
            // txtFoneComercial
            // 
            this.txtFoneComercial.Location = new System.Drawing.Point(15, 121);
            this.txtFoneComercial.Mask = "(99)0000-0000";
            this.txtFoneComercial.Name = "txtFoneComercial";
            this.txtFoneComercial.Size = new System.Drawing.Size(102, 24);
            this.txtFoneComercial.TabIndex = 6;
            this.txtFoneComercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFoneComercial.Enter += new System.EventHandler(this.txtFoneComercial_Enter);
            this.txtFoneComercial.Validated += new System.EventHandler(this.txtFoneComercial_Validated);
            // 
            // lblFoneComercial
            // 
            this.lblFoneComercial.AutoSize = true;
            this.lblFoneComercial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFoneComercial.Location = new System.Drawing.Point(15, 101);
            this.lblFoneComercial.Name = "lblFoneComercial";
            this.lblFoneComercial.Size = new System.Drawing.Size(98, 17);
            this.lblFoneComercial.TabIndex = 5;
            this.lblFoneComercial.Text = "Fone Comercial:";
            // 
            // txtFoneCelular
            // 
            this.txtFoneCelular.Location = new System.Drawing.Point(15, 168);
            this.txtFoneCelular.Mask = "(99)90000-0000";
            this.txtFoneCelular.Name = "txtFoneCelular";
            this.txtFoneCelular.Size = new System.Drawing.Size(102, 24);
            this.txtFoneCelular.TabIndex = 8;
            this.txtFoneCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFoneCelular.Enter += new System.EventHandler(this.txtFoneCelular_Enter);
            this.txtFoneCelular.Validated += new System.EventHandler(this.txtFoneCelular_Validated);
            // 
            // lblFoneCelular
            // 
            this.lblFoneCelular.AutoSize = true;
            this.lblFoneCelular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFoneCelular.Location = new System.Drawing.Point(15, 148);
            this.lblFoneCelular.Name = "lblFoneCelular";
            this.lblFoneCelular.Size = new System.Drawing.Size(81, 17);
            this.lblFoneCelular.TabIndex = 7;
            this.lblFoneCelular.Text = "Fone Celular:";
            // 
            // lblvalNome
            // 
            this.lblvalNome.AutoSize = true;
            this.lblvalNome.BackColor = System.Drawing.SystemColors.Control;
            this.lblvalNome.ForeColor = System.Drawing.Color.Red;
            this.lblvalNome.Location = new System.Drawing.Point(342, 29);
            this.lblvalNome.Name = "lblvalNome";
            this.lblvalNome.Size = new System.Drawing.Size(15, 17);
            this.lblvalNome.TabIndex = 16;
            this.lblvalNome.Text = "*";
            this.lblvalNome.Visible = false;
            // 
            // btnIncluir_Alterar
            // 
            this.btnIncluir_Alterar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnIncluir_Alterar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIncluir_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir_Alterar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir_Alterar.Image = global::System.XML_Exemple.Properties.Resources.add_32x32;
            this.btnIncluir_Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir_Alterar.Location = new System.Drawing.Point(15, 246);
            this.btnIncluir_Alterar.Margin = new System.Windows.Forms.Padding(0);
            this.btnIncluir_Alterar.Name = "btnIncluir_Alterar";
            this.btnIncluir_Alterar.Size = new System.Drawing.Size(101, 35);
            this.btnIncluir_Alterar.TabIndex = 11;
            this.btnIncluir_Alterar.Text = "Incluir";
            this.btnIncluir_Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir_Alterar.UseVisualStyleBackColor = true;
            this.btnIncluir_Alterar.Click += new System.EventHandler(this.btnIncluir_Alterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::System.XML_Exemple.Properties.Resources.edit_delete_003;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(551, 433);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(98, 35);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBusca.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Image = global::System.XML_Exemple.Properties.Resources.edit_find_replace;
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(15, 433);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(0);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(88, 35);
            this.btnBusca.TabIndex = 17;
            this.btnBusca.Text = "Busca";
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnLimpaFiltro
            // 
            this.btnLimpaFiltro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnLimpaFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpaFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpaFiltro.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaFiltro.Image = global::System.XML_Exemple.Properties.Resources.refresh_32x32;
            this.btnLimpaFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpaFiltro.Location = new System.Drawing.Point(106, 433);
            this.btnLimpaFiltro.Name = "btnLimpaFiltro";
            this.btnLimpaFiltro.Size = new System.Drawing.Size(114, 35);
            this.btnLimpaFiltro.TabIndex = 18;
            this.btnLimpaFiltro.Text = "&Limpa filtro";
            this.btnLimpaFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpaFiltro.UseVisualStyleBackColor = true;
            this.btnLimpaFiltro.Visible = false;
            this.btnLimpaFiltro.Click += new System.EventHandler(this.btnLimpaFiltro_Click);
            // 
            // frmAgenda3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 480);
            this.Controls.Add(this.btnLimpaFiltro);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.lblvalNome);
            this.Controls.Add(this.txtFoneCelular);
            this.Controls.Add(this.lblFoneCelular);
            this.Controls.Add(this.txtFoneComercial);
            this.Controls.Add(this.lblFoneComercial);
            this.Controls.Add(this.txtFoneResidencial);
            this.Controls.Add(this.lblContatos);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.btnIncluir_Alterar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lbxAgenda);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblFoneResidencial);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pnlAlterar);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgenda3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Agenda telefonica";
            this.Load += new System.EventHandler(this.frmAgenda3_Load);
            this.pnlAlterar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.Label lblNome;
        private Windows.Forms.Label lblFoneResidencial;
        private Windows.Forms.TextBox txtNome;
        private Windows.Forms.Button btnIncluir_Alterar;
        private Windows.Forms.ListBox lbxAgenda;
        private Windows.Forms.Button btnExcluir;
        private Windows.Forms.Panel pnlAlterar;
        private Windows.Forms.Button btnSelecionar;
        private Windows.Forms.Label lblId;
        private Windows.Forms.TextBox txtObs;
        private Windows.Forms.Label lblObs;
        private Windows.Forms.Label lblContatos;
        private Windows.Forms.MaskedTextBox txtFoneResidencial;
        private Windows.Forms.MaskedTextBox txtFoneComercial;
        private Windows.Forms.Label lblFoneComercial;
        private Windows.Forms.MaskedTextBox txtFoneCelular;
        private Windows.Forms.Label lblFoneCelular;
        private Windows.Forms.Label lblvalNome;
        private Windows.Forms.Button btnCancelar;
        private Windows.Forms.Button btnBusca;
        private Windows.Forms.Button btnLimpaFiltro;
    }
}