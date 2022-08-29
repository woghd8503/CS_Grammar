using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// var는 지역 변수로만 사용할 수 있습니다.
// var는 지역 변수로만 사용할 수 있습니다. 클래스의 필드를 선언할 때는 반드시 명시적 형식을 선언해야 합니다. 왜일까요?
// 클래스의 필드는 선언과 같이 초기화를 하지 않는 경우가 많은데(나중에 배우겠지만 생성자라고 하는 특수한 메소드에서 초기화를 
// 하는 특수한 메소드에서 초기화를 하는 경우가 대부분입니다). var 키워드로 필드를 선언하면 컴파일러가 무슨 형식인지 파악살 길이
// 없기 때문입니다.

// 아차, 지역 변수 Local Variable는 처음보는 용어죠? 지역 변수란, 코드 블록 안에서 선언되는 면수를 말합니다. 이름처럼
// 자기가 태어난 동네Local, 즉 코드 블록에서만 사용되고 코드 블록이 종료될 때 소멸됩니다. 이 때문에 프로그램의 다른 코드에서는
// 접근할 수 없다는 특징이 있습니다. C/C++언어에서는 지역변수와 대비되는 개념의 전역 변수 Global Valuable라는 것이 있습니다. 
// 전역변수는 프로그램의 어느 코드에서나 접근해서 사용할 수 있었는데, 코드의 가독성을 해치고 오류를 낳는 원흉으로 지적도어 왔기에
// C# 언어 설계자는 C#에서 전역변수를 지원하지 않도록 만들었습니다.
namespace _01.BasicGrammar
{
    class UsingVar
    {
        static void Main(string[] args)
        {
            var a = 20;
            Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);

            var b = 3.1414231;
            Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b);

            var c = "Hello World";
            Console.WriteLine("Type: {0}, Value: {1}", c.GetType(), c);

            var d = new int[] { 10, 20, 30 };
            Console.Write("Type: {0}, Value: ", d.GetType());
            foreach(var e in d)
                Console.Write("{0} ", e);

            Console.WriteLine();
        }
    }
}
