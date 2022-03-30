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
    class Break
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("계속할까요?(예/아니오) : ");
                string answer = Console.ReadLine();

                if (answer == "아니오")
                    break;
            }
        }
    }
}
