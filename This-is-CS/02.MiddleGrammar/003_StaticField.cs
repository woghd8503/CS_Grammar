using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.MiddleGrammar
{
    // static은 사전적으로는 정적이라는 뜻을 갖고 있습니다. 움직이지 않는다는 뜻이지요. C#에서 static은 메소드나 필드가 클래스의 인스턴스가
    // 아닌 클래스 자체에 소속되도록 지정하는 한정자입니다. static으로 수식한 필드는 프로그램 전체에 걸쳐 하나밖에 존재하지 않습니다. 프로그램 전체에 걸쳐 공유해야
    // 하는 변수가 있다면 정적 필드를 이용하면 됩니다. 정적 메소드 역시 정적 필드처럼 인스턴스가 아닌 클래스 자체에 소속됩니다. 정적 메소드에 대해 우리가 우선적으로  
    // 기억해야 할 것은 정적 메소드가 클래스의 인스턴스를 생성하지 않아도 호출이 가능한 메소드라는 점입니다. 정적 메소드는 다음과 같이 선언하고 사용합니다. 낯설지 않을 겁니다.
    class Global 
    {
        public static int Count = 0;
    }  

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }

    class StaticFiled
    {
        static void Main()
        {
            Console.WriteLine($"Global.Count : {Global.Count}");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine($"Global.Count : {Global.Count}");
        }
    }
}
