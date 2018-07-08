using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Refactor
{
    public class ConvertAnything
    {
        public string ConvertThis(string X, string Y)
        {
            string O1 =  X.GetType().ToString();
            string O2 = Y.GetType().ToString();
            object ReturnValue = null;

            StringConverter s = new StringConverter();
            IntegerConverter i = new IntegerConverter();
            DoubleConverter d = new DoubleConverter();

            if (IsAlpha(X) && IsAlpha(Y))
                ReturnValue = s.ConvertString(X, Y);
            else if (IsNumeric(X) && IsNumeric(Y))
                ReturnValue = i.ConvertInteger(int.Parse(X), int.Parse(Y));
            else if (IsDouble(X) && IsDouble(Y))
                ReturnValue = d.ConvertDouble(double.Parse(X), double.Parse(Y));
            else
                ReturnValue = "Unsupported types provided";

                
            return ReturnValue.ToString();
        }

        public bool IsAlpha(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z]+$");
        }

        public bool IsNumeric(string input)
        {
            return Regex.IsMatch(input, "^[0-9]+$");
        }

        public bool IsDouble(string input)
        {
            return Regex.IsMatch(input, "^[0-9/.]+$");
        }



    }
}
