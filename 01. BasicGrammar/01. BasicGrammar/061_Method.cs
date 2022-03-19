using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// 매개변수 Parameter와 인수 Argument
// 매개변수는 매소드가 호출자에게서 전달받은 값을 받는 변수를 말하고, 인수는 호출자가 매개변수에 넘기는
// 값을 뜻합니다. 예를 들어, Calculator 클래스 안에 선언한 메소드 public static int Plus( int a, int b )에서 a,
// b가 매개변수, Calculator.Plus( 3, 4 )에서 3, 4가 인수입니다.

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
