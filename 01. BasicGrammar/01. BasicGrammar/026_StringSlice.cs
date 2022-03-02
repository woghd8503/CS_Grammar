using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01.BasicGrammar
{
    class StringSlice
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning";

            WriteLine(greeting.Substring(0, 5)); // "Good"
        }
    }
}
