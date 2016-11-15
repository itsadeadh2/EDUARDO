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
    public partial class userControlHorarios : UserControl
    {
        public userControlHorarios()
        {
            InitializeComponent();
            HelperFunctions.SetButtonsText(btnSalvar);
            GerarHorarios();
        }
        public void GerarHorarios()
        {
            cbEntrada.DataSource = new Horarios().GerarHorarios();
            cbAlmoco.DataSource = new Horarios().GerarProximoHorario(Convert.ToDateTime(cbEntrada.SelectedValue).TimeOfDay);
            cbReentrada.DataSource = new Horarios().GerarProximoHorario(Convert.ToDateTime(cbAlmoco.SelectedValue).TimeOfDay);
            cbSaida.DataSource = new Horarios().GerarProximoHorario(Convert.ToDateTime(cbReentrada.SelectedValue).TimeOfDay);            
        }
    }
}
