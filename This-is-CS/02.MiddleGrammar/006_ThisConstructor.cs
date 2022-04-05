using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 우리 자신을 지칭할 때 "나"라고 합니다. this는 객체가 자신을 지칭할 때 사용하는 키워드입니다.
// 객체 외부에서는 객체의 필드나 메소드에 접근할 때 객체의 이름(변수 또는 식별자)을 사용한다면, 객체 내부에서는 자신의 필드나
// 메소드에 접근할 때 this 키워드를 사용한다는 것입니다.

namespace _002.MiddleGrammar
{
    class MyClass
    {
        int a, b, c;

        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }

        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"MyClass({b})");
        }

        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass({b}), {c}");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a:{a}, b:{b}, c:{c}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();
            Console.WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            Console.WriteLine();

            MyClass c = new MyClass(10, 20);
            c.PrintFields();
        }
    }
}
