namespace SisClinica.Forms
{
    partial class userControlAgendarProximoTratamento
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
            this.bgVisualizacao = new System.Windows.Forms.GroupBox();
            this.lblValorPorSessao = new System.Windows.Forms.Label();
            this.lblValortotal = new System.Windows.Forms.Label();
            this.lblVisQtde = new System.Windows.Forms.Label();
            this.lblVisTipo = new System.Windows.Forms.Label();
            this.lblVisMedic = new System.Windows.Forms.Label();
            this.lblVisHora = new System.Windows.Forms.Label();
            this.lblVisConsult = new System.Windows.Forms.Label();
            this.lblVisCli = new System.Windows.Forms.Label();
            this.gbTratamento = new System.Windows.Forms.GroupBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lbData = new System.Windows.Forms.Label();
            this.gbHorário = new System.Windows.Forms.GroupBox();
            this.cbHorarioFinal = new System.Windows.Forms.ComboBox();
            this.lblAs = new System.Windows.Forms.Label();
            this.cbHorarioInicial = new System.Windows.Forms.ComboBox();
            this.rdbTarde = new System.Windows.Forms.RadioButton();
            this.rdbManha = new System.Windows.Forms.RadioButton();
            this.cbTipoDeTratamento = new System.Windows.Forms.ComboBox();
            this.cbMedicos = new System.Windows.Forms.ComboBox();
            this.cbConsultorios = new System.Windows.Forms.ComboBox();
            this.lblSelecConsult = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblSelecData = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.bgVisualizacao.SuspendLayout();
            this.gbTratamento.SuspendLayout();
            this.gbHorário.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgVisualizacao
            // 
            this.bgVisualizacao.Controls.Add(this.lblValorPorSessao);
            this.bgVisualizacao.Controls.Add(this.lblValortotal);
            this.bgVisualizacao.Controls.Add(this.lblVisQtde);
            this.bgVisualizacao.Controls.Add(this.lblVisTipo);
            this.bgVisualizacao.Controls.Add(this.lblVisMedic);
            this.bgVisualizacao.Controls.Add(this.lblVisHora);
            this.bgVisualizacao.Controls.Add(this.lblVisConsult);
            this.bgVisualizacao.Controls.Add(this.lblVisCli);
            this.bgVisualizacao.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgVisualizacao.ForeColor = System.Drawing.Color.White;
            this.bgVisualizacao.Location = new System.Drawing.Point(15, 258);
            this.bgVisualizacao.Name = "bgVisualizacao";
            this.bgVisualizacao.Size = new System.Drawing.Size(471, 151);
            this.bgVisualizacao.TabIndex = 4;
            this.bgVisualizacao.TabStop = false;
            this.bgVisualizacao.Text = "Visualização";
            // 
            // lblValorPorSessao
            // 
            this.lblValorPorSessao.AutoSize = true;
            this.lblValorPorSessao.Location = new System.Drawing.Point(319, 35);
            this.lblValorPorSessao.Name = "lblValorPorSessao";
            this.lblValorPorSessao.Size = new System.Drawing.Size(96, 16);
            this.lblValorPorSessao.TabIndex = 8;
            this.lblValorPorSessao.Text = "Valor por sessão:";
            // 
            // lblValortotal
            // 
            this.lblValortotal.AutoSize = true;
            this.lblValortotal.Location = new System.Drawing.Point(349, 19);
            this.lblValortotal.Name = "lblValortotal";
            this.lblValortotal.Size = new System.Drawing.Size(66, 16);
            this.lblValortotal.TabIndex = 7;
            this.lblValortotal.Text = "Valor total:";
            // 
            // lblVisQtde
            // 
            this.lblVisQtde.AutoSize = true;
            this.lblVisQtde.Location = new System.Drawing.Point(9, 114);
            this.lblVisQtde.Name = "lblVisQtde";
            this.lblVisQtde.Size = new System.Drawing.Size(138, 16);
            this.lblVisQtde.TabIndex = 6;
            this.lblVisQtde.Text = "Quantidade de sessôes:";
            // 
            // lblVisTipo
            // 
            this.lblVisTipo.AutoSize = true;
            this.lblVisTipo.Location = new System.Drawing.Point(9, 57);
            this.lblVisTipo.Name = "lblVisTipo";
            this.lblVisTipo.Size = new System.Drawing.Size(116, 16);
            this.lblVisTipo.TabIndex = 5;
            this.lblVisTipo.Text = "Tipo de tratamento:";
            // 
            // lblVisMedic
            // 
            this.lblVisMedic.AutoSize = true;
            this.lblVisMedic.Location = new System.Drawing.Point(9, 38);
            this.lblVisMedic.Name = "lblVisMedic";
            this.lblVisMedic.Size = new System.Drawing.Size(125, 16);
            this.lblVisMedic.TabIndex = 4;
            this.lblVisMedic.Text = "Médico Responsável:";
            // 
            // lblVisHora
            // 
            this.lblVisHora.AutoSize = true;
            this.lblVisHora.Location = new System.Drawing.Point(9, 95);
            this.lblVisHora.Name = "lblVisHora";
            this.lblVisHora.Size = new System.Drawing.Size(49, 16);
            this.lblVisHora.TabIndex = 3;
            this.lblVisHora.Text = "Horário:";
            // 
            // lblVisConsult
            // 
            this.lblVisConsult.AutoSize = true;
            this.lblVisConsult.Location = new System.Drawing.Point(9, 76);
            this.lblVisConsult.Name = "lblVisConsult";
            this.lblVisConsult.Size = new System.Drawing.Size(70, 16);
            this.lblVisConsult.TabIndex = 2;
            this.lblVisConsult.Text = "Consultório:";
            // 
            // lblVisCli
            // 
            this.lblVisCli.AutoSize = true;
            this.lblVisCli.Location = new System.Drawing.Point(9, 19);
            this.lblVisCli.Name = "lblVisCli";
            this.lblVisCli.Size = new System.Drawing.Size(49, 16);
            this.lblVisCli.TabIndex = 1;
            this.lblVisCli.Text = "Cliente:";
            // 
            // gbTratamento
            // 
            this.gbTratamento.Controls.Add(this.dtpData);
            this.gbTratamento.Controls.Add(this.lbData);
            this.gbTratamento.Controls.Add(this.gbHorário);
            this.gbTratamento.Controls.Add(this.cbTipoDeTratamento);
            this.gbTratamento.Controls.Add(this.cbMedicos);
            this.gbTratamento.Controls.Add(this.cbConsultorios);
            this.gbTratamento.Controls.Add(this.lblSelecConsult);
            this.gbTratamento.Controls.Add(this.lblMedico);
            this.gbTratamento.Controls.Add(this.lblSelecData);
            this.gbTratamento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTratamento.ForeColor = System.Drawing.Color.White;
            this.gbTratamento.Location = new System.Drawing.Point(15, 3);
            this.gbTratamento.Name = "gbTratamento";
            this.gbTratamento.Size = new System.Drawing.Size(471, 252);
            this.gbTratamento.TabIndex = 3;
            this.gbTratamento.TabStop = false;
            this.gbTratamento.Text = "Tratamento";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(48, 116);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(96, 21);
            this.dtpData.TabIndex = 12;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(6, 120);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(39, 16);
            this.lbData.TabIndex = 11;
            this.lbData.Text = "Data:";
            // 
            // gbHorário
            // 
            this.gbHorário.Controls.Add(this.cbHorarioFinal);
            this.gbHorário.Controls.Add(this.lblAs);
            this.gbHorário.Controls.Add(this.cbHorarioInicial);
            this.gbHorário.Controls.Add(this.rdbTarde);
            this.gbHorário.Controls.Add(this.rdbManha);
            this.gbHorário.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbHorário.ForeColor = System.Drawing.Color.White;
            this.gbHorário.Location = new System.Drawing.Point(3, 143);
            this.gbHorário.Name = "gbHorário";
            this.gbHorário.Size = new System.Drawing.Size(465, 106);
            this.gbHorário.TabIndex = 10;
            this.gbHorário.TabStop = false;
            this.gbHorário.Text = "Horário";
            // 
            // cbHorarioFinal
            // 
            this.cbHorarioFinal.DisplayMember = "Hora";
            this.cbHorarioFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorarioFinal.FormattingEnabled = true;
            this.cbHorarioFinal.Location = new System.Drawing.Point(248, 46);
            this.cbHorarioFinal.Name = "cbHorarioFinal";
            this.cbHorarioFinal.Size = new System.Drawing.Size(72, 24);
            this.cbHorarioFinal.TabIndex = 4;
            this.cbHorarioFinal.ValueMember = "data";
            // 
            // lblAs
            // 
            this.lblAs.AutoSize = true;
            this.lblAs.Location = new System.Drawing.Point(222, 50);
            this.lblAs.Name = "lblAs";
            this.lblAs.Size = new System.Drawing.Size(20, 16);
            this.lblAs.TabIndex = 3;
            this.lblAs.Text = "as";
            // 
            // cbHorarioInicial
            // 
            this.cbHorarioInicial.DisplayMember = "Hora";
            this.cbHorarioInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorarioInicial.FormattingEnabled = true;
            this.cbHorarioInicial.Location = new System.Drawing.Point(144, 46);
            this.cbHorarioInicial.Name = "cbHorarioInicial";
            this.cbHorarioInicial.Size = new System.Drawing.Size(72, 24);
            this.cbHorarioInicial.TabIndex = 2;
            this.cbHorarioInicial.ValueMember = "data";
            this.cbHorarioInicial.SelectedIndexChanged += new System.EventHandler(this.cbHorarioInicial_SelectedIndexChanged);
            // 
            // rdbTarde
            // 
            this.rdbTarde.AutoSize = true;
            this.rdbTarde.Location = new System.Drawing.Point(245, 20);
            this.rdbTarde.Name = "rdbTarde";
            this.rdbTarde.Size = new System.Drawing.Size(57, 20);
            this.rdbTarde.TabIndex = 1;
            this.rdbTarde.Text = "Tarde";
            this.rdbTarde.UseVisualStyleBackColor = true;
            this.rdbTarde.CheckedChanged += new System.EventHandler(this.rdbTarde_CheckedChanged);
            // 
            // rdbManha
            // 
            this.rdbManha.AutoSize = true;
            this.rdbManha.Checked = true;
            this.rdbManha.Location = new System.Drawing.Point(172, 20);
            this.rdbManha.Name = "rdbManha";
            this.rdbManha.Size = new System.Drawing.Size(67, 20);
            this.rdbManha.TabIndex = 0;
            this.rdbManha.TabStop = true;
            this.rdbManha.Text = "Manhã";
            this.rdbManha.UseVisualStyleBackColor = true;
            this.rdbManha.CheckedChanged += new System.EventHandler(this.rdbManha_CheckedChanged);
            // 
            // cbTipoDeTratamento
            // 
            this.cbTipoDeTratamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDeTratamento.FormattingEnabled = true;
            this.cbTipoDeTratamento.Location = new System.Drawing.Point(124, 86);
            this.cbTipoDeTratamento.Name = "cbTipoDeTratamento";
            this.cbTipoDeTratamento.Size = new System.Drawing.Size(200, 24);
            this.cbTipoDeTratamento.TabIndex = 7;
            this.cbTipoDeTratamento.SelectedIndexChanged += new System.EventHandler(this.cbTipoDeTratamento_SelectedIndexChanged);
            // 
            // cbMedicos
            // 
            this.cbMedicos.DisplayMember = "nome do medico";
            this.cbMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedicos.FormattingEnabled = true;
            this.cbMedicos.Location = new System.Drawing.Point(65, 27);
            this.cbMedicos.Name = "cbMedicos";
            this.cbMedicos.Size = new System.Drawing.Size(259, 24);
            this.cbMedicos.TabIndex = 5;
            this.cbMedicos.ValueMember = "id medico";
            this.cbMedicos.SelectedIndexChanged += new System.EventHandler(this.cbMedicos_SelectedIndexChanged);
            // 
            // cbConsultorios
            // 
            this.cbConsultorios.DisplayMember = "Nome";
            this.cbConsultorios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsultorios.FormattingEnabled = true;
            this.cbConsultorios.Location = new System.Drawing.Point(82, 57);
            this.cbConsultorios.Name = "cbConsultorios";
            this.cbConsultorios.Size = new System.Drawing.Size(242, 24);
            this.cbConsultorios.TabIndex = 4;
            this.cbConsultorios.ValueMember = "id";
            this.cbConsultorios.SelectedIndexChanged += new System.EventHandler(this.cbConsultorios_SelectedIndexChanged);
            // 
            // lblSelecConsult
            // 
            this.lblSelecConsult.AutoSize = true;
            this.lblSelecConsult.Location = new System.Drawing.Point(6, 60);
            this.lblSelecConsult.Name = "lblSelecConsult";
            this.lblSelecConsult.Size = new System.Drawing.Size(70, 16);
            this.lblSelecConsult.TabIndex = 2;
            this.lblSelecConsult.Text = "Consultório:";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(6, 30);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(53, 16);
            this.lblMedico.TabIndex = 1;
            this.lblMedico.Text = "Médico:";
            // 
            // lblSelecData
            // 
            this.lblSelecData.AutoSize = true;
            this.lblSelecData.Location = new System.Drawing.Point(6, 90);
            this.lblSelecData.Name = "lblSelecData";
            this.lblSelecData.Size = new System.Drawing.Size(116, 16);
            this.lblSelecData.TabIndex = 0;
            this.lblSelecData.Text = "Tipo de tratamento:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(489, 172);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(177, 65);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControlAgendarProximoTratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.bgVisualizacao);
            this.Controls.Add(this.gbTratamento);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "userControlAgendarProximoTratamento";
            this.Size = new System.Drawing.Size(672, 409);
            this.bgVisualizacao.ResumeLayout(false);
            this.bgVisualizacao.PerformLayout();
            this.gbTratamento.ResumeLayout(false);
            this.gbTratamento.PerformLayout();
            this.gbHorário.ResumeLayout(false);
            this.gbHorário.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bgVisualizacao;
        private System.Windows.Forms.Label lblValorPorSessao;
        private System.Windows.Forms.Label lblValortotal;
        private System.Windows.Forms.Label lblVisQtde;
        private System.Windows.Forms.Label lblVisTipo;
        private System.Windows.Forms.Label lblVisMedic;
        private System.Windows.Forms.Label lblVisHora;
        private System.Windows.Forms.Label lblVisConsult;
        private System.Windows.Forms.Label lblVisCli;
        private System.Windows.Forms.GroupBox gbTratamento;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.GroupBox gbHorário;
        private System.Windows.Forms.ComboBox cbHorarioFinal;
        private System.Windows.Forms.Label lblAs;
        private System.Windows.Forms.ComboBox cbHorarioInicial;
        private System.Windows.Forms.RadioButton rdbTarde;
        private System.Windows.Forms.RadioButton rdbManha;
        private System.Windows.Forms.ComboBox cbTipoDeTratamento;
        private System.Windows.Forms.ComboBox cbMedicos;
        private System.Windows.Forms.ComboBox cbConsultorios;
        private System.Windows.Forms.Label lblSelecConsult;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblSelecData;
        private System.Windows.Forms.Button btnSalvar;
    }
}
