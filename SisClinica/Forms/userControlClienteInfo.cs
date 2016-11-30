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
    public partial class userControlClienteInfo : UserControl
    {
        public userControlClienteInfo(Cliente objCli)
        {
            InitializeComponent();
            linkLblNomeResp.Enabled = false;
            objCliente = new Cliente().PesquisarPorId(objCli.id);
            lblNome.Text =objCliente.nome;
            lblCPF.Text = objCliente.cpf;
            lblDataNasc.Text = objCliente.dataNascimento.Date.ToString("dd/MM/yyyy");
            lblEndereco.Text = objCliente.endereco;
            lblEstado.Text = objCliente.paisEstadoCidade.siglaEstado;
            lblCidade.Text = objCliente.paisEstadoCidade.nomeCidade;
            lblEmail.Text = objCliente.email;
            lblTelefone.Text = objCliente.telefone;
            rtbAdicionalInfo.Text = objCliente.adicionalInfo;
            dtgSessoes.DataSource = new Sessoes().DataTableBuscaPorCliente(objCliente);
            if (objCliente.objResponsavel != null)
            {
                linkLblNomeResp.Text = objCliente.objResponsavel.nome;
                linkLblNomeResp.Enabled = true;
            }
        }

        //-Atributos
        Cliente objCliente;

        //-Eventos
        private void dtgSessoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (new Sessoes().BuscaPorId(Convert.ToInt32(dtgSessoes.CurrentRow.Cells["id"].Value)).tipoDeSessao == "Consulta")
                {
                    Controls.Clear();
                    userControlAlterarSessoes alterCon = new userControlAlterarSessoes(new Sessoes().BuscaPorId(Convert.ToInt32(dtgSessoes.CurrentRow.Cells["id"].Value)));
                    Controls.Add(alterCon);
                    alterCon.Show();
                }
                else
                {

                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controls.Clear();
            userControlResponsavelInfo ucResp = new userControlResponsavelInfo(objCliente.objResponsavel);
            Controls.Add(ucResp);
            ucResp.Show();
        }
    }
}
