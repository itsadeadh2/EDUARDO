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
            Controls.Clear();
            userControlRegistraCliente regCli = new userControlRegistraCliente();
            Controls.Add(regCli);
            regCli.Show();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            userControlRegistraMedico regMed = new userControlRegistraMedico();
            Controls.Add(regMed);
            regMed.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            UserControl agenCons = new userControlAgendarConsulta();
            Controls.Add(agenCons);
            agenCons.Show();

        }
    }   
}

