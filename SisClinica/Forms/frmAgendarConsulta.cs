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
    public partial class frmAgendarConsulta : Form
    {
        //- Variáveis do form
        public frmAgendarConsulta()
        {
            InitializeComponent();
            
        }
        private Cliente objCliente;
        private Sessoes objSessao = new Sessoes();
        private Consultorio objConsultorio;
        private Medico objMedico;
        private string turno;

        //-Eventos
        private void frmAgendarConsulta_Load(object sender, EventArgs e)
        {
            ChecaTurno();
            cbConsultorio.DataSource = new Consultorio().Pesquisar();
            cbMedicosDisponiveis.DataSource = new Medico().Pesquisar();
            if (cbMedicosDisponiveis.DataSource != null && cbConsultorio.DataSource != null)
            {
                SetConsultorio();
                SetMedico();
                SetHora();
                SetFields();
            }
            else if (cbMedicosDisponiveis.DataSource == null && cbConsultorio.DataSource == null)
            {
                MessageBox.Show("O sistema não possui consultórios nem médicos suficentes para fazer agendamentos!");
                Close();
            }
            else if (cbConsultorio.DataSource == null)
            {
                MessageBox.Show("O sistema não possui consultórios suficientes para fazer agendamentos, por favor, cadastre um consultório.");
                Close();
            }
            else if (cbMedicosDisponiveis.DataSource == null)
            {
                MessageBox.Show("O sistema não possui médicos suficientes para fazer agendamentos, por favor, cadastre um médico.");
                Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new frmBuscaCliente())
            {
                var result = form.ShowDialog();
                if (result==DialogResult.OK)
                {
                    objCliente = form.objCliente;
                    lblCliente.Text = lblCliente.Text + " " + objCliente.nome;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form registrarCliente = new frmRegistraCliente();
            registrarCliente.Show();
        }
        private void frmAgendarConsulta_SizeChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SetHora();
            cbHorarioInicial.ValueMember = "Data";
            cbHorarioInicial.DisplayMember = "Hora";
        }
        private void cbHorarioInicial_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHorarioFinal.DataSource = new Sessoes().GerarListaDeHorariosFinais(new Medico().Pesquisar(Convert.ToInt32(cbMedicosDisponiveis.SelectedValue)), new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorio.SelectedValue)), Convert.ToDateTime(cbHorarioInicial.SelectedValue),turno);
            SetFields();
        }
        private void cbMedicosDisponiveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetMedico();
        }
        private void cbConsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetConsultorio();
        }
        private void cbHorarioFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFields();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                objSessao.medicoResponsavel = objMedico;
                objSessao.objCliente = objCliente;
                objSessao.objConsultorio = objConsultorio;
                objSessao.horaInicio = Convert.ToDateTime(cbHorarioInicial.SelectedValue);
                objSessao.horaFim = Convert.ToDateTime(cbHorarioFinal.SelectedValue);
                objSessao.tipoDeSessao = "Consulta";
                objSessao.qtdeSessoes = 1;
                objSessao.dataSessao = Convert.ToDateTime(cbHorarioInicial.SelectedValue);

                objSessao.RegistrarSessao();

                MessageBox.Show("Consulta cadastrada!");
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        private void rdBtnManha_CheckedChanged(object sender, EventArgs e)
        {
            ChecaTurno();
        }
        private void rdBtnTarde_CheckedChanged(object sender, EventArgs e)
        {
            ChecaTurno();
        }

        //-Métodos
        private void SetConsultorio()
        {
            if (objMedico==null)
            {
                objConsultorio = new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorio.SelectedValue));
                lblConsultorio.Text = "Consultório: " + objConsultorio.nomeConsultorio;
            }
            else
            {
                objConsultorio = new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorio.SelectedValue));
                lblConsultorio.Text = "Consultório: " + objConsultorio.nomeConsultorio;
                SetHora();
            }
        }
        private void SetMedico()
        {
            if (objConsultorio==null)
            {
                objMedico = new Medico().Pesquisar(Convert.ToInt32(cbMedicosDisponiveis.SelectedValue));
                lblMedicoResponsavel.Text = "Médico responsável: " + objMedico.nome;
            }
            else
            {
                objMedico = new Medico().Pesquisar(Convert.ToInt32(cbMedicosDisponiveis.SelectedValue));
                lblMedicoResponsavel.Text = "Médico responsável: " + objMedico.nome;
                SetHora();
            }            
        }
        private void SetFields()
        {
            objSessao.horaInicio = Convert.ToDateTime(cbHorarioInicial.SelectedValue);
            objSessao.horaFim = Convert.ToDateTime(cbHorarioFinal.SelectedValue);

            lblDataConsulta.Text = "Data da consulta: " + objSessao.horaInicio.Date.ToString();
            lblHoraConsulta.Text = "Horário: " + objSessao.horaInicio.TimeOfDay.ToString() + " as " + objSessao.horaFim.TimeOfDay.ToString();
        }
        private void SetHora()
        {
            cbHorarioInicial.DataSource = new Sessoes().GerarListaDeHorariosIniciais(dtpDia.Value, new Medico().Pesquisar(Convert.ToInt32(cbMedicosDisponiveis.SelectedValue)), new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorio.SelectedValue)), turno);
        }
        private void ChecaTurno()
        {
            if (rdBtnManha.Checked)
            {
                turno = "Manhã";
            }
            else
            {
                turno = "Tarde";
            }
            if (objMedico==null || objConsultorio==null)
            {

            }
            else
            {
                SetHora();
            }
        }
    }
}
