﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BasicGrammar
{
    class   SignedUnsignedConversion
    {
        static void Main(string[] args)
        {
            int a = 500;
            Console.WriteLine(a);

            uint b = (uint)a;
            Console.WriteLine(b);

            int x = -30;
            Console.WriteLine(x);

            uint y = (uint)x;
            Console.WriteLine(y);  // 언더플로우

        }
    }
}
