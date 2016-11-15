namespace SisClinica.Forms
{
    partial class userControlConfirmarSessoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgSessoes = new System.Windows.Forms.DataGridView();
            this.gbConfirmar = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTipoTrat = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblCRM = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSessoes)).BeginInit();
            this.gbConfirmar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione uma sessão para confirmar:";
            // 
            // dtgSessoes
            // 
            this.dtgSessoes.AllowUserToAddRows = false;
            this.dtgSessoes.AllowUserToDeleteRows = false;
            this.dtgSessoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSessoes.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgSessoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgSessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSessoes.Location = new System.Drawing.Point(0, 42);
            this.dtgSessoes.Name = "dtgSessoes";
            this.dtgSessoes.ReadOnly = true;
            this.dtgSessoes.Size = new System.Drawing.Size(672, 168);
            this.dtgSessoes.TabIndex = 1;
            this.dtgSessoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSessoes_CellClick);
            // 
            // gbConfirmar
            // 
            this.gbConfirmar.Controls.Add(this.btnConfirmar);
            this.gbConfirmar.Controls.Add(this.lblHorario);
            this.gbConfirmar.Controls.Add(this.lblConsultorio);
            this.gbConfirmar.Controls.Add(this.lblValor);
            this.gbConfirmar.Controls.Add(this.lblTipoTrat);
            this.gbConfirmar.Controls.Add(this.lblTipo);
            this.gbConfirmar.Controls.Add(this.lblMedico);
            this.gbConfirmar.Controls.Add(this.lblCRM);
            this.gbConfirmar.Controls.Add(this.lblCPF);
            this.gbConfirmar.Controls.Add(this.lblCliente);
            this.gbConfirmar.Controls.Add(this.label10);
            this.gbConfirmar.Controls.Add(this.label9);
            this.gbConfirmar.Controls.Add(this.label8);
            this.gbConfirmar.Controls.Add(this.label7);
            this.gbConfirmar.Controls.Add(this.label6);
            this.gbConfirmar.Controls.Add(this.label5);
            this.gbConfirmar.Controls.Add(this.label4);
            this.gbConfirmar.Controls.Add(this.label3);
            this.gbConfirmar.Controls.Add(this.label2);
            this.gbConfirmar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbConfirmar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gbConfirmar.ForeColor = System.Drawing.Color.White;
            this.gbConfirmar.Location = new System.Drawing.Point(0, 216);
            this.gbConfirmar.Name = "gbConfirmar";
            this.gbConfirmar.Size = new System.Drawing.Size(672, 193);
            this.gbConfirmar.TabIndex = 2;
            this.gbConfirmar.TabStop = false;
            this.gbConfirmar.Text = "Confirmar Sessão";
            this.gbConfirmar.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(528, 134);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(138, 53);
            this.btnConfirmar.TabIndex = 39;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(387, 116);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(55, 17);
            this.lblHorario.TabIndex = 38;
            this.lblHorario.Text = "Horário";
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.BackColor = System.Drawing.Color.Transparent;
            this.lblConsultorio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultorio.ForeColor = System.Drawing.Color.White;
            this.lblConsultorio.Location = new System.Drawing.Point(387, 84);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(82, 17);
            this.lblConsultorio.TabIndex = 37;
            this.lblConsultorio.Text = "Consultorio";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(151, 156);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(42, 17);
            this.lblValor.TabIndex = 36;
            this.lblValor.Text = "Valor";
            // 
            // lblTipoTrat
            // 
            this.lblTipoTrat.AutoSize = true;
            this.lblTipoTrat.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoTrat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTrat.ForeColor = System.Drawing.Color.White;
            this.lblTipoTrat.Location = new System.Drawing.Point(151, 116);
            this.lblTipoTrat.Name = "lblTipoTrat";
            this.lblTipoTrat.Size = new System.Drawing.Size(12, 17);
            this.lblTipoTrat.TabIndex = 35;
            this.lblTipoTrat.Text = "-";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(151, 84);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(34, 17);
            this.lblTipo.TabIndex = 34;
            this.lblTipo.Text = "Tipo";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.BackColor = System.Drawing.Color.Transparent;
            this.lblMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.ForeColor = System.Drawing.Color.White;
            this.lblMedico.Location = new System.Drawing.Point(151, 52);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(56, 17);
            this.lblMedico.TabIndex = 33;
            this.lblMedico.Text = "Médico";
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.BackColor = System.Drawing.Color.Transparent;
            this.lblCRM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRM.ForeColor = System.Drawing.Color.White;
            this.lblCRM.Location = new System.Drawing.Point(387, 52);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(38, 17);
            this.lblCRM.TabIndex = 32;
            this.lblCRM.Text = "CRM";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(387, 20);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(33, 17);
            this.lblCPF.TabIndex = 31;
            this.lblCPF.Text = "CPF";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(151, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(54, 17);
            this.lblCliente.TabIndex = 30;
            this.lblCliente.Text = "Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Tipo de sessão:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Valor da sessão:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(339, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "CRM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Médico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Horário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tipo de tratamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Consultório:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cliente:";
            // 
            // userControlConfirmarSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gbConfirmar);
            this.Controls.Add(this.dtgSessoes);
            this.Controls.Add(this.label1);
            this.Name = "userControlConfirmarSessoes";
            this.Size = new System.Drawing.Size(672, 409);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSessoes)).EndInit();
            this.gbConfirmar.ResumeLayout(false);
            this.gbConfirmar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgSessoes;
        private System.Windows.Forms.GroupBox gbConfirmar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTipoTrat;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
