namespace SisClinica.Forms
{
    partial class frmTratamentoInfo
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
            this.lbTipoTratamento = new System.Windows.Forms.Label();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.lbMedicoResponsavel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpSessoes = new System.Windows.Forms.GroupBox();
            this.cbTeste = new System.Windows.Forms.CheckBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gpInformacaoGeral = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpSessoes.SuspendLayout();
            this.gpInformacaoGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTipoTratamento
            // 
            this.lbTipoTratamento.AutoSize = true;
            this.lbTipoTratamento.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbTipoTratamento.Location = new System.Drawing.Point(11, 20);
            this.lbTipoTratamento.Name = "lbTipoTratamento";
            this.lbTipoTratamento.Size = new System.Drawing.Size(146, 19);
            this.lbTipoTratamento.TabIndex = 2;
            this.lbTipoTratamento.Text = "Tipo de tratamento:";
            this.lbTipoTratamento.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbNomeCliente.Location = new System.Drawing.Point(27, 39);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(130, 19);
            this.lbNomeCliente.TabIndex = 3;
            this.lbNomeCliente.Text = "Nome do Cliente:";
            // 
            // lbMedicoResponsavel
            // 
            this.lbMedicoResponsavel.AutoSize = true;
            this.lbMedicoResponsavel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbMedicoResponsavel.Location = new System.Drawing.Point(6, 58);
            this.lbMedicoResponsavel.Name = "lbMedicoResponsavel";
            this.lbMedicoResponsavel.Size = new System.Drawing.Size(151, 19);
            this.lbMedicoResponsavel.TabIndex = 4;
            this.lbMedicoResponsavel.Text = "Médico responsável:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 152);
            this.dataGridView1.TabIndex = 6;
            // 
            // gpSessoes
            // 
            this.gpSessoes.Controls.Add(this.cbTeste);
            this.gpSessoes.Controls.Add(this.btnAlterar);
            this.gpSessoes.Controls.Add(this.dataGridView1);
            this.gpSessoes.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gpSessoes.Location = new System.Drawing.Point(12, 108);
            this.gpSessoes.Name = "gpSessoes";
            this.gpSessoes.Size = new System.Drawing.Size(447, 216);
            this.gpSessoes.TabIndex = 5;
            this.gpSessoes.TabStop = false;
            this.gpSessoes.Text = "Sessões";
            // 
            // cbTeste
            // 
            this.cbTeste.AutoSize = true;
            this.cbTeste.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbTeste.Location = new System.Drawing.Point(11, 80);
            this.cbTeste.Name = "cbTeste";
            this.cbTeste.Size = new System.Drawing.Size(123, 23);
            this.cbTeste.TabIndex = 5;
            this.cbTeste.Text = "Sessao ficticia";
            this.cbTeste.UseVisualStyleBackColor = true;
            this.cbTeste.CheckedChanged += new System.EventHandler(this.cbTeste_CheckedChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAlterar.Location = new System.Drawing.Point(181, 177);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 27);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gpInformacaoGeral
            // 
            this.gpInformacaoGeral.Controls.Add(this.lbTipoTratamento);
            this.gpInformacaoGeral.Controls.Add(this.lbMedicoResponsavel);
            this.gpInformacaoGeral.Controls.Add(this.lbNomeCliente);
            this.gpInformacaoGeral.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.gpInformacaoGeral.Location = new System.Drawing.Point(12, 12);
            this.gpInformacaoGeral.Name = "gpInformacaoGeral";
            this.gpInformacaoGeral.Size = new System.Drawing.Size(447, 87);
            this.gpInformacaoGeral.TabIndex = 1;
            this.gpInformacaoGeral.TabStop = false;
            this.gpInformacaoGeral.Text = "Informações geral";
            // 
            // frmTratamentoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 331);
            this.Controls.Add(this.gpSessoes);
            this.Controls.Add(this.gpInformacaoGeral);
            this.Name = "frmTratamentoInfo";
            this.Text = "Informações do tratamento";
            this.Load += new System.EventHandler(this.frmTratamentoInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpSessoes.ResumeLayout(false);
            this.gpSessoes.PerformLayout();
            this.gpInformacaoGeral.ResumeLayout(false);
            this.gpInformacaoGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTipoTratamento;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.Label lbMedicoResponsavel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpSessoes;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.CheckBox cbTeste;
        private System.Windows.Forms.GroupBox gpInformacaoGeral;
    }
}