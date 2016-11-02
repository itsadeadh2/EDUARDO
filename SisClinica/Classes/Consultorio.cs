using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SisClinica.DAO;

namespace SisClinica.Classes
{
    public class Consultorio
    {
        public int id { get; set; }
        public string nomeConsultorio { get; set; }

        /// <summary>
        /// Encontra um consultorio.
        /// </summary>
        /// <param name="id">id do consultorio</param>
        /// <returns>objeto consultorio</returns>
        public Consultorio Pesquisar(int id)
        {
            return new ConsultorioDAO().Pesquisar(id);
        }

        /// <summary>
        /// Retorna todos os consultorios em um DataTable.
        /// </summary>
        /// <returns>DataTable de consultorios</returns>
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

        /// <summary>
        /// Encontra consultorios baseado no nome
        /// </summary>
        /// <param name="nome">nome do consultorio</param>
        /// <returns>DataTable com consultorios</returns>
        public DataTable Pesquisar(string nome)
        {
            IList<Consultorio> listaDeConsultorios = new ConsultorioDAO().Pesquisar(nome);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nome", typeof(string));

            foreach (Consultorio objCon in listaDeConsultorios)
            {
                dt.Rows.Add(objCon.id, objCon.nomeConsultorio);
            }
            return dt;
        }

        public void Excluir()
        {

        }

        public void Registrar()
        {

        }
    }
}
