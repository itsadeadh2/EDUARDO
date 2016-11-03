﻿namespace SisClinica.Forms
{
    partial class frmBuscaSessoes
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dtgSessoes = new System.Windows.Forms.DataGridView();
            this.gbInfoPesquisa = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtbxNomePesquisa = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbBusca = new System.Windows.Forms.GroupBox();
            this.cbData = new System.Windows.Forms.CheckBox();
            this.cbTratamentos = new System.Windows.Forms.CheckBox();
            this.cbConsultas = new System.Windows.Forms.CheckBox();
            this.cbMedico = new System.Windows.Forms.CheckBox();
            this.cbCliente = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSessoes)).BeginInit();
            this.gbInfoPesquisa.SuspendLayout();
            this.gbBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.gbInfoPesquisa);
            this.groupBox1.Controls.Add(this.gbBusca);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 289);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Sessões";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInfo);
            this.groupBox2.Controls.Add(this.dtgSessoes);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(418, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 206);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados da pesquisa";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(6, 21);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(237, 16);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "*Duplo clique na célula para ver detalhes";
            // 
            // dtgSessoes
            // 
            this.dtgSessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSessoes.Location = new System.Drawing.Point(6, 38);
            this.dtgSessoes.Name = "dtgSessoes";
            this.dtgSessoes.Size = new System.Drawing.Size(616, 163);
            this.dtgSessoes.TabIndex = 0;
            // 
            // gbInfoPesquisa
            // 
            this.gbInfoPesquisa.Controls.Add(this.label1);
            this.gbInfoPesquisa.Controls.Add(this.dtpData);
            this.gbInfoPesquisa.Controls.Add(this.btnPesquisar);
            this.gbInfoPesquisa.Controls.Add(this.txtbxNomePesquisa);
            this.gbInfoPesquisa.Controls.Add(this.lblNome);
            this.gbInfoPesquisa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoPesquisa.Location = new System.Drawing.Point(6, 141);
            this.gbInfoPesquisa.Name = "gbInfoPesquisa";
            this.gbInfoPesquisa.Size = new System.Drawing.Size(406, 137);
            this.gbInfoPesquisa.TabIndex = 4;
            this.gbInfoPesquisa.TabStop = false;
            this.gbInfoPesquisa.Text = "Informe os dados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Location = new System.Drawing.Point(64, 58);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 23);
            this.dtpData.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Enabled = false;
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(95, 96);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(214, 29);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtbxNomePesquisa
            // 
            this.txtbxNomePesquisa.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNomePesquisa.Location = new System.Drawing.Point(64, 29);
            this.txtbxNomePesquisa.Name = "txtbxNomePesquisa";
            this.txtbxNomePesquisa.Size = new System.Drawing.Size(336, 23);
            this.txtbxNomePesquisa.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 17);
            this.lblNome.TabIndex = 0;
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
            this.cbData.CheckedChanged += new System.EventHandler(this.cbData_CheckedChanged);
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
            this.cbTratamentos.CheckedChanged += new System.EventHandler(this.cbTratamentos_CheckedChanged);
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
            this.cbConsultas.CheckedChanged += new System.EventHandler(this.cbConsultas_CheckedChanged);
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
            this.cbMedico.CheckedChanged += new System.EventHandler(this.cbMedico_CheckedChanged);
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
            this.cbCliente.CheckedChanged += new System.EventHandler(this.cbCliente_CheckedChanged);
            // 
            // frmBuscaSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 503);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBuscaSessoes";
            this.Text = "frmBuscarTratCon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSessoes)).EndInit();
            this.gbInfoPesquisa.ResumeLayout(false);
            this.gbInfoPesquisa.PerformLayout();
            this.gbBusca.ResumeLayout(false);
            this.gbBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dtgSessoes;
        private System.Windows.Forms.GroupBox gbInfoPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtbxNomePesquisa;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbBusca;
        private System.Windows.Forms.CheckBox cbData;
        private System.Windows.Forms.CheckBox cbTratamentos;
        private System.Windows.Forms.CheckBox cbConsultas;
        private System.Windows.Forms.CheckBox cbMedico;
        private System.Windows.Forms.CheckBox cbCliente;
    }
}