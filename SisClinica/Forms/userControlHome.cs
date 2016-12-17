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
    public partial class userControlHome : UserControl
    {
        public userControlHome()
        {
            InitializeComponent();
            DateTime data = DateTime.Now;                     
            lblData.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

            dtgSessoesDoDia.DataSource = new Sessoes().DataTableBuscaPorDataHome(data);
        }

        private void dtgSessoesDoDia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userControlAlterarSessoes uc = new userControlAlterarSessoes(new Sessoes().BuscaPorId(Convert.ToInt32(dtgSessoesDoDia.CurrentRow.Cells["id"].Value)));
                Controls.Clear();
                Controls.Add(uc);
                uc.Show();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }
    }
}
