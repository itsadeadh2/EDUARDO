namespace SisClinica.Forms
{
    partial class frmAlterarCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTelefoneRegCliente = new System.Windows.Forms.Label();
            this.msktxtboxTelefoneRegCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblEmailRegCliente = new System.Windows.Forms.Label();
            this.txtboxEmailRegCliente = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBoxNomeRegistraCliente = new System.Windows.Forms.TextBox();
            this.lblNomeRegistraCliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAlterEnderecoCliente = new System.Windows.Forms.Label();
            this.txtboxAlterEnderecoCliente = new System.Windows.Forms.TextBox();
            this.lblCidadeAlterCliente = new System.Windows.Forms.Label();
            this.cbAlterCidadeCliente = new System.Windows.Forms.ComboBox();
            this.lblEstadoRegCliente = new System.Windows.Forms.Label();
            this.txtboxAlterBairroCliente = new System.Windows.Forms.TextBox();
            this.cbAlterEstadoCli = new System.Windows.Forms.ComboBox();
            this.lblNumeroRegCliente = new System.Windows.Forms.Label();
            this.lblAlterBairroCliente = new System.Windows.Forms.Label();
            this.txtboxAlterNumCliente = new System.Windows.Forms.TextBox();
            this.btnPesquisarAlterCli = new System.Windows.Forms.Button();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTelefoneRegCliente);
            this.groupBox1.Controls.Add(this.msktxtboxTelefoneRegCliente);
            this.groupBox1.Controls.Add(this.lblEmailRegCliente);
            this.groupBox1.Controls.Add(this.txtboxEmailRegCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(11, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 104);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contato";
            // 
            // lblTelefoneRegCliente
            // 
            this.lblTelefoneRegCliente.AutoSize = true;
            this.lblTelefoneRegCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneRegCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelefoneRegCliente.Location = new System.Drawing.Point(6, 58);
            this.lblTelefoneRegCliente.Name = "lblTelefoneRegCliente";
            this.lblTelefoneRegCliente.Size = new System.Drawing.Size(71, 20);
            this.lblTelefoneRegCliente.TabIndex = 2;
            this.lblTelefoneRegCliente.Text = "Telefone";
            // 
            // msktxtboxTelefoneRegCliente
            // 
            this.msktxtboxTelefoneRegCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtboxTelefoneRegCliente.Location = new System.Drawing.Point(88, 56);
            this.msktxtboxTelefoneRegCliente.Mask = "(99) 00000-0000";
            this.msktxtboxTelefoneRegCliente.Name = "msktxtboxTelefoneRegCliente";
            this.msktxtboxTelefoneRegCliente.Size = new System.Drawing.Size(121, 22);
            this.msktxtboxTelefoneRegCliente.TabIndex = 7;
            // 
            // lblEmailRegCliente
            // 
            this.lblEmailRegCliente.AutoSize = true;
            this.lblEmailRegCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailRegCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmailRegCliente.Location = new System.Drawing.Point(26, 29);
            this.lblEmailRegCliente.Name = "lblEmailRegCliente";
            this.lblEmailRegCliente.Size = new System.Drawing.Size(53, 20);
            this.lblEmailRegCliente.TabIndex = 3;
            this.lblEmailRegCliente.Text = "E-mail";
            // 
            // txtboxEmailRegCliente
            // 
            this.txtboxEmailRegCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmailRegCliente.Location = new System.Drawing.Point(88, 27);
            this.txtboxEmailRegCliente.Name = "txtboxEmailRegCliente";
            this.txtboxEmailRegCliente.Size = new System.Drawing.Size(287, 22);
            this.txtboxEmailRegCliente.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxNomeRegistraCliente);
            this.groupBox3.Controls.Add(this.lblNomeRegistraCliente);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(11, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 68);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // txtBoxNomeRegistraCliente
            // 
            this.txtBoxNomeRegistraCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeRegistraCliente.Location = new System.Drawing.Point(88, 26);
            this.txtBoxNomeRegistraCliente.Name = "txtBoxNomeRegistraCliente";
            this.txtBoxNomeRegistraCliente.Size = new System.Drawing.Size(287, 22);
            this.txtBoxNomeRegistraCliente.TabIndex = 3;
            // 
            // lblNomeRegistraCliente
            // 
            this.lblNomeRegistraCliente.AutoSize = true;
            this.lblNomeRegistraCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeRegistraCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomeRegistraCliente.Location = new System.Drawing.Point(25, 25);
            this.lblNomeRegistraCliente.Name = "lblNomeRegistraCliente";
            this.lblNomeRegistraCliente.Size = new System.Drawing.Size(51, 20);
            this.lblNomeRegistraCliente.TabIndex = 2;
            this.lblNomeRegistraCliente.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAlterEnderecoCliente);
            this.groupBox2.Controls.Add(this.txtboxAlterEnderecoCliente);
            this.groupBox2.Controls.Add(this.lblCidadeAlterCliente);
            this.groupBox2.Controls.Add(this.cbAlterCidadeCliente);
            this.groupBox2.Controls.Add(this.lblEstadoRegCliente);
            this.groupBox2.Controls.Add(this.txtboxAlterBairroCliente);
            this.groupBox2.Controls.Add(this.cbAlterEstadoCli);
            this.groupBox2.Controls.Add(this.lblNumeroRegCliente);
            this.groupBox2.Controls.Add(this.lblAlterBairroCliente);
            this.groupBox2.Controls.Add(this.txtboxAlterNumCliente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(11, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 150);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço Pessoal";
            // 
            // lblAlterEnderecoCliente
            // 
            this.lblAlterEnderecoCliente.AutoSize = true;
            this.lblAlterEnderecoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterEnderecoCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAlterEnderecoCliente.Location = new System.Drawing.Point(6, 34);
            this.lblAlterEnderecoCliente.Name = "lblAlterEnderecoCliente";
            this.lblAlterEnderecoCliente.Size = new System.Drawing.Size(78, 20);
            this.lblAlterEnderecoCliente.TabIndex = 4;
            this.lblAlterEnderecoCliente.Text = "Endereço";
            // 
            // txtboxAlterEnderecoCliente
            // 
            this.txtboxAlterEnderecoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAlterEnderecoCliente.Location = new System.Drawing.Point(97, 32);
            this.txtboxAlterEnderecoCliente.Name = "txtboxAlterEnderecoCliente";
            this.txtboxAlterEnderecoCliente.Size = new System.Drawing.Size(278, 22);
            this.txtboxAlterEnderecoCliente.TabIndex = 9;
            // 
            // lblCidadeAlterCliente
            // 
            this.lblCidadeAlterCliente.AutoSize = true;
            this.lblCidadeAlterCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeAlterCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCidadeAlterCliente.Location = new System.Drawing.Point(224, 100);
            this.lblCidadeAlterCliente.Name = "lblCidadeAlterCliente";
            this.lblCidadeAlterCliente.Size = new System.Drawing.Size(59, 20);
            this.lblCidadeAlterCliente.TabIndex = 19;
            this.lblCidadeAlterCliente.Text = "Cidade";
            // 
            // cbAlterCidadeCliente
            // 
            this.cbAlterCidadeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlterCidadeCliente.FormattingEnabled = true;
            this.cbAlterCidadeCliente.Location = new System.Drawing.Point(299, 101);
            this.cbAlterCidadeCliente.Name = "cbAlterCidadeCliente";
            this.cbAlterCidadeCliente.Size = new System.Drawing.Size(121, 24);
            this.cbAlterCidadeCliente.TabIndex = 13;
            // 
            // lblEstadoRegCliente
            // 
            this.lblEstadoRegCliente.AutoSize = true;
            this.lblEstadoRegCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoRegCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstadoRegCliente.Location = new System.Drawing.Point(27, 99);
            this.lblEstadoRegCliente.Name = "lblEstadoRegCliente";
            this.lblEstadoRegCliente.Size = new System.Drawing.Size(60, 20);
            this.lblEstadoRegCliente.TabIndex = 7;
            this.lblEstadoRegCliente.Text = "Estado";
            // 
            // txtboxAlterBairroCliente
            // 
            this.txtboxAlterBairroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAlterBairroCliente.Location = new System.Drawing.Point(97, 64);
            this.txtboxAlterBairroCliente.Name = "txtboxAlterBairroCliente";
            this.txtboxAlterBairroCliente.Size = new System.Drawing.Size(142, 22);
            this.txtboxAlterBairroCliente.TabIndex = 11;
            // 
            // cbAlterEstadoCli
            // 
            this.cbAlterEstadoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlterEstadoCli.FormattingEnabled = true;
            this.cbAlterEstadoCli.Items.AddRange(new object[] {
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
            this.cbAlterEstadoCli.Location = new System.Drawing.Point(97, 99);
            this.cbAlterEstadoCli.Name = "cbAlterEstadoCli";
            this.cbAlterEstadoCli.Size = new System.Drawing.Size(121, 24);
            this.cbAlterEstadoCli.TabIndex = 12;
            // 
            // lblNumeroRegCliente
            // 
            this.lblNumeroRegCliente.AutoSize = true;
            this.lblNumeroRegCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRegCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumeroRegCliente.Location = new System.Drawing.Point(267, 68);
            this.lblNumeroRegCliente.Name = "lblNumeroRegCliente";
            this.lblNumeroRegCliente.Size = new System.Drawing.Size(25, 20);
            this.lblNumeroRegCliente.TabIndex = 5;
            this.lblNumeroRegCliente.Text = "N°";
            // 
            // lblAlterBairroCliente
            // 
            this.lblAlterBairroCliente.AutoSize = true;
            this.lblAlterBairroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterBairroCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAlterBairroCliente.Location = new System.Drawing.Point(38, 66);
            this.lblAlterBairroCliente.Name = "lblAlterBairroCliente";
            this.lblAlterBairroCliente.Size = new System.Drawing.Size(51, 20);
            this.lblAlterBairroCliente.TabIndex = 6;
            this.lblAlterBairroCliente.Text = "Bairro";
            // 
            // txtboxAlterNumCliente
            // 
            this.txtboxAlterNumCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAlterNumCliente.Location = new System.Drawing.Point(299, 66);
            this.txtboxAlterNumCliente.Name = "txtboxAlterNumCliente";
            this.txtboxAlterNumCliente.Size = new System.Drawing.Size(64, 22);
            this.txtboxAlterNumCliente.TabIndex = 10;
            // 
            // btnPesquisarAlterCli
            // 
            this.btnPesquisarAlterCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPesquisarAlterCli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisarAlterCli.Location = new System.Drawing.Point(108, 12);
            this.btnPesquisarAlterCli.Name = "btnPesquisarAlterCli";
            this.btnPesquisarAlterCli.Size = new System.Drawing.Size(203, 40);
            this.btnPesquisarAlterCli.TabIndex = 35;
            this.btnPesquisarAlterCli.Text = "Pesquisar Cliente";
            this.btnPesquisarAlterCli.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlterarCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterarCliente.Location = new System.Drawing.Point(149, 432);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(131, 55);
            this.btnAlterarCliente.TabIndex = 39;
            this.btnAlterarCliente.Text = "Alterar";
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(2, 58);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(445, 368);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informações";
            // 
            // frmAlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 499);
            this.Controls.Add(this.btnAlterarCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPesquisarAlterCli);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmAlterarCliente";
            this.Text = "frmAlterarCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTelefoneRegCliente;
        private System.Windows.Forms.MaskedTextBox msktxtboxTelefoneRegCliente;
        private System.Windows.Forms.Label lblEmailRegCliente;
        private System.Windows.Forms.TextBox txtboxEmailRegCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxNomeRegistraCliente;
        private System.Windows.Forms.Label lblNomeRegistraCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAlterEnderecoCliente;
        private System.Windows.Forms.TextBox txtboxAlterEnderecoCliente;
        private System.Windows.Forms.Label lblCidadeAlterCliente;
        private System.Windows.Forms.ComboBox cbAlterCidadeCliente;
        private System.Windows.Forms.Label lblEstadoRegCliente;
        private System.Windows.Forms.TextBox txtboxAlterBairroCliente;
        private System.Windows.Forms.ComboBox cbAlterEstadoCli;
        private System.Windows.Forms.Label lblNumeroRegCliente;
        private System.Windows.Forms.Label lblAlterBairroCliente;
        private System.Windows.Forms.TextBox txtboxAlterNumCliente;
        private System.Windows.Forms.Button btnPesquisarAlterCli;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}