using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01.BasicGrammar
{
    class BitwiseOperator
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 10;

            Console.WriteLine($"{a} & {b} : {a & b}");
            Console.WriteLine($"{a} | {b} : {a | b}");
            Console.WriteLine($"{a} ^ {b} : {a ^ b}");

        }
    }
}
