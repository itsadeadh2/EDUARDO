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
    public partial class userControlAgendarConsulta : UserControl
    {
        public userControlAgendarConsulta()
        {
            InitializeComponent();
            HelperFunctions.SetButtonsText(btnSalvar);
            HelperFunctions.SetButtonsText(btnCadastrarCli);
            
            HelperFunctions.SetButtons(btnPesquisar);
           
            

            ChecaTurno();
            cbConsultorios.DataSource = new Consultorio().Pesquisar();
            cbMedicos.DataSource = new Medico().Pesquisar();
            if (cbMedicos.DataSource != null && cbConsultorios.DataSource != null)
            {
                SetConsultorio();
                SetMedico();
                SetHora();
                SetFields();
            }
            else if (cbMedicos.DataSource == null && cbConsultorios.DataSource == null)
            {
                MessageBox.Show("O sistema não possui consultórios nem médicos suficentes para fazer agendamentos!");
                RetornarAoMenuAnterior();
            }
            else if (cbConsultorios.DataSource == null)
            {
                MessageBox.Show("O sistema não possui consultórios suficientes para fazer agendamentos, por favor, cadastre um consultório.");
                RetornarAoMenuAnterior();
            }
            else if (cbMedicos.DataSource == null)
            {
                MessageBox.Show("O sistema não possui médicos suficientes para fazer agendamentos, por favor, cadastre um médico.");
                RetornarAoMenuAnterior();
            }
        }

        private Cliente objCliente;
        private Sessoes objSessao = new Sessoes();
        private Consultorio objConsultorio;
        private Medico objMedico;
        private string turno;

        //- Eventos
        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            objCliente = new Cliente().PesquisarPorId(Convert.ToInt32(dtgClientes.CurrentRow.Cells["id"].Value));
            lblVisCli.Text = lblVisCli.Text + " " + objCliente.nome;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você será levado ao menu de cadastro de clientes e todas as informações já preenchidas serão perdidas deseja continuar?", "Aviso", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                Controls.Clear();
                UserControl menuCadCli = new userControlRegistraCliente();
                Controls.Add(menuCadCli);
                menuCadCli.Show();
            }
        }
        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            if (HelperFunctions.ChecaDataSessao(dtpData.Value)!=true)
            {
                ChecaTurno();
                SetHora();
                SetFields();
                cbHorarioInicial.ValueMember = "Data";
                cbHorarioInicial.DisplayMember = "Hora";
            }
            else
            {
                MessageBox.Show("O sistema não permite agendar sessões no passado!");
                dtpData.Value = DateTime.Now;
            }            
        }
        private void cbHorarioInicial_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHorarioFinal.DataSource = new Sessoes().GerarListaDeHorariosFinais(new Medico().Pesquisar(Convert.ToInt32(cbMedicos.SelectedValue)), new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorios.SelectedValue)), Convert.ToDateTime(cbHorarioInicial.SelectedValue), turno);
            SetFields();
        }
        private void cbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetMedico();
        }
        private void cbConsultorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetConsultorio();
        }
        private void cbHorarioFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFields();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
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
                objSessao.sessaoCompleta = false;

                if (cbHorarioInicial.SelectedValue==null)
                {
                    MessageBox.Show("Não há horários disponíveis, tente um turno ou data diferente!");
                }
                else
                {
                    objSessao.RegistrarSessao();
                    MessageBox.Show("Consulta cadastrada!");
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
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
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dtgClientes.DataSource = new Cliente().PesquisarPorNome(txtbNomeCli.Text);
        }
        
        //- metodos
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
            if (objMedico == null || objConsultorio == null)
            {

            }
            else
            {
                SetHora();
            }

        }
        private void SetHora()
        {
            cbHorarioInicial.DataSource = new Sessoes().GerarListaDeHorariosIniciais(dtpData.Value, new Medico().Pesquisar(Convert.ToInt32(cbMedicos.SelectedValue)), new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorios.SelectedValue)), turno);
        }
        private void SetConsultorio()
        {
            if (objMedico == null)
            {
                objConsultorio = new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorios.SelectedValue));
                lblVisConsult.Text = "Consultório: " + objConsultorio.nomeConsultorio;
            }
            else
            {
                objConsultorio = new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorios.SelectedValue));
                lblVisConsult.Text = "Consultório: " + objConsultorio.nomeConsultorio;
                SetHora();
            }
        }
        private void SetMedico()
        {
            if (objConsultorio == null)
            {
                objMedico = new Medico().Pesquisar(Convert.ToInt32(cbMedicos.SelectedValue));
                lblVisMedic.Text = "Médico responsável: " + objMedico.nome;
            }
            else
            {
                objMedico = new Medico().Pesquisar(Convert.ToInt32(cbMedicos.SelectedValue));
                lblVisMedic.Text = "Médico responsável: " + objMedico.nome;
                SetHora();
            }
        }
        private void SetFields()
        {
            objSessao.horaInicio = Convert.ToDateTime(cbHorarioInicial.SelectedValue);
            objSessao.horaFim = Convert.ToDateTime(cbHorarioFinal.SelectedValue);
            lblVisData.Text = "Data da consulta: " + objSessao.horaInicio.Date.ToString("dd/MM/yyyy");
            lblVisHora.Text = "Horário: " + objSessao.horaInicio.TimeOfDay.ToString() + " as " + objSessao.horaFim.TimeOfDay.ToString();
        }
        private void RetornarAoMenuAnterior()
        {
            Controls.Clear();
            UserControl menuAnt = new userControlMenuNovo();
            Controls.Add(menuAnt);
            menuAnt.Show();
        }        
    }
}
