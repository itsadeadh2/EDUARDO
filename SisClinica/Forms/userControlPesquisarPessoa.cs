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
    public partial class userControlPesquisarPessoa : UserControl
    {
        public userControlPesquisarPessoa()
        {
            InitializeComponent();
            HelperFunctions.SetButtons(btnPesquisarCliente);
            HelperFunctions.SetButtons(btnPesquisarMedico);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
