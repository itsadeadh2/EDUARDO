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
            this.btnConfigurarHorarios = new System.Windows.Forms.Button();
            this.btnCadastrarConsultorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfigurarHorarios
            // 
            this.btnConfigurarHorarios.BackColor = System.Drawing.Color.White;
            this.btnConfigurarHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigurarHorarios.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurarHorarios.Location = new System.Drawing.Point(18, 27);
            this.btnConfigurarHorarios.Name = "btnConfigurarHorarios";
            this.btnConfigurarHorarios.Size = new System.Drawing.Size(234, 100);
            this.btnConfigurarHorarios.TabIndex = 0;
            this.btnConfigurarHorarios.Text = "Horários";
            this.btnConfigurarHorarios.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarConsultorios
            // 
            this.btnCadastrarConsultorios.BackColor = System.Drawing.Color.White;
            this.btnCadastrarConsultorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarConsultorios.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarConsultorios.Location = new System.Drawing.Point(300, 27);
            this.btnCadastrarConsultorios.Name = "btnCadastrarConsultorios";
            this.btnCadastrarConsultorios.Size = new System.Drawing.Size(234, 100);
            this.btnCadastrarConsultorios.TabIndex = 1;
            this.btnCadastrarConsultorios.Text = "Consultorios";
            this.btnCadastrarConsultorios.UseVisualStyleBackColor = false;
            // 
            // userControlMenuConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.btnCadastrarConsultorios);
            this.Controls.Add(this.btnConfigurarHorarios);
            this.Name = "userControlMenuConfiguracoes";
            this.Size = new System.Drawing.Size(672, 409);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfigurarHorarios;
        private System.Windows.Forms.Button btnCadastrarConsultorios;
    }
}
