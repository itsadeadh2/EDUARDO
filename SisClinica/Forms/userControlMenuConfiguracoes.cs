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
    public partial class userControlMenuConfiguracoes : UserControl
    {
        newFrmPrincipal formprin = null;
        public userControlMenuConfiguracoes(newFrmPrincipal frmPrin)
        {
            InitializeComponent();
            HelperFunctions.SetButtonsText(btnCadastrar);
            HelperFunctions.SetButtonsText(btnDark);
            HelperFunctions.SetButtonsText(btnDasNeves);
            HelperFunctions.SetButtonsText(btnBizantino);
            formprin = frmPrin;
        }

        private void btnConfigurarHorarios_Click(object sender, EventArgs e)
        {
            userControlHorarios conHora = new userControlHorarios();
            Controls.Clear();
            Controls.Add(conHora);
            conHora.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formprin.SetSkin(newFrmPrincipal.skin.darkTrevosoSombrioDasTrevas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formprin.SetSkin(newFrmPrincipal.skin.macacoDasNeves);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formprin.SetSkin(newFrmPrincipal.skin.macacoBizantino);
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Consultorio objConsultorio = new Consultorio();
            objConsultorio.nomeConsultorio = mtbNomeConsult.Text;
            objConsultorio.Registrar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TipoDeTratamento objTipo = new TipoDeTratamento();
            objTipo.nome = mtbNomeTratamento.Text;
            objTipo.valor = Convert.ToDecimal(mtbValorTratamento.Text);
            objTipo.CadastrarNovoTipo();
        }
    }
}
