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
    public partial class frmAgendarTratamentoComConsulta : Form
    {
        public frmAgendarTratamentoComConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form buscaCliente = new frmBuscaCliente();
            buscaCliente.Show();
        }
    }
}
