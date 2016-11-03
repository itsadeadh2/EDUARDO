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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxEndereco = new System.Windows.Forms.TextBox();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.txtBoxBairro = new System.Windows.Forms.TextBox();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.mskTxtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskdCPF = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.rtbAdicionalInfo = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnSelecionarResponsavel = new System.Windows.Forms.Button();
            this.cbCidadeRegCliente = new System.Windows.Forms.ComboBox();
            this.cbEstadoRegCliente = new System.Windows.Forms.ComboBox();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "N°";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estado";
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
            this.btnRegistrarCliente.TabIndex = 18;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(104, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cidade";
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
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbCliente.Controls.Add(this.rtbAdicionalInfo);
            this.gbCliente.Controls.Add(this.label9);
            this.gbCliente.Controls.Add(this.dtpDataDeNascimento);
            this.gbCliente.Controls.Add(this.btnSelecionarResponsavel);
            this.gbCliente.Controls.Add(this.cbCidadeRegCliente);
            this.gbCliente.Controls.Add(this.cbEstadoRegCliente);
            this.gbCliente.Controls.Add(this.mskdCPF);
            this.gbCliente.Controls.Add(this.label11);
            this.gbCliente.Controls.Add(this.label10);
            this.gbCliente.Controls.Add(this.mskTxtBoxTelefone);
            this.gbCliente.Controls.Add(this.txtBoxBairro);
            this.gbCliente.Controls.Add(this.txtBoxNumero);
            this.gbCliente.Controls.Add(this.txtBoxEndereco);
            this.gbCliente.Controls.Add(this.txtBoxEmail);
            this.gbCliente.Controls.Add(this.txtBoxNomeCompleto);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Controls.Add(this.label8);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.label7);
            this.gbCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(12, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(1014, 503);
            this.gbCliente.TabIndex = 46;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // rtbAdicionalInfo
            // 
            this.rtbAdicionalInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAdicionalInfo.Location = new System.Drawing.Point(611, 75);
            this.rtbAdicionalInfo.Name = "rtbAdicionalInfo";
            this.rtbAdicionalInfo.Size = new System.Drawing.Size(397, 422);
            this.rtbAdicionalInfo.TabIndex = 25;
            this.rtbAdicionalInfo.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(607, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Informações Adicionais";
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(186, 135);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(200, 26);
            this.dtpDataDeNascimento.TabIndex = 23;
            this.dtpDataDeNascimento.ValueChanged += new System.EventHandler(this.dtpDataDeNascimento_ValueChanged);
            // 
            // btnSelecionarResponsavel
            // 
            this.btnSelecionarResponsavel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarResponsavel.Location = new System.Drawing.Point(392, 138);
            this.btnSelecionarResponsavel.Name = "btnSelecionarResponsavel";
            this.btnSelecionarResponsavel.Size = new System.Drawing.Size(169, 23);
            this.btnSelecionarResponsavel.TabIndex = 22;
            this.btnSelecionarResponsavel.Text = "Selecionar Responsavel";
            this.btnSelecionarResponsavel.UseVisualStyleBackColor = true;
            this.btnSelecionarResponsavel.Visible = false;
            this.btnSelecionarResponsavel.Click += new System.EventHandler(this.btnSelecionarResponsavel_Click);
            // 
            // cbCidadeRegCliente
            // 
            this.cbCidadeRegCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidadeRegCliente.FormattingEnabled = true;
            this.cbCidadeRegCliente.Location = new System.Drawing.Point(186, 432);
            this.cbCidadeRegCliente.Name = "cbCidadeRegCliente";
            this.cbCidadeRegCliente.Size = new System.Drawing.Size(121, 28);
            this.cbCidadeRegCliente.TabIndex = 10;
            // 
            // cbEstadoRegCliente
            // 
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxNomeCompleto;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxEndereco;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.TextBox txtBoxBairro;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxTelefone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskdCPF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.ComboBox cbCidadeRegCliente;
        private System.Windows.Forms.ComboBox cbEstadoRegCliente;
        private System.Windows.Forms.Button btnSelecionarResponsavel;
        private System.Windows.Forms.DateTimePicker dtpDataDeNascimento;
        private System.Windows.Forms.RichTextBox rtbAdicionalInfo;
        private System.Windows.Forms.Label label9;
    }
}