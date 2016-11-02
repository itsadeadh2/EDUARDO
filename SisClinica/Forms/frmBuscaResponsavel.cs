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

        public frmBuscaResponsavel()
        {
            InitializeComponent();
            
        }
        

        private void btnPreencher_Click(object sender, EventArgs e)
        {
            if (!checaValidez())
            {
                this.nomeCompleto = txtBoxNomeCompleto.Text;
                this.cpf = mskdCPF.Text;
                this.dataNascimento = dtpDataNascimento.Value.ToString();
                this.telefone = mskTxtBoxTelefone.Text;
                this.email = txtBoxEmail.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
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
    }
}
