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
            data = data.AddDays(1);
            lblData.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            IList<Sessoes> lst = new Sessoes().BuscaPorData(data);
            DataTable dt = new DataTable();
            dt.Columns.Add("Tipo", typeof(string));
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Médico responsável", typeof(string));
            dt.Columns.Add("Horário", typeof(string));
            dt.Columns.Add("Consultorio", typeof(string));
            dt.Columns.Add("id", typeof(int));
            if (lst!=null)
            {
                foreach (Sessoes objSessao in lst)
                {
                    if (objSessao.sessaoCompleta!=true)
                    {
                        dt.Rows.Add(objSessao.tipoDeSessao, objSessao.objCliente.nome, objSessao.medicoResponsavel.nome, objSessao.horaInicio.TimeOfDay + " as " + objSessao.horaFim.TimeOfDay, objSessao.objConsultorio.nomeConsultorio,objSessao.id);
                    }
                }
            }
            dtgSessoesDoDia.DataSource = dt;
        }

        private void dtgSessoesDoDia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            userControlAlterarSessoes uc = new userControlAlterarSessoes().Preencher(new Sessoes().BuscaPorId(Convert.ToInt32(dtgSessoesDoDia.CurrentRow.Cells["id"].Value)));
        }
    }
}
