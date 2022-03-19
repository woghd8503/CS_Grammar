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


namespace _01.BasicGrammar
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Method
    {
        public static void Main()
        {
            int result = Calculator.Plus(3, 4);
            Console.WriteLine(result);

            result = Calculator.Minus(5, 2);
            Console.WriteLine(result);
        }
    }
}
