namespace SisClinica.Forms
{
    partial class frmBuscaResponsavel
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
            this.gbRegistrarNovoResponsavel = new System.Windows.Forms.GroupBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.dtpDataNascimentoBuscarResponsavel = new System.Windows.Forms.DateTimePicker();
            this.btnPreencher = new System.Windows.Forms.Button();
            this.mskdCPFBuscarResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.lbCpfBuscarResponsavel = new System.Windows.Forms.Label();
            this.mskTxtBoxTelefoneBuscarResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxEmailBuscarResponsavel = new System.Windows.Forms.TextBox();
            this.txtBoxNomeCompletoBuscarResponsavel = new System.Windows.Forms.TextBox();
            this.lbEmailBuscarResponsavel = new System.Windows.Forms.Label();
            this.lbNomeResponsavelBuscarResponsavel = new System.Windows.Forms.Label();
            this.lbDataNascimentoBuscarResponsavel = new System.Windows.Forms.Label();
            this.lbTelefoneBuscarResponsavel = new System.Windows.Forms.Label();
            this.gbRegistrarNovoResponsavel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistrarNovoResponsavel
            // 
            this.gbRegistrarNovoResponsavel.BackColor = System.Drawing.Color.Transparent;
            this.gbRegistrarNovoResponsavel.Controls.Add(this.lblAviso);
            this.gbRegistrarNovoResponsavel.Controls.Add(this.dtpDataNascimentoBuscarResponsavel);
            this.gbRegistrarNovoResponsavel.Controls.Add(this.btnPreencher);
            this.gbRegistrarNovoResponsavel.Controls.Add(this.mskdCPFBuscarResponsavel);
            this.gbRegistrarNovoResponsavel.Controls.Add(this.lbCpfBuscarResponsavel);
            this.gbRegistrarNovoResponsavel.Controls.Add(this.mskTxtBoxTelefoneBuscarResponsavel);
            this.gbRegistrarNovoResponsavel.Controls.Add(this.txtBoxEmailBuscarResponsavel);
            this.gbRegistrarNovoResponsavel.Controls.Add(this.txtBoxNomeCompletoBuscarResponsavel);
            this.gbRegistrarNovoResponsavel.Controls.Add(this.lbEmailBuscarResponsavel);
            this.gbRegistrarNovoResponsavel.Controls.Add(this.lbNomeResponsavelBuscarResponsavel);
            this.gbRegistrarNovoResponsavel.Controls.Add(this.lbDataNascimentoBuscarResponsavel);
            this.gbRegistrarNovoResponsavel.Controls.Add(this.lbTelefoneBuscarResponsavel);
            this.gbRegistrarNovoResponsavel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrarNovoResponsavel.Location = new System.Drawing.Point(12, 12);
            this.gbRegistrarNovoResponsavel.Name = "gbRegistrarNovoResponsavel";
            this.gbRegistrarNovoResponsavel.Size = new System.Drawing.Size(555, 309);
            this.gbRegistrarNovoResponsavel.TabIndex = 1;
            this.gbRegistrarNovoResponsavel.TabStop = false;
            this.gbRegistrarNovoResponsavel.Text = "Registrar Novo Responsavel";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(186, 160);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(250, 16);
            this.lblAviso.TabIndex = 24;
            this.lblAviso.Text = "O responsável precisa ter no mínimo 18 anos!";
            this.lblAviso.Visible = false;
            // 
            // dtpDataNascimentoBuscarResponsavel
            // 
            this.dtpDataNascimentoBuscarResponsavel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimentoBuscarResponsavel.Location = new System.Drawing.Point(189, 131);
            this.dtpDataNascimentoBuscarResponsavel.Name = "dtpDataNascimentoBuscarResponsavel";
            this.dtpDataNascimentoBuscarResponsavel.Size = new System.Drawing.Size(284, 26);
            this.dtpDataNascimentoBuscarResponsavel.TabIndex = 4;
            this.dtpDataNascimentoBuscarResponsavel.ValueChanged += new System.EventHandler(this.dtpDataNascimento_ValueChanged);
            // 
            // btnPreencher
            // 
            this.btnPreencher.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreencher.Location = new System.Drawing.Point(233, 262);
            this.btnPreencher.Name = "btnPreencher";
            this.btnPreencher.Size = new System.Drawing.Size(88, 41);
            this.btnPreencher.TabIndex = 7;
            this.btnPreencher.Text = "Preencher";
            this.btnPreencher.UseVisualStyleBackColor = true;
            this.btnPreencher.Click += new System.EventHandler(this.btnPreencher_Click);
            // 
            // mskdCPFBuscarResponsavel
            // 
            this.mskdCPFBuscarResponsavel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdCPFBuscarResponsavel.Location = new System.Drawing.Point(186, 94);
            this.mskdCPFBuscarResponsavel.Mask = "999.999.999-99";
            this.mskdCPFBuscarResponsavel.Name = "mskdCPFBuscarResponsavel";
            this.mskdCPFBuscarResponsavel.Size = new System.Drawing.Size(121, 26);
            this.mskdCPFBuscarResponsavel.TabIndex = 3;
            // 
            // lbCpfBuscarResponsavel
            // 
            this.lbCpfBuscarResponsavel.AutoSize = true;
            this.lbCpfBuscarResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpfBuscarResponsavel.Location = new System.Drawing.Point(123, 97);
            this.lbCpfBuscarResponsavel.Name = "lbCpfBuscarResponsavel";
            this.lbCpfBuscarResponsavel.Size = new System.Drawing.Size(40, 21);
            this.lbCpfBuscarResponsavel.TabIndex = 22;
            this.lbCpfBuscarResponsavel.Text = "CPF";
            // 
            // mskTxtBoxTelefoneBuscarResponsavel
            // 
            this.mskTxtBoxTelefoneBuscarResponsavel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtBoxTelefoneBuscarResponsavel.Location = new System.Drawing.Point(186, 178);
            this.mskTxtBoxTelefoneBuscarResponsavel.Mask = "(99) 00000-0000";
            this.mskTxtBoxTelefoneBuscarResponsavel.Name = "mskTxtBoxTelefoneBuscarResponsavel";
            this.mskTxtBoxTelefoneBuscarResponsavel.Size = new System.Drawing.Size(121, 26);
            this.mskTxtBoxTelefoneBuscarResponsavel.TabIndex = 5;
            // 
            // txtBoxEmailBuscarResponsavel
            // 
            this.txtBoxEmailBuscarResponsavel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmailBuscarResponsavel.Location = new System.Drawing.Point(186, 220);
            this.txtBoxEmailBuscarResponsavel.Name = "txtBoxEmailBuscarResponsavel";
            this.txtBoxEmailBuscarResponsavel.Size = new System.Drawing.Size(287, 26);
            this.txtBoxEmailBuscarResponsavel.TabIndex = 6;
            // 
            // txtBoxNomeCompletoBuscarResponsavel
            // 
            this.txtBoxNomeCompletoBuscarResponsavel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeCompletoBuscarResponsavel.Location = new System.Drawing.Point(186, 52);
            this.txtBoxNomeCompletoBuscarResponsavel.Name = "txtBoxNomeCompletoBuscarResponsavel";
            this.txtBoxNomeCompletoBuscarResponsavel.Size = new System.Drawing.Size(287, 26);
            this.txtBoxNomeCompletoBuscarResponsavel.TabIndex = 2;
            // 
            // lbEmailBuscarResponsavel
            // 
            this.lbEmailBuscarResponsavel.AutoSize = true;
            this.lbEmailBuscarResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailBuscarResponsavel.Location = new System.Drawing.Point(110, 226);
            this.lbEmailBuscarResponsavel.Name = "lbEmailBuscarResponsavel";
            this.lbEmailBuscarResponsavel.Size = new System.Drawing.Size(56, 21);
            this.lbEmailBuscarResponsavel.TabIndex = 26;
            this.lbEmailBuscarResponsavel.Text = "E-mail";
            // 
            // lbNomeResponsavelBuscarResponsavel
            // 
            this.lbNomeResponsavelBuscarResponsavel.AutoSize = true;
            this.lbNomeResponsavelBuscarResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeResponsavelBuscarResponsavel.Location = new System.Drawing.Point(43, 54);
            this.lbNomeResponsavelBuscarResponsavel.Name = "lbNomeResponsavelBuscarResponsavel";
            this.lbNomeResponsavelBuscarResponsavel.Size = new System.Drawing.Size(137, 21);
            this.lbNomeResponsavelBuscarResponsavel.TabIndex = 21;
            this.lbNomeResponsavelBuscarResponsavel.Text = "Nome completo";
            // 
            // lbDataNascimentoBuscarResponsavel
            // 
            this.lbDataNascimentoBuscarResponsavel.AutoSize = true;
            this.lbDataNascimentoBuscarResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascimentoBuscarResponsavel.Location = new System.Drawing.Point(11, 140);
            this.lbDataNascimentoBuscarResponsavel.Name = "lbDataNascimentoBuscarResponsavel";
            this.lbDataNascimentoBuscarResponsavel.Size = new System.Drawing.Size(172, 21);
            this.lbDataNascimentoBuscarResponsavel.TabIndex = 23;
            this.lbDataNascimentoBuscarResponsavel.Text = "Data de nascimento";
            // 
            // lbTelefoneBuscarResponsavel
            // 
            this.lbTelefoneBuscarResponsavel.AutoSize = true;
            this.lbTelefoneBuscarResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefoneBuscarResponsavel.Location = new System.Drawing.Point(92, 183);
            this.lbTelefoneBuscarResponsavel.Name = "lbTelefoneBuscarResponsavel";
            this.lbTelefoneBuscarResponsavel.Size = new System.Drawing.Size(76, 21);
            this.lbTelefoneBuscarResponsavel.TabIndex = 25;
            this.lbTelefoneBuscarResponsavel.Text = "Telefone";
            // 
            // frmBuscaResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 326);
            this.Controls.Add(this.gbRegistrarNovoResponsavel);
            this.Name = "frmBuscaResponsavel";
            this.Text = "Buscar Responsavel";
            this.Load += new System.EventHandler(this.frmBuscaResponsavel_Load);
            this.gbRegistrarNovoResponsavel.ResumeLayout(false);
            this.gbRegistrarNovoResponsavel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistrarNovoResponsavel;
        private System.Windows.Forms.Label lbCpfBuscarResponsavel;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxTelefoneBuscarResponsavel;
        private System.Windows.Forms.TextBox txtBoxEmailBuscarResponsavel;
        private System.Windows.Forms.TextBox txtBoxNomeCompletoBuscarResponsavel;
        private System.Windows.Forms.Label lbEmailBuscarResponsavel;
        private System.Windows.Forms.Label lbNomeResponsavelBuscarResponsavel;
        private System.Windows.Forms.Label lbDataNascimentoBuscarResponsavel;
        private System.Windows.Forms.Label lbTelefoneBuscarResponsavel;
        private System.Windows.Forms.Button btnPreencher;
        private System.Windows.Forms.DateTimePicker dtpDataNascimentoBuscarResponsavel;
        private System.Windows.Forms.MaskedTextBox mskdCPFBuscarResponsavel;
        private System.Windows.Forms.Label lblAviso;
    }
}