namespace SisClinica.Forms
{
    partial class userControlAgendarTratamento
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
            this.components = new System.ComponentModel.Container();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.cbMedicos = new System.Windows.Forms.ComboBox();
            this.cbConsultorios = new System.Windows.Forms.ComboBox();
            this.lblSelecConsult = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.gbTratamento = new System.Windows.Forms.GroupBox();
            this.checkPago = new System.Windows.Forms.CheckBox();
            this.mtbQtdeSessoes = new System.Windows.Forms.MaskedTextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gbHorário = new System.Windows.Forms.GroupBox();
            this.cbHorarioFinal = new System.Windows.Forms.ComboBox();
            this.lblAs = new System.Windows.Forms.Label();
            this.cbHorarioInicial = new System.Windows.Forms.ComboBox();
            this.rdbTarde = new System.Windows.Forms.RadioButton();
            this.rdbManha = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoDeTratamento = new System.Windows.Forms.ComboBox();
            this.lblSelecData = new System.Windows.Forms.Label();
            this.btnCadastrarCli = new System.Windows.Forms.Button();
            this.txtbNomeCli = new System.Windows.Forms.TextBox();
            this.lblNomePesq = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bgVisualizacao = new System.Windows.Forms.GroupBox();
            this.lblValorPorSessao = new System.Windows.Forms.Label();
            this.lblValortotal = new System.Windows.Forms.Label();
            this.lblVisQtde = new System.Windows.Forms.Label();
            this.lblVisTipo = new System.Windows.Forms.Label();
            this.lblVisMedic = new System.Windows.Forms.Label();
            this.lblVisHora = new System.Windows.Forms.Label();
            this.lblVisConsult = new System.Windows.Forms.Label();
            this.lblVisCli = new System.Windows.Forms.Label();
            this.lblVisData = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.gbTratamento.SuspendLayout();
            this.gbHorário.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bgVisualizacao.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::SisClinica.Properties.Resources.btnPesquisarResp1;
            this.btnPesquisar.Location = new System.Drawing.Point(294, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(30, 30);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Cursor = System.Windows.Forms.Cursors.Help;
            this.dtgClientes.Location = new System.Drawing.Point(9, 57);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.Size = new System.Drawing.Size(315, 108);
            this.dtgClientes.TabIndex = 3;
            this.ttHelp.SetToolTip(this.dtgClientes, "Duplo clique para selecionar o cliente.");
            this.dtgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellClick);
            // 
            // cbMedicos
            // 
            this.cbMedicos.DisplayMember = "nome do medico";
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
            // gbTratamento
            // 
            this.gbTratamento.Controls.Add(this.checkPago);
            this.gbTratamento.Controls.Add(this.mtbQtdeSessoes);
            this.gbTratamento.Controls.Add(this.dtpData);
            this.gbTratamento.Controls.Add(this.label2);
            this.gbTratamento.Controls.Add(this.gbHorário);
            this.gbTratamento.Controls.Add(this.label1);
            this.gbTratamento.Controls.Add(this.cbTipoDeTratamento);
            this.gbTratamento.Controls.Add(this.cbMedicos);
            this.gbTratamento.Controls.Add(this.cbConsultorios);
            this.gbTratamento.Controls.Add(this.lblSelecConsult);
            this.gbTratamento.Controls.Add(this.lblMedico);
            this.gbTratamento.Controls.Add(this.lblSelecData);
            this.gbTratamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTratamento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTratamento.Location = new System.Drawing.Point(339, 3);
            this.gbTratamento.Name = "gbTratamento";
            this.gbTratamento.Size = new System.Drawing.Size(330, 252);
            this.gbTratamento.TabIndex = 1;
            this.gbTratamento.TabStop = false;
            this.gbTratamento.Text = "Tratamento";
            // 
            // checkPago
            // 
            this.checkPago.AutoSize = true;
            this.checkPago.Location = new System.Drawing.Point(194, 145);
            this.checkPago.Name = "checkPago";
            this.checkPago.Size = new System.Drawing.Size(130, 20);
            this.checkPago.TabIndex = 14;
            this.checkPago.Text = "Pago previamente";
            this.checkPago.UseVisualStyleBackColor = true;
            // 
            // mtbQtdeSessoes
            // 
            this.mtbQtdeSessoes.Location = new System.Drawing.Point(148, 117);
            this.mtbQtdeSessoes.Mask = "00";
            this.mtbQtdeSessoes.Name = "mtbQtdeSessoes";
            this.mtbQtdeSessoes.Size = new System.Drawing.Size(22, 21);
            this.mtbQtdeSessoes.TabIndex = 13;
            this.mtbQtdeSessoes.Leave += new System.EventHandler(this.mtbQtdeSessoes_Leave);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(48, 145);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(96, 21);
            this.dtpData.TabIndex = 12;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data:";
            // 
            // gbHorário
            // 
            this.gbHorário.Controls.Add(this.cbHorarioFinal);
            this.gbHorário.Controls.Add(this.lblAs);
            this.gbHorário.Controls.Add(this.cbHorarioInicial);
            this.gbHorário.Controls.Add(this.rdbTarde);
            this.gbHorário.Controls.Add(this.rdbManha);
            this.gbHorário.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbHorário.Location = new System.Drawing.Point(3, 170);
            this.gbHorário.Name = "gbHorário";
            this.gbHorário.Size = new System.Drawing.Size(324, 79);
            this.gbHorário.TabIndex = 10;
            this.gbHorário.TabStop = false;
            this.gbHorário.Text = "Horário";
            // 
            // cbHorarioFinal
            // 
            this.cbHorarioFinal.DisplayMember = "Hora";
            this.cbHorarioFinal.FormattingEnabled = true;
            this.cbHorarioFinal.Location = new System.Drawing.Point(173, 46);
            this.cbHorarioFinal.Name = "cbHorarioFinal";
            this.cbHorarioFinal.Size = new System.Drawing.Size(72, 24);
            this.cbHorarioFinal.TabIndex = 4;
            this.cbHorarioFinal.ValueMember = "data";
            this.cbHorarioFinal.SelectedIndexChanged += new System.EventHandler(this.cbHorarioFinal_SelectedIndexChanged);
            // 
            // lblAs
            // 
            this.lblAs.AutoSize = true;
            this.lblAs.Location = new System.Drawing.Point(147, 50);
            this.lblAs.Name = "lblAs";
            this.lblAs.Size = new System.Drawing.Size(20, 16);
            this.lblAs.TabIndex = 3;
            this.lblAs.Text = "as";
            // 
            // cbHorarioInicial
            // 
            this.cbHorarioInicial.DisplayMember = "Hora";
            this.cbHorarioInicial.FormattingEnabled = true;
            this.cbHorarioInicial.Location = new System.Drawing.Point(69, 46);
            this.cbHorarioInicial.Name = "cbHorarioInicial";
            this.cbHorarioInicial.Size = new System.Drawing.Size(72, 24);
            this.cbHorarioInicial.TabIndex = 2;
            this.cbHorarioInicial.ValueMember = "data";
            this.cbHorarioInicial.SelectedIndexChanged += new System.EventHandler(this.cbHorarioInicial_SelectedIndexChanged);
            // 
            // rdbTarde
            // 
            this.rdbTarde.AutoSize = true;
            this.rdbTarde.Location = new System.Drawing.Point(170, 20);
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
            this.rdbManha.Location = new System.Drawing.Point(97, 20);
            this.rdbManha.Name = "rdbManha";
            this.rdbManha.Size = new System.Drawing.Size(67, 20);
            this.rdbManha.TabIndex = 0;
            this.rdbManha.TabStop = true;
            this.rdbManha.Text = "Manhã";
            this.rdbManha.UseVisualStyleBackColor = true;
            this.rdbManha.CheckedChanged += new System.EventHandler(this.rdbManha_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantidade de sessões:";
            // 
            // cbTipoDeTratamento
            // 
            this.cbTipoDeTratamento.FormattingEnabled = true;
            this.cbTipoDeTratamento.Location = new System.Drawing.Point(124, 86);
            this.cbTipoDeTratamento.Name = "cbTipoDeTratamento";
            this.cbTipoDeTratamento.Size = new System.Drawing.Size(200, 24);
            this.cbTipoDeTratamento.TabIndex = 7;
            this.cbTipoDeTratamento.SelectedIndexChanged += new System.EventHandler(this.cbTipoDeTratamento_SelectedIndexChanged);
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
            // btnCadastrarCli
            // 
            this.btnCadastrarCli.Location = new System.Drawing.Point(108, 192);
            this.btnCadastrarCli.Name = "btnCadastrarCli";
            this.btnCadastrarCli.Size = new System.Drawing.Size(110, 23);
            this.btnCadastrarCli.TabIndex = 4;
            this.btnCadastrarCli.Text = "Cadastrar Novo";
            this.btnCadastrarCli.UseVisualStyleBackColor = true;
            this.btnCadastrarCli.Click += new System.EventHandler(this.btnCadastrarCli_Click);
            // 
            // txtbNomeCli
            // 
            this.txtbNomeCli.Location = new System.Drawing.Point(55, 35);
            this.txtbNomeCli.Name = "txtbNomeCli";
            this.txtbNomeCli.Size = new System.Drawing.Size(233, 21);
            this.txtbNomeCli.TabIndex = 1;
            // 
            // lblNomePesq
            // 
            this.lblNomePesq.AutoSize = true;
            this.lblNomePesq.Location = new System.Drawing.Point(6, 38);
            this.lblNomePesq.Name = "lblNomePesq";
            this.lblNomePesq.Size = new System.Drawing.Size(43, 16);
            this.lblNomePesq.TabIndex = 0;
            this.lblNomePesq.Text = "Nome:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbCliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbTratamento, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 258);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnCadastrarCli);
            this.gbCliente.Controls.Add(this.dtgClientes);
            this.gbCliente.Controls.Add(this.btnPesquisar);
            this.gbCliente.Controls.Add(this.txtbNomeCli);
            this.gbCliente.Controls.Add(this.lblNomePesq);
            this.gbCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(3, 3);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(330, 252);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bgVisualizacao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 151);
            this.panel1.TabIndex = 4;
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
            this.bgVisualizacao.Controls.Add(this.lblVisData);
            this.bgVisualizacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgVisualizacao.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgVisualizacao.Location = new System.Drawing.Point(0, 0);
            this.bgVisualizacao.Name = "bgVisualizacao";
            this.bgVisualizacao.Size = new System.Drawing.Size(483, 151);
            this.bgVisualizacao.TabIndex = 2;
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
            this.lblVisQtde.Location = new System.Drawing.Point(9, 115);
            this.lblVisQtde.Name = "lblVisQtde";
            this.lblVisQtde.Size = new System.Drawing.Size(138, 16);
            this.lblVisQtde.TabIndex = 6;
            this.lblVisQtde.Text = "Quantidade de sessôes:";
            // 
            // lblVisTipo
            // 
            this.lblVisTipo.AutoSize = true;
            this.lblVisTipo.Location = new System.Drawing.Point(9, 51);
            this.lblVisTipo.Name = "lblVisTipo";
            this.lblVisTipo.Size = new System.Drawing.Size(116, 16);
            this.lblVisTipo.TabIndex = 5;
            this.lblVisTipo.Text = "Tipo de tratamento:";
            // 
            // lblVisMedic
            // 
            this.lblVisMedic.AutoSize = true;
            this.lblVisMedic.Location = new System.Drawing.Point(9, 35);
            this.lblVisMedic.Name = "lblVisMedic";
            this.lblVisMedic.Size = new System.Drawing.Size(125, 16);
            this.lblVisMedic.TabIndex = 4;
            this.lblVisMedic.Text = "Médico Responsável:";
            // 
            // lblVisHora
            // 
            this.lblVisHora.AutoSize = true;
            this.lblVisHora.Location = new System.Drawing.Point(9, 99);
            this.lblVisHora.Name = "lblVisHora";
            this.lblVisHora.Size = new System.Drawing.Size(49, 16);
            this.lblVisHora.TabIndex = 3;
            this.lblVisHora.Text = "Horário:";
            // 
            // lblVisConsult
            // 
            this.lblVisConsult.AutoSize = true;
            this.lblVisConsult.Location = new System.Drawing.Point(9, 67);
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
            // lblVisData
            // 
            this.lblVisData.AutoSize = true;
            this.lblVisData.Location = new System.Drawing.Point(9, 83);
            this.lblVisData.Name = "lblVisData";
            this.lblVisData.Size = new System.Drawing.Size(167, 16);
            this.lblVisData.TabIndex = 0;
            this.lblVisData.Text = "Data do primeiro tratamento:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(492, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 151);
            this.panel2.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::SisClinica.Properties.Resources.btnSave;
            this.btnSalvar.Location = new System.Drawing.Point(23, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(144, 124);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // userControlAgendarTratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "userControlAgendarTratamento";
            this.Size = new System.Drawing.Size(672, 409);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.gbTratamento.ResumeLayout(false);
            this.gbTratamento.PerformLayout();
            this.gbHorário.ResumeLayout(false);
            this.gbHorário.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.bgVisualizacao.ResumeLayout(false);
            this.bgVisualizacao.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ToolTip ttHelp;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.ComboBox cbMedicos;
        private System.Windows.Forms.ComboBox cbConsultorios;
        private System.Windows.Forms.Label lblSelecConsult;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.GroupBox gbTratamento;
        private System.Windows.Forms.ComboBox cbTipoDeTratamento;
        private System.Windows.Forms.Label lblSelecData;
        private System.Windows.Forms.Button btnCadastrarCli;
        private System.Windows.Forms.TextBox txtbNomeCli;
        private System.Windows.Forms.Label lblNomePesq;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbHorário;
        private System.Windows.Forms.ComboBox cbHorarioFinal;
        private System.Windows.Forms.Label lblAs;
        private System.Windows.Forms.ComboBox cbHorarioInicial;
        private System.Windows.Forms.RadioButton rdbTarde;
        private System.Windows.Forms.RadioButton rdbManha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox bgVisualizacao;
        private System.Windows.Forms.Label lblVisMedic;
        private System.Windows.Forms.Label lblVisHora;
        private System.Windows.Forms.Label lblVisConsult;
        private System.Windows.Forms.Label lblVisCli;
        private System.Windows.Forms.Label lblVisData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVisQtde;
        private System.Windows.Forms.Label lblVisTipo;
        private System.Windows.Forms.MaskedTextBox mtbQtdeSessoes;
        private System.Windows.Forms.CheckBox checkPago;
        private System.Windows.Forms.Label lblValorPorSessao;
        private System.Windows.Forms.Label lblValortotal;
    }
}
