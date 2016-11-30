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
        //-Construtor
        public userControlPesquisaMedico()
        {
            InitializeComponent();
            HelperFunctions.SetButtonsText(btnFullInfo);
            HelperFunctions.SetButtonsText(btnPesq);
            HelperFunctions.SetButtonsText(btnDelete);
        }

        //-Atributos
        Medico objMedico;

        //-Eventos
        private void btnPesq_Click(object sender, EventArgs e)
        {
            dtgResultados.DataSource = new Medico().Pesquisar(txtbNomePesquisa.Text);
            if (dtgResultados.DataSource == null)
            {
                MessageBox.Show("A pesquisa com o nome:" + txtbNomePesquisa.Text + " não obteve resultados.");
            }
        }
        private void dtgResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                objMedico = new Medico().Pesquisar(Convert.ToInt32(dtgResultados.CurrentRow.Cells["id"].Value));
                btnFullInfo.Visible = true;
                btnPesq.Visible = true;
                btnDelete.Visible = true;
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (new Sessoes().BuscaPorMedico(objMedico)!=null)
            {
                DialogResult resultado = MessageBox.Show("O médico possui sessões ativas, gostaria de excluí-lo mesmo assim?", "Aviso", MessageBoxButtons.YesNo);
                if (resultado==DialogResult.Yes)
                {
                    objMedico.Excluir();
                    dtgResultados.DataSource = new Medico().Pesquisar(txtbNomePesquisa.Text);
                }                
            }
            else
            {
                objMedico.Excluir();
                MessageBox.Show("Médico excluído com sucesso!");
                dtgResultados.DataSource = new Medico().Pesquisar(txtbNomePesquisa.Text);
            }
        }
        private void btnFullInfo_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            userControlMedicoInfo medicoInfo = new userControlMedicoInfo(objMedico);
            Controls.Add(medicoInfo);
            medicoInfo.Show();
        }
    }
}
