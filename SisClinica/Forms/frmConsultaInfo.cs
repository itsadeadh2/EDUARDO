using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SisClinica.Forms
{
    public partial class frmConsultaInfo : Form
    {
        public frmConsultaInfo()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //MetroForm alterarData = new frmAlterarData();
            //alterarData.Show();
        }

        private void cbTeste_CheckedChanged(object sender, EventArgs e)
        {
            btnAlterar.Enabled = cbTeste.Checked;
        }
    }
}
