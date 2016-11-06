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
    public partial class frmBuscaResponsavel : Form        
    {
        public string nomeCompleto { get; set; }
        public string cpf { get; set; }
        public string dataNascimento { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public Responsavel objResponsavel = new Responsavel();


        public frmBuscaResponsavel()
        {
            InitializeComponent();
        }
        

        private void btnPreencher_Click(object sender, EventArgs e)
        {
            if (!checaValidez())
            {
                objResponsavel.nome = txtBoxNomeCompleto.Text;
                objResponsavel.cpf = mskdCPF.Text;
                objResponsavel.dataNascimento = dtpDataNascimento.Value;
                objResponsavel.telefone = mskTxtBoxTelefone.Text;
                objResponsavel.email = txtBoxEmail.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("O formulário contem informações inválidas, corrija-as antes de continuar!");
            }
                                 
        }

        private void dtpDataNascimento_ValueChanged(object sender, EventArgs e)
        {
            checaValidez();
        }

        private void frmBuscaResponsavel_Load(object sender, EventArgs e)
        {
            
        }
        private bool checaValidez()
        {
            if ((DateTime.Now.Year - dtpDataNascimento.Value.Year) < 18)
            {
                lblAviso.Visible = true;
                return true;               
            }
            else
            {
                lblAviso.Visible = false;
                return false;
                
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dtgResponsaveis.DataSource = new Responsavel().Pesquisar(txtbNomePesq.Text);
        }

        private void dtgResponsaveis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            objResponsavel = new Responsavel().Pesquisar(Convert.ToInt32(dtgResponsaveis.CurrentRow.Cells["ID"].Value));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
