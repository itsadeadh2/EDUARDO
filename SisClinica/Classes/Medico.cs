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
        //-Propriedades
        public string crm { get; set; }
        
        //-Métodos
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
        public Medico PesquisarPorCRM(string crm)
        {
            return new MedicoDAO().PesquisarPorCrm(crm);
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
            if (listaDeMedicos!=null)
            {
                foreach (Medico objMedico in listaDeMedicos)
                {
                    dt.Rows.Add(objMedico.nome, objMedico.id);
                }
            }
            else
            {
                dt = null;
            }
            return dt;
        }
        /// <summary>
        /// Pesquisa médicos por nome no formato de um datatable
        /// </summary>
        /// <param name="nome">nome do medico</param>
        /// <returns>DataTable de medicos</returns>
        public DataTable Pesquisar(string nome)
        {
            IList < Medico > listaDeMedicos = new MedicoDAO().Pesquisar(nome);
            DataTable dt = new DataTable();
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("cpf", typeof(string));
            dt.Columns.Add("crm", typeof(string));
            dt.Columns.Add("id", typeof(int));

            if (listaDeMedicos!=null)
            {
                foreach (Medico objMedico in listaDeMedicos)
                {
                    dt.Rows.Add(objMedico.nome, objMedico.cpf, objMedico.crm, objMedico.id);
                }
            }
            else
            {
                dt = null;
            }
            return dt;
        }
        /// <summary>
        /// Pesquisa médicos por nome no formato de um iList
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public IList<Medico> iListPesquisar(string nome)
        {
            return new MedicoDAO().Pesquisar(nome);
        }
        public Medico PesquisarPorCpf(string cpf)
        {
            return new MedicoDAO().PesquisarPorCpf(cpf);
        }
        public void Alterar()
        {
            new MedicoDAO().Alterar(this);
        }
        public void Excluir()
        {
            IList < Sessoes > lista = new Sessoes().BuscaPorMedico(this);
            if (lista==null)
            {
                new MedicoDAO().Excluir(this);
            }
            else
            {
                new MedicoDAO().ExcluirComSessoes(this);
            }
        }
    }
}
