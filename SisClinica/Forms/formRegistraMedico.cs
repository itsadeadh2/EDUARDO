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
using SisClinica.DAO;

namespace SisClinica.Forms
{
    public partial class formRegistraMedico : Form
    {
        public formRegistraMedico()
        {
            InitializeComponent();
        }

        private void btnSalvarRegMedico_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarMedico_Click(object sender, EventArgs e)
        {
            try
            {

                Medico objMedico = new Medico();
                objMedico.nome = txtBoxNomeRegistraMedico.Text;
                objMedico.cpf = msktxtboxCpfRegistraMedico.Text;
                objMedico.crm = mskdtxtbxCRM.Text + "-" + mskdTxtBoxDigitoCRM.Text + cbEstado.Text;
                objMedico.dataNascimento = dtpDataNascimento.Value;
                objMedico.telefone = msktxtboxTelefoneRegMedico.Text;
                objMedico.endereco = txtboxEnderecoRegMedico.Text + ", " + txtboxNumeroRegMedico.Text + ", " + txtboxBairroRegMedico.Text;
                objMedico.cidadeEstado = cbCidadeRegMedico.Text + "/" + cbEstadoRegMedico.Text;
                objMedico.email = txtboxEmailRegMedico.Text;

                objMedico.Registrar();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
    }
}
