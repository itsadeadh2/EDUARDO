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
    public partial class frmRegistrarConsultorio : Form
    {
        public frmRegistrarConsultorio()
        {
            InitializeComponent();
            txtBNome.PromptChar = ' ';
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = new Consultorio().Pesquisar(txtBNome.Text);
            if (dt!=null)
            {
                MessageBox.Show("Já existe um consultório com este nome, por favor, insira outro nome!");
                txtBNome.Clear();
            }
            else if (dt==null)
            {
                Consultorio objConsultorio = new Consultorio();
                objConsultorio.nomeConsultorio = txtBNome.Text;
                objConsultorio.Registrar();
                MessageBox.Show("Consultório registrado com sucesso!");
                Close();
            }
        }
    }
}
