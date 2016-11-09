namespace SisClinica.Forms
{
    partial class frmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tratamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semConsultaPréviaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comConsultaPréviaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.médicoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sessõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.pesquisarToolStripMenuItem1,
            this.alterarToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(846, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.consultórioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.médicoToolStripMenuItem,
            this.tratamentoToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // consultórioToolStripMenuItem
            // 
            this.consultórioToolStripMenuItem.Name = "consultórioToolStripMenuItem";
            this.consultórioToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.consultórioToolStripMenuItem.Text = "Consultório";
            this.consultórioToolStripMenuItem.Click += new System.EventHandler(this.consultórioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // médicoToolStripMenuItem
            // 
            this.médicoToolStripMenuItem.Name = "médicoToolStripMenuItem";
            this.médicoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.médicoToolStripMenuItem.Text = "Médico";
            this.médicoToolStripMenuItem.Click += new System.EventHandler(this.médicoToolStripMenuItem_Click);
            // 
            // tratamentoToolStripMenuItem
            // 
            this.tratamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.semConsultaPréviaToolStripMenuItem,
            this.comConsultaPréviaToolStripMenuItem});
            this.tratamentoToolStripMenuItem.Name = "tratamentoToolStripMenuItem";
            this.tratamentoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.tratamentoToolStripMenuItem.Text = "Tratamento";
            // 
            // semConsultaPréviaToolStripMenuItem
            // 
            this.semConsultaPréviaToolStripMenuItem.Name = "semConsultaPréviaToolStripMenuItem";
            this.semConsultaPréviaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.semConsultaPréviaToolStripMenuItem.Text = "Sem consulta prévia";
            this.semConsultaPréviaToolStripMenuItem.Click += new System.EventHandler(this.semConsultaPréviaToolStripMenuItem_Click);
            // 
            // comConsultaPréviaToolStripMenuItem
            // 
            this.comConsultaPréviaToolStripMenuItem.Name = "comConsultaPréviaToolStripMenuItem";
            this.comConsultaPréviaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.comConsultaPréviaToolStripMenuItem.Text = "Com consulta prévia";
            this.comConsultaPréviaToolStripMenuItem.Click += new System.EventHandler(this.comConsultaPréviaToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem1
            // 
            this.pesquisarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.médicoToolStripMenuItem1,
            this.sessõesToolStripMenuItem});
            this.pesquisarToolStripMenuItem1.Name = "pesquisarToolStripMenuItem1";
            this.pesquisarToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.pesquisarToolStripMenuItem1.Text = "Pesquisar";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // médicoToolStripMenuItem1
            // 
            this.médicoToolStripMenuItem1.Name = "médicoToolStripMenuItem1";
            this.médicoToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.médicoToolStripMenuItem1.Text = "Médico";
            this.médicoToolStripMenuItem1.Click += new System.EventHandler(this.médicoToolStripMenuItem1_Click);
            // 
            // sessõesToolStripMenuItem
            // 
            this.sessõesToolStripMenuItem.Name = "sessõesToolStripMenuItem";
            this.sessõesToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sessõesToolStripMenuItem.Text = "Sessões";
            this.sessõesToolStripMenuItem.Click += new System.EventHandler(this.sessõesToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médicoToolStripMenuItem2});
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // médicoToolStripMenuItem2
            // 
            this.médicoToolStripMenuItem2.Name = "médicoToolStripMenuItem2";
            this.médicoToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.médicoToolStripMenuItem2.Text = "Médico";
            this.médicoToolStripMenuItem2.Click += new System.EventHandler(this.médicoToolStripMenuItem2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 518);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.MdiChildActivate += new System.EventHandler(this.frmPrincipal_MdiChildActivate);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.frmPrincipal_ControlAdded);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tratamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semConsultaPréviaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comConsultaPréviaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sessõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultórioToolStripMenuItem;
    }
}