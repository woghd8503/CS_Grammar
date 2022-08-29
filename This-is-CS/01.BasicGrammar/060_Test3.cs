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
    class Test3
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

            int o = 0;

            do
            {
                int p = 5;
                while (p > o)
                {
                    Console.Write("*");
                    p--;
                }

                Console.WriteLine();
                o++;
            } while (o < 5);



            int num = -1;

            while(num <= 0)
            {
                Console.Write("반복 횟수를 입력하세요");
                String input = Console.ReadLine();
                num = Convert.ToInt32(input);

                for(int i = 0; i < num; i++)
                {
                    for(int j = 0; j < i + 1; j++)
                        Console.Write("*");

                    Console.WriteLine();
                }

                if(num <= 0)
                    Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
            }


        }
    }
}
