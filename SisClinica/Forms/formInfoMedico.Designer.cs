namespace SisClinica.Forms
{
    partial class formInfoMedico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCrmInfoMedico = new System.Windows.Forms.Label();
            this.lblCidadeInfoMedico = new System.Windows.Forms.Label();
            this.lblBairroInfoMedico = new System.Windows.Forms.Label();
            this.lblNumeroInfoMedico = new System.Windows.Forms.Label();
            this.lblEnderecoInfoMedico = new System.Windows.Forms.Label();
            this.lblEmailInfoMedico = new System.Windows.Forms.Label();
            this.lblTelefoneInfoMedico = new System.Windows.Forms.Label();
            this.lblDataNascInfoMedico = new System.Windows.Forms.Label();
            this.lblNomeInfoMedico = new System.Windows.Forms.Label();
            this.gbConsultasAgendadas = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbTratamentosEmAndamento = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.gbConsultasAgendadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbTratamentosEmAndamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblCrmInfoMedico);
            this.groupBox1.Controls.Add(this.lblCidadeInfoMedico);
            this.groupBox1.Controls.Add(this.lblBairroInfoMedico);
            this.groupBox1.Controls.Add(this.lblNumeroInfoMedico);
            this.groupBox1.Controls.Add(this.lblEnderecoInfoMedico);
            this.groupBox1.Controls.Add(this.lblEmailInfoMedico);
            this.groupBox1.Controls.Add(this.lblTelefoneInfoMedico);
            this.groupBox1.Controls.Add(this.lblDataNascInfoMedico);
            this.groupBox1.Controls.Add(this.lblNomeInfoMedico);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Pessoais";
            // 
            // lblCrmInfoMedico
            // 
            this.lblCrmInfoMedico.AutoSize = true;
            this.lblCrmInfoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrmInfoMedico.Location = new System.Drawing.Point(381, 68);
            this.lblCrmInfoMedico.Name = "lblCrmInfoMedico";
            this.lblCrmInfoMedico.Size = new System.Drawing.Size(49, 20);
            this.lblCrmInfoMedico.TabIndex = 8;
            this.lblCrmInfoMedico.Text = "CRM:";
            // 
            // lblCidadeInfoMedico
            // 
            this.lblCidadeInfoMedico.AutoSize = true;
            this.lblCidadeInfoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeInfoMedico.Location = new System.Drawing.Point(623, 128);
            this.lblCidadeInfoMedico.Name = "lblCidadeInfoMedico";
            this.lblCidadeInfoMedico.Size = new System.Drawing.Size(63, 20);
            this.lblCidadeInfoMedico.TabIndex = 7;
            this.lblCidadeInfoMedico.Text = "Cidade:";
            // 
            // lblBairroInfoMedico
            // 
            this.lblBairroInfoMedico.AutoSize = true;
            this.lblBairroInfoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroInfoMedico.Location = new System.Drawing.Point(439, 128);
            this.lblBairroInfoMedico.Name = "lblBairroInfoMedico";
            this.lblBairroInfoMedico.Size = new System.Drawing.Size(55, 20);
            this.lblBairroInfoMedico.TabIndex = 6;
            this.lblBairroInfoMedico.Text = "Bairro:";
            // 
            // lblNumeroInfoMedico
            // 
            this.lblNumeroInfoMedico.AutoSize = true;
            this.lblNumeroInfoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroInfoMedico.Location = new System.Drawing.Point(304, 128);
            this.lblNumeroInfoMedico.Name = "lblNumeroInfoMedico";
            this.lblNumeroInfoMedico.Size = new System.Drawing.Size(29, 20);
            this.lblNumeroInfoMedico.TabIndex = 5;
            this.lblNumeroInfoMedico.Text = "N°:";
            // 
            // lblEnderecoInfoMedico
            // 
            this.lblEnderecoInfoMedico.AutoSize = true;
            this.lblEnderecoInfoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoInfoMedico.Location = new System.Drawing.Point(6, 128);
            this.lblEnderecoInfoMedico.Name = "lblEnderecoInfoMedico";
            this.lblEnderecoInfoMedico.Size = new System.Drawing.Size(82, 20);
            this.lblEnderecoInfoMedico.TabIndex = 4;
            this.lblEnderecoInfoMedico.Text = "Endereço:";
            // 
            // lblEmailInfoMedico
            // 
            this.lblEmailInfoMedico.AutoSize = true;
            this.lblEmailInfoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailInfoMedico.Location = new System.Drawing.Point(6, 108);
            this.lblEmailInfoMedico.Name = "lblEmailInfoMedico";
            this.lblEmailInfoMedico.Size = new System.Drawing.Size(57, 20);
            this.lblEmailInfoMedico.TabIndex = 3;
            this.lblEmailInfoMedico.Text = "E-mail:";
            // 
            // lblTelefoneInfoMedico
            // 
            this.lblTelefoneInfoMedico.AutoSize = true;
            this.lblTelefoneInfoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneInfoMedico.Location = new System.Drawing.Point(6, 88);
            this.lblTelefoneInfoMedico.Name = "lblTelefoneInfoMedico";
            this.lblTelefoneInfoMedico.Size = new System.Drawing.Size(75, 20);
            this.lblTelefoneInfoMedico.TabIndex = 2;
            this.lblTelefoneInfoMedico.Text = "Telefone:";
            // 
            // lblDataNascInfoMedico
            // 
            this.lblDataNascInfoMedico.AutoSize = true;
            this.lblDataNascInfoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascInfoMedico.Location = new System.Drawing.Point(6, 68);
            this.lblDataNascInfoMedico.Name = "lblDataNascInfoMedico";
            this.lblDataNascInfoMedico.Size = new System.Drawing.Size(158, 20);
            this.lblDataNascInfoMedico.TabIndex = 1;
            this.lblDataNascInfoMedico.Text = "Data de Nascimento:";
            // 
            // lblNomeInfoMedico
            // 
            this.lblNomeInfoMedico.AutoSize = true;
            this.lblNomeInfoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeInfoMedico.Location = new System.Drawing.Point(6, 48);
            this.lblNomeInfoMedico.Name = "lblNomeInfoMedico";
            this.lblNomeInfoMedico.Size = new System.Drawing.Size(55, 20);
            this.lblNomeInfoMedico.TabIndex = 0;
            this.lblNomeInfoMedico.Text = "Nome:";
            // 
            // gbConsultasAgendadas
            // 
            this.gbConsultasAgendadas.BackColor = System.Drawing.Color.Transparent;
            this.gbConsultasAgendadas.Controls.Add(this.dataGridView1);
            this.gbConsultasAgendadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultasAgendadas.Location = new System.Drawing.Point(12, 183);
            this.gbConsultasAgendadas.Name = "gbConsultasAgendadas";
            this.gbConsultasAgendadas.Size = new System.Drawing.Size(860, 205);
            this.gbConsultasAgendadas.TabIndex = 2;
            this.gbConsultasAgendadas.TabStop = false;
            this.gbConsultasAgendadas.Text = "Consultas Agendadas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbTratamentosEmAndamento
            // 
            this.gbTratamentosEmAndamento.BackColor = System.Drawing.Color.Transparent;
            this.gbTratamentosEmAndamento.Controls.Add(this.dataGridView2);
            this.gbTratamentosEmAndamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTratamentosEmAndamento.Location = new System.Drawing.Point(12, 394);
            this.gbTratamentosEmAndamento.Name = "gbTratamentosEmAndamento";
            this.gbTratamentosEmAndamento.Size = new System.Drawing.Size(860, 205);
            this.gbTratamentosEmAndamento.TabIndex = 3;
            this.gbTratamentosEmAndamento.TabStop = false;
            this.gbTratamentosEmAndamento.Text = "Tratamentos em Andamento";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(830, 161);
            this.dataGridView2.TabIndex = 0;
            // 
            // formInfoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 619);
            this.Controls.Add(this.gbTratamentosEmAndamento);
            this.Controls.Add(this.gbConsultasAgendadas);
            this.Controls.Add(this.groupBox1);
            this.Name = "formInfoMedico";
            this.Text = "Informações do Médico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbConsultasAgendadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbTratamentosEmAndamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCidadeInfoMedico;
        private System.Windows.Forms.Label lblBairroInfoMedico;
        private System.Windows.Forms.Label lblNumeroInfoMedico;
        private System.Windows.Forms.Label lblEnderecoInfoMedico;
        private System.Windows.Forms.Label lblEmailInfoMedico;
        private System.Windows.Forms.Label lblTelefoneInfoMedico;
        private System.Windows.Forms.Label lblDataNascInfoMedico;
        private System.Windows.Forms.Label lblNomeInfoMedico;
        private System.Windows.Forms.Label lblCrmInfoMedico;
        private System.Windows.Forms.GroupBox gbConsultasAgendadas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbTratamentosEmAndamento;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}