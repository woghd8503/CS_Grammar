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
    class AssignmentOperator
    {
        static void Main(string[] args)
        {
            int a;
            a = 100;
            Console.WriteLine($"a = 100 : {a}");
            a += 90;
            Console.WriteLine();
        }
    }
}
