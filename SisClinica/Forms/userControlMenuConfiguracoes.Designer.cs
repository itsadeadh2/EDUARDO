namespace SisClinica.Forms
{
    partial class userControlMenuConfiguracoes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userControlMenuConfiguracoes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBizantino = new System.Windows.Forms.Button();
            this.btnDasNeves = new System.Windows.Forms.Button();
            this.btnDark = new System.Windows.Forms.Button();
            this.lblSkins = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbValorTratamento = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mtbNomeTratamento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpCadastrarConsultorio = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.mtbNomeConsult = new System.Windows.Forms.MaskedTextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.ttHistoria = new System.Windows.Forms.ToolTip(this.components);
            this.lbTratamento = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpCadastrarConsultorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBizantino);
            this.panel1.Controls.Add(this.btnDasNeves);
            this.panel1.Controls.Add(this.btnDark);
            this.panel1.Controls.Add(this.lblSkins);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 409);
            this.panel1.TabIndex = 0;
            // 
            // btnBizantino
            // 
            this.btnBizantino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBizantino.ForeColor = System.Drawing.Color.White;
            this.btnBizantino.Location = new System.Drawing.Point(431, 269);
            this.btnBizantino.Name = "btnBizantino";
            this.btnBizantino.Size = new System.Drawing.Size(180, 111);
            this.btnBizantino.TabIndex = 4;
            this.btnBizantino.Text = "Macaco Bizantino";
            this.ttHistoria.SetToolTip(this.btnBizantino, resources.GetString("btnBizantino.ToolTip"));
            this.btnBizantino.UseVisualStyleBackColor = true;
            this.btnBizantino.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDasNeves
            // 
            this.btnDasNeves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDasNeves.ForeColor = System.Drawing.Color.White;
            this.btnDasNeves.Location = new System.Drawing.Point(431, 35);
            this.btnDasNeves.Name = "btnDasNeves";
            this.btnDasNeves.Size = new System.Drawing.Size(180, 111);
            this.btnDasNeves.TabIndex = 3;
            this.btnDasNeves.Text = "Macaco das Neves";
            this.ttHistoria.SetToolTip(this.btnDasNeves, "Macaco das neves: Assim como um macaco, que por nao ser preto o suficiente se iso" +
        "la de seu bando e vai morar no himalaia onde neva muito, esta skin possui o topo" +
        " não muito preto.");
            this.btnDasNeves.UseVisualStyleBackColor = true;
            this.btnDasNeves.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDark
            // 
            this.btnDark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDark.ForeColor = System.Drawing.Color.White;
            this.btnDark.Location = new System.Drawing.Point(431, 152);
            this.btnDark.Name = "btnDark";
            this.btnDark.Size = new System.Drawing.Size(180, 111);
            this.btnDark.TabIndex = 2;
            this.btnDark.Text = "Dark trevoso sombrio das trevas";
            this.ttHistoria.SetToolTip(this.btnDark, "Assim como a escuridão sugiu do nada, essa skin não tem historia, ela é simplesme" +
        "nte o nada.");
            this.btnDark.UseVisualStyleBackColor = true;
            this.btnDark.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSkins
            // 
            this.lblSkins.AutoSize = true;
            this.lblSkins.ForeColor = System.Drawing.Color.White;
            this.lblSkins.Location = new System.Drawing.Point(355, 202);
            this.lblSkins.Name = "lblSkins";
            this.lblSkins.Size = new System.Drawing.Size(45, 21);
            this.lblSkins.TabIndex = 1;
            this.lblSkins.Text = "Skins";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTratamento);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.gpCadastrarConsultorio);
            this.panel2.Controls.Add(this.lblConsultorio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 409);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbValorTratamento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mtbNomeTratamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar novo";
            // 
            // mtbValorTratamento
            // 
            this.mtbValorTratamento.Location = new System.Drawing.Point(79, 92);
            this.mtbValorTratamento.Name = "mtbValorTratamento";
            this.mtbValorTratamento.Size = new System.Drawing.Size(100, 27);
            this.mtbValorTratamento.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(107, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mtbNomeTratamento
            // 
            this.mtbNomeTratamento.Location = new System.Drawing.Point(79, 50);
            this.mtbNomeTratamento.Name = "mtbNomeTratamento";
            this.mtbNomeTratamento.Size = new System.Drawing.Size(166, 27);
            this.mtbNomeTratamento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // gpCadastrarConsultorio
            // 
            this.gpCadastrarConsultorio.Controls.Add(this.btnCadastrar);
            this.gpCadastrarConsultorio.Controls.Add(this.mtbNomeConsult);
            this.gpCadastrarConsultorio.Controls.Add(this.lbNome);
            this.gpCadastrarConsultorio.ForeColor = System.Drawing.Color.White;
            this.gpCadastrarConsultorio.Location = new System.Drawing.Point(3, 30);
            this.gpCadastrarConsultorio.Name = "gpCadastrarConsultorio";
            this.gpCadastrarConsultorio.Size = new System.Drawing.Size(325, 129);
            this.gpCadastrarConsultorio.TabIndex = 1;
            this.gpCadastrarConsultorio.TabStop = false;
            this.gpCadastrarConsultorio.Text = "Cadastrar novo";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(110, 83);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 40);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // mtbNomeConsult
            // 
            this.mtbNomeConsult.Location = new System.Drawing.Point(79, 50);
            this.mtbNomeConsult.Name = "mtbNomeConsult";
            this.mtbNomeConsult.Size = new System.Drawing.Size(166, 27);
            this.mtbNomeConsult.TabIndex = 2;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 53);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(61, 21);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.ForeColor = System.Drawing.Color.White;
            this.lblConsultorio.Location = new System.Drawing.Point(114, 6);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(103, 21);
            this.lblConsultorio.TabIndex = 0;
            this.lblConsultorio.Text = "Consultórios";
            // 
            // lbTratamento
            // 
            this.lbTratamento.AutoSize = true;
            this.lbTratamento.ForeColor = System.Drawing.Color.White;
            this.lbTratamento.Location = new System.Drawing.Point(109, 182);
            this.lbTratamento.Name = "lbTratamento";
            this.lbTratamento.Size = new System.Drawing.Size(110, 21);
            this.lbTratamento.TabIndex = 3;
            this.lbTratamento.Text = "Tratamentos";
            // 
            // userControlMenuConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "userControlMenuConfiguracoes";
            this.Size = new System.Drawing.Size(672, 409);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpCadastrarConsultorio.ResumeLayout(false);
            this.gpCadastrarConsultorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSkins;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gpCadastrarConsultorio;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox mtbNomeConsult;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.Button btnBizantino;
        private System.Windows.Forms.Button btnDasNeves;
        private System.Windows.Forms.Button btnDark;
        private System.Windows.Forms.ToolTip ttHistoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbValorTratamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtbNomeTratamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTratamento;
    }
}
