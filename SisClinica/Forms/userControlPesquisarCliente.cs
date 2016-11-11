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

        private void dtgResultados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            objCliente = new Cliente().PesquisarPorId(Convert.ToInt32(dtgResultados.CurrentRow.Cells["id"].Value));

            lblNomeCliente.Text ="Nome: "+ objCliente.nome;
            lblCPF.Text = "CPF: " + objCliente.cpf;
            lblResponsavel.Text = "Responsável: " + objCliente.objResponsavel.nome;
            //implementacao da situacao
            //implementãção do lblsituacao

        }
    }
}
