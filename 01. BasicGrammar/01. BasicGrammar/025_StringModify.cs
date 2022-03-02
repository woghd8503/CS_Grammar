using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01.BasicGrammar
{
    class StringModify
    {
        static void Main(string[] args)
        {
            WriteLine("ToLower() : '{0}'", "ABC".ToLower());
            WriteLine("ToUpper() : '{0}'", "abc".ToUpper());

            WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));
        }
    }
}
