using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisClinica.Forms
{
    public partial class newFrmPrincipal : Form
    {
        public newFrmPrincipal()
        {
            InitializeComponent();
            SetButton(btnNovo);
            SetButton(btnPesquisar);
            SetButton(btnAlterar);
            btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(43)))));
            btnHome.FlatAppearance.MouseOverBackColor = btnHome.BackColor;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            //btnHome.BackgroundImage.
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {          
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
        }

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.BackgroundImage = Properties.Resources.borda;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackgroundImage = null;
        }
        private void SetButton(Button btn)
        {
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 101, 86);
            btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 53, 45);
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            PainelDinamico.Controls.Clear();
            UserControl menuNovo = new userControlMenuNovo();
            menuNovo.AutoScroll = true;
            PainelDinamico.Controls.Add(menuNovo);
            menuNovo.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PainelDinamico.Controls.Clear();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            PainelDinamico.Controls.Clear();
        }
    }
}
