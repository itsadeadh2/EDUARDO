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
    public partial class userControlResponsavelInfo : UserControl
    {
        UserControl menuA;
        public userControlResponsavelInfo(Responsavel objResp)
        {
            InitializeComponent();
            HelperFunctions.SetButtonsText(btnSalvar);
            HelperFunctions.SetButtonsText(btnAlterar);
            HelperFunctions.SetButtonsText(btnCancelar);
            HelperFunctions.SetButtonsText(btnVoltar);

            objResponsavel = new Responsavel().Pesquisar(objResp.id);
            txtbNome.Text = objResponsavel.nome;
            lblCPF.Text = objResponsavel.cpf;
            dtpDataNasc.Value = objResponsavel.dataNascimento;
            mtbTelefone.Text = objResponsavel.telefone;
            txtbEmail.Text = objResponsavel.email;
            dtgClientes.DataSource = new Cliente().PesquisarPorResponsavel(objResponsavel);
        }

        //-Atributos
        Responsavel objResponsavel;        

        //-Métodos
        private void Salvar()
        {
            if (HelperFunctions.ChecaMenorDeIdade(dtpDataNasc.Value))
            {

            }
            else
            {
                objResponsavel.nome = txtbNome.Text;
                objResponsavel.dataNascimento = dtpDataNasc.Value;
                objResponsavel.telefone = mtbTelefone.Text;
                objResponsavel.email = txtbEmail.Text;
                objResponsavel.Alterar();
                MessageBox.Show("Responsável alterado!");
                txtbNome.Enabled = false;
                dtpDataNasc.Enabled = false;
                mtbTelefone.Enabled = false;
                txtbEmail.Enabled = false;
                btnSalvar.Enabled = true;
                btnVoltar.Enabled = true;
                btnSalvar.Visible = false;
                btnCancelar.Visible = false;
            }
        }
        private void Cancelar()
        {
            txtbNome.Text = objResponsavel.nome;
            dtpDataNasc.Value = objResponsavel.dataNascimento;
            mtbTelefone.Text = objResponsavel.telefone;
            txtbEmail.Text = objResponsavel.email;
            btnSalvar.Enabled = true;
            btnVoltar.Enabled = true;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
        }
        private void Voltar()
        {
            Controls.Clear();
            userControlPesquisarCliente uc = new userControlPesquisarCliente();
            Controls.Add(uc);
            uc.Show();
        }

        //-Eventos
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtbEmail.Enabled = true;
            txtbNome.Enabled = true;
            dtpDataNasc.Enabled = true;
            mtbTelefone.Enabled = true;
            txtbEmail.Enabled = true;
            btnAlterar.Enabled = false;
            btnVoltar.Enabled = false;
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void dtgClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Controls.Clear();
            userControlClienteInfo uc = new userControlClienteInfo(new Cliente().PesquisarPorCpf(dtgClientes.CurrentRow.Cells["CPF"].Value.ToString()));
            Controls.Add(uc);
            uc.Show();
        }
    }
}
