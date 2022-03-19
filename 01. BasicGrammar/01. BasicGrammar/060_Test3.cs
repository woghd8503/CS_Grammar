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
    class Goto
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (int k = 5; k > 0; k--)
            {
                for (int l = 0; l < k; l++)
                    Console.Write("*");
                Console.WriteLine();
            }

            int m = 0;

            do
            {
                int n = 0;
                while (n < m + 1)
                {
                    Console.Write("*");
                    n++;
                }

                Console.WriteLine();
                m++;
            } while (m < 5);
        }
    }
}
