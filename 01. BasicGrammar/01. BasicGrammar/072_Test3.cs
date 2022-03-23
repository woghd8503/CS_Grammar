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
        static float Square(float inputNum)
        {
            float result = inputNum * inputNum;
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요: ");

            string input = Console.ReadLine();
            float inputNum = float.Parse(input);

            Console.WriteLine("결과 : " + Square(inputNum));
        }
    }
}