using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 분할 클래스 Partial Class란, 여러 번에 나눠서 구현하는 클래스를 말합니다. 분할 클래스는 그 자체로 특별한 기능을 하는 것은 아니며 클래스의 구현이 길어질 경우
// 여러 파일에 나눠서 구현할 수 있게 함으로써 소스 코드 관리의 편의를 제공하는 데 그 의미가 있습니다.

namespace _002.MiddleGrammar
{
   partial class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public void Method2()
        {
            Console.WriteLine();
        }
    }
}
