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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnFullInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbDadosCliente = new System.Windows.Forms.GroupBox();
            this.dtgResultados = new System.Windows.Forms.DataGridView();
            this.btnPesq = new System.Windows.Forms.Button();
            this.txtbNomePesquisa = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbDadosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAlter);
            this.panel1.Controls.Add(this.btnFullInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.gbDadosCliente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 299);
            this.panel2.TabIndex = 2;
            // 
            // gbDadosCliente
            // 
            this.gbDadosCliente.Controls.Add(this.dtgResultados);
            this.gbDadosCliente.Controls.Add(this.btnPesq);
            this.gbDadosCliente.Controls.Add(this.txtbNomePesquisa);
            this.gbDadosCliente.Controls.Add(this.lblNome);
            this.gbDadosCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDadosCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosCliente.Location = new System.Drawing.Point(0, 0);
            this.gbDadosCliente.Name = "gbDadosCliente";
            this.gbDadosCliente.Size = new System.Drawing.Size(672, 299);
            this.gbDadosCliente.TabIndex = 2;
            this.gbDadosCliente.TabStop = false;
            this.gbDadosCliente.Text = "Dados da pesquisa";
            // 
            // dtgResultados
            // 
            this.dtgResultados.AllowUserToAddRows = false;
            this.dtgResultados.AllowUserToDeleteRows = false;
            this.dtgResultados.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgResultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultados.Location = new System.Drawing.Point(9, 84);
            this.dtgResultados.Name = "dtgResultados";
            this.dtgResultados.ReadOnly = true;
            this.dtgResultados.Size = new System.Drawing.Size(657, 203);
            this.dtgResultados.TabIndex = 3;
            this.dtgResultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgResultados_CellClick);
            // 
            // btnPesq
            // 
            this.btnPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesq.Image = global::SisClinica.Properties.Resources.btnPesquisarResp1;
            this.btnPesq.Location = new System.Drawing.Point(412, 39);
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
            this.txtbNomePesquisa.Size = new System.Drawing.Size(338, 23);
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
            // userControlPesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "userControlPesquisarCliente";
            this.Size = new System.Drawing.Size(672, 409);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbDadosCliente.ResumeLayout(false);
            this.gbDadosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFullInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbDadosCliente;
        private System.Windows.Forms.DataGridView dtgResultados;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.TextBox txtbNomePesquisa;
        private System.Windows.Forms.Label lblNome;
    }
}
