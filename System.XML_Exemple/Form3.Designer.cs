﻿namespace System.XML_Exemple
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
            this.btnIncluir_Alterar = new System.Windows.Forms.Button();
            this.lbxAgenda = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
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
            this.pnlAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblFoneResidencial
            // 
            this.lblFoneResidencial.AutoSize = true;
            this.lblFoneResidencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFoneResidencial.Location = new System.Drawing.Point(12, 48);
            this.lblFoneResidencial.Name = "lblFoneResidencial";
            this.lblFoneResidencial.Size = new System.Drawing.Size(92, 13);
            this.lblFoneResidencial.TabIndex = 3;
            this.lblFoneResidencial.Text = "Fone Residencial:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // btnIncluir_Alterar
            // 
            this.btnIncluir_Alterar.Location = new System.Drawing.Point(12, 207);
            this.btnIncluir_Alterar.Name = "btnIncluir_Alterar";
            this.btnIncluir_Alterar.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir_Alterar.TabIndex = 7;
            this.btnIncluir_Alterar.Text = "Incluir";
            this.btnIncluir_Alterar.UseVisualStyleBackColor = true;
            this.btnIncluir_Alterar.Click += new System.EventHandler(this.btnIncluir_Alterar_Click);
            // 
            // lbxAgenda
            // 
            this.lbxAgenda.FormattingEnabled = true;
            this.lbxAgenda.Location = new System.Drawing.Point(314, 25);
            this.lbxAgenda.Name = "lbxAgenda";
            this.lbxAgenda.Size = new System.Drawing.Size(243, 355);
            this.lbxAgenda.TabIndex = 9;
            this.lbxAgenda.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxAgenda_MouseDoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(482, 383);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pnlAlterar
            // 
            this.pnlAlterar.Controls.Add(this.btnCancelar);
            this.pnlAlterar.Location = new System.Drawing.Point(93, 207);
            this.pnlAlterar.Name = "pnlAlterar";
            this.pnlAlterar.Size = new System.Drawing.Size(85, 23);
            this.pnlAlterar.TabIndex = 12;
            this.pnlAlterar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(401, 383);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 10;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(80, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(15, 181);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(293, 20);
            this.txtObs.TabIndex = 6;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(12, 165);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(73, 13);
            this.lblObs.TabIndex = 5;
            this.lblObs.Text = "Observações:";
            // 
            // lblContatos
            // 
            this.lblContatos.AutoSize = true;
            this.lblContatos.Location = new System.Drawing.Point(311, 9);
            this.lblContatos.Name = "lblContatos";
            this.lblContatos.Size = new System.Drawing.Size(52, 13);
            this.lblContatos.TabIndex = 8;
            this.lblContatos.Text = "Contatos:";
            // 
            // txtFoneResidencial
            // 
            this.txtFoneResidencial.Location = new System.Drawing.Point(15, 64);
            this.txtFoneResidencial.Mask = "(99)0000-0000";
            this.txtFoneResidencial.Name = "txtFoneResidencial";
            this.txtFoneResidencial.Size = new System.Drawing.Size(100, 20);
            this.txtFoneResidencial.TabIndex = 4;
            // 
            // txtFoneComercial
            // 
            this.txtFoneComercial.Location = new System.Drawing.Point(16, 103);
            this.txtFoneComercial.Mask = "(99)0000-0000";
            this.txtFoneComercial.Name = "txtFoneComercial";
            this.txtFoneComercial.Size = new System.Drawing.Size(100, 20);
            this.txtFoneComercial.TabIndex = 14;
            // 
            // lblFoneComercial
            // 
            this.lblFoneComercial.AutoSize = true;
            this.lblFoneComercial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFoneComercial.Location = new System.Drawing.Point(13, 87);
            this.lblFoneComercial.Name = "lblFoneComercial";
            this.lblFoneComercial.Size = new System.Drawing.Size(83, 13);
            this.lblFoneComercial.TabIndex = 13;
            this.lblFoneComercial.Text = "Fone Comercial:";
            // 
            // txtFoneCelular
            // 
            this.txtFoneCelular.Location = new System.Drawing.Point(16, 142);
            this.txtFoneCelular.Mask = "(99)90000-0000";
            this.txtFoneCelular.Name = "txtFoneCelular";
            this.txtFoneCelular.Size = new System.Drawing.Size(100, 20);
            this.txtFoneCelular.TabIndex = 16;
            // 
            // lblFoneCelular
            // 
            this.lblFoneCelular.AutoSize = true;
            this.lblFoneCelular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFoneCelular.Location = new System.Drawing.Point(13, 126);
            this.lblFoneCelular.Name = "lblFoneCelular";
            this.lblFoneCelular.Size = new System.Drawing.Size(69, 13);
            this.lblFoneCelular.TabIndex = 15;
            this.lblFoneCelular.Text = "Fone Celular:";
            // 
            // frmAgenda3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 413);
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
            this.Name = "frmAgenda3";
            this.Text = "Agenda";
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
        private Windows.Forms.Button btnCancelar;
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
    }
}