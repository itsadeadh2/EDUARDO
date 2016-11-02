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
    public partial class frmAlterarData : Form
    {
        public frmAlterarData()
        {
            InitializeComponent();
        }

        private void cbTeste_CheckedChanged(object sender, EventArgs e)
        {
            btnAlterar.Enabled = cbTeste.Checked;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data alterada com sucesso!");
            this.Close();
        }
    }
}
