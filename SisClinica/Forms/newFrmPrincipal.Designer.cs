using System.Windows.Forms;
namespace SisClinica.Forms

{
    partial class newFrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newFrmPrincipal));
            this.painelButtons = new System.Windows.Forms.Panel();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.painelBGSubButtons = new System.Windows.Forms.Panel();
            this.painelBGBtnHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.painelTopBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.painelDinamico = new System.Windows.Forms.Panel();
            this.painelButtons.SuspendLayout();
            this.painelBGBtnHome.SuspendLayout();
            this.painelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelButtons
            // 
            this.painelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(73)))));
            this.painelButtons.Controls.Add(this.btnConfigurar);
            this.painelButtons.Controls.Add(this.btnConfirmar);
            this.painelButtons.Controls.Add(this.btnPesquisar);
            this.painelButtons.Controls.Add(this.btnNovo);
            this.painelButtons.Controls.Add(this.painelBGSubButtons);
            this.painelButtons.Controls.Add(this.painelBGBtnHome);
            this.painelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelButtons.Location = new System.Drawing.Point(0, 0);
            this.painelButtons.Name = "painelButtons";
            this.painelButtons.Size = new System.Drawing.Size(155, 509);
            this.painelButtons.TabIndex = 0;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfigurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigurar.Image = global::SisClinica.Properties.Resources.btnConfig;
            this.btnConfigurar.Location = new System.Drawing.Point(0, 328);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(155, 76);
            this.btnConfigurar.TabIndex = 3;
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Image = global::SisClinica.Properties.Resources.btnConfirmar;
            this.btnConfirmar.Location = new System.Drawing.Point(0, 252);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(155, 76);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::SisClinica.Properties.Resources.BTNPESQUISA;
            this.btnPesquisar.Location = new System.Drawing.Point(0, 176);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(155, 76);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(86)))));
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(45)))));
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(0, 100);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(155, 76);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // painelBGSubButtons
            // 
            this.painelBGSubButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(40)))));
            this.painelBGSubButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelBGSubButtons.Location = new System.Drawing.Point(0, 100);
            this.painelBGSubButtons.Name = "painelBGSubButtons";
            this.painelBGSubButtons.Size = new System.Drawing.Size(155, 409);
            this.painelBGSubButtons.TabIndex = 1;
            // 
            // painelBGBtnHome
            // 
            this.painelBGBtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(57)))));
            this.painelBGBtnHome.Controls.Add(this.btnHome);
            this.painelBGBtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelBGBtnHome.Location = new System.Drawing.Point(0, 0);
            this.painelBGBtnHome.Name = "painelBGBtnHome";
            this.painelBGBtnHome.Size = new System.Drawing.Size(155, 100);
            this.painelBGBtnHome.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(43)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(155, 100);
            this.btnHome.TabIndex = 0;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // painelTopBar
            // 
            this.painelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(57)))));
            this.painelTopBar.Controls.Add(this.btnMinimize);
            this.painelTopBar.Controls.Add(this.btnClose);
            this.painelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTopBar.Location = new System.Drawing.Point(155, 0);
            this.painelTopBar.Name = "painelTopBar";
            this.painelTopBar.Size = new System.Drawing.Size(672, 100);
            this.painelTopBar.TabIndex = 1;
            this.painelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseDown);
            this.painelTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseMove);
            this.painelTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.btnMinimize.Image = global::SisClinica.Properties.Resources.btnMinimizar2;
            this.btnMinimize.Location = new System.Drawing.Point(609, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 24);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.btnClose.Image = global::SisClinica.Properties.Resources.btnClose2;
            this.btnClose.Location = new System.Drawing.Point(640, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 24);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // painelDinamico
            // 
            this.painelDinamico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(107)))), ((int)(((byte)(98)))));
            this.painelDinamico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.painelDinamico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelDinamico.Location = new System.Drawing.Point(155, 100);
            this.painelDinamico.Name = "painelDinamico";
            this.painelDinamico.Size = new System.Drawing.Size(672, 409);
            this.painelDinamico.TabIndex = 2;
            // 
            // newFrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 509);
            this.Controls.Add(this.painelDinamico);
            this.Controls.Add(this.painelTopBar);
            this.Controls.Add(this.painelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newFrmPrincipal";
            this.Text = "newFrmPrincipal";
            this.painelButtons.ResumeLayout(false);
            this.painelBGBtnHome.ResumeLayout(false);
            this.painelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelButtons;
        private System.Windows.Forms.Panel painelTopBar;
        private System.Windows.Forms.Button btnNovo;
       

        private System.Windows.Forms.Button btnPesquisar;
        public Panel painelDinamico;
        private Button btnConfirmar;
        private Button btnConfigurar;
        private Button btnMinimize;
        private Button btnClose;
        private Panel painelBGSubButtons;
        private Panel painelBGBtnHome;
        private Button btnHome;
    }
}