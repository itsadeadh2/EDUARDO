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
        public userControlMenuConfiguracoes(newFrmPrincipal frmPrin)
        {
            InitializeComponent();
            HelperFunctions.SetButtonsText(btnCadastrar);
            HelperFunctions.SetButtonsText(btnCadastrarTratamento);
            HelperFunctions.SetButtonsText(btnDark);
            HelperFunctions.SetButtonsText(btnDasNeves);
            HelperFunctions.SetButtonsText(btnBizantino);
            formprin = frmPrin;
        }

        //-Atributos
        newFrmPrincipal formprin = null;

        //-Eventos
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
            else if (mtbNomeConsult.Text.Length <1)
            {
                MessageBox.Show("Não pode registrar consultorio sem um nome, digite um nome para o consultorio");
            }
            else if (mtbNomeConsult.Text.Length >5)
            {
                MessageBox.Show("O Consultorio só pode ter de 1 a 5 Caracteres");
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
            TipoDeTratamento objTratamento = new TipoDeTratamento();
            objTratamento.nome = mtbNomeTratamento.Text;

            if (ChecarTratamento(objTratamento.nome))
            {

            } 
             else if  (mtbValorTratamento.Text.Length < 1 && mtbNomeTratamento.Text.Length < 1)
            {
                MessageBox.Show("Digite um Nome para o tratamento e o Valor do tratamento");
            }
            else if (mtbValorTratamento.Text.Length < 1)
            {
                MessageBox.Show("Digite um valor para o tratamento.");
            }
            else if (mtbNomeTratamento.Text.Length < 1)
            {
                MessageBox.Show("Digite um nome para o Tratamento.");
            }
            else
            {
            objTratamento.valor = Convert.ToDecimal(mtbValorTratamento.Text);
            objTratamento.CadastrarNovoTipo();
            mtbNomeTratamento.Clear();
            mtbValorTratamento.Clear();
            MessageBox.Show("Novo Tratamento Cadastrado com sucesso.");
            }
        }
        private void mtbNomeConsult_Leave(object sender, EventArgs e)
        {

        }

        //-Métodos
        private bool ChecarConsultorio(string checkConsult)
        {
            bool value = false;
            if (new Consultorio().PesquisarPorNome(checkConsult) != null)
            {
                Consultorio objConsultorio = new Consultorio().PesquisarPorNome(checkConsult);
                MessageBox.Show("O sistema ja possui em registro um consultório com esse nome: " + objConsultorio.nomeConsultorio);
                value = true;
            }
            return value;
        }
        private bool ChecarTratamento(string CheckTrat)
        {
            bool value = false;
            if (new TipoDeTratamento().PesquisarPorNome(CheckTrat) != null)
            {
                TipoDeTratamento objTratamento = new TipoDeTratamento().PesquisarPorNome(CheckTrat);
                MessageBox.Show("Já possui um Tratamento com esse nome: " + objTratamento.nome);
                value = true;
            }
            return value;
        }
    }
}
