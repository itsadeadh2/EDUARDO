using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SisClinica.DAO;

namespace SisClinica.Classes
{
    class Consultorio
    {
        public int id { get; set; }
        public string nomeConsultorio { get; set; }

        public Consultorio Pesquisar(int id)
        {
            return new ConsultorioDAO().Pesquisar(id);
        }
        public DataTable Pesquisar()
        {
            IList<Consultorio> listaDeConsultorios = new ConsultorioDAO().Pesquisar();

            DataTable dt = new DataTable();
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("id", typeof(int));
            foreach (Consultorio objConsultorio in listaDeConsultorios)
            {
                dt.Rows.Add(objConsultorio.nomeConsultorio, objConsultorio.id);
            }
            return dt;

        }
    }
}
