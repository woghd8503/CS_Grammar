﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BasicGrammar
{
    class Overflow
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;

            Console.WriteLine(a);

            a = a + 1;

            Console.WriteLine(a);
        }
    }
}
