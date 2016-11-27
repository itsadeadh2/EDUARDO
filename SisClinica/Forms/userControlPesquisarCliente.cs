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
            HelperFunctions.SetButtonsText(btnPesq);
            HelperFunctions.SetButtonsText(btnFullInfo);
            HelperFunctions.SetButtonsText(btnAlter);
            HelperFunctions.SetButtonsText(btnDelete);
        }
        private Cliente objCliente;

        private void btnPesq_Click(object sender, EventArgs e)
        {
            dtgResultados.DataSource = new Cliente().PesquisarPorNome(txtbNomePesquisa.Text);
            if (dtgResultados.DataSource == null)
            {
                MessageBox.Show("A pesquisa com o nome: " + txtbNomePesquisa.Text + " não obteve resultados.");
            }
        }

        private void dtgResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
   
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
                    dtgResultados.DataSource = new Cliente().PesquisarPorNome(txtbNomePesquisa.Text);
                }
            }
            else
            {
                objCliente.Excluir(objCliente.id);
                MessageBox.Show("Cliente deletado com sucesso!");
                dtgResultados.DataSource = new Cliente().PesquisarPorNome(txtbNomePesquisa.Text);

            }
        }

        private void btnFullInfo_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            UserControl cliInfo = new userControlClienteInfo().PreencheFormulario(objCliente);
            Controls.Add(cliInfo);
            cliInfo.Show();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            userControlAlterarCliente ucAlterCli = new userControlAlterarCliente().Preencher(objCliente);
            Controls.Add(ucAlterCli);
            ucAlterCli.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nigger");
        }
    }
}
