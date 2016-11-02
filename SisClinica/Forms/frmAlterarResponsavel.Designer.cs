namespace SisClinica.Forms
{
    partial class frmAlterarResponsavel
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
            this.btnSelecResp = new System.Windows.Forms.Button();
            this.gbInfoResponsavel = new System.Windows.Forms.GroupBox();
            this.gpResponsavel = new System.Windows.Forms.GroupBox();
            this.txtBoxNomeRegistraResponsavel = new System.Windows.Forms.TextBox();
            this.lblNomeRegistraMedico = new System.Windows.Forms.Label();
            this.gbEndereçoPessoalResponsavel = new System.Windows.Forms.GroupBox();
            this.lblEnderecoRegEnderecoResponsavel = new System.Windows.Forms.Label();
            this.txtboxEnderecoRegResponsavel = new System.Windows.Forms.TextBox();
            this.lblCidadeRegResponsavel = new System.Windows.Forms.Label();
            this.cbCidadeRegResponsavel = new System.Windows.Forms.ComboBox();
            this.lblEstadoRegResponsavel = new System.Windows.Forms.Label();
            this.txtboxBairroRegResponsavel = new System.Windows.Forms.TextBox();
            this.cbEstadoRegResponsavel = new System.Windows.Forms.ComboBox();
            this.lblNumeroRegResponsavel = new System.Windows.Forms.Label();
            this.lblBairroRegMedico = new System.Windows.Forms.Label();
            this.txtboxNumeroRegMedico = new System.Windows.Forms.TextBox();
            this.gbResponsavel = new System.Windows.Forms.GroupBox();
            this.lblTelefoneRegResponsavel = new System.Windows.Forms.Label();
            this.msktxtboxTelefoneRegResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.lblEmailRegResponsavel = new System.Windows.Forms.Label();
            this.txtboxEmailRegResponsavel = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gbInfoResponsavel.SuspendLayout();
            this.gpResponsavel.SuspendLayout();
            this.gbEndereçoPessoalResponsavel.SuspendLayout();
            this.gbResponsavel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelecResp
            // 
            this.btnSelecResp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecResp.Location = new System.Drawing.Point(141, 12);
            this.btnSelecResp.Name = "btnSelecResp";
            this.btnSelecResp.Size = new System.Drawing.Size(170, 42);
            this.btnSelecResp.TabIndex = 0;
            this.btnSelecResp.Text = "Selecionar Responsável";
            this.btnSelecResp.UseVisualStyleBackColor = true;
            // 
            // gbInfoResponsavel
            // 
            this.gbInfoResponsavel.Controls.Add(this.gpResponsavel);
            this.gbInfoResponsavel.Controls.Add(this.gbResponsavel);
            this.gbInfoResponsavel.Controls.Add(this.gbEndereçoPessoalResponsavel);
            this.gbInfoResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoResponsavel.Location = new System.Drawing.Point(12, 60);
            this.gbInfoResponsavel.Name = "gbInfoResponsavel";
            this.gbInfoResponsavel.Size = new System.Drawing.Size(446, 371);
            this.gbInfoResponsavel.TabIndex = 34;
            this.gbInfoResponsavel.TabStop = false;
            this.gbInfoResponsavel.Text = "Informações";
            // 
            // gpResponsavel
            // 
            this.gpResponsavel.Controls.Add(this.txtBoxNomeRegistraResponsavel);
            this.gpResponsavel.Controls.Add(this.lblNomeRegistraMedico);
            this.gpResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gpResponsavel.Location = new System.Drawing.Point(6, 26);
            this.gpResponsavel.Name = "gpResponsavel";
            this.gpResponsavel.Size = new System.Drawing.Size(429, 68);
            this.gpResponsavel.TabIndex = 32;
            this.gpResponsavel.TabStop = false;
            this.gpResponsavel.Text = "Responsavel";
            // 
            // txtBoxNomeRegistraResponsavel
            // 
            this.txtBoxNomeRegistraResponsavel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeRegistraResponsavel.Location = new System.Drawing.Point(88, 36);
            this.txtBoxNomeRegistraResponsavel.Name = "txtBoxNomeRegistraResponsavel";
            this.txtBoxNomeRegistraResponsavel.Size = new System.Drawing.Size(287, 23);
            this.txtBoxNomeRegistraResponsavel.TabIndex = 3;
            // 
            // lblNomeRegistraMedico
            // 
            this.lblNomeRegistraMedico.AutoSize = true;
            this.lblNomeRegistraMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeRegistraMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomeRegistraMedico.Location = new System.Drawing.Point(25, 36);
            this.lblNomeRegistraMedico.Name = "lblNomeRegistraMedico";
            this.lblNomeRegistraMedico.Size = new System.Drawing.Size(57, 21);
            this.lblNomeRegistraMedico.TabIndex = 2;
            this.lblNomeRegistraMedico.Text = "Nome";
            // 
            // gbEndereçoPessoalResponsavel
            // 
            this.gbEndereçoPessoalResponsavel.Controls.Add(this.lblEnderecoRegEnderecoResponsavel);
            this.gbEndereçoPessoalResponsavel.Controls.Add(this.txtboxEnderecoRegResponsavel);
            this.gbEndereçoPessoalResponsavel.Controls.Add(this.lblCidadeRegResponsavel);
            this.gbEndereçoPessoalResponsavel.Controls.Add(this.cbCidadeRegResponsavel);
            this.gbEndereçoPessoalResponsavel.Controls.Add(this.lblEstadoRegResponsavel);
            this.gbEndereçoPessoalResponsavel.Controls.Add(this.txtboxBairroRegResponsavel);
            this.gbEndereçoPessoalResponsavel.Controls.Add(this.cbEstadoRegResponsavel);
            this.gbEndereçoPessoalResponsavel.Controls.Add(this.lblNumeroRegResponsavel);
            this.gbEndereçoPessoalResponsavel.Controls.Add(this.lblBairroRegMedico);
            this.gbEndereçoPessoalResponsavel.Controls.Add(this.txtboxNumeroRegMedico);
            this.gbEndereçoPessoalResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gbEndereçoPessoalResponsavel.Location = new System.Drawing.Point(6, 200);
            this.gbEndereçoPessoalResponsavel.Name = "gbEndereçoPessoalResponsavel";
            this.gbEndereçoPessoalResponsavel.Size = new System.Drawing.Size(429, 165);
            this.gbEndereçoPessoalResponsavel.TabIndex = 31;
            this.gbEndereçoPessoalResponsavel.TabStop = false;
            this.gbEndereçoPessoalResponsavel.Text = "Endereço Pessoal";
            // 
            // lblEnderecoRegEnderecoResponsavel
            // 
            this.lblEnderecoRegEnderecoResponsavel.AutoSize = true;
            this.lblEnderecoRegEnderecoResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoRegEnderecoResponsavel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnderecoRegEnderecoResponsavel.Location = new System.Drawing.Point(6, 34);
            this.lblEnderecoRegEnderecoResponsavel.Name = "lblEnderecoRegEnderecoResponsavel";
            this.lblEnderecoRegEnderecoResponsavel.Size = new System.Drawing.Size(85, 21);
            this.lblEnderecoRegEnderecoResponsavel.TabIndex = 4;
            this.lblEnderecoRegEnderecoResponsavel.Text = "Endereço";
            // 
            // txtboxEnderecoRegResponsavel
            // 
            this.txtboxEnderecoRegResponsavel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEnderecoRegResponsavel.Location = new System.Drawing.Point(97, 32);
            this.txtboxEnderecoRegResponsavel.Name = "txtboxEnderecoRegResponsavel";
            this.txtboxEnderecoRegResponsavel.Size = new System.Drawing.Size(287, 23);
            this.txtboxEnderecoRegResponsavel.TabIndex = 9;
            // 
            // lblCidadeRegResponsavel
            // 
            this.lblCidadeRegResponsavel.AutoSize = true;
            this.lblCidadeRegResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeRegResponsavel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCidadeRegResponsavel.Location = new System.Drawing.Point(224, 100);
            this.lblCidadeRegResponsavel.Name = "lblCidadeRegResponsavel";
            this.lblCidadeRegResponsavel.Size = new System.Drawing.Size(69, 21);
            this.lblCidadeRegResponsavel.TabIndex = 19;
            this.lblCidadeRegResponsavel.Text = "Cidade";
            // 
            // cbCidadeRegResponsavel
            // 
            this.cbCidadeRegResponsavel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidadeRegResponsavel.FormattingEnabled = true;
            this.cbCidadeRegResponsavel.Location = new System.Drawing.Point(299, 101);
            this.cbCidadeRegResponsavel.Name = "cbCidadeRegResponsavel";
            this.cbCidadeRegResponsavel.Size = new System.Drawing.Size(121, 25);
            this.cbCidadeRegResponsavel.TabIndex = 13;
            // 
            // lblEstadoRegResponsavel
            // 
            this.lblEstadoRegResponsavel.AutoSize = true;
            this.lblEstadoRegResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoRegResponsavel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstadoRegResponsavel.Location = new System.Drawing.Point(27, 99);
            this.lblEstadoRegResponsavel.Name = "lblEstadoRegResponsavel";
            this.lblEstadoRegResponsavel.Size = new System.Drawing.Size(64, 21);
            this.lblEstadoRegResponsavel.TabIndex = 7;
            this.lblEstadoRegResponsavel.Text = "Estado";
            // 
            // txtboxBairroRegResponsavel
            // 
            this.txtboxBairroRegResponsavel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBairroRegResponsavel.Location = new System.Drawing.Point(97, 64);
            this.txtboxBairroRegResponsavel.Name = "txtboxBairroRegResponsavel";
            this.txtboxBairroRegResponsavel.Size = new System.Drawing.Size(142, 23);
            this.txtboxBairroRegResponsavel.TabIndex = 11;
            // 
            // cbEstadoRegResponsavel
            // 
            this.cbEstadoRegResponsavel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoRegResponsavel.FormattingEnabled = true;
            this.cbEstadoRegResponsavel.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbEstadoRegResponsavel.Location = new System.Drawing.Point(97, 99);
            this.cbEstadoRegResponsavel.Name = "cbEstadoRegResponsavel";
            this.cbEstadoRegResponsavel.Size = new System.Drawing.Size(121, 25);
            this.cbEstadoRegResponsavel.TabIndex = 12;
            // 
            // lblNumeroRegResponsavel
            // 
            this.lblNumeroRegResponsavel.AutoSize = true;
            this.lblNumeroRegResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRegResponsavel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumeroRegResponsavel.Location = new System.Drawing.Point(267, 68);
            this.lblNumeroRegResponsavel.Name = "lblNumeroRegResponsavel";
            this.lblNumeroRegResponsavel.Size = new System.Drawing.Size(28, 21);
            this.lblNumeroRegResponsavel.TabIndex = 5;
            this.lblNumeroRegResponsavel.Text = "N°";
            // 
            // lblBairroRegMedico
            // 
            this.lblBairroRegMedico.AutoSize = true;
            this.lblBairroRegMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBairroRegMedico.Location = new System.Drawing.Point(38, 66);
            this.lblBairroRegMedico.Name = "lblBairroRegMedico";
            this.lblBairroRegMedico.Size = new System.Drawing.Size(53, 21);
            this.lblBairroRegMedico.TabIndex = 6;
            this.lblBairroRegMedico.Text = "Bairro";
            // 
            // txtboxNumeroRegMedico
            // 
            this.txtboxNumeroRegMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNumeroRegMedico.Location = new System.Drawing.Point(299, 66);
            this.txtboxNumeroRegMedico.Name = "txtboxNumeroRegMedico";
            this.txtboxNumeroRegMedico.Size = new System.Drawing.Size(64, 23);
            this.txtboxNumeroRegMedico.TabIndex = 10;
            // 
            // gbResponsavel
            // 
            this.gbResponsavel.Controls.Add(this.lblTelefoneRegResponsavel);
            this.gbResponsavel.Controls.Add(this.msktxtboxTelefoneRegResponsavel);
            this.gbResponsavel.Controls.Add(this.lblEmailRegResponsavel);
            this.gbResponsavel.Controls.Add(this.txtboxEmailRegResponsavel);
            this.gbResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gbResponsavel.Location = new System.Drawing.Point(6, 100);
            this.gbResponsavel.Name = "gbResponsavel";
            this.gbResponsavel.Size = new System.Drawing.Size(429, 104);
            this.gbResponsavel.TabIndex = 30;
            this.gbResponsavel.TabStop = false;
            this.gbResponsavel.Text = "Contato";
            // 
            // lblTelefoneRegResponsavel
            // 
            this.lblTelefoneRegResponsavel.AutoSize = true;
            this.lblTelefoneRegResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneRegResponsavel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelefoneRegResponsavel.Location = new System.Drawing.Point(6, 53);
            this.lblTelefoneRegResponsavel.Name = "lblTelefoneRegResponsavel";
            this.lblTelefoneRegResponsavel.Size = new System.Drawing.Size(76, 21);
            this.lblTelefoneRegResponsavel.TabIndex = 2;
            this.lblTelefoneRegResponsavel.Text = "Telefone";
            this.lblTelefoneRegResponsavel.Click += new System.EventHandler(this.lblTelefoneRegResponsavel_Click);
            // 
            // msktxtboxTelefoneRegResponsavel
            // 
            this.msktxtboxTelefoneRegResponsavel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtboxTelefoneRegResponsavel.Location = new System.Drawing.Point(88, 56);
            this.msktxtboxTelefoneRegResponsavel.Mask = "(99) 00000-0000";
            this.msktxtboxTelefoneRegResponsavel.Name = "msktxtboxTelefoneRegResponsavel";
            this.msktxtboxTelefoneRegResponsavel.Size = new System.Drawing.Size(121, 23);
            this.msktxtboxTelefoneRegResponsavel.TabIndex = 7;
            // 
            // lblEmailRegResponsavel
            // 
            this.lblEmailRegResponsavel.AutoSize = true;
            this.lblEmailRegResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailRegResponsavel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmailRegResponsavel.Location = new System.Drawing.Point(26, 29);
            this.lblEmailRegResponsavel.Name = "lblEmailRegResponsavel";
            this.lblEmailRegResponsavel.Size = new System.Drawing.Size(56, 21);
            this.lblEmailRegResponsavel.TabIndex = 3;
            this.lblEmailRegResponsavel.Text = "E-mail";
            // 
            // txtboxEmailRegResponsavel
            // 
            this.txtboxEmailRegResponsavel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmailRegResponsavel.Location = new System.Drawing.Point(88, 27);
            this.txtboxEmailRegResponsavel.Name = "txtboxEmailRegResponsavel";
            this.txtboxEmailRegResponsavel.Size = new System.Drawing.Size(287, 23);
            this.txtboxEmailRegResponsavel.TabIndex = 8;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterar.Location = new System.Drawing.Point(168, 437);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(131, 55);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // frmAlterarResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 496);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.gbInfoResponsavel);
            this.Controls.Add(this.btnSelecResp);
            this.Name = "frmAlterarResponsavel";
            this.Text = "Alterar Responsavel";
            this.Load += new System.EventHandler(this.frmAlterarResponsavel_Load);
            this.gbInfoResponsavel.ResumeLayout(false);
            this.gpResponsavel.ResumeLayout(false);
            this.gpResponsavel.PerformLayout();
            this.gbEndereçoPessoalResponsavel.ResumeLayout(false);
            this.gbEndereçoPessoalResponsavel.PerformLayout();
            this.gbResponsavel.ResumeLayout(false);
            this.gbResponsavel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelecResp;
        private System.Windows.Forms.GroupBox gbInfoResponsavel;
        private System.Windows.Forms.GroupBox gpResponsavel;
        private System.Windows.Forms.TextBox txtBoxNomeRegistraResponsavel;
        private System.Windows.Forms.Label lblNomeRegistraMedico;
        private System.Windows.Forms.GroupBox gbEndereçoPessoalResponsavel;
        private System.Windows.Forms.Label lblEnderecoRegEnderecoResponsavel;
        private System.Windows.Forms.TextBox txtboxEnderecoRegResponsavel;
        private System.Windows.Forms.Label lblCidadeRegResponsavel;
        private System.Windows.Forms.ComboBox cbCidadeRegResponsavel;
        private System.Windows.Forms.Label lblEstadoRegResponsavel;
        private System.Windows.Forms.TextBox txtboxBairroRegResponsavel;
        private System.Windows.Forms.ComboBox cbEstadoRegResponsavel;
        private System.Windows.Forms.Label lblNumeroRegResponsavel;
        private System.Windows.Forms.Label lblBairroRegMedico;
        private System.Windows.Forms.TextBox txtboxNumeroRegMedico;
        private System.Windows.Forms.GroupBox gbResponsavel;
        private System.Windows.Forms.Label lblTelefoneRegResponsavel;
        private System.Windows.Forms.MaskedTextBox msktxtboxTelefoneRegResponsavel;
        private System.Windows.Forms.Label lblEmailRegResponsavel;
        private System.Windows.Forms.TextBox txtboxEmailRegResponsavel;
        private System.Windows.Forms.Button btnAlterar;
    }
}