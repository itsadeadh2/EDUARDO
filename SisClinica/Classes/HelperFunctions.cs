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
        /// <summary>
        /// Remove as bordas dos botões e muda a cor do MouseDown para branco. Utilizado geralmente para os botões que não possuem texto.
        /// </summary>
        /// <param name="btn">Botão</param>
        public static void SetButtons(Button btn)
        {
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.White;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
        /// <summary>
        /// Remove as bordas e define a aparencia do botão como flat, também muda as cores do MouseDown e MouseOver. Utilizado geralmente para os botões que contem texto.
        /// </summary>
        /// <param name="btn">Botão</param>
        public static void SetButtonsText(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.FromArgb(238, 238, 238);
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.Black;
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 51, 51);
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 102, 102);
        }
        /// <summary>
        /// Remove as bordas e muda a cor do mouseOver e mouseClick para as cores passadas como parâmetro.
        /// </summary>
        /// <param name="btn"></param>
        /// <param name="mouseOver">Cor do MouseOver</param>
        /// <param name="mouseClick">Cor do MouseClic</param>
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
        /// <summary>
        /// Checa se o nome tem o nome é valido.
        /// </summary>
        /// <param name="nome">nome</param>
        /// <returns></returns>
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
        /// <summary>
        /// Checa se a data da sessão é uma data válida.
        /// </summary>
        /// <param name="data">Data</param>
        /// <returns></returns>
        public static bool ChecaData(DateTime data)
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
        /// <summary>
        /// Checa se o horário é valido.
        /// </summary>
        /// <param name="horario"></param>
        /// <returns></returns>
        public static bool ChecaHorario(TimeSpan horario)
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
