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
    public partial class userControlMenuNovo : UserControl
    {
        public userControlMenuNovo()
        {
            InitializeComponent();
            HelperFunctions.SetButtons(btnConsulta);
            HelperFunctions.SetButtons(btnMedico);
            HelperFunctions.SetButtons(btnNovoCliente);
            HelperFunctions.SetButtons(btnTratamento);
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            newFrmPrincipal frm = new newFrmPrincipal();
            new newFrmPrincipal().painelDinamico.Controls.Clear();
            userControlRegistraCliente ucRegCli = new userControlRegistraCliente();
            ucRegCli.AutoScroll = true;
            new newFrmPrincipal().painelDinamico.Controls.Add(ucRegCli);
            ucRegCli.Show();
        }
    }   
}

