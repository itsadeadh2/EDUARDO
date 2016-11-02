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
        public frmAgendarConsulta()
        {
            InitializeComponent();
            cbMedicosDisponiveis.DataSource = new Medico().Pesquisar();
            cbConsultorio.DataSource = new Consultorio().Pesquisar();
            SetMedico();
            SetConsultorio();
            cbHorarioInicial.DataSource = new Sessoes().GerarListaDeHorarios(dtpDia.Value, new Medico().Pesquisar(Convert.ToInt32(cbMedicosDisponiveis.SelectedValue)), new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorio.SelectedValue)), Convert.ToDateTime(cbHorarioInicial.SelectedValue));
            cbHorarioFinal.DataSource = new Sessoes().GerarListaDeHorarios(dtpDia.Value, new Medico().Pesquisar(Convert.ToInt32(cbMedicosDisponiveis.SelectedValue)), new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorio.SelectedValue)), Convert.ToDateTime(cbHorarioInicial.SelectedValue));
            SetHora();
        }
        private Cliente objCliente;
        private Sessoes objSessao = new Sessoes();
        private Consultorio objConsultorio;
        private Medico objMedico;
        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new frmBuscaCliente())
            {
                var result = form.ShowDialog();
                if (result==DialogResult.OK)
                {
                    objCliente = form.objCliente;
                    lblCliente.Text = lblCliente.Text + " " + objCliente.nome;
                    //MessageBox.Show(objSessao.objCliente.nome);
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
            cbHorarioInicial.DataSource = null;
            cbHorarioInicial.DataSource = new Sessoes().GerarListaDeHorarios(dtpDia.Value, new Medico().Pesquisar(Convert.ToInt32(cbMedicosDisponiveis.SelectedValue)), new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorio.SelectedValue)),Convert.ToDateTime(cbHorarioInicial.SelectedValue));
            cbHorarioInicial.ValueMember = "Data";
            cbHorarioInicial.DisplayMember = "Hora";
        }

        private void frmAgendarConsulta_Load(object sender, EventArgs e)
        {

        }

        private void cbHorarioInicial_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHorarioFinal.DataSource = new Sessoes().GerarListaDeHorarios(dtpDia.Value, new Medico().Pesquisar(Convert.ToInt32(cbMedicosDisponiveis.SelectedValue)), new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorio.SelectedValue)), Convert.ToDateTime(cbHorarioInicial.SelectedValue));
            SetHora();
        }

        private void cbMedicosDisponiveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetMedico();
        }

        private void cbConsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetConsultorio();
        }

        private void SetConsultorio()
        {
            objConsultorio = new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorio.SelectedValue));
            lblConsultorio.Text = "Consultório: " + objConsultorio.nomeConsultorio;
        }
        private void SetMedico()
        {
            objMedico = new Medico().Pesquisar(Convert.ToInt32(cbMedicosDisponiveis.SelectedValue));
            lblMedicoResponsavel.Text = "Médico responsável: " + objMedico.nome;
        }
        private void SetHora()
        {
            objSessao.horaInicio = Convert.ToDateTime(cbHorarioInicial.SelectedValue);
            objSessao.horaFim = Convert.ToDateTime(cbHorarioFinal.SelectedValue);

            lblDataConsulta.Text = "Data da consulta: " + objSessao.horaInicio.Date.ToString();
            lblHoraConsulta.Text = "Horário: " + objSessao.horaInicio.TimeOfDay.ToString() + " as " + objSessao.horaFim.TimeOfDay.ToString();
        }

        private void cbHorarioFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetHora();
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
    }
}
