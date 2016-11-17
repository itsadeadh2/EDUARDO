namespace SisClinica.Forms
{
    partial class userControlRegistraCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbDadosDoCliente = new System.Windows.Forms.GroupBox();
            this.ptErrorNomeCli = new System.Windows.Forms.PictureBox();
            this.lbInfoAdicional = new System.Windows.Forms.Label();
            this.rtbAdicionalInfo = new System.Windows.Forms.RichTextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.txtbEndereco = new System.Windows.Forms.TextBox();
            this.txtbemail = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEmailCliente = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbTelefoneCliente = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.lbDataNascimentoCliente = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lbCpfCliente = new System.Windows.Forms.Label();
            this.txtbNomeCompletoCli = new System.Windows.Forms.TextBox();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.gbDadosDoResponsavel = new System.Windows.Forms.GroupBox();
            this.btnClearPesquisa = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtgResponsavel = new System.Windows.Forms.DataGridView();
            this.txtbNomeRespPesquisa = new System.Windows.Forms.TextBox();
            this.lblNomePesquisa = new System.Windows.Forms.Label();
            this.lbPesquisa = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtbEmailResp = new System.Windows.Forms.TextBox();
            this.lbEmailResponsavel = new System.Windows.Forms.Label();
            this.mtbTelefoneResp = new System.Windows.Forms.MaskedTextBox();
            this.lbTelefoneResponsavel = new System.Windows.Forms.Label();
            this.dtpDataNascResp = new System.Windows.Forms.DateTimePicker();
            this.lbDataNascimentoResponsavel = new System.Windows.Forms.Label();
            this.mtbCpfResp = new System.Windows.Forms.MaskedTextBox();
            this.lbCpfResponsavel = new System.Windows.Forms.Label();
            this.txtbNomeResp = new System.Windows.Forms.TextBox();
            this.lbNomeResponsavel = new System.Windows.Forms.Label();
            this.ttpErrors = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.gbDadosDoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptErrorNomeCli)).BeginInit();
            this.gbDadosDoResponsavel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResponsavel)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.44643F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.55357F));
            this.tableLayoutPanel1.Controls.Add(this.gbDadosDoCliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbDadosDoResponsavel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbDadosDoCliente
            // 
            this.gbDadosDoCliente.Controls.Add(this.ptErrorNomeCli);
            this.gbDadosDoCliente.Controls.Add(this.lbInfoAdicional);
            this.gbDadosDoCliente.Controls.Add(this.rtbAdicionalInfo);
            this.gbDadosDoCliente.Controls.Add(this.cbEstado);
            this.gbDadosDoCliente.Controls.Add(this.cbCidade);
            this.gbDadosDoCliente.Controls.Add(this.txtbEndereco);
            this.gbDadosDoCliente.Controls.Add(this.txtbemail);
            this.gbDadosDoCliente.Controls.Add(this.lbEstado);
            this.gbDadosDoCliente.Controls.Add(this.lbCidade);
            this.gbDadosDoCliente.Controls.Add(this.label6);
            this.gbDadosDoCliente.Controls.Add(this.lbEmailCliente);
            this.gbDadosDoCliente.Controls.Add(this.mtbTelefone);
            this.gbDadosDoCliente.Controls.Add(this.lbTelefoneCliente);
            this.gbDadosDoCliente.Controls.Add(this.dtpDataNasc);
            this.gbDadosDoCliente.Controls.Add(this.lbDataNascimentoCliente);
            this.gbDadosDoCliente.Controls.Add(this.mtbCpf);
            this.gbDadosDoCliente.Controls.Add(this.lbCpfCliente);
            this.gbDadosDoCliente.Controls.Add(this.txtbNomeCompletoCli);
            this.gbDadosDoCliente.Controls.Add(this.lbNomeCliente);
            this.gbDadosDoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDadosDoCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosDoCliente.ForeColor = System.Drawing.Color.White;
            this.gbDadosDoCliente.Location = new System.Drawing.Point(3, 3);
            this.gbDadosDoCliente.Name = "gbDadosDoCliente";
            this.gbDadosDoCliente.Size = new System.Drawing.Size(333, 403);
            this.gbDadosDoCliente.TabIndex = 0;
            this.gbDadosDoCliente.TabStop = false;
            this.gbDadosDoCliente.Text = "Dados do Cliente";
            // 
            // ptErrorNomeCli
            // 
            this.ptErrorNomeCli.Image = global::SisClinica.Properties.Resources.exclamation;
            this.ptErrorNomeCli.Location = new System.Drawing.Point(298, 31);
            this.ptErrorNomeCli.Name = "ptErrorNomeCli";
            this.ptErrorNomeCli.Size = new System.Drawing.Size(25, 25);
            this.ptErrorNomeCli.TabIndex = 20;
            this.ptErrorNomeCli.TabStop = false;
            this.ttpErrors.SetToolTip(this.ptErrorNomeCli, "Nome inválido, o nome precisa ser maior do que três caracteres.");
            this.ptErrorNomeCli.Visible = false;
            // 
            // lbInfoAdicional
            // 
            this.lbInfoAdicional.AutoSize = true;
            this.lbInfoAdicional.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoAdicional.Location = new System.Drawing.Point(8, 286);
            this.lbInfoAdicional.Name = "lbInfoAdicional";
            this.lbInfoAdicional.Size = new System.Drawing.Size(134, 16);
            this.lbInfoAdicional.TabIndex = 18;
            this.lbInfoAdicional.Text = "Informações Adicionais:";
            // 
            // rtbAdicionalInfo
            // 
            this.rtbAdicionalInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAdicionalInfo.Location = new System.Drawing.Point(11, 305);
            this.rtbAdicionalInfo.Name = "rtbAdicionalInfo";
            this.rtbAdicionalInfo.Size = new System.Drawing.Size(314, 92);
            this.rtbAdicionalInfo.TabIndex = 17;
            this.rtbAdicionalInfo.Text = "";
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbEstado.Location = new System.Drawing.Point(112, 223);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(59, 24);
            this.cbEstado.TabIndex = 16;
            // 
            // cbCidade
            // 
            this.cbCidade.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(112, 193);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(59, 24);
            this.cbCidade.TabIndex = 15;
            // 
            // txtbEndereco
            // 
            this.txtbEndereco.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEndereco.Location = new System.Drawing.Point(112, 166);
            this.txtbEndereco.Name = "txtbEndereco";
            this.txtbEndereco.Size = new System.Drawing.Size(180, 21);
            this.txtbEndereco.TabIndex = 14;
            // 
            // txtbemail
            // 
            this.txtbemail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbemail.Location = new System.Drawing.Point(112, 139);
            this.txtbemail.Name = "txtbemail";
            this.txtbemail.Size = new System.Drawing.Size(180, 21);
            this.txtbemail.TabIndex = 13;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(55, 231);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(48, 16);
            this.lbEstado.TabIndex = 12;
            this.lbEstado.Text = "Estado:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidade.Location = new System.Drawing.Point(50, 201);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(53, 16);
            this.lbCidade.TabIndex = 11;
            this.lbCidade.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Endereço:";
            // 
            // lbEmailCliente
            // 
            this.lbEmailCliente.AutoSize = true;
            this.lbEmailCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailCliente.Location = new System.Drawing.Point(67, 142);
            this.lbEmailCliente.Name = "lbEmailCliente";
            this.lbEmailCliente.Size = new System.Drawing.Size(39, 16);
            this.lbEmailCliente.TabIndex = 9;
            this.lbEmailCliente.Text = "Email:";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefone.Location = new System.Drawing.Point(112, 111);
            this.mtbTelefone.Mask = "(00) 0 00000000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(180, 21);
            this.mtbTelefone.TabIndex = 8;
            // 
            // lbTelefoneCliente
            // 
            this.lbTelefoneCliente.AutoSize = true;
            this.lbTelefoneCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefoneCliente.Location = new System.Drawing.Point(50, 115);
            this.lbTelefoneCliente.Name = "lbTelefoneCliente";
            this.lbTelefoneCliente.Size = new System.Drawing.Size(56, 16);
            this.lbTelefoneCliente.TabIndex = 7;
            this.lbTelefoneCliente.Text = "Telefone:";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(128, 84);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(157, 21);
            this.dtpDataNasc.TabIndex = 6;
            this.dtpDataNasc.ValueChanged += new System.EventHandler(this.dtpDataNasc_ValueChanged);
            // 
            // lbDataNascimentoCliente
            // 
            this.lbDataNascimentoCliente.AutoSize = true;
            this.lbDataNascimentoCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascimentoCliente.Location = new System.Drawing.Point(6, 88);
            this.lbDataNascimentoCliente.Name = "lbDataNascimentoCliente";
            this.lbDataNascimentoCliente.Size = new System.Drawing.Size(123, 16);
            this.lbDataNascimentoCliente.TabIndex = 5;
            this.lbDataNascimentoCliente.Text = "Data de nascimento:";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpf.Location = new System.Drawing.Point(112, 58);
            this.mtbCpf.Mask = "000.000.000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(180, 21);
            this.mtbCpf.TabIndex = 4;
            // 
            // lbCpfCliente
            // 
            this.lbCpfCliente.AutoSize = true;
            this.lbCpfCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpfCliente.Location = new System.Drawing.Point(74, 61);
            this.lbCpfCliente.Name = "lbCpfCliente";
            this.lbCpfCliente.Size = new System.Drawing.Size(32, 16);
            this.lbCpfCliente.TabIndex = 3;
            this.lbCpfCliente.Text = "CPF:";
            // 
            // txtbNomeCompletoCli
            // 
            this.txtbNomeCompletoCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNomeCompletoCli.Location = new System.Drawing.Point(112, 31);
            this.txtbNomeCompletoCli.Name = "txtbNomeCompletoCli";
            this.txtbNomeCompletoCli.Size = new System.Drawing.Size(180, 21);
            this.txtbNomeCompletoCli.TabIndex = 2;
            this.txtbNomeCompletoCli.Leave += new System.EventHandler(this.txtbNomeCompletoCli_Leave);
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCliente.Location = new System.Drawing.Point(8, 34);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(98, 16);
            this.lbNomeCliente.TabIndex = 1;
            this.lbNomeCliente.Text = "Nome completo:";
            // 
            // gbDadosDoResponsavel
            // 
            this.gbDadosDoResponsavel.Controls.Add(this.btnClearPesquisa);
            this.gbDadosDoResponsavel.Controls.Add(this.btnPesquisar);
            this.gbDadosDoResponsavel.Controls.Add(this.dtgResponsavel);
            this.gbDadosDoResponsavel.Controls.Add(this.txtbNomeRespPesquisa);
            this.gbDadosDoResponsavel.Controls.Add(this.lblNomePesquisa);
            this.gbDadosDoResponsavel.Controls.Add(this.lbPesquisa);
            this.gbDadosDoResponsavel.Controls.Add(this.btnSalvar);
            this.gbDadosDoResponsavel.Controls.Add(this.txtbEmailResp);
            this.gbDadosDoResponsavel.Controls.Add(this.lbEmailResponsavel);
            this.gbDadosDoResponsavel.Controls.Add(this.mtbTelefoneResp);
            this.gbDadosDoResponsavel.Controls.Add(this.lbTelefoneResponsavel);
            this.gbDadosDoResponsavel.Controls.Add(this.dtpDataNascResp);
            this.gbDadosDoResponsavel.Controls.Add(this.lbDataNascimentoResponsavel);
            this.gbDadosDoResponsavel.Controls.Add(this.mtbCpfResp);
            this.gbDadosDoResponsavel.Controls.Add(this.lbCpfResponsavel);
            this.gbDadosDoResponsavel.Controls.Add(this.txtbNomeResp);
            this.gbDadosDoResponsavel.Controls.Add(this.lbNomeResponsavel);
            this.gbDadosDoResponsavel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDadosDoResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosDoResponsavel.ForeColor = System.Drawing.Color.White;
            this.gbDadosDoResponsavel.Location = new System.Drawing.Point(342, 3);
            this.gbDadosDoResponsavel.Name = "gbDadosDoResponsavel";
            this.gbDadosDoResponsavel.Size = new System.Drawing.Size(327, 403);
            this.gbDadosDoResponsavel.TabIndex = 1;
            this.gbDadosDoResponsavel.TabStop = false;
            this.gbDadosDoResponsavel.Text = "Dados do Responsável";
            // 
            // btnClearPesquisa
            // 
            this.btnClearPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.btnClearPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPesquisa.Image = global::SisClinica.Properties.Resources.btnRefresh;
            this.btnClearPesquisa.Location = new System.Drawing.Point(271, 183);
            this.btnClearPesquisa.Name = "btnClearPesquisa";
            this.btnClearPesquisa.Size = new System.Drawing.Size(32, 32);
            this.btnClearPesquisa.TabIndex = 30;
            this.btnClearPesquisa.UseVisualStyleBackColor = false;
            this.btnClearPesquisa.Visible = false;
            this.btnClearPesquisa.Click += new System.EventHandler(this.btnClearPesquisa_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Enabled = false;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::SisClinica.Properties.Resources.btnPesquisarResp1;
            this.btnPesquisar.Location = new System.Drawing.Point(235, 183);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(32, 32);
            this.btnPesquisar.TabIndex = 29;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtgResponsavel
            // 
            this.dtgResponsavel.AllowUserToAddRows = false;
            this.dtgResponsavel.AllowUserToDeleteRows = false;
            this.dtgResponsavel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgResponsavel.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgResponsavel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgResponsavel.ColumnHeadersHeight = 25;
            this.dtgResponsavel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgResponsavel.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgResponsavel.Location = new System.Drawing.Point(40, 218);
            this.dtgResponsavel.Name = "dtgResponsavel";
            this.dtgResponsavel.ReadOnly = true;
            this.dtgResponsavel.Size = new System.Drawing.Size(246, 81);
            this.dtgResponsavel.TabIndex = 28;
            this.dtgResponsavel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgResponsavel_CellDoubleClick);
            // 
            // txtbNomeRespPesquisa
            // 
            this.txtbNomeRespPesquisa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNomeRespPesquisa.Location = new System.Drawing.Point(123, 191);
            this.txtbNomeRespPesquisa.Name = "txtbNomeRespPesquisa";
            this.txtbNomeRespPesquisa.Size = new System.Drawing.Size(106, 21);
            this.txtbNomeRespPesquisa.TabIndex = 27;
            this.txtbNomeRespPesquisa.TextChanged += new System.EventHandler(this.txtbNomeRespPesquisa_TextChanged);
            this.txtbNomeRespPesquisa.Leave += new System.EventHandler(this.txtbNomeRespPesquisa_Leave);
            // 
            // lblNomePesquisa
            // 
            this.lblNomePesquisa.AutoSize = true;
            this.lblNomePesquisa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePesquisa.Location = new System.Drawing.Point(19, 194);
            this.lblNomePesquisa.Name = "lblNomePesquisa";
            this.lblNomePesquisa.Size = new System.Drawing.Size(98, 16);
            this.lblNomePesquisa.TabIndex = 26;
            this.lblNomePesquisa.Text = "Nome completo:";
            // 
            // lbPesquisa
            // 
            this.lbPesquisa.AutoSize = true;
            this.lbPesquisa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesquisa.Location = new System.Drawing.Point(20, 171);
            this.lbPesquisa.Name = "lbPesquisa";
            this.lbPesquisa.Size = new System.Drawing.Size(58, 16);
            this.lbPesquisa.TabIndex = 25;
            this.lbPesquisa.Text = "Pesquisar";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(65, 305);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(213, 79);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtbEmailResp
            // 
            this.txtbEmailResp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmailResp.Location = new System.Drawing.Point(124, 139);
            this.txtbEmailResp.Name = "txtbEmailResp";
            this.txtbEmailResp.Size = new System.Drawing.Size(177, 21);
            this.txtbEmailResp.TabIndex = 23;
            // 
            // lbEmailResponsavel
            // 
            this.lbEmailResponsavel.AutoSize = true;
            this.lbEmailResponsavel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailResponsavel.Location = new System.Drawing.Point(79, 142);
            this.lbEmailResponsavel.Name = "lbEmailResponsavel";
            this.lbEmailResponsavel.Size = new System.Drawing.Size(39, 16);
            this.lbEmailResponsavel.TabIndex = 22;
            this.lbEmailResponsavel.Text = "Email:";
            // 
            // mtbTelefoneResp
            // 
            this.mtbTelefoneResp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefoneResp.Location = new System.Drawing.Point(124, 111);
            this.mtbTelefoneResp.Mask = "(00) 0 00000000";
            this.mtbTelefoneResp.Name = "mtbTelefoneResp";
            this.mtbTelefoneResp.Size = new System.Drawing.Size(177, 21);
            this.mtbTelefoneResp.TabIndex = 21;
            // 
            // lbTelefoneResponsavel
            // 
            this.lbTelefoneResponsavel.AutoSize = true;
            this.lbTelefoneResponsavel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefoneResponsavel.Location = new System.Drawing.Point(62, 115);
            this.lbTelefoneResponsavel.Name = "lbTelefoneResponsavel";
            this.lbTelefoneResponsavel.Size = new System.Drawing.Size(56, 16);
            this.lbTelefoneResponsavel.TabIndex = 20;
            this.lbTelefoneResponsavel.Text = "Telefone:";
            // 
            // dtpDataNascResp
            // 
            this.dtpDataNascResp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascResp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascResp.Location = new System.Drawing.Point(140, 84);
            this.dtpDataNascResp.Name = "dtpDataNascResp";
            this.dtpDataNascResp.Size = new System.Drawing.Size(161, 21);
            this.dtpDataNascResp.TabIndex = 19;
            // 
            // lbDataNascimentoResponsavel
            // 
            this.lbDataNascimentoResponsavel.AutoSize = true;
            this.lbDataNascimentoResponsavel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascimentoResponsavel.Location = new System.Drawing.Point(18, 88);
            this.lbDataNascimentoResponsavel.Name = "lbDataNascimentoResponsavel";
            this.lbDataNascimentoResponsavel.Size = new System.Drawing.Size(123, 16);
            this.lbDataNascimentoResponsavel.TabIndex = 18;
            this.lbDataNascimentoResponsavel.Text = "Data de nascimento:";
            // 
            // mtbCpfResp
            // 
            this.mtbCpfResp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpfResp.Location = new System.Drawing.Point(124, 58);
            this.mtbCpfResp.Mask = "000.000.000-00";
            this.mtbCpfResp.Name = "mtbCpfResp";
            this.mtbCpfResp.Size = new System.Drawing.Size(177, 21);
            this.mtbCpfResp.TabIndex = 17;
            // 
            // lbCpfResponsavel
            // 
            this.lbCpfResponsavel.AutoSize = true;
            this.lbCpfResponsavel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpfResponsavel.Location = new System.Drawing.Point(86, 61);
            this.lbCpfResponsavel.Name = "lbCpfResponsavel";
            this.lbCpfResponsavel.Size = new System.Drawing.Size(32, 16);
            this.lbCpfResponsavel.TabIndex = 16;
            this.lbCpfResponsavel.Text = "CPF:";
            // 
            // txtbNomeResp
            // 
            this.txtbNomeResp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNomeResp.Location = new System.Drawing.Point(124, 31);
            this.txtbNomeResp.Name = "txtbNomeResp";
            this.txtbNomeResp.Size = new System.Drawing.Size(177, 21);
            this.txtbNomeResp.TabIndex = 15;
            this.txtbNomeResp.Leave += new System.EventHandler(this.txtbNomeResp_Leave);
            // 
            // lbNomeResponsavel
            // 
            this.lbNomeResponsavel.AutoSize = true;
            this.lbNomeResponsavel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeResponsavel.Location = new System.Drawing.Point(20, 34);
            this.lbNomeResponsavel.Name = "lbNomeResponsavel";
            this.lbNomeResponsavel.Size = new System.Drawing.Size(98, 16);
            this.lbNomeResponsavel.TabIndex = 14;
            this.lbNomeResponsavel.Text = "Nome completo:";
            // 
            // userControlRegistraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "userControlRegistraCliente";
            this.Size = new System.Drawing.Size(672, 409);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbDadosDoCliente.ResumeLayout(false);
            this.gbDadosDoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptErrorNomeCli)).EndInit();
            this.gbDadosDoResponsavel.ResumeLayout(false);
            this.gbDadosDoResponsavel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResponsavel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbDadosDoCliente;
        private System.Windows.Forms.GroupBox gbDadosDoResponsavel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEmailCliente;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lbTelefoneCliente;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Label lbDataNascimentoCliente;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lbCpfCliente;
        private System.Windows.Forms.TextBox txtbNomeCompletoCli;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.Label lbInfoAdicional;
        private System.Windows.Forms.RichTextBox rtbAdicionalInfo;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.TextBox txtbEndereco;
        private System.Windows.Forms.TextBox txtbemail;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.TextBox txtbEmailResp;
        private System.Windows.Forms.Label lbEmailResponsavel;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneResp;
        private System.Windows.Forms.Label lbTelefoneResponsavel;
        private System.Windows.Forms.DateTimePicker dtpDataNascResp;
        private System.Windows.Forms.Label lbDataNascimentoResponsavel;
        private System.Windows.Forms.MaskedTextBox mtbCpfResp;
        private System.Windows.Forms.Label lbCpfResponsavel;
        private System.Windows.Forms.TextBox txtbNomeResp;
        private System.Windows.Forms.Label lbNomeResponsavel;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dtgResponsavel;
        private System.Windows.Forms.TextBox txtbNomeRespPesquisa;
        private System.Windows.Forms.Label lblNomePesquisa;
        private System.Windows.Forms.Label lbPesquisa;
        private System.Windows.Forms.Button btnClearPesquisa;
        private System.Windows.Forms.PictureBox ptErrorNomeCli;
        private System.Windows.Forms.ToolTip ttpErrors;
    }
}
