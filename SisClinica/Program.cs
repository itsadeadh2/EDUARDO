using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisClinica.Forms;

namespace SisClinica
{
    public enum tdp : int { cliente, medico, data, clienteEMedico, clienteMedicoEData, clienteData, medicoData }
    public enum tdr :int { consulta, tratamento, consultaETratamento}
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new newFrmPrincipal());
        }
    }
}
