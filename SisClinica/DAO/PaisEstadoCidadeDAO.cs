using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClinica.Classes;
using System.Data;
using System.Data.SqlClient;

namespace SisClinica.DAO
{
    public class PaisEstadoCidadeDAO
    {
        public PaisEstadoCidade BuscarCidade(int idCidade)
        {
            PaisEstadoCidade objPaisEstadoCidade = new PaisEstadoCidade();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM cidade WHERE cod_cidade = @id";
            comando.Parameters.AddWithValue("@id", idCidade);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                dr.Read();
                                
                objPaisEstadoCidade.idCidade = (int)dr["cod_cidade"];
                objPaisEstadoCidade.idEstado = (int)dr["cod_estado"];
                PaisEstadoCidade e = new PaisEstadoCidade().BuscarEstado(objPaisEstadoCidade.idEstado);
                objPaisEstadoCidade.siglaEstado = e.siglaEstado;
                objPaisEstadoCidade.nomeCidade = dr["nom_cidade"].ToString();
            }
            else
            {
                objPaisEstadoCidade = null;
            }
            return objPaisEstadoCidade;
        }
        //private string SiglaEstado(int idEstado)
        //{
        //    string value;
        //    SqlCommand comando = new SqlCommand();
        //    comando.CommandType = CommandType.Text;
        //    comando.CommandText = "SELECT sgl_estado FROM estado WHERE cod_estado = @id";
        //    comando.Parameters.AddWithValue("@id", idEstado);

        //    Conexao con = new Conexao();
        //    SqlDataReader dr = con.ExecutarSelect(comando);
        //    if (dr.HasRows)
        //    {
        //        dr.Read();
        //        value = dr["sgl_estado"].ToString();
        //    }
        //}
        public IList<PaisEstadoCidade> BuscarCidadesPorEstado(int idEstado)
        {
            IList<PaisEstadoCidade> listaPaisEstadoCidade = new List<PaisEstadoCidade>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM cidade WHERE cod_estado = @id";
            comando.Parameters.AddWithValue("@id", idEstado);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    PaisEstadoCidade objPaisEstadoCidade = new PaisEstadoCidade();
                    objPaisEstadoCidade.idCidade = (int)dr["cod_cidade"];
                    objPaisEstadoCidade.idEstado = idEstado;
                    objPaisEstadoCidade.nomeCidade = dr["nom_cidade"].ToString();
                    listaPaisEstadoCidade.Add(objPaisEstadoCidade);
                }
               
            }
            else
            {
                listaPaisEstadoCidade = null;
            }
            return listaPaisEstadoCidade;
        }
        public IList<PaisEstadoCidade> BuscarTodosOsEstados()
        {
            IList<PaisEstadoCidade> listaPaisEstadoCidade = new List<PaisEstadoCidade>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from estado";

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    PaisEstadoCidade objPaisEstadoCidade = new PaisEstadoCidade();
                    objPaisEstadoCidade.idEstado = Convert.ToInt32(dr["cod_estado"]);
                    objPaisEstadoCidade.siglaEstado = dr["sgl_estado"].ToString();
                    listaPaisEstadoCidade.Add(objPaisEstadoCidade);
                }
            }
            else
            {
                listaPaisEstadoCidade = null;
            }
            return listaPaisEstadoCidade;
        }
        public PaisEstadoCidade BuscarEstado(int idEstado)
        {
            PaisEstadoCidade objPaisEstadoCidade = new PaisEstadoCidade();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from estado where cod_estado = @id";
            comando.Parameters.AddWithValue("@id", idEstado);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);
            if (dr.HasRows)
            {
                dr.Read();               
                objPaisEstadoCidade.idEstado = (int)dr["cod_estado"];                
                objPaisEstadoCidade.siglaEstado = dr["sgl_estado"].ToString();
            }
            else
            {
                objPaisEstadoCidade = null;
            }
            return objPaisEstadoCidade;
        }
    }
}
