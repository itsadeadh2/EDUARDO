namespace SisClinica.Forms
{
    partial class frmAlterarData
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
            this.dtgAlterardata = new System.Windows.Forms.DataGridView();
            this.lbDatasDisponiveisAlterarData = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.cbTeste = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlterardata)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAlterardata
            // 
            this.dtgAlterardata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlterardata.Location = new System.Drawing.Point(12, 60);
            this.dtgAlterardata.Name = "dtgAlterardata";
            this.dtgAlterardata.Size = new System.Drawing.Size(260, 150);
            this.dtgAlterardata.TabIndex = 2;
            // 
            // lbDatasDisponiveisAlterarData
            // 
            this.lbDatasDisponiveisAlterarData.AutoSize = true;
            this.lbDatasDisponiveisAlterarData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatasDisponiveisAlterarData.Location = new System.Drawing.Point(8, 20);
            this.lbDatasDisponiveisAlterarData.Name = "lbDatasDisponiveisAlterarData";
            this.lbDatasDisponiveisAlterarData.Size = new System.Drawing.Size(133, 20);
            this.lbDatasDisponiveisAlterarData.TabIndex = 1;
            this.lbDatasDisponiveisAlterarData.Text = "Datas disponíveis";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(98, 227);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // cbTeste
            // 
            this.cbTeste.AutoSize = true;
            this.cbTeste.Location = new System.Drawing.Point(22, 124);
            this.cbTeste.Name = "cbTeste";
            this.cbTeste.Size = new System.Drawing.Size(85, 17);
            this.cbTeste.TabIndex = 5;
            this.cbTeste.Text = "Data Ficticia";
            this.cbTeste.UseVisualStyleBackColor = true;
            this.cbTeste.CheckedChanged += new System.EventHandler(this.cbTeste_CheckedChanged);
            // 
            // frmAlterarData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cbTeste);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lbDatasDisponiveisAlterarData);
            this.Controls.Add(this.dtgAlterardata);
            this.Name = "frmAlterarData";
            this.Text = "Alterar Data";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlterardata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAlterardata;
        private System.Windows.Forms.Label lbDatasDisponiveisAlterarData;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.CheckBox cbTeste;
    }
}