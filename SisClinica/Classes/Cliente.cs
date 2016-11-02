using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClinica.DAO;
using System.Data;

namespace SisClinica.Classes
{
    public class Cliente:Pessoa
    {
        //-Propriedades
        public string adicionalInfo { get; set; }
        public Responsavel objResponsavel { get; set; }
        //-Métodos

        public void Excluir(int id)
        {
            IList<Sessoes> lista = new Sessoes().BuscaPorCliente(this);
            if (lista==null)
            {
                new ClienteDAO().Excluir(this);
            }
            else
            {
                new ClienteDAO().ExcluirComSessao(this);
            }
        }

        /// <summary>
        /// Encontra um objeto do tipo cliente.
        /// </summary>
        /// <param name="cpf">CPF do cliente</param>
        /// <returns>objeto cliente</returns>
        public Cliente PesquisarPorCpf(string cpf)
        {
            return new ClienteDAO().Pesquisar(cpf);
           
        }

        /// <summary>
        /// Encontra um objeto do tipo cliente.
        /// </summary>
        /// <param name="id">id para a busca</param>
        /// <returns>objeto cliente</returns>
        public Cliente PesquisarPorId(int id)
        {
            return new ClienteDAO().Pesquisar(id);
        }

        /// <summary>
        /// Determina se o cliente possui um responsável e caso tenha, vincula-o ao cliente. Caso não tenha, apenas registra o cliente.
        /// </summary>
        public void Registrar()
        {
            if (this.objResponsavel!=null)
            {
                new ClienteDAO().RegistrarComResponsavel(this);
            }
            else
            {
                new ClienteDAO().Registrar(this);
            }                
        }
        
        /// <summary>
        /// Retorna uma data table com alguns dados essenciais do cliente.
        /// </summary>
        /// <param name="nome">Nome do cliente</param>
        /// <returns> DataTable com: ID, Nome, CPF, Nome Responsavel, CPF Responsavel</returns>
        public DataTable PesquisarPorNome(string nome)
        {
            IList<Cliente> listadeClientes = new List<Cliente>();
            listadeClientes = new ClienteDAO().PesquisarPorNome(nome);

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("CPF", typeof(string));
            dt.Columns.Add("Nome Responsavel", typeof(string));
            dt.Columns.Add("CPF Responsavel", typeof(string));
            foreach (Cliente objCliente in listadeClientes)
            {
                if (objCliente.objResponsavel!=null)
                {
                    dt.Rows.Add(objCliente.id, objCliente.nome, objCliente.cpf, objCliente.objResponsavel.nome, objCliente.objResponsavel.cpf);
                }
                else
                {
                    dt.Rows.Add(objCliente.id, objCliente.nome, objCliente.cpf, "-", "-");
                }
            }
            return dt;
        }
    }
}
