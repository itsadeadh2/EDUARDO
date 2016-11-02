using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClinica.DAO;
using System.Data;

namespace SisClinica.Classes
{
    public class Medico:Pessoa
    {
        public string crm { get; set; }

        /// <summary>
        /// Registra o objeto medico no banco de dados.
        /// </summary>
        public void Registrar()
        {
            new MedicoDAO().Registrar(this);
        }

        /// <summary>
        /// Pesquisa um medico.
        /// </summary>
        /// <param name="id">id do medico</param>
        /// <returns>objeto medico</returns>
        public Medico Pesquisar(int id)
        {
           return new MedicoDAO().Pesquisar(id);
        }

        /// <summary>
        /// Retorna todos os medicos
        /// </summary>
        /// <returns>DataTable com todos os medicos</returns>
        public DataTable Pesquisar()
        {
            IList<Medico> listaDeMedicos = new MedicoDAO().Pesquisar();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nome do Medico", typeof(string));
            dt.Columns.Add("Id Medico", typeof(int));

            foreach (Medico objMedico in listaDeMedicos)
            {
                dt.Rows.Add(objMedico.nome, objMedico.id);
            }
            return dt;
        }

        /// <summary>
        /// Pesquisa vários medicos
        /// </summary>
        /// <param name="nome">nome do medico</param>
        /// <returns>DataTable de medicos</returns>
        public DataTable Pesquisar(string nome)
        {
            IList < Medico > listaDeMedicos = new MedicoDAO().Pesquisar(nome);
            DataTable dt = new DataTable();
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("cpf", typeof(string));
            dt.Columns.Add("crm", typeof(string));

            if (listaDeMedicos!=null)
            {
                foreach (Medico objMedico in listaDeMedicos)
                {
                    dt.Rows.Add(objMedico.nome, objMedico.id, objMedico.cpf, objMedico.crm);
                }
            }
            else
            {

            }
            return dt;
        }

        public void Alterar()
        {
            new MedicoDAO().Alterar(this);
        }

        public bool Excluir()
        {
            IList < Sessoes > lista = new Sessoes().BuscaPorMedico(this);
            if (lista==null)
            {
                new MedicoDAO().Excluir(this);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
