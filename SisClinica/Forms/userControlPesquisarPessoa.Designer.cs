namespace SisClinica.Forms
{
    partial class userControlPesquisarPessoa
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
            this.btnPesquisarMedico = new System.Windows.Forms.Button();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnPesquisarMedico, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPesquisarCliente, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnPesquisarMedico
            // 
            this.btnPesquisarMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarMedico.Image = global::SisClinica.Properties.Resources.btnnewmedico;
            this.btnPesquisarMedico.Location = new System.Drawing.Point(339, 3);
            this.btnPesquisarMedico.Name = "btnPesquisarMedico";
            this.btnPesquisarMedico.Size = new System.Drawing.Size(330, 403);
            this.btnPesquisarMedico.TabIndex = 1;
            this.btnPesquisarMedico.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.Image = global::SisClinica.Properties.Resources.btnnewcliente;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(3, 3);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(330, 403);
            this.btnPesquisarCliente.TabIndex = 0;
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControlPesquisarPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "userControlPesquisarPessoa";
            this.Size = new System.Drawing.Size(672, 409);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Button btnPesquisarMedico;
    }
}
