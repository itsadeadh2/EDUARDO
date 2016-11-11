using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisClinica.Classes;

namespace SisClinica.Forms
{
    public partial class userControlPesquisaMedico : UserControl
    {
        public userControlPesquisaMedico()
        {
            InitializeComponent();
            HelperFunctions.SetButtons(btnAlter);
            HelperFunctions.SetButtons(btnFullInfo);
            HelperFunctions.SetButtons(btnPesq);
            HelperFunctions.SetButtons(btnDelete);
        }

        Medico objMedico;

        private void btnPesq_Click(object sender, EventArgs e)
        {
            dtgResultados.DataSource = new Medico().Pesquisar(txtbNomePesquisa.Text);
        }

        private void dtgResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            objMedico = new Medico().Pesquisar(Convert.ToInt32(dtgResultados.CurrentRow.Cells["id"].Value));
            MessageBox.Show(objMedico.nome);
            btnAlter.Enabled = true;
            btnFullInfo.Enabled = true;
            btnPesq.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
