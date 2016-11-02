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
    public partial class frmAgendarTratamentoSemConsulta : Form
    {
        public frmAgendarTratamentoSemConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form buscaCliente = new frmBuscaCliente();
            buscaCliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form registraCliente = new frmRegistraCliente();
            registraCliente.Show();
        }
    }
}
