﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SisClinica.Classes;

namespace SisClinica.DAO
{
    public class ConsultorioDAO
    {
        public Consultorio Pesquisar(int id)
        {
            Consultorio objConsultorio = new Consultorio();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM consultorio WHERE id=@id";
            comando.Parameters.AddWithValue("@id", id);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                dr.Read();
                objConsultorio.nomeConsultorio = dr["nome"].ToString();
                objConsultorio.id = Convert.ToInt32(dr["id"]);
            }
            else
            {
                objConsultorio = null;
            }
            return objConsultorio;
        }
        public Consultorio PesquisarPorNome(string nome)
        {
            Consultorio objConsultorio = new Consultorio();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM consultorio Where nome=@nome";
            comando.Parameters.AddWithValue("@nome", nome);

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);
            if (dr.HasRows)
            {
                dr.Read();
                objConsultorio.nomeConsultorio = dr["nome"].ToString();
                objConsultorio.id = Convert.ToInt32(dr["id"]);
            }
            else
            {
                objConsultorio = null;
            }
            return objConsultorio;
        }
        public IList<Consultorio> Pesquisar(string nome)
        {
            IList<Consultorio> listaDeConsultorios = new List<Consultorio>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Consultorio where nome like @nome";
            comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Consultorio objConsultorio = new Consultorio();
                    objConsultorio.id = Convert.ToInt32(dr["id"]);
                    objConsultorio.nomeConsultorio = dr["nome"].ToString();
                    listaDeConsultorios.Add(objConsultorio);
                }
            }
            else
            {
                listaDeConsultorios = null;
            }
            return listaDeConsultorios;
        }
        public IList<Consultorio> Pesquisar()
        {
            IList<Consultorio> listaDeConsultorios = new List<Consultorio>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Consultorio";

            Conexao con = new Conexao();
            SqlDataReader dr = con.ExecutarSelect(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Consultorio objConsultorio = new Consultorio();
                    objConsultorio.id = Convert.ToInt32(dr["id"]);
                    objConsultorio.nomeConsultorio = dr["nome"].ToString();
                    listaDeConsultorios.Add(objConsultorio);
                }
            }
            else
            {
                listaDeConsultorios = null;
            }
            return listaDeConsultorios;
        }

        public void Registrar(Consultorio objConsultorio)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Consultorio(nome) values(@nome)";
            comando.Parameters.AddWithValue("@nome",objConsultorio.nomeConsultorio);

            Conexao con = new Conexao();
            con.ExecutarCru(comando);

        }
    }
}
