using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisClinica.Classes;

namespace SisClinica.Forms
{
    public partial class frmConfiguracoes : Form
    {
        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sessoes.horaEntrada = Convert.ToDateTime(cbHoraEntrada.SelectedItem);
            Sessoes.horaAlmoco = Convert.ToDateTime(cbHoraAlmoco.SelectedItem);
            Sessoes.horarioReentrada = Convert.ToDateTime(cbHoraReentrada.SelectedItem);
            Sessoes.fimExpediente = Convert.ToDateTime(cbFimExpediente.SelectedItem);

            MessageBox.Show("Configurações alteradas!");
            Close();
        }
    }
}
