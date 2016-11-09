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
    public partial class userControlMenuAlterar : UserControl
    {
        public userControlMenuAlterar()
        {
            InitializeComponent();
            ConfButtons.SetButtons(btnAlterarCliente);
            ConfButtons.SetButtons(btnAlterarMedico);
            ConfButtons.SetButtons(btnAlterarSessoes);
        }
    }
}
