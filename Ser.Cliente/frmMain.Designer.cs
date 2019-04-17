namespace Ser.Cliente
{
    partial class frmMain
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
            this.txtMenssagem = new System.Windows.Forms.TextBox();
            this.btnInvServico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMenssagem
            // 
            this.txtMenssagem.Location = new System.Drawing.Point(12, 51);
            this.txtMenssagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtMenssagem.Name = "txtMenssagem";
            this.txtMenssagem.Size = new System.Drawing.Size(420, 23);
            this.txtMenssagem.TabIndex = 0;
            // 
            // btnInvServico
            // 
            this.btnInvServico.Location = new System.Drawing.Point(13, 12);
            this.btnInvServico.Name = "btnInvServico";
            this.btnInvServico.Size = new System.Drawing.Size(119, 23);
            this.btnInvServico.TabIndex = 1;
            this.btnInvServico.Text = "Invocar Serviço";
            this.btnInvServico.UseVisualStyleBackColor = true;
            this.btnInvServico.Click += new System.EventHandler(this.btnInvServico_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 87);
            this.Controls.Add(this.btnInvServico);
            this.Controls.Add(this.txtMenssagem);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Cliente - WFC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMenssagem;
        private System.Windows.Forms.Button btnInvServico;
    }
}

