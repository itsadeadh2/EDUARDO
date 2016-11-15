using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisClinica.Classes
{
    public class Horarios
    {
        public TimeSpan horarioDeEntrada { get; set; }
        public TimeSpan horarioDeAlmoco { get; set; }
        public TimeSpan horarioDeReentrada { get; set; }
        public TimeSpan horarioFimDeExpediente { get; set; }

        public IList<TimeSpan> GerarHorarios()
        {
            IList<TimeSpan> lst = new List<TimeSpan>();
            TimeSpan hora = Convert.ToDateTime("00:00").TimeOfDay;
            int limite = 23;
            for (int i = 0; i < limite; i++)
            {
                hora = hora.Add(Convert.ToDateTime("00:30").TimeOfDay);
                lst.Add(hora);
            }
            return lst;
        }
        public IList<TimeSpan> GerarProximoHorario(TimeSpan horarioAnterior)
        {
            IList<TimeSpan> lst = new List<TimeSpan>();
            TimeSpan hora = Convert.ToDateTime("00:00").TimeOfDay;
            int limite = 23;
            for (int i = 0; i < limite; i++)
            {
                hora = hora.Add(Convert.ToDateTime("00:30").TimeOfDay);
                if (hora>=horarioAnterior)
                {
                    lst.Add(hora);
                }
            }
            return lst;
        }

        public void GravarHorarios()
        {
            //
        }
        public Horarios PesquisarHorarios(int id)
        {
            return null;
        }
    }
}
