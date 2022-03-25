using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.MiddleGrammar
{
    // 프로그래머가 생성자를 하나라도 직접 정의하면 C# 컴파일러는 매개변수 없는 기본 생성자를 제공하지 않습니다.
    // 주던 것을 안 준다고 C# 
    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
    class BasicClass
    {
        static void Main(string[] args)
        {

        }
    }
}
