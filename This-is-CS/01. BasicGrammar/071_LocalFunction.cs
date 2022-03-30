using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// 메소드 오버로딩 vs 선택적 매개변수
// 선택적 인수는 유용한 기능임에 틀림없지만, 메소드 오버로딩과 함께 사용될 때 혼란을 야기할 수도 있습니다. 예를 들어 다음과 같이 두개의 MyMethod()메소드를 오버로딩해봅시다.

// void MyMethod( String arg0 = "", string arg1 = "" )
//{
//    Console.WriteLine( "A" );
//}

// void MyMethod (  )
//{
//    Console.WriteLine( "B" );
//}

// 그리고 다음과 같이 PrintProfile() 메소드를 호출했다고 해봅시다. 어떤 결과가 나올까요?
// MyMethod();

// 정답은 "B가 출력된다" 입니다. 하지만 이 정답에 의미를 둘 필요는 없습니다. 앞에서와 같이 선택적 인수와 오버로딩을 함께 사용한 것 자체가 0점짜리 코드이기 때문입니다.
// 오버로딩을 할지 아니면 선택적 인수를 사용할지를 프로그래머가 정책적으로 분명하게 정할 필요가 있습니다.
// 논리는 동일하되 매개변수가 다른 경우는 선택적 인수를 사용하고, 매개변수에 따라 논리도 함께 달라지는 경우에는 오버로딩을 사용하는 식으로 말입니다.

namespace _01.BasicGrammar
{
    class LoacalFuction
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90) // A ~ Z의 ASCII 값 : 65 ~ 90
                    return arr[i];
                else // a ~ z의 ASCII 값 : 97 ~ 122
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning."));
            Console.WriteLine(ToLowerString("This is C#"));
        }
    }
}