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
    public partial class userControlAgendarProximoTratamento : UserControl
    {
        public userControlAgendarProximoTratamento()
        {
            InitializeComponent();                    
        }

        private Cliente objCliente;
        private Sessoes objSessao = new Sessoes();        
        private string turno;
        private bool editable = false;
        // - Métodos

        public userControlAgendarProximoTratamento Preencher(Sessoes objS)
        {
            userControlAgendarProximoTratamento uc = new userControlAgendarProximoTratamento();
            uc.cbMedicos.DataSource = new Medico().Pesquisar();
            uc.cbConsultorios.DataSource = new Consultorio().Pesquisar();
            uc.cbTipoDeTratamento.DataSource = new TipoDeTratamento().Pesquisar();
            uc.cbTipoDeTratamento.DisplayMember = "nome";
            uc.cbTipoDeTratamento.ValueMember = "id";
            uc.lblVisCli.Text = "Cliente: " + objS.objCliente.nome;
            uc.lblValorPorSessao.Text = "Valor por sessão: " + "R$" + objS.valorSessao;
            uc.lblValortotal.Text = "Valor total: " + "R$" + objS.tipoDeTratamento.valor;
            uc.objSessao = objS; 
            uc.ChecaTurno();

            return uc;
        }

        private void ChecaTurno()
        {
            if (rdbManha.Checked)
            {
                turno = "Manhã";
            }
            else
            {
                turno = "Tarde";
            }
            if (objSessao.medicoResponsavel == null || objSessao.objConsultorio == null)
            {

            }
            else
            {
                SetHora();
            }

        }
        private void SetHora()
        {
            cbHorarioInicial.DataSource = new Sessoes().GerarListaDeHorariosIniciais(dtpData.Value, objSessao.medicoResponsavel, objSessao.objConsultorio, turno, objSessao);
        }
        private void SetConsultorio()
        {
            if (objSessao.medicoResponsavel == null)
            {
                objSessao.objConsultorio = new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorios.SelectedValue));
            }
            else
            {
                objSessao.objConsultorio = new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorios.SelectedValue));
            }
        }
        private void SetMedico()
        {
            if (objSessao.objConsultorio == null)
            {
                objSessao.medicoResponsavel = new Medico().Pesquisar(Convert.ToInt32(cbMedicos.SelectedValue));

            }
            else
            {
                objSessao.medicoResponsavel = new Medico().Pesquisar(Convert.ToInt32(cbMedicos.SelectedValue));
                SetHora();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbHorarioInicial.SelectedValue == null)
            {
                MessageBox.Show("Não há horários disponíveis, tente um turno ou data diferente!");
            }
            else
            {
                objSessao.situacao = "Agendada";
                objSessao.sessaoCompleta = false;
                objSessao.dataSessao = dtpData.Value;
                objSessao.horaInicio = Convert.ToDateTime(cbHorarioInicial.SelectedValue);
                objSessao.horaFim = Convert.ToDateTime(cbHorarioFinal.SelectedValue);
                Sessoes s = new Sessoes().BuscaPorId(objSessao.id);
                objSessao.id = objSessao.RegistrarSessaoPosterior();
                s.tratamentoPosterior = objSessao;
                s.AdicionarTratamentoPosterior();

                MessageBox.Show("Sessão agendada!");
                Controls.Clear();
            }            
        }


        private void cbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetMedico();
        }

        private void cbConsultorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetConsultorio();
        }

        private void cbTipoDeTratamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            objSessao.tipoDeTratamento = new TipoDeTratamento().Pesquisar(Convert.ToInt32(cbTipoDeTratamento.SelectedValue));
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            if (HelperFunctions.ChecaDataSessao(dtpData.Value)!=true)
            {
                ChecaTurno();
                SetHora();
            }
            else
            {
                MessageBox.Show("O sistema não permite agendar sessões no passado!");
                dtpData.Value = DateTime.Now;
            }
        }

        private void rdbManha_CheckedChanged(object sender, EventArgs e)
        {
            ChecaTurno();
        }

        private void rdbTarde_CheckedChanged(object sender, EventArgs e)
        {
            ChecaTurno();
        }

        private void cbHorarioInicial_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHorarioFinal.DataSource = new Sessoes().GerarListaDeHorariosFinais(objSessao.medicoResponsavel, objSessao.objConsultorio, Convert.ToDateTime(cbHorarioInicial.SelectedValue), turno);
        }
    }
}
