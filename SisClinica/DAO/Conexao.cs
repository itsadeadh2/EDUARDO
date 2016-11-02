using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SisClinica.DAO
{
    class Conexao
    {
        private SqlConnection Conectar()
        {
            string StringConexao = "Data Source = MALAKI; Initial Catalog = BDSISCLIN; user ID = sa; Password = 0123654852; Min Pool Size=5;Max Pool Size=250; Connect Timeout=3";
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
