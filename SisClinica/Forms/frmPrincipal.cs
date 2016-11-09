using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using SisClinica.Classes;
namespace SisClinica.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmConsulta = new frmAgendarConsulta();
            frmConsulta.MdiParent = this;
            frmConsulta.Show();
        }

        private void semConsultaPréviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form frmSemConsultaPrevia = new frmAgendarTratamentoSemConsulta();
            //frmSemConsultaPrevia.MdiParent = this;
            //frmSemConsultaPrevia.Show();
        }

        private void comConsultaPréviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form frmComConsultaPrevia = new frmAgendarTratamentoComConsulta();
            //frmComConsultaPrevia.MdiParent = this;
            //frmComConsultaPrevia.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmRegistraCliente = new frmRegistraCliente();
            frmRegistraCliente.MdiParent = this;
            frmRegistraCliente.Show();
        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmRegistraMedico = new formRegistraMedico();
            frmRegistraMedico.MdiParent = this;
            frmRegistraMedico.Show();            
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmPesquisarCliente = new frmBuscaCliente();
            frmPesquisarCliente.MdiParent = this;
            frmPesquisarCliente.Show();
        }

        private void médicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmPesquisarMedico = new formBuscaMedico();
            frmPesquisarMedico.MdiParent = this;
            frmPesquisarMedico.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void frmPrincipal_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void frmPrincipal_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                menuPrincipal.Enabled = false;
            }
            else
            {
                menuPrincipal.Enabled = true;
            }
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmConfig = new frmConfiguracoes();
            frmConfig.MdiParent = this;
            frmConfig.Show();
        }

        private void médicoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frmAlterarMedico = new frmAlterarMedico();
            frmAlterarMedico.MdiParent = this;
            frmAlterarMedico.Show();
        }

        private void sessõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBuscaSessoes = new frmBuscaSessoes();
            frmBuscaSessoes.MdiParent = this;
            frmBuscaSessoes.Show();
        }

        private void consultórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form regConsult = new frmRegistrarConsultorio();
            regConsult.MdiParent = this;
            regConsult.Show();
        }
    }
}
