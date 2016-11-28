namespace SisClinica.Forms
{
    partial class userControlHome
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
            this.lblSessoes = new System.Windows.Forms.Label();
            this.dtgSessoesDoDia = new System.Windows.Forms.DataGridView();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSessoesDoDia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSessoes
            // 
            this.lblSessoes.AutoSize = true;
            this.lblSessoes.ForeColor = System.Drawing.Color.White;
            this.lblSessoes.Location = new System.Drawing.Point(272, 34);
            this.lblSessoes.Name = "lblSessoes";
            this.lblSessoes.Size = new System.Drawing.Size(128, 21);
            this.lblSessoes.TabIndex = 0;
            this.lblSessoes.Text = "Sessões de hoje";
            // 
            // dtgSessoesDoDia
            // 
            this.dtgSessoesDoDia.AllowUserToAddRows = false;
            this.dtgSessoesDoDia.AllowUserToDeleteRows = false;
            this.dtgSessoesDoDia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSessoesDoDia.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgSessoesDoDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgSessoesDoDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSessoesDoDia.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSessoesDoDia.Location = new System.Drawing.Point(3, 83);
            this.dtgSessoesDoDia.Name = "dtgSessoesDoDia";
            this.dtgSessoesDoDia.ReadOnly = true;
            this.dtgSessoesDoDia.Size = new System.Drawing.Size(666, 279);
            this.dtgSessoesDoDia.TabIndex = 1;
            this.dtgSessoesDoDia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSessoesDoDia_CellDoubleClick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(287, 55);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(50, 21);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "data";
            // 
            // userControlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtgSessoesDoDia);
            this.Controls.Add(this.lblSessoes);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "userControlHome";
            this.Size = new System.Drawing.Size(672, 409);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSessoesDoDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSessoes;
        private System.Windows.Forms.DataGridView dtgSessoesDoDia;
        private System.Windows.Forms.Label lblData;
    }
}
