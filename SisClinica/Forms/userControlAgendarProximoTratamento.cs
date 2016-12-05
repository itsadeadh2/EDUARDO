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
        public userControlAgendarProximoTratamento(Sessoes objS)
        {
            InitializeComponent();
            HelperFunctions.SetButtonsText(btnSalvar);
            //Medico
            cbMedicos.DisplayMember = "nome do medico";
            cbMedicos.ValueMember = "id medico";
            cbMedicos.DataSource = new Medico().Pesquisar();
            cbMedicos.DisplayMember = "nome do medico";
            cbMedicos.ValueMember = "id medico";
            //Consultorio
            cbConsultorios.DisplayMember = "Nome";
            cbConsultorios.ValueMember = "id";
            cbConsultorios.DataSource = new Consultorio().Pesquisar();
            cbConsultorios.DisplayMember = "Nome";
            cbConsultorios.ValueMember = "id";
            //Tipo de tratamento
            cbTipoDeTratamento.DisplayMember = "nome";
            cbTipoDeTratamento.ValueMember = "id";
            cbTipoDeTratamento.DataSource = new TipoDeTratamento().Pesquisar();
            cbTipoDeTratamento.DisplayMember = "nome";
            cbTipoDeTratamento.ValueMember = "id";

            lblVisCli.Text = "Cliente: " + objS.objCliente.nome;
            lblVisMedic.Text = "Médico: " + objS.medicoResponsavel.nome;
            lblVisQtde.Text = "Sessões restantes: " + (objS.qtdeSessoes - objS.nroSessao);
            lblVisTipo.Text = "Tipo de tratamento: " + objS.tipoDeTratamento.nome;
            lblVisConsult.Text = "Consultório: " + objS.objConsultorio.nomeConsultorio;
            lblVisHora.Text = "Horário: " + objS.horaInicio.TimeOfDay.ToString() + " as " + objS.horaFim.TimeOfDay.ToString();           

            if (objS.quitada == true)
            {
                lblValortotal.Text = "Valor total: " + "Quitada";
                lblValorPorSessao.Text = "Valor por sessão: " + "Quitada";
            }
            else
            {
                lblValortotal.Text = "Valor total: " + "R$" + objS.tipoDeTratamento.valor;
                lblValorPorSessao.Text = "Valor por sessão: " + "R$" + objS.valorSessao;
            }
            objSessao = objS;
            ChecaTurno();
        }

        //-Atributos
        private Cliente objCliente;
        private Sessoes objSessao = new Sessoes();        
        private string turno;
        private bool editable = false;
        
        // - Métodos
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
            cbHorarioInicial.DataSource = new Sessoes().GerarListaDeHorariosIniciais(dtpData.Value, objSessao.medicoResponsavel, objSessao.objConsultorio, turno);
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

        //- Eventos
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
                objSessao.nroSessao++;
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
            cbMedicos.DisplayMember = "nome do medico";
            cbMedicos.ValueMember = "id medico";
            SetMedico();
            cbMedicos.DisplayMember = "nome do medico";
            cbMedicos.ValueMember = "id medico";
        }
        private void cbConsultorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbConsultorios.DisplayMember = "Nome";
            cbConsultorios.ValueMember = "id";
            SetConsultorio();
            cbConsultorios.DisplayMember = "Nome";
            cbConsultorios.ValueMember = "id";
        }
        private void cbTipoDeTratamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTipoDeTratamento.DisplayMember = "nome";
            cbTipoDeTratamento.ValueMember = "id";
            objSessao.tipoDeTratamento = new TipoDeTratamento().Pesquisar(Convert.ToInt32(cbTipoDeTratamento.SelectedValue));
            cbTipoDeTratamento.DisplayMember = "nome";
            cbTipoDeTratamento.ValueMember = "id";
        }
        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            if (HelperFunctions.ChecaData(dtpData.Value)!=true)
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
