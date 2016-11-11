namespace SisClinica.Forms
{
    partial class userControlMenuNovo
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
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnTratamento = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.Controls.Add(this.btnNovoCliente, 0, 0);
            this.layout.Controls.Add(this.btnMedico, 1, 0);
            this.layout.Controls.Add(this.btnTratamento, 1, 1);
            this.layout.Controls.Add(this.btnConsulta, 0, 1);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 2;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.Size = new System.Drawing.Size(672, 409);
            this.layout.TabIndex = 0;
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCliente.Image = global::SisClinica.Properties.Resources.btnnewcliente;
            this.btnNovoCliente.Location = new System.Drawing.Point(3, 3);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(330, 198);
            this.btnNovoCliente.TabIndex = 2;
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedico.Image = global::SisClinica.Properties.Resources.btnnewmedico;
            this.btnMedico.Location = new System.Drawing.Point(339, 3);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(330, 198);
            this.btnMedico.TabIndex = 3;
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnTratamento
            // 
            this.btnTratamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTratamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTratamento.Image = global::SisClinica.Properties.Resources.btnnewtratamentos;
            this.btnTratamento.Location = new System.Drawing.Point(339, 207);
            this.btnTratamento.Name = "btnTratamento";
            this.btnTratamento.Size = new System.Drawing.Size(330, 199);
            this.btnTratamento.TabIndex = 4;
            this.btnTratamento.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Image = global::SisClinica.Properties.Resources.btnnewconsulta;
            this.btnConsulta.Location = new System.Drawing.Point(3, 207);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(330, 199);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // userControlMenuNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.layout);
            this.Name = "userControlMenuNovo";
            this.Size = new System.Drawing.Size(672, 409);
            this.layout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnTratamento;
        private System.Windows.Forms.Button btnConsulta;
    }
}
