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

// int total = 0;

// total = Sum( 1, 2 );
// total = Sum( 1, 2, 3 );
// total = Sum( 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 );
// ...

// 가변 개수의 인수를 params 키워드와 배열을 이용해서 선언합니다. 다음은 가변 개수의 인수를 이용해서 모든 인수의
// 합을 구해 반환하는 Sum() 메소드의 구현입니다. 이렇게 구현한 메소드는 앞에서 본 코드에서처럼 인수의 개수를 달리해서
// 호출할 수 있습니다.

// int Sum( params int[] args )
//{
//    int sum = 0;
//
//    for(int i = 0; i < args.Length; i++)
//    {
//        sum += args[i];
//    }
//
//      return sum;
//}

namespace _01.BasicGrammar
{
    class UsingParams
    {
        static int Sum(params int[] args)
        {
            Console.Write("Summing....");

            int sum = 0;

            for(int i = 0; i < args.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");

                Console.Write();
            }

        }
    }
}