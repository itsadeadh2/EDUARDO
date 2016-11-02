namespace SisClinica.Forms
{
    partial class formRegistraMedico
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
            this.gbRegistraMedico = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.mskdTxtBoxDigitoCRM = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskdtxtbxCRM = new System.Windows.Forms.MaskedTextBox();
            this.cbCidadeRegMedico = new System.Windows.Forms.ComboBox();
            this.cbEstadoRegMedico = new System.Windows.Forms.ComboBox();
            this.lblCrmRegMedico = new System.Windows.Forms.Label();
            this.msktxtboxCpfRegistraMedico = new System.Windows.Forms.MaskedTextBox();
            this.lblCPFMedico = new System.Windows.Forms.Label();
            this.lblCidadeRegMedico = new System.Windows.Forms.Label();
            this.msktxtboxTelefoneRegMedico = new System.Windows.Forms.MaskedTextBox();
            this.txtboxBairroRegMedico = new System.Windows.Forms.TextBox();
            this.txtboxNumeroRegMedico = new System.Windows.Forms.TextBox();
            this.txtboxEmailRegMedico = new System.Windows.Forms.TextBox();
            this.txtboxEnderecoRegMedico = new System.Windows.Forms.TextBox();
            this.txtBoxNomeRegistraMedico = new System.Windows.Forms.TextBox();
            this.lblEmailRegMedico = new System.Windows.Forms.Label();
            this.lblNomeRegistraMedico = new System.Windows.Forms.Label();
            this.lblNumeroRegMedico = new System.Windows.Forms.Label();
            this.lblEstadoRegMedico = new System.Windows.Forms.Label();
            this.lblEnderecoRegEndereco = new System.Windows.Forms.Label();
            this.lblDataNascimentoMedico = new System.Windows.Forms.Label();
            this.lblTelefoneRegMedico = new System.Windows.Forms.Label();
            this.lblBairroRegMedico = new System.Windows.Forms.Label();
            this.btnRegistrarMedico = new System.Windows.Forms.Button();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.gbRegistraMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistraMedico
            // 
            this.gbRegistraMedico.BackColor = System.Drawing.Color.Transparent;
            this.gbRegistraMedico.Controls.Add(this.dtpDataNascimento);
            this.gbRegistraMedico.Controls.Add(this.cbEstado);
            this.gbRegistraMedico.Controls.Add(this.mskdTxtBoxDigitoCRM);
            this.gbRegistraMedico.Controls.Add(this.label1);
            this.gbRegistraMedico.Controls.Add(this.mskdtxtbxCRM);
            this.gbRegistraMedico.Controls.Add(this.cbCidadeRegMedico);
            this.gbRegistraMedico.Controls.Add(this.cbEstadoRegMedico);
            this.gbRegistraMedico.Controls.Add(this.lblCrmRegMedico);
            this.gbRegistraMedico.Controls.Add(this.msktxtboxCpfRegistraMedico);
            this.gbRegistraMedico.Controls.Add(this.lblCPFMedico);
            this.gbRegistraMedico.Controls.Add(this.lblCidadeRegMedico);
            this.gbRegistraMedico.Controls.Add(this.msktxtboxTelefoneRegMedico);
            this.gbRegistraMedico.Controls.Add(this.txtboxBairroRegMedico);
            this.gbRegistraMedico.Controls.Add(this.txtboxNumeroRegMedico);
            this.gbRegistraMedico.Controls.Add(this.txtboxEmailRegMedico);
            this.gbRegistraMedico.Controls.Add(this.txtboxEnderecoRegMedico);
            this.gbRegistraMedico.Controls.Add(this.txtBoxNomeRegistraMedico);
            this.gbRegistraMedico.Controls.Add(this.lblEmailRegMedico);
            this.gbRegistraMedico.Controls.Add(this.lblNomeRegistraMedico);
            this.gbRegistraMedico.Controls.Add(this.lblNumeroRegMedico);
            this.gbRegistraMedico.Controls.Add(this.lblEstadoRegMedico);
            this.gbRegistraMedico.Controls.Add(this.lblEnderecoRegEndereco);
            this.gbRegistraMedico.Controls.Add(this.lblDataNascimentoMedico);
            this.gbRegistraMedico.Controls.Add(this.lblTelefoneRegMedico);
            this.gbRegistraMedico.Controls.Add(this.lblBairroRegMedico);
            this.gbRegistraMedico.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistraMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbRegistraMedico.Location = new System.Drawing.Point(12, 12);
            this.gbRegistraMedico.Name = "gbRegistraMedico";
            this.gbRegistraMedico.Size = new System.Drawing.Size(550, 519);
            this.gbRegistraMedico.TabIndex = 47;
            this.gbRegistraMedico.TabStop = false;
            this.gbRegistraMedico.Text = "Médico";
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(398, 126);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(36, 25);
            this.cbEstado.TabIndex = 5;
            // 
            // mskdTxtBoxDigitoCRM
            // 
            this.mskdTxtBoxDigitoCRM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdTxtBoxDigitoCRM.Location = new System.Drawing.Point(368, 128);
            this.mskdTxtBoxDigitoCRM.Mask = "0";
            this.mskdTxtBoxDigitoCRM.Name = "mskdTxtBoxDigitoCRM";
            this.mskdTxtBoxDigitoCRM.Size = new System.Drawing.Size(24, 23);
            this.mskdTxtBoxDigitoCRM.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(350, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "-";
            // 
            // mskdtxtbxCRM
            // 
            this.mskdtxtbxCRM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdtxtbxCRM.Location = new System.Drawing.Point(223, 128);
            this.mskdtxtbxCRM.Mask = "000000000";
            this.mskdtxtbxCRM.Name = "mskdtxtbxCRM";
            this.mskdtxtbxCRM.Size = new System.Drawing.Size(121, 23);
            this.mskdtxtbxCRM.TabIndex = 3;
            // 
            // cbCidadeRegMedico
            // 
            this.cbCidadeRegMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidadeRegMedico.FormattingEnabled = true;
            this.cbCidadeRegMedico.Location = new System.Drawing.Point(223, 473);
            this.cbCidadeRegMedico.Name = "cbCidadeRegMedico";
            this.cbCidadeRegMedico.Size = new System.Drawing.Size(121, 25);
            this.cbCidadeRegMedico.TabIndex = 13;
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
            this.cbEstadoRegMedico.Location = new System.Drawing.Point(223, 430);
            this.cbEstadoRegMedico.Name = "cbEstadoRegMedico";
            this.cbEstadoRegMedico.Size = new System.Drawing.Size(121, 25);
            this.cbEstadoRegMedico.TabIndex = 12;
            // 
            // lblCrmRegMedico
            // 
            this.lblCrmRegMedico.AutoSize = true;
            this.lblCrmRegMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrmRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCrmRegMedico.Location = new System.Drawing.Point(164, 135);
            this.lblCrmRegMedico.Name = "lblCrmRegMedico";
            this.lblCrmRegMedico.Size = new System.Drawing.Size(48, 21);
            this.lblCrmRegMedico.TabIndex = 23;
            this.lblCrmRegMedico.Text = "CRM";
            // 
            // msktxtboxCpfRegistraMedico
            // 
            this.msktxtboxCpfRegistraMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtboxCpfRegistraMedico.Location = new System.Drawing.Point(223, 96);
            this.msktxtboxCpfRegistraMedico.Mask = "999.999.999-99";
            this.msktxtboxCpfRegistraMedico.Name = "msktxtboxCpfRegistraMedico";
            this.msktxtboxCpfRegistraMedico.Size = new System.Drawing.Size(121, 23);
            this.msktxtboxCpfRegistraMedico.TabIndex = 2;
            // 
            // lblCPFMedico
            // 
            this.lblCPFMedico.AutoSize = true;
            this.lblCPFMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCPFMedico.Location = new System.Drawing.Point(172, 99);
            this.lblCPFMedico.Name = "lblCPFMedico";
            this.lblCPFMedico.Size = new System.Drawing.Size(40, 21);
            this.lblCPFMedico.TabIndex = 21;
            this.lblCPFMedico.Text = "CPF";
            // 
            // lblCidadeRegMedico
            // 
            this.lblCidadeRegMedico.AutoSize = true;
            this.lblCidadeRegMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCidadeRegMedico.Location = new System.Drawing.Point(143, 475);
            this.lblCidadeRegMedico.Name = "lblCidadeRegMedico";
            this.lblCidadeRegMedico.Size = new System.Drawing.Size(69, 21);
            this.lblCidadeRegMedico.TabIndex = 19;
            this.lblCidadeRegMedico.Text = "Cidade";
            // 
            // msktxtboxTelefoneRegMedico
            // 
            this.msktxtboxTelefoneRegMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtboxTelefoneRegMedico.Location = new System.Drawing.Point(223, 214);
            this.msktxtboxTelefoneRegMedico.Mask = "(99) 00000-0000";
            this.msktxtboxTelefoneRegMedico.Name = "msktxtboxTelefoneRegMedico";
            this.msktxtboxTelefoneRegMedico.Size = new System.Drawing.Size(121, 23);
            this.msktxtboxTelefoneRegMedico.TabIndex = 7;
            // 
            // txtboxBairroRegMedico
            // 
            this.txtboxBairroRegMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBairroRegMedico.Location = new System.Drawing.Point(223, 382);
            this.txtboxBairroRegMedico.Name = "txtboxBairroRegMedico";
            this.txtboxBairroRegMedico.Size = new System.Drawing.Size(142, 23);
            this.txtboxBairroRegMedico.TabIndex = 11;
            // 
            // txtboxNumeroRegMedico
            // 
            this.txtboxNumeroRegMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNumeroRegMedico.Location = new System.Drawing.Point(223, 340);
            this.txtboxNumeroRegMedico.Name = "txtboxNumeroRegMedico";
            this.txtboxNumeroRegMedico.Size = new System.Drawing.Size(87, 23);
            this.txtboxNumeroRegMedico.TabIndex = 10;
            // 
            // txtboxEmailRegMedico
            // 
            this.txtboxEmailRegMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmailRegMedico.Location = new System.Drawing.Point(223, 256);
            this.txtboxEmailRegMedico.Name = "txtboxEmailRegMedico";
            this.txtboxEmailRegMedico.Size = new System.Drawing.Size(287, 23);
            this.txtboxEmailRegMedico.TabIndex = 8;
            // 
            // txtboxEnderecoRegMedico
            // 
            this.txtboxEnderecoRegMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEnderecoRegMedico.Location = new System.Drawing.Point(223, 300);
            this.txtboxEnderecoRegMedico.Name = "txtboxEnderecoRegMedico";
            this.txtboxEnderecoRegMedico.Size = new System.Drawing.Size(287, 23);
            this.txtboxEnderecoRegMedico.TabIndex = 9;
            // 
            // txtBoxNomeRegistraMedico
            // 
            this.txtBoxNomeRegistraMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeRegistraMedico.Location = new System.Drawing.Point(223, 54);
            this.txtBoxNomeRegistraMedico.Name = "txtBoxNomeRegistraMedico";
            this.txtBoxNomeRegistraMedico.Size = new System.Drawing.Size(287, 23);
            this.txtBoxNomeRegistraMedico.TabIndex = 1;
            // 
            // lblEmailRegMedico
            // 
            this.lblEmailRegMedico.AutoSize = true;
            this.lblEmailRegMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmailRegMedico.Location = new System.Drawing.Point(156, 260);
            this.lblEmailRegMedico.Name = "lblEmailRegMedico";
            this.lblEmailRegMedico.Size = new System.Drawing.Size(56, 21);
            this.lblEmailRegMedico.TabIndex = 3;
            this.lblEmailRegMedico.Text = "E-mail";
            // 
            // lblNomeRegistraMedico
            // 
            this.lblNomeRegistraMedico.AutoSize = true;
            this.lblNomeRegistraMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeRegistraMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomeRegistraMedico.Location = new System.Drawing.Point(75, 54);
            this.lblNomeRegistraMedico.Name = "lblNomeRegistraMedico";
            this.lblNomeRegistraMedico.Size = new System.Drawing.Size(137, 21);
            this.lblNomeRegistraMedico.TabIndex = 0;
            this.lblNomeRegistraMedico.Text = "Nome completo";
            // 
            // lblNumeroRegMedico
            // 
            this.lblNumeroRegMedico.AutoSize = true;
            this.lblNumeroRegMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumeroRegMedico.Location = new System.Drawing.Point(184, 346);
            this.lblNumeroRegMedico.Name = "lblNumeroRegMedico";
            this.lblNumeroRegMedico.Size = new System.Drawing.Size(28, 21);
            this.lblNumeroRegMedico.TabIndex = 5;
            this.lblNumeroRegMedico.Text = "N°";
            // 
            // lblEstadoRegMedico
            // 
            this.lblEstadoRegMedico.AutoSize = true;
            this.lblEstadoRegMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstadoRegMedico.Location = new System.Drawing.Point(148, 432);
            this.lblEstadoRegMedico.Name = "lblEstadoRegMedico";
            this.lblEstadoRegMedico.Size = new System.Drawing.Size(64, 21);
            this.lblEstadoRegMedico.TabIndex = 7;
            this.lblEstadoRegMedico.Text = "Estado";
            // 
            // lblEnderecoRegEndereco
            // 
            this.lblEnderecoRegEndereco.AutoSize = true;
            this.lblEnderecoRegEndereco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoRegEndereco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnderecoRegEndereco.Location = new System.Drawing.Point(127, 303);
            this.lblEnderecoRegEndereco.Name = "lblEnderecoRegEndereco";
            this.lblEnderecoRegEndereco.Size = new System.Drawing.Size(85, 21);
            this.lblEnderecoRegEndereco.TabIndex = 4;
            this.lblEnderecoRegEndereco.Text = "Endereço";
            // 
            // lblDataNascimentoMedico
            // 
            this.lblDataNascimentoMedico.AutoSize = true;
            this.lblDataNascimentoMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimentoMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDataNascimentoMedico.Location = new System.Drawing.Point(40, 174);
            this.lblDataNascimentoMedico.Name = "lblDataNascimentoMedico";
            this.lblDataNascimentoMedico.Size = new System.Drawing.Size(172, 21);
            this.lblDataNascimentoMedico.TabIndex = 1;
            this.lblDataNascimentoMedico.Text = "Data de nascimento";
            // 
            // lblTelefoneRegMedico
            // 
            this.lblTelefoneRegMedico.AutoSize = true;
            this.lblTelefoneRegMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelefoneRegMedico.Location = new System.Drawing.Point(136, 217);
            this.lblTelefoneRegMedico.Name = "lblTelefoneRegMedico";
            this.lblTelefoneRegMedico.Size = new System.Drawing.Size(76, 21);
            this.lblTelefoneRegMedico.TabIndex = 2;
            this.lblTelefoneRegMedico.Text = "Telefone";
            // 
            // lblBairroRegMedico
            // 
            this.lblBairroRegMedico.AutoSize = true;
            this.lblBairroRegMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBairroRegMedico.Location = new System.Drawing.Point(159, 389);
            this.lblBairroRegMedico.Name = "lblBairroRegMedico";
            this.lblBairroRegMedico.Size = new System.Drawing.Size(53, 21);
            this.lblBairroRegMedico.TabIndex = 6;
            this.lblBairroRegMedico.Text = "Bairro";
            // 
            // btnRegistrarMedico
            // 
            this.btnRegistrarMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMedico.Location = new System.Drawing.Point(222, 537);
            this.btnRegistrarMedico.Name = "btnRegistrarMedico";
            this.btnRegistrarMedico.Size = new System.Drawing.Size(130, 45);
            this.btnRegistrarMedico.TabIndex = 14;
            this.btnRegistrarMedico.Text = "Registrar";
            this.btnRegistrarMedico.UseVisualStyleBackColor = true;
            this.btnRegistrarMedico.Click += new System.EventHandler(this.btnRegistrarMedico_Click);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimento.Location = new System.Drawing.Point(223, 170);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(287, 26);
            this.dtpDataNascimento.TabIndex = 6;
            // 
            // formRegistraMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 587);
            this.Controls.Add(this.btnRegistrarMedico);
            this.Controls.Add(this.gbRegistraMedico);
            this.Name = "formRegistraMedico";
            this.Text = "formRegistraMedico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbRegistraMedico.ResumeLayout(false);
            this.gbRegistraMedico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistraMedico;
        private System.Windows.Forms.MaskedTextBox msktxtboxCpfRegistraMedico;
        private System.Windows.Forms.Label lblCPFMedico;
        private System.Windows.Forms.Label lblCidadeRegMedico;
        private System.Windows.Forms.MaskedTextBox msktxtboxTelefoneRegMedico;
        private System.Windows.Forms.TextBox txtboxBairroRegMedico;
        private System.Windows.Forms.TextBox txtboxNumeroRegMedico;
        private System.Windows.Forms.TextBox txtboxEmailRegMedico;
        private System.Windows.Forms.TextBox txtboxEnderecoRegMedico;
        private System.Windows.Forms.TextBox txtBoxNomeRegistraMedico;
        private System.Windows.Forms.Label lblEmailRegMedico;
        private System.Windows.Forms.Label lblNomeRegistraMedico;
        private System.Windows.Forms.Label lblNumeroRegMedico;
        private System.Windows.Forms.Label lblEstadoRegMedico;
        private System.Windows.Forms.Label lblEnderecoRegEndereco;
        private System.Windows.Forms.Label lblDataNascimentoMedico;
        private System.Windows.Forms.Label lblTelefoneRegMedico;
        private System.Windows.Forms.Label lblBairroRegMedico;
        private System.Windows.Forms.Label lblCrmRegMedico;
        private System.Windows.Forms.ComboBox cbCidadeRegMedico;
        private System.Windows.Forms.ComboBox cbEstadoRegMedico;
        private System.Windows.Forms.MaskedTextBox mskdTxtBoxDigitoCRM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskdtxtbxCRM;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnRegistrarMedico;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
    }
}