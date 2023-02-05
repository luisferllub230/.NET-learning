using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.controller
{
    public class RemuveCaracter 
    {
        public string filter(string str, List<char> remove) 
        {
            foreach (char c in remove) 
            {
                str = str.Replace(c.ToString(), string.Empty);
            }
            return str;
        }
    }
}
