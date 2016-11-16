namespace SisClinica.Forms
{
    partial class userControlRegistraMedico
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNome = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbCrm = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtbnome = new System.Windows.Forms.TextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.mtbCRM = new System.Windows.Forms.MaskedTextBox();
            this.txtbDigitoCRM = new System.Windows.Forms.MaskedTextBox();
            this.cbEstadoCRM = new System.Windows.Forms.ComboBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtbEndereco = new System.Windows.Forms.TextBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.ttpErrors = new System.Windows.Forms.ToolTip(this.components);
            this.ptbCPFError = new System.Windows.Forms.PictureBox();
            this.ptbDtNascError = new System.Windows.Forms.PictureBox();
            this.ptbNomeError = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCPFError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDtNascError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNomeError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 98);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(120, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome completo:";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.Location = new System.Drawing.Point(89, 158);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(37, 17);
            this.lbCpf.TabIndex = 1;
            this.lbCpf.Text = "CPF:";
            // 
            // lbCrm
            // 
            this.lbCrm.AutoSize = true;
            this.lbCrm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrm.Location = new System.Drawing.Point(84, 127);
            this.lbCrm.Name = "lbCrm";
            this.lbCrm.Size = new System.Drawing.Size(42, 17);
            this.lbCrm.TabIndex = 2;
            this.lbCrm.Text = "CRM:";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascimento.Location = new System.Drawing.Point(358, 126);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(148, 17);
            this.lbDataNascimento.TabIndex = 3;
            this.lbDataNascimento.Text = "Data de Nascimento:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(75, 218);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(51, 17);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "E-mail:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(61, 247);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(65, 17);
            this.lbTelefone.TabIndex = 5;
            this.lbTelefone.Text = "Telefone:";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.Location = new System.Drawing.Point(53, 276);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(73, 17);
            this.lbEndereco.TabIndex = 6;
            this.lbEndereco.Text = "Endereco:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidade.Location = new System.Drawing.Point(267, 188);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(61, 17);
            this.lbCidade.TabIndex = 7;
            this.lbCidade.Text = "Cidade:";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(70, 188);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(56, 17);
            this.lbEstado.TabIndex = 8;
            this.lbEstado.Text = "Estado:";
            // 
            // txtbnome
            // 
            this.txtbnome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbnome.Location = new System.Drawing.Point(132, 95);
            this.txtbnome.Name = "txtbnome";
            this.txtbnome.Size = new System.Drawing.Size(264, 23);
            this.txtbnome.TabIndex = 0;
            this.txtbnome.Leave += new System.EventHandler(this.txtbnome_Leave);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCPF.Location = new System.Drawing.Point(132, 155);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(101, 23);
            this.mtbCPF.TabIndex = 6;
            this.mtbCPF.Leave += new System.EventHandler(this.mtbCPF_Leave);
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(512, 123);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(101, 23);
            this.dtpDataNasc.TabIndex = 5;
            this.dtpDataNasc.ValueChanged += new System.EventHandler(this.dtpDataNasc_ValueChanged);
            this.dtpDataNasc.Leave += new System.EventHandler(this.dtpDataNasc_Leave);
            // 
            // mtbCRM
            // 
            this.mtbCRM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCRM.Location = new System.Drawing.Point(132, 124);
            this.mtbCRM.Name = "mtbCRM";
            this.mtbCRM.Size = new System.Drawing.Size(100, 23);
            this.mtbCRM.TabIndex = 2;
            // 
            // txtbDigitoCRM
            // 
            this.txtbDigitoCRM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDigitoCRM.Location = new System.Drawing.Point(243, 124);
            this.txtbDigitoCRM.Name = "txtbDigitoCRM";
            this.txtbDigitoCRM.Size = new System.Drawing.Size(26, 23);
            this.txtbDigitoCRM.TabIndex = 3;
            // 
            // cbEstadoCRM
            // 
            this.cbEstadoCRM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCRM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCRM.FormattingEnabled = true;
            this.cbEstadoCRM.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbEstadoCRM.Location = new System.Drawing.Point(280, 123);
            this.cbEstadoCRM.Name = "cbEstadoCRM";
            this.cbEstadoCRM.Size = new System.Drawing.Size(49, 25);
            this.cbEstadoCRM.TabIndex = 4;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefone.Location = new System.Drawing.Point(132, 244);
            this.mtbTelefone.Mask = "(00) 0 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(110, 23);
            this.mtbTelefone.TabIndex = 10;
            // 
            // txtbEndereco
            // 
            this.txtbEndereco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEndereco.Location = new System.Drawing.Point(132, 273);
            this.txtbEndereco.Name = "txtbEndereco";
            this.txtbEndereco.Size = new System.Drawing.Size(264, 23);
            this.txtbEndereco.TabIndex = 12;
            // 
            // cbCidade
            // 
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(334, 184);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(62, 25);
            this.cbCidade.TabIndex = 8;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
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
            this.cbEstado.Location = new System.Drawing.Point(132, 184);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(129, 25);
            this.cbEstado.TabIndex = 7;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmail.Location = new System.Drawing.Point(132, 215);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(264, 23);
            this.txtbEmail.TabIndex = 9;
            // 
            // ptbCPFError
            // 
            this.ptbCPFError.Image = global::SisClinica.Properties.Resources.exclamation;
            this.ptbCPFError.Location = new System.Drawing.Point(239, 155);
            this.ptbCPFError.Name = "ptbCPFError";
            this.ptbCPFError.Size = new System.Drawing.Size(25, 25);
            this.ptbCPFError.TabIndex = 25;
            this.ptbCPFError.TabStop = false;
            this.ttpErrors.SetToolTip(this.ptbCPFError, "O sistema já possui um médico com este cpf!");
            this.ptbCPFError.Visible = false;
            // 
            // ptbDtNascError
            // 
            this.ptbDtNascError.Image = global::SisClinica.Properties.Resources.exclamation;
            this.ptbDtNascError.Location = new System.Drawing.Point(619, 123);
            this.ptbDtNascError.Name = "ptbDtNascError";
            this.ptbDtNascError.Size = new System.Drawing.Size(25, 25);
            this.ptbDtNascError.TabIndex = 23;
            this.ptbDtNascError.TabStop = false;
            this.ttpErrors.SetToolTip(this.ptbDtNascError, "O médico não pode ser menor de idade!");
            this.ptbDtNascError.Visible = false;
            // 
            // ptbNomeError
            // 
            this.ptbNomeError.Image = global::SisClinica.Properties.Resources.exclamation;
            this.ptbNomeError.Location = new System.Drawing.Point(402, 95);
            this.ptbNomeError.Name = "ptbNomeError";
            this.ptbNomeError.Size = new System.Drawing.Size(25, 25);
            this.ptbNomeError.TabIndex = 22;
            this.ptbNomeError.TabStop = false;
            this.ttpErrors.SetToolTip(this.ptbNomeError, "Nome inválido, o nome precisa ter no mínimo três caracteres!");
            this.ptbNomeError.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(512, 276);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 43);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // userControlRegistraMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ptbCPFError);
            this.Controls.Add(this.ptbDtNascError);
            this.Controls.Add(this.ptbNomeError);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.txtbEndereco);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.cbEstadoCRM);
            this.Controls.Add(this.txtbDigitoCRM);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.mtbCRM);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.txtbnome);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbDataNascimento);
            this.Controls.Add(this.lbCrm);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lblNome);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "userControlRegistraMedico";
            this.Size = new System.Drawing.Size(672, 409);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCPFError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDtNascError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNomeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbCrm;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox txtbnome;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.MaskedTextBox mtbCRM;
        private System.Windows.Forms.MaskedTextBox txtbDigitoCRM;
        private System.Windows.Forms.ComboBox cbEstadoCRM;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.TextBox txtbEndereco;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.PictureBox ptbNomeError;
        private System.Windows.Forms.ToolTip ttpErrors;
        private System.Windows.Forms.PictureBox ptbDtNascError;
        private System.Windows.Forms.PictureBox ptbCPFError;
    }
}
