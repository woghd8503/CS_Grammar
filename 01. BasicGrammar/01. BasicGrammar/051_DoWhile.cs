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
    class While
    {
        static void Main(string[] args)
        {
            int i = 10;
            
            while (i > 0)
            {
                Console.WriteLine($"i : {i--}");
            }
        }
    }
}
