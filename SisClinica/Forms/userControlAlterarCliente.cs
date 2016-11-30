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
        public userControlAlterarCliente(Cliente objCli)
        {
            InitializeComponent();
            HelperFunctions.SetButtons(btnSalvar);
            objCliente = objCli;
            txtbNomeCompletoCli.Text = objCliente.nome;
            mtbTelefone.Text = objCliente.telefone;
            txtbemail.Text = objCliente.email;
            txtbEndereco.Text = objCliente.endereco;
            cbCidade.SelectedValue = objCliente.paisEstadoCidade.idCidade;
            cbEstado.SelectedValue = objCliente.paisEstadoCidade.idEstado;
            rtbAdicionalInfo.Text = objCliente.adicionalInfo;
            if (objCliente.objResponsavel != null)
            {
                linklblResponsavel.Text = objCliente.objResponsavel.nome;
            }
            else
            {
               linklblResponsavel.Enabled = false;
            }
            cbEstado.DisplayMember = "siglaEstado";
            cbEstado.ValueMember = "idEstado";
            cbEstado.DataSource = new PaisEstadoCidade().BuscarTodosOsEstados();
            cbEstado.DisplayMember = "siglaEstado";
            cbEstado.ValueMember = "idEstado";
            cbEstado.SelectedValue = objCliente.paisEstadoCidade.idEstado;
            cbCidade.SelectedValue = objCliente.paisEstadoCidade.idCidade;

        }
        Cliente objCliente;

        //-Eventos
        private void linklblResponsavel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controls.Clear();
            userControlResponsavelInfo ucResp = new userControlResponsavelInfo(objCliente.objResponsavel);
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
                objCliente.paisEstadoCidade = new PaisEstadoCidade().BuscarCidade(Convert.ToInt32(cbCidade.SelectedValue)); //cbCidade.Text;
                objCliente.adicionalInfo = rtbAdicionalInfo.Text;
                objCliente.Alterar();
                MessageBox.Show("Cliente alterado!");
            }
        }
        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCidade();
        }

        //-Métodos
        private void SetCidade()
        {
            cbCidade.DataSource = new PaisEstadoCidade().BuscarCidadesPorEstado(Convert.ToInt32(cbEstado.SelectedValue));
            cbCidade.DisplayMember = "nomeCidade";
            cbCidade.ValueMember = "idCidade";
        }
    }
}
