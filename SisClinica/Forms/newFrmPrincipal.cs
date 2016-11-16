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
        public enum skin { padrao, macacoBizantino, macacoDasNeves, darkTrevosoSombrioDasTrevas}
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
            userControlHome home = new userControlHome();
            painelDinamico.Controls.Add(home);
            home.Show();
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
            userControlHome uc = new userControlHome();
            painelDinamico.Controls.Clear();
            painelDinamico.Controls.Add(uc);
            uc.Show();
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
            btn.FlatAppearance.BorderSize = 0;
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

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            userControlMenuConfiguracoes menuConf = new userControlMenuConfiguracoes(this);
            painelDinamico.Controls.Clear();
            painelDinamico.Controls.Add(menuConf);
            menuConf.Show();
        }

        public void SetSkin(skin skn)
        {
            switch (skn)
            {

                case skin.padrao:
                    painelDinamico.BackColor = Color.FromArgb(164, 217, 212);
                    painelBGSubButtons.BackColor = Color.FromArgb(0, 47, 40);
                    painelBGBtnHome.BackColor = Color.FromArgb(55, 91, 57);
                    painelButtons.BackColor = Color.FromArgb(0,87,73);
                    painelTopBar.BackColor = Color.FromArgb(55, 91, 57);
                    //HelperFunctions.SetButtons(btnClose);
                    //HelperFunctions.SetButtons(btnConfirmar);
                    //HelperFunctions.SetButtons(btnNovo);
                    //HelperFunctions.SetButtons(btnPesquisar);
                    break;
                case skin.macacoBizantino:
                    painelDinamico.BackColor = Color.FromArgb(63,136,72);
                    painelBGSubButtons.BackColor = Color.FromArgb(17,16,16);
                    painelBGBtnHome.BackColor = Color.FromArgb(0,0,0);
                    painelButtons.BackColor = Color.FromArgb(17,16,16);
                    painelTopBar.BackColor = Color.FromArgb(0,0,0);
                    HelperFunctions.SetButtons(btnNovo, Color.FromArgb(79, 66, 66), Color.FromArgb(0,53,45));
                    HelperFunctions.SetButtons(btnMinimize, Color.FromArgb(79, 66, 66), Color.FromArgb(0, 53, 45));
                    HelperFunctions.SetButtons(btnConfigurar, Color.FromArgb(79, 66, 66), Color.FromArgb(0, 53, 45));
                    HelperFunctions.SetButtons(btnPesquisar, Color.FromArgb(79, 66, 66), Color.FromArgb(0, 53, 45));
                    HelperFunctions.SetButtons(btnConfirmar, Color.FromArgb(79, 66, 66), Color.FromArgb(0, 53, 45));
                    HelperFunctions.SetButtons(btnHome, Color.FromArgb(79, 66, 66), Color.FromArgb(0, 53, 45));
                    break;
                case skin.macacoDasNeves:
                    painelDinamico.BackColor = Color.FromArgb(114, 21, 106);
                    painelBGSubButtons.BackColor = Color.FromArgb(95,18,88);
                    painelBGBtnHome.BackColor = Color.FromArgb(50,6,46);
                    painelButtons.BackColor = Color.FromArgb(95,18,88);
                    painelTopBar.BackColor = Color.FromArgb(50,6,46);
                    HelperFunctions.SetButtons(btnNovo, Color.FromArgb(159, 44, 125), Color.FromArgb(81,15,50));
                    HelperFunctions.SetButtons(btnMinimize, Color.FromArgb(159, 44, 125), Color.FromArgb(81, 15, 50));
                    HelperFunctions.SetButtons(btnConfirmar, Color.FromArgb(159, 44, 125), Color.FromArgb(81, 15, 50));
                    HelperFunctions.SetButtons(btnPesquisar, Color.FromArgb(159, 44, 125), Color.FromArgb(81, 15, 50));
                    HelperFunctions.SetButtons(btnConfigurar, Color.FromArgb(159, 44, 125), Color.FromArgb(81, 15, 50));
                    HelperFunctions.SetButtons(btnHome, Color.FromArgb(159, 44, 125), Color.FromArgb(81, 15, 50));
                    break;
                case skin.darkTrevosoSombrioDasTrevas:
                    painelDinamico.BackColor = Color.FromArgb(8,6,8);
                    painelBGSubButtons.BackColor = Color.FromArgb(19,14,19);
                    painelBGBtnHome.BackColor = Color.FromArgb(0,0,0);
                    painelButtons.BackColor = Color.FromArgb(19,14,19);
                    painelTopBar.BackColor = Color.FromArgb(0,0,0);
                    HelperFunctions.SetButtons(btnClose, Color.FromArgb(79, 66, 66), Color.FromArgb(0, 179, 170));
                    HelperFunctions.SetButtons(btnMinimize, Color.FromArgb(79, 66, 66), Color.FromArgb(0, 179, 170));
                    HelperFunctions.SetButtons(btnNovo, Color.FromArgb(79, 66, 66), Color.FromArgb(0, 179, 170));
                    HelperFunctions.SetButtons(btnConfigurar, Color.FromArgb(79, 66, 66), Color.FromArgb(0, 179, 170));
                    HelperFunctions.SetButtons(btnPesquisar, Color.FromArgb(79, 66, 66), Color.FromArgb(0, 179, 170));
                    HelperFunctions.SetButtons(btnConfirmar, Color.FromArgb(79, 66, 66), Color.FromArgb(0, 179, 170));
                    HelperFunctions.SetButtons(btnHome, Color.FromArgb(79, 66, 66), Color.FromArgb(0, 179, 170));
                    break;
                default:
                    break;
            }
        }
    }
}
