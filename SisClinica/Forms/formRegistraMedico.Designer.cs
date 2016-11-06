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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegistraMedico));
            this.gbRegistraMedico = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEnderecoRegEndereco = new System.Windows.Forms.Label();
            this.txtboxEnderecoRegMedico = new System.Windows.Forms.TextBox();
            this.lblCidadeRegMedico = new System.Windows.Forms.Label();
            this.cbCidadeRegMedico = new System.Windows.Forms.ComboBox();
            this.lblEstadoRegMedico = new System.Windows.Forms.Label();
            this.cbEstadoRegMedico = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.mskdTxtBoxDigitoCRM = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskdtxtbxCRM = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNascimentoMedico = new System.Windows.Forms.Label();
            this.lblCrmRegMedico = new System.Windows.Forms.Label();
            this.msktxtboxCpfRegistraMedico = new System.Windows.Forms.MaskedTextBox();
            this.lblCPFMedico = new System.Windows.Forms.Label();
            this.txtBoxNomeRegistraMedico = new System.Windows.Forms.TextBox();
            this.lblNomeRegistraMedico = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTelefoneRegMedico = new System.Windows.Forms.Label();
            this.msktxtboxTelefoneRegMedico = new System.Windows.Forms.MaskedTextBox();
            this.lblEmailRegMedico = new System.Windows.Forms.Label();
            this.txtboxEmailRegMedico = new System.Windows.Forms.TextBox();
            this.btnRegistrarMedico = new System.Windows.Forms.Button();
            this.gbRegistraMedico.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistraMedico
            // 
            this.gbRegistraMedico.BackColor = System.Drawing.Color.Transparent;
            this.gbRegistraMedico.Controls.Add(this.groupBox2);
            this.gbRegistraMedico.Controls.Add(this.cbEstado);
            this.gbRegistraMedico.Controls.Add(this.dtpDataNascimento);
            this.gbRegistraMedico.Controls.Add(this.mskdTxtBoxDigitoCRM);
            this.gbRegistraMedico.Controls.Add(this.label1);
            this.gbRegistraMedico.Controls.Add(this.mskdtxtbxCRM);
            this.gbRegistraMedico.Controls.Add(this.lblDataNascimentoMedico);
            this.gbRegistraMedico.Controls.Add(this.lblCrmRegMedico);
            this.gbRegistraMedico.Controls.Add(this.msktxtboxCpfRegistraMedico);
            this.gbRegistraMedico.Controls.Add(this.lblCPFMedico);
            this.gbRegistraMedico.Controls.Add(this.txtBoxNomeRegistraMedico);
            this.gbRegistraMedico.Controls.Add(this.lblNomeRegistraMedico);
            this.gbRegistraMedico.Controls.Add(this.groupBox1);
            this.gbRegistraMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistraMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbRegistraMedico.Location = new System.Drawing.Point(12, 12);
            this.gbRegistraMedico.Name = "gbRegistraMedico";
            this.gbRegistraMedico.Size = new System.Drawing.Size(550, 478);
            this.gbRegistraMedico.TabIndex = 47;
            this.gbRegistraMedico.TabStop = false;
            this.gbRegistraMedico.Text = "Médico";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEnderecoRegEndereco);
            this.groupBox2.Controls.Add(this.txtboxEnderecoRegMedico);
            this.groupBox2.Controls.Add(this.lblCidadeRegMedico);
            this.groupBox2.Controls.Add(this.cbCidadeRegMedico);
            this.groupBox2.Controls.Add(this.lblEstadoRegMedico);
            this.groupBox2.Controls.Add(this.cbEstadoRegMedico);
            this.groupBox2.Location = new System.Drawing.Point(0, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 173);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço Pessoal";
            // 
            // lblEnderecoRegEndereco
            // 
            this.lblEnderecoRegEndereco.AutoSize = true;
            this.lblEnderecoRegEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoRegEndereco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnderecoRegEndereco.Location = new System.Drawing.Point(6, 34);
            this.lblEnderecoRegEndereco.Name = "lblEnderecoRegEndereco";
            this.lblEnderecoRegEndereco.Size = new System.Drawing.Size(78, 20);
            this.lblEnderecoRegEndereco.TabIndex = 4;
            this.lblEnderecoRegEndereco.Text = "Endereço";
            // 
            // txtboxEnderecoRegMedico
            // 
            this.txtboxEnderecoRegMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEnderecoRegMedico.Location = new System.Drawing.Point(97, 32);
            this.txtboxEnderecoRegMedico.Name = "txtboxEnderecoRegMedico";
            this.txtboxEnderecoRegMedico.Size = new System.Drawing.Size(287, 22);
            this.txtboxEnderecoRegMedico.TabIndex = 9;
            // 
            // lblCidadeRegMedico
            // 
            this.lblCidadeRegMedico.AutoSize = true;
            this.lblCidadeRegMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCidadeRegMedico.Location = new System.Drawing.Point(224, 61);
            this.lblCidadeRegMedico.Name = "lblCidadeRegMedico";
            this.lblCidadeRegMedico.Size = new System.Drawing.Size(59, 20);
            this.lblCidadeRegMedico.TabIndex = 19;
            this.lblCidadeRegMedico.Text = "Cidade";
            // 
            // cbCidadeRegMedico
            // 
            this.cbCidadeRegMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidadeRegMedico.FormattingEnabled = true;
            this.cbCidadeRegMedico.Location = new System.Drawing.Point(299, 62);
            this.cbCidadeRegMedico.Name = "cbCidadeRegMedico";
            this.cbCidadeRegMedico.Size = new System.Drawing.Size(121, 24);
            this.cbCidadeRegMedico.TabIndex = 13;
            // 
            // lblEstadoRegMedico
            // 
            this.lblEstadoRegMedico.AutoSize = true;
            this.lblEstadoRegMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstadoRegMedico.Location = new System.Drawing.Point(27, 60);
            this.lblEstadoRegMedico.Name = "lblEstadoRegMedico";
            this.lblEstadoRegMedico.Size = new System.Drawing.Size(60, 20);
            this.lblEstadoRegMedico.TabIndex = 7;
            this.lblEstadoRegMedico.Text = "Estado";
            // 
            // cbEstadoRegMedico
            // 
            this.cbEstadoRegMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbEstadoRegMedico.Location = new System.Drawing.Point(97, 60);
            this.cbEstadoRegMedico.Name = "cbEstadoRegMedico";
            this.cbEstadoRegMedico.Size = new System.Drawing.Size(121, 24);
            this.cbEstadoRegMedico.TabIndex = 12;
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(462, 63);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(36, 24);
            this.cbEstado.TabIndex = 5;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimento.Location = new System.Drawing.Point(184, 94);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(314, 24);
            this.dtpDataNascimento.TabIndex = 6;
            // 
            // mskdTxtBoxDigitoCRM
            // 
            this.mskdTxtBoxDigitoCRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdTxtBoxDigitoCRM.Location = new System.Drawing.Point(432, 65);
            this.mskdTxtBoxDigitoCRM.Mask = "0";
            this.mskdTxtBoxDigitoCRM.Name = "mskdTxtBoxDigitoCRM";
            this.mskdTxtBoxDigitoCRM.Size = new System.Drawing.Size(24, 22);
            this.mskdTxtBoxDigitoCRM.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(423, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "-";
            // 
            // mskdtxtbxCRM
            // 
            this.mskdtxtbxCRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdtxtbxCRM.Location = new System.Drawing.Point(351, 65);
            this.mskdtxtbxCRM.Mask = "000000000";
            this.mskdtxtbxCRM.Name = "mskdtxtbxCRM";
            this.mskdtxtbxCRM.Size = new System.Drawing.Size(75, 22);
            this.mskdtxtbxCRM.TabIndex = 3;
            // 
            // lblDataNascimentoMedico
            // 
            this.lblDataNascimentoMedico.AutoSize = true;
            this.lblDataNascimentoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimentoMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDataNascimentoMedico.Location = new System.Drawing.Point(6, 94);
            this.lblDataNascimentoMedico.Name = "lblDataNascimentoMedico";
            this.lblDataNascimentoMedico.Size = new System.Drawing.Size(152, 20);
            this.lblDataNascimentoMedico.TabIndex = 1;
            this.lblDataNascimentoMedico.Text = "Data de nascimento";
            // 
            // lblCrmRegMedico
            // 
            this.lblCrmRegMedico.AutoSize = true;
            this.lblCrmRegMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrmRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCrmRegMedico.Location = new System.Drawing.Point(297, 67);
            this.lblCrmRegMedico.Name = "lblCrmRegMedico";
            this.lblCrmRegMedico.Size = new System.Drawing.Size(45, 20);
            this.lblCrmRegMedico.TabIndex = 23;
            this.lblCrmRegMedico.Text = "CRM";
            // 
            // msktxtboxCpfRegistraMedico
            // 
            this.msktxtboxCpfRegistraMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtboxCpfRegistraMedico.Location = new System.Drawing.Point(192, 65);
            this.msktxtboxCpfRegistraMedico.Mask = "999.999.999-99";
            this.msktxtboxCpfRegistraMedico.Name = "msktxtboxCpfRegistraMedico";
            this.msktxtboxCpfRegistraMedico.Size = new System.Drawing.Size(99, 22);
            this.msktxtboxCpfRegistraMedico.TabIndex = 2;
            // 
            // lblCPFMedico
            // 
            this.lblCPFMedico.AutoSize = true;
            this.lblCPFMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCPFMedico.Location = new System.Drawing.Point(146, 69);
            this.lblCPFMedico.Name = "lblCPFMedico";
            this.lblCPFMedico.Size = new System.Drawing.Size(40, 20);
            this.lblCPFMedico.TabIndex = 21;
            this.lblCPFMedico.Text = "CPF";
            // 
            // txtBoxNomeRegistraMedico
            // 
            this.txtBoxNomeRegistraMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeRegistraMedico.Location = new System.Drawing.Point(192, 32);
            this.txtBoxNomeRegistraMedico.Name = "txtBoxNomeRegistraMedico";
            this.txtBoxNomeRegistraMedico.Size = new System.Drawing.Size(306, 22);
            this.txtBoxNomeRegistraMedico.TabIndex = 1;
            // 
            // lblNomeRegistraMedico
            // 
            this.lblNomeRegistraMedico.AutoSize = true;
            this.lblNomeRegistraMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeRegistraMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomeRegistraMedico.Location = new System.Drawing.Point(49, 34);
            this.lblNomeRegistraMedico.Name = "lblNomeRegistraMedico";
            this.lblNomeRegistraMedico.Size = new System.Drawing.Size(120, 20);
            this.lblNomeRegistraMedico.TabIndex = 0;
            this.lblNomeRegistraMedico.Text = "Nome completo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTelefoneRegMedico);
            this.groupBox1.Controls.Add(this.msktxtboxTelefoneRegMedico);
            this.groupBox1.Controls.Add(this.lblEmailRegMedico);
            this.groupBox1.Controls.Add(this.txtboxEmailRegMedico);
            this.groupBox1.Location = new System.Drawing.Point(0, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 104);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contato";
            // 
            // lblTelefoneRegMedico
            // 
            this.lblTelefoneRegMedico.AutoSize = true;
            this.lblTelefoneRegMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelefoneRegMedico.Location = new System.Drawing.Point(6, 53);
            this.lblTelefoneRegMedico.Name = "lblTelefoneRegMedico";
            this.lblTelefoneRegMedico.Size = new System.Drawing.Size(71, 20);
            this.lblTelefoneRegMedico.TabIndex = 2;
            this.lblTelefoneRegMedico.Text = "Telefone";
            // 
            // msktxtboxTelefoneRegMedico
            // 
            this.msktxtboxTelefoneRegMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtboxTelefoneRegMedico.Location = new System.Drawing.Point(88, 56);
            this.msktxtboxTelefoneRegMedico.Mask = "(99) 00000-0000";
            this.msktxtboxTelefoneRegMedico.Name = "msktxtboxTelefoneRegMedico";
            this.msktxtboxTelefoneRegMedico.Size = new System.Drawing.Size(121, 22);
            this.msktxtboxTelefoneRegMedico.TabIndex = 7;
            // 
            // lblEmailRegMedico
            // 
            this.lblEmailRegMedico.AutoSize = true;
            this.lblEmailRegMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailRegMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmailRegMedico.Location = new System.Drawing.Point(26, 29);
            this.lblEmailRegMedico.Name = "lblEmailRegMedico";
            this.lblEmailRegMedico.Size = new System.Drawing.Size(53, 20);
            this.lblEmailRegMedico.TabIndex = 3;
            this.lblEmailRegMedico.Text = "E-mail";
            // 
            // txtboxEmailRegMedico
            // 
            this.txtboxEmailRegMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmailRegMedico.Location = new System.Drawing.Point(88, 27);
            this.txtboxEmailRegMedico.Name = "txtboxEmailRegMedico";
            this.txtboxEmailRegMedico.Size = new System.Drawing.Size(287, 22);
            this.txtboxEmailRegMedico.TabIndex = 8;
            // 
            // btnRegistrarMedico
            // 
            this.btnRegistrarMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMedico.Location = new System.Drawing.Point(227, 439);
            this.btnRegistrarMedico.Name = "btnRegistrarMedico";
            this.btnRegistrarMedico.Size = new System.Drawing.Size(130, 45);
            this.btnRegistrarMedico.TabIndex = 14;
            this.btnRegistrarMedico.Text = "Registrar";
            this.btnRegistrarMedico.UseVisualStyleBackColor = true;
            this.btnRegistrarMedico.Click += new System.EventHandler(this.btnRegistrarMedico_Click);
            // 
            // formRegistraMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(581, 495);
            this.Controls.Add(this.btnRegistrarMedico);
            this.Controls.Add(this.gbRegistraMedico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Name = "formRegistraMedico";
            this.Text = "Registrar Medico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbRegistraMedico.ResumeLayout(false);
            this.gbRegistraMedico.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistraMedico;
        private System.Windows.Forms.MaskedTextBox msktxtboxCpfRegistraMedico;
        private System.Windows.Forms.Label lblCPFMedico;
        private System.Windows.Forms.Label lblCidadeRegMedico;
        private System.Windows.Forms.MaskedTextBox msktxtboxTelefoneRegMedico;
        private System.Windows.Forms.TextBox txtboxEmailRegMedico;
        private System.Windows.Forms.TextBox txtboxEnderecoRegMedico;
        private System.Windows.Forms.TextBox txtBoxNomeRegistraMedico;
        private System.Windows.Forms.Label lblEmailRegMedico;
        private System.Windows.Forms.Label lblNomeRegistraMedico;
        private System.Windows.Forms.Label lblEstadoRegMedico;
        private System.Windows.Forms.Label lblEnderecoRegEndereco;
        private System.Windows.Forms.Label lblDataNascimentoMedico;
        private System.Windows.Forms.Label lblTelefoneRegMedico;
        private System.Windows.Forms.Label lblCrmRegMedico;
        private System.Windows.Forms.ComboBox cbCidadeRegMedico;
        private System.Windows.Forms.ComboBox cbEstadoRegMedico;
        private System.Windows.Forms.MaskedTextBox mskdTxtBoxDigitoCRM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskdtxtbxCRM;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnRegistrarMedico;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}