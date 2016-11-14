namespace SisClinica.Forms
{
    partial class userControlAlterarSessoes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.btnDtgPesq = new System.Windows.Forms.Button();
            this.txtbNomePesquisa = new System.Windows.Forms.TextBox();
            this.lblNomePesq = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cbConsultorios = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSelecConsult = new System.Windows.Forms.Label();
            this.cbHorarioFinal = new System.Windows.Forms.ComboBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblAs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHorarioInicial = new System.Windows.Forms.ComboBox();
            this.lblSelecData = new System.Windows.Forms.Label();
            this.rdbTarde = new System.Windows.Forms.RadioButton();
            this.cbMedicos = new System.Windows.Forms.ComboBox();
            this.rdbManha = new System.Windows.Forms.RadioButton();
            this.txtbNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblTipoSessao = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblvalortotal = new System.Windows.Forms.Label();
            this.lblValorSessao = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalSessao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalSessao);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblValorSessao);
            this.panel1.Controls.Add(this.lblvalortotal);
            this.panel1.Controls.Add(this.gbPesquisa);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.cbConsultorios);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpData);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblSelecConsult);
            this.panel1.Controls.Add(this.cbHorarioFinal);
            this.panel1.Controls.Add(this.lblMedico);
            this.panel1.Controls.Add(this.lblAs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbHorarioInicial);
            this.panel1.Controls.Add(this.lblSelecData);
            this.panel1.Controls.Add(this.rdbTarde);
            this.panel1.Controls.Add(this.cbMedicos);
            this.panel1.Controls.Add(this.rdbManha);
            this.panel1.Controls.Add(this.txtbNomeCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.lblTipoSessao);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.lblSituacao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 409);
            this.panel1.TabIndex = 32;
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Controls.Add(this.dtgClientes);
            this.gbPesquisa.Controls.Add(this.btnDtgPesq);
            this.gbPesquisa.Controls.Add(this.txtbNomePesquisa);
            this.gbPesquisa.Controls.Add(this.lblNomePesq);
            this.gbPesquisa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesquisa.Location = new System.Drawing.Point(40, 12);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(406, 151);
            this.gbPesquisa.TabIndex = 22;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Pesquisar Cliente";
            this.gbPesquisa.Visible = false;
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(62, 55);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.Size = new System.Drawing.Size(315, 89);
            this.dtgClientes.TabIndex = 19;
            this.dtgClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellContentDoubleClick);
            // 
            // btnDtgPesq
            // 
            this.btnDtgPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDtgPesq.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDtgPesq.Image = global::SisClinica.Properties.Resources.btnPesquisarResp1;
            this.btnDtgPesq.Location = new System.Drawing.Point(332, 17);
            this.btnDtgPesq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDtgPesq.Name = "btnDtgPesq";
            this.btnDtgPesq.Size = new System.Drawing.Size(44, 37);
            this.btnDtgPesq.TabIndex = 18;
            this.btnDtgPesq.UseVisualStyleBackColor = true;
            this.btnDtgPesq.Click += new System.EventHandler(this.btnDtgPesq_Click);
            // 
            // txtbNomePesquisa
            // 
            this.txtbNomePesquisa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNomePesquisa.Location = new System.Drawing.Point(62, 25);
            this.txtbNomePesquisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNomePesquisa.Name = "txtbNomePesquisa";
            this.txtbNomePesquisa.Size = new System.Drawing.Size(262, 22);
            this.txtbNomePesquisa.TabIndex = 16;
            // 
            // lblNomePesq
            // 
            this.lblNomePesq.AutoSize = true;
            this.lblNomePesq.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePesq.Location = new System.Drawing.Point(8, 28);
            this.lblNomePesq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePesq.Name = "lblNomePesq";
            this.lblNomePesq.Size = new System.Drawing.Size(47, 17);
            this.lblNomePesq.TabIndex = 15;
            this.lblNomePesq.Text = "Nome:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(519, 252);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(120, 58);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "Deletar";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cbConsultorios
            // 
            this.cbConsultorios.DisplayMember = "Nome";
            this.cbConsultorios.Enabled = false;
            this.cbConsultorios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConsultorios.FormattingEnabled = true;
            this.cbConsultorios.Location = new System.Drawing.Point(118, 305);
            this.cbConsultorios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbConsultorios.Name = "cbConsultorios";
            this.cbConsultorios.Size = new System.Drawing.Size(298, 25);
            this.cbConsultorios.TabIndex = 4;
            this.cbConsultorios.ValueMember = "id";
            this.cbConsultorios.SelectedIndexChanged += new System.EventHandler(this.cbConsultorios_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 372);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Horário:";
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(120, 247);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(146, 22);
            this.dtpData.TabIndex = 3;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Turno:";
            // 
            // lblSelecConsult
            // 
            this.lblSelecConsult.AutoSize = true;
            this.lblSelecConsult.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecConsult.Location = new System.Drawing.Point(34, 308);
            this.lblSelecConsult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecConsult.Name = "lblSelecConsult";
            this.lblSelecConsult.Size = new System.Drawing.Size(78, 17);
            this.lblSelecConsult.TabIndex = 2;
            this.lblSelecConsult.Text = "Consultório:";
            // 
            // cbHorarioFinal
            // 
            this.cbHorarioFinal.DisplayMember = "Hora";
            this.cbHorarioFinal.Enabled = false;
            this.cbHorarioFinal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHorarioFinal.FormattingEnabled = true;
            this.cbHorarioFinal.Location = new System.Drawing.Point(237, 369);
            this.cbHorarioFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHorarioFinal.Name = "cbHorarioFinal";
            this.cbHorarioFinal.Size = new System.Drawing.Size(82, 25);
            this.cbHorarioFinal.TabIndex = 27;
            this.cbHorarioFinal.ValueMember = "data";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(56, 278);
            this.lblMedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(57, 17);
            this.lblMedico.TabIndex = 1;
            this.lblMedico.Text = "Médico:";
            // 
            // lblAs
            // 
            this.lblAs.AutoSize = true;
            this.lblAs.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAs.Location = new System.Drawing.Point(208, 378);
            this.lblAs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAs.Name = "lblAs";
            this.lblAs.Size = new System.Drawing.Size(21, 17);
            this.lblAs.TabIndex = 26;
            this.lblAs.Text = "as";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cliente:";
            // 
            // cbHorarioInicial
            // 
            this.cbHorarioInicial.DisplayMember = "Hora";
            this.cbHorarioInicial.Enabled = false;
            this.cbHorarioInicial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHorarioInicial.FormattingEnabled = true;
            this.cbHorarioInicial.Location = new System.Drawing.Point(118, 369);
            this.cbHorarioInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHorarioInicial.Name = "cbHorarioInicial";
            this.cbHorarioInicial.Size = new System.Drawing.Size(82, 25);
            this.cbHorarioInicial.TabIndex = 25;
            this.cbHorarioInicial.ValueMember = "data";
            this.cbHorarioInicial.SelectedIndexChanged += new System.EventHandler(this.cbHorarioInicial_SelectedIndexChanged);
            // 
            // lblSelecData
            // 
            this.lblSelecData.AutoSize = true;
            this.lblSelecData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecData.Location = new System.Drawing.Point(69, 252);
            this.lblSelecData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecData.Name = "lblSelecData";
            this.lblSelecData.Size = new System.Drawing.Size(41, 17);
            this.lblSelecData.TabIndex = 0;
            this.lblSelecData.Text = "Data:";
            // 
            // rdbTarde
            // 
            this.rdbTarde.AutoSize = true;
            this.rdbTarde.Enabled = false;
            this.rdbTarde.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTarde.Location = new System.Drawing.Point(194, 338);
            this.rdbTarde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbTarde.Name = "rdbTarde";
            this.rdbTarde.Size = new System.Drawing.Size(59, 21);
            this.rdbTarde.TabIndex = 24;
            this.rdbTarde.Text = "Tarde";
            this.rdbTarde.UseVisualStyleBackColor = true;
            this.rdbTarde.CheckedChanged += new System.EventHandler(this.rdbTarde_CheckedChanged);
            // 
            // cbMedicos
            // 
            this.cbMedicos.DisplayMember = "nome do medico";
            this.cbMedicos.Enabled = false;
            this.cbMedicos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedicos.FormattingEnabled = true;
            this.cbMedicos.Location = new System.Drawing.Point(118, 275);
            this.cbMedicos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMedicos.Name = "cbMedicos";
            this.cbMedicos.Size = new System.Drawing.Size(298, 25);
            this.cbMedicos.TabIndex = 5;
            this.cbMedicos.ValueMember = "id medico";
            this.cbMedicos.SelectedIndexChanged += new System.EventHandler(this.cbMedicos_SelectedIndexChanged);
            // 
            // rdbManha
            // 
            this.rdbManha.AutoSize = true;
            this.rdbManha.Checked = true;
            this.rdbManha.Enabled = false;
            this.rdbManha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbManha.Location = new System.Drawing.Point(118, 338);
            this.rdbManha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbManha.Name = "rdbManha";
            this.rdbManha.Size = new System.Drawing.Size(67, 21);
            this.rdbManha.TabIndex = 23;
            this.rdbManha.TabStop = true;
            this.rdbManha.Text = "Manhã";
            this.rdbManha.UseVisualStyleBackColor = true;
            this.rdbManha.CheckedChanged += new System.EventHandler(this.rdbManha_CheckedChanged);
            // 
            // txtbNomeCliente
            // 
            this.txtbNomeCliente.Enabled = false;
            this.txtbNomeCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNomeCliente.Location = new System.Drawing.Point(120, 218);
            this.txtbNomeCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNomeCliente.Name = "txtbNomeCliente";
            this.txtbNomeCliente.Size = new System.Drawing.Size(298, 22);
            this.txtbNomeCliente.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tipo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(519, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 58);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Situação:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(519, 188);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 58);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTipoSessao
            // 
            this.lblTipoSessao.AutoSize = true;
            this.lblTipoSessao.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoSessao.Location = new System.Drawing.Point(117, 168);
            this.lblTipoSessao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoSessao.Name = "lblTipoSessao";
            this.lblTipoSessao.Size = new System.Drawing.Size(32, 17);
            this.lblTipoSessao.TabIndex = 17;
            this.lblTipoSessao.Text = "tipo";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(519, 122);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(120, 58);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(117, 195);
            this.lblSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(60, 17);
            this.lblSituacao.TabIndex = 18;
            this.lblSituacao.Text = "situação";
            // 
            // lblvalortotal
            // 
            this.lblvalortotal.AutoSize = true;
            this.lblvalortotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalortotal.Location = new System.Drawing.Point(289, 166);
            this.lblvalortotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalortotal.Name = "lblvalortotal";
            this.lblvalortotal.Size = new System.Drawing.Size(75, 17);
            this.lblvalortotal.TabIndex = 31;
            this.lblvalortotal.Text = "Valor total:";
            this.lblvalortotal.Visible = false;
            // 
            // lblValorSessao
            // 
            this.lblValorSessao.AutoSize = true;
            this.lblValorSessao.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSessao.Location = new System.Drawing.Point(256, 195);
            this.lblValorSessao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorSessao.Name = "lblValorSessao";
            this.lblValorSessao.Size = new System.Drawing.Size(108, 17);
            this.lblValorSessao.TabIndex = 32;
            this.lblValorSessao.Text = "Valor por sessão:";
            this.lblValorSessao.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(369, 166);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 17);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "total";
            this.lblTotal.Visible = false;
            // 
            // lblTotalSessao
            // 
            this.lblTotalSessao.AutoSize = true;
            this.lblTotalSessao.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSessao.Location = new System.Drawing.Point(369, 195);
            this.lblTotalSessao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSessao.Name = "lblTotalSessao";
            this.lblTotalSessao.Size = new System.Drawing.Size(78, 17);
            this.lblTotalSessao.TabIndex = 34;
            this.lblTotalSessao.Text = "valorsessao";
            this.lblTotalSessao.Visible = false;
            // 
            // userControlAlterarSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "userControlAlterarSessoes";
            this.Size = new System.Drawing.Size(672, 409);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbPesquisa;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Button btnDtgPesq;
        private System.Windows.Forms.TextBox txtbNomePesquisa;
        private System.Windows.Forms.Label lblNomePesq;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cbConsultorios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSelecConsult;
        private System.Windows.Forms.ComboBox cbHorarioFinal;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblAs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHorarioInicial;
        private System.Windows.Forms.Label lblSelecData;
        private System.Windows.Forms.RadioButton rdbTarde;
        private System.Windows.Forms.ComboBox cbMedicos;
        private System.Windows.Forms.RadioButton rdbManha;
        private System.Windows.Forms.TextBox txtbNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTipoSessao;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblTotalSessao;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValorSessao;
        private System.Windows.Forms.Label lblvalortotal;
    }
}
