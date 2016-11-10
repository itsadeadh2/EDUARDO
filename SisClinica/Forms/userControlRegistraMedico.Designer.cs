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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CRM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Endereco:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(200, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Estado:";
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
            this.cbEstadoCRM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCRM.FormattingEnabled = true;
            this.cbEstadoCRM.Location = new System.Drawing.Point(280, 123);
            this.cbEstadoCRM.Name = "cbEstadoCRM";
            this.cbEstadoCRM.Size = new System.Drawing.Size(31, 25);
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
            this.cbCidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(267, 184);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(62, 25);
            this.cbCidade.TabIndex = 8;
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(132, 184);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(62, 25);
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
            this.btnSalvar.Image = global::SisClinica.Properties.Resources.btnSave;
            this.btnSalvar.Location = new System.Drawing.Point(512, 276);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(157, 130);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // userControlRegistraMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
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
