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
    class SessoesDAO
    {
        public void RegistrarConsulta(Sessoes objSessao)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Sessoes (dataSessao, horaInicio, horaFim, tipoDeSessao, id_medico_responsavel, id_cliente, id_consultorio) " +
                "values (@dataSessao, @horaInicio, @horaFim, @tipoDeSessao, @id_medico_responsavel, @id_cliente, @id_consultorio)";
            comando.Parameters.AddWithValue("@dataSessao", objSessao.dataSessao);
            comando.Parameters.AddWithValue("@horainicio", objSessao.horaInicio);
            comando.Parameters.AddWithValue("@horafim", objSessao.horaFim);
            comando.Parameters.AddWithValue("@tipoDeSessao", objSessao.tipoDeSessao);
            comando.Parameters.AddWithValue("@id_medico_responsavel", objSessao.medicoResponsavel.id);
            comando.Parameters.AddWithValue("@id_cliente", objSessao.objCliente.id);
            comando.Parameters.AddWithValue("@id_consultorio", objSessao.objConsultorio.id);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }
        public void RegistrarTratamento(Sessoes objSessao)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Sessoes (datasessao, horainicio, horafim, tipodesessao, id_medico_responsavel, id_cliente, sessaoCompleta, id_consultorio, id_tipodetratamento, valorSessao,qtdeSessoes, nroSessao) " +
                                  "values (@datasessao, @horainicio, @horafim, @tipodesessao, @id_medico_responsavel, @id_cliente, @sessaocompleta,@id_consultorio, @id_tipoDeTratamento, @valorSessao, @qtdeSessoes, @nroSessao)";
            comando.Parameters.AddWithValue("@datasessao", objSessao.dataSessao);
            comando.Parameters.AddWithValue("@horainicio",objSessao.horaInicio);
            comando.Parameters.AddWithValue("@horafim", objSessao.horaFim);
            comando.Parameters.AddWithValue("@tipodesessao", objSessao.tipoDeSessao);
            comando.Parameters.AddWithValue("@id_medico_responsavel",objSessao.medicoResponsavel.id);
            comando.Parameters.AddWithValue("@id_cliente", objSessao.objCliente.id);
            comando.Parameters.AddWithValue("@sessaocompleta",Convert.ToInt32(objSessao.sessaoCompleta));
            comando.Parameters.AddWithValue("@id_consultorio", objSessao.objConsultorio.id);
            comando.Parameters.AddWithValue("@id_tipoDeTratamento", objSessao.tipoDeTratamento.id);
            comando.Parameters.AddWithValue("@valorSessao", objSessao.valorSessao);
            comando.Parameters.AddWithValue("@qtdeSessoes", objSessao.qtdeSessoes);
            comando.Parameters.AddWithValue("@nroSessao", objSessao.nroSessao);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }

        public IList<Sessoes> PesquisarPorHorarioInicial(DateTime data)
        {
            IList<Sessoes> listadeSessoes = new List<Sessoes>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Sessoes where horaInicio = @data";
            comando.Parameters.AddWithValue("@data", data);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Sessoes objSessao = new Sessoes();
                    objSessao.medicoResponsavel = new MedicoDAO().Pesquisar(Convert.ToInt32(dr["id_medico_responsavel"]));
                    objSessao.objCliente = new ClienteDAO().Pesquisar(Convert.ToInt32(dr["id_cliente"]));
                    objSessao.objConsultorio = new ConsultorioDAO().Pesquisar(Convert.ToInt32(dr["id_consultorio"]));
                    objSessao.dataSessao = Convert.ToDateTime(dr["dataSessao"]);
                    objSessao.horaFim = Convert.ToDateTime(dr["horaFim"]);
                    objSessao.horaInicio = Convert.ToDateTime(dr["horaInicio"]);
                    objSessao.tipoDeSessao = dr["tipoDeSessao"].ToString();
                    objSessao.id = (int)dr["id"];
                    listadeSessoes.Add(objSessao);
                }                 
            }
            else
            {
                listadeSessoes = null;
            }
            return listadeSessoes;
        }
        public IList<Sessoes> PesquisarPorData(DateTime data)
        {
            IList<Sessoes> listadeSessoes = new List<Sessoes>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Sessoes where dataSessao = @data";
            comando.Parameters.AddWithValue("@data", data);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Sessoes objSessao = new Sessoes();
                    objSessao.medicoResponsavel = new MedicoDAO().Pesquisar(Convert.ToInt32(dr["id_medico_responsavel"]));
                    objSessao.objCliente = new ClienteDAO().Pesquisar(Convert.ToInt32(dr["id_cliente"]));
                    objSessao.objConsultorio = new ConsultorioDAO().Pesquisar(Convert.ToInt32(dr["id_consultorio"]));
                    objSessao.dataSessao = Convert.ToDateTime(dr["dataSessao"]);
                    objSessao.horaFim = Convert.ToDateTime(dr["horaFim"]);
                    objSessao.horaInicio = Convert.ToDateTime(dr["horaInicio"]);
                    objSessao.tipoDeSessao = dr["tipoDeSessao"].ToString();
                    objSessao.id = (int)dr["id"];
                    listadeSessoes.Add(objSessao);
                }
            }
            else
            {
                listadeSessoes = null;
            }
            return listadeSessoes;
        }
        public Sessoes Pesquisar(DateTime data, Medico objMedico, Consultorio objConsultorio)
        {
            Sessoes objSessao = new Sessoes();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Sessoes where horaInicio = @data and id_medico_responsavel = @id and id_consultorio=@idcons";
            comando.Parameters.AddWithValue("@data", data);
            comando.Parameters.AddWithValue("@id", objMedico.id);
            comando.Parameters.AddWithValue("@idcons", objConsultorio.id);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                dr.Read();
                objSessao.medicoResponsavel = new MedicoDAO().Pesquisar(Convert.ToInt32(dr["id_medico_responsavel"]));
                objSessao.objCliente = new ClienteDAO().Pesquisar(Convert.ToInt32(dr["id_cliente"]));
                objSessao.objConsultorio = new ConsultorioDAO().Pesquisar(Convert.ToInt32(dr["id_consultorio"]));
                objSessao.dataSessao = Convert.ToDateTime(dr["dataSessao"]);
                objSessao.horaFim = Convert.ToDateTime(dr["horaFim"]);
                objSessao.horaInicio = Convert.ToDateTime(dr["horaInicio"]);
                objSessao.tipoDeSessao = dr["tipoDeSessao"].ToString();
                objSessao.id = (int)dr["id"];
            }
            else
            {
                objSessao = null;
            }
            return objSessao;
        }

        public IList<Sessoes> Pesquisar(Medico objMedico)
        {
            IList<Sessoes> listaDeSessoes = new List<Sessoes>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Sessoes WHERE id_medico_responsavel = @id";
            comando.Parameters.AddWithValue("@id", objMedico.id);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Sessoes objSessao = new Sessoes();
                    objSessao.medicoResponsavel = new MedicoDAO().Pesquisar(Convert.ToInt32(dr["id_medico_responsavel"]));
                    objSessao.objCliente = new ClienteDAO().Pesquisar(Convert.ToInt32(dr["id_cliente"]));
                    objSessao.objConsultorio = new ConsultorioDAO().Pesquisar(Convert.ToInt32(dr["id_consultorio"]));
                    objSessao.dataSessao = Convert.ToDateTime(dr["dataSessao"]);
                    objSessao.horaFim = Convert.ToDateTime(dr["horaFim"]);
                    objSessao.horaInicio = Convert.ToDateTime(dr["horaInicio"]);
                    objSessao.tipoDeSessao = dr["tipoDeSessao"].ToString();
                    objSessao.id = (int)dr["id"];
                    listaDeSessoes.Add(objSessao);
                }
            }
            else
            {
                listaDeSessoes = null;
            }
            return listaDeSessoes;
        }

        public Sessoes Pesquisar(int id)
        {
            Sessoes objSessao = new Sessoes();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Sessoes where id=@id";
            comando.Parameters.AddWithValue("@id", id);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                dr.Read();
                objSessao.medicoResponsavel = new MedicoDAO().Pesquisar(Convert.ToInt32(dr["id_medico_responsavel"]));
                objSessao.objCliente = new ClienteDAO().Pesquisar(Convert.ToInt32(dr["id_cliente"]));
                objSessao.objConsultorio = new ConsultorioDAO().Pesquisar(Convert.ToInt32(dr["id_consultorio"]));
                objSessao.dataSessao = Convert.ToDateTime(dr["dataSessao"]);
                objSessao.horaFim = Convert.ToDateTime(dr["horaFim"]);
                objSessao.horaInicio = Convert.ToDateTime(dr["horaInicio"]);
                objSessao.tipoDeSessao = dr["tipoDeSessao"].ToString();
                objSessao.id = (int)dr["id"];
            }
            else
            {
                objSessao = null;
            }
            return objSessao;
        }

        public IList<Sessoes> Pesquisar(Cliente objCliente)
        {
            IList<Sessoes> listaDeSessoes = new List<Sessoes>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Sessoes WHERE id_cliente = @id";
            comando.Parameters.AddWithValue("@id", objCliente.id);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Sessoes objSessao = new Sessoes();
                    objSessao.medicoResponsavel = new MedicoDAO().Pesquisar(Convert.ToInt32(dr["id_medico_responsavel"]));
                    objSessao.objCliente = new ClienteDAO().Pesquisar(Convert.ToInt32(dr["id_cliente"]));
                    objSessao.objConsultorio = new ConsultorioDAO().Pesquisar(Convert.ToInt32(dr["id_consultorio"]));
                    objSessao.dataSessao = Convert.ToDateTime(dr["dataSessao"]);
                    objSessao.horaFim = Convert.ToDateTime(dr["horaFim"]);
                    objSessao.horaInicio = Convert.ToDateTime(dr["horaInicio"]);
                    objSessao.tipoDeSessao = dr["tipoDeSessao"].ToString();
                    objSessao.id = (int)dr["id"];
                    listaDeSessoes.Add(objSessao);
                }
            }
            else
            {
                listaDeSessoes = null;
            }
            return listaDeSessoes;
        }

        public IList<Sessoes> Pesquisar(Consultorio objConsultorio)
        {
            IList<Sessoes> listaDeSessoes = new List<Sessoes>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Sessoes WHERE id_consultorio = @id";
            comando.Parameters.AddWithValue("@id", objConsultorio.id);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Sessoes objSessao = new Sessoes();
                    objSessao.medicoResponsavel = new MedicoDAO().Pesquisar(Convert.ToInt32(dr["id_medico_responsavel"]));
                    objSessao.objCliente = new ClienteDAO().Pesquisar(Convert.ToInt32(dr["id_cliente"]));
                    objSessao.objConsultorio = new ConsultorioDAO().Pesquisar(Convert.ToInt32(dr["id_consultorio"]));
                    objSessao.dataSessao = Convert.ToDateTime(dr["dataSessao"]);
                    objSessao.horaFim = Convert.ToDateTime(dr["horaFim"]);
                    objSessao.horaInicio = Convert.ToDateTime(dr["horaInicio"]);
                    objSessao.tipoDeSessao = dr["tipoDeSessao"].ToString();
                    objSessao.id = (int)dr["id"];
                    listaDeSessoes.Add(objSessao);
                }   
            }
            else
            {
                listaDeSessoes = null;
            }
            return listaDeSessoes;
        }
    }
}
