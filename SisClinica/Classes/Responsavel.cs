using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SisClinica.DAO;
namespace SisClinica.Classes
{
    public class Responsavel : Pessoa
    {
        /// <summary>
        /// Registra o responsável no banco de dados
        /// </summary>
        public void Registrar()
        {
            new ResponsavelDAO().Registrar(this);
        }
        /// <summary>
        /// Pesquisa um responsável
        /// </summary>
        /// <param name="id">id do responsavel</param>
        /// <returns>objeto responsavel</returns>
        public Responsavel Pesquisar(int id)
        {
            return new ResponsavelDAO().Pesquisar(id);
        }

        public void Alterar()
        {
            new ResponsavelDAO().Alterar(this);
        }

        public Responsavel PesquisarPorCPF(string cpf)
        {
            return new ResponsavelDAO().Pesquisar(cpf);
        }
        public DataTable Pesquisar(string nome)
        {
            IList<Responsavel> lista = new ResponsavelDAO().PesquisarPorNome(nome);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("cpf", typeof(string));
            if (lista!=null)
            {
                foreach (Responsavel objResp in lista)
                {
                    dt.Rows.Add(objResp.id, objResp.nome, objResp.cpf);
                }
            }
            else
            {
                dt = null;
            }
            return dt;
        }
        public void Excluir()
        {

        }
    }
}
