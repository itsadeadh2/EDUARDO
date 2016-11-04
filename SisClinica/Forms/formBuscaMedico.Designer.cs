namespace SisClinica.Forms
{
    partial class formBuscaMedico
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
            this.gpPesquisa = new System.Windows.Forms.GroupBox();
            this.lbNomeMedico = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtBoxNomeMedico = new System.Windows.Forms.TextBox();
            this.gpMedicos = new System.Windows.Forms.GroupBox();
            this.dtgMedicos = new System.Windows.Forms.DataGridView();
            this.gpPesquisa.SuspendLayout();
            this.gpMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpPesquisa
            // 
            this.gpPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.gpPesquisa.Controls.Add(this.lbNomeMedico);
            this.gpPesquisa.Controls.Add(this.btnPesquisar);
            this.gpPesquisa.Controls.Add(this.txtBoxNomeMedico);
            this.gpPesquisa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPesquisa.Location = new System.Drawing.Point(15, 14);
            this.gpPesquisa.Name = "gpPesquisa";
            this.gpPesquisa.Size = new System.Drawing.Size(297, 152);
            this.gpPesquisa.TabIndex = 1;
            this.gpPesquisa.TabStop = false;
            this.gpPesquisa.Text = "Pesquisa";
            // 
            // lbNomeMedico
            // 
            this.lbNomeMedico.AutoSize = true;
            this.lbNomeMedico.Location = new System.Drawing.Point(66, 53);
            this.lbNomeMedico.Name = "lbNomeMedico";
            this.lbNomeMedico.Size = new System.Drawing.Size(169, 22);
            this.lbNomeMedico.TabIndex = 2;
            this.lbNomeMedico.Text = "Nome do médico";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(94, 117);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(115, 29);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtBoxNomeMedico
            // 
            this.txtBoxNomeMedico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeMedico.Location = new System.Drawing.Point(48, 78);
            this.txtBoxNomeMedico.Name = "txtBoxNomeMedico";
            this.txtBoxNomeMedico.Size = new System.Drawing.Size(201, 26);
            this.txtBoxNomeMedico.TabIndex = 3;
            // 
            // gpMedicos
            // 
            this.gpMedicos.BackColor = System.Drawing.Color.Transparent;
            this.gpMedicos.Controls.Add(this.dtgMedicos);
            this.gpMedicos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpMedicos.Location = new System.Drawing.Point(15, 172);
            this.gpMedicos.Name = "gpMedicos";
            this.gpMedicos.Size = new System.Drawing.Size(297, 161);
            this.gpMedicos.TabIndex = 5;
            this.gpMedicos.TabStop = false;
            this.gpMedicos.Text = "Medicos";
            // 
            // dtgMedicos
            // 
            this.dtgMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicos.Location = new System.Drawing.Point(6, 28);
            this.dtgMedicos.Name = "dtgMedicos";
            this.dtgMedicos.RowHeadersWidth = 60;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgMedicos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgMedicos.Size = new System.Drawing.Size(285, 119);
            this.dtgMedicos.TabIndex = 6;
            // 
            // formBuscaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(327, 346);
            this.Controls.Add(this.gpPesquisa);
            this.Controls.Add(this.gpMedicos);
            this.Name = "formBuscaMedico";
            this.Text = "Buscar Médico";
            this.gpPesquisa.ResumeLayout(false);
            this.gpPesquisa.PerformLayout();
            this.gpMedicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtBoxNomeMedico;
        private System.Windows.Forms.GroupBox gpMedicos;
        private System.Windows.Forms.DataGridView dtgMedicos;
        private System.Windows.Forms.Label lbNomeMedico;
    }
}