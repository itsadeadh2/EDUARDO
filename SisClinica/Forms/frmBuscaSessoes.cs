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
    //enum tdp : int { cliente, medico, data, clienteEMedico, clienteMedicoEData,clienteData,medicoData}
    public partial class frmBuscaSessoes : Form
    {
        public frmBuscaSessoes()
        {
            InitializeComponent();
            DeterminaAtivacao();
        }
        private tdp tipoDePesquisa;
        private tdr tipoDeRetorno = tdr.consultaETratamento;

        private void cbCliente_CheckedChanged(object sender, EventArgs e)
        {
            DeterminaAtivacao();
        }
        
        private void cbMedico_CheckedChanged(object sender, EventArgs e)
        {
            DeterminaAtivacao();
        }
        private void DeterminaAtivacao()
        {
            if (cbCliente.Checked || cbMedico.Checked || cbData.Checked)
            {
                btnPesquisar.Enabled = true;
                txtbxNomePesquisa.Enabled = true;
                if (cbCliente.Checked && cbMedico.Checked && cbData.Checked)
                {
                    dtpData.Enabled = true;
                    tipoDePesquisa = tdp.clienteMedicoEData;
                }
                else if (cbCliente.Checked&&cbMedico.Checked)
                {
                    tipoDePesquisa = tdp.clienteEMedico;
                }
                
                else if (cbCliente.Checked)
                {
                    tipoDePesquisa = tdp.cliente;
                }
                else if (cbMedico.Checked)
                {
                    tipoDePesquisa = tdp.medico;
                }
                else if (cbData.Checked&&(cbCliente.Checked||cbMedico.Checked))
                {

                    dtpData.Enabled = true;
                    if (cbCliente.Checked)
                    {
                        tipoDePesquisa = tdp.clienteData;
                    }
                    else if (cbData.Checked)
                    {
                        tipoDePesquisa = tdp.medicoData;
                    }
                }

            }
            else if (cbCliente.Checked || cbMedico.Checked && cbData.Checked)
            {

            }
            else
            {
                btnPesquisar.Enabled = false;
                txtbxNomePesquisa.Enabled = false;                
            }
            if (cbConsultas.Checked||cbTratamentos.Checked)
            {
                if (cbConsultas.Checked)
                {
                    tipoDeRetorno = tdr.consulta;
                }
                else if (cbTratamentos.Checked)
                {
                    tipoDeRetorno = tdr.tratamento;
                }
                else
                {
                    tipoDeRetorno = tdr.consultaETratamento;
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dtgSessoes.DataSource = new Sessoes().BuscaPorClienteMedicoData(txtbxNomePesquisa.Text, tipoDePesquisa, dtpData.Value, tipoDeRetorno);
        }

        private void cbConsultas_CheckedChanged(object sender, EventArgs e)
        {
            DeterminaAtivacao();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbTratamentos_CheckedChanged(object sender, EventArgs e)
        {
            DeterminaAtivacao();
        }

        private void cbData_CheckedChanged(object sender, EventArgs e)
        {
            DeterminaAtivacao();
        }
    }
}
