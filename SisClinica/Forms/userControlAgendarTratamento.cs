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
    public partial class userControlAgendarTratamento : UserControl
    {
        public userControlAgendarTratamento()
        {
            InitializeComponent();

            ChecaTurno();
            cbConsultorios.DataSource = new Consultorio().Pesquisar();
            cbMedicos.DataSource = new Medico().Pesquisar();
            cbTipoDeTratamento.DataSource = new TipoDeTratamento().Pesquisar();
            cbTipoDeTratamento.DisplayMember = "Nome";
            cbTipoDeTratamento.ValueMember = "id";
            if (cbMedicos.DataSource != null && cbConsultorios.DataSource != null&&cbTipoDeTratamento.DataSource!=null)
            {
                SetConsultorio();
                SetMedico();
                SetHora();
                SetFields();
                SetTipoDeTratamento();
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
            else if (cbTipoDeTratamento.DataSource==null)
            {
                MessageBox.Show("O sistema não possui nenhum tipo de tratamento disponível, por favor, cadastre um tipo de tratamento.");
                RetornarAoMenuAnterior();
            }
        }

        //- Variáveis
        private Cliente objCliente;
        private Sessoes objSessao = new Sessoes();
        private TipoDeTratamento objTipoDeTratamento;
        private Consultorio objConsultorio;
        private Medico objMedico;
        private string turno;
        
        //- Eventos
        private void RetornarAoMenuAnterior()
        {
            Controls.Clear();
            UserControl menuAnt = new userControlMenuNovo();
            Controls.Add(menuAnt);
            menuAnt.Show();
        }     
        private void btnCadastrarCli_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você será levado ao menu de cadastro de clientes e todas as informações já preenchidas serão perdidas deseja continuar?", "Aviso", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Controls.Clear();
                UserControl menuCadCli = new userControlRegistraCliente();
                Controls.Add(menuCadCli);
                menuCadCli.Show();
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dtgClientes.DataSource = new Cliente().PesquisarPorNome(txtbNomeCli.Text);
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
        private void cbHorarioFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFields();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (mtbQtdeSessoes.Text.Contains("_")||mtbQtdeSessoes.Text=="")
            {
                MessageBox.Show("Quantidade de sessões inválida, por favor, insira a quantidade em números.");
            }
            else
            {
                try
                {
                    objSessao.medicoResponsavel = objMedico;
                    objSessao.objCliente = objCliente;
                    objSessao.objConsultorio = objConsultorio;
                    objSessao.tipoDeTratamento = objTipoDeTratamento;
                    objSessao.valorSessao = objTipoDeTratamento.valor / Convert.ToInt32(mtbQtdeSessoes.Text);
                    objSessao.horaInicio = Convert.ToDateTime(cbHorarioInicial.SelectedValue);
                    objSessao.horaFim = Convert.ToDateTime(cbHorarioFinal.SelectedValue);
                    objSessao.tipoDeSessao = "Tratamento";
                    objSessao.quitada = checkPago.Checked;
                    objSessao.sessaoCompleta = false;
                    objSessao.situacao = "Agendada";
                    objSessao.nroSessao = 1;

                    objSessao.qtdeSessoes = Convert.ToInt32(mtbQtdeSessoes.Text);
                    objSessao.dataSessao = Convert.ToDateTime(cbHorarioInicial.SelectedValue);

                    if (cbHorarioInicial.SelectedValue == null)
                    {
                        MessageBox.Show("Não há horários disponíveis, tente um turno ou data diferente!");
                    }
                    else
                    {
                        objSessao.RegistrarSessao();
                        MessageBox.Show("Tratamento cadastrado!");
                    }
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                }
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
        private void cbTipoDeTratamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTipoDeTratamento();
        }
        private void cbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetMedico();
        }
        private void cbConsultorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetConsultorio();
        }
        private void mtbQtdeSessoes_Leave(object sender, EventArgs e)
        {
            lblValorPorSessao.Text = "Valor por sessão: " + "R$"+(objTipoDeTratamento.valor / Convert.ToInt32(mtbQtdeSessoes.Text)).ToString("0.00"); ;
        }
        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            objCliente = new Cliente().PesquisarPorId(Convert.ToInt32(dtgClientes.CurrentRow.Cells["id"].Value));
            lblVisCli.Text = lblVisCli.Text + " " + objCliente.nome;
        }

        //- Métodos
        private void SetTipoDeTratamento()
        {
            if (objMedico == null)
            {
                objTipoDeTratamento = new TipoDeTratamento().Pesquisar(Convert.ToInt32(cbTipoDeTratamento.SelectedValue));
                lblVisTipo.Text = "Tipo de Tratamento: " + objTipoDeTratamento.nome;
                lblValortotal.Text = "Valor total: " + "R$" + objTipoDeTratamento.valor.ToString();
            }
            else
            {
                objTipoDeTratamento = new TipoDeTratamento().Pesquisar(Convert.ToInt32(cbTipoDeTratamento.SelectedValue));
                lblVisTipo.Text = "Tipo de Tratamento: " + objTipoDeTratamento.nome;
                lblValortotal.Text = "Valor total: " + "R$" + objTipoDeTratamento.valor.ToString();
                SetHora();
            }
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

        private void checkPago_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
