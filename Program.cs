using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = null;
            string B = null;

            while (true)
            {
                Console.WriteLine("Give me two things to convert");

                Console.Write("Thing A >");
                A = Console.ReadLine();
                Console.Write("Thing B >");
                B = Console.ReadLine();

                ConvertAnything Converter = new ConvertAnything();
                object x = Converter.ConvertThis(A, B);

                Console.WriteLine(x);

                Console.WriteLine();
                Console.Write("Press Enter key to go again or 'N' to stop? >");
                if (Console.ReadLine().ToUpper() == "N")
                    break;
            }

        }
    }
}
