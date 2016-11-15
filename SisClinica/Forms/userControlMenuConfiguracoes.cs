using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisClinica.Forms
{
    public partial class userControlMenuConfiguracoes : UserControl
    {
        newFrmPrincipal formprin = null;
        public userControlMenuConfiguracoes(newFrmPrincipal frmPrin)
        {
            InitializeComponent();
            HelperFunctions.SetButtonsText(btnCadastrar);
            HelperFunctions.SetButtonsText(button1);
            HelperFunctions.SetButtonsText(button2);
            HelperFunctions.SetButtonsText(button3);
            formprin = frmPrin;
        }

        private void btnConfigurarHorarios_Click(object sender, EventArgs e)
        {
            userControlHorarios conHora = new userControlHorarios();
            Controls.Clear();
            Controls.Add(conHora);
            conHora.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formprin.SetSkin(newFrmPrincipal.skin.dark);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formprin.SetSkin(newFrmPrincipal.skin.roxa);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formprin.SetSkin(newFrmPrincipal.skin.verde);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formprin.SetSkin(newFrmPrincipal.skin.vermelha);
        }
    }
}
