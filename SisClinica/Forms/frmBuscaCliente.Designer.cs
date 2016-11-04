namespace SisClinica.Forms
{
    partial class frmBuscaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBoxNomeClienteBuscarCliente = new System.Windows.Forms.TextBox();
            this.gpPesquisaBuscarCliente = new System.Windows.Forms.GroupBox();
            this.lbNomeClienteBuscarCliente = new System.Windows.Forms.Label();
            this.btnPesquisarBuscarCliente = new System.Windows.Forms.Button();
            this.gpClienteBuscarCliente = new System.Windows.Forms.GroupBox();
            this.dtgClientesBuscarCliente = new System.Windows.Forms.DataGridView();
            this.gpPesquisaBuscarCliente.SuspendLayout();
            this.gpClienteBuscarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientesBuscarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxNomeClienteBuscarCliente
            // 
            this.txtBoxNomeClienteBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeClienteBuscarCliente.Location = new System.Drawing.Point(46, 85);
            this.txtBoxNomeClienteBuscarCliente.Name = "txtBoxNomeClienteBuscarCliente";
            this.txtBoxNomeClienteBuscarCliente.Size = new System.Drawing.Size(201, 26);
            this.txtBoxNomeClienteBuscarCliente.TabIndex = 3;
            // 
            // gpPesquisaBuscarCliente
            // 
            this.gpPesquisaBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.gpPesquisaBuscarCliente.Controls.Add(this.lbNomeClienteBuscarCliente);
            this.gpPesquisaBuscarCliente.Controls.Add(this.btnPesquisarBuscarCliente);
            this.gpPesquisaBuscarCliente.Controls.Add(this.txtBoxNomeClienteBuscarCliente);
            this.gpPesquisaBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPesquisaBuscarCliente.Location = new System.Drawing.Point(15, 12);
            this.gpPesquisaBuscarCliente.Name = "gpPesquisaBuscarCliente";
            this.gpPesquisaBuscarCliente.Size = new System.Drawing.Size(297, 152);
            this.gpPesquisaBuscarCliente.TabIndex = 1;
            this.gpPesquisaBuscarCliente.TabStop = false;
            this.gpPesquisaBuscarCliente.Text = "Pesquisa";
            // 
            // lbNomeClienteBuscarCliente
            // 
            this.lbNomeClienteBuscarCliente.AutoSize = true;
            this.lbNomeClienteBuscarCliente.Location = new System.Drawing.Point(69, 60);
            this.lbNomeClienteBuscarCliente.Name = "lbNomeClienteBuscarCliente";
            this.lbNomeClienteBuscarCliente.Size = new System.Drawing.Size(161, 22);
            this.lbNomeClienteBuscarCliente.TabIndex = 2;
            this.lbNomeClienteBuscarCliente.Text = "Nome do cliente";
            // 
            // btnPesquisarBuscarCliente
            // 
            this.btnPesquisarBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarBuscarCliente.Location = new System.Drawing.Point(94, 117);
            this.btnPesquisarBuscarCliente.Name = "btnPesquisarBuscarCliente";
            this.btnPesquisarBuscarCliente.Size = new System.Drawing.Size(115, 29);
            this.btnPesquisarBuscarCliente.TabIndex = 4;
            this.btnPesquisarBuscarCliente.Text = "Pesquisar";
            this.btnPesquisarBuscarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarBuscarCliente.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // gpClienteBuscarCliente
            // 
            this.gpClienteBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.gpClienteBuscarCliente.Controls.Add(this.dtgClientesBuscarCliente);
            this.gpClienteBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpClienteBuscarCliente.Location = new System.Drawing.Point(15, 170);
            this.gpClienteBuscarCliente.Name = "gpClienteBuscarCliente";
            this.gpClienteBuscarCliente.Size = new System.Drawing.Size(297, 161);
            this.gpClienteBuscarCliente.TabIndex = 5;
            this.gpClienteBuscarCliente.TabStop = false;
            this.gpClienteBuscarCliente.Text = "Clientes";
            // 
            // dtgClientesBuscarCliente
            // 
            this.dtgClientesBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientesBuscarCliente.Location = new System.Drawing.Point(6, 28);
            this.dtgClientesBuscarCliente.Name = "dtgClientesBuscarCliente";
            this.dtgClientesBuscarCliente.RowHeadersWidth = 60;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgClientesBuscarCliente.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgClientesBuscarCliente.Size = new System.Drawing.Size(285, 119);
            this.dtgClientesBuscarCliente.TabIndex = 6;
            this.dtgClientesBuscarCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellContentClick);
            // 
            // frmBuscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(327, 346);
            this.Controls.Add(this.gpClienteBuscarCliente);
            this.Controls.Add(this.gpPesquisaBuscarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBuscaCliente";
            this.Text = "Buscar cliente";
            this.gpPesquisaBuscarCliente.ResumeLayout(false);
            this.gpPesquisaBuscarCliente.PerformLayout();
            this.gpClienteBuscarCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientesBuscarCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxNomeClienteBuscarCliente;
        private System.Windows.Forms.GroupBox gpPesquisaBuscarCliente;
        private System.Windows.Forms.Button btnPesquisarBuscarCliente;
        private System.Windows.Forms.GroupBox gpClienteBuscarCliente;
        private System.Windows.Forms.DataGridView dtgClientesBuscarCliente;
        private System.Windows.Forms.Label lbNomeClienteBuscarCliente;
    }
}