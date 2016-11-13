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
    public partial class userControlMedicoInfo : UserControl
    {
        public userControlMedicoInfo()
        {
            InitializeComponent();
        }

        Medico objMedico;

        public userControlMedicoInfo Preencher(Medico objMed)
        {
            userControlMedicoInfo uc = new userControlMedicoInfo();
            uc.txtbnome.Text = objMed.nome;
            uc.cbEstado.Text = objMed.estado;
            uc.cbCidade.Text = objMed.cidade;
            uc.txtbEmail.Text = objMed.email;
            uc.mtbTelefone.Text = objMed.telefone;
            uc.txtbEndereco.Text = objMed.endereco;

            uc.dtgSessoes.DataSource = new Sessoes().DataTableBuscaPorMedico(objMed);
            uc.objMedico = objMed;
            return uc;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;

            txtbnome.Enabled = true;
            cbEstado.Enabled = true;
            cbCidade.Enabled = true;
            txtbEmail.Enabled = true;
            mtbTelefone.Enabled = true;
            txtbEndereco.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (HelperFunctions.ChecaNome(txtbnome.Text))
            {
                MessageBox.Show("Nome inválido, o nome precisa ter no mínimo três caracteres!");
            }
            else
            {
                objMedico.nome = txtbnome.Text;
                objMedico.estado = cbEstado.Text;
                objMedico.cidade = cbCidade.Text;
                objMedico.telefone = mtbTelefone.Text;
                objMedico.endereco = txtbEndereco.Text;
                objMedico.Alterar();
                MessageBox.Show("Médico alterado!");
                txtbnome.Enabled = false;
                cbEstado.Enabled = false;
                cbCidade.Enabled = false;
                txtbEmail.Enabled = false;
                mtbTelefone.Enabled = false;
                txtbEndereco.Enabled = false;
                btnSalvar.Visible = false;
                btnCancelar.Visible = false;
                btnAlterar.Enabled = true;
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtbnome.Text = objMedico.nome;
            cbEstado.Text = objMedico.estado;
            cbCidade.Text = objMedico.cidade;
            txtbEmail.Text = objMedico.email;
            mtbTelefone.Text = objMedico.telefone;
            txtbEndereco.Text = objMedico.endereco;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            btnAlterar.Enabled = true;
        }

        private void dtgSessoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (new Sessoes().BuscaPorId(Convert.ToInt32(dtgSessoes.CurrentRow.Cells["id"].Value)).tipoDeSessao == "Consulta")
            {
                Controls.Clear();
                userControlAlterarConsulta alterCon = new userControlAlterarConsulta().Preencher(new Sessoes().BuscaPorId(Convert.ToInt32(dtgSessoes.CurrentRow.Cells["id"].Value)));
                Controls.Add(alterCon);
                alterCon.Show();
            }
            else
            {

            }
        }
    }
}
