using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisClinica.Forms
{
    public partial class userControlMenuPesquisar : UserControl
    {
        public userControlMenuPesquisar()
        {
            InitializeComponent();
            HelperFunctions.SetButtons(btnPessoa);
            HelperFunctions.SetButtons(btnSessoes);
        }

        private void btnPessoa_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            UserControl pesqPessoas = new userControlPesquisaPessoas();
            Controls.Add(pesqPessoas);
            pesqPessoas.Show();
        }
    }
}
