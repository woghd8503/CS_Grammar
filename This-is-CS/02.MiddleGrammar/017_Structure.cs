using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// public 필드가 보이네요?
// 은닉성을 운운하며 모든 필드는 반드시 private으로 만들어야 한다고 했던 제가 왜 이렇게 했을까요?
// 문법적으로 구조체가 클래스와 유사하기는 해도, 각자의 존재 이유는 조금 다릅니다. 클래스는 실세계의
// 객체를 추상화하려는 데 그 존재의 이유가 있지만, 구조체는 데이터를 담기 위한 자료구조로 사용됩니다.

namespace MyExtension
{
    public static class IntegerExtension
    { 
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
                result = result * myInt;

            return result;
        }
    }
}

namespace ExtensionMethod
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");
        }
    }
}
