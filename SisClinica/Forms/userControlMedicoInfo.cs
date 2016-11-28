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
            HelperFunctions.SetButtonsText(btnSalvar);
            HelperFunctions.SetButtonsText(btnCancelar);
            HelperFunctions.SetButtonsText(btnAlterar);
            
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
            uc.cbEstado.DisplayMember = "siglaEstado";
            uc.cbEstado.ValueMember = "idEstado";
            uc.cbEstado.DataSource = new PaisEstadoCidade().BuscarTodosOsEstados();
            uc.cbEstado.DisplayMember = "siglaEstado";
            uc.cbEstado.ValueMember = "idEstado";
            uc.cbEstado.SelectedIndex = uc.cbEstado.FindStringExact(uc.objMedico.estado);
            uc.cbCidade.SelectedIndex = uc.cbCidade.FindStringExact(uc.objMedico.cidade);
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
        private void SetCidade()
        {
            cbCidade.DataSource = new PaisEstadoCidade().BuscarCidadesPorEstado(Convert.ToInt32(cbEstado.SelectedValue));
            cbCidade.DisplayMember = "nomeCidade";
            cbCidade.ValueMember = "idCidade";
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
                objMedico.email = txtbEmail.Text;
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
            userControlMedicoInfo uc = new userControlMedicoInfo().Preencher(objMedico);
            Controls.Clear();
            Controls.Add(uc);
            uc.Show();
        }

        private void dtgSessoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (new Sessoes().BuscaPorId(Convert.ToInt32(dtgSessoes.CurrentRow.Cells["id"].Value)).tipoDeSessao == "Consulta")
                {
                    Controls.Clear();
                    userControlAlterarSessoes alterCon = new userControlAlterarSessoes().Preencher(new Sessoes().BuscaPorId(Convert.ToInt32(dtgSessoes.CurrentRow.Cells["id"].Value)));
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

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCidade();
        }
    }
}
