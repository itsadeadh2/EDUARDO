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
            this.txtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblEmailRegMedico = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEnderecoRegEndereco = new System.Windows.Forms.Label();
            this.txtbEndereco = new System.Windows.Forms.TextBox();
            this.lblCidadeRegMedico = new System.Windows.Forms.Label();
            this.txtbCidade = new System.Windows.Forms.ComboBox();
            this.lblEstadoRegMedico = new System.Windows.Forms.Label();
            this.txtbBairro = new System.Windows.Forms.TextBox();
            this.txtbEstado = new System.Windows.Forms.ComboBox();
            this.lblNumeroRegMedico = new System.Windows.Forms.Label();
            this.lblBairroRegMedico = new System.Windows.Forms.Label();
            this.txtbnumero = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbNome = new System.Windows.Forms.TextBox();
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
            this.btnAlterar.Location = new System.Drawing.Point(181, 410);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(131, 55);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTelefoneRegMedico);
            this.groupBox1.Controls.Add(this.txtbTelefone);
            this.groupBox1.Controls.Add(this.lblEmailRegMedico);
            this.groupBox1.Controls.Add(this.txtbEmail);
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
            // txtbTelefone
            // 
            this.txtbTelefone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTelefone.Location = new System.Drawing.Point(88, 56);
            this.txtbTelefone.Mask = "(99) 00000-0000";
            this.txtbTelefone.Name = "txtbTelefone";
            this.txtbTelefone.Size = new System.Drawing.Size(121, 23);
            this.txtbTelefone.TabIndex = 4;
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
            // txtbEmail
            // 
            this.txtbEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmail.Location = new System.Drawing.Point(88, 27);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(287, 23);
            this.txtbEmail.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEnderecoRegEndereco);
            this.groupBox2.Controls.Add(this.txtbEndereco);
            this.groupBox2.Controls.Add(this.lblCidadeRegMedico);
            this.groupBox2.Controls.Add(this.txtbCidade);
            this.groupBox2.Controls.Add(this.lblEstadoRegMedico);
            this.groupBox2.Controls.Add(this.txtbBairro);
            this.groupBox2.Controls.Add(this.txtbEstado);
            this.groupBox2.Controls.Add(this.lblNumeroRegMedico);
            this.groupBox2.Controls.Add(this.lblBairroRegMedico);
            this.groupBox2.Controls.Add(this.txtbnumero);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox2.Location = new System.Drawing.Point(27, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 141);
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
            // txtbEndereco
            // 
            this.txtbEndereco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEndereco.Location = new System.Drawing.Point(97, 32);
            this.txtbEndereco.Name = "txtbEndereco";
            this.txtbEndereco.Size = new System.Drawing.Size(287, 23);
            this.txtbEndereco.TabIndex = 5;
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
            // txtbCidade
            // 
            this.txtbCidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCidade.FormattingEnabled = true;
            this.txtbCidade.Location = new System.Drawing.Point(299, 101);
            this.txtbCidade.Name = "txtbCidade";
            this.txtbCidade.Size = new System.Drawing.Size(121, 25);
            this.txtbCidade.TabIndex = 9;
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
            // txtbBairro
            // 
            this.txtbBairro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbBairro.Location = new System.Drawing.Point(97, 64);
            this.txtbBairro.Name = "txtbBairro";
            this.txtbBairro.Size = new System.Drawing.Size(142, 23);
            this.txtbBairro.TabIndex = 6;
            // 
            // txtbEstado
            // 
            this.txtbEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEstado.FormattingEnabled = true;
            this.txtbEstado.Items.AddRange(new object[] {
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
            this.txtbEstado.Location = new System.Drawing.Point(97, 99);
            this.txtbEstado.Name = "txtbEstado";
            this.txtbEstado.Size = new System.Drawing.Size(121, 25);
            this.txtbEstado.TabIndex = 8;
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
            // txtbnumero
            // 
            this.txtbnumero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbnumero.Location = new System.Drawing.Point(299, 66);
            this.txtbnumero.Name = "txtbnumero";
            this.txtbnumero.Size = new System.Drawing.Size(64, 23);
            this.txtbnumero.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtbNome);
            this.groupBox3.Controls.Add(this.lblNomeRegistraMedico);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox3.Location = new System.Drawing.Point(27, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 68);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Medico";
            // 
            // txtbNome
            // 
            this.txtbNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNome.Location = new System.Drawing.Point(88, 36);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(306, 23);
            this.txtbNome.TabIndex = 2;
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
            this.gbInfoMedico.Size = new System.Drawing.Size(482, 350);
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
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar Médico";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmAlterarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 470);
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
        private System.Windows.Forms.MaskedTextBox txtbTelefone;
        private System.Windows.Forms.Label lblEmailRegMedico;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEnderecoRegEndereco;
        private System.Windows.Forms.TextBox txtbEndereco;
        private System.Windows.Forms.Label lblCidadeRegMedico;
        private System.Windows.Forms.ComboBox txtbCidade;
        private System.Windows.Forms.Label lblEstadoRegMedico;
        private System.Windows.Forms.TextBox txtbBairro;
        private System.Windows.Forms.ComboBox txtbEstado;
        private System.Windows.Forms.Label lblNumeroRegMedico;
        private System.Windows.Forms.Label lblBairroRegMedico;
        private System.Windows.Forms.TextBox txtbnumero;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label lblNomeRegistraMedico;
        private System.Windows.Forms.GroupBox gbInfoMedico;
        private System.Windows.Forms.Button btnPesquisar;
    }
}