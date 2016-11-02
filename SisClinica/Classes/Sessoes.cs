using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SisClinica.DAO;

namespace SisClinica.Classes
{
    class Sessoes
    {
        public Medico medicoResponsavel { get; set; }
        public Cliente objCliente { get; set; }
        public Consultorio objConsultorio { get; set; }
        public DateTime dataSessao { get; set; }
        public DateTime horaInicio  { get; set; }
        public DateTime horaFim { get; set; }
        public string tipoDeSessao { get; set; }
        public int qtdeSessoes { get; set; }

        public static DateTime horaEntrada { get; set; }
        public static DateTime horaAlmoco { get; set; }
        public static DateTime horarioReentrada { get; set; }
        public static DateTime fimExpediente { get; set; }

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
        public IList<Sessoes> BuscaPorCliente(Cliente objClienteDaBusca)
        {
            return null;
        }
        public Sessoes BuscaPorData(DateTime data, Medico objMedico)
        {
            return new SessoesDAO().Pesquisar(data, objMedico);
        }
        public Sessoes BuscaPorData(DateTime data)
        {
            return new SessoesDAO().Pesquisar(data);
        }
        public Sessoes BuscaPorMedico(Medico objMedicoDaBusca)
        {
            return new SessoesDAO().Pesquisar(objMedicoDaBusca);
        }
        public Sessoes BuscaPorConsultorio(Consultorio objConsultorio)
        {
            return new SessoesDAO().Pesquisar(objConsultorio);
        }
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
        //public IList<DateTime> GerarHorarios(DateTime horarioInicial, DateTime horarioDeAlmoco, DateTime horarioDeReentrada, DateTime fimDoExpediente, DateTime data, Medico objMedico, Consultorio objConsultorio)
        //{
        //    IList<Sessoes> listaDeSessoes = new Sessoes().BuscaPorData(data.Date);
        //    IList<DateTime> listaDeHorarios = new List<DateTime>();
        //    DateTime dt = data.Date;
        //    bool outOfLoop = false;
        //    for (int i = 0; i < 46; i++)
        //    {                
        //        dt = dt.AddMinutes(30);
        //        if (listaDeSessoes!=null && outOfLoop==false && ((dt <= fimDoExpediente && dt >= horarioDeReentrada) || dt <= horarioDeAlmoco && dt >= horarioInicial))
        //        {
        //            foreach (Sessoes objSessao in listaDeSessoes)
        //            {

        //                if (dt <= fimDoExpediente && dt >= horarioDeReentrada && (dt >= objSessao.horaFim || dt < objSessao.horaInicio) && objSessao.BuscaPorMedico(objMedico)==null && objSessao.BuscaPorConsultorio(objConsultorio)==null)
        //                {
        //                    listaDeHorarios.Add(dt);
        //                }
        //                else if (dt <= horarioDeAlmoco && dt >= horarioInicial && (dt >= objSessao.horaFim || dt < objSessao.horaInicio) && objSessao.BuscaPorMedico(objMedico) == null && objSessao.BuscaPorConsultorio(objConsultorio) == null)
        //                {
        //                    listaDeHorarios.Add(dt);
        //                }
        //            }
        //            outOfLoop = true;
        //        }
        //        else
        //        {
        //            if (dt <= fimDoExpediente && dt >= horarioDeReentrada)
        //            {
        //                listaDeHorarios.Add(dt);
        //            }
        //            else if (dt <= horarioDeAlmoco && dt >= horarioInicial)
        //            {
        //                listaDeHorarios.Add(dt);
        //            }
        //        }
                
                
        //    }
        //    return listaDeHorarios;
        //}








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

                Sessoes objSessaoComparar = new Sessoes().BuscaPorData(dt,objMedico);
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




    }
}
