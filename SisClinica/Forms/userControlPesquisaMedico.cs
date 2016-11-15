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
            HelperFunctions.SetButtonsText(btnFullInfo);
            HelperFunctions.SetButtonsText(btnPesq);
            HelperFunctions.SetButtonsText(btnDelete);
        }

        Medico objMedico;

        private void btnPesq_Click(object sender, EventArgs e)
        {
            dtgResultados.DataSource = new Medico().Pesquisar(txtbNomePesquisa.Text);
        }

        private void dtgResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            objMedico = new Medico().Pesquisar(Convert.ToInt32(dtgResultados.CurrentRow.Cells["id"].Value));
            btnFullInfo.Enabled = true;
            btnPesq.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (new Sessoes().BuscaPorMedico(objMedico)!=null)
            {
                DialogResult resultado = MessageBox.Show("O médico possui sessões ativas, gostaria de excluí-lo mesmo assim?", "Aviso", MessageBoxButtons.YesNo);
                if (resultado==DialogResult.Yes)
                {
                    objMedico.Excluir();
                }                
            }
            else
            {
                objMedico.Excluir();
                MessageBox.Show("Médico excluído com sucesso!");
                Controls.Clear();
                userControlPesquisaMedico uc = new userControlPesquisaMedico();
                Controls.Add(uc);
                uc.Show();                
            }
        }

        private void btnFullInfo_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            userControlMedicoInfo medicoInfo = new userControlMedicoInfo().Preencher(objMedico);
            Controls.Add(medicoInfo);
            medicoInfo.Show();
        }
    }
}
