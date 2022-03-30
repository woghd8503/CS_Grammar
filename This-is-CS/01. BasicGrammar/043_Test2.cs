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

        // 오른쪽 쉬프트 연산자는 옮기는 bit수 만큼 2의 n승 으로 나눠진다.
        // 따라서 8 / 12(2의 1승) => 4이다.
        // 이진수로 표현하면 "0000 1000" 을 1 비트씩 오른쪽 으로 이동하기에 "0000 0100" 이 되었다. 즉, a의 값은 4이다.

        // a의 값이 4가 되었고 4 / 4(2의 2승) => 1이다.

        // 이진수로 표현하면 "0000 0100"을 2비트씩 오른쪽 으로 이동하기에 "0000 0001" 이 되었다.
        // 즉, b의 값은 1이다.

        // 4. 다음 코드에서 a는 얼마일까요?
        // int a = 0xF0 | 0x0F;

        // 논리합(OR) 연산자는 비교하는 bit중 한쪽만 1이상의 값이라면 결과값이 1이기에
        // 16진수 0xF0 과
        // 16진수 0x0F 를 연산한다면 빈틈없이 모두 1의 값을 가지게 되어
        // 결과값은 0xFF가 된다.

        // 16진수이건 2진수이건 결국 컴퓨터가 값을 저장하는 방식은 1과 0 두가지 경우이기에 16진수를 2진수로 변환한 뒤 OR 연산자를
        // 적용한다고 생각하면 쉽다.

        // 5. 다음 코드에서 b는 어떤 값을 가질까요?
        // int a = 10;
        // string b = a == 0 ? "가나다" : "ABC";

        // b는 "ABC"의 값을 가진다.
    }
}
