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
            comando.CommandText = "INSERT INTO Sessoes (dataSessao, horaInicio, horaFim, tipoDeSessao, id_medico_responsavel, id_cliente, id_consultorio,sessaoCompleta ) " +
                "values (@dataSessao, @horaInicio, @horaFim, @tipoDeSessao, @id_medico_responsavel, @id_cliente, @id_consultorio, @sessaoCompleta)";
            comando.Parameters.AddWithValue("@dataSessao", objSessao.dataSessao);
            comando.Parameters.AddWithValue("@horainicio", objSessao.horaInicio);
            comando.Parameters.AddWithValue("@horafim", objSessao.horaFim);
            comando.Parameters.AddWithValue("@tipoDeSessao", objSessao.tipoDeSessao);
            comando.Parameters.AddWithValue("@id_medico_responsavel", objSessao.medicoResponsavel.id);
            comando.Parameters.AddWithValue("@id_cliente", objSessao.objCliente.id);
            comando.Parameters.AddWithValue("@id_consultorio", objSessao.objConsultorio.id);
            comando.Parameters.AddWithValue("@sessaoCompleta", Convert.ToInt32(objSessao.sessaoCompleta));

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }
        public void RegistrarTratamento(Sessoes objSessao)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Sessoes (datasessao, horainicio, horafim, tipodesessao, id_medico_responsavel, id_cliente, sessaoCompleta, id_consultorio, id_tipodetratamento, valorSessao,qtdeSessoes, nroSessao, sessaoQuitada) " +
                                  "values (@datasessao, @horainicio, @horafim, @tipodesessao, @id_medico_responsavel, @id_cliente, @sessaocompleta,@id_consultorio, @id_tipoDeTratamento, @valorSessao, @qtdeSessoes, @nroSessao, @sessaoQuitada)";
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
            comando.Parameters.AddWithValue("@sessaoQuitada", objSessao.quitada);

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
                    if (objSessao.tipoDeSessao=="Tratamento")
                    {
                        objSessao.tipoDeTratamento = new TipoDeTratamento().Pesquisar(Convert.ToInt32(dr["id_tipodetratamento"]));
                        objSessao.quitada = Convert.ToBoolean(dr["sessaoQuitada"]);
                        objSessao.valorSessao = Convert.ToDecimal(dr["valorsessao"]);
                        objSessao.qtdeSessoes = Convert.ToInt32(dr["qtdesessoes"]);
                        objSessao.nroSessao = Convert.ToInt32(dr["nroSessao"]);
                    }
                    objSessao.sessaoCompleta = Convert.ToBoolean(dr["sessaocompleta"]);
                    objSessao.id = (int)dr["id"];
                    if (objSessao.sessaoCompleta==true)
                    {
                        objSessao.situacao = "Finalizada";
                    }
                    else
                    {
                        objSessao.situacao = "Agendada";
                    }
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
                    if (objSessao.tipoDeSessao == "Tratamento")
                    {
                        objSessao.tipoDeTratamento = new TipoDeTratamento().Pesquisar(Convert.ToInt32(dr["id_tipodetratamento"]));
                        objSessao.quitada = Convert.ToBoolean(dr["sessaoQuitada"]);
                        objSessao.valorSessao = Convert.ToDecimal(dr["valorsessao"]);
                        objSessao.qtdeSessoes = Convert.ToInt32(dr["qtdesessoes"]);
                        objSessao.nroSessao = Convert.ToInt32(dr["nroSessao"]);
                    }
                    objSessao.sessaoCompleta = Convert.ToBoolean(dr["sessaocompleta"]);
                    objSessao.id = (int)dr["id"];
                    if (objSessao.sessaoCompleta == true)
                    {
                        objSessao.situacao = "Finalizada";
                    }
                    else
                    {
                        objSessao.situacao = "Agendada";
                    }
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
                if (objSessao.tipoDeSessao == "Tratamento")
                {
                    objSessao.tipoDeTratamento = new TipoDeTratamento().Pesquisar(Convert.ToInt32(dr["id_tipodetratamento"]));
                    objSessao.quitada = Convert.ToBoolean(dr["sessaoQuitada"]);
                    objSessao.valorSessao = Convert.ToDecimal(dr["valorsessao"]);
                    objSessao.qtdeSessoes = Convert.ToInt32(dr["qtdesessoes"]);
                    objSessao.nroSessao = Convert.ToInt32(dr["nroSessao"]);
                }
                objSessao.sessaoCompleta = Convert.ToBoolean(dr["sessaocompleta"]);
                objSessao.id = (int)dr["id"];
                if (objSessao.sessaoCompleta == true)
                {
                    objSessao.situacao = "Finalizada";
                }
                else
                {
                    objSessao.situacao = "Agendada";
                }
            }
            else
            {
                objSessao = null;
            }
            return objSessao;
        }
        public Sessoes Pesquisar(DateTime data, Medico objMedico, Consultorio objConsultorio, Sessoes sessaoAIgnorar)
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
                if (sessaoAIgnorar.id==(int)dr["id"])
                {

                }
                else
                {
                    objSessao.medicoResponsavel = new MedicoDAO().Pesquisar(Convert.ToInt32(dr["id_medico_responsavel"]));
                    objSessao.objCliente = new ClienteDAO().Pesquisar(Convert.ToInt32(dr["id_cliente"]));
                    objSessao.objConsultorio = new ConsultorioDAO().Pesquisar(Convert.ToInt32(dr["id_consultorio"]));
                    objSessao.dataSessao = Convert.ToDateTime(dr["dataSessao"]);
                    objSessao.horaFim = Convert.ToDateTime(dr["horaFim"]);
                    objSessao.horaInicio = Convert.ToDateTime(dr["horaInicio"]);
                    objSessao.tipoDeSessao = dr["tipoDeSessao"].ToString();
                    if (objSessao.tipoDeSessao == "Tratamento")
                    {
                        objSessao.tipoDeTratamento = new TipoDeTratamento().Pesquisar(Convert.ToInt32(dr["id_tipodetratamento"]));
                        objSessao.quitada = Convert.ToBoolean(dr["sessaoQuitada"]);
                        objSessao.valorSessao = Convert.ToDecimal(dr["valorsessao"]);
                        objSessao.qtdeSessoes = Convert.ToInt32(dr["qtdesessoes"]);
                        objSessao.nroSessao = Convert.ToInt32(dr["nroSessao"]);
                    }
                    objSessao.sessaoCompleta = Convert.ToBoolean(dr["sessaocompleta"]);
                    objSessao.id = (int)dr["id"];
                    if (objSessao.sessaoCompleta == true)
                    {
                        objSessao.situacao = "Finalizada";
                    }
                    else
                    {
                        objSessao.situacao = "Agendada";
                    }
                }                
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
                    if (objSessao.tipoDeSessao == "Tratamento")
                    {
                        objSessao.tipoDeTratamento = new TipoDeTratamento().Pesquisar(Convert.ToInt32(dr["id_tipodetratamento"]));
                        objSessao.quitada = Convert.ToBoolean(dr["sessaoQuitada"]);
                        objSessao.valorSessao = Convert.ToDecimal(dr["valorsessao"]);
                        objSessao.qtdeSessoes = Convert.ToInt32(dr["qtdesessoes"]);
                        objSessao.nroSessao = Convert.ToInt32(dr["nroSessao"]);
                    }
                    objSessao.sessaoCompleta = Convert.ToBoolean(dr["sessaocompleta"]);
                    objSessao.id = (int)dr["id"];
                    if (objSessao.sessaoCompleta == true)
                    {
                        objSessao.situacao = "Finalizada";
                    }
                    else
                    {
                        objSessao.situacao = "Agendada";
                    }
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
                if (objSessao.tipoDeSessao == "Tratamento")
                {
                    objSessao.tipoDeTratamento = new TipoDeTratamento().Pesquisar(Convert.ToInt32(dr["id_tipodetratamento"]));
                    objSessao.quitada = Convert.ToBoolean(dr["sessaoQuitada"]);
                    objSessao.valorSessao = Convert.ToDecimal(dr["valorsessao"]);
                    objSessao.qtdeSessoes = Convert.ToInt32(dr["qtdesessoes"]);
                    objSessao.nroSessao = Convert.ToInt32(dr["nroSessao"]);
                }
                objSessao.sessaoCompleta = Convert.ToBoolean(dr["sessaocompleta"]);
                objSessao.id = (int)dr["id"];
                if (objSessao.sessaoCompleta == true)
                {
                    objSessao.situacao = "Finalizada";
                }
                else
                {
                    objSessao.situacao = "Agendada";
                }
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
                    if (objSessao.tipoDeSessao == "Tratamento")
                    {
                        objSessao.tipoDeTratamento = new TipoDeTratamento().Pesquisar(Convert.ToInt32(dr["id_tipodetratamento"]));
                        objSessao.quitada = Convert.ToBoolean(dr["sessaoQuitada"]);
                        objSessao.valorSessao = Convert.ToDecimal(dr["valorsessao"]);
                        objSessao.qtdeSessoes = Convert.ToInt32(dr["qtdesessoes"]);
                        objSessao.nroSessao = Convert.ToInt32(dr["nroSessao"]);
                    }
                    objSessao.sessaoCompleta = Convert.ToBoolean(dr["sessaocompleta"]);
                    objSessao.id = (int)dr["id"];
                    if (objSessao.sessaoCompleta == true)
                    {
                        objSessao.situacao = "Finalizada";
                    }
                    else
                    {
                        objSessao.situacao = "Agendada";
                    }
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
                    objSessao.sessaoCompleta = Convert.ToBoolean(dr["sessaocompleta"]);
                    objSessao.tipoDeTratamento = new TipoDeTratamento().Pesquisar(Convert.ToInt32(dr["id_tipodetratamento"]));
                    objSessao.valorSessao = Convert.ToDecimal(dr["valorsessao"]);
                    objSessao.qtdeSessoes = Convert.ToInt32(dr["qtdesessoes"]);
                    objSessao.nroSessao = Convert.ToInt32(dr["nroSessao"]);
                    objSessao.quitada = Convert.ToBoolean(dr["sessaoQuitada"]);
                    objSessao.id = (int)dr["id"];
                    if (objSessao.sessaoCompleta == true)
                    {
                        objSessao.situacao = "Finalizada";
                    }
                    else
                    {
                        objSessao.situacao = "Agendada";
                    }
                    listaDeSessoes.Add(objSessao);
                }   
            }
            else
            {
                listaDeSessoes = null;
            }
            return listaDeSessoes;
        }
        public void CompletarSessao(Sessoes objSessao)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE sessoes SET sessaoCompleta = @sesscom where id = @id";
            comando.Parameters.AddWithValue("@sesscom", Convert.ToInt32(objSessao.sessaoCompleta));
            comando.Parameters.AddWithValue("@id", objSessao.id);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }
        public void AlterarSessao(Sessoes objSessao)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE sessoes SET id_cliente=@idcli, dataSessao=@data, id_medico_responsavel=@idmedico, id_consultorio=@idconsultorio, horaInicio=@horainicio, horaFim=@horafim where id=@id";
            comando.Parameters.AddWithValue("@idcli", objSessao.objCliente.id);
            comando.Parameters.AddWithValue("@data",objSessao.dataSessao);
            comando.Parameters.AddWithValue("@idmedico",objSessao.medicoResponsavel.id);
            comando.Parameters.AddWithValue("@idconsultorio",objSessao.objConsultorio.id);
            comando.Parameters.AddWithValue("@horainicio",objSessao.horaInicio);
            comando.Parameters.AddWithValue("@horafim",objSessao.horaFim);
            comando.Parameters.AddWithValue("@id", objSessao.id);
            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }
        public void Deletar(Sessoes objSessao)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM Sessoes where id=@id";
            comando.Parameters.AddWithValue("@id", objSessao.id);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);
        }
    }
}
