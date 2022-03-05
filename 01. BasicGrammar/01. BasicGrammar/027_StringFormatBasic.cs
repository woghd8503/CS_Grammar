using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01.BasicGrammar
{
    class StringFormatBasic
    {
        static void Main(string[] args)
        {
            string fmt = "{0, -20}{1, -15}{2, 30}";

            WriteLine(fmt, "Publisher", "Author", "Title");
        }
    }
}
