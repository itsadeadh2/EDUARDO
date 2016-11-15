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
            btn.FlatAppearance.MouseDownBackColor = Color.White;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
        public static void SetButtonsText(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.FromArgb(238, 238, 238);
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 51, 51);
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 102, 102);
        }
        public static void SetButtons(Button btn, Color mouseOver, Color mouseClick)
        {
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = mouseClick;
            btn.FlatAppearance.MouseOverBackColor = mouseOver;
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
        public static void SetUserControl(UserControl uc)
        {
            uc.BackColor = Color.FromArgb(164, 217, 212);
            uc.Width = 672;
            uc.Height = 409;
        }
        public static bool ChecaNome(string nome)
        {
            bool value;
            if (nome.Length<3)
            {
                value = true;
            }
            else
            {
                value = false;
            }
            return value;
        }
        public static bool ChecaDataSessao(DateTime data)
        {
            bool value;
            if (data.Date<DateTime.Now.Date)
            {
                value = true;
            }
            else
            {
                value = false;
            }
            return value;
        }
        public static bool ChecaHorarioSessao(TimeSpan horario)
        {
            bool value;
            if (horario<DateTime.Now.TimeOfDay)
            {
                value = true;
            }
            else
            {
                value = false;
            }
            return value;
        }        
    }
}
