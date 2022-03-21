using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// 선택적 인수
// 메소드의 매개변수는 기본값을 가질 수 있습니다. 그러니까 다음과 같이 매개변수를 특정 값으로 초기화하듯
// 메소드를 선언할 수 있다는 겁니다.

// void MyMethod( int a, int b = 0 )
// {
//      Console.WriteLine( "{0}, {1}", a, b);
// }

// 이와 같이 기본값을 가진 매개변수는 메소드를 호출할 때 해당 인수를 생략할 수 있습니다.
// MyMethod ( 3 );

// 물론 필요한 경우에는 인수를 입력할 수도 있습니다. 기본값을 가진 매개변수는 필요에 따라 인수를
// 할당하거난 할당하지 않을 수 있기 때문에 이를 "선택적 인수 Optional Argument"라고 부릅니다.
// MyMethod ( 3, 4 );
// 선택적 인수는 항상 필수 인수 뒤에 와야 합니다. 물론 필수 인수가 하나도 없는 경우에는 이 규칙에
// 신경 쓰지 않아도 됩니다. 다음은 선택적 인수의 선언 예입니다.

// void MyMethod_0( int a = 0 )
// {
//      Console.WriteLine( "{0}", a );
// }

// void MyMethod_1( int a, int b = 0 )
// {
//      Console.WriteLine( "{0}, {1}", a, b );
// }

// void MyMethod_2( int a, int b, int c = 10, int d = 20 )
//{
//      Console.WriteLine( "{0}, {1}, {2}, {3}", a, b, c, d );
//}

// 선택적 인수는 메소드의 사용자에게 신경 쓰고 싶지 않은 인수를 염두에 두지 않도록 편의를 제공하지만,
// 또 한편으로는 모호함이라는 스트레스도 같이 줍니다. 코드를 작성할 때는 인텔리센스의 도움을 받아 내가 어느
// 매개변수의 수가 많고 여기에 선택적 인수도 여럿 포함되면 문제는 더 심각해집니다. 이런 경우 명명된 인수의 도움을
// 받으면 쉬게 문제를 풀 수 있습니다.

namespace _01.BasicGrammar
{
    class OptionalParameter
    {
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile("중근");
            PrintProfile("관순", "010-123-1234");
            PrintProfile(name: "봉길");
            PrintProfile(name: "동주", phone: "010-789-7890");
        }
    }
}