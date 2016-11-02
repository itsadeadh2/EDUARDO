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
    public partial class frmAlterarMedico : Form
    {
        public frmAlterarMedico()
        {
            InitializeComponent();
        }
        private Medico objMedico;
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            using (var form = new formBuscaMedico())
            {
                var result = form.ShowDialog();
                if (result==DialogResult.OK)
                {
                    objMedico = form.objMedico;
                }
            }
            if (objMedico!=null)
            {
                txtbNome.Text = objMedico.nome;
                txtbEmail.Text = objMedico.email;
                txtbTelefone.Text = objMedico.telefone;
                txtbEndereco.Text = objMedico.endereco;
                txtbEstado.Text = objMedico.cidadeEstado;
                txtbCidade.Text = objMedico.cidadeEstado;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            objMedico.nome = txtbNome.Text;
            objMedico.email = txtbEmail.Text;
            objMedico.telefone = txtbTelefone.Text;
            objMedico.endereco = txtbEndereco.Text + ", " + txtbBairro.Text + ", " + txtbNome;
            objMedico.cidadeEstado = txtbCidade.Text + "/" + txtbCidade.Text;
            objMedico.Alterar();
            MessageBox.Show("Médico Alterado!");
            Close();
        }
    }
}
