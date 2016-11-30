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
    public class MedicoDAO
    {
        public void Registrar(Medico objMedico)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Medico(cpf, email, endereco, cidade, estado, nome, telefone, dataNascimento, crm) values (@cpf, @email, @endereco, @cidade, @estado, @nome, @telefone, @dataNascimento, @crm)";
            comando.Parameters.AddWithValue("@cpf", objMedico.cpf);
            comando.Parameters.AddWithValue("@email", objMedico.email);
            comando.Parameters.AddWithValue("@endereco", objMedico.endereco);
            comando.Parameters.AddWithValue("@cidade", objMedico.paisEstadoCidade.idCidade);
            comando.Parameters.AddWithValue("@estado", objMedico.paisEstadoCidade.idEstado);
            comando.Parameters.AddWithValue("@nome", objMedico.nome);
            comando.Parameters.AddWithValue("@telefone", objMedico.telefone);
            comando.Parameters.AddWithValue("@dataNascimento", objMedico.dataNascimento);
            comando.Parameters.AddWithValue("@crm", objMedico.crm);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }
        public Medico PesquisarPorCpf(string cpf)
        {
            Medico objMedico = new Medico();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Medico where cpf = @cpf";
            comando.Parameters.AddWithValue("@cpf", cpf);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                dr.Read();
                objMedico.id = Convert.ToInt32(dr["id"]);
                objMedico.cpf = dr["cpf"].ToString();
                objMedico.email = dr["email"].ToString();
                objMedico.endereco = dr["endereco"].ToString();
                objMedico.paisEstadoCidade = new PaisEstadoCidade().BuscarCidade((int)dr["cidade"]);
                objMedico.nome = dr["nome"].ToString();
                objMedico.telefone = dr["telefone"].ToString();
                objMedico.dataNascimento = Convert.ToDateTime(dr["dataNascimento"]);
                objMedico.crm = dr["crm"].ToString();
            }
            else
            {
                objMedico = null;
            }
            return objMedico;
        }
        public Medico Pesquisar(int id)
        {
            Medico objMedico = new Medico();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Medico where id = @id";
            comando.Parameters.AddWithValue("@id", id);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                dr.Read();
                objMedico.id = Convert.ToInt32(dr["id"]);
                objMedico.cpf = dr["cpf"].ToString();
                objMedico.email = dr["email"].ToString();
                objMedico.endereco = dr["endereco"].ToString();
                objMedico.paisEstadoCidade = new PaisEstadoCidade().BuscarCidade((int)dr["cidade"]);
                objMedico.nome = dr["nome"].ToString();
                objMedico.telefone = dr["telefone"].ToString();
                objMedico.dataNascimento = Convert.ToDateTime(dr["dataNascimento"]);
                objMedico.crm = dr["crm"].ToString();
            }
            else
            {
                objMedico = null;
            }
            return objMedico;
        }
        public IList<Medico> Pesquisar()
        {
            IList<Medico> listaDemedicos = new List<Medico>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Medico";

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Medico objMedico = new Medico();
                    objMedico.id = Convert.ToInt32(dr["id"]);
                    objMedico.cpf = dr["cpf"].ToString();
                    objMedico.email = dr["email"].ToString();
                    objMedico.endereco = dr["endereco"].ToString();
                    objMedico.paisEstadoCidade = new PaisEstadoCidade().BuscarCidade((int)dr["cidade"]);
                    objMedico.nome = dr["nome"].ToString();
                    objMedico.telefone = dr["telefone"].ToString();
                    objMedico.dataNascimento = Convert.ToDateTime(dr["dataNascimento"]);
                    objMedico.crm = dr["crm"].ToString();
                    listaDemedicos.Add(objMedico);
                }
            }
            else
            {
                listaDemedicos = null;
            }
            return listaDemedicos;
        }

        public Medico PesquisarPorCrm(string crm)
        {
            Medico objMedico = new Medico();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Medico where crm = @crm";
            comando.Parameters.AddWithValue("@crm", crm);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                dr.Read();
                objMedico.id = Convert.ToInt32(dr["id"]);
                objMedico.cpf = dr["cpf"].ToString();
                objMedico.email = dr["email"].ToString();
                objMedico.endereco = dr["endereco"].ToString();
                objMedico.paisEstadoCidade = new PaisEstadoCidade().BuscarCidade((int)dr["cidade"]);
                objMedico.nome = dr["nome"].ToString();
                objMedico.telefone = dr["telefone"].ToString();
                objMedico.dataNascimento = Convert.ToDateTime(dr["dataNascimento"]);
                objMedico.crm = dr["crm"].ToString();
            }
            else
            {
                objMedico = null;
            }
            return objMedico;
        }

        public void Alterar(Medico objMedico)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE MEDICO set email=@email, endereco=@endereco, cidade=@cidade, estado=@estado, nome=@nome, telefone=@telefone where id=@id";
            comando.Parameters.AddWithValue("@email", objMedico.email);
            comando.Parameters.AddWithValue("@id", objMedico.id);
            comando.Parameters.AddWithValue("@endereco", objMedico.endereco);
            comando.Parameters.AddWithValue("@cidade", objMedico.paisEstadoCidade.idCidade);
            comando.Parameters.AddWithValue("@estado", objMedico.paisEstadoCidade.idEstado);
            comando.Parameters.AddWithValue("@nome", objMedico.nome);
            comando.Parameters.AddWithValue("@telefone", objMedico.telefone);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }

        public IList<Medico> Pesquisar(string nome)
        {
            IList<Medico> listaDemedicos = new List<Medico>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Medico where nome like @nome";
            comando.Parameters.AddWithValue("@nome", "%" + nome + "%");
            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Medico objMedico = new Medico();
                    objMedico.id = Convert.ToInt32(dr["id"]);
                    objMedico.cpf = dr["cpf"].ToString();
                    objMedico.email = dr["email"].ToString();
                    objMedico.endereco = dr["endereco"].ToString();
                    objMedico.paisEstadoCidade = new PaisEstadoCidade().BuscarCidade((int)dr["cidade"]);
                    objMedico.nome = dr["nome"].ToString();
                    objMedico.telefone = dr["telefone"].ToString();
                    objMedico.dataNascimento = Convert.ToDateTime(dr["dataNascimento"]);
                    objMedico.crm = dr["crm"].ToString();
                    listaDemedicos.Add(objMedico);
                }
            }
            else
            {
                listaDemedicos = null;
            }
            return listaDemedicos;
        }

        public void Excluir(Medico objMedico)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM Medico where id=@id";
            comando.Parameters.AddWithValue("@id", objMedico.id);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }
        public void ExcluirComSessoes(Medico objMedico)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM sessoes where id_medico_responsavel=@id DELETE FROM Medico where id=@id";
            comando.Parameters.AddWithValue("@id", objMedico.id);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }
    }
}
