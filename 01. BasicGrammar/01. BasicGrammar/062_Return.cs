using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// void 반환 형식
// 모든 메소드들이 결과를 반환하는 것은 아닙니다. 어떤 메소드들은 그냥 자기 할 일만 하고 종료하기도 합니다.
// Console 클래스의 Write()나 WriteLine() 메소드가 그런 예지요. 이런 메소드를 선언할 때는 반환 형식에 void
// 를 넣어주면 됩니다. 그런데 void, 굉장히 낯이 익지 않습니까? Main 메소드를 선언할 때 항상 사용했잖아요.

// static 한정자
// static은 사전적으로 "정적"이라는 뜻을 갖고 있습니다. 움직이지 않는다는 뜻이지요. C#에서 static은 메소드나
// 필드가 클래스의 인스턴스가 아닌 클래스 자체에 소속되도록 지정하는 한정자입니다. 조금 전의 예제 코드에서 Plus()
// 메소드와 Minus() 메소드를 static 한정자에 수식했지요? 이렇게 하면 Calculator의 인스턴스를 만들지 않고도
// 해당 메소드를 호출할 수 있습니다.

// 재귀 호출
// 메소드가 자기 자신을 스스로 호출하는 것을 일컬어 재귀 호출 Recursive Call이라고 합니다. 조금 전의 Fibonacci()
// 메소드가 조건에 따라 또 다시 Fibonacci() 함수 자신을 호출했지요? 이것이 재귀 호출의 예입니다. 재귀 호출은 
// 코드를 단순하게 구성할 수 있다는 장점이 있는 한편 (재귀 호출이 없었다면 우리는 앞의 코드를 반복문으로) 구성해야
// 했을 겁니다). 성능에는 나쁜 영향을 주기 때문에 주의해서 사용해야 합니다.

namespace _01.BasicGrammar
{
    class Return
    {
        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("이름을 입력해주세요.");
                return;
            }

            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"10번째 피보나치 수 : {Fibonacci(10)}");

            PrintProfile("", "123-4567");
            PrintProfile("박상현", "456-1230");
        }
    }
}
