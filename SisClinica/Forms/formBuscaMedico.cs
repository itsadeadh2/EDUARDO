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
    public partial class formBuscaMedico : Form
    {
        public formBuscaMedico()
        {
            InitializeComponent();
        }
        public Medico objMedico { get; set; }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                dtgMedicos.DataSource = new Medico().Pesquisar(txtBoxNome.Text);
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        { 
        //{
        //    Medico objMedico = new Medico().Pesquisar(Convert.ToInt32(dtgMedicos.CurrentRow.Cells["id"].Value));
        //    bool foiDeletado = objMedico.Excluir();
        //    btnExcluir.Enabled = !foiDeletado;
        //    if (foiDeletado)
        //    {
        //        MessageBox.Show("Médico deletado!");
        //    }
        //    else
        //    {
        //        MessageBox.Show("O médico possui sessões e como as procedures para exclusão com sessões ainda\n estão sendo elaboradas, não foi deletado!");
        //    }
        //    Close();
        }

        private void dtgMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExcluir.Enabled = true;
        }

        private void dtgMedicos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            objMedico = new Medico().Pesquisar(Convert.ToInt32(dtgMedicos.CurrentRow.Cells["id"].Value));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
