namespace SisClinica.Forms
{
    partial class frmAlterarMedico
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTelefoneRegMedico = new System.Windows.Forms.Label();
            this.msktxtboxTelefoneRegMedico = new System.Windows.Forms.MaskedTextBox();
            this.lblEmailRegMedico = new System.Windows.Forms.Label();
            this.txtboxEmailRegMedico = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEnderecoRegEndereco = new System.Windows.Forms.Label();
            this.txtboxEnderecoRegMedico = new System.Windows.Forms.TextBox();
            this.lblCidadeRegMedico = new System.Windows.Forms.Label();
            this.cbCidadeRegMedico = new System.Windows.Forms.ComboBox();
            this.lblEstadoRegMedico = new System.Windows.Forms.Label();
            this.txtboxBairroRegMedico = new System.Windows.Forms.TextBox();
            this.cbEstadoRegMedico = new System.Windows.Forms.ComboBox();
            this.lblNumeroRegMedico = new System.Windows.Forms.Label();
            this.lblBairroRegMedico = new System.Windows.Forms.Label();
            this.txtboxNumeroRegMedico = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBoxNomeRegistraMedico = new System.Windows.Forms.TextBox();
            this.lblNomeRegistraMedico = new System.Windows.Forms.Label();
            this.gbInfoMedico = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbInfoMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterar.Location = new System.Drawing.Point(181, 439);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(131, 55);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTelefoneRegMedico);
            this.groupBox1.Controls.Add(this.msktxtboxTelefoneRegMedico);
            this.groupBox1.Controls.Add(this.lblEmailRegMedico);
            this.groupBox1.Controls.Add(this.txtboxEmailRegMedico);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox1.Location = new System.Drawing.Point(27, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 104);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contato";
            // 
            // lblTelefoneRegMedico
            // 
            this.lblTelefoneRegMedico.AutoSize = true;
            this.lblTelefoneRegMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelefoneRegMedico.Location = new System.Drawing.Point(6, 53);
            this.lblTelefoneRegMedico.Name = "lblTelefoneRegMedico";
            this.lblTelefoneRegMedico.Size = new System.Drawing.Size(76, 21);
            this.lblTelefoneRegMedico.TabIndex = 2;
            this.lblTelefoneRegMedico.Text = "Telefone";
            // 
            // msktxtboxTelefoneRegMedico
            // 
            this.msktxtboxTelefoneRegMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtboxTelefoneRegMedico.Location = new System.Drawing.Point(88, 56);
            this.msktxtboxTelefoneRegMedico.Mask = "(99) 00000-0000";
            this.msktxtboxTelefoneRegMedico.Name = "msktxtboxTelefoneRegMedico";
            this.msktxtboxTelefoneRegMedico.Size = new System.Drawing.Size(121, 23);
            this.msktxtboxTelefoneRegMedico.TabIndex = 7;
            // 
            // lblEmailRegMedico
            // 
            this.lblEmailRegMedico.AutoSize = true;
            this.lblEmailRegMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmailRegMedico.Location = new System.Drawing.Point(26, 29);
            this.lblEmailRegMedico.Name = "lblEmailRegMedico";
            this.lblEmailRegMedico.Size = new System.Drawing.Size(56, 21);
            this.lblEmailRegMedico.TabIndex = 3;
            this.lblEmailRegMedico.Text = "E-mail";
            // 
            // txtboxEmailRegMedico
            // 
            this.txtboxEmailRegMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmailRegMedico.Location = new System.Drawing.Point(88, 27);
            this.txtboxEmailRegMedico.Name = "txtboxEmailRegMedico";
            this.txtboxEmailRegMedico.Size = new System.Drawing.Size(287, 23);
            this.txtboxEmailRegMedico.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEnderecoRegEndereco);
            this.groupBox2.Controls.Add(this.txtboxEnderecoRegMedico);
            this.groupBox2.Controls.Add(this.lblCidadeRegMedico);
            this.groupBox2.Controls.Add(this.cbCidadeRegMedico);
            this.groupBox2.Controls.Add(this.lblEstadoRegMedico);
            this.groupBox2.Controls.Add(this.txtboxBairroRegMedico);
            this.groupBox2.Controls.Add(this.cbEstadoRegMedico);
            this.groupBox2.Controls.Add(this.lblNumeroRegMedico);
            this.groupBox2.Controls.Add(this.lblBairroRegMedico);
            this.groupBox2.Controls.Add(this.txtboxNumeroRegMedico);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox2.Location = new System.Drawing.Point(27, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 173);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço Pessoal";
            // 
            // lblEnderecoRegEndereco
            // 
            this.lblEnderecoRegEndereco.AutoSize = true;
            this.lblEnderecoRegEndereco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoRegEndereco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnderecoRegEndereco.Location = new System.Drawing.Point(6, 34);
            this.lblEnderecoRegEndereco.Name = "lblEnderecoRegEndereco";
            this.lblEnderecoRegEndereco.Size = new System.Drawing.Size(85, 21);
            this.lblEnderecoRegEndereco.TabIndex = 4;
            this.lblEnderecoRegEndereco.Text = "Endereço";
            // 
            // txtboxEnderecoRegMedico
            // 
            this.txtboxEnderecoRegMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEnderecoRegMedico.Location = new System.Drawing.Point(97, 32);
            this.txtboxEnderecoRegMedico.Name = "txtboxEnderecoRegMedico";
            this.txtboxEnderecoRegMedico.Size = new System.Drawing.Size(287, 23);
            this.txtboxEnderecoRegMedico.TabIndex = 9;
            // 
            // lblCidadeRegMedico
            // 
            this.lblCidadeRegMedico.AutoSize = true;
            this.lblCidadeRegMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCidadeRegMedico.Location = new System.Drawing.Point(224, 100);
            this.lblCidadeRegMedico.Name = "lblCidadeRegMedico";
            this.lblCidadeRegMedico.Size = new System.Drawing.Size(69, 21);
            this.lblCidadeRegMedico.TabIndex = 19;
            this.lblCidadeRegMedico.Text = "Cidade";
            // 
            // cbCidadeRegMedico
            // 
            this.cbCidadeRegMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidadeRegMedico.FormattingEnabled = true;
            this.cbCidadeRegMedico.Location = new System.Drawing.Point(299, 101);
            this.cbCidadeRegMedico.Name = "cbCidadeRegMedico";
            this.cbCidadeRegMedico.Size = new System.Drawing.Size(121, 25);
            this.cbCidadeRegMedico.TabIndex = 13;
            // 
            // lblEstadoRegMedico
            // 
            this.lblEstadoRegMedico.AutoSize = true;
            this.lblEstadoRegMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstadoRegMedico.Location = new System.Drawing.Point(27, 99);
            this.lblEstadoRegMedico.Name = "lblEstadoRegMedico";
            this.lblEstadoRegMedico.Size = new System.Drawing.Size(64, 21);
            this.lblEstadoRegMedico.TabIndex = 7;
            this.lblEstadoRegMedico.Text = "Estado";
            // 
            // txtboxBairroRegMedico
            // 
            this.txtboxBairroRegMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBairroRegMedico.Location = new System.Drawing.Point(97, 64);
            this.txtboxBairroRegMedico.Name = "txtboxBairroRegMedico";
            this.txtboxBairroRegMedico.Size = new System.Drawing.Size(142, 23);
            this.txtboxBairroRegMedico.TabIndex = 11;
            // 
            // cbEstadoRegMedico
            // 
            this.cbEstadoRegMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoRegMedico.FormattingEnabled = true;
            this.cbEstadoRegMedico.Items.AddRange(new object[] {
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
            this.cbEstadoRegMedico.Location = new System.Drawing.Point(97, 99);
            this.cbEstadoRegMedico.Name = "cbEstadoRegMedico";
            this.cbEstadoRegMedico.Size = new System.Drawing.Size(121, 25);
            this.cbEstadoRegMedico.TabIndex = 12;
            // 
            // lblNumeroRegMedico
            // 
            this.lblNumeroRegMedico.AutoSize = true;
            this.lblNumeroRegMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumeroRegMedico.Location = new System.Drawing.Point(267, 68);
            this.lblNumeroRegMedico.Name = "lblNumeroRegMedico";
            this.lblNumeroRegMedico.Size = new System.Drawing.Size(28, 21);
            this.lblNumeroRegMedico.TabIndex = 5;
            this.lblNumeroRegMedico.Text = "N°";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxNomeRegistraMedico);
            this.groupBox3.Controls.Add(this.lblNomeRegistraMedico);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox3.Location = new System.Drawing.Point(27, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 68);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Medico";
            // 
            // txtBoxNomeRegistraMedico
            // 
            this.txtBoxNomeRegistraMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeRegistraMedico.Location = new System.Drawing.Point(88, 36);
            this.txtBoxNomeRegistraMedico.Name = "txtBoxNomeRegistraMedico";
            this.txtBoxNomeRegistraMedico.Size = new System.Drawing.Size(306, 23);
            this.txtBoxNomeRegistraMedico.TabIndex = 3;
            // 
            // lblNomeRegistraMedico
            // 
            this.lblNomeRegistraMedico.AutoSize = true;
            this.lblNomeRegistraMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeRegistraMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomeRegistraMedico.Location = new System.Drawing.Point(25, 35);
            this.lblNomeRegistraMedico.Name = "lblNomeRegistraMedico";
            this.lblNomeRegistraMedico.Size = new System.Drawing.Size(57, 21);
            this.lblNomeRegistraMedico.TabIndex = 2;
            this.lblNomeRegistraMedico.Text = "Nome";
            // 
            // gbInfoMedico
            // 
            this.gbInfoMedico.Controls.Add(this.groupBox3);
            this.gbInfoMedico.Controls.Add(this.groupBox2);
            this.gbInfoMedico.Controls.Add(this.groupBox1);
            this.gbInfoMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoMedico.Location = new System.Drawing.Point(5, 54);
            this.gbInfoMedico.Name = "gbInfoMedico";
            this.gbInfoMedico.Size = new System.Drawing.Size(482, 379);
            this.gbInfoMedico.TabIndex = 33;
            this.gbInfoMedico.TabStop = false;
            this.gbInfoMedico.Text = "Informações";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisar.Location = new System.Drawing.Point(145, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(203, 40);
            this.btnPesquisar.TabIndex = 34;
            this.btnPesquisar.Text = "Pesquisar Médico";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // frmAlterarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 506);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.gbInfoMedico);
            this.Controls.Add(this.btnAlterar);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "frmAlterarMedico";
            this.Text = "Alterar Medico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbInfoMedico.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTelefoneRegMedico;
        private System.Windows.Forms.MaskedTextBox msktxtboxTelefoneRegMedico;
        private System.Windows.Forms.Label lblEmailRegMedico;
        private System.Windows.Forms.TextBox txtboxEmailRegMedico;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEnderecoRegEndereco;
        private System.Windows.Forms.TextBox txtboxEnderecoRegMedico;
        private System.Windows.Forms.Label lblCidadeRegMedico;
        private System.Windows.Forms.ComboBox cbCidadeRegMedico;
        private System.Windows.Forms.Label lblEstadoRegMedico;
        private System.Windows.Forms.TextBox txtboxBairroRegMedico;
        private System.Windows.Forms.ComboBox cbEstadoRegMedico;
        private System.Windows.Forms.Label lblNumeroRegMedico;
        private System.Windows.Forms.Label lblBairroRegMedico;
        private System.Windows.Forms.TextBox txtboxNumeroRegMedico;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxNomeRegistraMedico;
        private System.Windows.Forms.Label lblNomeRegistraMedico;
        private System.Windows.Forms.GroupBox gbInfoMedico;
        private System.Windows.Forms.Button btnPesquisar;
    }
}