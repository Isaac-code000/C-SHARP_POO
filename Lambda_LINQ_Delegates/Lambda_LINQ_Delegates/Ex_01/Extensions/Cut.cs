using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    static class Cut
    {

        public static string CutString(this string str, int tam)
        {
            if (str.Length <= tam)
            {
                return str;
            }
            else
            {
                return str.Substring(0, tam) + "...";
            }

        }   


    }
}
