using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SisClinica.Forms
{
    public partial class newFrmPrincipal : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );
        public newFrmPrincipal()
        {
            InitializeComponent();
            if (WindowState!=FormWindowState.Maximized)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            }            
            SetButton(btnNovo);
            SetButton(btnPesquisar);
            SetButton(btnConfirmar);
            SetButton(btnConfigurar);
            HelperFunctions.SetButtons(btnClose);
            HelperFunctions.SetButtons(btnMinimize);
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
            painelDinamico.Controls.Clear();
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
            painelDinamico.Controls.Clear();
            UserControl menuNovo = new userControlMenuNovo();
            menuNovo.AutoScroll = true;
            painelDinamico.Controls.Add(menuNovo);
            menuNovo.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            painelDinamico.Controls.Clear();
            UserControl menuPesquisar = new userControlMenuPesquisar();
            menuPesquisar.AutoScroll = true;
            painelDinamico.Controls.Add(menuPesquisar);
            menuPesquisar.Show();
        }
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);


        private void topbar_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void topbar_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            painelDinamico.Controls.Clear();
            userControlConfirmarSessoes conSess = new userControlConfirmarSessoes();
            painelDinamico.Controls.Add(conSess);
            conSess.Show();
        }
    }
}
