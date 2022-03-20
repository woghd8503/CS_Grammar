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

// out에는 ref에 없는 안전장치가 있습니다.
// 예를 들어 ref 키워드를 이용해서 매개변수를 넘기는 경우 메소드가 해당 매개변수에 결과를 저장하지 않아도
// 컴파일러는 아무런 경고를 하지 않습니다. 이와는 달리, out 키워드를 이용해서 매개변수를 넘길 때는 메소드가
// 해당 매개변수에 결과를 저장하지 않으면 컴파일러가 에러 메시지를 출력합니다.

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