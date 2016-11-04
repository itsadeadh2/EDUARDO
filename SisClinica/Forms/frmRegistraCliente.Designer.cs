namespace SisClinica.Forms
{
    partial class frmRegistraCliente
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
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxEndereco = new System.Windows.Forms.TextBox();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.txtBoxBairro = new System.Windows.Forms.TextBox();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.mskTxtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.mskdCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.rtbAdicionalInfo = new System.Windows.Forms.RichTextBox();
            this.lbInfoAdicional = new System.Windows.Forms.Label();
            this.dtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnSelecionarResponsavel = new System.Windows.Forms.Button();
            this.cbCidadeRegCliente = new System.Windows.Forms.ComboBox();
            this.cbEstadoRegCliente = new System.Windows.Forms.ComboBox();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCliente.Location = new System.Drawing.Point(43, 54);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(137, 21);
            this.lbNomeCliente.TabIndex = 20;
            this.lbNomeCliente.Text = "Nome completo";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascimento.Location = new System.Drawing.Point(11, 140);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(172, 21);
            this.lbDataNascimento.TabIndex = 22;
            this.lbDataNascimento.Text = "Data de nascimento";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(92, 183);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(76, 21);
            this.lbTelefone.TabIndex = 23;
            this.lbTelefone.Text = "Telefone";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(110, 226);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 21);
            this.lbEmail.TabIndex = 24;
            this.lbEmail.Text = "E-mail";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.Location = new System.Drawing.Point(85, 269);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(85, 21);
            this.lbEndereco.TabIndex = 25;
            this.lbEndereco.Text = "Endereço";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(138, 312);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(28, 21);
            this.lbNumero.TabIndex = 26;
            this.lbNumero.Text = "N°";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.Location = new System.Drawing.Point(112, 355);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(53, 21);
            this.lbBairro.TabIndex = 27;
            this.lbBairro.Text = "Bairro";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(103, 398);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(64, 21);
            this.lbEstado.TabIndex = 28;
            this.lbEstado.Text = "Estado";
            // 
            // txtBoxNomeCompleto
            // 
            this.txtBoxNomeCompleto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeCompleto.Location = new System.Drawing.Point(186, 52);
            this.txtBoxNomeCompleto.Name = "txtBoxNomeCompleto";
            this.txtBoxNomeCompleto.Size = new System.Drawing.Size(375, 26);
            this.txtBoxNomeCompleto.TabIndex = 1;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(186, 220);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(375, 26);
            this.txtBoxEmail.TabIndex = 5;
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEndereco.Location = new System.Drawing.Point(186, 262);
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.Size = new System.Drawing.Size(375, 26);
            this.txtBoxEndereco.TabIndex = 6;
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumero.Location = new System.Drawing.Point(186, 304);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(80, 26);
            this.txtBoxNumero.TabIndex = 7;
            // 
            // txtBoxBairro
            // 
            this.txtBoxBairro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBairro.Location = new System.Drawing.Point(186, 346);
            this.txtBoxBairro.Name = "txtBoxBairro";
            this.txtBoxBairro.Size = new System.Drawing.Size(176, 26);
            this.txtBoxBairro.TabIndex = 8;
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCliente.Location = new System.Drawing.Point(454, 521);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(130, 45);
            this.btnRegistrarCliente.TabIndex = 11;
            this.btnRegistrarCliente.Text = "Registrar";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
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
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidade.Location = new System.Drawing.Point(104, 441);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(69, 21);
            this.lbCidade.TabIndex = 29;
            this.lbCidade.Text = "Cidade";
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
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.Location = new System.Drawing.Point(123, 97);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(40, 21);
            this.lbCpf.TabIndex = 21;
            this.lbCpf.Text = "CPF";
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbCliente.Controls.Add(this.rtbAdicionalInfo);
            this.gbCliente.Controls.Add(this.lbInfoAdicional);
            this.gbCliente.Controls.Add(this.dtpDataDeNascimento);
            this.gbCliente.Controls.Add(this.btnSelecionarResponsavel);
            this.gbCliente.Controls.Add(this.cbCidadeRegCliente);
            this.gbCliente.Controls.Add(this.cbEstadoRegCliente);
            this.gbCliente.Controls.Add(this.mskdCPF);
            this.gbCliente.Controls.Add(this.lbCpf);
            this.gbCliente.Controls.Add(this.lbCidade);
            this.gbCliente.Controls.Add(this.mskTxtBoxTelefone);
            this.gbCliente.Controls.Add(this.txtBoxBairro);
            this.gbCliente.Controls.Add(this.txtBoxNumero);
            this.gbCliente.Controls.Add(this.txtBoxEndereco);
            this.gbCliente.Controls.Add(this.txtBoxEmail);
            this.gbCliente.Controls.Add(this.txtBoxNomeCompleto);
            this.gbCliente.Controls.Add(this.lbEmail);
            this.gbCliente.Controls.Add(this.lbNomeCliente);
            this.gbCliente.Controls.Add(this.lbNumero);
            this.gbCliente.Controls.Add(this.lbEstado);
            this.gbCliente.Controls.Add(this.lbEndereco);
            this.gbCliente.Controls.Add(this.lbDataNascimento);
            this.gbCliente.Controls.Add(this.lbTelefone);
            this.gbCliente.Controls.Add(this.lbBairro);
            this.gbCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(12, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(1014, 503);
            this.gbCliente.TabIndex = 31;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // rtbAdicionalInfo
            // 
            this.rtbAdicionalInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAdicionalInfo.Location = new System.Drawing.Point(611, 75);
            this.rtbAdicionalInfo.Name = "rtbAdicionalInfo";
            this.rtbAdicionalInfo.Size = new System.Drawing.Size(397, 422);
            this.rtbAdicionalInfo.TabIndex = 12;
            this.rtbAdicionalInfo.Text = "";
            // 
            // lbInfoAdicional
            // 
            this.lbInfoAdicional.AutoSize = true;
            this.lbInfoAdicional.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoAdicional.Location = new System.Drawing.Point(607, 52);
            this.lbInfoAdicional.Name = "lbInfoAdicional";
            this.lbInfoAdicional.Size = new System.Drawing.Size(181, 20);
            this.lbInfoAdicional.TabIndex = 30;
            this.lbInfoAdicional.Text = "Informações Adicionais";
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(186, 135);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(200, 26);
            this.dtpDataDeNascimento.TabIndex = 3;
            this.dtpDataDeNascimento.ValueChanged += new System.EventHandler(this.dtpDataDeNascimento_ValueChanged);
            // 
            // btnSelecionarResponsavel
            // 
            this.btnSelecionarResponsavel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarResponsavel.Location = new System.Drawing.Point(392, 138);
            this.btnSelecionarResponsavel.Name = "btnSelecionarResponsavel";
            this.btnSelecionarResponsavel.Size = new System.Drawing.Size(169, 23);
            this.btnSelecionarResponsavel.TabIndex = 3;
            this.btnSelecionarResponsavel.Text = "Selecionar Responsavel";
            this.btnSelecionarResponsavel.UseVisualStyleBackColor = true;
            this.btnSelecionarResponsavel.Visible = false;
            this.btnSelecionarResponsavel.Click += new System.EventHandler(this.btnSelecionarResponsavel_Click);
            // 
            // cbCidadeRegCliente
            // 
            this.cbCidadeRegCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidadeRegCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidadeRegCliente.FormattingEnabled = true;
            this.cbCidadeRegCliente.Location = new System.Drawing.Point(186, 432);
            this.cbCidadeRegCliente.Name = "cbCidadeRegCliente";
            this.cbCidadeRegCliente.Size = new System.Drawing.Size(121, 28);
            this.cbCidadeRegCliente.TabIndex = 10;
            // 
            // cbEstadoRegCliente
            // 
            this.cbEstadoRegCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoRegCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoRegCliente.FormattingEnabled = true;
            this.cbEstadoRegCliente.Items.AddRange(new object[] {
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
            this.cbEstadoRegCliente.Location = new System.Drawing.Point(186, 388);
            this.cbEstadoRegCliente.Name = "cbEstadoRegCliente";
            this.cbEstadoRegCliente.Size = new System.Drawing.Size(121, 28);
            this.cbEstadoRegCliente.TabIndex = 9;
            // 
            // frmRegistraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 573);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Name = "frmRegistraCliente";
            this.Text = "Registro Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegistraCliente_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox txtBoxNomeCompleto;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxEndereco;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.TextBox txtBoxBairro;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxTelefone;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.MaskedTextBox mskdCPF;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.ComboBox cbCidadeRegCliente;
        private System.Windows.Forms.ComboBox cbEstadoRegCliente;
        private System.Windows.Forms.Button btnSelecionarResponsavel;
        private System.Windows.Forms.DateTimePicker dtpDataDeNascimento;
        private System.Windows.Forms.RichTextBox rtbAdicionalInfo;
        private System.Windows.Forms.Label lbInfoAdicional;
    }
}