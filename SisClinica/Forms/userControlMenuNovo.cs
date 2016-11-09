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
    public partial class userControlMenuNovo : UserControl
    {
        public userControlMenuNovo()
        {
            InitializeComponent();
            ConfButtons.SetButtons(btnConsulta);
            ConfButtons.SetButtons(btnMedico);
            ConfButtons.SetButtons(btnNovoCliente);
            ConfButtons.SetButtons(btnTratamento);
        }    
    }   
}

