namespace SisClinica.Forms
{
    partial class frmAgendarTratamentoComConsulta
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
            this.gpCliente = new System.Windows.Forms.GroupBox();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.gpInformacoesCliente = new System.Windows.Forms.GroupBox();
            this.lbDiagnosticoConsulta = new System.Windows.Forms.Label();
            this.lbDataConsulta = new System.Windows.Forms.Label();
            this.lbNomeResponsavel = new System.Windows.Forms.Label();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.gpTratamento = new System.Windows.Forms.GroupBox();
            this.cbMedicosDisponiveis = new System.Windows.Forms.ComboBox();
            this.lbMedicosDisponiveis = new System.Windows.Forms.Label();
            this.lbHorariosDisponiveis = new System.Windows.Forms.Label();
            this.dtgTratamento = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbMedicoResponsavelVisu = new System.Windows.Forms.Label();
            this.lbDataInicioTratamentoVisu = new System.Windows.Forms.Label();
            this.lbResponsavelVisu = new System.Windows.Forms.Label();
            this.lbNomeVisu = new System.Windows.Forms.Label();
            this.btnAgendarTratamento = new System.Windows.Forms.Button();
            this.gpCliente.SuspendLayout();
            this.gpInformacoesCliente.SuspendLayout();
            this.gpTratamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTratamento)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpCliente
            // 
            this.gpCliente.Controls.Add(this.btnSelecionarCliente);
            this.gpCliente.Location = new System.Drawing.Point(12, 12);
            this.gpCliente.Name = "gpCliente";
            this.gpCliente.Size = new System.Drawing.Size(527, 90);
            this.gpCliente.TabIndex = 1;
            this.gpCliente.TabStop = false;
            this.gpCliente.Text = "Cliente";
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarCliente.Location = new System.Drawing.Point(165, 19);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(197, 47);
            this.btnSelecionarCliente.TabIndex = 2;
            this.btnSelecionarCliente.Text = "Selecionar Cliente";
            this.btnSelecionarCliente.UseVisualStyleBackColor = true;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpInformacoesCliente
            // 
            this.gpInformacoesCliente.Controls.Add(this.lbDiagnosticoConsulta);
            this.gpInformacoesCliente.Controls.Add(this.lbDataConsulta);
            this.gpInformacoesCliente.Controls.Add(this.lbNomeResponsavel);
            this.gpInformacoesCliente.Controls.Add(this.lbNomeCliente);
            this.gpInformacoesCliente.Location = new System.Drawing.Point(12, 108);
            this.gpInformacoesCliente.Name = "gpInformacoesCliente";
            this.gpInformacoesCliente.Size = new System.Drawing.Size(527, 111);
            this.gpInformacoesCliente.TabIndex = 3;
            this.gpInformacoesCliente.TabStop = false;
            this.gpInformacoesCliente.Text = "Informações do Cliente";
            // 
            // lbDiagnosticoConsulta
            // 
            this.lbDiagnosticoConsulta.AutoSize = true;
            this.lbDiagnosticoConsulta.Location = new System.Drawing.Point(6, 79);
            this.lbDiagnosticoConsulta.Name = "lbDiagnosticoConsulta";
            this.lbDiagnosticoConsulta.Size = new System.Drawing.Size(124, 13);
            this.lbDiagnosticoConsulta.TabIndex = 7;
            this.lbDiagnosticoConsulta.Text = "Diagnóstico da consulta:";
            // 
            // lbDataConsulta
            // 
            this.lbDataConsulta.AutoSize = true;
            this.lbDataConsulta.Location = new System.Drawing.Point(6, 59);
            this.lbDataConsulta.Name = "lbDataConsulta";
            this.lbDataConsulta.Size = new System.Drawing.Size(91, 13);
            this.lbDataConsulta.TabIndex = 6;
            this.lbDataConsulta.Text = "Data da consulta:";
            // 
            // lbNomeResponsavel
            // 
            this.lbNomeResponsavel.AutoSize = true;
            this.lbNomeResponsavel.Location = new System.Drawing.Point(6, 39);
            this.lbNomeResponsavel.Name = "lbNomeResponsavel";
            this.lbNomeResponsavel.Size = new System.Drawing.Size(72, 13);
            this.lbNomeResponsavel.TabIndex = 5;
            this.lbNomeResponsavel.Text = "Responsável:";
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(6, 19);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(38, 13);
            this.lbNomeCliente.TabIndex = 4;
            this.lbNomeCliente.Text = "Nome:";
            // 
            // gpTratamento
            // 
            this.gpTratamento.Controls.Add(this.cbMedicosDisponiveis);
            this.gpTratamento.Controls.Add(this.lbMedicosDisponiveis);
            this.gpTratamento.Controls.Add(this.lbHorariosDisponiveis);
            this.gpTratamento.Controls.Add(this.dtgTratamento);
            this.gpTratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTratamento.Location = new System.Drawing.Point(12, 225);
            this.gpTratamento.Name = "gpTratamento";
            this.gpTratamento.Size = new System.Drawing.Size(527, 198);
            this.gpTratamento.TabIndex = 8;
            this.gpTratamento.TabStop = false;
            this.gpTratamento.Text = "Tratamento";
            // 
            // cbMedicosDisponiveis
            // 
            this.cbMedicosDisponiveis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedicosDisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedicosDisponiveis.FormattingEnabled = true;
            this.cbMedicosDisponiveis.Location = new System.Drawing.Point(202, 152);
            this.cbMedicosDisponiveis.Name = "cbMedicosDisponiveis";
            this.cbMedicosDisponiveis.Size = new System.Drawing.Size(245, 21);
            this.cbMedicosDisponiveis.TabIndex = 12;
            // 
            // lbMedicosDisponiveis
            // 
            this.lbMedicosDisponiveis.AutoSize = true;
            this.lbMedicosDisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedicosDisponiveis.Location = new System.Drawing.Point(89, 155);
            this.lbMedicosDisponiveis.Name = "lbMedicosDisponiveis";
            this.lbMedicosDisponiveis.Size = new System.Drawing.Size(107, 13);
            this.lbMedicosDisponiveis.TabIndex = 11;
            this.lbMedicosDisponiveis.Text = "Médicos disponíveis:";
            // 
            // lbHorariosDisponiveis
            // 
            this.lbHorariosDisponiveis.AutoSize = true;
            this.lbHorariosDisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorariosDisponiveis.Location = new System.Drawing.Point(6, 31);
            this.lbHorariosDisponiveis.Name = "lbHorariosDisponiveis";
            this.lbHorariosDisponiveis.Size = new System.Drawing.Size(103, 13);
            this.lbHorariosDisponiveis.TabIndex = 9;
            this.lbHorariosDisponiveis.Text = "Horários disponíveis";
            // 
            // dtgTratamento
            // 
            this.dtgTratamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTratamento.Location = new System.Drawing.Point(6, 47);
            this.dtgTratamento.Name = "dtgTratamento";
            this.dtgTratamento.Size = new System.Drawing.Size(498, 80);
            this.dtgTratamento.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbMedicoResponsavelVisu);
            this.groupBox4.Controls.Add(this.lbDataInicioTratamentoVisu);
            this.groupBox4.Controls.Add(this.lbResponsavelVisu);
            this.groupBox4.Controls.Add(this.lbNomeVisu);
            this.groupBox4.Location = new System.Drawing.Point(12, 429);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(527, 102);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Visualização";
            // 
            // lbMedicoResponsavelVisu
            // 
            this.lbMedicoResponsavelVisu.AutoSize = true;
            this.lbMedicoResponsavelVisu.Location = new System.Drawing.Point(6, 78);
            this.lbMedicoResponsavelVisu.Name = "lbMedicoResponsavelVisu";
            this.lbMedicoResponsavelVisu.Size = new System.Drawing.Size(110, 13);
            this.lbMedicoResponsavelVisu.TabIndex = 17;
            this.lbMedicoResponsavelVisu.Text = "Médico Responsável:";
            // 
            // lbDataInicioTratamentoVisu
            // 
            this.lbDataInicioTratamentoVisu.AutoSize = true;
            this.lbDataInicioTratamentoVisu.Location = new System.Drawing.Point(6, 58);
            this.lbDataInicioTratamentoVisu.Name = "lbDataInicioTratamentoVisu";
            this.lbDataInicioTratamentoVisu.Size = new System.Drawing.Size(143, 13);
            this.lbDataInicioTratamentoVisu.TabIndex = 16;
            this.lbDataInicioTratamentoVisu.Text = "Data de inicio do tratamento:";
            // 
            // lbResponsavelVisu
            // 
            this.lbResponsavelVisu.AutoSize = true;
            this.lbResponsavelVisu.Location = new System.Drawing.Point(6, 38);
            this.lbResponsavelVisu.Name = "lbResponsavelVisu";
            this.lbResponsavelVisu.Size = new System.Drawing.Size(72, 13);
            this.lbResponsavelVisu.TabIndex = 15;
            this.lbResponsavelVisu.Text = "Responsável:";
            // 
            // lbNomeVisu
            // 
            this.lbNomeVisu.AutoSize = true;
            this.lbNomeVisu.Location = new System.Drawing.Point(6, 18);
            this.lbNomeVisu.Name = "lbNomeVisu";
            this.lbNomeVisu.Size = new System.Drawing.Size(38, 13);
            this.lbNomeVisu.TabIndex = 14;
            this.lbNomeVisu.Text = "Nome:";
            // 
            // btnAgendarTratamento
            // 
            this.btnAgendarTratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarTratamento.Location = new System.Drawing.Point(177, 537);
            this.btnAgendarTratamento.Name = "btnAgendarTratamento";
            this.btnAgendarTratamento.Size = new System.Drawing.Size(197, 39);
            this.btnAgendarTratamento.TabIndex = 18;
            this.btnAgendarTratamento.Text = "Agendar";
            this.btnAgendarTratamento.UseVisualStyleBackColor = true;
            // 
            // frmAgendarTratamentoComConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 584);
            this.Controls.Add(this.btnAgendarTratamento);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gpTratamento);
            this.Controls.Add(this.gpInformacoesCliente);
            this.Controls.Add(this.gpCliente);
            this.Name = "frmAgendarTratamentoComConsulta";
            this.Text = "Agendar Tratamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gpCliente.ResumeLayout(false);
            this.gpInformacoesCliente.ResumeLayout(false);
            this.gpInformacoesCliente.PerformLayout();
            this.gpTratamento.ResumeLayout(false);
            this.gpTratamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTratamento)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpCliente;
        private System.Windows.Forms.Button btnSelecionarCliente;
        private System.Windows.Forms.GroupBox gpInformacoesCliente;
        private System.Windows.Forms.Label lbDiagnosticoConsulta;
        private System.Windows.Forms.Label lbDataConsulta;
        private System.Windows.Forms.Label lbNomeResponsavel;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.GroupBox gpTratamento;
        private System.Windows.Forms.ComboBox cbMedicosDisponiveis;
        private System.Windows.Forms.Label lbMedicosDisponiveis;
        private System.Windows.Forms.Label lbHorariosDisponiveis;
        private System.Windows.Forms.DataGridView dtgTratamento;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbMedicoResponsavelVisu;
        private System.Windows.Forms.Label lbDataInicioTratamentoVisu;
        private System.Windows.Forms.Label lbResponsavelVisu;
        private System.Windows.Forms.Label lbNomeVisu;
        private System.Windows.Forms.Button btnAgendarTratamento;
    }
}