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
    public partial class frmRegistraCliente : Form
    {
        public frmRegistraCliente()
        {
            InitializeComponent();
        }
        Responsavel objResponsavel = new Responsavel();

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (checaData()&&objResponsavel.cpf==null)
                {
                    MessageBox.Show("O cliente é menor de idade, selecione um Responsável!");                       
                }
                else if (txtBoxNomeCompleto.TextLength<3)
                {
                    MessageBox.Show("Nome inválido, por favor, digite um nome válido!");
                }
                else if (checaData()&&objResponsavel.id!=0)
                {
                    Cliente objCliente = new Cliente();
                    objCliente.nome = txtBoxNomeCompleto.Text;
                    objCliente.cpf = mskdCPF.Text;
                    objCliente.dataNascimento = dtpDataDeNascimento.Value;
                    objCliente.telefone = mskTxtBoxTelefone.Text;
                    objCliente.email = txtBoxEmail.Text;
                    objCliente.endereco = txtBoxEndereco.Text + ", " + txtBoxNumero.Text + ", " + txtBoxBairro.Text;
                    objCliente.cidadeEstado = cbCidadeRegCliente.Text + cbEstadoRegCliente.Text;
                    objCliente.adicionalInfo = rtbAdicionalInfo.Text;

                    objCliente.objResponsavel = objResponsavel;
                    objCliente.Registrar();
                    MessageBox.Show("Cliente registrado e vinculado ao Responsável!");
                    Close();
                }
                else if (checaData())
                {
                    Cliente objCliente = new Cliente();
                    objCliente.nome = txtBoxNomeCompleto.Text;
                    objCliente.cpf = mskdCPF.Text;
                    objCliente.dataNascimento = dtpDataDeNascimento.Value;
                    objCliente.telefone = mskTxtBoxTelefone.Text;
                    objCliente.email = txtBoxEmail.Text;
                    objCliente.endereco = txtBoxEndereco.Text + ", " + txtBoxNumero.Text + ", " + txtBoxBairro.Text;
                    objCliente.cidadeEstado = cbCidadeRegCliente.Text + cbEstadoRegCliente.Text;
                    objCliente.adicionalInfo = rtbAdicionalInfo.Text;

                    objResponsavel.endereco = txtBoxEndereco.Text + ", " + txtBoxNumero.Text + ", " + txtBoxBairro.Text;
                    objResponsavel.cidadeEstado  = cbCidadeRegCliente.Text + cbEstadoRegCliente.Text;
                    objCliente.objResponsavel = objResponsavel;
                    objResponsavel.Registrar();
                    objCliente.Registrar();

                    MessageBox.Show("Cliente e Responsável vinculados e registrados com sucesso!");
                    Close();
                }
                else if (!checaData())
                {
                    Cliente objCliente = new Cliente();
                    objCliente.nome = txtBoxNomeCompleto.Text;
                    objCliente.cpf = mskdCPF.Text;
                    objCliente.dataNascimento = dtpDataDeNascimento.Value;
                    objCliente.telefone = mskTxtBoxTelefone.Text;
                    objCliente.email = txtBoxEmail.Text;
                    objCliente.endereco = txtBoxEndereco.Text + ", " + txtBoxNumero.Text + ", " + txtBoxBairro.Text;
                    objCliente.cidadeEstado = cbCidadeRegCliente.Text + cbEstadoRegCliente.Text;
                    objCliente.adicionalInfo = rtbAdicionalInfo.Text;

                    objCliente.Registrar();

                    MessageBox.Show("Cliente Registrado com sucesso!");
                    Close();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscaCliente fcliente = new frmBuscaCliente();
            fcliente.Show();
        }
        private void btnSelecionarResponsavel_Click(object sender, EventArgs e)
        {
            using (var form = new frmBuscaResponsavel())
            {
                var result = form.ShowDialog();
                if (result==DialogResult.OK)
                {
                    objResponsavel = form.objResponsavel;
                }
            }            
        }

        private void dtpDataDeNascimento_ValueChanged(object sender, EventArgs e)
        {
            checaData();
        }

        private void frmRegistraCliente_Load(object sender, EventArgs e)
        {
            checaData();
        }

        /// <summary>
        /// Checa se a data informada no DateTimePicker é correspondente a uma pessoa maior de idade.
        /// </summary>
        /// <returns>true para maior de idade, false para menor de idade</returns>
        private bool checaData()
        {
            if (DateTime.Now.Year - dtpDataDeNascimento.Value.Year < 18)
            {                
                btnSelecionarResponsavel.Visible = true;
                return true;
            }
            else
            {
                btnSelecionarResponsavel.Visible = false;
                return false;
            }
        }

    }
}
