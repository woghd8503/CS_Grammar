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
    class ShiftOperator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing <<...");

            int a = 1;
            Console.WriteLine("a      : {0:D5} (0x{0:X8})", a);
            Console.WriteLine("a << 1 : {0:D5} (0x{0:X8})", a << 1);
        }
    }
}
