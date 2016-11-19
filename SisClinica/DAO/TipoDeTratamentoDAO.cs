using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClinica.Classes;
using System.Data.SqlClient;
using System.Data;

namespace SisClinica.DAO
{
    public class TipoDeTratamentoDAO
    {
        public void CadastrarNovoTipo(TipoDeTratamento tipo)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO tipodetratamento(nome, valor) VALUES (@nome,@valor)";
            comando.Parameters.AddWithValue("@nome", tipo.nome);
            comando.Parameters.AddWithValue("@valor", tipo.valor);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }
        public IList<TipoDeTratamento> PesquisarTratamentos()
        {
            IList<TipoDeTratamento> listaDeTipos = new List<TipoDeTratamento>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM tipodetratamento";

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    TipoDeTratamento objTipo = new TipoDeTratamento();
                    objTipo.nome = dr["nome"].ToString();
                    objTipo.id = (int)dr["id"];
                    objTipo.valor = (decimal)dr["valor"];
                    listaDeTipos.Add(objTipo);
                }
            }
            return listaDeTipos;
        }
        public TipoDeTratamento PesquisarTratamentos(int id)
        {
            TipoDeTratamento objTipo = new TipoDeTratamento();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM tipodetratamento WHERE id=@id";
            comando.Parameters.AddWithValue("@id", id);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                dr.Read();
                objTipo.nome = dr["nome"].ToString();
                objTipo.id = (int)dr["id"];
                objTipo.valor = (decimal)dr["valor"];
            }
            return objTipo;
        }
        public TipoDeTratamento PesquisarTratamentosPorNome(string nome)
        {
            TipoDeTratamento objTipodeTratamento = new TipoDeTratamento();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * FROM tipodetratamento Where nome=@nome";
            comando.Parameters.AddWithValue("@nome", nome);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);
            if (dr.HasRows)
            {
                dr.Read();
                objTipodeTratamento.nome = dr["nome"].ToString();
                objTipodeTratamento.id = (int)dr["id"];
                objTipodeTratamento.valor = (decimal)dr["valor"];
            }
            else
            {
                objTipodeTratamento = null;
            }
            return objTipodeTratamento;
        }
    }
}
