using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SisClinica.DAO;

namespace SisClinica.Classes
{
    public class TipoDeTratamento
    {
        public string nome { get; set; }
        public int id { get; set; }

        public void CadastrarNovoTipo()
        {
            new TipoDeTratamentoDAO().CadastrarNovoTipo(this);
        }
        public TipoDeTratamento Pesquisar(int id)
        {
            return new TipoDeTratamentoDAO().PesquisarTratamentos(id);
        }
        public DataTable Pesquisar()
        {
            IList<TipoDeTratamento> lista = new TipoDeTratamentoDAO().PesquisarTratamentos();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("id", typeof(int));
            if (lista!=null)
            {
                foreach (TipoDeTratamento objTipo in lista)
                {
                    dt.Rows.Add(objTipo.nome, objTipo.id);
                }
            }
            return dt;
        }
    }
}
