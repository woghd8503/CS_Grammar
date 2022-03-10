using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01.BasicGrammar
{
    class ConditionalOperator
    {
        static void Main(string[] args)
        {
            string result = (10 % 2) == 0 ? "짝수" : "홀수";

            Console.WriteLine(result);
        }
    }
}
