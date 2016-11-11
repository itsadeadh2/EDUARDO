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
    public partial class userControlPesquisarCliente : UserControl
    {
        public userControlPesquisarCliente()
        {
            InitializeComponent();
            HelperFunctions.SetButtons(btnPesq);
            HelperFunctions.SetButtons(btnFullInfo);
            HelperFunctions.SetButtons(btnAlter);
            HelperFunctions.SetButtons(btnDelete);
        }
        private Cliente objCliente;

        private void btnPesq_Click(object sender, EventArgs e)
        {
            dtgResultados.DataSource = new Cliente().PesquisarPorNome(txtbNomePesquisa.Text);
        }

        private void dtgResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            objCliente = new Cliente().PesquisarPorId(Convert.ToInt32(dtgResultados.CurrentRow.Cells["id"].Value));
            if (objCliente != null)
            {
                btnAlter.Enabled = true;
                btnDelete.Enabled = true;
                btnFullInfo.Enabled = true;
            }
            //lblNomeCliente.Text = "Nome: " + objCliente.nome;
            //lblCPF.Text = "CPF: " + objCliente.cpf;
            //lblResponsavel.Text = "Responsável: " + objCliente.objResponsavel.nome;
            //implementacao da situacao
            //implementãção do lblsituacao
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (new Sessoes().BuscaPorCliente(objCliente)!=null)
            {
                DialogResult result = MessageBox.Show("O cliente selecionado possui sessões agendadas, gostaria de deletá-lo mesmo assim?", "Aviso", MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    objCliente.Excluir(objCliente.id);
                    MessageBox.Show("Cliente deletado com sucesso!");
                }
            }
            else
            {
                objCliente.Excluir(objCliente.id);
                MessageBox.Show("Cliente deletado com sucesso!");
            }
        }

        private void btnFullInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nigger");
        }
    }
}
