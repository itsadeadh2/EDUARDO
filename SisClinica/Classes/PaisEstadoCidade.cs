using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClinica.DAO;

namespace SisClinica.Classes
{
    public class PaisEstadoCidade
    {
        public int idPais { get; set; }
        public int idEstado { get; set; }
        public int idCidade { get; set; }
        public string siglaPais { get; set; }
        public string siglaEstado { get; set; }
        public string nomeCidade { get; set; }

        public IList<PaisEstadoCidade> BuscarTodosOsEstados()
        {
            return new PaisEstadoCidadeDAO().BuscarTodosOsEstados();
        }
        public PaisEstadoCidade BuscarCidade(int idCidade)
        {
            return new PaisEstadoCidadeDAO().BuscarCidade(idCidade);
        }
        public IList<PaisEstadoCidade> BuscarCidadesPorEstado(int idEstado)
        {
            return new PaisEstadoCidadeDAO().BuscarCidadesPorEstado(idEstado);
        }
        public PaisEstadoCidade BuscarEstado(int idEstado)
        {
            return new PaisEstadoCidadeDAO().BuscarEstado(idEstado);
        }
    }
}
