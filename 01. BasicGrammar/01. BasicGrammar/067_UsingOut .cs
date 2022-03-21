using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// 오버로딩 Overloading이란 "과적하다"라는 뜻을 갖고 있습니다. 과적이란 트럭 따위에 원래의 탑재량을 넘겨 싣는 것을 말하죠.
// 메소드 오버로딩은 하나의 메소드 이름에 여러 개의 구현을 올리는 것을 뜻합니다. 
// int 형식의 매개변수와 반환 형식을 갖고 있는 Plus() 메소드만 있는데, double 형식을 지원하는 버전도 추가해야 한다고 생각해보세요.

namespace _01.BasicGrammar
{
    class UsingOut
    {
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            // int c;
            // int d;

            Divide(a, b, out int c, out int d);

            Console.WriteLine($"a:{a}, b:{b}:, a/b:{c}, a%d:{d}");
        }
    }
}