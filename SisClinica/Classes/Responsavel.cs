using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
