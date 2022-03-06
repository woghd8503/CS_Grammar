using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01.BasicGrammar
{
    class StringInterpolation
    {
        static void Main(string[] args)
        {
            WriteLine("사각형의 너비를 입력하세요.");
            string width = ReadLine();
            WriteLine("사각형의 높이를 입력하세요.");
            string height = ReadLine();

            int answer = Int32.Parse(width) * Int32.Parse(height);

            WriteLine("사각형의 넓이는 : " + answer);
        }
    }
}

