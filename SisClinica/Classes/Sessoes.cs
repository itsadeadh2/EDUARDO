using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SisClinica.DAO;

namespace SisClinica.Classes
{
    public class Sessoes
    {
        //-Propriedades
        public Medico medicoResponsavel { get; set; }
        public Cliente objCliente { get; set; }
        public Consultorio objConsultorio { get; set; }
        public DateTime dataSessao { get; set; }
        public DateTime horaInicio  { get; set; }
        public DateTime horaFim { get; set; }
        public string tipoDeSessao { get; set; }
        public int qtdeSessoes { get; set; }
        public int id { get; set; }

        //-Propriedades que planejo utilizar no futuro para configurar os horarios.
            //public static DateTime horaEntrada { get; set; }
            //public static DateTime horaAlmoco { get; set; }
            //public static DateTime horarioReentrada { get; set; }
            //public static DateTime fimExpediente { get; set; }

        /// <summary>
        /// Altera a data da Sessão
        /// </summary>
        /// <param name="novaData">nova data</param>
        public void AlterarData(DateTime novaData)
        {
            
        }
        public void AlterarMedico(Medico novoMedico)
        {

        }
        public void RegistrarSessao()
        {
             new SessoesDAO().Registrar(this);
        }

        /// <summary>
        /// Retorna uma sessao que tenha o médico, data e consultorios passados como parametros
        /// </summary>
        /// <param name="data">Data</param>
        /// <param name="objMedico">Medico Responsavel</param>
        /// <param name="objConsultorio">Consultorio</param>
        /// <returns></returns>
        public Sessoes BuscaPorData(DateTime data, Medico objMedico, Consultorio objConsultorio)
        {
            return new SessoesDAO().Pesquisar(data, objMedico, objConsultorio);
        }

        /// <summary>
        /// Pesquisa uma sessão com a data informada.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IList<Sessoes> BuscaPorData(DateTime data)
        {
            return new SessoesDAO().PesquisarPorData(data.Date);
        }

        public IList<Sessoes> BuscaPorHoraInicial(DateTime data)
        {
            return new SessoesDAO().PesquisarPorHorarioInicial(data);
        }

        public IList<Sessoes> BuscaPorCliente(Cliente objCliente)
        {
            return new SessoesDAO().Pesquisar(objCliente);
        }

        public DataTable BuscaPorClienteMedicoData(string nome,tdp tipoDePesquisa, DateTime data, tdr tipoDeRetorno)
        {
            IList<Sessoes> listaPorData = new Sessoes().BuscaPorData(data);
            IList<Cliente> listaDeClientes = new Cliente().iListPesquisarPorNome(nome);
            IList<Medico> listaDeMedicos = new Medico().iListPesquisar(nome);
            IList<Sessoes> listaDeSessoes = new List<Sessoes>();
            #region
            if (listaDeClientes!=null)
            {
                foreach (Cliente objCliente in listaDeClientes)
                {
                    IList<Sessoes> lista = new Sessoes().BuscaPorCliente(objCliente);
                    if (lista!=null)
                    {
                        foreach (Sessoes objSessoes in lista)
                        {
                            listaDeSessoes.Add(objSessoes);
                        }
                    }                    
                }
            }
            if (listaDeMedicos!=null)
            {
                foreach (Medico objMedico in listaDeMedicos)
                {
                    IList<Sessoes> lista = new Sessoes().BuscaPorMedico(objMedico);
                    if (lista!=null)
                    {
                        foreach (Sessoes objSessoes in lista)
                        {
                            if (listaDeSessoes.Count!=0)
                            {
                                foreach (Sessoes s in listaDeSessoes)
                                {
                                    if (objSessoes.id != s.id)
                                    {
                                        listaDeSessoes.Add(objSessoes);
                                    }
                                }
                            }
                            else
                            {
                                listaDeSessoes.Add(objSessoes);
                            }                            
                        }
                    }
                    
                }
            }
            if (listaPorData!=null)
            {
                foreach (Sessoes s in listaPorData)
                {
                    if (listaDeSessoes.Count != 0)
                    {
                        foreach (Sessoes ss in listaDeSessoes)
                        {
                            if (s.id != ss.id)
                            {
                                listaDeSessoes.Add(s);
                            }
                        }
                    }
                    else
                    {
                        listaDeSessoes.Add(s);
                    }
                }
            }
            
            #endregion
            //A partir daqui ListaDeSessoes é uma lista generalizada
            IList<Sessoes> listaDefinitiva = new List<Sessoes>();            
            if (tipoDePesquisa==tdp.cliente)
            {
                foreach (Sessoes s in listaDeSessoes)
                {
                    if (s.objCliente.nome.ToUpper().Contains(nome.ToUpper()))
                    {
                        listaDefinitiva.Add(s);
                    }
                }
            }
            else if (tipoDePesquisa==tdp.clienteData)
            {
                foreach (Sessoes s in listaDeSessoes)
                {
                    if (s.objCliente.nome.ToUpper().Contains(nome.ToUpper())&&s.dataSessao==data.Date)
                    {
                        listaDefinitiva.Add(s);
                    }
                }
            }
            else if (tipoDePesquisa == tdp.clienteEMedico)
            {
                foreach (Sessoes s in listaDeSessoes)
                {
                    if (s.objCliente.nome.ToUpper().Contains(nome.ToUpper()) || s.medicoResponsavel.nome.ToUpper().Contains(nome.ToUpper()))
                    {
                        listaDefinitiva.Add(s);
                    }
                }
            }
            else if (tipoDePesquisa==tdp.clienteMedicoEData)
            {
                foreach (Sessoes s in listaDeSessoes)
                {
                    if (s.objCliente.nome.ToUpper().Contains(nome.ToUpper()) || s.medicoResponsavel.nome.ToUpper().Contains(nome.ToUpper()) && (s.dataSessao==data.Date))
                    {
                        listaDefinitiva.Add(s);
                    }
                }
            }
            else if (tipoDePesquisa==tdp.data)
            {
                foreach (Sessoes s in listaDeSessoes)
                {
                    if (s.dataSessao==data.Date)
                    {
                        listaDefinitiva.Add(s);
                    }
                }
            }
            else if (tipoDePesquisa==tdp.medico)
            {
                foreach (Sessoes s in listaDeSessoes)
                {
                    if (s.medicoResponsavel.nome.ToUpper().Contains(nome.ToUpper()))
                    {
                        listaDefinitiva.Add(s);
                    }
                }
            }
            else if (tipoDePesquisa==tdp.medicoData)
            {
                foreach (Sessoes s in listaDeSessoes)
                {
                    if (s.medicoResponsavel.nome.ToUpper().Contains(nome.ToUpper()) && s.dataSessao==data.Date)
                    {
                        listaDefinitiva.Add(s);
                    }
                }
            }
            IList<Sessoes> lst = new List<Sessoes>();
            if (tipoDeRetorno==tdr.consulta)
            {
                foreach (Sessoes s in listaDefinitiva)
                {
                    if (s.tipoDeSessao=="Consulta")
                    {
                        lst.Add(s);
                    }
                }
            }
            else if (tipoDeRetorno==tdr.tratamento)
            {
                foreach (Sessoes s in listaDefinitiva)
                {
                    if (s.tipoDeSessao == "Tratamento")
                    {
                        lst.Add(s);
                    }
                }
            }
            else
            {
                foreach (Sessoes s in listaDefinitiva)
                {
                    lst.Add(s);
                }
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Médico Responsável", typeof(string));
            dt.Columns.Add("Tipo de sessão", typeof(string));
            dt.Columns.Add("Data da Sessão", typeof(DateTime));
            dt.Columns.Add("Horario de início", typeof(TimeSpan));
            dt.Columns.Add("Horario de término", typeof(TimeSpan));

            foreach (Sessoes objSessoes in lst)
            {
                dt.Rows.Add(objSessoes.objCliente.nome, objSessoes.medicoResponsavel.nome, objSessoes.tipoDeSessao, objSessoes.dataSessao, objSessoes.horaInicio.TimeOfDay, objSessoes.horaFim.TimeOfDay);
            }
            return dt;
        }

        /// <summary>
        /// Retorna uma lista de sessoes com um determinado medico
        /// </summary>
        /// <param name="objMedicoDaBusca">determinado medico</param>
        /// <returns></returns>
        public IList<Sessoes> BuscaPorMedico(Medico objMedicoDaBusca)
        {
            return new SessoesDAO().Pesquisar(objMedicoDaBusca);
        }

        /// <summary>
        /// Retorna uma lista de sessoes em um determinado consultório
        /// </summary>
        /// <param name="objConsultorio">determinado consultório</param>
        /// <returns></returns>
        public IList<Sessoes> BuscaPorConsultorio(Consultorio objConsultorio)
        {
            return new SessoesDAO().Pesquisar(objConsultorio);
        }

        /// <summary>
        /// Gera um DataTable com os horarios disponíveis para a data selecionada
        /// </summary>
        /// <param name="data">data a ser pesquisada</param>
        /// <param name="objMedico">Medico em vigencia</param>
        /// <param name="objConsultorio">Consultorio da sessao</param>
        /// <param name="datasource">DataSource que receberá o dataTable</param>
        /// <returns>DataTable de horarios disponiveis</returns>
        public DataTable GerarListaDeHorarios(DateTime data, Medico objMedico, Consultorio objConsultorio, DateTime datasource)
        {            
            DateTime hi = data.Date;
            DateTime ha = data.Date;
            DateTime hr = data.Date;
            DateTime fe = data.Date;
            hi = hi.AddHours(8);
            ha = ha.AddHours(11);
            ha = ha.AddMinutes(30);
            hr = hr.AddHours(14);
            fe = fe.AddHours(18);
            IList<DateTime> listaDeHorarios = new Sessoes().GerarHorarios(hi, ha, hr, fe, data.Date, objMedico, objConsultorio);

            DataTable dt = new DataTable();
            if (datasource == null)
            {
                dt.Columns.Add("Data", typeof(DateTime));
                dt.Columns.Add("Hora", typeof(string));
                foreach (DateTime hora in listaDeHorarios)
                {
                    dt.Rows.Add(hora, hora.TimeOfDay.ToString());
                }
            }
            else if (datasource != null)
            {
                dt.Columns.Add("Data", typeof(DateTime));
                dt.Columns.Add("Hora", typeof(string));
                foreach (DateTime hora in listaDeHorarios)
                {
                    if (hora > datasource)
                    {
                        dt.Rows.Add(hora, hora.TimeOfDay.ToString());
                    }
                }
            }

            return dt;
        }

        /// <summary>
        /// Implementa o algoritmo para geração dos horários disponíveis.
        /// </summary>
        /// <param name="horarioInicial">Horario de entrada no expediente</param>
        /// <param name="horarioDeAlmoco">Horario de saída para o almoço</param>
        /// <param name="horarioDeReentrada">Horário de re-entrada</param>
        /// <param name="fimDoExpediente">Hora de término do expediente</param>
        /// <param name="data">Data do expediente</param>
        /// <param name="objMedico">Medico que será responsavel</param>
        /// <param name="objConsultorio">Consultorio onde será feita a sessão</param>
        /// <returns>lista de horarios disponiveis</returns>
        public IList<DateTime> GerarHorarios(DateTime horarioInicial, DateTime horarioDeAlmoco, DateTime horarioDeReentrada, DateTime fimDoExpediente, DateTime data, Medico objMedico, Consultorio objConsultorio)
        {
            IList<DateTime> listaDeHorarios = new List<DateTime>();
            IList<DateTime> horariosRetornar = new List<DateTime>();
            DateTime dataComparacao = data.Date;
            for (int i = 0; i < 46; i++)
            {
                dataComparacao = dataComparacao.AddMinutes(30);
                if (dataComparacao <= fimDoExpediente && dataComparacao >= horarioDeReentrada)
                {
                    listaDeHorarios.Add(dataComparacao);
                }
                else if (dataComparacao <= horarioDeAlmoco && dataComparacao >= horarioInicial)
                {
                    listaDeHorarios.Add(dataComparacao);
                }
            }
            DateTime horaFim = data.Date;
            foreach (DateTime dt in listaDeHorarios)
            {

                Sessoes objSessaoComparar = new Sessoes().BuscaPorData(dt,objMedico, objConsultorio);
                if (objSessaoComparar==null)
                {
                    if (dt>horaFim)
                    {
                        horariosRetornar.Add(dt);
                    }
                }
                else if (objSessaoComparar.horaFim<=dt)
                {
                    horariosRetornar.Add(dt);
                    horaFim = objSessaoComparar.horaFim;
                }
                else if (objSessaoComparar!=null)
                {
                    horaFim = objSessaoComparar.horaFim;
                }
            }
            return horariosRetornar;
        }

        public void Excluir()
        {

        }
    }
}
