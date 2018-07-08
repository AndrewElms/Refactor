using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    public class StringConverter
    {
        public string ConvertString(string a, string b)
        {
            return string.Concat(a, b);
        }
    }
}
