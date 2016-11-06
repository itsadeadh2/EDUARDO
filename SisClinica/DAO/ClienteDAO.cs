using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SisClinica.Classes;

namespace SisClinica.DAO
{
    public class ClienteDAO
    {
        /// <summary>
        /// Traduz um objeto do tipo cliente para o banco de dados
        /// </summary>
        /// <param name="objCliente">Objeto cliente a ser traduzido</param>
        public void RegistrarComResponsavel(Cliente objCliente)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Cliente (cpf, email, endereco, cidade, estado, nome, telefone, dataNascimento, adicionalInfo, cpf_responsavel) " +
                "values (@cpf, @email, @endereco, @cidade, @estado, @nome, @telefone, @dataNascimento, @adicionalInfo, @cpf_resp)";
            comando.Parameters.AddWithValue("@cpf", objCliente.cpf);
            comando.Parameters.AddWithValue("@email", objCliente.email);
            comando.Parameters.AddWithValue("@endereco", objCliente.endereco);
            comando.Parameters.AddWithValue("@cidade", objCliente.cidade);
            comando.Parameters.AddWithValue("@estado", objCliente.estado);
            comando.Parameters.AddWithValue("@nome", objCliente.nome);
            comando.Parameters.AddWithValue("@telefone", objCliente.telefone);
            comando.Parameters.AddWithValue("@dataNascimento", objCliente.dataNascimento);
            comando.Parameters.AddWithValue("@adicionalInfo", objCliente.adicionalInfo);
            comando.Parameters.AddWithValue("@cpf_resp", objCliente.objResponsavel.cpf);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }
        public void Registrar(Cliente objCliente)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Cliente (cpf, email, endereco, cidade, estado, nome, telefone, dataNascimento, adicionalInfo) " +
                "values (@cpf, @email, @endereco, @cidade, @estado, @nome, @telefone, @dataNascimento, @adicionalInfo)";
            comando.Parameters.AddWithValue("@cpf", objCliente.cpf);
            comando.Parameters.AddWithValue("@email", objCliente.email);
            comando.Parameters.AddWithValue("@endereco", objCliente.endereco);
            comando.Parameters.AddWithValue("@cidade", objCliente.cidade);
            comando.Parameters.AddWithValue("@estado", objCliente.estado);
            comando.Parameters.AddWithValue("@nome", objCliente.nome);
            comando.Parameters.AddWithValue("@telefone", objCliente.telefone);
            comando.Parameters.AddWithValue("@dataNascimento", objCliente.dataNascimento);
            comando.Parameters.AddWithValue("@adicionalInfo", objCliente.adicionalInfo);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }
        /// <summary>
        /// Retorna um cliente baseado no id
        /// </summary>
        /// <param name="id">id utilizado para encontrar o cliente</param>
        /// <returns></returns>
        public Cliente Pesquisar(int id)
        {
            Cliente objCliente = new Cliente();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Cliente WHERE id LIKE @id";
            comando.Parameters.AddWithValue("@id", id);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                dr.Read();
                objCliente.nome = dr["nome"].ToString();
                objCliente.cpf = dr["cpf"].ToString();
                objCliente.endereco = dr["endereco"].ToString();
                objCliente.cidade = dr["cidade"].ToString();
                objCliente.estado = dr["estado"].ToString();
                objCliente.email = dr["email"].ToString();
                objCliente.telefone = dr["telefone"].ToString();
                objCliente.dataNascimento = Convert.ToDateTime(dr["dataNascimento"]);
                objCliente.adicionalInfo = dr["adicionalInfo"].ToString();
                objCliente.id = Convert.ToInt32(dr["id"]);
                objCliente.objResponsavel = new ResponsavelDAO().Pesquisar(dr["cpf"].ToString());
            }
            else
            {
                objCliente = null;
            }
            return objCliente;
        }
        /// <summary>
        /// Retorna um cliente baseado no cpf
        /// </summary>
        /// <param name="cpf">CPF para ser utilizado para encontrar o cliente</param>
        /// <returns></returns>
        public Cliente Pesquisar(string cpf)
        {
            Cliente objCliente = new Cliente();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Cliente WHERE cpf LIKE @cpf";
            comando.Parameters.AddWithValue("@cpf", cpf);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                dr.Read();
                objCliente.nome = dr["nome"].ToString();
                objCliente.cpf = dr["cpf"].ToString();
                objCliente.endereco = dr["endereco"].ToString();
                objCliente.cidade = dr["cidade"].ToString();
                objCliente.estado = dr["estado"].ToString();
                objCliente.email = dr["email"].ToString();
                objCliente.telefone = dr["telefone"].ToString();
                objCliente.dataNascimento = Convert.ToDateTime(dr["dataNascimento"]);
                objCliente.adicionalInfo = dr["adicionalInfo"].ToString();
                objCliente.id = Convert.ToInt32(dr["id"]);
                objCliente.objResponsavel = new ResponsavelDAO().Pesquisar(dr["cpf"].ToString());
            }
            else
            {
                objCliente = null;
            }
            return objCliente;
        }
        /// <summary>
        /// Retorna um cliente baseado no nome
        /// </summary>
        /// <param name="nome">Nome a ser utilizado para pesquisar o cliente</param>
        /// <returns></returns>
        public IList<Cliente> PesquisarPorNome(string nome)
        {
            IList<Cliente> listaDeClientes = new List<Cliente>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM CLIENTE where nome LIKE @nome";
            comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Cliente objCliente = new Cliente();
                    objCliente.nome = dr["nome"].ToString();
                    objCliente.cpf = dr["cpf"].ToString();
                    objCliente.endereco = dr["endereco"].ToString();
                    objCliente.cidade = dr["cidade"].ToString();
                    objCliente.estado = dr["estado"].ToString();
                    objCliente.email = dr["email"].ToString();
                    objCliente.telefone = dr["telefone"].ToString();
                    objCliente.dataNascimento = Convert.ToDateTime(dr["dataNascimento"]);
                    objCliente.adicionalInfo = dr["adicionalInfo"].ToString();
                    objCliente.id = Convert.ToInt32(dr["id"]);
                    objCliente.objResponsavel = new ResponsavelDAO().Pesquisar(dr["cpf"].ToString());

                    listaDeClientes.Add(objCliente);
                }
            }
            else
            {
                listaDeClientes = null;
            }
            return listaDeClientes;
        }
        public void Excluir(Cliente objCliente)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM Cliente where id=@id";
            comando.Parameters.AddWithValue("@id", objCliente.id);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }
        public void ExcluirComSessao(Cliente objCliente)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "exec p2 @id";
            comando.Parameters.AddWithValue("@id", objCliente.id);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }
        public void Alterar(Cliente objCliente)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Cliente SET cpf=@cpf email=@email endereco=@endereco cidade=@cidade, estado=@estado nome=@nome telefone=@telefone dataNascimento=@dtNasc adicionalInfo = @ainfo cpf_responsavel = @cpfresp";
            comando.Parameters.AddWithValue("@cpf", objCliente.cpf);
            comando.Parameters.AddWithValue("@email", objCliente.email);
            comando.Parameters.AddWithValue("@endereco", objCliente.endereco);
            comando.Parameters.AddWithValue("@cidade", objCliente.cidade);
            comando.Parameters.AddWithValue("@estado", objCliente.estado);
            comando.Parameters.AddWithValue("@nome", objCliente.nome);
            comando.Parameters.AddWithValue("@telefone", objCliente.telefone);
            comando.Parameters.AddWithValue("@dtNasc", objCliente.dataNascimento);
            comando.Parameters.AddWithValue("@ainfo", objCliente.adicionalInfo);
            comando.Parameters.AddWithValue("@cpfresp", objCliente.objResponsavel.cpf);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }
    }
}
