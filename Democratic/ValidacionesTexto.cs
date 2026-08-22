using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Democratic
{
    class ValidacionesTexto
    {
        public static void soloNumeros(KeyPressEventArgs f)
        {
            if (char.IsNumber(f.KeyChar))
            {
                f.Handled = false;
            }
            else if (char.IsControl(f.KeyChar))
            {
                f.Handled = false;
            }
            else
            {
                f.Handled = true;
            }
        }

        public static void soloLetras(KeyPressEventArgs f)
        {
            if (char.IsLetter(f.KeyChar))
            {
                f.Handled = false;
            }
            else if (char.IsControl(f.KeyChar))
            {
                f.Handled = false;
            }
            else if (f.KeyChar == ' ')
            {
                f.Handled = false;
            }
            else
            {
                f.Handled = true;
            }
        }
    }
}
