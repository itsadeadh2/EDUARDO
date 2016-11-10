namespace SisClinica.Forms
{
    partial class userControlMenuAlterar
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
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.btnAlterarMedico = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlterarSessoes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAlterarCliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAlterarMedico, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 216);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlterarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarCliente.Image = global::SisClinica.Properties.Resources.btnaltercliente;
            this.btnAlterarCliente.Location = new System.Drawing.Point(3, 3);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(330, 210);
            this.btnAlterarCliente.TabIndex = 0;
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            // 
            // btnAlterarMedico
            // 
            this.btnAlterarMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlterarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarMedico.Image = global::SisClinica.Properties.Resources.btbaltermedico;
            this.btnAlterarMedico.Location = new System.Drawing.Point(339, 3);
            this.btnAlterarMedico.Name = "btnAlterarMedico";
            this.btnAlterarMedico.Size = new System.Drawing.Size(330, 210);
            this.btnAlterarMedico.TabIndex = 1;
            this.btnAlterarMedico.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAlterarSessoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 193);
            this.panel1.TabIndex = 1;
            // 
            // btnAlterarSessoes
            // 
            this.btnAlterarSessoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlterarSessoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarSessoes.Image = global::SisClinica.Properties.Resources.alterarsessoes4;
            this.btnAlterarSessoes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterarSessoes.Location = new System.Drawing.Point(0, 0);
            this.btnAlterarSessoes.Name = "btnAlterarSessoes";
            this.btnAlterarSessoes.Size = new System.Drawing.Size(672, 193);
            this.btnAlterarSessoes.TabIndex = 0;
            this.btnAlterarSessoes.UseVisualStyleBackColor = true;
            // 
            // userControlMenuAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "userControlMenuAlterar";
            this.Size = new System.Drawing.Size(672, 409);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.Button btnAlterarMedico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlterarSessoes;
    }
}
