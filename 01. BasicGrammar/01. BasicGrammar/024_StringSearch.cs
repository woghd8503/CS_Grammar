using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01.BasicGrammar
{
    class StringSearch
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            // IndexOf()
            WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            WriteLine("IndexOf 'o' : {0}", greeting.IndexOf("o"));

            // LastIndexOf()
            WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
            WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf("o"));

            // StartWith()
            WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
            WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));

            // EndWith()
            WriteLine("EndWith 'Good' : {0}", greeting.StartsWith("Good"));
            WriteLine("EndWith 'Morning' : {0}", greeting.StartsWith("Morning"));

            // Contains()
            WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

        }
    }
}
