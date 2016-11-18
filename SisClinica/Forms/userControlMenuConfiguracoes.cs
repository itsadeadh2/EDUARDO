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
        private bool ChecarConsultorio(string checkConsult)
        {
            bool value = false;
            if (new Consultorio().PesquisarPorNome(checkConsult) != null)
            {
                Consultorio objConsultorio = new Consultorio().PesquisarPorNome(checkConsult);
                MessageBox.Show("O sistema ja possui um consultorio com esse nome" + "nome do consultorio:" + objConsultorio.nomeConsultorio);
                value = true;
            }
            return value;
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

            if (ChecarConsultorio(objConsultorio.nomeConsultorio))
            {

            }
            else
            {
                objConsultorio.Registrar();
                mtbNomeConsult.Clear();
                MessageBox.Show("Novo Consultorio Registrado com sucesso");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TipoDeTratamento objTipo = new TipoDeTratamento();
            objTipo.nome = mtbNomeTratamento.Text;
            objTipo.valor = Convert.ToDecimal(mtbValorTratamento.Text);
            objTipo.CadastrarNovoTipo();
            mtbNomeTratamento.Clear();
            mtbValorTratamento.Clear();
            MessageBox.Show("Novo Tratamento Cadastrado com sucesso.");
        }
    }
}
