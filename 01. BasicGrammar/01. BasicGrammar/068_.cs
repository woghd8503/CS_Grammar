using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// 가변 개수의 인수
// 프로그래밍을 하다 보면 그저 인수의 "개수"가 다르다는 이유만으로 똑같은 메소드를 여거가지 버전으로
// 오버로딩하고 싶을 때가 있습니다. 이런 경우를 위해 C#은 "가변 개수의 인수"라는 기능을 제공합니다.

// 가변 개수의 인수란, 그 개수가 유연하게 면할 수 있는 인수를 말합니다. 이것을 이용하면 다음과 같이 입력되는
// 모든 인수의 합을 구하는 Sum() 메소드를 오버로딩하지 않고도 구현할 수 있습니다.

//

namespace _01.BasicGrammar
{
    class Overloading
    {
        static int Plus(int a, int b)
        {
            Console.WriteLine("Calling int Plus(int, int)...");
            return a + b;
        }

        static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling int Plus(int, int, int)...");
            return a + b + c;
        }

        static double Plus(double a, double b)
        {
            Console.WriteLine("Calling double Plus(double, double)...");
            return a + b;
        }

        static double Plus(int a, double b)
        {
            Console.WriteLine("Calling double Plus(int, double)...");
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1.0, 2.4));
            Console.WriteLine(Plus(1, 2.4));
        }
    }
}