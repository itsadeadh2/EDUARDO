namespace SisClinica.Forms
{
    partial class frmAgendarTratamentoSemConsulta
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
            this.gpClienteAgendarTratamentoSemConsulta = new System.Windows.Forms.GroupBox();
            this.btnRegistrarNovoAgendarTratamentoSemConsulta = new System.Windows.Forms.Button();
            this.btnSelecionarClienteAgendarTratamentoSemConsulta = new System.Windows.Forms.Button();
            this.gpTratamentoAgendarTratamentoSemConsulta = new System.Windows.Forms.GroupBox();
            this.CbMedicoDisponiveisAgendarTratamentoSemConsulta = new System.Windows.Forms.ComboBox();
            this.lbMedicosDisponivelAgendarTratamentoSemConsulta = new System.Windows.Forms.Label();
            this.lbHorariosTratamentoAgendarTratamentoSemConsulta = new System.Windows.Forms.Label();
            this.dtgHorariosTratamentosAgendarTratamentoSemConsulta = new System.Windows.Forms.DataGridView();
            this.gpVisualizacaoAgendarTratamentoSemConsulta = new System.Windows.Forms.GroupBox();
            this.lbMedicoResponsavelAgendarTratamentoSemConsulta = new System.Windows.Forms.Label();
            this.lbDataInicioTratamentoAgendarTratamentoSemConsultaVisu = new System.Windows.Forms.Label();
            this.lbResponsavelAgendarTratamentoSemConsultaVisu = new System.Windows.Forms.Label();
            this.lbNomeAgendarTratamentoSemConsulta = new System.Windows.Forms.Label();
            this.btnAgendarAgendarTratamentoSemConsulta = new System.Windows.Forms.Button();
            this.gpClienteAgendarTratamentoSemConsulta.SuspendLayout();
            this.gpTratamentoAgendarTratamentoSemConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHorariosTratamentosAgendarTratamentoSemConsulta)).BeginInit();
            this.gpVisualizacaoAgendarTratamentoSemConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpClienteAgendarTratamentoSemConsulta
            // 
            this.gpClienteAgendarTratamentoSemConsulta.Controls.Add(this.btnRegistrarNovoAgendarTratamentoSemConsulta);
            this.gpClienteAgendarTratamentoSemConsulta.Controls.Add(this.btnSelecionarClienteAgendarTratamentoSemConsulta);
            this.gpClienteAgendarTratamentoSemConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpClienteAgendarTratamentoSemConsulta.Location = new System.Drawing.Point(12, 12);
            this.gpClienteAgendarTratamentoSemConsulta.Name = "gpClienteAgendarTratamentoSemConsulta";
            this.gpClienteAgendarTratamentoSemConsulta.Size = new System.Drawing.Size(527, 100);
            this.gpClienteAgendarTratamentoSemConsulta.TabIndex = 1;
            this.gpClienteAgendarTratamentoSemConsulta.TabStop = false;
            this.gpClienteAgendarTratamentoSemConsulta.Text = "Cliente";
            // 
            // btnRegistrarNovoAgendarTratamentoSemConsulta
            // 
            this.btnRegistrarNovoAgendarTratamentoSemConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarNovoAgendarTratamentoSemConsulta.Location = new System.Drawing.Point(283, 35);
            this.btnRegistrarNovoAgendarTratamentoSemConsulta.Name = "btnRegistrarNovoAgendarTratamentoSemConsulta";
            this.btnRegistrarNovoAgendarTratamentoSemConsulta.Size = new System.Drawing.Size(197, 47);
            this.btnRegistrarNovoAgendarTratamentoSemConsulta.TabIndex = 3;
            this.btnRegistrarNovoAgendarTratamentoSemConsulta.Text = "Registrar Novo";
            this.btnRegistrarNovoAgendarTratamentoSemConsulta.UseVisualStyleBackColor = true;
            this.btnRegistrarNovoAgendarTratamentoSemConsulta.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSelecionarClienteAgendarTratamentoSemConsulta
            // 
            this.btnSelecionarClienteAgendarTratamentoSemConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarClienteAgendarTratamentoSemConsulta.Location = new System.Drawing.Point(53, 35);
            this.btnSelecionarClienteAgendarTratamentoSemConsulta.Name = "btnSelecionarClienteAgendarTratamentoSemConsulta";
            this.btnSelecionarClienteAgendarTratamentoSemConsulta.Size = new System.Drawing.Size(197, 47);
            this.btnSelecionarClienteAgendarTratamentoSemConsulta.TabIndex = 2;
            this.btnSelecionarClienteAgendarTratamentoSemConsulta.Text = "Selecionar Cliente";
            this.btnSelecionarClienteAgendarTratamentoSemConsulta.UseVisualStyleBackColor = true;
            this.btnSelecionarClienteAgendarTratamentoSemConsulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpTratamentoAgendarTratamentoSemConsulta
            // 
            this.gpTratamentoAgendarTratamentoSemConsulta.Controls.Add(this.CbMedicoDisponiveisAgendarTratamentoSemConsulta);
            this.gpTratamentoAgendarTratamentoSemConsulta.Controls.Add(this.lbMedicosDisponivelAgendarTratamentoSemConsulta);
            this.gpTratamentoAgendarTratamentoSemConsulta.Controls.Add(this.lbHorariosTratamentoAgendarTratamentoSemConsulta);
            this.gpTratamentoAgendarTratamentoSemConsulta.Controls.Add(this.dtgHorariosTratamentosAgendarTratamentoSemConsulta);
            this.gpTratamentoAgendarTratamentoSemConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTratamentoAgendarTratamentoSemConsulta.Location = new System.Drawing.Point(12, 118);
            this.gpTratamentoAgendarTratamentoSemConsulta.Name = "gpTratamentoAgendarTratamentoSemConsulta";
            this.gpTratamentoAgendarTratamentoSemConsulta.Size = new System.Drawing.Size(527, 198);
            this.gpTratamentoAgendarTratamentoSemConsulta.TabIndex = 6;
            this.gpTratamentoAgendarTratamentoSemConsulta.TabStop = false;
            this.gpTratamentoAgendarTratamentoSemConsulta.Text = "Tratamento";
            // 
            // CbMedicoDisponiveisAgendarTratamentoSemConsulta
            // 
            this.CbMedicoDisponiveisAgendarTratamentoSemConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMedicoDisponiveisAgendarTratamentoSemConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbMedicoDisponiveisAgendarTratamentoSemConsulta.FormattingEnabled = true;
            this.CbMedicoDisponiveisAgendarTratamentoSemConsulta.Location = new System.Drawing.Point(202, 152);
            this.CbMedicoDisponiveisAgendarTratamentoSemConsulta.Name = "CbMedicoDisponiveisAgendarTratamentoSemConsulta";
            this.CbMedicoDisponiveisAgendarTratamentoSemConsulta.Size = new System.Drawing.Size(245, 21);
            this.CbMedicoDisponiveisAgendarTratamentoSemConsulta.TabIndex = 8;
            // 
            // lbMedicosDisponivelAgendarTratamentoSemConsulta
            // 
            this.lbMedicosDisponivelAgendarTratamentoSemConsulta.AutoSize = true;
            this.lbMedicosDisponivelAgendarTratamentoSemConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedicosDisponivelAgendarTratamentoSemConsulta.Location = new System.Drawing.Point(89, 155);
            this.lbMedicosDisponivelAgendarTratamentoSemConsulta.Name = "lbMedicosDisponivelAgendarTratamentoSemConsulta";
            this.lbMedicosDisponivelAgendarTratamentoSemConsulta.Size = new System.Drawing.Size(107, 13);
            this.lbMedicosDisponivelAgendarTratamentoSemConsulta.TabIndex = 7;
            this.lbMedicosDisponivelAgendarTratamentoSemConsulta.Text = "Médicos disponíveis:";
            // 
            // lbHorariosTratamentoAgendarTratamentoSemConsulta
            // 
            this.lbHorariosTratamentoAgendarTratamentoSemConsulta.AutoSize = true;
            this.lbHorariosTratamentoAgendarTratamentoSemConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorariosTratamentoAgendarTratamentoSemConsulta.Location = new System.Drawing.Point(6, 31);
            this.lbHorariosTratamentoAgendarTratamentoSemConsulta.Name = "lbHorariosTratamentoAgendarTratamentoSemConsulta";
            this.lbHorariosTratamentoAgendarTratamentoSemConsulta.Size = new System.Drawing.Size(103, 13);
            this.lbHorariosTratamentoAgendarTratamentoSemConsulta.TabIndex = 5;
            this.lbHorariosTratamentoAgendarTratamentoSemConsulta.Text = "Horários disponíveis";
            // 
            // dtgHorariosTratamentosAgendarTratamentoSemConsulta
            // 
            this.dtgHorariosTratamentosAgendarTratamentoSemConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHorariosTratamentosAgendarTratamentoSemConsulta.Location = new System.Drawing.Point(6, 47);
            this.dtgHorariosTratamentosAgendarTratamentoSemConsulta.Name = "dtgHorariosTratamentosAgendarTratamentoSemConsulta";
            this.dtgHorariosTratamentosAgendarTratamentoSemConsulta.Size = new System.Drawing.Size(498, 80);
            this.dtgHorariosTratamentosAgendarTratamentoSemConsulta.TabIndex = 6;
            // 
            // gpVisualizacaoAgendarTratamentoSemConsulta
            // 
            this.gpVisualizacaoAgendarTratamentoSemConsulta.Controls.Add(this.lbMedicoResponsavelAgendarTratamentoSemConsulta);
            this.gpVisualizacaoAgendarTratamentoSemConsulta.Controls.Add(this.lbDataInicioTratamentoAgendarTratamentoSemConsultaVisu);
            this.gpVisualizacaoAgendarTratamentoSemConsulta.Controls.Add(this.lbResponsavelAgendarTratamentoSemConsultaVisu);
            this.gpVisualizacaoAgendarTratamentoSemConsulta.Controls.Add(this.lbNomeAgendarTratamentoSemConsulta);
            this.gpVisualizacaoAgendarTratamentoSemConsulta.Location = new System.Drawing.Point(12, 322);
            this.gpVisualizacaoAgendarTratamentoSemConsulta.Name = "gpVisualizacaoAgendarTratamentoSemConsulta";
            this.gpVisualizacaoAgendarTratamentoSemConsulta.Size = new System.Drawing.Size(527, 106);
            this.gpVisualizacaoAgendarTratamentoSemConsulta.TabIndex = 9;
            this.gpVisualizacaoAgendarTratamentoSemConsulta.TabStop = false;
            this.gpVisualizacaoAgendarTratamentoSemConsulta.Text = "Visualização";
            // 
            // lbMedicoResponsavelAgendarTratamentoSemConsulta
            // 
            this.lbMedicoResponsavelAgendarTratamentoSemConsulta.AutoSize = true;
            this.lbMedicoResponsavelAgendarTratamentoSemConsulta.Location = new System.Drawing.Point(6, 79);
            this.lbMedicoResponsavelAgendarTratamentoSemConsulta.Name = "lbMedicoResponsavelAgendarTratamentoSemConsulta";
            this.lbMedicoResponsavelAgendarTratamentoSemConsulta.Size = new System.Drawing.Size(110, 13);
            this.lbMedicoResponsavelAgendarTratamentoSemConsulta.TabIndex = 13;
            this.lbMedicoResponsavelAgendarTratamentoSemConsulta.Text = "Médico Responsável:";
            // 
            // lbDataInicioTratamentoAgendarTratamentoSemConsultaVisu
            // 
            this.lbDataInicioTratamentoAgendarTratamentoSemConsultaVisu.AutoSize = true;
            this.lbDataInicioTratamentoAgendarTratamentoSemConsultaVisu.Location = new System.Drawing.Point(6, 59);
            this.lbDataInicioTratamentoAgendarTratamentoSemConsultaVisu.Name = "lbDataInicioTratamentoAgendarTratamentoSemConsultaVisu";
            this.lbDataInicioTratamentoAgendarTratamentoSemConsultaVisu.Size = new System.Drawing.Size(143, 13);
            this.lbDataInicioTratamentoAgendarTratamentoSemConsultaVisu.TabIndex = 12;
            this.lbDataInicioTratamentoAgendarTratamentoSemConsultaVisu.Text = "Data de inicio do tratamento:";
            // 
            // lbResponsavelAgendarTratamentoSemConsultaVisu
            // 
            this.lbResponsavelAgendarTratamentoSemConsultaVisu.AutoSize = true;
            this.lbResponsavelAgendarTratamentoSemConsultaVisu.Location = new System.Drawing.Point(6, 39);
            this.lbResponsavelAgendarTratamentoSemConsultaVisu.Name = "lbResponsavelAgendarTratamentoSemConsultaVisu";
            this.lbResponsavelAgendarTratamentoSemConsultaVisu.Size = new System.Drawing.Size(72, 13);
            this.lbResponsavelAgendarTratamentoSemConsultaVisu.TabIndex = 11;
            this.lbResponsavelAgendarTratamentoSemConsultaVisu.Text = "Responsável:";
            // 
            // lbNomeAgendarTratamentoSemConsulta
            // 
            this.lbNomeAgendarTratamentoSemConsulta.AutoSize = true;
            this.lbNomeAgendarTratamentoSemConsulta.Location = new System.Drawing.Point(6, 19);
            this.lbNomeAgendarTratamentoSemConsulta.Name = "lbNomeAgendarTratamentoSemConsulta";
            this.lbNomeAgendarTratamentoSemConsulta.Size = new System.Drawing.Size(38, 13);
            this.lbNomeAgendarTratamentoSemConsulta.TabIndex = 10;
            this.lbNomeAgendarTratamentoSemConsulta.Text = "Nome:";
            // 
            // btnAgendarAgendarTratamentoSemConsulta
            // 
            this.btnAgendarAgendarTratamentoSemConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarAgendarTratamentoSemConsulta.Location = new System.Drawing.Point(174, 434);
            this.btnAgendarAgendarTratamentoSemConsulta.Name = "btnAgendarAgendarTratamentoSemConsulta";
            this.btnAgendarAgendarTratamentoSemConsulta.Size = new System.Drawing.Size(197, 39);
            this.btnAgendarAgendarTratamentoSemConsulta.TabIndex = 14;
            this.btnAgendarAgendarTratamentoSemConsulta.Text = "Agendar";
            this.btnAgendarAgendarTratamentoSemConsulta.UseVisualStyleBackColor = true;
            // 
            // frmAgendarTratamentoSemConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 481);
            this.Controls.Add(this.btnAgendarAgendarTratamentoSemConsulta);
            this.Controls.Add(this.gpVisualizacaoAgendarTratamentoSemConsulta);
            this.Controls.Add(this.gpTratamentoAgendarTratamentoSemConsulta);
            this.Controls.Add(this.gpClienteAgendarTratamentoSemConsulta);
            this.Name = "frmAgendarTratamentoSemConsulta";
            this.Text = "Agendar tratamento sem consulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gpClienteAgendarTratamentoSemConsulta.ResumeLayout(false);
            this.gpTratamentoAgendarTratamentoSemConsulta.ResumeLayout(false);
            this.gpTratamentoAgendarTratamentoSemConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHorariosTratamentosAgendarTratamentoSemConsulta)).EndInit();
            this.gpVisualizacaoAgendarTratamentoSemConsulta.ResumeLayout(false);
            this.gpVisualizacaoAgendarTratamentoSemConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpClienteAgendarTratamentoSemConsulta;
        private System.Windows.Forms.Button btnRegistrarNovoAgendarTratamentoSemConsulta;
        private System.Windows.Forms.Button btnSelecionarClienteAgendarTratamentoSemConsulta;
        private System.Windows.Forms.GroupBox gpTratamentoAgendarTratamentoSemConsulta;
        private System.Windows.Forms.ComboBox CbMedicoDisponiveisAgendarTratamentoSemConsulta;
        private System.Windows.Forms.Label lbMedicosDisponivelAgendarTratamentoSemConsulta;
        private System.Windows.Forms.Label lbHorariosTratamentoAgendarTratamentoSemConsulta;
        private System.Windows.Forms.DataGridView dtgHorariosTratamentosAgendarTratamentoSemConsulta;
        private System.Windows.Forms.GroupBox gpVisualizacaoAgendarTratamentoSemConsulta;
        private System.Windows.Forms.Label lbMedicoResponsavelAgendarTratamentoSemConsulta;
        private System.Windows.Forms.Label lbDataInicioTratamentoAgendarTratamentoSemConsultaVisu;
        private System.Windows.Forms.Label lbResponsavelAgendarTratamentoSemConsultaVisu;
        private System.Windows.Forms.Label lbNomeAgendarTratamentoSemConsulta;
        private System.Windows.Forms.Button btnAgendarAgendarTratamentoSemConsulta;
    }
}