namespace SisClinica.Forms
{
    partial class frmBuscarTratCon
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
            this.gpBuscarSessoes = new System.Windows.Forms.GroupBox();
            this.gpResultadosPesquisa = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dtgResultadoPesquisa = new System.Windows.Forms.DataGridView();
            this.gbInfoPesquisa = new System.Windows.Forms.GroupBox();
            this.lbData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.mskdTxtBxCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtbxNomePesquisa = new System.Windows.Forms.TextBox();
            this.lblCRMCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbBusca = new System.Windows.Forms.GroupBox();
            this.cbData = new System.Windows.Forms.CheckBox();
            this.cbTratamentos = new System.Windows.Forms.CheckBox();
            this.cbConsultas = new System.Windows.Forms.CheckBox();
            this.cbMedico = new System.Windows.Forms.CheckBox();
            this.cbCliente = new System.Windows.Forms.CheckBox();
            this.gpBuscarSessoes.SuspendLayout();
            this.gpResultadosPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultadoPesquisa)).BeginInit();
            this.gbInfoPesquisa.SuspendLayout();
            this.gbBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBuscarSessoes
            // 
            this.gpBuscarSessoes.Controls.Add(this.gpResultadosPesquisa);
            this.gpBuscarSessoes.Controls.Add(this.gbInfoPesquisa);
            this.gpBuscarSessoes.Controls.Add(this.gbBusca);
            this.gpBuscarSessoes.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBuscarSessoes.Location = new System.Drawing.Point(6, 4);
            this.gpBuscarSessoes.Name = "gpBuscarSessoes";
            this.gpBuscarSessoes.Size = new System.Drawing.Size(827, 310);
            this.gpBuscarSessoes.TabIndex = 2;
            this.gpBuscarSessoes.TabStop = false;
            this.gpBuscarSessoes.Text = "Buscar Sessões";
            // 
            // gpResultadosPesquisa
            // 
            this.gpResultadosPesquisa.Controls.Add(this.lblInfo);
            this.gpResultadosPesquisa.Controls.Add(this.dtgResultadoPesquisa);
            this.gpResultadosPesquisa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpResultadosPesquisa.Location = new System.Drawing.Point(418, 40);
            this.gpResultadosPesquisa.Name = "gpResultadosPesquisa";
            this.gpResultadosPesquisa.Size = new System.Drawing.Size(403, 264);
            this.gpResultadosPesquisa.TabIndex = 24;
            this.gpResultadosPesquisa.TabStop = false;
            this.gpResultadosPesquisa.Text = "Resultados da pesquisa";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(6, 49);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(237, 16);
            this.lblInfo.TabIndex = 25;
            this.lblInfo.Text = "*Duplo clique na célula para ver detalhes";
            // 
            // dtgResultadoPesquisa
            // 
            this.dtgResultadoPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultadoPesquisa.Location = new System.Drawing.Point(6, 78);
            this.dtgResultadoPesquisa.Name = "dtgResultadoPesquisa";
            this.dtgResultadoPesquisa.Size = new System.Drawing.Size(391, 180);
            this.dtgResultadoPesquisa.TabIndex = 26;
            // 
            // gbInfoPesquisa
            // 
            this.gbInfoPesquisa.Controls.Add(this.lbData);
            this.gbInfoPesquisa.Controls.Add(this.dtpData);
            this.gbInfoPesquisa.Controls.Add(this.mskdTxtBxCPF);
            this.gbInfoPesquisa.Controls.Add(this.btnPesquisar);
            this.gbInfoPesquisa.Controls.Add(this.txtbxNomePesquisa);
            this.gbInfoPesquisa.Controls.Add(this.lblCRMCPF);
            this.gbInfoPesquisa.Controls.Add(this.lblNome);
            this.gbInfoPesquisa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoPesquisa.Location = new System.Drawing.Point(6, 141);
            this.gbInfoPesquisa.Name = "gbInfoPesquisa";
            this.gbInfoPesquisa.Size = new System.Drawing.Size(406, 163);
            this.gbInfoPesquisa.TabIndex = 20;
            this.gbInfoPesquisa.TabStop = false;
            this.gbInfoPesquisa.Text = "Informe os dados";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Enabled = false;
            this.lbData.Location = new System.Drawing.Point(6, 96);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(45, 17);
            this.lbData.TabIndex = 23;
            this.lbData.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Location = new System.Drawing.Point(64, 91);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 23);
            this.dtpData.TabIndex = 9;
            // 
            // mskdTxtBxCPF
            // 
            this.mskdTxtBxCPF.Enabled = false;
            this.mskdTxtBxCPF.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.mskdTxtBxCPF.Location = new System.Drawing.Point(64, 60);
            this.mskdTxtBxCPF.Mask = "000.000.000-00";
            this.mskdTxtBxCPF.Name = "mskdTxtBxCPF";
            this.mskdTxtBxCPF.Size = new System.Drawing.Size(116, 23);
            this.mskdTxtBxCPF.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Enabled = false;
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(96, 128);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(214, 29);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtbxNomePesquisa
            // 
            this.txtbxNomePesquisa.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNomePesquisa.Location = new System.Drawing.Point(64, 29);
            this.txtbxNomePesquisa.Name = "txtbxNomePesquisa";
            this.txtbxNomePesquisa.Size = new System.Drawing.Size(336, 23);
            this.txtbxNomePesquisa.TabIndex = 7;
            // 
            // lblCRMCPF
            // 
            this.lblCRMCPF.AutoSize = true;
            this.lblCRMCPF.Enabled = false;
            this.lblCRMCPF.Location = new System.Drawing.Point(6, 64);
            this.lblCRMCPF.Name = "lblCRMCPF";
            this.lblCRMCPF.Size = new System.Drawing.Size(37, 17);
            this.lblCRMCPF.TabIndex = 22;
            this.lblCRMCPF.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 17);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome:";
            // 
            // gbBusca
            // 
            this.gbBusca.Controls.Add(this.cbData);
            this.gbBusca.Controls.Add(this.cbTratamentos);
            this.gbBusca.Controls.Add(this.cbConsultas);
            this.gbBusca.Controls.Add(this.cbMedico);
            this.gbBusca.Controls.Add(this.cbCliente);
            this.gbBusca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusca.Location = new System.Drawing.Point(6, 40);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(406, 95);
            this.gbBusca.TabIndex = 3;
            this.gbBusca.TabStop = false;
            this.gbBusca.Text = "Filtros:";
            // 
            // cbData
            // 
            this.cbData.AutoSize = true;
            this.cbData.Location = new System.Drawing.Point(282, 22);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(60, 21);
            this.cbData.TabIndex = 6;
            this.cbData.Text = "Data";
            this.cbData.UseVisualStyleBackColor = true;
            // 
            // cbTratamentos
            // 
            this.cbTratamentos.AutoSize = true;
            this.cbTratamentos.Location = new System.Drawing.Point(144, 49);
            this.cbTratamentos.Name = "cbTratamentos";
            this.cbTratamentos.Size = new System.Drawing.Size(107, 21);
            this.cbTratamentos.TabIndex = 5;
            this.cbTratamentos.Text = "Tratamentos";
            this.cbTratamentos.UseVisualStyleBackColor = true;
            // 
            // cbConsultas
            // 
            this.cbConsultas.AutoSize = true;
            this.cbConsultas.Location = new System.Drawing.Point(144, 22);
            this.cbConsultas.Name = "cbConsultas";
            this.cbConsultas.Size = new System.Drawing.Size(90, 21);
            this.cbConsultas.TabIndex = 4;
            this.cbConsultas.Text = "Consultas";
            this.cbConsultas.UseVisualStyleBackColor = true;
            // 
            // cbMedico
            // 
            this.cbMedico.AutoSize = true;
            this.cbMedico.Location = new System.Drawing.Point(13, 49);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(80, 21);
            this.cbMedico.TabIndex = 3;
            this.cbMedico.Text = "Médicos";
            this.cbMedico.UseVisualStyleBackColor = true;
            // 
            // cbCliente
            // 
            this.cbCliente.AutoSize = true;
            this.cbCliente.Location = new System.Drawing.Point(13, 22);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(78, 21);
            this.cbCliente.TabIndex = 2;
            this.cbCliente.Text = "Clientes";
            this.cbCliente.UseVisualStyleBackColor = true;
            // 
            // frmBuscarTratCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 326);
            this.Controls.Add(this.gpBuscarSessoes);
            this.Name = "frmBuscarTratCon";
            this.Text = "Buscar o tratamento da consulta";
            this.gpBuscarSessoes.ResumeLayout(false);
            this.gpResultadosPesquisa.ResumeLayout(false);
            this.gpResultadosPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultadoPesquisa)).EndInit();
            this.gbInfoPesquisa.ResumeLayout(false);
            this.gbInfoPesquisa.PerformLayout();
            this.gbBusca.ResumeLayout(false);
            this.gbBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBuscarSessoes;
        private System.Windows.Forms.GroupBox gpResultadosPesquisa;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dtgResultadoPesquisa;
        private System.Windows.Forms.GroupBox gbInfoPesquisa;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.MaskedTextBox mskdTxtBxCPF;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtbxNomePesquisa;
        private System.Windows.Forms.Label lblCRMCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbBusca;
        private System.Windows.Forms.CheckBox cbData;
        private System.Windows.Forms.CheckBox cbTratamentos;
        private System.Windows.Forms.CheckBox cbConsultas;
        private System.Windows.Forms.CheckBox cbMedico;
        private System.Windows.Forms.CheckBox cbCliente;
    }
}