namespace SisClinica.Forms
{
    partial class userControlPesquisarCliente
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbDadosCliente = new System.Windows.Forms.GroupBox();
            this.dtgResultados = new System.Windows.Forms.DataGridView();
            this.btnPesq = new System.Windows.Forms.Button();
            this.txtbNomePesquisa = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnFullInfo = new System.Windows.Forms.Button();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblProxSessao = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.gbInformacoesBasicas = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbDadosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbInformacoesBasicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbInformacoesBasicas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbDadosCliente, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 299);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbDadosCliente
            // 
            this.gbDadosCliente.Controls.Add(this.dtgResultados);
            this.gbDadosCliente.Controls.Add(this.btnPesq);
            this.gbDadosCliente.Controls.Add(this.txtbNomePesquisa);
            this.gbDadosCliente.Controls.Add(this.lblNome);
            this.gbDadosCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDadosCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosCliente.Location = new System.Drawing.Point(3, 3);
            this.gbDadosCliente.Name = "gbDadosCliente";
            this.gbDadosCliente.Size = new System.Drawing.Size(330, 293);
            this.gbDadosCliente.TabIndex = 1;
            this.gbDadosCliente.TabStop = false;
            this.gbDadosCliente.Text = "Dados da pesquisa";
            // 
            // dtgResultados
            // 
            this.dtgResultados.AllowUserToAddRows = false;
            this.dtgResultados.AllowUserToDeleteRows = false;
            this.dtgResultados.AllowUserToOrderColumns = true;
            this.dtgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultados.Location = new System.Drawing.Point(9, 84);
            this.dtgResultados.Name = "dtgResultados";
            this.dtgResultados.ReadOnly = true;
            this.dtgResultados.Size = new System.Drawing.Size(315, 203);
            this.dtgResultados.TabIndex = 3;
            this.dtgResultados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgResultados_CellContentDoubleClick);
            // 
            // btnPesq
            // 
            this.btnPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesq.Image = global::SisClinica.Properties.Resources.btnPesquisarResp1;
            this.btnPesq.Location = new System.Drawing.Point(276, 39);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(49, 39);
            this.btnPesq.TabIndex = 2;
            this.btnPesq.UseVisualStyleBackColor = true;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // txtbNomePesquisa
            // 
            this.txtbNomePesquisa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNomePesquisa.Location = new System.Drawing.Point(68, 55);
            this.txtbNomePesquisa.Name = "txtbNomePesquisa";
            this.txtbNomePesquisa.Size = new System.Drawing.Size(198, 23);
            this.txtbNomePesquisa.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(7, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAlter);
            this.panel1.Controls.Add(this.btnFullInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 110);
            this.panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::SisClinica.Properties.Resources.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(457, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 107);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAlter
            // 
            this.btnAlter.Enabled = false;
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.Image = global::SisClinica.Properties.Resources.btnPencil;
            this.btnAlter.Location = new System.Drawing.Point(75, 2);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(140, 107);
            this.btnAlter.TabIndex = 3;
            this.btnAlter.UseVisualStyleBackColor = true;
            // 
            // btnFullInfo
            // 
            this.btnFullInfo.Enabled = false;
            this.btnFullInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullInfo.Image = global::SisClinica.Properties.Resources.btnFullInfo;
            this.btnFullInfo.Location = new System.Drawing.Point(266, 2);
            this.btnFullInfo.Name = "btnFullInfo";
            this.btnFullInfo.Size = new System.Drawing.Size(140, 107);
            this.btnFullInfo.TabIndex = 2;
            this.btnFullInfo.UseVisualStyleBackColor = true;
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsavel.Location = new System.Drawing.Point(14, 138);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(92, 17);
            this.lblResponsavel.TabIndex = 2;
            this.lblResponsavel.Text = "Responsável:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(14, 100);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 17);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF:";
            // 
            // lblProxSessao
            // 
            this.lblProxSessao.AutoSize = true;
            this.lblProxSessao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProxSessao.Location = new System.Drawing.Point(14, 176);
            this.lblProxSessao.Name = "lblProxSessao";
            this.lblProxSessao.Size = new System.Drawing.Size(109, 17);
            this.lblProxSessao.TabIndex = 4;
            this.lblProxSessao.Text = "Proxima sessão:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(14, 214);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(69, 17);
            this.lblSituacao.TabIndex = 5;
            this.lblSituacao.Text = "Situacão:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(14, 62);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(52, 17);
            this.lblNomeCliente.TabIndex = 6;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // gbInformacoesBasicas
            // 
            this.gbInformacoesBasicas.Controls.Add(this.lblNomeCliente);
            this.gbInformacoesBasicas.Controls.Add(this.lblSituacao);
            this.gbInformacoesBasicas.Controls.Add(this.lblProxSessao);
            this.gbInformacoesBasicas.Controls.Add(this.lblCPF);
            this.gbInformacoesBasicas.Controls.Add(this.lblResponsavel);
            this.gbInformacoesBasicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInformacoesBasicas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacoesBasicas.Location = new System.Drawing.Point(339, 3);
            this.gbInformacoesBasicas.Name = "gbInformacoesBasicas";
            this.gbInformacoesBasicas.Size = new System.Drawing.Size(330, 293);
            this.gbInformacoesBasicas.TabIndex = 2;
            this.gbInformacoesBasicas.TabStop = false;
            this.gbInformacoesBasicas.Text = "Informações Básicas";
            // 
            // userControlPesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "userControlPesquisarCliente";
            this.Size = new System.Drawing.Size(672, 409);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbDadosCliente.ResumeLayout(false);
            this.gbDadosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbInformacoesBasicas.ResumeLayout(false);
            this.gbInformacoesBasicas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbDadosCliente;
        private System.Windows.Forms.DataGridView dtgResultados;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.TextBox txtbNomePesquisa;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFullInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.GroupBox gbInformacoesBasicas;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblProxSessao;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblResponsavel;
    }
}
