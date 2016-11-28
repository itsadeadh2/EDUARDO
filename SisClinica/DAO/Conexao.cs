using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SisClinica.DAO
{
    public class Conexao
    {
        private SqlConnection Conectar()
        {
            string StringConexao = "Data Source = kei-pc; Initial Catalog = BDSISCLIN; user ID = sa; Password = 147k; Min Pool Size=5;Max Pool Size=250; Connect Timeout=5";
            SqlConnection conexao = new SqlConnection(StringConexao);
            conexao.Open();
            return conexao;
        }

        public void ExecutarCru(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            comando.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataReader ExecutarSelect(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
    }
}
