namespace SisClinica.Forms
{
    partial class userControlAgendarConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnCadastrarCli = new System.Windows.Forms.Button();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtbNomeCli = new System.Windows.Forms.TextBox();
            this.lblNomePesq = new System.Windows.Forms.Label();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.gbHorário = new System.Windows.Forms.GroupBox();
            this.cbHorarioFinal = new System.Windows.Forms.ComboBox();
            this.lblAs = new System.Windows.Forms.Label();
            this.cbHorarioInicial = new System.Windows.Forms.ComboBox();
            this.rdbTarde = new System.Windows.Forms.RadioButton();
            this.rdbManha = new System.Windows.Forms.RadioButton();
            this.cbMedicos = new System.Windows.Forms.ComboBox();
            this.cbConsultorios = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblSelecConsult = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblSelecData = new System.Windows.Forms.Label();
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bgVisualizacao = new System.Windows.Forms.GroupBox();
            this.lblVisMedic = new System.Windows.Forms.Label();
            this.lblVisHora = new System.Windows.Forms.Label();
            this.lblVisConsult = new System.Windows.Forms.Label();
            this.lblVisCli = new System.Windows.Forms.Label();
            this.lblVisData = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.gbConsulta.SuspendLayout();
            this.gbHorário.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bgVisualizacao.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbCliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbConsulta, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 237);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.gbCliente.ForeColor = System.Drawing.Color.White;
            this.gbCliente.Location = new System.Drawing.Point(3, 3);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(330, 231);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // btnCadastrarCli
            // 
            this.btnCadastrarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCli.Location = new System.Drawing.Point(108, 192);
            this.btnCadastrarCli.Name = "btnCadastrarCli";
            this.btnCadastrarCli.Size = new System.Drawing.Size(110, 23);
            this.btnCadastrarCli.TabIndex = 4;
            this.btnCadastrarCli.Text = "Cadastrar Novo";
            this.btnCadastrarCli.UseVisualStyleBackColor = true;
            this.btnCadastrarCli.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Cursor = System.Windows.Forms.Cursors.Help;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgClientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgClientes.Location = new System.Drawing.Point(9, 63);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.Size = new System.Drawing.Size(315, 102);
            this.dtgClientes.TabIndex = 3;
            this.ttHelp.SetToolTip(this.dtgClientes, "Duplo clique para selecionar o cliente.");
            this.dtgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellClick);
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
            this.lblNomePesq.ForeColor = System.Drawing.Color.White;
            this.lblNomePesq.Location = new System.Drawing.Point(6, 38);
            this.lblNomePesq.Name = "lblNomePesq";
            this.lblNomePesq.Size = new System.Drawing.Size(43, 16);
            this.lblNomePesq.TabIndex = 0;
            this.lblNomePesq.Text = "Nome:";
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.gbHorário);
            this.gbConsulta.Controls.Add(this.cbMedicos);
            this.gbConsulta.Controls.Add(this.cbConsultorios);
            this.gbConsulta.Controls.Add(this.dtpData);
            this.gbConsulta.Controls.Add(this.lblSelecConsult);
            this.gbConsulta.Controls.Add(this.lblMedico);
            this.gbConsulta.Controls.Add(this.lblSelecData);
            this.gbConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbConsulta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsulta.ForeColor = System.Drawing.Color.White;
            this.gbConsulta.Location = new System.Drawing.Point(339, 3);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(330, 231);
            this.gbConsulta.TabIndex = 1;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta";
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
            this.gbHorário.Location = new System.Drawing.Point(3, 128);
            this.gbHorário.Name = "gbHorário";
            this.gbHorário.Size = new System.Drawing.Size(324, 100);
            this.gbHorário.TabIndex = 6;
            this.gbHorário.TabStop = false;
            this.gbHorário.Text = "Horário";
            // 
            // cbHorarioFinal
            // 
            this.cbHorarioFinal.DisplayMember = "Hora";
            this.cbHorarioFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorarioFinal.FormattingEnabled = true;
            this.cbHorarioFinal.Location = new System.Drawing.Point(178, 55);
            this.cbHorarioFinal.Name = "cbHorarioFinal";
            this.cbHorarioFinal.Size = new System.Drawing.Size(72, 24);
            this.cbHorarioFinal.TabIndex = 4;
            this.cbHorarioFinal.ValueMember = "data";
            this.cbHorarioFinal.SelectedIndexChanged += new System.EventHandler(this.cbHorarioFinal_SelectedIndexChanged);
            // 
            // lblAs
            // 
            this.lblAs.AutoSize = true;
            this.lblAs.Location = new System.Drawing.Point(152, 59);
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
            this.cbHorarioInicial.Location = new System.Drawing.Point(74, 55);
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
            // cbMedicos
            // 
            this.cbMedicos.DisplayMember = "nome do medico";
            this.cbMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedicos.FormattingEnabled = true;
            this.cbMedicos.Location = new System.Drawing.Point(110, 63);
            this.cbMedicos.Name = "cbMedicos";
            this.cbMedicos.Size = new System.Drawing.Size(200, 24);
            this.cbMedicos.TabIndex = 5;
            this.cbMedicos.ValueMember = "id medico";
            this.cbMedicos.SelectedIndexChanged += new System.EventHandler(this.cbMedicos_SelectedIndexChanged);
            // 
            // cbConsultorios
            // 
            this.cbConsultorios.DisplayMember = "Nome";
            this.cbConsultorios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsultorios.FormattingEnabled = true;
            this.cbConsultorios.Location = new System.Drawing.Point(110, 93);
            this.cbConsultorios.Name = "cbConsultorios";
            this.cbConsultorios.Size = new System.Drawing.Size(200, 24);
            this.cbConsultorios.TabIndex = 4;
            this.cbConsultorios.ValueMember = "id";
            this.cbConsultorios.SelectedIndexChanged += new System.EventHandler(this.cbConsultorios_SelectedIndexChanged);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(110, 36);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(99, 21);
            this.dtpData.TabIndex = 3;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // lblSelecConsult
            // 
            this.lblSelecConsult.AutoSize = true;
            this.lblSelecConsult.ForeColor = System.Drawing.Color.White;
            this.lblSelecConsult.Location = new System.Drawing.Point(34, 97);
            this.lblSelecConsult.Name = "lblSelecConsult";
            this.lblSelecConsult.Size = new System.Drawing.Size(70, 16);
            this.lblSelecConsult.TabIndex = 2;
            this.lblSelecConsult.Text = "Consultório:";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.ForeColor = System.Drawing.Color.White;
            this.lblMedico.Location = new System.Drawing.Point(51, 67);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(53, 16);
            this.lblMedico.TabIndex = 1;
            this.lblMedico.Text = "Médico:";
            // 
            // lblSelecData
            // 
            this.lblSelecData.AutoSize = true;
            this.lblSelecData.ForeColor = System.Drawing.Color.White;
            this.lblSelecData.Location = new System.Drawing.Point(6, 38);
            this.lblSelecData.Name = "lblSelecData";
            this.lblSelecData.Size = new System.Drawing.Size(98, 16);
            this.lblSelecData.TabIndex = 0;
            this.lblSelecData.Text = "Selecionar data:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bgVisualizacao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 172);
            this.panel1.TabIndex = 1;
            // 
            // bgVisualizacao
            // 
            this.bgVisualizacao.Controls.Add(this.lblVisMedic);
            this.bgVisualizacao.Controls.Add(this.lblVisHora);
            this.bgVisualizacao.Controls.Add(this.lblVisConsult);
            this.bgVisualizacao.Controls.Add(this.lblVisCli);
            this.bgVisualizacao.Controls.Add(this.lblVisData);
            this.bgVisualizacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgVisualizacao.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgVisualizacao.ForeColor = System.Drawing.Color.White;
            this.bgVisualizacao.Location = new System.Drawing.Point(0, 0);
            this.bgVisualizacao.Name = "bgVisualizacao";
            this.bgVisualizacao.Size = new System.Drawing.Size(333, 172);
            this.bgVisualizacao.TabIndex = 1;
            this.bgVisualizacao.TabStop = false;
            this.bgVisualizacao.Text = "Visualização";
            // 
            // lblVisMedic
            // 
            this.lblVisMedic.AutoSize = true;
            this.lblVisMedic.ForeColor = System.Drawing.Color.White;
            this.lblVisMedic.Location = new System.Drawing.Point(8, 88);
            this.lblVisMedic.Name = "lblVisMedic";
            this.lblVisMedic.Size = new System.Drawing.Size(125, 16);
            this.lblVisMedic.TabIndex = 4;
            this.lblVisMedic.Text = "Médico Responsável:";
            // 
            // lblVisHora
            // 
            this.lblVisHora.AutoSize = true;
            this.lblVisHora.ForeColor = System.Drawing.Color.White;
            this.lblVisHora.Location = new System.Drawing.Point(8, 115);
            this.lblVisHora.Name = "lblVisHora";
            this.lblVisHora.Size = new System.Drawing.Size(49, 16);
            this.lblVisHora.TabIndex = 3;
            this.lblVisHora.Text = "Horário:";
            // 
            // lblVisConsult
            // 
            this.lblVisConsult.AutoSize = true;
            this.lblVisConsult.ForeColor = System.Drawing.Color.White;
            this.lblVisConsult.Location = new System.Drawing.Point(8, 142);
            this.lblVisConsult.Name = "lblVisConsult";
            this.lblVisConsult.Size = new System.Drawing.Size(70, 16);
            this.lblVisConsult.TabIndex = 2;
            this.lblVisConsult.Text = "Consultório:";
            // 
            // lblVisCli
            // 
            this.lblVisCli.AutoSize = true;
            this.lblVisCli.ForeColor = System.Drawing.Color.White;
            this.lblVisCli.Location = new System.Drawing.Point(8, 34);
            this.lblVisCli.Name = "lblVisCli";
            this.lblVisCli.Size = new System.Drawing.Size(49, 16);
            this.lblVisCli.TabIndex = 1;
            this.lblVisCli.Text = "Cliente:";
            // 
            // lblVisData
            // 
            this.lblVisData.AutoSize = true;
            this.lblVisData.ForeColor = System.Drawing.Color.White;
            this.lblVisData.Location = new System.Drawing.Point(8, 61);
            this.lblVisData.Name = "lblVisData";
            this.lblVisData.Size = new System.Drawing.Size(109, 16);
            this.lblVisData.TabIndex = 0;
            this.lblVisData.Text = "Data da Consulta:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(333, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 172);
            this.panel2.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(97, 43);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(144, 69);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // userControlAgendarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "userControlAgendarConsulta";
            this.Size = new System.Drawing.Size(672, 409);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            this.gbHorário.ResumeLayout(false);
            this.gbHorário.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.bgVisualizacao.ResumeLayout(false);
            this.bgVisualizacao.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtbNomeCli;
        private System.Windows.Forms.Label lblNomePesq;
        private System.Windows.Forms.Button btnCadastrarCli;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.ToolTip ttHelp;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblSelecData;
        private System.Windows.Forms.Label lblSelecConsult;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cbMedicos;
        private System.Windows.Forms.ComboBox cbConsultorios;
        private System.Windows.Forms.GroupBox gbHorário;
        private System.Windows.Forms.RadioButton rdbTarde;
        private System.Windows.Forms.RadioButton rdbManha;
        private System.Windows.Forms.ComboBox cbHorarioInicial;
        private System.Windows.Forms.ComboBox cbHorarioFinal;
        private System.Windows.Forms.Label lblAs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox bgVisualizacao;
        private System.Windows.Forms.Label lblVisMedic;
        private System.Windows.Forms.Label lblVisHora;
        private System.Windows.Forms.Label lblVisConsult;
        private System.Windows.Forms.Label lblVisCli;
        private System.Windows.Forms.Label lblVisData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvar;
    }
}
