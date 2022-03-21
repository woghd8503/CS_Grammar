using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// 명명된 인수
// 메소드를 호출할 때 매개변수 목록 중 어느 매개변수에 데이터를 할당할지 지정하는 것은 "순서"입니다.
// 가령 void MyMethod ( int a, int b, int c )와 같이 선언된 메소드를 MyMethod( 1, 2, 3 )이라고 호출하면
// 인수의 순서에 따라 a에는 1, b에는 2, c에는 3이 할당됩니다.

// 대개의 경우 순서에 근거해서 매개변수에 인수를 할당하는 스타일을 사용하지만, C#은 또 다른 스타일도 지원합니다.
// 바로 명명된 인수 Named Argument라는 건데요. 말 그대로 메소드를 호출할 때 인수의 이름에 근거해서 데이터를
// 할당할 수 있는 기능입니다.

// 명명된 인수를 사용하기 위해 메소드 선언에 손댈 일은 전혀 없습니다. 메소드를 호출할 때만 인수의 이름 뒤에 콜론(:)을
// 붙인 뒤 할당할 데이터를 넣어주면 됩니다. 다음은 명명된 인수의 예제 코드입니다.

// static void PrintProfile(string name, string phone)
//{
//     Console.WriteLine("Name:{0}, Phone:{1}", name, phone);
//}

// static void Main(string[] args)
//{
//      PrintProfile(name : "박찬호", phone : "010-123-1234");
//}

namespace _01.BasicGrammar
{
    class NamedParameter
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        static void Main(string[] args)
        {

        }
    }
}