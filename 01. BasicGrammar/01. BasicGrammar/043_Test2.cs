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
    class Test2
    {
        static void Main(string[] args)
        {

        }
        // 1. i++와 ++i의 차이점은 무엇인가?


        // i++ 는 후위 증가연산자로 해당 라인의 코드를 모두 실행한 다음에 값이 1 증가한다.
        // ++i 는 전위 증가연산자로 값이 1 증가된 후에 해당 라인의 코드 실행이 완료된다.

        // 2. 다음 보기 중에서 그 결과가 다른 것을 찾으세요 
        //  a. i = i + 1;
        //  b. i++;
        //  c. ++i;
        //  d. i += 1;

        // 2번의 경우는 출력문내에 있다고 가정하면 변수값 그대로 출력된 후에 i의 값이 1증가된다.

        // 3. 다음 코드에서 a와 b는 각각 얼마일까요?
        // int a = 8 >> 1;
        // int b = a >> 2;



        // 4. 다음 코드에서 a는 얼마일까요?
        // int a = 0xF0 | 0x0F;

        // 5. 다음 코드에서 b는 어떤 값을 가질까요?
        // int a = 10;
        // string b = a == 0 ? "가나다" : "ABC";
    }
}
