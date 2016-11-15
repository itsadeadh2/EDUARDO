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
        public userControlResponsavelInfo()
        {
            InitializeComponent();
            HelperFunctions.SetButtonsText(btnSalvar);
            HelperFunctions.SetButtonsText(btnAlterar);
            HelperFunctions.SetButtonsText(btnCancelar);
            HelperFunctions.SetButtonsText(btnVoltar);
        }
        Responsavel objResponsavel;
        public userControlResponsavelInfo Preencher(Responsavel objResp)
        {
            userControlResponsavelInfo uc = new userControlResponsavelInfo();
            uc.objResponsavel = new Responsavel().Pesquisar(objResp.id);
            uc.txtbNome.Text = uc.objResponsavel.nome;
            uc.lblCPF.Text = uc.objResponsavel.cpf;
            uc.dtpDataNasc.Value = uc.objResponsavel.dataNascimento;
            uc.mtbTelefone.Text = uc.objResponsavel.telefone;
            uc.txtbEmail.Text = uc.objResponsavel.email;
            return uc;
        }

        // - Métodos
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
            userControlAlterarCliente alterCli = new userControlAlterarCliente().Preencher(new Cliente().PesquisarPorResponsavel(objResponsavel));
            Controls.Add(alterCli);
            alterCli.Show();
        }

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
    }
}
