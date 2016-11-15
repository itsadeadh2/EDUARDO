namespace SisClinica.Forms
{
    partial class userControlHorarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbAlmoco = new System.Windows.Forms.ComboBox();
            this.cbReentrada = new System.Windows.Forms.ComboBox();
            this.cbSaida = new System.Windows.Forms.ComboBox();
            this.cbEntrada = new System.Windows.Forms.ComboBox();
            this.lblHorarioFimDeExpediente = new System.Windows.Forms.Label();
            this.lblHorarioDeAlmoco = new System.Windows.Forms.Label();
            this.lblHorarioDeSaida = new System.Windows.Forms.Label();
            this.lblHorarioDeEntrada = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.cbAlmoco);
            this.panel1.Controls.Add(this.cbReentrada);
            this.panel1.Controls.Add(this.cbSaida);
            this.panel1.Controls.Add(this.cbEntrada);
            this.panel1.Controls.Add(this.lblHorarioFimDeExpediente);
            this.panel1.Controls.Add(this.lblHorarioDeAlmoco);
            this.panel1.Controls.Add(this.lblHorarioDeSaida);
            this.panel1.Controls.Add(this.lblHorarioDeEntrada);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 409);
            this.panel1.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(242, 331);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(189, 75);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // cbAlmoco
            // 
            this.cbAlmoco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlmoco.FormattingEnabled = true;
            this.cbAlmoco.Location = new System.Drawing.Point(319, 173);
            this.cbAlmoco.Name = "cbAlmoco";
            this.cbAlmoco.Size = new System.Drawing.Size(121, 29);
            this.cbAlmoco.TabIndex = 7;
            // 
            // cbReentrada
            // 
            this.cbReentrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReentrada.FormattingEnabled = true;
            this.cbReentrada.Location = new System.Drawing.Point(319, 210);
            this.cbReentrada.Name = "cbReentrada";
            this.cbReentrada.Size = new System.Drawing.Size(121, 29);
            this.cbReentrada.TabIndex = 6;
            // 
            // cbSaida
            // 
            this.cbSaida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSaida.FormattingEnabled = true;
            this.cbSaida.Location = new System.Drawing.Point(319, 245);
            this.cbSaida.Name = "cbSaida";
            this.cbSaida.Size = new System.Drawing.Size(121, 29);
            this.cbSaida.TabIndex = 5;
            // 
            // cbEntrada
            // 
            this.cbEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntrada.FormattingEnabled = true;
            this.cbEntrada.Location = new System.Drawing.Point(319, 134);
            this.cbEntrada.Name = "cbEntrada";
            this.cbEntrada.Size = new System.Drawing.Size(121, 29);
            this.cbEntrada.TabIndex = 4;
            // 
            // lblHorarioFimDeExpediente
            // 
            this.lblHorarioFimDeExpediente.AutoSize = true;
            this.lblHorarioFimDeExpediente.BackColor = System.Drawing.Color.Transparent;
            this.lblHorarioFimDeExpediente.ForeColor = System.Drawing.Color.White;
            this.lblHorarioFimDeExpediente.Location = new System.Drawing.Point(171, 249);
            this.lblHorarioFimDeExpediente.Name = "lblHorarioFimDeExpediente";
            this.lblHorarioFimDeExpediente.Size = new System.Drawing.Size(142, 21);
            this.lblHorarioFimDeExpediente.TabIndex = 3;
            this.lblHorarioFimDeExpediente.Text = "Horário de Saída:";
            // 
            // lblHorarioDeAlmoco
            // 
            this.lblHorarioDeAlmoco.AutoSize = true;
            this.lblHorarioDeAlmoco.BackColor = System.Drawing.Color.Transparent;
            this.lblHorarioDeAlmoco.ForeColor = System.Drawing.Color.White;
            this.lblHorarioDeAlmoco.Location = new System.Drawing.Point(130, 214);
            this.lblHorarioDeAlmoco.Name = "lblHorarioDeAlmoco";
            this.lblHorarioDeAlmoco.Size = new System.Drawing.Size(183, 21);
            this.lblHorarioDeAlmoco.TabIndex = 2;
            this.lblHorarioDeAlmoco.Text = "Horário de Reentrada:";
            // 
            // lblHorarioDeSaida
            // 
            this.lblHorarioDeSaida.AutoSize = true;
            this.lblHorarioDeSaida.BackColor = System.Drawing.Color.Transparent;
            this.lblHorarioDeSaida.ForeColor = System.Drawing.Color.White;
            this.lblHorarioDeSaida.Location = new System.Drawing.Point(154, 177);
            this.lblHorarioDeSaida.Name = "lblHorarioDeSaida";
            this.lblHorarioDeSaida.Size = new System.Drawing.Size(159, 21);
            this.lblHorarioDeSaida.TabIndex = 1;
            this.lblHorarioDeSaida.Text = "Horário de Almoço:";
            // 
            // lblHorarioDeEntrada
            // 
            this.lblHorarioDeEntrada.AutoSize = true;
            this.lblHorarioDeEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblHorarioDeEntrada.ForeColor = System.Drawing.Color.White;
            this.lblHorarioDeEntrada.Location = new System.Drawing.Point(150, 138);
            this.lblHorarioDeEntrada.Name = "lblHorarioDeEntrada";
            this.lblHorarioDeEntrada.Size = new System.Drawing.Size(163, 21);
            this.lblHorarioDeEntrada.TabIndex = 0;
            this.lblHorarioDeEntrada.Text = "Horario de entrada:";
            // 
            // userControlHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "userControlHorarios";
            this.Size = new System.Drawing.Size(672, 409);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbAlmoco;
        private System.Windows.Forms.ComboBox cbReentrada;
        private System.Windows.Forms.ComboBox cbSaida;
        private System.Windows.Forms.ComboBox cbEntrada;
        private System.Windows.Forms.Label lblHorarioFimDeExpediente;
        private System.Windows.Forms.Label lblHorarioDeAlmoco;
        private System.Windows.Forms.Label lblHorarioDeSaida;
        private System.Windows.Forms.Label lblHorarioDeEntrada;
    }
}
