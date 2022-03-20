using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// ref만으로도 여러 개의 결과를 메소드에서 얻어돌 수 있지만, C#은 조금 더 안전한 방법으로 똑같은 일을 할 수
// 있게 해줍니다. 바로 out 키워드를 이용한 "출력 전용 매개변수"가 그것입니다. out 키워드의 사용법은 간단합니다.
// 메소드의 선언부와 호출부에 ref 키워드 대신 out 키워드를 사용하는 것이 전부입니다. 
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