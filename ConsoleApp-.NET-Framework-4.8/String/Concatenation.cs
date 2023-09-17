using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.String
{
    internal class Concatenation
    {
        public string ConcatString(string[] strings)
        {
            string str = string.Empty;

            for (int i = 0; i < strings.Length; i++)
            {
                str += strings[i]; // string + string + string
            }

            str = str + " (These Strings were Cancatinated with \"+\" symbol)";

            return str;
        }

        public string Interpolation(string[] strings)
        {
            string str = string.Concat(strings);

            string description = "Interpolation Method $,{}";

            str = $"{str} - {description}";

            return str;
        }
    }
}
