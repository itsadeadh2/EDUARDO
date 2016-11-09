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
    public partial class userControlRegistraCliente : UserControl
    {
        public userControlRegistraCliente()
        {
            InitializeComponent();
            HelperFunctions.SetButtons(btnSalvar);
            if (HelperFunctions.ChecaMenorDeIdade(dtpDataNasc.Value))
            {
                txtbNomeResp.Enabled = true;
                mtbCpfResp.Enabled = true;
                dtpDataNascResp.Enabled = true;
                mtbTelefoneResp.Enabled = true;
                txtbEmailResp.Enabled = true;
            }
            else
            {
                txtbNomeResp.Enabled = false;
                mtbCpfResp.Enabled = false;
                dtpDataNascResp.Enabled = false;
                mtbTelefoneResp.Enabled = false;
                txtbEmailResp.Enabled = false;
            }
        }
        private Responsavel objResponsavel;

        private void btnSalvar_Click(object sender, EventArgs e)
        {            

            if (HelperFunctions.ChecaMenorDeIdade(dtpDataNasc.Value)&&objResponsavel.cpf == null)
            {
                MessageBox.Show("O cliente é menor de idade, selecione um Responsável!");
            }
            else if (txtbNomeCompletoCli.TextLength<3)
            {
                MessageBox.Show("Nome inválido, por favor, digite um nome válido!");
            }
            else if (HelperFunctions.ChecaMenorDeIdade(dtpDataNasc.Value) && objResponsavel.id!=0)
            {
                Cliente objCliente = new Cliente();
                objCliente.nome = txtbNomeCompletoCli.Text;
                objCliente.cpf = mtbCpf.Text;
                objCliente.dataNascimento = dtpDataNasc.Value;
                objCliente.email = txtbemail.Text;
                objCliente.endereco = txtbEndereco.Text;
                objCliente.cidade = cbCidade.Text;
                objCliente.estado = cbEstado.Text;
                objCliente.adicionalInfo = rtbAdicionalInfo.Text;

                objCliente.objResponsavel = objResponsavel;
                objCliente.Registrar();
                MessageBox.Show("CLiente Registrado e Vinculado ao Reponsável!");
                RetornarAoMenuAnterior();
            }
            else if (HelperFunctions.ChecaMenorDeIdade(dtpDataNasc.Value))
            {
                objResponsavel = new Responsavel();
                Cliente objCliente = new Cliente();
                objCliente.nome = txtbNomeCompletoCli.Text;
                objCliente.cpf = mtbCpf.Text;
                objCliente.dataNascimento = dtpDataNasc.Value;
                objCliente.email = txtbemail.Text;
                objCliente.endereco = txtbEndereco.Text;
                objCliente.cidade = cbCidade.Text;
                objCliente.estado = cbEstado.Text;
                objCliente.adicionalInfo = rtbAdicionalInfo.Text;

                if (HelperFunctions.ChecaMenorDeIdade(dtpDataNascResp.Value))
                {
                    MessageBox.Show("O responsável precisa ser maior de idade!");
                }
                objResponsavel.nome = txtbNomeResp.Text;
                objResponsavel.cpf = mtbCpf.Text;
                objResponsavel.dataNascimento = dtpDataNascResp.Value;
                objResponsavel.telefone = mtbTelefoneResp.Text;
                objResponsavel.email = txtbEmailResp.Text;
                if (objResponsavel.endereco == null)
                {
                    objResponsavel.endereco = txtbEndereco.Text;
                }
                if (objResponsavel.cidade == null)
                {
                    objResponsavel.cidade = cbCidade.Text;
                }
                if (objResponsavel.estado == null)
                {
                    objResponsavel.estado = cbEstado.Text;
                }

                objResponsavel.Registrar();
                objResponsavel = new Responsavel().PesquisarPorCPF(objResponsavel.cpf);
                objCliente.objResponsavel = objResponsavel;
                objCliente.Registrar();

                MessageBox.Show("Cliente e responsável vinculados e registrados com sucesso!");
                RetornarAoMenuAnterior();
            }
            else if (!HelperFunctions.ChecaMenorDeIdade(dtpDataNasc.Value))
            {
                Cliente objCliente = new Cliente();
                objCliente.nome = txtbNomeCompletoCli.Text;
                objCliente.cpf = mtbCpf.Text;
                objCliente.dataNascimento = dtpDataNasc.Value;
                objCliente.email = txtbemail.Text;
                objCliente.endereco = txtbEndereco.Text;
                objCliente.cidade = cbCidade.Text;
                objCliente.estado = cbEstado.Text;
                objCliente.adicionalInfo = rtbAdicionalInfo.Text;
                objCliente.Registrar();

                MessageBox.Show("Cliente Registrado com sucesso!");
                RetornarAoMenuAnterior();
            }
        }

        private void dtpDataNasc_ValueChanged(object sender, EventArgs e)
        {
            if (HelperFunctions.ChecaMenorDeIdade(dtpDataNasc.Value))
            {
                txtbNomeResp.Enabled = true;
                mtbCpfResp.Enabled = true;
                dtpDataNascResp.Enabled = true;
                mtbTelefoneResp.Enabled = true;
                txtbEmailResp.Enabled = true;
            }
            else
            {
                txtbNomeResp.Enabled = false;
                mtbCpfResp.Enabled = false;
                dtpDataNascResp.Enabled = false;
                mtbTelefoneResp.Enabled = false;
                txtbEmailResp.Enabled = false;
            }
        }

        private void RetornarAoMenuAnterior()
        {
            newFrmPrincipal.painelDinamico.Controls.Clear();
            userControlMenuNovo menuNovo = new userControlMenuNovo();
            menuNovo.AutoScroll = true;
            newFrmPrincipal.painelDinamico.Controls.Add(menuNovo);
            menuNovo.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dtgResponsavel.DataSource = new Responsavel().Pesquisar(txtbNomeRespPesquisa.Text);
        }

        private void dtgResponsavel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            objResponsavel = objResponsavel.Pesquisar(Convert.ToInt32(dtgResponsavel.CurrentRow.Cells["id"]));
            txtbNomeResp.Text = objResponsavel.nome;
            mtbCpfResp.Text = objResponsavel.cpf;
            dtpDataNascResp.Value = objResponsavel.dataNascimento;
            mtbTelefoneResp.Text = objResponsavel.telefone;
            txtbEmailResp.Text = objResponsavel.email;
        }
    }
}
