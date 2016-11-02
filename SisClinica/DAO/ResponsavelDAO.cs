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
    public class ResponsavelDAO
    {
        public void Registrar(Responsavel objResponsvavel)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Responsavel (cpf, email, endereco, cidadeEstado, nome, telefone, dataNascimento) values (@cpf, @email, @endereco, @cidadeEstado, @nome, @telefone, @dataNascimento)";
            comando.Parameters.AddWithValue("@cpf", objResponsvavel.cpf);
            comando.Parameters.AddWithValue("@email", objResponsvavel.email);
            comando.Parameters.AddWithValue("@endereco", objResponsvavel.endereco);
            comando.Parameters.AddWithValue("@cidadeEstado", objResponsvavel.cidadeEstado);
            comando.Parameters.AddWithValue("@nome", objResponsvavel.nome);
            comando.Parameters.AddWithValue("@telefone", objResponsvavel.telefone);
            comando.Parameters.AddWithValue("@dataNascimento", objResponsvavel.dataNascimento);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }

        public Responsavel Pesquisar(int id)
        {
            Responsavel objResponsavel = new Responsavel();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Responsavel where id=@id";
            comando.Parameters.AddWithValue("@id", id);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                dr.Read();
                objResponsavel.id = Convert.ToInt32(dr["id"]);
                objResponsavel.nome = dr["nome"].ToString();
                objResponsavel.cpf = dr["cpf"].ToString();
                objResponsavel.email = dr["email"].ToString();
                objResponsavel.cidadeEstado = dr["cidadeEstado"].ToString();
                objResponsavel.telefone = dr["telefone"].ToString();
                objResponsavel.dataNascimento = Convert.ToDateTime(dr["dataNascimento"]);
            }
            else
            {
                objResponsavel = null;
            }
            return objResponsavel;
        }

        public Responsavel Pesquisar(string cpf)
        {
            Responsavel objResponsavel = new Responsavel();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Responsavel where cpf like @cpf";
            comando.Parameters.AddWithValue("@cpf", cpf);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                dr.Read();
                objResponsavel.id = Convert.ToInt32(dr["id"]);
                objResponsavel.nome = dr["nome"].ToString();
                objResponsavel.cpf = dr["cpf"].ToString();
                objResponsavel.email = dr["email"].ToString();
                objResponsavel.cidadeEstado = dr["cidadeEstado"].ToString();
                objResponsavel.telefone = dr["telefone"].ToString();
                objResponsavel.dataNascimento = Convert.ToDateTime(dr["dataNascimento"]);
            }
            else
            {
                objResponsavel = null;
            }
            return objResponsavel;
        }

        public IList<Responsavel> PesquisarPorNome(string nome)
        {
            IList<Responsavel> listaDeResponsaveis = new List<Responsavel>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Responsavel where nome like @nome";
            comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Responsavel objResponsavel = new Responsavel();
                    objResponsavel.id = (int)dr["id"];
                    objResponsavel.cpf = dr["cpf"].ToString();
                    objResponsavel.email = dr["email"].ToString();
                    objResponsavel.endereco = dr["endereco"].ToString();
                    objResponsavel.cidadeEstado = dr["cidadeEstado"].ToString();
                    objResponsavel.nome = dr["nome"].ToString();
                    objResponsavel.telefone = dr["telefone"].ToString();
                    objResponsavel.dataNascimento = Convert.ToDateTime(dr["dataNascimento"]);
                    listaDeResponsaveis.Add(objResponsavel);
                }
            }
            else
            {
                listaDeResponsaveis = null;
            }
            return listaDeResponsaveis;
        }
    }
}
