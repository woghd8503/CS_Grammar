﻿using System;
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
            Console.Write("종료 조건(숫자)을 입력하세요 :");

            String input = Console.ReadLine();

            int input_number = Convert.ToInt32(input);
            int exit_number = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (exit_number++ == input_number)
                            goto EXIT_FOR;

                        Console.WriteLine(exit_number);
                    }
                }
            }

            goto EXIT_PROGRAM;

        EXIT_FOR:
            Console.WriteLine("/nExit nested for...");
        EXIT_PROGRAM:
            Console.WriteLine("Exit program...");
        }
    }
}
