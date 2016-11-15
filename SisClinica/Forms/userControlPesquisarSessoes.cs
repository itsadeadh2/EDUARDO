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
    public partial class userControlPesquisarSessoes : UserControl
    {
        public userControlPesquisarSessoes()
        {
            InitializeComponent();
            HelperFunctions.SetButtons(btnPesquisar);
        }

        private Sessoes objSessao;
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
                else if (cbCliente.Checked && cbMedico.Checked)
                {
                    tipoDePesquisa = tdp.clienteEMedico;
                    dtpData.Enabled = false;
                }
                else if (cbCliente.Checked && cbData.Checked)
                {
                    tipoDePesquisa = tdp.clienteData;
                    dtpData.Enabled = true;
                }
                else if (cbCliente.Checked)
                {
                    tipoDePesquisa = tdp.cliente;
                    dtpData.Enabled = false;
                }
                else if (cbMedico.Checked)
                {
                    tipoDePesquisa = tdp.medico;
                    dtpData.Enabled = false;
                }
                else if (cbData.Checked)
                {
                    dtpData.Enabled = true;
                    txtbxNomePesquisa.Enabled = false;              
                    tipoDePesquisa = tdp.data;

                }
                
                

                else if (cbData.Checked && (cbCliente.Checked || cbMedico.Checked))
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
                dtpData.Enabled = false;
            }
            if (cbConsultas.Checked || cbTratamentos.Checked)
            {
                if (cbConsultas.Checked)
                {
                    tipoDeRetorno = tdr.consulta;
                }
                else if (cbTratamentos.Checked)
                {
                    tipoDeRetorno = tdr.tratamento;
                }
                else if (cbConsultas.Checked && cbTratamentos.Checked)
                {
                    tipoDeRetorno = tdr.consultaETratamento;
                }
            }
            if (cbTratamentos.Checked&&cbConsultas.Checked)
            {
                tipoDeRetorno = tdr.consultaETratamento;
            }
            if (cbConsultas.Checked==false&&cbTratamentos.Checked==false)
            {
                tipoDeRetorno = tdr.consultaETratamento;
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
        private void dtgSessoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Controls.Clear();
            userControlAlterarSessoes alterCon = new userControlAlterarSessoes().Preencher(new Sessoes().BuscaPorId(Convert.ToInt32(dtgSessoes.CurrentRow.Cells["id"].Value)));
            Controls.Add(alterCon);
            alterCon.Show();
        }
    }
}
