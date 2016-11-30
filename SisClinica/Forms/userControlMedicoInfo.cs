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
        public userControlMedicoInfo(Medico objMed)
        {
            InitializeComponent();
            HelperFunctions.SetButtonsText(btnSalvar);
            HelperFunctions.SetButtonsText(btnCancelar);
            HelperFunctions.SetButtonsText(btnAlterar);

            txtbnome.Text = objMed.nome;
            
            txtbEmail.Text = objMed.email;
            mtbTelefone.Text = objMed.telefone;
            txtbEndereco.Text = objMed.endereco;
            dtgSessoes.DataSource = new Sessoes().DataTableBuscaPorMedico(objMed);
            objMedico = objMed;
            cbEstado.DisplayMember = "siglaEstado";
            cbEstado.ValueMember = "idEstado";
            cbEstado.DataSource = new PaisEstadoCidade().BuscarTodosOsEstados();
            cbEstado.DisplayMember = "siglaEstado";
            cbEstado.ValueMember = "idEstado";
            cbEstado.SelectedValue = objMed.paisEstadoCidade.idEstado;
            cbCidade.SelectedValue = objMed.paisEstadoCidade.idCidade;
        }

        //-Atributos
        Medico objMedico;

        //-Eventos
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
                objMedico.paisEstadoCidade = new PaisEstadoCidade().BuscarCidade(Convert.ToInt32(cbCidade.SelectedValue));
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
            userControlMedicoInfo uc = new userControlMedicoInfo(objMedico);
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
                    userControlAlterarSessoes alterCon = new userControlAlterarSessoes(new Sessoes().BuscaPorId(Convert.ToInt32(dtgSessoes.CurrentRow.Cells["id"].Value)));
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

        //-Métodos
        private void SetCidade()
        {
            cbCidade.DataSource = new PaisEstadoCidade().BuscarCidadesPorEstado(Convert.ToInt32(cbEstado.SelectedValue));
            cbCidade.DisplayMember = "nomeCidade";
            cbCidade.ValueMember = "idCidade";
        }
    }
}
