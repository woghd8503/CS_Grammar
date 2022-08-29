using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01.BasicGrammar
{
    class InDecOperator
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a++);
            Console.WriteLine(++a);

            Console.WriteLine(a--);
            Console.WriteLine(--a);
        }
    }
}
