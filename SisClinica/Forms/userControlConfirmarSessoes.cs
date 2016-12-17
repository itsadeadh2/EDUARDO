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
    public partial class userControlConfirmarSessoes : UserControl
    {
        DateTime data = DateTime.Now.Date;
        public userControlConfirmarSessoes()
        {
            //data = data.AddDays(1);
            InitializeComponent();            
            HelperFunctions.SetButtonsText(btnConfirmar);
            
            dtgSessoes.DataSource = new Sessoes().DataTableBuscaPorData(data);          
        }
        //-Atributos
        Sessoes objSessao;

        //-Eventos
        private void dtgSessoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              
              objSessao = new Sessoes().BuscaPorId(Convert.ToInt32(dtgSessoes.CurrentRow.Cells["id"].Value));
              gbConfirmar.Visible = true;
            if (objSessao.sessaoCompleta==true)
            {
                btnConfirmar.Enabled = false;
            }
            else
            {
                btnConfirmar.Enabled = true;
            }
            PreencherCampos();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            
        }        
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (objSessao!=null)
            {
                objSessao.sessaoCompleta = true;
                objSessao.CompletarSessao();
                if (objSessao.nroSessao < objSessao.qtdeSessoes)
                {
                    DialogResult resultado = MessageBox.Show("A " + objSessao.nroSessao + "° sessão do tratamento foi confirmada, gostaria de marcar a " + (objSessao.nroSessao + 1) + "° sessão agora?", "Aviso", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        userControlAgendarProximoTratamento agenProx = new userControlAgendarProximoTratamento(objSessao);
                        Controls.Clear();
                        Controls.Add(agenProx);
                        agenProx.Show();
                    }
                    else
                    {
                        dtgSessoes.DataSource = new Sessoes().DataTableBuscaPorData(data);
                    }
                }
                else
                {
                    if (objSessao.tipoDeSessao == "Tratamento")
                    {
                        MessageBox.Show("Última sessão confirmada, tratamento finalizado!");
                        dtgSessoes.DataSource = new Sessoes().DataTableBuscaPorData(data);
                    }
                    else
                    {
                        MessageBox.Show("Consulta confirmada!");
                        dtgSessoes.DataSource = new Sessoes().DataTableBuscaPorData(data);

                    }
                    btnConfirmar.Enabled = false;
                }
                gbConfirmar.Visible = false;
            }            
        }

        //-Métodos
        private void PreencherCampos()
        {
            lblCliente.Text = objSessao.objCliente.nome;
            lblMedico.Text = objSessao.medicoResponsavel.nome;
            lblTipo.Text = objSessao.tipoDeSessao;
            if (objSessao.tipoDeSessao == "Tratamento")
            {
                lblTipoTrat.Text = objSessao.tipoDeTratamento.nome;
            }
            else
            {
                lblTipoTrat.Text = "-";
            }
            if (objSessao.quitada == true)
            {
                lblValor.Text = "Sessão quitada";
            }
            else
            {
                lblValor.Text = "R$" + objSessao.valorSessao.ToString();
            }

            lblCPF.Text = objSessao.objCliente.cpf;
            lblCRM.Text = objSessao.medicoResponsavel.crm;
            lblConsultorio.Text = objSessao.objConsultorio.nomeConsultorio;
            lblHorario.Text = objSessao.horaInicio.TimeOfDay.ToString() + " as " + objSessao.horaFim.TimeOfDay.ToString();
        }
    }
}
