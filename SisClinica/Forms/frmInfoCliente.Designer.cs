namespace SisClinica.Forms
{
    partial class frmInfoCliente
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
            this.gpInformacoesPessoais = new System.Windows.Forms.GroupBox();
            this.lbResponsavel = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.gpConsultas = new System.Windows.Forms.GroupBox();
            this.dtgConsultas = new System.Windows.Forms.DataGridView();
            this.gpTratamentos = new System.Windows.Forms.GroupBox();
            this.dtgTratamentos = new System.Windows.Forms.DataGridView();
            this.gpInformacoesPessoais.SuspendLayout();
            this.gpConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).BeginInit();
            this.gpTratamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTratamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpInformacoesPessoais
            // 
            this.gpInformacoesPessoais.BackColor = System.Drawing.Color.Transparent;
            this.gpInformacoesPessoais.Controls.Add(this.lbResponsavel);
            this.gpInformacoesPessoais.Controls.Add(this.lbCidade);
            this.gpInformacoesPessoais.Controls.Add(this.lbBairro);
            this.gpInformacoesPessoais.Controls.Add(this.lbNumero);
            this.gpInformacoesPessoais.Controls.Add(this.lbEndereco);
            this.gpInformacoesPessoais.Controls.Add(this.lbEmail);
            this.gpInformacoesPessoais.Controls.Add(this.lbTelefone);
            this.gpInformacoesPessoais.Controls.Add(this.lbDataNascimento);
            this.gpInformacoesPessoais.Controls.Add(this.lbNome);
            this.gpInformacoesPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpInformacoesPessoais.Location = new System.Drawing.Point(12, 21);
            this.gpInformacoesPessoais.Name = "gpInformacoesPessoais";
            this.gpInformacoesPessoais.Size = new System.Drawing.Size(860, 140);
            this.gpInformacoesPessoais.TabIndex = 1;
            this.gpInformacoesPessoais.TabStop = false;
            this.gpInformacoesPessoais.Text = "Informações Pessoais";
            // 
            // lbResponsavel
            // 
            this.lbResponsavel.AutoSize = true;
            this.lbResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResponsavel.Location = new System.Drawing.Point(439, 25);
            this.lbResponsavel.Name = "lbResponsavel";
            this.lbResponsavel.Size = new System.Drawing.Size(105, 20);
            this.lbResponsavel.TabIndex = 3;
            this.lbResponsavel.Text = "Responsável:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidade.Location = new System.Drawing.Point(623, 103);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(63, 20);
            this.lbCidade.TabIndex = 10;
            this.lbCidade.Text = "Cidade:";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.Location = new System.Drawing.Point(439, 103);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(55, 20);
            this.lbBairro.TabIndex = 9;
            this.lbBairro.Text = "Bairro:";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(304, 103);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(29, 20);
            this.lbNumero.TabIndex = 8;
            this.lbNumero.Text = "N°:";
            this.lbNumero.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.Location = new System.Drawing.Point(6, 103);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(82, 20);
            this.lbEndereco.TabIndex = 7;
            this.lbEndereco.Text = "Endereço:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(6, 83);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(57, 20);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "E-mail:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(6, 63);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(75, 20);
            this.lbTelefone.TabIndex = 5;
            this.lbTelefone.Text = "Telefone:";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascimento.Location = new System.Drawing.Point(6, 43);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(158, 20);
            this.lbDataNascimento.TabIndex = 4;
            this.lbDataNascimento.Text = "Data de Nascimento:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(6, 23);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(55, 20);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome:";
            // 
            // gpConsultas
            // 
            this.gpConsultas.BackColor = System.Drawing.Color.Transparent;
            this.gpConsultas.Controls.Add(this.dtgConsultas);
            this.gpConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpConsultas.Location = new System.Drawing.Point(12, 167);
            this.gpConsultas.Name = "gpConsultas";
            this.gpConsultas.Size = new System.Drawing.Size(860, 205);
            this.gpConsultas.TabIndex = 11;
            this.gpConsultas.TabStop = false;
            this.gpConsultas.Text = "Consultas";
            // 
            // dtgConsultas
            // 
            this.dtgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultas.Location = new System.Drawing.Point(10, 28);
            this.dtgConsultas.Name = "dtgConsultas";
            this.dtgConsultas.Size = new System.Drawing.Size(830, 161);
            this.dtgConsultas.TabIndex = 12;
            // 
            // gpTratamentos
            // 
            this.gpTratamentos.BackColor = System.Drawing.Color.Transparent;
            this.gpTratamentos.Controls.Add(this.dtgTratamentos);
            this.gpTratamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTratamentos.Location = new System.Drawing.Point(12, 378);
            this.gpTratamentos.Name = "gpTratamentos";
            this.gpTratamentos.Size = new System.Drawing.Size(860, 205);
            this.gpTratamentos.TabIndex = 13;
            this.gpTratamentos.TabStop = false;
            this.gpTratamentos.Text = "Tratamentos";
            // 
            // dtgTratamentos
            // 
            this.dtgTratamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTratamentos.Location = new System.Drawing.Point(10, 28);
            this.dtgTratamentos.Name = "dtgTratamentos";
            this.dtgTratamentos.Size = new System.Drawing.Size(830, 161);
            this.dtgTratamentos.TabIndex = 14;
            // 
            // frmInfoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 619);
            this.Controls.Add(this.gpTratamentos);
            this.Controls.Add(this.gpConsultas);
            this.Controls.Add(this.gpInformacoesPessoais);
            this.Name = "frmInfoCliente";
            this.Text = "Infomações do cliente";
            this.gpInformacoesPessoais.ResumeLayout(false);
            this.gpInformacoesPessoais.PerformLayout();
            this.gpConsultas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).EndInit();
            this.gpTratamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTratamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpInformacoesPessoais;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.GroupBox gpConsultas;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.DataGridView dtgConsultas;
        private System.Windows.Forms.GroupBox gpTratamentos;
        private System.Windows.Forms.DataGridView dtgTratamentos;
        private System.Windows.Forms.Label lbResponsavel;
    }
}