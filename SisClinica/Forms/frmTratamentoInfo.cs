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
    public partial class frmTratamentoInfo : Form
    {
        public frmTratamentoInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTratamentoInfo_Load(object sender, EventArgs e)
        {

        }

        private void cbTeste_CheckedChanged(object sender, EventArgs e)
        {
            btnAlterar.Enabled = cbTeste.Checked;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Form alterardata = new frmAlterarData();
            alterardata.Show();
        }
    }
}
