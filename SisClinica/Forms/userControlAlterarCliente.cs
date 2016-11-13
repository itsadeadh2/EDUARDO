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
    public partial class userControlAlterarCliente : UserControl
    {
        public userControlAlterarCliente()
        {
            InitializeComponent();
            HelperFunctions.SetButtons(btnSalvar);
        }
        Cliente objCliente;
        public userControlAlterarCliente Preencher(Cliente objCli)
        {
            userControlAlterarCliente uc = new userControlAlterarCliente();
            uc.objCliente = objCli;
            uc.txtbNomeCompletoCli.Text = uc.objCliente.nome;
            uc.mtbTelefone.Text = uc.objCliente.telefone;
            uc.txtbemail.Text = uc.objCliente.email;
            uc.txtbEndereco.Text = uc.objCliente.endereco;
            uc.cbCidade.Text = uc.objCliente.cidade;
            uc.cbEstado.Text = uc.objCliente.estado;
            uc.rtbAdicionalInfo.Text = uc.objCliente.adicionalInfo;
            if (uc.objCliente.objResponsavel!=null)
            {
                uc.linklblResponsavel.Text = uc.objCliente.objResponsavel.nome;
            }
            else
            {
                uc.linklblResponsavel.Enabled = false;
            }
            return uc;
        }

        private void linklblResponsavel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controls.Clear();
            userControlResponsavelInfo ucResp = new userControlResponsavelInfo().Preencher(objCliente.objResponsavel);
            Controls.Add(ucResp);
            ucResp.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (HelperFunctions.ChecaNome(txtbNomeCompletoCli.Text))
            {
                MessageBox.Show("Nome inválido, o nome precisa ter mais que três caracteres!");
            }
            else
            {
                objCliente.nome = txtbNomeCompletoCli.Text;
                objCliente.telefone = mtbTelefone.Text;
                objCliente.email = txtbemail.Text;
                objCliente.endereco = txtbEndereco.Text;
                objCliente.cidade = cbCidade.Text;
                objCliente.estado = cbEstado.Text;
                objCliente.Alterar();
                MessageBox.Show("Cliente alterado!");
            }
        }
    }
}
