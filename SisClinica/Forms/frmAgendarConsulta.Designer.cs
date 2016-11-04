namespace SisClinica.Forms
{
    partial class frmAgendarConsulta
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnRegistrarNovo = new System.Windows.Forms.Button();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbHorarioInicial = new System.Windows.Forms.ComboBox();
            this.cbHorarioFinal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbConsultorio = new System.Windows.Forms.ComboBox();
            this.lblInfoConsultorio = new System.Windows.Forms.Label();
            this.cbMedicosDisponiveis = new System.Windows.Forms.ComboBox();
            this.lblInfoMedicos = new System.Windows.Forms.Label();
            this.gbVisualizacao = new System.Windows.Forms.GroupBox();
            this.lblHoraConsulta = new System.Windows.Forms.Label();
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.lblMedicoResponsavel = new System.Windows.Forms.Label();
            this.lblDataConsulta = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            this.gbConsulta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbVisualizacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnRegistrarNovo);
            this.gbCliente.Controls.Add(this.btnSelecionarCliente);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(12, 25);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(510, 100);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // btnRegistrarNovo
            // 
            this.btnRegistrarNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarNovo.Location = new System.Drawing.Point(283, 35);
            this.btnRegistrarNovo.Name = "btnRegistrarNovo";
            this.btnRegistrarNovo.Size = new System.Drawing.Size(197, 47);
            this.btnRegistrarNovo.TabIndex = 1;
            this.btnRegistrarNovo.Text = "Registrar Novo";
            this.btnRegistrarNovo.UseVisualStyleBackColor = true;
            this.btnRegistrarNovo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarCliente.Location = new System.Drawing.Point(53, 35);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(197, 47);
            this.btnSelecionarCliente.TabIndex = 0;
            this.btnSelecionarCliente.Text = "Selecionar Cliente";
            this.btnSelecionarCliente.UseVisualStyleBackColor = true;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.groupBox1);
            this.gbConsulta.Controls.Add(this.dtpDia);
            this.gbConsulta.Controls.Add(this.label1);
            this.gbConsulta.Controls.Add(this.cbConsultorio);
            this.gbConsulta.Controls.Add(this.lblInfoConsultorio);
            this.gbConsulta.Controls.Add(this.cbMedicosDisponiveis);
            this.gbConsulta.Controls.Add(this.lblInfoMedicos);
            this.gbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsulta.Location = new System.Drawing.Point(12, 131);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(510, 239);
            this.gbConsulta.TabIndex = 1;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbHorarioInicial);
            this.groupBox1.Controls.Add(this.cbHorarioFinal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(114, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 78);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horário";
            // 
            // cbHorarioInicial
            // 
            this.cbHorarioInicial.DisplayMember = "Hora";
            this.cbHorarioInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHorarioInicial.FormattingEnabled = true;
            this.cbHorarioInicial.Location = new System.Drawing.Point(32, 31);
            this.cbHorarioInicial.Name = "cbHorarioInicial";
            this.cbHorarioInicial.Size = new System.Drawing.Size(81, 21);
            this.cbHorarioInicial.TabIndex = 11;
            this.cbHorarioInicial.ValueMember = "data";
            this.cbHorarioInicial.SelectedIndexChanged += new System.EventHandler(this.cbHorarioInicial_SelectedIndexChanged);
            // 
            // cbHorarioFinal
            // 
            this.cbHorarioFinal.DisplayMember = "Hora";
            this.cbHorarioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHorarioFinal.FormattingEnabled = true;
            this.cbHorarioFinal.Location = new System.Drawing.Point(170, 31);
            this.cbHorarioFinal.Name = "cbHorarioFinal";
            this.cbHorarioFinal.Size = new System.Drawing.Size(81, 21);
            this.cbHorarioFinal.TabIndex = 10;
            this.cbHorarioFinal.ValueMember = "data";
            this.cbHorarioFinal.SelectedIndexChanged += new System.EventHandler(this.cbHorarioFinal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "As";
            // 
            // dtpDia
            // 
            this.dtpDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDia.Location = new System.Drawing.Point(100, 19);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(231, 20);
            this.dtpDia.TabIndex = 7;
            this.dtpDia.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecionar data:";
            // 
            // cbConsultorio
            // 
            this.cbConsultorio.DisplayMember = "Nome";
            this.cbConsultorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConsultorio.FormattingEnabled = true;
            this.cbConsultorio.Location = new System.Drawing.Point(100, 82);
            this.cbConsultorio.Name = "cbConsultorio";
            this.cbConsultorio.Size = new System.Drawing.Size(245, 21);
            this.cbConsultorio.TabIndex = 5;
            this.cbConsultorio.ValueMember = "id";
            this.cbConsultorio.SelectedIndexChanged += new System.EventHandler(this.cbConsultorio_SelectedIndexChanged);
            // 
            // lblInfoConsultorio
            // 
            this.lblInfoConsultorio.AutoSize = true;
            this.lblInfoConsultorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoConsultorio.Location = new System.Drawing.Point(32, 85);
            this.lblInfoConsultorio.Name = "lblInfoConsultorio";
            this.lblInfoConsultorio.Size = new System.Drawing.Size(62, 13);
            this.lblInfoConsultorio.TabIndex = 4;
            this.lblInfoConsultorio.Text = "Consultório:";
            // 
            // cbMedicosDisponiveis
            // 
            this.cbMedicosDisponiveis.DisplayMember = "nome do medico";
            this.cbMedicosDisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedicosDisponiveis.FormattingEnabled = true;
            this.cbMedicosDisponiveis.Location = new System.Drawing.Point(100, 50);
            this.cbMedicosDisponiveis.Name = "cbMedicosDisponiveis";
            this.cbMedicosDisponiveis.Size = new System.Drawing.Size(245, 21);
            this.cbMedicosDisponiveis.TabIndex = 3;
            this.cbMedicosDisponiveis.ValueMember = "id medico";
            this.cbMedicosDisponiveis.SelectedIndexChanged += new System.EventHandler(this.cbMedicosDisponiveis_SelectedIndexChanged);
            // 
            // lblInfoMedicos
            // 
            this.lblInfoMedicos.AutoSize = true;
            this.lblInfoMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoMedicos.Location = new System.Drawing.Point(50, 53);
            this.lblInfoMedicos.Name = "lblInfoMedicos";
            this.lblInfoMedicos.Size = new System.Drawing.Size(45, 13);
            this.lblInfoMedicos.TabIndex = 2;
            this.lblInfoMedicos.Text = "Médico:";
            // 
            // gbVisualizacao
            // 
            this.gbVisualizacao.Controls.Add(this.lblHoraConsulta);
            this.gbVisualizacao.Controls.Add(this.lblConsultorio);
            this.gbVisualizacao.Controls.Add(this.lblMedicoResponsavel);
            this.gbVisualizacao.Controls.Add(this.lblDataConsulta);
            this.gbVisualizacao.Controls.Add(this.lblCliente);
            this.gbVisualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVisualizacao.Location = new System.Drawing.Point(12, 376);
            this.gbVisualizacao.Name = "gbVisualizacao";
            this.gbVisualizacao.Size = new System.Drawing.Size(504, 148);
            this.gbVisualizacao.TabIndex = 2;
            this.gbVisualizacao.TabStop = false;
            this.gbVisualizacao.Text = "Visualização";
            // 
            // lblHoraConsulta
            // 
            this.lblHoraConsulta.AutoSize = true;
            this.lblHoraConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraConsulta.Location = new System.Drawing.Point(246, 56);
            this.lblHoraConsulta.Name = "lblHoraConsulta";
            this.lblHoraConsulta.Size = new System.Drawing.Size(53, 16);
            this.lblHoraConsulta.TabIndex = 8;
            this.lblHoraConsulta.Text = "Horário";
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultorio.Location = new System.Drawing.Point(6, 108);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(78, 16);
            this.lblConsultorio.TabIndex = 7;
            this.lblConsultorio.Text = "Consultório:";
            // 
            // lblMedicoResponsavel
            // 
            this.lblMedicoResponsavel.AutoSize = true;
            this.lblMedicoResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicoResponsavel.Location = new System.Drawing.Point(6, 82);
            this.lblMedicoResponsavel.Name = "lblMedicoResponsavel";
            this.lblMedicoResponsavel.Size = new System.Drawing.Size(134, 16);
            this.lblMedicoResponsavel.TabIndex = 6;
            this.lblMedicoResponsavel.Text = "Médico responsável:";
            // 
            // lblDataConsulta
            // 
            this.lblDataConsulta.AutoSize = true;
            this.lblDataConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataConsulta.Location = new System.Drawing.Point(6, 56);
            this.lblDataConsulta.Name = "lblDataConsulta";
            this.lblDataConsulta.Size = new System.Drawing.Size(112, 16);
            this.lblDataConsulta.TabIndex = 5;
            this.lblDataConsulta.Text = "Data da consulta:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(6, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(52, 16);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnAgendar
            // 
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.Location = new System.Drawing.Point(195, 530);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(197, 39);
            this.btnAgendar.TabIndex = 2;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmAgendarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 572);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.gbVisualizacao);
            this.Controls.Add(this.gbConsulta);
            this.Controls.Add(this.gbCliente);
            this.Name = "frmAgendarConsulta";
            this.Text = "Agendar Consulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAgendarConsulta_Load);
            this.SizeChanged += new System.EventHandler(this.frmAgendarConsulta_SizeChanged);
            this.gbCliente.ResumeLayout(false);
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbVisualizacao.ResumeLayout(false);
            this.gbVisualizacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnRegistrarNovo;
        private System.Windows.Forms.Button btnSelecionarCliente;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.ComboBox cbMedicosDisponiveis;
        private System.Windows.Forms.Label lblInfoMedicos;
        private System.Windows.Forms.GroupBox gbVisualizacao;
        private System.Windows.Forms.Label lblMedicoResponsavel;
        private System.Windows.Forms.Label lblDataConsulta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.ComboBox cbConsultorio;
        private System.Windows.Forms.Label lblInfoConsultorio;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbHorarioInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHorarioFinal;
        private System.Windows.Forms.Label lblHoraConsulta;
    }
}