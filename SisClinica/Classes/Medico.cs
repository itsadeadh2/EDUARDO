using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClinica.DAO;
using System.Data;

namespace SisClinica.Classes
{
    class Medico:Pessoa
    {
        public string crm { get; set; }

        public void Registrar()
        {
            new MedicoDAO().Registrar(this);
        }
        public Medico Pesquisar(int id)
        {
           return new MedicoDAO().Pesquisar(id);
        }
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
        public DataTable Pesquisar(string nome)
        {
            IList < Medico > listaDeMedicos = new MedicoDAO().Pesquisar(nome);
            DataTable dt = new DataTable();
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("cpf", typeof(string));
            dt.Columns.Add("crm", typeof(string));

            foreach (Medico objMedico in listaDeMedicos)
            {
                dt.Rows.Add(objMedico.nome, objMedico.id, objMedico.cpf, objMedico.crm);
            }
            return dt;
        }
    }
}
