using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPGR031_RayTracer.Utilities.Interface
{
    static class InputHandler
    {
        public static void ColorInput(string TextboxText, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (TextboxText.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar))
            {
                if (Convert.ToInt16(TextboxText + e.KeyChar) > 255)
                {
                    e.Handled = true;
                }
            }
        }

        public static void ResolutionInput(string TextboxText, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (TextboxText.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar))
            {
                if (Convert.ToInt16(TextboxText + e.KeyChar) > 2048)
                {
                    e.Handled = true;
                }
            }
        }
        public static void AngleInput(string TextboxText, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (TextboxText.Length >= 3)
            {
                e.Handled = true;
            }
            if (TextboxText.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar))
            {
                if (Convert.ToInt16(TextboxText + e.KeyChar) > 150)
                {
                    e.Handled = true;
                }
            }
        }

        public static void SampleInput(string TextboxText, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (TextboxText.Length >= 3)
            {
                e.Handled = true;
            }
            if (TextboxText.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar))
            {
                if (Convert.ToInt16(TextboxText + e.KeyChar) > 10)
                {
                    e.Handled = true;
                }
            }
        }

        public static void DoubleInput(string TextboxText, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            if (!char.IsNumber(e.KeyChar))
            {
                if(e.KeyChar == '.' && !TextboxText.Contains('.'))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == '-' && TextboxText.Length == 0)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

        }
        public static void DoubleInputNonNegative(string TextboxText, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            if (!char.IsNumber(e.KeyChar))
            {
                if (e.KeyChar == '.' && !TextboxText.Contains('.') && TextboxText.Length > 0)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

        }
    }
}
