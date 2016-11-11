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
            comando.CommandText = "INSERT INTO tipodetratamento VALUES (@nome)";
            comando.Parameters.AddWithValue("@nome", tipo.nome);

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
            }
            return objTipo;
        }
    }
}
