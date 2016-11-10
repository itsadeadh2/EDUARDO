﻿using System;
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
            HelperFunctions.SetButtons(btnClearPesquisa);
            HelperFunctions.SetButtons(btnPesquisar);
            if (HelperFunctions.ChecaMenorDeIdade(dtpDataNasc.Value))
            {
                AtivaResponsavel();
            }
            else
            {
                DesativaResponsavel();
            }
        }

        //- Variáveis
        private Responsavel objResponsavel = new Responsavel();
        private bool foiPesquisado;

        //- Métodos
        private void AtivaResponsavel()
        {
            txtbNomeResp.Enabled = true;
            mtbCpfResp.Enabled = true;
            dtpDataNascResp.Enabled = true;
            mtbTelefoneResp.Enabled = true;
            txtbEmailResp.Enabled = true;
            dtgResponsavel.Enabled = true;
            txtbNomeRespPesquisa.Enabled = true;
        }

        private void DesativaResponsavel()
        {
            txtbNomeResp.Enabled = false;
            mtbCpfResp.Enabled = false;
            dtpDataNascResp.Enabled = false;
            mtbTelefoneResp.Enabled = false;
            txtbEmailResp.Enabled = false;
            btnPesquisar.Enabled = false;
            dtgResponsavel.Enabled = false;
            txtbNomeRespPesquisa.Enabled = false;
        }

        private bool ChecaCPF(string cpfPessoa)
        {
            bool value = false;
            if (new Responsavel().PesquisarPorCPF(cpfPessoa) != null)
            {
                Responsavel objResponsavel = new Responsavel().PesquisarPorCPF(cpfPessoa);
                MessageBox.Show("O sistema já possui um cliente com este cpf!" + "\n Nome do cliente: " + objResponsavel.nome);
                value = true;
            }
            else if (new Cliente().PesquisarPorCpf(cpfPessoa) != null)
            {
                Cliente objCliente = new Cliente().PesquisarPorCpf(cpfPessoa);
                MessageBox.Show("O sistema já possui um cliente com este cpf!" + "\n Nome do cliente: " + objCliente.nome);
                value = true;
            }
            else if (new Medico().PesquisarPorCpf(cpfPessoa)!=null)
            {
                Medico objMedico = new Medico().PesquisarPorCpf(cpfPessoa);
                MessageBox.Show("O sistema já possui um Medico com este cpf!" + "\n Nome do cliente: " + objMedico.nome);
                value = true;
            }
            return value;
        }

        private bool ChecaCPF(string cpfResp, string cpfCli)
        {
            bool value = false;
            if (cpfResp == cpfCli)
            {
                MessageBox.Show("Os CPF do responsável não pode ser igual ao do Cliente!");
                value = true;
            }
            return value;
        }

        private bool ChecaNome(string nome)
        {
            bool value = false;
            if (nome.Length < 3)
            {
                MessageBox.Show("Nome inválido!");
                value = false;
            }
            return value;
        }

        private bool ChecaNomeSemAviso(string nome)
        {
            bool value = false;
            if (nome.Length < 3)
            {
                value = true;
            }
            return value;
        }

        private void RetornarAoMenuAnterior()
        {
            UserControl menuAnterior = new userControlMenuNovo();
            Controls.Clear();
            Controls.Add(menuAnterior);
        }

        //- Eventos
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            #region
            Cliente objCliente = new Cliente();
            objCliente.nome = txtbNomeCompletoCli.Text;
            objCliente.cpf = mtbCpf.Text;
            objCliente.dataNascimento = dtpDataNasc.Value;
            objCliente.email = txtbemail.Text;
            objCliente.endereco = txtbEndereco.Text;
            objCliente.cidade = cbCidade.Text;
            objCliente.estado = cbEstado.Text;
            objCliente.telefone = mtbTelefone.Text;
            objCliente.adicionalInfo = rtbAdicionalInfo.Text;
            if (HelperFunctions.ChecaMenorDeIdade(objCliente.dataNascimento))
            {
                if (foiPesquisado)
                {

                }
                else
                {
                    objResponsavel = new Responsavel();
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
                }
            }
            #endregion
            if (ChecaNome(objCliente.nome))
            {                
            }
            else if (ChecaCPF(objCliente.cpf)|| ChecaCPF(objResponsavel.cpf, objCliente.cpf))
            {
                mtbCpf.Focus();
            }
            else if (HelperFunctions.ChecaMenorDeIdade(objCliente.dataNascimento))
            {
                if (!foiPesquisado)
                {
                    if (ChecaNome(objResponsavel.nome))
                    {
                    }
                    else if (ChecaCPF(objResponsavel.cpf) || ChecaCPF(objResponsavel.cpf,objCliente.cpf))
                    {
                        mtbCpfResp.Focus();
                    }
                    objResponsavel.Registrar();
                    objResponsavel = objResponsavel.PesquisarPorCPF(objResponsavel.cpf);
                    objCliente.objResponsavel = objResponsavel;
                    objCliente.Registrar();
                    MessageBox.Show("Cliente e Responsável registrados e vinculados com sucesso!");

                    RetornarAoMenuAnterior();
                }
                else
                {
                    objResponsavel.Registrar();
                    objResponsavel = objResponsavel.PesquisarPorCPF(objResponsavel.cpf);
                    objCliente.objResponsavel = objResponsavel;
                    objCliente.Registrar();
                    MessageBox.Show("Cliente e Responsável registrados e vinculados com sucesso!");

                    RetornarAoMenuAnterior();
                }                
            }
            else
            {                
                objCliente.Registrar();
                RetornarAoMenuAnterior();
            }
        }

        private void dtpDataNasc_ValueChanged(object sender, EventArgs e)
        {
            if (HelperFunctions.ChecaMenorDeIdade(dtpDataNasc.Value))
            {
                AtivaResponsavel();
            }
            else
            {
                DesativaResponsavel();
            }
        }        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dtgResponsavel.DataSource = new Responsavel().Pesquisar(txtbNomeRespPesquisa.Text);
        }

        private void dtgResponsavel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            objResponsavel = objResponsavel.Pesquisar(Convert.ToInt32(dtgResponsavel.CurrentRow.Cells["id"].Value));
            txtbNomeResp.Text = objResponsavel.nome;
            mtbCpfResp.Text = objResponsavel.cpf;
            dtpDataNascResp.Value = objResponsavel.dataNascimento;
            mtbTelefoneResp.Text = objResponsavel.telefone;
            txtbEmailResp.Text = objResponsavel.email;
            btnSalvar.Focus();
            DesativaResponsavel();
            txtbNomeRespPesquisa.Enabled = true;            
            btnClearPesquisa.Visible = true;
            foiPesquisado = true;
        }

        private void dtpDataNascResp_Leave(object sender, EventArgs e)
        {

        }

        private void mtbCpf_Leave(object sender, EventArgs e)
        {

        }

        private void mtbCpfResp_Leave(object sender, EventArgs e)
        {

        }

        private void txtbNomeCompletoCli_Leave(object sender, EventArgs e)
        {
            ptErrorNomeCli.Visible = ChecaNomeSemAviso(txtbNomeCompletoCli.Text);
           
        }

        private void txtbNomeResp_Leave(object sender, EventArgs e)
        {
            ChecaNome(txtbNomeResp.Text);
        }

        private void txtbNomeRespPesquisa_Leave(object sender, EventArgs e)
        {
            ChecaNome(txtbNomeRespPesquisa.Text);
        }

        private void txtbNomeRespPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtbNomeRespPesquisa.TextLength<3)
            {
                btnPesquisar.Enabled = false;
            }
            else if (txtbNomeRespPesquisa.TextLength>=3)
            {
                btnPesquisar.Enabled = true;
            }
        }

        private void btnClearPesquisa_Click(object sender, EventArgs e)
        {
            objResponsavel = new Responsavel();
            txtbNomeResp.Clear();
            mtbCpfResp.Clear();
            mtbTelefone.Clear();
            dtpDataNascResp.ResetText();
            txtbEmailResp.Clear();
            dtgResponsavel.DataSource = null;
            dtgResponsavel.Update();
            txtbNomeRespPesquisa.Clear();
            btnClearPesquisa.Visible = false;
            if (HelperFunctions.ChecaMenorDeIdade(dtpDataNasc.Value))
            {
                AtivaResponsavel();
            }
        }
    }
}