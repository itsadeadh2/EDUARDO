using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisClinica.Forms
{
    public static class HelperFunctions
    {
        public static void SetButtons(Button btn)
        {
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 195, 189);
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
        }
        /// <summary>
        /// Checa se a data informada corresponde a um maior de idade
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>Verdadeiro para menor, falso para maior.</returns>
        public static bool ChecaMenorDeIdade(DateTime dt)
        {
            if (DateTime.Now.Year - dt.Year < 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }        
    }
}
