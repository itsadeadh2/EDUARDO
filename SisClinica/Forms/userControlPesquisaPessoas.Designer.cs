namespace SisClinica.Forms
{
    partial class userControlPesquisaPessoas
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
            this.btnPesqCliente = new System.Windows.Forms.Button();
            this.btnPesqMed = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnPesqCliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPesqMed, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPesqCliente
            // 
            this.btnPesqCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesqCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqCliente.Image = global::SisClinica.Properties.Resources.btnnewcliente;
            this.btnPesqCliente.Location = new System.Drawing.Point(3, 3);
            this.btnPesqCliente.Name = "btnPesqCliente";
            this.btnPesqCliente.Size = new System.Drawing.Size(330, 403);
            this.btnPesqCliente.TabIndex = 0;
            this.btnPesqCliente.UseVisualStyleBackColor = true;
            this.btnPesqCliente.Click += new System.EventHandler(this.btnPesqCliente_Click);
            // 
            // btnPesqMed
            // 
            this.btnPesqMed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesqMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqMed.Image = global::SisClinica.Properties.Resources.btnnewmedico;
            this.btnPesqMed.Location = new System.Drawing.Point(339, 3);
            this.btnPesqMed.Name = "btnPesqMed";
            this.btnPesqMed.Size = new System.Drawing.Size(330, 403);
            this.btnPesqMed.TabIndex = 1;
            this.btnPesqMed.UseVisualStyleBackColor = true;
            this.btnPesqMed.Click += new System.EventHandler(this.btnPesqMed_Click);
            // 
            // userControlPesquisaPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "userControlPesquisaPessoas";
            this.Size = new System.Drawing.Size(672, 409);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPesqCliente;
        private System.Windows.Forms.Button btnPesqMed;
    }
}
