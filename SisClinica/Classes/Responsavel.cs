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

        public void Registrar()
        {
            new ResponsavelDAO().Registrar(this);
        }
        public Responsavel Pesquisar(int id)
        {
            return new ResponsavelDAO().Pesquisar(id);
        }
    }
}
