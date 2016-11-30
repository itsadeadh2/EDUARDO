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
        //-Propriedades
        public int id { get; set; }
        public string nomeConsultorio { get; set; }
        
        //-Métodos                
        public Consultorio Pesquisar(int id)
        {
            return new ConsultorioDAO().Pesquisar(id);
        }
        public Consultorio PesquisarPorNome(string nome)
        {
            return new ConsultorioDAO().PesquisarPorNome(nome);
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
            if (listaDeConsultorios!=null)
            {
                foreach (Consultorio objConsultorio in listaDeConsultorios)
                {
                    dt.Rows.Add(objConsultorio.nomeConsultorio, objConsultorio.id);
                }
            }
            else
            {
                dt = null;
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
            if (listaDeConsultorios!=null)
            {
                foreach (Consultorio objCon in listaDeConsultorios)
                {
                    dt.Rows.Add(objCon.id, objCon.nomeConsultorio);
                }
            }
            else
            {
                dt = null;
            }
            return dt;
        }
        public void Registrar()
        {
            new ConsultorioDAO().Registrar(this);
        }
    }
}
