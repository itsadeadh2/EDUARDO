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
            this.gbRegistrarNovo = new System.Windows.Forms.GroupBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnPreencher = new System.Windows.Forms.Button();
            this.mskdCPF = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mskTxtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbRegistrarNovo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistrarNovo
            // 
            this.gbRegistrarNovo.BackColor = System.Drawing.Color.Transparent;
            this.gbRegistrarNovo.Controls.Add(this.lblAviso);
            this.gbRegistrarNovo.Controls.Add(this.dtpDataNascimento);
            this.gbRegistrarNovo.Controls.Add(this.btnPreencher);
            this.gbRegistrarNovo.Controls.Add(this.mskdCPF);
            this.gbRegistrarNovo.Controls.Add(this.label11);
            this.gbRegistrarNovo.Controls.Add(this.mskTxtBoxTelefone);
            this.gbRegistrarNovo.Controls.Add(this.txtBoxEmail);
            this.gbRegistrarNovo.Controls.Add(this.txtBoxNomeCompleto);
            this.gbRegistrarNovo.Controls.Add(this.label4);
            this.gbRegistrarNovo.Controls.Add(this.label1);
            this.gbRegistrarNovo.Controls.Add(this.label2);
            this.gbRegistrarNovo.Controls.Add(this.label3);
            this.gbRegistrarNovo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrarNovo.Location = new System.Drawing.Point(12, 12);
            this.gbRegistrarNovo.Name = "gbRegistrarNovo";
            this.gbRegistrarNovo.Size = new System.Drawing.Size(555, 309);
            this.gbRegistrarNovo.TabIndex = 47;
            this.gbRegistrarNovo.TabStop = false;
            this.gbRegistrarNovo.Text = "Registrar Novo";
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
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimento.Location = new System.Drawing.Point(189, 131);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(284, 26);
            this.dtpDataNascimento.TabIndex = 23;
            this.dtpDataNascimento.ValueChanged += new System.EventHandler(this.dtpDataNascimento_ValueChanged);
            // 
            // btnPreencher
            // 
            this.btnPreencher.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreencher.Location = new System.Drawing.Point(233, 262);
            this.btnPreencher.Name = "btnPreencher";
            this.btnPreencher.Size = new System.Drawing.Size(88, 41);
            this.btnPreencher.TabIndex = 22;
            this.btnPreencher.Text = "Preencher";
            this.btnPreencher.UseVisualStyleBackColor = true;
            this.btnPreencher.Click += new System.EventHandler(this.btnPreencher_Click);
            // 
            // mskdCPF
            // 
            this.mskdCPF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdCPF.Location = new System.Drawing.Point(186, 94);
            this.mskdCPF.Mask = "999.999.999-99";
            this.mskdCPF.Name = "mskdCPF";
            this.mskdCPF.Size = new System.Drawing.Size(121, 26);
            this.mskdCPF.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(123, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "CPF";
            // 
            // mskTxtBoxTelefone
            // 
            this.mskTxtBoxTelefone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtBoxTelefone.Location = new System.Drawing.Point(186, 178);
            this.mskTxtBoxTelefone.Mask = "(99) 00000-0000";
            this.mskTxtBoxTelefone.Name = "mskTxtBoxTelefone";
            this.mskTxtBoxTelefone.Size = new System.Drawing.Size(121, 26);
            this.mskTxtBoxTelefone.TabIndex = 4;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(186, 220);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(287, 26);
            this.txtBoxEmail.TabIndex = 5;
            // 
            // txtBoxNomeCompleto
            // 
            this.txtBoxNomeCompleto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeCompleto.Location = new System.Drawing.Point(186, 52);
            this.txtBoxNomeCompleto.Name = "txtBoxNomeCompleto";
            this.txtBoxNomeCompleto.Size = new System.Drawing.Size(287, 26);
            this.txtBoxNomeCompleto.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // frmBuscaResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 555);
            this.Controls.Add(this.gbRegistrarNovo);
            this.Name = "frmBuscaResponsavel";
            this.Text = "frmBuscaResponsavel";
            this.Load += new System.EventHandler(this.frmBuscaResponsavel_Load);
            this.gbRegistrarNovo.ResumeLayout(false);
            this.gbRegistrarNovo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistrarNovo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxTelefone;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxNomeCompleto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPreencher;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.MaskedTextBox mskdCPF;
        private System.Windows.Forms.Label lblAviso;
    }
}