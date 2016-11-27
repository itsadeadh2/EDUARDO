using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SisClinica.DAO;
using SisClinica.Forms;

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
        public TipoDeTratamento tipoDeTratamento { get; set; }
        public Sessoes tratamentoPosterior { get; set; }
        public string situacao { get; set; }
        public int nroSessao { get; set; }
        public int qtdeSessoes { get; set; }
        public decimal valorSessao { get; set; }    
        public bool quitada { get; set; }
        public bool sessaoCompleta { get; set; }
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
        public void AdicionarTratamentoPosterior()
        {
            new SessoesDAO().AdicionarTratamentoPosterior(this);
        }
        public int RegistrarSessaoPosterior()
        {
            return new SessoesDAO().RegistraTratamentoPosterior(this);
        }
        public void RegistrarSessao()
        {
            if (this.tipoDeSessao=="Tratamento")
            {
                new SessoesDAO().RegistrarTratamento(this);
            }
            else
            {
                new SessoesDAO().RegistrarConsulta(this);
            }
             
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
        public DataTable DataTableBuscaPorData(DateTime data)
        {
            IList<Sessoes> lst = new Sessoes().BuscaPorData(data.Date);
            DataTable dt = new DataTable();
            dt.Columns.Add("Tipo de Sessao", typeof(string));
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("CPF Cliente", typeof(string));
            dt.Columns.Add("Médico", typeof(string));
            dt.Columns.Add("Data", typeof(DateTime));
            dt.Columns.Add("Hora de início", typeof(TimeSpan));
            dt.Columns.Add("Hora de fim", typeof(TimeSpan));
            dt.Columns.Add("Andamento", typeof(string));
            dt.Columns.Add("id", typeof(int));
            if (lst!=null)
            {
                foreach (Sessoes objSessao in lst)
                {
                    if (objSessao.sessaoCompleta==false)
                    {
                        if (objSessao.tipoDeSessao!="Tratamento")
                        {
                            dt.Rows.Add(objSessao.tipoDeSessao, objSessao.objCliente.nome, objSessao.objCliente.cpf, objSessao.medicoResponsavel.nome, objSessao.dataSessao, objSessao.horaInicio.TimeOfDay, objSessao.horaFim.TimeOfDay,"-", objSessao.id);
                        }
                        else
                        {
                            dt.Rows.Add(objSessao.tipoDeSessao, objSessao.objCliente.nome, objSessao.objCliente.cpf, objSessao.medicoResponsavel.nome, objSessao.dataSessao, objSessao.horaInicio.TimeOfDay, objSessao.horaFim.TimeOfDay, objSessao.nroSessao + "/" + objSessao.qtdeSessoes, objSessao.id);
                        }
                    }                    
                }
            }
            return dt;
        }

        public Sessoes BuscaPorData(DateTime data, Medico objMedico, Consultorio objConsultorio, Sessoes sessaoAIgnorar)
        {
            return new SessoesDAO().Pesquisar(data, objMedico, objConsultorio, sessaoAIgnorar);
        }

        public Sessoes BuscaPorId(int id)
        {
        
            return new SessoesDAO().Pesquisar(id);
            
   
      
        }

        public IList<Sessoes> BuscaPorHoraInicial(DateTime data)
        {
            return new SessoesDAO().PesquisarPorHorarioInicial(data);
        }

        public DataTable DataTableBuscaPorMedico(Medico objMedico)
        {
            IList<Sessoes> lst = new SessoesDAO().Pesquisar(objMedico);
            DataTable dt = new DataTable();
            dt.Columns.Add("Médico Responsável", typeof(string));
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Tipo de sessão", typeof(string));
            dt.Columns.Add("Data da Sessão", typeof(DateTime));
            dt.Columns.Add("Horario de início", typeof(TimeSpan));
            dt.Columns.Add("Horario de término", typeof(TimeSpan));
            dt.Columns.Add("Situação", typeof(string));
            dt.Columns.Add("id", typeof(int));

            if (lst != null)
            {
                foreach (Sessoes objSessoes in lst)
                {
                    dt.Rows.Add(objSessoes.medicoResponsavel.nome, objSessoes.objCliente.nome, objSessoes.tipoDeSessao, objSessoes.dataSessao, objSessoes.horaInicio.TimeOfDay, objSessoes.horaFim.TimeOfDay, objSessoes.situacao, objSessoes.id);
                }
            }
            return dt;
        }
        public DataTable DataTableBuscaPorCliente(Cliente objCliente)
        {
            IList<Sessoes> lst = new SessoesDAO().Pesquisar(objCliente);
            DataTable dt = new DataTable();
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Médico Responsável", typeof(string));
            dt.Columns.Add("Tipo de sessão", typeof(string));
            dt.Columns.Add("Data da Sessão", typeof(DateTime));
            dt.Columns.Add("Horario de início", typeof(TimeSpan));
            dt.Columns.Add("Horario de término", typeof(TimeSpan));
            dt.Columns.Add("Situação", typeof(string));
            dt.Columns.Add("id", typeof(int));

            if (lst!=null)
            {
                foreach (Sessoes objSessoes in lst)
                {
                    dt.Rows.Add(objSessoes.objCliente.nome, objSessoes.medicoResponsavel.nome, objSessoes.tipoDeSessao, objSessoes.dataSessao, objSessoes.horaInicio.TimeOfDay, objSessoes.horaFim.TimeOfDay, objSessoes.situacao, objSessoes.id);
                }                
            }
            return dt;
        }
        public IList<Sessoes> BuscaPorCliente(Cliente objCliente)
        {
            return new SessoesDAO().Pesquisar(objCliente);
        }

        public DataTable BuscaPorClienteMedicoData(string nome,tdp tipoDePesquisa, DateTime data, tdr tipoDeRetorno, bool sessaoCompleta)
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
                            if (true)
                            {

                            }
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
                        IList<int> idsListaSessoes = new List<int>();
                        IList<int> idsLista = new List<int>();

                        foreach (Sessoes objs in listaDeSessoes)
                        {
                            idsListaSessoes.Add(objs.id);
                        }
                        foreach(Sessoes objs in lista)
                        {
                            idsLista.Add(objs.id);
                        }
                        foreach (int id in idsLista)
                        {
                            if (idsListaSessoes.Contains(id))
                            {

                            }
                            else
                            {
                                listaDeSessoes.Add(new Sessoes().BuscaPorId(id));
                            }
                        }
                    }
                    
                }
            }
            if (listaPorData!=null)
            {
                IList<int> idSessoes = new List<int>();
                IList<int> idSessoesPorData = new List<int>();
                foreach (Sessoes s in listaPorData)
                {
                    idSessoesPorData.Add(s.id);
                }
                foreach (Sessoes s in listaDeSessoes)
                {
                    idSessoes.Add(s.id);
                }

                foreach (int id in idSessoes)
                {
                    if (idSessoes.Contains(id))
                    {

                    }
                    else
                    {
                        listaDeSessoes.Add(new Sessoes().BuscaPorId(id));
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
            dt.Columns.Add("Situação", typeof(string));
            dt.Columns.Add("Andamento", typeof(string));
            dt.Columns.Add("id", typeof(int));
            if (lst.Count != 0)
            {
                foreach (Sessoes objSessoes in lst)
                {
                    if (sessaoCompleta)
                    {
                        if (objSessoes.sessaoCompleta)
                        {
                            if (objSessoes.tipoDeSessao != "Tratamento")
                            {
                                dt.Rows.Add(objSessoes.objCliente.nome, objSessoes.medicoResponsavel.nome, objSessoes.tipoDeSessao, objSessoes.dataSessao, objSessoes.horaInicio.TimeOfDay, objSessoes.horaFim.TimeOfDay, objSessoes.situacao, "-", objSessoes.id);
                            }
                            else
                            {
                                dt.Rows.Add(objSessoes.objCliente.nome, objSessoes.medicoResponsavel.nome, objSessoes.tipoDeSessao, objSessoes.dataSessao, objSessoes.horaInicio.TimeOfDay, objSessoes.horaFim.TimeOfDay, objSessoes.situacao, objSessoes.nroSessao + "/" + objSessoes.qtdeSessoes, objSessoes.id);
                            }

                        }
                    }
                    else
                    {
                        if (!objSessoes.sessaoCompleta)
                        {
                            if (objSessoes.tipoDeSessao != "Tratamento")
                            {
                                dt.Rows.Add(objSessoes.objCliente.nome, objSessoes.medicoResponsavel.nome, objSessoes.tipoDeSessao, objSessoes.dataSessao, objSessoes.horaInicio.TimeOfDay, objSessoes.horaFim.TimeOfDay, objSessoes.situacao, "-", objSessoes.id);
                            }
                            else
                            {
                                dt.Rows.Add(objSessoes.objCliente.nome, objSessoes.medicoResponsavel.nome, objSessoes.tipoDeSessao, objSessoes.dataSessao, objSessoes.horaInicio.TimeOfDay, objSessoes.horaFim.TimeOfDay, objSessoes.situacao, objSessoes.nroSessao + "/" + objSessoes.qtdeSessoes, objSessoes.id);
                            }
                        }

                    }

                }

            }
            else
            {
                dt = null;
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
        public DataTable GerarListaDeHorariosIniciais(DateTime data, Medico objMedico, Consultorio objConsultorio, string turno)
        {            
            DateTime hi = data.Date;
            DateTime ha = data.Date;
            DateTime hr = data.Date;
            DateTime fe = data.Date;
            //hi = Convert.ToDateTime("08:00");
            //ha = Convert.ToDateTime("11:30");
            //hr = Convert.ToDateTime("14:00");
            //fe = Convert.ToDateTime("18:00");
            hi = hi.AddHours(8);
            ha = ha.AddHours(11);
            ha = ha.AddMinutes(30);
            hr = hr.AddHours(14);
            fe = fe.AddHours(18);
            IList<DateTime> listaDeHorarios = new Sessoes().GerarHorariosDeInicio(hi, ha, hr, fe, data.Date, objMedico, objConsultorio, turno);

            DataTable dt = new DataTable();
           
            dt.Columns.Add("Data", typeof(DateTime));
            dt.Columns.Add("Hora", typeof(string));
            foreach (DateTime hora in listaDeHorarios)
            {
                if (hora.Date==DateTime.Now.Date)
                {
                    if (HelperFunctions.ChecaHorarioSessao(hora.TimeOfDay)!=true)
                    {
                        if (turno == "Manhã")
                        {
                            if (hora == ha)
                            {

                            }
                            else
                            {
                                dt.Rows.Add(hora, hora.TimeOfDay.ToString());
                            }
                        }
                        else
                        {
                            if (hora == fe)
                            {

                            }
                            else
                            {
                                dt.Rows.Add(hora, hora.TimeOfDay.ToString());
                            }
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (turno == "Manhã")
                    {
                        if (hora == ha)
                        {

                        }
                        else
                        {
                            dt.Rows.Add(hora, hora.TimeOfDay.ToString());
                        }
                    }
                    else
                    {
                        if (hora == fe)
                        {

                        }
                        else
                        {
                            dt.Rows.Add(hora, hora.TimeOfDay.ToString());
                        }
                    }
                }        
            }
            return dt;
        }
        public DataTable GerarListaDeHorariosFinais(Medico objMedico, Consultorio objConsultorio, DateTime horarioInicialSelecionado, string turno)
        {
            DateTime ha = horarioInicialSelecionado.Date;
            DateTime hr = horarioInicialSelecionado.Date;
            DateTime fe = horarioInicialSelecionado.Date;
            //hi = Convert.ToDateTime("08:00");
            ha = Convert.ToDateTime("11:30");
            hr = Convert.ToDateTime("14:00");
            fe = Convert.ToDateTime("18:00");

            //ha = ha.AddHours(11);
            //ha = ha.AddMinutes(30);
            //hr = hr.AddHours(14);
            //fe = fe.AddHours(18);
            IList<DateTime> listaDeHorarios = new Sessoes().GerarHorariosDeTermino(horarioInicialSelecionado, ha, hr, fe, objMedico, objConsultorio, turno);

            DataTable dt = new DataTable();
            dt.Columns.Add("Data", typeof(DateTime));
            dt.Columns.Add("Hora", typeof(string));
            foreach (DateTime hora in listaDeHorarios)
            {
                dt.Rows.Add(hora, hora.TimeOfDay.ToString());
            }
            
            return dt;
        }

        public DataTable GerarListaDeHorariosIniciais(DateTime data, Medico objMedico, Consultorio objConsultorio, string turno, Sessoes sessaoAIgnorar)
        {
            DateTime hi = data.Date;
            DateTime ha = data.Date;
            DateTime hr = data.Date;
            DateTime fe = data.Date;
            //hi = Convert.ToDateTime("08:00");
            //ha = Convert.ToDateTime("11:30");
            //hr = Convert.ToDateTime("14:00");
            //fe = Convert.ToDateTime("18:00");
            hi = hi.AddHours(8);
            ha = ha.AddHours(11);
            ha = ha.AddMinutes(30);
            hr = hr.AddHours(14);
            fe = fe.AddHours(18);
            IList<DateTime> listaDeHorarios = new Sessoes().GerarHorariosDeInicio(hi, ha, hr, fe, data.Date, objMedico, objConsultorio, turno, sessaoAIgnorar);

            DataTable dt = new DataTable();

            dt.Columns.Add("Data", typeof(DateTime));
            dt.Columns.Add("Hora", typeof(string));
            foreach (DateTime hora in listaDeHorarios)
            {
                if (hora.Date == DateTime.Now.Date)
                {
                    if (HelperFunctions.ChecaHorarioSessao(hora.TimeOfDay) != true)
                    {
                        if (turno == "Manhã")
                        {
                            if (hora == ha)
                            {

                            }
                            else
                            {
                                dt.Rows.Add(hora, hora.TimeOfDay.ToString());
                            }
                        }
                        else
                        {
                            if (hora == fe)
                            {

                            }
                            else
                            {
                                dt.Rows.Add(hora, hora.TimeOfDay.ToString());
                            }
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (turno == "Manhã")
                    {
                        if (hora == ha)
                        {

                        }
                        else
                        {
                            dt.Rows.Add(hora, hora.TimeOfDay.ToString());
                        }
                    }
                    else
                    {
                        if (hora == fe)
                        {

                        }
                        else
                        {
                            dt.Rows.Add(hora, hora.TimeOfDay.ToString());
                        }
                    }
                }
            }
            return dt;
        }
        public DataTable GerarListaDeHorariosFinais(Medico objMedico, Consultorio objConsultorio, DateTime horarioInicialSelecionado, string turno, Sessoes sessaoAIgnorar)
        {
            DateTime ha = horarioInicialSelecionado.Date;
            DateTime hr = horarioInicialSelecionado.Date;
            DateTime fe = horarioInicialSelecionado.Date;
            //hi = Convert.ToDateTime("08:00");
            ha = Convert.ToDateTime("11:30");
            hr = Convert.ToDateTime("14:00");
            fe = Convert.ToDateTime("18:00");

            //ha = ha.AddHours(11);
            //ha = ha.AddMinutes(30);
            //hr = hr.AddHours(14);
            //fe = fe.AddHours(18);
            IList<DateTime> listaDeHorarios = new Sessoes().GerarHorariosDeTermino(horarioInicialSelecionado, ha, hr, fe, objMedico, objConsultorio, turno,sessaoAIgnorar);

            DataTable dt = new DataTable();
            dt.Columns.Add("Data", typeof(DateTime));
            dt.Columns.Add("Hora", typeof(string));
            foreach (DateTime hora in listaDeHorarios)
            {
                dt.Rows.Add(hora, hora.TimeOfDay.ToString());
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
        private IList<DateTime> GerarHorariosDeInicio(DateTime horarioInicial, DateTime horarioDeAlmoco, DateTime horarioDeReentrada, DateTime fimDoExpediente, DateTime data, Medico objMedico, Consultorio objConsultorio, string turno)
        {
            IList<DateTime> listaDeHorarios = new List<DateTime>();
            IList<DateTime> horariosRetornar = new List<DateTime>();
            DateTime dataComparacao = data.Date;
            int limite = 23;
            if (turno=="Tarde")
            {
                dataComparacao = horarioDeReentrada.Subtract(Convert.ToDateTime("00:30").TimeOfDay);
            }
            for (int i = 0; i < limite; i++)
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
                    if (dt>=horaFim)
                    {
                        horariosRetornar.Add(dt);
                    }
                }
                else if (objSessaoComparar.horaInicio>dt)
                {
                    horariosRetornar.Add(dt);
                    horaFim = objSessaoComparar.horaFim;
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
        private IList<DateTime> GerarHorariosDeTermino(DateTime horarioInicial, DateTime horarioDeAlmoco, DateTime horarioDeReentrada, DateTime fimDoExpediente, Medico objMedico, Consultorio objConsultorio, string turno)
        {
            IList<DateTime> listaDeHorarios = new List<DateTime>();
            IList<DateTime> horariosRetornar = new List<DateTime>();
            DateTime dataComparacao = horarioInicial;
            int limite = 23;
            if (turno != "Tarde")
            {
                fimDoExpediente = horarioDeAlmoco;
            }
            for (int i = 0; i < limite; i++)
            {
                dataComparacao = dataComparacao.AddMinutes(30);
                if (dataComparacao.TimeOfDay <= fimDoExpediente.TimeOfDay && dataComparacao.TimeOfDay >= horarioDeReentrada.TimeOfDay)
                {
                    listaDeHorarios.Add(dataComparacao);
                }
                else if (dataComparacao.TimeOfDay <= horarioDeAlmoco.TimeOfDay && dataComparacao.TimeOfDay >= horarioInicial.TimeOfDay)
                {
                    listaDeHorarios.Add(dataComparacao);
                }
            }
            DateTime horaFim = horarioInicial.Date;
            bool stopAdding = false;
            foreach (DateTime dt in listaDeHorarios)
            {
                Sessoes objSessaoComparar = new Sessoes().BuscaPorData(dt, objMedico, objConsultorio);
                if (objSessaoComparar == null && stopAdding==false)
                {
                    if (dt >= horaFim)
                    {
                        horariosRetornar.Add(dt);
                    }
                }
                else if (objSessaoComparar!=null)
                {
                    if (dt <= objSessaoComparar.horaInicio)
                    {
                        horariosRetornar.Add(dt);
                        stopAdding = true;
                    }
                }
            }
            return horariosRetornar;
        }

        private IList<DateTime> GerarHorariosDeInicio(DateTime horarioInicial, DateTime horarioDeAlmoco, DateTime horarioDeReentrada, DateTime fimDoExpediente, DateTime data, Medico objMedico, Consultorio objConsultorio, string turno, Sessoes sessaoAIgnorar)
        {
            IList<DateTime> listaDeHorarios = new List<DateTime>();
            IList<DateTime> horariosRetornar = new List<DateTime>();
            DateTime dataComparacao = data.Date;
            int limite = 23;
            if (turno == "Tarde")
            {
                dataComparacao = horarioDeReentrada.Subtract(Convert.ToDateTime("00:30").TimeOfDay);
            }
            for (int i = 0; i < limite; i++)
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

                Sessoes objSessaoComparar = new Sessoes().BuscaPorData(dt, objMedico, objConsultorio, sessaoAIgnorar);
                if (objSessaoComparar == null)
                {
                    if (dt >= horaFim)
                    {
                        horariosRetornar.Add(dt);
                    }
                }
                else if (objSessaoComparar.horaInicio > dt)
                {
                    horariosRetornar.Add(dt);
                    horaFim = objSessaoComparar.horaFim;
                }
                else if (objSessaoComparar.horaFim <= dt)
                {
                    horariosRetornar.Add(dt);
                    horaFim = objSessaoComparar.horaFim;
                }
                else if (objSessaoComparar != null)
                {
                    horaFim = objSessaoComparar.horaFim;
                }
            }
            return horariosRetornar;
        }
        private IList<DateTime> GerarHorariosDeTermino(DateTime horarioInicial, DateTime horarioDeAlmoco, DateTime horarioDeReentrada, DateTime fimDoExpediente, Medico objMedico, Consultorio objConsultorio, string turno, Sessoes sessaoAIgnorar)
        {
            IList<DateTime> listaDeHorarios = new List<DateTime>();
            IList<DateTime> horariosRetornar = new List<DateTime>();
            DateTime dataComparacao = horarioInicial;
            int limite = 23;
            if (turno != "Tarde")
            {
                fimDoExpediente = horarioDeAlmoco;
            }
            for (int i = 0; i < limite; i++)
            {
                dataComparacao = dataComparacao.AddMinutes(30);
                if (dataComparacao.TimeOfDay <= fimDoExpediente.TimeOfDay && dataComparacao.TimeOfDay >= horarioDeReentrada.TimeOfDay)
                {
                    listaDeHorarios.Add(dataComparacao);
                }
                else if (dataComparacao.TimeOfDay <= horarioDeAlmoco.TimeOfDay && dataComparacao.TimeOfDay >= horarioInicial.TimeOfDay)
                {
                    listaDeHorarios.Add(dataComparacao);
                }
            }
            DateTime horaFim = horarioInicial.Date;
            bool stopAdding = false;
            foreach (DateTime dt in listaDeHorarios)
            {
                Sessoes objSessaoComparar = new Sessoes().BuscaPorData(dt, objMedico, objConsultorio,sessaoAIgnorar);
                if (objSessaoComparar == null && stopAdding == false)
                {
                    if (dt >= horaFim)
                    {
                        horariosRetornar.Add(dt);
                    }
                }
                else if (objSessaoComparar != null)
                {
                    if (dt <= objSessaoComparar.horaInicio)
                    {
                        horariosRetornar.Add(dt);
                        stopAdding = true;
                    }
                }
            }
            return horariosRetornar;
        }

        public void AlterarSessao()
        {
            new SessoesDAO().AlterarSessao(this);
         
        }
        public void CompletarSessao()
        {
            new SessoesDAO().CompletarSessao(this);
        }

        public void Excluir()
        {
            new SessoesDAO().Deletar(this);
        }
        
    }
}
