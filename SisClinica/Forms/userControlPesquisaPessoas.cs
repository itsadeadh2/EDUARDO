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
    public partial class userControlPesquisaPessoas : UserControl
    {
        public userControlPesquisaPessoas()
        {
            InitializeComponent();
            HelperFunctions.SetButtons(btnPesqCliente);
            HelperFunctions.SetButtons(btnPesqMed);            
        }

        private void btnPesqCliente_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            UserControl pesqCli = new userControlPesquisarCliente();
            Controls.Add(pesqCli);
            pesqCli.Show();
        }
    }
}
