using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01.BasicGrammar
{
    class StringConcatenate
    {
        static void Main(string[] args)
        {
            string result = "123" + "456";
            Console.WriteLine(result);

            result = "Hello" + " " + "World!";
            Console.WriteLine(result);
        }
    }
}
