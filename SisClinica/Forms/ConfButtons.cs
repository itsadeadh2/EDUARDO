using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisClinica.Forms
{
    public static class ConfButtons
    {
        public static void SetButtons(Button btn)
        {
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 195, 189);
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
        }
    }
}
