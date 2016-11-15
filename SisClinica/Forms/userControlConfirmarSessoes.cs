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
        public userControlConfirmarSessoes()
        {
            InitializeComponent();
            DateTime data = DateTime.Now.Date;
            data = data.AddDays(1);
            dtgSessoes.DataSource = new Sessoes().DataTableBuscaPorData(data);          
        }
        Sessoes objSessao;
        private void dtgSessoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbConfirmar.Visible = true;
            objSessao = new Sessoes().BuscaPorId(Convert.ToInt32(dtgSessoes.CurrentRow.Cells["id"].Value));
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
        private void PreencherCampos()
        {
            lblCliente.Text = objSessao.objCliente.nome;
            lblMedico.Text = objSessao.medicoResponsavel.nome;
            lblTipo.Text = objSessao.tipoDeSessao;
            if (objSessao.tipoDeSessao=="Tratamento")
            {
                lblTipoTrat.Text = objSessao.tipoDeTratamento.nome;
            }
            else
            {
                lblTipoTrat.Text = "-";
            }
            lblValor.Text = "R$"+objSessao.valorSessao.ToString();
            lblCPF.Text = objSessao.objCliente.cpf;
            lblCRM.Text = objSessao.medicoResponsavel.crm;
            lblConsultorio.Text = objSessao.objConsultorio.nomeConsultorio;
            lblHorario.Text = objSessao.horaInicio.TimeOfDay.ToString() + " as " + objSessao.horaFim.TimeOfDay.ToString();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            objSessao.sessaoCompleta = true;
            objSessao.CompletarSessao();
            if (objSessao.nroSessao < objSessao.qtdeSessoes)
            {
                DialogResult resultado = MessageBox.Show("A " + objSessao.nroSessao + "° sessão do tratamento foi confirmada, gostaria de marcar a " + (objSessao.nroSessao + 1) + "° sessão agora?", "Aviso", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    userControlAgendarProximoTratamento agenProx = new userControlAgendarProximoTratamento().Preencher(objSessao);
                    Controls.Clear();
                    Controls.Add(agenProx);
                    agenProx.Show();
                }
            }
            else
            {
                MessageBox.Show("Última sessão confirmada, tratamento finalizado!");
                btnConfirmar.Enabled = false;
            }
        }
    }
}
