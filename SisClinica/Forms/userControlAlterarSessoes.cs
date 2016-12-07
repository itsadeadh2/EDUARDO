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
    public partial class userControlAlterarSessoes : UserControl
    {
        public userControlAlterarSessoes(Sessoes objSess)
        {
            InitializeComponent();
            cbConsultorios.ValueMember = "id";
            cbConsultorios.DisplayMember = "nome";
            cbConsultorios.DataSource = new Consultorio().Pesquisar();
            cbConsultorios.ValueMember = "id";
            cbConsultorios.DisplayMember = "nome";
            cbMedicos.ValueMember = "id medico";
            cbMedicos.DisplayMember = "nome do medico";
            cbMedicos.DataSource = new Medico().Pesquisar();
            cbMedicos.ValueMember = "id medico";
            cbMedicos.DisplayMember = "nome do medico";
            HelperFunctions.SetButtonsText(btnSalvar);
            HelperFunctions.SetButtonsText(btnAlterar);
            HelperFunctions.SetButtonsText(btnExcluir);
            HelperFunctions.SetButtonsText(btnAgendarProxima);
            HelperFunctions.SetButtonsText(btnCancelar);
            HelperFunctions.SetButtons(btnDtgPesq);

            if (objSess.sessaoCompleta == true)
            {
                btnAlterar.Enabled = false;
            }
            lblTipoSessao.Text = objSess.tipoDeSessao;
            lblSituacao.Text = objSess.situacao;
            txtbNomeCliente.Text = objSess.objCliente.nome;
            dtpData.Value = objSess.dataSessao;
            cbMedicos.SelectedIndex = cbMedicos.FindStringExact(objSess.medicoResponsavel.nome);
            cbConsultorios.SelectedIndex = cbConsultorios.FindStringExact(objSess.objConsultorio.nomeConsultorio);
            if (objSess.horaFim.TimeOfDay <= Convert.ToDateTime("12:00").TimeOfDay)
            {
                rdbManha.Checked = true;
            }
            else
            {
                rdbTarde.Checked = true;
            }
            if (objSess.tipoDeSessao == "Tratamento")
            {
                lblvalortotal.Visible = true;
                lblTotal.Visible = true;
                lblTotalSessao.Visible = true;
                lblValorSessao.Visible = true;
                lblTotal.Text = "R$" + objSess.tipoDeTratamento.valor.ToString();
                lblTotalSessao.Text = "R$" + objSess.valorSessao.ToString();
                if (objSess.tratamentoPosterior == null && objSess.nroSessao < objSess.qtdeSessoes)
                {
                    btnAgendarProxima.Visible = true;
                }
            }
            cbHorarioInicial.DisplayMember = "Hora";
            cbHorarioInicial.ValueMember = "data";
            cbHorarioInicial.SelectedIndex = cbHorarioInicial.FindStringExact(objSess.horaInicio.TimeOfDay.ToString());   //objSess.horaInicio.TimeOfDay.ToString();
            cbHorarioInicial.DisplayMember = "Hora";
            cbHorarioInicial.ValueMember = "data";

            cbHorarioFinal.DisplayMember = "Hora";
            cbHorarioFinal.ValueMember = "data";
            cbHorarioFinal.SelectedIndex = cbHorarioFinal.FindStringExact(objSess.horaFim.TimeOfDay.ToString());   //objSess.horaFim.TimeOfDay.ToString();
            cbHorarioFinal.DisplayMember = "Hora";
            cbHorarioFinal.ValueMember = "data";
            objSessao = objSess;

        }

        ///-Atributos
        private Cliente objCliente;
        private Sessoes objSessao = new Sessoes();
        private Sessoes objSessaoSalvar;
        private Consultorio objConsultorio;
        private Medico objMedico;
        private string turno;
        private bool editable = false;

        //-Métodos
        private void AtivaDesativaControles()
        {
            editable = !editable;
            btnAlterar.Enabled = !btnAlterar.Enabled;
            btnSalvar.Visible = !btnSalvar.Visible;
            btnCancelar.Visible = !btnCancelar.Visible;
            gbPesquisa.Visible = !gbPesquisa.Visible;
            dtpData.Enabled = !dtpData.Enabled;
            cbMedicos.Enabled = !cbMedicos.Enabled;
            cbConsultorios.Enabled = !cbConsultorios.Enabled;
            rdbManha.Enabled = !rdbManha.Enabled;
            rdbTarde.Enabled = !rdbTarde.Enabled;
            cbHorarioFinal.Enabled = !cbHorarioFinal.Enabled;
            cbHorarioInicial.Enabled = !cbHorarioInicial.Enabled;
            btnExcluir.Visible = !btnExcluir.Visible;
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
            cbHorarioInicial.DataSource = new Sessoes().GerarListaDeHorariosIniciais(dtpData.Value, new Medico().Pesquisar(Convert.ToInt32(cbMedicos.SelectedValue)), new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorios.SelectedValue)), turno,objSessao);
        }
        private void SetConsultorio()
        {
            if (objMedico == null)
            {
                objConsultorio = new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorios.SelectedValue));                
            }
            else
            {
                objConsultorio = new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorios.SelectedValue));               
            }
        }
        private void SetMedico()
        {
            if (objConsultorio == null)
            {
                objMedico = new Medico().Pesquisar(Convert.ToInt32(cbMedicos.SelectedValue));
                
            }
            else
            {
                objMedico = new Medico().Pesquisar(Convert.ToInt32(cbMedicos.SelectedValue));                
                SetHora();
            }
        }

        //-Eventos
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ChecaTurno();            
            SetConsultorio();
            SetMedico();
            SetHora();
            cbConsultorios.SelectedIndex = cbConsultorios.FindString(objSessao.objConsultorio.nomeConsultorio);
            cbMedicos.SelectedIndex = cbMedicos.FindString(objSessao.medicoResponsavel.nome);
            cbHorarioInicial.SelectedIndex = cbHorarioInicial.FindString(objSessao.horaInicio.TimeOfDay.ToString());
            cbHorarioFinal.SelectedIndex = cbHorarioFinal.FindString(objSessao.horaFim.TimeOfDay.ToString());
            AtivaDesativaControles();
            objSessaoSalvar = objSessao; 
        }
        private void cbHorarioInicial_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHorarioFinal.DataSource = new Sessoes().GerarListaDeHorariosFinais(objSessao.medicoResponsavel, objSessao.objConsultorio, Convert.ToDateTime(cbHorarioInicial.SelectedValue), turno, objSessao);
        }
        private void btnDtgPesq_Click(object sender, EventArgs e)
        {
            dtgClientes.DataSource = new Cliente().PesquisarPorNome(txtbNomePesquisa.Text);
            if (dtgClientes.DataSource == null)
            {
                MessageBox.Show("A pesquisa: " + txtbNomePesquisa.Text + " não encontrou resultados.");
            }
             
        }
        private void dtgClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                objSessaoSalvar.objCliente = new Cliente().PesquisarPorId(Convert.ToInt32(dtgClientes.CurrentRow.Cells["id"].Value));
                txtbNomeCliente.Text = objSessaoSalvar.objCliente.nome;
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
     
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (editable==true)
            {
                if (cbHorarioInicial.SelectedValue == null)
                {
                    MessageBox.Show("Não há horários disponíveis, tente um turno ou data diferente!");
                }
                else
                {
                    ChecaTurno();
                    objSessaoSalvar.dataSessao = dtpData.Value;
                    objSessaoSalvar.medicoResponsavel = new Medico().Pesquisar(Convert.ToInt32(cbMedicos.SelectedValue));
                    objSessaoSalvar.objConsultorio = new Consultorio().Pesquisar(Convert.ToInt32(cbConsultorios.SelectedValue));
                    objSessaoSalvar.horaFim = Convert.ToDateTime(cbHorarioFinal.SelectedValue);
                    objSessaoSalvar.horaInicio = Convert.ToDateTime(cbHorarioInicial.SelectedValue);
                    objSessao = objSessaoSalvar;
                    objSessao.AlterarSessao();
                    MessageBox.Show("Sessão alterada!");
                    AtivaDesativaControles();
                }
                
            }                        
        }
        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            if (editable==true)
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
        }
        private void cbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editable==true)
            {
                SetHora();
            }
        }
        private void cbConsultorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editable==true)
            {
                SetHora();
            }
        }
        private void rdbManha_CheckedChanged(object sender, EventArgs e)
        {
            if (editable==true)
            {
                ChecaTurno();
                SetHora();
            }
        }
        private void rdbTarde_CheckedChanged(object sender, EventArgs e)
        {
            if (editable==true)
            {
                ChecaTurno();
                SetHora();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            userControlAlterarSessoes alterCon = new userControlAlterarSessoes(objSessao);
            Controls.Clear();
            Controls.Add(alterCon);            
            alterCon.Show();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objSessao.Excluir();
            MessageBox.Show("Sessão excluída!");
            Controls.Clear();
            UserControl pesqSessoes = new userControlPesquisarSessoes();
            Controls.Add(pesqSessoes);
            pesqSessoes.Show();

            //Controls.Clear();
            //userControlPesquisarSessoes pesqSess = new userControlPesquisarSessoes();
            //Controls.Add(pesqSess);
            //pesqSess.Show();
        }
        private void btnAgendarProxima_Click(object sender, EventArgs e)
        {
            userControlAgendarProximoTratamento agenProx = new userControlAgendarProximoTratamento(objSessao);
            Controls.Clear();
            Controls.Add(agenProx);
            agenProx.Show();
        }
    }
}
