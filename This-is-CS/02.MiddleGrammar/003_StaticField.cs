using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.MiddleGrammar
{
    // static은 사전적으로는 정적이라는 뜻을 갖고 있습니다. 움직이지 않는다는 뜻이지요. C#에서 static은 메소드나 필드가 클래스의 인스턴스가
    // 아닌 클래스 자체에 소속되도록 지정하는 한정자입니다.

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

        }
    }
}
