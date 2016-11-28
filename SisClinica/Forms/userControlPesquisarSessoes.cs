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
            HelperFunctions.SetButtonsText(btnPesquisar);
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
                    lbData.Visible = true;
                    dtpData.Visible = true;
                    tipoDePesquisa = tdp.clienteMedicoEData;
                    cbNaoConcluido.Enabled = false;
                }
                else if (cbCliente.Checked && cbMedico.Checked)
                {
                    tipoDePesquisa = tdp.clienteEMedico;
                    lbData.Visible = false;
                    dtpData.Visible = false;
                    cbNaoConcluido.Enabled = false;
                }
                else if (cbCliente.Checked && cbData.Checked)
                {
                    tipoDePesquisa = tdp.clienteData;
                    lbData.Visible = true;
                    dtpData.Visible = true;
                    cbNaoConcluido.Enabled = false;
                }
                else if (cbMedico.Checked && cbData.Checked)
                {
                    tipoDePesquisa = tdp.clienteMedicoEData;
                    lbData.Visible = true;
                    dtpData.Visible = true;
                    cbNaoConcluido.Enabled = false;
                }
                else if (cbCliente.Checked)
                {
                    tipoDePesquisa = tdp.cliente;
                    lbData.Visible = false;
                    dtpData.Visible = false;                    
                    cbNaoConcluido.Enabled = false;

                }
                else if (cbMedico.Checked)
                {
                    tipoDePesquisa = tdp.medico;
                    dtpData.Visible = false;
                    lbData.Visible = false;
                    cbNaoConcluido.Enabled = false;
                }
                else if (cbData.Checked)
                {
                    lbData.Visible = true;
                    dtpData.Visible = true;
                    txtbxNomePesquisa.Enabled = false;              
                    tipoDePesquisa = tdp.data;
                    cbNaoConcluido.Enabled = true;

                }
                
                

                else if (cbData.Checked && (cbCliente.Checked || cbMedico.Checked))
                {
                    lbData.Visible = true;
                    dtpData.Visible = true;
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
                lbData.Visible = false;
                dtpData.Visible = false;
                cbNaoConcluido.Enabled = false;
            }
            if (cbConsultas.Checked || cbTratamentos.Checked)
            {
                if (cbConsultas.Checked)
                {
                    tipoDeRetorno = tdr.consulta;
                    cbNaoConcluido.Enabled = true;
                }
                else if (cbTratamentos.Checked)
                {
                    tipoDeRetorno = tdr.tratamento;
                    cbNaoConcluido.Enabled = true;
                }
                else if (cbConsultas.Checked && cbTratamentos.Checked)
                {
                    tipoDeRetorno = tdr.consultaETratamento;
                    cbNaoConcluido.Enabled = false;
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
            dtgSessoes.DataSource = new Sessoes().BuscaPorClienteMedicoData(txtbxNomePesquisa.Text, tipoDePesquisa, dtpData.Value, tipoDeRetorno, cbNaoConcluido.Checked);
            if (dtgSessoes.DataSource == null)
            {
                MessageBox.Show("A pesquisa não encontrou nenhum resultado em registro!");
            }
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
            try
            {
                Controls.Clear();
                userControlAlterarSessoes alterCon = new userControlAlterarSessoes().Preencher(new Sessoes().BuscaPorId(Convert.ToInt32(dtgSessoes.CurrentRow.Cells["id"].Value)));
                Controls.Add(alterCon);
                alterCon.Show();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
                Controls.Clear();
                UserControl pesqSessoes = new userControlPesquisarSessoes();
                Controls.Add(pesqSessoes);
                pesqSessoes.Show();
            }
       
        }

        private void cbNaoConcluido_CheckedChanged(object sender, EventArgs e)
        {
            DeterminaAtivacao();
        }
    }
}
