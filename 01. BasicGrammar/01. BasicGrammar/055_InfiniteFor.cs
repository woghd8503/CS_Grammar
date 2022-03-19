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
    class InfiniteFor
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (; ; )
                Console.WriteLine(i++);
        }
    }
}
