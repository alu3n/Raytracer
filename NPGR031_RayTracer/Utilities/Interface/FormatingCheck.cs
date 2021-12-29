using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPGR031_RayTracer.Utilities.Interface
{
    static class FormatingCheck
    {
        public static string ValidateStringNumber(string text, int def)
        {
            if(text == "-" | text == "," | text == "." | text == "")
            {
                return def.ToString();
            }
            else
            {
                return text;
            }
        }

        public static string ValidateMinimalValue(string text, double minimum)
        {
            if(text == "")
            {
                return minimum.ToString();
            }
             if(Convert.ToDouble(text) < minimum)
            {
                return minimum.ToString();
            }
            else
            {
                return text;
            }
        }
    }
}
