using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClinica.Classes;
using System.Windows.Forms;

namespace SisClinica.Forms
{
    public partial class userControlRegistraMedico : UserControl
    {
        public userControlRegistraMedico()
        {
            InitializeComponent();
            HelperFunctions.SetButtonsText(btnSalvar);
            cbEstado.ValueMember = "idEstado";
            cbEstado.DisplayMember = "siglaEstado";
            cbEstado.DataSource = new PaisEstadoCidade().BuscarTodosOsEstados();
            cbEstado.ValueMember = "idEstado";
            cbEstado.DisplayMember = "siglaEstado";
            cbEstadoCRM.ValueMember = "idEstado";
            cbEstadoCRM.DisplayMember = "siglaEstado";
            cbEstadoCRM.DataSource = new PaisEstadoCidade().BuscarTodosOsEstados();
            cbEstadoCRM.ValueMember = "idEstado";
            cbEstadoCRM.DisplayMember = "siglaEstado";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Medico objMedico = new Medico();
            objMedico.nome = txtbnome.Text;
            objMedico.cpf = mtbCPF.Text;
            objMedico.crm = mtbCRM.Text + "-" + txtbDigitoCRM.Text + cbEstadoCRM.Text;
            objMedico.dataNascimento = dtpDataNasc.Value;
            objMedico.telefone = mtbTelefone.Text;
            objMedico.endereco = txtbEndereco.Text;
            objMedico.cidade = cbCidade.Text;
            objMedico.estado = cbEstado.Text;
            objMedico.email = txtbEmail.Text;

            if (objMedico.nome.Length<3)
            {
                MessageBox.Show("Nome inválido!");
                txtbnome.Focus();
            }
            else if (ChecaCPF(objMedico.cpf))
            {

            }

            else if (new Medico().PesquisarPorCRM(objMedico.crm)!=null)
            {
                objMedico = objMedico.PesquisarPorCRM(objMedico.crm);
                MessageBox.Show("O sistema já possui um médico com este CRM" + "\n Nome do médico: " + objMedico.nome);
            }
            else if (HelperFunctions.ChecaMenorDeIdade(dtpDataNasc.Value))
            {
                MessageBox.Show("O médico não pode ser menor de idade!");
            }
            else
            {
                objMedico.Registrar();
                MessageBox.Show("Médico registrado com sucesso!");

                Controls.Clear();
                UserControl menuAnterior = new userControlMenuNovo();
                Controls.Add(menuAnterior);
                menuAnterior.Show();
            }
        }
        private void SetCidade()
        {
            cbCidade.DataSource = new PaisEstadoCidade().BuscarCidadesPorEstado(Convert.ToInt32(cbEstado.SelectedValue));
            cbCidade.DisplayMember = "nomeCidade";
            cbCidade.ValueMember = "idCidade";
        }

        private void txtbnome_Leave(object sender, EventArgs e)
        {
            if (txtbnome.TextLength<3)
            {
                ptbNomeError.Visible = true;
            }
            else
            {
                ptbNomeError.Visible = false;
            }
        }

        private void dtpDataNasc_Leave(object sender, EventArgs e)
        {
            if (HelperFunctions.ChecaMenorDeIdade(dtpDataNasc.Value))
            {
                ptbDtNascError.Visible = true;
            }
            else
            {
                ptbDtNascError.Visible = false;
            }
        }

        private void mtbCPF_Leave(object sender, EventArgs e)
        {
            if (ChecaCPFSemMensagem(mtbCPF.Text))
            {
                ptbCPFError.Visible = true;
            }
            else
            {
                ptbCPFError.Visible = false;
            }
        }

        private void dtpDataNasc_ValueChanged(object sender, EventArgs e)
        {
            if (HelperFunctions.ChecaMenorDeIdade(dtpDataNasc.Value))
            {
                ptbDtNascError.Visible = true;
            }
            else
            {
                ptbDtNascError.Visible = false;
            }
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
            else if (new Medico().PesquisarPorCpf(cpfPessoa) != null)
            {
                Medico objMedico = new Medico().PesquisarPorCpf(cpfPessoa);
                MessageBox.Show("O sistema já possui um Medico com este cpf!" + "\n Nome do cliente: " + objMedico.nome);
                value = true;
            }
            return value;
        }
        private bool ChecaCPFSemMensagem(string cpfPessoa)
        {
            bool value = false;
            if (new Responsavel().PesquisarPorCPF(cpfPessoa) != null)
            {
                value = true;
            }
            else if (new Cliente().PesquisarPorCpf(cpfPessoa) != null)
            {
                value = true;
            }
            else if (new Medico().PesquisarPorCpf(cpfPessoa) != null)
            {
                value = true;
            }
            return value;
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCidade();
        }
    }
}
