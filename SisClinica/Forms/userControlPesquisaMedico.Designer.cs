﻿namespace SisClinica.Forms
{
    partial class userControlPesquisaMedico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDadosMedico = new System.Windows.Forms.GroupBox();
            this.dtgResultados = new System.Windows.Forms.DataGridView();
            this.btnPesq = new System.Windows.Forms.Button();
            this.txtbNomePesquisa = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFullInfo = new System.Windows.Forms.Button();
            this.gbDadosMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosMedico
            // 
            this.gbDadosMedico.Controls.Add(this.dtgResultados);
            this.gbDadosMedico.Controls.Add(this.btnPesq);
            this.gbDadosMedico.Controls.Add(this.txtbNomePesquisa);
            this.gbDadosMedico.Controls.Add(this.lblNome);
            this.gbDadosMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDadosMedico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosMedico.ForeColor = System.Drawing.Color.White;
            this.gbDadosMedico.Location = new System.Drawing.Point(0, 0);
            this.gbDadosMedico.Name = "gbDadosMedico";
            this.gbDadosMedico.Size = new System.Drawing.Size(672, 299);
            this.gbDadosMedico.TabIndex = 2;
            this.gbDadosMedico.TabStop = false;
            this.gbDadosMedico.Text = "Dados da pesquisa";
            // 
            // dtgResultados
            // 
            this.dtgResultados.AllowUserToAddRows = false;
            this.dtgResultados.AllowUserToDeleteRows = false;
            this.dtgResultados.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgResultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgResultados.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultados.Location = new System.Drawing.Point(9, 84);
            this.dtgResultados.Name = "dtgResultados";
            this.dtgResultados.ReadOnly = true;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dtgResultados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgResultados.Size = new System.Drawing.Size(657, 203);
            this.dtgResultados.TabIndex = 3;
            this.dtgResultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgResultados_CellClick);
            // 
            // btnPesq
            // 
            this.btnPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesq.Location = new System.Drawing.Point(412, 55);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(90, 23);
            this.btnPesq.TabIndex = 2;
            this.btnPesq.Text = "Pesquisar";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.gbDadosMedico);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 299);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnFullInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 110);
            this.panel1.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(369, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 71);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFullInfo
            // 
            this.btnFullInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullInfo.Location = new System.Drawing.Point(173, 16);
            this.btnFullInfo.Name = "btnFullInfo";
            this.btnFullInfo.Size = new System.Drawing.Size(108, 71);
            this.btnFullInfo.TabIndex = 2;
            this.btnFullInfo.Text = "Detalhes";
            this.btnFullInfo.UseVisualStyleBackColor = true;
            this.btnFullInfo.Visible = false;
            this.btnFullInfo.Click += new System.EventHandler(this.btnFullInfo_Click);
            // 
            // userControlPesquisaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "userControlPesquisaMedico";
            this.Size = new System.Drawing.Size(672, 409);
            this.gbDadosMedico.ResumeLayout(false);
            this.gbDadosMedico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosMedico;
        private System.Windows.Forms.DataGridView dtgResultados;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.TextBox txtbNomePesquisa;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFullInfo;
    }
}
