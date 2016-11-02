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
        //-Propriedadesf
        public string adicionalInfo { get; set; }
        public Responsavel objResponsavel { get; set; }
        //-Métodos
        /// <summary>
        /// Retorna uma iList (lista) de clientes que tem o nome igual ao que é passado pelo parâmetro.
        /// </summary>
        /// <param name="nome">Nome do cliente</param>
        /// <returns></returns>
        //public IList<Cliente> PesquisarPorNome(string nome)
        //{
        //    IList<Cliente> listaDeClientes = new List<Cliente>();
        //    listaDeClientes = new ClienteDAO().PesquisarPorNome(nome);
        //    return listaDeClientes;
        //}
        /// <summary>
        /// Retorna uma iList (lista) com APENAS UM registro que é encontrado através do CPF passado como parâmetro.
        /// </summary>
        /// <param name="cpf">CPF do cliente</param>
        /// <returns></returns>
        public IList<Cliente> PesquisarPorCpf(string cpf)
        {
            IList<Cliente> listaDeClientes = new List<Cliente>();
            Cliente objCliente = new Cliente();
            ClienteDAO objClienteDao = new ClienteDAO();
            objCliente = objClienteDao.Pesquisar(cpf);
            listaDeClientes.Add(objCliente);
            //objCliente = new ClienteDAO().Pesquisar(cpf);
            return listaDeClientes;
        }
        public Cliente PesquisarPorId(int id)
        {
            return new ClienteDAO().Pesquisar(id);
        }
        /// <summary>
        /// Registra um cliente no banco de dados.
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
        /// Registra um cliente e seu responsável no banco de dados.
        /// </summary>
        /// <param name="objResponsavel">Responsável a ser registrado.</param>       

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

                dt.Rows.Add(objCliente.id, objCliente.nome, objCliente.cpf, objCliente.objResponsavel.nome, objCliente.objResponsavel.cpf);
            }
            return dt;
        }
    }
}
