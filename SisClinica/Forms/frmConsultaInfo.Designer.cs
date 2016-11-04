namespace SisClinica.Forms
{
    partial class frmConsultaInfo
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
            this.lbMedicoResponsavel = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.dtgConsultas = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.cbTeste = new System.Windows.Forms.CheckBox();
            this.gpConsultas = new System.Windows.Forms.GroupBox();
            this.gpInfoGeral = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).BeginInit();
            this.gpConsultas.SuspendLayout();
            this.gpInfoGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMedicoResponsavel
            // 
            this.lbMedicoResponsavel.AutoSize = true;
            this.lbMedicoResponsavel.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbMedicoResponsavel.Location = new System.Drawing.Point(6, 38);
            this.lbMedicoResponsavel.Name = "lbMedicoResponsavel";
            this.lbMedicoResponsavel.Size = new System.Drawing.Size(132, 17);
            this.lbMedicoResponsavel.TabIndex = 3;
            this.lbMedicoResponsavel.Text = "Médico responsável:";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbCliente.Location = new System.Drawing.Point(6, 21);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(54, 17);
            this.lbCliente.TabIndex = 2;
            this.lbCliente.Text = "Cliente:";
            // 
            // dtgConsultas
            // 
            this.dtgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultas.Location = new System.Drawing.Point(12, 19);
            this.dtgConsultas.Name = "dtgConsultas";
            this.dtgConsultas.Size = new System.Drawing.Size(447, 152);
            this.dtgConsultas.TabIndex = 5;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAlterar.Location = new System.Drawing.Point(191, 273);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 37);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // cbTeste
            // 
            this.cbTeste.AutoSize = true;
            this.cbTeste.Location = new System.Drawing.Point(15, 86);
            this.cbTeste.Name = "cbTeste";
            this.cbTeste.Size = new System.Drawing.Size(101, 20);
            this.cbTeste.TabIndex = 21;
            this.cbTeste.Text = "Sessao ficticia";
            this.cbTeste.UseVisualStyleBackColor = true;
            this.cbTeste.CheckedChanged += new System.EventHandler(this.cbTeste_CheckedChanged);
            // 
            // gpConsultas
            // 
            this.gpConsultas.Controls.Add(this.cbTeste);
            this.gpConsultas.Controls.Add(this.dtgConsultas);
            this.gpConsultas.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.gpConsultas.Location = new System.Drawing.Point(0, 81);
            this.gpConsultas.Name = "gpConsultas";
            this.gpConsultas.Size = new System.Drawing.Size(472, 186);
            this.gpConsultas.TabIndex = 4;
            this.gpConsultas.TabStop = false;
            this.gpConsultas.Text = "Consultas";
            // 
            // gpInfoGeral
            // 
            this.gpInfoGeral.Controls.Add(this.lbCliente);
            this.gpInfoGeral.Controls.Add(this.lbMedicoResponsavel);
            this.gpInfoGeral.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.gpInfoGeral.Location = new System.Drawing.Point(6, 12);
            this.gpInfoGeral.Name = "gpInfoGeral";
            this.gpInfoGeral.Size = new System.Drawing.Size(453, 63);
            this.gpInfoGeral.TabIndex = 1;
            this.gpInfoGeral.TabStop = false;
            this.gpInfoGeral.Text = "Informação Geral";
            // 
            // frmConsultaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 322);
            this.Controls.Add(this.gpConsultas);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.gpInfoGeral);
            this.Name = "frmConsultaInfo";
            this.Text = "Informações da consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).EndInit();
            this.gpConsultas.ResumeLayout(false);
            this.gpConsultas.PerformLayout();
            this.gpInfoGeral.ResumeLayout(false);
            this.gpInfoGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbMedicoResponsavel;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.DataGridView dtgConsultas;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.CheckBox cbTeste;
        private System.Windows.Forms.GroupBox gpConsultas;
        private System.Windows.Forms.GroupBox gpInfoGeral;
    }
}